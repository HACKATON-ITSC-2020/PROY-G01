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

        #region variables

        string contraseña = string.Empty;
        int longitud;

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
            GenerarPassword();
            _titular.Clave = contraseña;
            _titular.Estado = "Pendiente";
            _busTitular.SaveTitular(_titular);
        }

        private void GenerarPassword()
        {
            string[] letras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            Random EleccionAleatoria = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int LetraAleatoria = EleccionAleatoria.Next(0, 100);
                int NumeroAleatorio = EleccionAleatoria.Next(0, 9);

                if (LetraAleatoria < letras.Length)
                {
                    contraseña += letras[LetraAleatoria];
                }
                else
                {
                    contraseña += NumeroAleatorio.ToString();
                }
            }            
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
            Registro _registro = new Registro();
            Login _login = new Login();
            _registro.Close();
            _login.Show();
        }
    }
}