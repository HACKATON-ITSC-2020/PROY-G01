using BussinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCash
{
    public class MetodosCompartidos
    {

        #region Instancias
        private Titular _titular;
        private BusTitular _busTitular;
        private Cuenta _cuenta;
        private BusCuenta _busCuenta;

        #endregion

        public MetodosCompartidos()
        {
            _titular = new Titular();
            _busTitular = new BusTitular();
            _cuenta = new Cuenta();
            _busCuenta = new BusCuenta();
        }

        #region Variables
        public int longitud = 6;
        public string clave;
        public string correo;
        public bool Correcta;
        public int SaldoCC;
        public int SaldoCH;
        #endregion

        #region Metodos
        public void GenerarPassword()
        {
            clave = string.Empty;
            string[] letras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n",
                                "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
                                "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            Random EleccionAleatoria = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int LetraAleatoria = EleccionAleatoria.Next(0, 50);
                int NumeroAleatorio = EleccionAleatoria.Next(0, 9);


                if (LetraAleatoria < letras.Length)
                {
                    clave += letras[LetraAleatoria] + NumeroAleatorio.ToString();
                }
            }
        }

        public void ConsultarTitular()
        {
            _titular = _busTitular.ConsultarTitular(correo, clave);

            if (_titular.Correo == correo &&
                _titular.Clave == clave)
            {
                Correcta = true;
            }
            else
            {
                Correcta = false;
            }
        }


        public void TraerSaldos()
        {
            _busCuenta.TraerSaldos(_cuenta);
            _cuenta.SaldoCC = SaldoCC;
            _cuenta.SaldoCH = SaldoCH;
        }
        #endregion


    }
}
