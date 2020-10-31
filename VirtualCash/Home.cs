using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualCash
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        #region Llamada a otro form

        private void AbrirFormHijo(object formHijo)
        {
            if (this.PnlForms.Controls.Count > 0)
            {
                this.PnlForms.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnlForms.Controls.Add(fh);
            this.PnlForms.Tag = fh;
            fh.Show();
        }

        private void BtnCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(formHijo: new FormMovimientos());
        }
        private void BtnTarjetas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(formHijo: new FormTarjetas());
        }

        private void BtnTienda_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Eventos

        #endregion

        private void BtnDesloguear_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
