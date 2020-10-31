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
        private Movimiento _movimiento;        
        private CommonClass _commonClass;

        public FormMovimientos()
        {
            InitializeComponent();
            _movimiento = new Movimiento();
            _commonClass = new CommonClass();
        }

        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            CargarMovimientos();
        }

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

        #endregion

    }
}
