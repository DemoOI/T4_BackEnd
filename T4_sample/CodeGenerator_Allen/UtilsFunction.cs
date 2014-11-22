using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator_Allen
{
    public static class UtilsFunction
    {
        public static List<string> getAllTable(string DbName) // 取得該DB所有table
        {
            List<string> list = new List<string>();
            string connectionString = "Server=localhost;Database="+DbName+";Trusted_Connection=true"; 
			SqlConnection conn = new SqlConnection(connectionString); 
			conn.Open(); 						
			string Query = "USE " + DbName +
                           " SELECT * FROM INFORMATION_SCHEMA.Tables order by TABLE_NAME"; 
			SqlCommand command = new SqlCommand(Query,conn);
            DataSet ds = new DataSet();
            using (SqlDataAdapter ad = new SqlDataAdapter(command)) {  
			    
                ad.Fill(ds);
            }
            if (ds.Tables[0].Rows.Count > 0) 
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {
                    list.Add(ds.Tables[0].Rows[i]["TABLE_NAME"].ToString());
                }
            }
            return list;
        }

        public static void isDirectoryExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static List<string> getAllDB() // 取得該DB所有table
        {
            List<string> list = new List<string>();
            string connectionString = "Server=localhost;Database=master;Trusted_Connection=true";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string Query = "SELECT Name FROM Master..SysDatabases ORDER BY Name";
            SqlCommand command = new SqlCommand(Query, conn);
            DataSet ds = new DataSet();
            using (SqlDataAdapter ad = new SqlDataAdapter(command))
            {

                ad.Fill(ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    list.Add(ds.Tables[0].Rows[i]["NAME"].ToString());
                }
            }
            return list;
        }
    }
}
