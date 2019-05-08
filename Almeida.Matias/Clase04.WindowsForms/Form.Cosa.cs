using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_04;

namespace Clase04.WindowsForms
{
    public partial class Form1 : Form
    {
        Cosa obj = new Cosa();

        public Form1()
        {
            InitializeComponent();
           // MessageBox.Show("Hola jeje");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola jeje");
        }

        //Los cambios que se pueden hacer en tiempo de ejecucion
        //Hay que pausar la ejecucion del programa
        //

        private void button1_Click(object sender, EventArgs e)
        {
            Cosa objetoNuevo = new Cosa();
            MessageBox.Show(obj.Mostrar());
            this.button1.Text = "Crear una cosa bonita jeje";
            this.BackColor = Color.AliceBlue;
        }
    }
}
