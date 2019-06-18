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
    public partial class FrmTest2 : Form
    {
        public FrmTest2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Inicializar);
        }

        private void Inicializar(object sender, EventArgs e)
        {
            /*Manejadora man = new Manejadora();
            MiDelegado delegado1 = new MiDelegado(Manejadora.Sumar);
            MiDelegado delegado2 = new MiDelegado(man.Restar);

            delegado1.Invoke(3, 5);//(explicita)
            delegado1(2, 5);//(implicita) Las dos hacen lo mismo.*/
            this.btnBoton1.Click += new System.EventHandler(this.MiManejador);
            //MessageBox.Show();
        }

        public void MiManejador(object sender, EventArgs e)
        {
            string aux = ((Control)sender).Name;

            MessageBox.Show(aux);
            if (aux == this.btnBoton1.Name)
            {
                this.btnBoton1.Click -= new System.EventHandler(this.MiManejador);
                this.btnBoton2.Click += new System.EventHandler(this.MiManejador);
            }
            else if (aux == this.btnBoton2.Name)
            {
                this.btnBoton2.Click -= new System.EventHandler(this.MiManejador);
                this.btnBoton3.Click += new System.EventHandler(this.MiManejador);
            }
            else
            {
                this.btnBoton3.Click -= new System.EventHandler(this.MiManejador);
                this.btnBoton1.Click += new System.EventHandler(this.MiManejador);
            }
        }

        private void btnBoton4_Click(object sender, EventArgs e)
        {
            Manejadora man = new Manejadora();
            MiDelegado delegado1 = new MiDelegado(Manejadora.Sumar);
            MiDelegado delegado2 = new MiDelegado(man.Restar);
            MiDelegado delegadoCombinado = new MiDelegado((MiDelegado)MiDelegado.Combine(delegado1, delegado2));
            MiDelegado delegado4 = new MiDelegado((MiDelegado)MiDelegado.Combine(delegadoCombinado, new MiDelegado(man.Multiplicar)));

            delegado1.Invoke(3, 5);//(explicita)
            delegado2(2, 5);//(implicita) Las dos llaman a Invoke.
            delegadoCombinado.Invoke(35,623);
            MessageBox.Show(delegado1.Method.ToString());
            MessageBox.Show(delegado2.Method.ToString());
            MessageBox.Show(delegadoCombinado.Method.ToString());
            //MessageBox.Show(delegado1.Target.ToString()); TIRA NULL EXCEPTION PORQUE ES ESTATICO
            MessageBox.Show(delegado2.Target.ToString());
            MessageBox.Show(delegadoCombinado.Target.ToString());
            
            foreach(Delegate item in delegado1.GetInvocationList())
            {
                MessageBox.Show(item.Method.ToString());
            }

            delegado4.Invoke(23, 52);

            OtraSuma(delegado1, 2, 5);
        }

        public void OtraSuma(MiDelegado a, int g, int b)
        {
            a.Invoke(g, b);
        }
    }
}
