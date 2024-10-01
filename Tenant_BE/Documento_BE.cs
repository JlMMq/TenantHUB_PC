using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant_BE
{
    public class Documento_BE
    {
        public int int_codDoc { get; set; }
        public string str_descrCorta { get; set; }
        public string str_descrLarga { get; set; }
        public int int_long { get; set; }
        public int int_tipo { get; set; }
        public int int_tipoContrib { get; set; }
        public int int_longExact { get; set; }
    }

    /* 
     LO:Longitud(int_long)

     T :Tipo(int_tipo)
         5 :Numérico
         0 :Alfanumérico

     C:Indicador de tipo de contribuyente(int_tipoContrib)
         0:Documento para nacionales solamente
         1:Documento para extranjeros solamente
         2:Documento para nacionales y extranjeros

     E:Indicador de longitud exacta(int_longExact)
         1:Longitud exacta
         0:Longitud máxima
     */
}
