using DataAccessLayer;
using Entities;

namespace BussinessLogicLayer
{
    public class BusTarjeta
    {
        private DataTarjeta _dataTarjeta;

        public BusTarjeta()
        {
            _dataTarjeta = new DataTarjeta();
        }

        public int GenerarTarjeta(string Tipotarjeta, Tarjeta tarjeta)
        {
            return _dataTarjeta.GenerarTarjeta(Tipotarjeta, tarjeta);
        }

    }
}