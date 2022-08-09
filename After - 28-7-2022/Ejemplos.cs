using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeClase
{
    public class Ejemplos : IEjemplos
    {
        public string ConseguirNombre()
        {
            throw new NotImplementedException();
        }
    }

    public interface IEjemplos
    {
        string ConseguirNombre();
    }

    public class TrabajoEjemplo
    {
        private readonly IEjemplos _ejemplos;


        void Ejemplo()
        {
            _ejemplos.ConseguirNombre();
        }
    }
}
