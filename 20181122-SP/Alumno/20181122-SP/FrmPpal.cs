using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;
using Patentes;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        private List<Thread> listaThreads;

        public FrmPpal()
        {
            InitializeComponent();
            this.listaThreads = new List<Thread>();
            this.cola = new Queue<Patente>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.vistaPatente1.finExposicion += new FinExposicionPatente(ProximaPatente);
            this.vistaPatente2.finExposicion += new FinExposicionPatente(ProximaPatente);
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            Xml<Queue<Patente>> nuevo = new Xml<Queue<Patente>>();
            nuevo.Leer("Patentes.xml", out this.cola);
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                Texto nuevo = new Texto();
                nuevo.Leer("Patentes.txt", out this.cola);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSql_Click(object sender, EventArgs e)
        {

        }

        private void FinalizarSimulacion()
        {
            foreach (Thread item in this.listaThreads)
            {
                if (item != null && item.IsAlive)
                    item.Abort();
            }
        }

        public void ProximaPatente(object patente)
        {
            if(this.cola.Count > 0)
            {
                Thread hiloNuevo = new Thread(((VistaPatente)patente).MostrarPatente);
                hiloNuevo.Start(this.cola.Dequeue());
                this.listaThreads.Add(hiloNuevo);
            }
        }

        private void IniciarSimulacion()
        {
            FinalizarSimulacion();
            ProximaPatente(this.vistaPatente1);
            ProximaPatente(this.vistaPatente2);
        }
    }
}
