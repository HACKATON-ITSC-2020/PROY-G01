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

namespace VirtualCash
{
    public partial class FormMovimientos : Form
    {

        #region Instancias

        private Movimiento _movimiento;
        private CommonClass _commonClass;
        private MetodosCompartidos _metodosCompartidos;

        #endregion


        #region Load
        public FormMovimientos()
        {
            InitializeComponent();
            _movimiento = new Movimiento();
            _commonClass = new CommonClass();
            _metodosCompartidos = new MetodosCompartidos();
        }

        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            CargarMovimientos();
            _metodosCompartidos.TraerSaldos();
            MostrarSaldos();
        }

        #endregion


        #region Metodos

        private void CargarMovimientos()
        {
            DtgMovimientos.Rows.Clear();
            _commonClass.CargarListaDemovimientos();
            if (_commonClass.DsTablaDeMovimientos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in _commonClass.DsTablaDeMovimientos.Tables[0].Rows)
                {
                    DtgMovimientos.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3]);
                }
            }
        }

        private void MostrarSaldos()
        {
            LblSaldoCC.Text = _metodosCompartidos.SaldoCC.ToString("G29");
            LblSaldoCH.Text = _metodosCompartidos.SaldoCH.ToString("G29");
        }


        #endregion

        #region Eventos

        #endregion

    }
}
