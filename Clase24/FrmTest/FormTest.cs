using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTest
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            Manejadora man = new Manejadora();
            InitializeComponent();
            //this.btnBoton.Click += new System.EventHandler(Manejadora.Manejador);
            //this.lblEtiqueta.Click += new System.EventHandler(Manejadora.Manejador);
            this.btnBoton.Click += new System.EventHandler(Manejadora.Manejador);
            this.lblEtiqueta.Click += new System.EventHandler(man.ManejadorInstancia);
        }

        private void MostrarMensaje(object sender, EventArgs e)
        {            
            MessageBox.Show("Evento click del boton");
            //this.lblEtiqueta.Click += new System.EventHandler(this.lblEtiqueta_Click);
            //this.txtCuadroTexto.Click += new System.EventHandler(this.txtCuadroTexto_Click);
        }

        private void lblEtiqueta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click desde el label");
            //this.lblEtiqueta.Click -= new System.EventHandler(this.lblEtiqueta_Click);
        }

        private void txtCuadroTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento del textBox");
        }
    }

    public class Manejadora
    {
        public static void Manejador(object sender, EventArgs e)
        {
            MessageBox.Show("Estoy en el manejador estatico de la clase manejadora");
        }

        public void ManejadorInstancia(object sender, EventArgs e)
        {
            MessageBox.Show("Estoy en el metodo de instancia de la clase manejador");

            if (sender is Label)
                MessageBox.Show("El sender es " + sender.ToString());
            else if (sender is TextBox)
                MessageBox.Show("El sender es de tipo textbox");
            else
                MessageBox.Show("El sender es " + sender.ToString());
        }

        public static void Sumar(int a, int b)
        {
            MessageBox.Show((a + b).ToString());
        }

        public void Restar(int a, int b)
        {
            MessageBox.Show((a - b).ToString());
        }

        public void Multiplicar(int a, int b)
        {
            MessageBox.Show((a*b).ToString());
        }
    }
}
