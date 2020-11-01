using System.Net.Cache;

namespace Entities
{
    public class Titular
    {
        public int Id { get; set; }
        public string Adicional { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string CUIL { get; set; }
        public string DNI { get; set; }
        public string Contacto { get; set; }
        public string ContactoAlternativo { get; set; }
        public string Correo { get; set; }

        public string Clave { get; set; }
        public string Estado { get; set; }
    }
}
