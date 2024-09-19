using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tenant_BE;


namespace Tenant.conf
{
    public class jsconfig
    {
        private static readonly string fileName = "config.json";
        private string folderPath = Path.Combine(Application.StartupPath,"routes");

        public void SaveConfig(url_conf _jsconf)
        {
            try
            {
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

                string filePath = Path.Combine(folderPath,fileName);
                string json = JsonConvert.SerializeObject(_jsconf, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch(Exception ex)
            {

            } 
        }

        public url_conf ReadConfig()
        {
            url_conf _jsconf = new url_conf
            {
                urlService = "0",
                urlFiles = "0"
            };
           
            try
            {
                string filePath = Path.Combine(folderPath,fileName);
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    _jsconf = JsonConvert.DeserializeObject<url_conf>(json);
                }
                else
                {
                    SaveConfig(_jsconf);
                    throw new Exception("No se encontro el archivo de la configuracion.");
                }    
            }
            catch(Exception ex)
            {

            }
            return _jsconf;
        }
    }
 }
