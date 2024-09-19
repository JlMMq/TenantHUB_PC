using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant_BL
{
    public class System_BL
    {
        private string urlEndpoint;
        private Tenant_ADO.System_ADO _ado;
        public System_BL(string _urlEndPoint)
        {
            this.urlEndpoint = _urlEndPoint;
            _ado = new Tenant_ADO.System_ADO(urlEndpoint);
        }

        public bool RunningService(string url)
        {
            return _ado.RunningService(url);
        }
    }
}
