using System;
using System.Data.SqlClient;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("MyConnectString");
            SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            /*
            And
            Sqlconnection conn = new sqlconnection(Myconnectstring);
            Sqlcommand cmd = new sqlcommand(“sp_Myproc”, conn);
           

            using(conn)
            conn.Open();
            cmd.ExecuteNonQuery();
            
            */

            //Exceptions are being thrown
        }
    }
}
