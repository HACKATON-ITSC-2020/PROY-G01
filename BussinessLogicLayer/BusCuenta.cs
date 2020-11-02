using DataAccessLayer;
using Entities;

namespace BussinessLogicLayer
{
    public class BusCuenta
    {
        private DataCuenta _dataCuenta;

        public BusCuenta()
        {
            _dataCuenta = new DataCuenta();
        }

        public Cuenta TraerSaldos(Cuenta cuenta)
        {
            return _dataCuenta.TraerSaldos(cuenta);
        }

        public int GenerarCuenta(Cuenta cuenta)
        {
            return _dataCuenta.GenerarCuenta(cuenta);
        }

    }
}