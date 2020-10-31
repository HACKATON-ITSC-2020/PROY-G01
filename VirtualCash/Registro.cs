using AdminInterno;
using BussinessLogicLayer;
using Entities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace VirtualCash
{
    public partial class Registro : Form
    {
        #region Instancias

        private Titular _titular = new Titular();
        private BusTitular _busTitular = new BusTitular();

        #endregion

        public Registro()
        {
            InitializeComponent();
        }


        #region Metodos


       


        private void SendDataTitular()
        {
            _titular.Apellido = txtApellido.Text;
            _titular.Nombre = txtNombre.Text;
            _titular.CUIL = txtCuil.Text;
            _titular.DNI = txtDNI.Text;
            _titular.Contacto = txtContacto.Text;
            _titular.ContactoAlternativo = txtAlernativo.Text;
            _titular.Correo = txtCorreo.Text;
            if (rbtnSI.Checked)
            {
                _titular.Adicional = "Si";
            }
            else
            {
                _titular.Adicional = "No";
            }
            _busTitular.SavePosibleTitular(_titular);
        }

        private void ClearTemplate()
        {
            foreach (Control tex in this.Controls)
            {
                if (tex is TextBox)
                {
                    tex.Text = string.Empty;
                }
            }
        }

        #endregion


        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            SendDataTitular();
            ClearTemplate();
            Admin form2 = new Admin();
            form2.Show();
        }
    }
}
