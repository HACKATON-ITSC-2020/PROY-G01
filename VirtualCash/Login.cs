using BussinessLogicLayer;
using Entities;
using System.Drawing;
using System.Windows.Forms;

namespace VirtualCash
{
    public partial class Login : Form
    {

        #region Instancias
        Home _home = new Home();
        private Titular _titular;
        private BusTitular _busTitular;
        private MetodosCompartidos _metodosCompartidos;

        #endregion

        public Login()
        {
            InitializeComponent();
            _busTitular = new BusTitular();
            _titular = new Titular();
            _metodosCompartidos = new MetodosCompartidos();
        }

        #region Variables
        private bool Vacio;
        private bool IniciarSesion = true;
        #endregion

        #region Metodos

        private void RestablecerClave()
        {
            LinkNuevoRegistro.Visible = false;
            LinkReestablecerClave.Visible = false;
            LblCorreo.Text = "Ingresá tu correo";
            TxtClave.Visible = false;
            TxtClave.Enabled = false;
            LblClave.Visible = false;
            BtnIniciarSesion.Location = new Point(26, 106);
            BtnIniciarSesion.Text = "Solicitar nueva clave";
            IniciarSesion = false;
        }

        private void LogIn()
        {
            LinkNuevoRegistro.Visible = true;
            LinkReestablecerClave.Visible = true;
            LblCorreo.Text = "Correo electrónico";
            TxtClave.Visible = true;
            TxtClave.Enabled = true;
            LblClave.Visible = true;
            BtnIniciarSesion.Location = new Point(26, 191);
            BtnIniciarSesion.Text = "Iniciar Sesión";
            IniciarSesion = true;
        }

        private void EmptyStringVerification()
        {
            if (IniciarSesion)
            {
                foreach (Control text in this.Controls)
                {
                    if (text is TextBox)
                    {
                        if (string.IsNullOrEmpty(text.Text))
                        {
                            Vacio = true;
                            AvisoDeCamposVacios();
                        }
                        else
                        {
                            Vacio = false;
                        }
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(TxtCorreo.Text))
                {
                    Vacio = true;
                    AvisoDeCamposVacios();
                }
                else
                {
                    Vacio = false;
                }
            }
        }

        private void AvisoDeCamposVacios()
        {
            MessageBox.Show("Todos los campos son obligatorios", "Campos vacíos", MessageBoxButtons.OK);
        }

        private void AvisoDeDatosIncorrectos()
        {
            MessageBox.Show("Por favor, revise que los datos sean correctos","Datos Incorrectos",MessageBoxButtons.OK);
        }

        #endregion


        #region Eventos
        private void LinkNuevoRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro _registro = new Registro();
            _registro.ShowDialog();
        }

        private void LinkReestablecerClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RestablecerClave();
        }

        private void BtnIniciarSesion_Click(object sender, System.EventArgs e)
        {
            EmptyStringVerification();
            if (IniciarSesion)
            {
                if (Vacio)
                {
                    AvisoDeCamposVacios();
                }
                else
                {
                    _metodosCompartidos.correo = TxtCorreo.Text;
                    _metodosCompartidos.clave = TxtClave.Text;
                    _metodosCompartidos.ConsultarTitular();
                    if (_metodosCompartidos.Correcta)
                    {
                        _home.Show();
                        this.Hide();
                    }
                    else
                    {
                        AvisoDeDatosIncorrectos();
                    }
                }
            }
            else
            {
                _metodosCompartidos.GenerarPassword();
                _titular.Clave = _metodosCompartidos.clave;
                _titular.Correo = TxtCorreo.Text;
                _busTitular.RestablecerClave(_titular);
                LogIn();
            }
        }

        #endregion
    }
}