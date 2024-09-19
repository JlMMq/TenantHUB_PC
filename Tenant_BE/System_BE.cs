using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant_BE
{
    public class System_BE
    {

    }

    public class GenericMessage
    {
        public int cod { get; set; }
        public string msm { get; set; }
        public int vx1 {  get; set; }
        public int vx2 { get; set; }
        public string tx1 { get; set; }
        public string tx2 { get; set; }
    }

    public class url_conf
    {
        public string urlService { get; set; }
        public string urlFiles { get; set; }
    }
}

