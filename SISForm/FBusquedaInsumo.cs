using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISBll;
using SISModels;

namespace SISForm
{
    public partial class FBusquedaInsumo : Form
    {
        public FBusquedaInsumo()
        {
            InitializeComponent();
            SISBll.INSUMO.Insumo _insumoBll = new SISBll.INSUMO.Insumo();        
            dataGridViewInsumo.DataSource = _insumoBll.getAllVieW(); 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SISBll.INSUMO.Insumo _insumoBll = new SISBll.INSUMO.Insumo();
            dataGridViewInsumo.DataSource = _insumoBll.getASearch(txtBuscqueda.Text.Trim());
        }

        private void btnFventaFacturar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnFventaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewInsumo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewInsumo.SelectedRows.Count > 0) {
                FVenta frm = Owner as FVenta;
                frm.txtFventaId.Text = dataGridViewInsumo.SelectedRows[0].Cells[0].Value.ToString();
                frm.txtFventaPrecio.Text = dataGridViewInsumo.SelectedRows[0].Cells[3].Value.ToString();
                frm.txtFventaDescsripcion.Text = dataGridViewInsumo.SelectedRows[0].Cells[1].Value.ToString();
                this.Close();
            }
        
        }
    }
}
