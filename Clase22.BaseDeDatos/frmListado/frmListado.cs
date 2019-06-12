using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace frmListado
{
    public partial class frmListado : Form
    {
        private List<Persona> _personas;
        private DataTable _tabla;

        public frmListado()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            AccesoDatos.AccesoDatos datos = new AccesoDatos.AccesoDatos();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this._personas = new List<Persona>();
            this._personas = datos.TraerTodos();
            this._tabla = datos.TraerTablaPersonas();
            //this.dataGridView1.DataSource = this._personas; no me funciono con personas, quizas sea la version del visual studio
            this.dataGridView1.DataSource = this._tabla;
        }
    }
}
