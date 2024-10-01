using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tenant_BE;

namespace Tenant_BL
{
    public class Documento_BL
    {
        private string urlEndpoint;
        private Tenant_ADO.Documento_ADO _ado;

        public Documento_BL(string _urlEndPoint)
        {
            this.urlEndpoint = _urlEndPoint;
            _ado = new Tenant_ADO.Documento_ADO(urlEndpoint);
        }

        public List<Documento_BE> ListDocumento()
        {
            return _ado.ListDocumento();
        }
    }
}
