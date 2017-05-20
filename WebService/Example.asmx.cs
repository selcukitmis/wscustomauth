using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace WebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Example : System.Web.Services.WebService
    {
        List<string> values;

        public Example()
        {
            values = new List<string>();
            values.Add("İstanbul");
            values.Add("Ankara");
            values.Add("İzmir");
            values.Add("Adana");
        }

        public CustomAuthentication customAuth;

        [WebMethod]
        [SoapHeader("customAuth")]
        public List<string> GetCities()
        {
            if (customAuth == null)
            {
                return null;
            }

            if (customAuth.Username == "Demo" && customAuth.Password == "Pass123")
            {
                return values;
            }

            return null;
        }

        [WebMethod]
        [SoapHeader("customAuth")]
        public List<string> AddCity(string name)
        {
            if (customAuth == null)
            {
                return null;
            }

            if (customAuth.Username == "Demo" && customAuth.Password == "Pass123")
            {
                if (!values.Contains(name))
                {
                    values.Add(name);
                }
                return values;
            }

            return null;
        }

        [WebMethod]
        [SoapHeader("customAuth")]
        public List<string> RemoveCity(string name)
        {
            if (customAuth == null)
            {
                return null;
            }

            if (customAuth.Username == "Demo" && customAuth.Password == "Pass123")
            {
                if (values.Contains(name))
                {
                    values.Remove(name);
                }
                return values;
            }

            return null;
        }
    }
}
