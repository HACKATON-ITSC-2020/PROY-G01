using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BusTipoMovimiento
    {
        private DataTipoMovimiento _dataTipoMovimiento;

        public BusTipoMovimiento()
        {
            _dataTipoMovimiento = new DataTipoMovimiento();
        }

        public DataTable TraerTipoMovimiento()
        {
            return _dataTipoMovimiento.TraerTipoMovimiento();
        }
    }
}
