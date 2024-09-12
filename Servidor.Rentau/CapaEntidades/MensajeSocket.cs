using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    [Serializable]
    public class MensajeSocket<T>
    {
        public string Metodo { get; set; }
        public T Entidad { get; set; }
    }
}
