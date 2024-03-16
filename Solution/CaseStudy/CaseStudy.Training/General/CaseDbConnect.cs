using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Training.General
{
    public class CaseDbConnect
    {
        public static string CaseConnect()
        {
            string ConnectionString = "Server=GNB028;Database=Deneme;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;";
            SqlConnection Connect = new SqlConnection();
            Connect.ConnectionString = ConnectionString;
            if(Connect.State == System.Data.ConnectionState.Closed) Connect.Open(); 
            return Connect.State.ToString();
        }
    }
}