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
    public partial class FVenta : Form
    {
        public FVenta()
        {
            InitializeComponent();
        }
        private SISBll.INSUMO.Insumo _insumobll = new SISBll.INSUMO.Insumo();
        private SISBll.FACTURA.Factura _facturabll = new SISBll.FACTURA.Factura();
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFventaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FVenta_Load(object sender, EventArgs e)
        {
            this.Opacity = 90;
            //INICIALIZAR 
            addColumms();
            txtTotal.Text = "0";


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FBusquedaInsumo _formBusqueda = new FBusquedaInsumo();
            AddOwnedForm(_formBusqueda);
            _formBusqueda.Show();
        }

        private void  addColumms(){
            listView1.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("DESCRIPCION", 400, HorizontalAlignment.Left);
            listView1.Columns.Add("PRECIO UNIDAD", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("CANTIDAD", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("SUB TOTAL", 100, HorizontalAlignment.Left);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = txtFventaId.Text;
            lvi.SubItems.Add(txtFventaDescsripcion.Text);
            lvi.SubItems.Add(txtFventaPrecio.Text);
            lvi.SubItems.Add(txtCantidad.Text);
            Decimal subtotal = Convert.ToDecimal(txtFventaPrecio.Text) * Convert.ToDecimal(txtCantidad.Text);
            lvi.SubItems.Add(txtFventaPrecio.Text);
            lvi.SubItems.Add(subtotal.ToString());
            listView1.Items.Add(lvi);
            txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) + subtotal).ToString();
        }

        private void txtCantidad_TabStopChanged(object sender, EventArgs e)
        {
        
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCantidad.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtCantidad.Text = txtCantidad.Text.Remove(txtCantidad.Text.Length - 1);
            }
        }

        private void btnFventaFacturar_Click(object sender, EventArgs e)
        {

            SISModels.FACTURA _factura = new SISModels.FACTURA();
             List<SISModels.FACTURA_DETALLE_POS> list = new List<SISModels.FACTURA_DETALLE_POS>();
            try
            {
                _factura.CLIENTE_NOMBRE = txtNombre.Text;
                _factura.CLIENTE_EMAIL = txtEmail.Text;
                _factura.CLIENTE_TELEFONO = txtTelefono.Text;
                _factura.FECHA = new DateTime();
                _factura.ESTADO = "FACTURADO";
                _factura.TOTAL = Convert.ToDecimal(txtTotal.Text);

                 for (int i = 0; i < listView1.Items.Count; i++)
                {
                    SISModels.FACTURA_DETALLE_POS _detalle = new SISModels.FACTURA_DETALLE_POS();
                    _detalle.INSUMO_ID = Convert.ToInt16(listView1.Items[i].SubItems[0].Text);
                    _detalle.PRECIO_UNITARIO = Convert.ToDecimal(listView1.Items[i].SubItems[2].Text);
                    _detalle.CANTIDAD = Convert.ToInt16(listView1.Items[i].SubItems[3].Text);
                    list.Add(_detalle);
                }
                _factura.FACTURA_DETALLE_POS = list;
                _facturabll.save(_factura);
                FAlert frm = new FAlert();
                frm.lblFAlertText.Text = "Operacion Exitosa";
                frm.Show();
                  
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
