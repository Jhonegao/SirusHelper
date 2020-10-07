using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //verificar
   class DBAcess : IDisposable
    {                
        static SqlConnection connection = new SqlConnection();
        public static SqlConnection Conexao
        {
            get { return connection; }
        }
        public static void OpenConnection()
        {
            string ConnectionSring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\entra21\Documents\dbSirus.mdf; Integrated Security = True; Connect Timeout = 30";
            connection.ConnectionString = ConnectionSring;
            connection.Open();
        }
        public static void CloseConnection()
        {
            connection.Close();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
