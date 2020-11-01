using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCash
{
    public class CommonClass
    {
        #region Instancias
        private BusMovimiento _busMovimiento;
        public DataSet DsTablaDeMovimientos = new DataSet();
        #endregion

        public CommonClass()
        {
            _busMovimiento = new BusMovimiento();
        }

        #region Variables públicas


        #endregion


        #region Metodos

        public void CargarListaDemovimientos()
        {
            DsTablaDeMovimientos = _busMovimiento.UltimosMovimientos();
        }
        #endregion


    }
}
