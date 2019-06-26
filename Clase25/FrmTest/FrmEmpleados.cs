using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace FrmTest
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
            this.comboBox1.Items.Add(ETipoManejador.LimiteSueldo);
            this.comboBox1.Items.Add(ETipoManejador.Log);
            this.comboBox1.Items.Add(ETipoManejador.Ambos);
        }     

        public void EmpleadoMejorado_LimiteSueldo(EmpleadoMejorado e, EmpleadoSueldoArgs a)
        {
            MessageBox.Show(e.Nombre + " - " + e.Legajo.ToString() + "\nSe le quizo asignar el sueldo: " + a.Sueldo.ToString());
        }

        public void EmpleadoMejorado_Log_LimiteSueldo(EmpleadoMejorado e, EmpleadoSueldoArgs a)
        {
            try
            {
                StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\archivoForm.log");

                writer.Write(DateTime.Now + " - " + e.ToString());
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text != "" && this.textBox2.Text != "" && this.textBox3.Text != "" && this.comboBox1.SelectedItem != null)
            {
                EmpleadoMejorado emp = new EmpleadoMejorado();

                switch ((ETipoManejador)this.comboBox1.SelectedItem)
                {
                    case ETipoManejador.LimiteSueldo:
                        emp._LimiteSueldo += new DelSueldo(EmpleadoMejorado_LimiteSueldo);
                        break;
                    case ETipoManejador.Log:
                        emp._LimiteSueldo += new DelSueldo(EmpleadoMejorado_Log_LimiteSueldo);
                        break;
                    case ETipoManejador.Ambos:
                        emp._LimiteSueldo += new DelSueldo(EmpleadoMejorado_LimiteSueldo);
                        emp._LimiteSueldo += new DelSueldo(EmpleadoMejorado_Log_LimiteSueldo);
                        break;
                    default:
                        break;
                }

                emp.Nombre = this.textBox3.Text;
                emp.Legajo = int.Parse(this.textBox2.Text);
                emp.Sueldo = float.Parse(this.textBox1.Text);
            }
            else
            {
                MessageBox.Show("No lleno los campos necesarios.");
            }
                
        }
    }
}
