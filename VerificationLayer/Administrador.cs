using BussinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificationLayer
{
    public partial class Administrador : Form
    {
        #region Instacias

        private BusTitular _busTitular;
        private Titular _titular;
        private BusTipoMovimiento _busTipoMovimiento;
        private Movimiento _movimiento;
        private Cuenta _cuenta;
        private BusCuenta _busCuenta;
        private Tarjeta _tarjeta;
        private BusTarjeta _busTarjeta;

        #endregion

        public Administrador()
        {
            InitializeComponent();
            _busTitular = new BusTitular();
            _titular = new Titular();
            _busTipoMovimiento = new BusTipoMovimiento();
            _movimiento = new Movimiento();
            _cuenta = new Cuenta();
            _busCuenta = new BusCuenta();
            _tarjeta = new Tarjeta();
            _busTarjeta = new BusTarjeta();
        }
        private void Administrador_Load(object sender, EventArgs e)
        {
            AceptacionesPendientes();
            CargarTipoMovimiento();
        }

        #region Variables
        private int Next = 0;
        private int PosibleTitularId;
        private string vApellido;
        private string vNombre;
        private string vCUIL;
        private string vDNI;
        private string vContacto;
        private string vAlternativo;
        private string vCorreo;
        private string vAdicional;
        private string Tipo;
        #endregion

        #region Metodos

        private void AceptacionesPendientes()
        {
            DtgTitularesPendientes.Rows.Clear();
            DataSet DsTablaDeTitulares = new DataSet();
            DsTablaDeTitulares = _busTitular.ListadoTitularesPendientes();

            if (DsTablaDeTitulares.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in DsTablaDeTitulares.Tables[0].Rows)
                {
                    DtgTitularesPendientes.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3]);
                }
            }
        }

        private void CargarTipoMovimiento()
        {
            DataTable dt = _busTipoMovimiento.TraerTipoMovimiento();
            cmbTipoMovimiento.DataSource = dt;
            cmbTipoMovimiento.DisplayMember = "Descripcion";
        }


        #endregion

        #region Eventos



        #endregion

        private void RbTarjetaY_CheckedChanged(object sender, EventArgs e)
        {
            CmbTarjetas.Enabled = true;
        }

        private void RbTarjetaN_CheckedChanged(object sender, EventArgs e)
        {
            CmbTarjetas.Enabled = false;
        }

        private void TxtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se teclean los digitos
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (TxtImporte.Text.Contains(",") || TxtImporte.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                //con esto se desactivan todas las otras teclas no contempladas en las líneas anteriores
                e.Handled = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _movimiento.Importe = Convert.ToDecimal(TxtImporte.Text);
            _movimiento.Fecha = dtpFecha.Value;
            _movimiento.CuotasTotales = Convert.ToInt32(cmbCuotas.SelectedItem);
            _movimiento.CuotasPagas = Convert.ToInt32(cmbCuotas.SelectedItem);
            if (RbTarjetaY.Checked)
            {
                _movimiento.TarjetaId = CmbTarjetas.SelectedIndex + 1;
            }
        }

        private void DtgTitularesPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)DtgTitularesPendientes.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() != string.Empty)
            {
                _titular.Id = int.Parse(DtgTitularesPendientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                PosibleTitularId = int.Parse(DtgTitularesPendientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                _busTitular.ConsultarTitularPendiente(_titular);
                TraerDatosPosibleTitular();

            }
            TabAdministrador.SelectedIndex = Next + 2;
        }

        private void TraerDatosPosibleTitular()
        {
            //_titular = _busTitular.ConsultarTitularPendiente();
            //PosibleTitularId = _titular.Id;
            //TxtApellidoVerificacion.Text = vApellido;
            //TxtNombreVerificacion.Text = vNombre;
            //TxtCUILVerificacion.Text = vCUIL;
            //TxtDNIVerificacion.Text = vDNI;
            //TxtContactoVerificacion.Text = vContacto;
            //TxtAlternativoVerificacion.Text = vAlternativo;
            //TxtCorreoVerificacion.Text = vCorreo;
            //TxtAdicionarVerificacion.Text = vAdicional;
        }


        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            _busTitular.BuscarCoincidencias(PosibleTitularId, _titular);

            TxtApellidoCoincidencia.Text = Convert.ToString(_titular.Id);
        }

        private void CargaDeTitular()
        {
            TxtApellidoVerificacion.Text = vApellido;
            TxtNombreVerificacion.Text = vNombre;
            TxtCUILVerificacion.Text = vCUIL;
            TxtDNIVerificacion.Text = vDNI;
            TxtContactoVerificacion.Text = vContacto;
            TxtAlternativoVerificacion.Text = vAlternativo;
            TxtCorreoVerificacion.Text = vCorreo;
            TxtAdicionarVerificacion.Text = vAdicional;
        }

        private void BtnGenerarCuenta_Click(object sender, EventArgs e)
        {
            TxtIdTitular.Text = Convert.ToString(PosibleTitularId);
        }

        private void BtnGenerarCuenta_Click_1(object sender, EventArgs e)
        {
            GenerarCuenta();
            GenerarTarjetaDebito();
            GenerarTarjetaVisa();
            GenerarTarjetaAmex();
        }
        private void GenerarCuenta()
        {
            _cuenta.NroCuenta = Convert.ToInt32(TxtCuenta.Text);
            _cuenta.CVU = Convert.ToInt32(TxtCVU.Text);
            _cuenta.Alias = TxtAlias.Text;
            _cuenta.TitularId = Convert.ToInt32(TxtIdTitular.Text);
            _cuenta.LimiteDescubierto = Convert.ToDecimal(TxtLimite.Text);
            _busCuenta.GenerarCuenta(_cuenta);
        }
        private void GenerarTarjetaDebito()
        {
            Tipo = "Debito";
            _tarjeta.NroTarjeta = Convert.ToInt32(TxtDebito.Text);
            _tarjeta.clave = Convert.ToInt32(TxtClaveDebito.Text);
            _tarjeta.TitularId = Convert.ToInt32(TxtIdTitular.Text);
            _tarjeta.TipoTarjeta = Tipo;
            _busTarjeta.GenerarTarjeta(Tipo, _tarjeta);
        }
        private void GenerarTarjetaVisa()
        {
            Tipo = "Credito";
            _tarjeta.NroTarjeta = Convert.ToInt32(TxtCreditoVisa.Text);
            _tarjeta.clave = Convert.ToInt32(TxtClaveVisa.Text);
            _tarjeta.TitularId = Convert.ToInt32(TxtIdTitular.Text);
            _tarjeta.TipoTarjeta = Tipo;
            _tarjeta.MaxCuotas = Convert.ToInt32(TxtMaxCuotasVisa.Text);
            _tarjeta.InteresMensual = Convert.ToDecimal(TxtInteresMensualVisa.Text);
            _tarjeta.LimiteCompra = Convert.ToDecimal(TxtLimiteDeCompraVisa.Text);
            _busTarjeta.GenerarTarjeta(Tipo, _tarjeta);
        }

        private void GenerarTarjetaAmex()
        {
            Tipo = "Credito";
            _tarjeta.NroTarjeta = Convert.ToInt32(TxtCreditoAmex.Text);
            _tarjeta.clave = Convert.ToInt32(TxtClaveAmex.Text);
            _tarjeta.TitularId = Convert.ToInt32(TxtIdTitular.Text);
            _tarjeta.TipoTarjeta = Tipo;
            _tarjeta.MaxCuotas = Convert.ToInt32(TxtMaxCuotasAmex.Text);
            _tarjeta.InteresMensual = Convert.ToDecimal(TxtInteresMensualAmex.Text);
            _tarjeta.LimiteCompra = Convert.ToDecimal(TxtLimiteAmex.Text);
            _busTarjeta.GenerarTarjeta(Tipo, _tarjeta);
        }
    }
}