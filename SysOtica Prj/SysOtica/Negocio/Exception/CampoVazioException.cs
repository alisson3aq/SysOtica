using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Exception
{
    public class CampoVazioException : System.Exception
    {
        public CampoVazioException() : base() { }
        public CampoVazioException(string message) : base(message) { }
        public CampoVazioException(string message, System.Exception inner) : base(message, inner) { }
        protected CampoVazioException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }

    }
}
