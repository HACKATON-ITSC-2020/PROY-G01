using DataAccessLayer;
using System.Data;

namespace BussinessLogicLayer
{
    public class BusMovimiento
    {
        private DataMovimiento _dataMovimiento;
        public BusMovimiento()
        {
            _dataMovimiento = new DataMovimiento();
        }


        public DataSet UltimosMovimientos()
        {
            return _dataMovimiento.UltimosMovimientos();
        }
    }
}