using DataAccessLayer;
using Entities;
using System.Data;

namespace BussinessLogicLayer
{
    public class BusTitular
    {
        #region Instancias
        private DataTitular _dataTitular;
        #endregion

        public BusTitular()
        {
            _dataTitular = new DataTitular();
        }

        public int SaveTitular(Titular _titular)
        {
            return _dataTitular.SaveTitular(_titular);
        }

        public DataSet ListadoTitularesPendientes()
        {
            return _dataTitular.ListadoTitularesPendientes();
        }

        public int RestablecerClave(Titular _titular)
        {
            return _dataTitular.RestablecerClave(_titular);
        }

        public Titular ConsultarTitular(string correo, string clave)
        {
            return _dataTitular.ConsultarTitular(correo, clave);
        }

        public Titular ConsultarTitularPendiente(Titular titular)
        {
            return _dataTitular.ConsultarTitularPendiente(titular);
        }

        public Titular BuscarCoincidencias(int PosibleTitularId, Titular _titular)
        {
            return _dataTitular.BuscarCoincidencias(PosibleTitularId, _titular);
        }
    }
}