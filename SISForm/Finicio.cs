using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SISForm
{
    public partial class Finicio : Form
    {
        public Finicio()
        {
            InitializeComponent();
            AbrirFormulario<FDashboard>();
            Opacity = 0.7D;
         
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Finicio_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            loadCultureInfo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void panelformularios_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }
        private void btnFventaVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FVenta>();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnFventaInforme_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = true;
        }

        private void btnFventaVentas_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = false ;
        }

        private void btnFventaProductos_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FDashboard>();
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tmFechaHora_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void lbFecha_Click(object sender, EventArgs e)
        {

        }
        private void loadCultureInfo() {
            btnFventaVenta.Text = Res.btnFventaVenta;
        }
    }
}
