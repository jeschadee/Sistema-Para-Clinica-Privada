using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    /// <summary>
    /// Exepcion personalizada
    /// </summary>
    class MiExepcion : Exception
    {
        public MiExepcion(string message) : base(message)
        {
        }

        public MiExepcion(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
