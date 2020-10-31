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

        public int SavePosibleTitular(Titular _titular)
        {
            return _dataTitular.SavePosibleTitular(_titular);
        }

        public DataSet listadoPosiblesTitulares(string cual)
        {
            return _dataTitular.listadoPosiblesTitulares(cual);
        }
    }
}