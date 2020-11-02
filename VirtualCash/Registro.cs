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

        Login login = new Login();
        private Titular _titular;
        private BusTitular _busTitular;
        private MetodosCompartidos _metodosCompartidos;

        #endregion

        public Registro()
        {
            InitializeComponent();
            _busTitular = new BusTitular();
            _titular = new Titular();
            _metodosCompartidos = new MetodosCompartidos();
            login.Close();
        }

        #region variables


        #endregion

        #region Metodos
        private void SendDataTitular()
        {
            _titular.Apellido = TxtApellido.Text;
            _titular.Nombre = TxtNombre.Text;
            _titular.CUIL = TxtCUIL.Text;
            _titular.DNI = TxtDNI.Text;
            _titular.Contacto = TxtContacto.Text;
            _titular.ContactoAlternativo = TxtAlternativo.Text;
            _titular.Correo = TxtCorreo.Text;
            if (RbYes.Checked)
            {
                _titular.Adicional = "Si";
            }
            else
            {
                _titular.Adicional = "No";
            }
            _metodosCompartidos.GenerarPassword();
            _titular.Clave = _metodosCompartidos.clave;
            _titular.Estado = "P";
            _busTitular.SaveTitular(_titular);
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

        #region Eventos
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            SendDataTitular();
            ClearTemplate();

            DialogResult _dialogResult = MessageBox.Show("Datos Enviados! A la brevedad vas a recibir un correo con una clave para ingresar a tu cuenta.", "Datos completados", MessageBoxButtons.OK);
            if (_dialogResult == DialogResult.OK)
            {
                Registro registro = new Registro();
                registro.Close();
            }
        }

        #endregion
    }
}