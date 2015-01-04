using nmctBaWPF1.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace webAPINmctTemplate1.Helper
{
    
    public class DAMedewerker
    {
        private const string CONNECTIONSTRING = "DefaultConnection";
        public List<MedewerkerInfo> GetData()
        {

            List<MedewerkerInfo> MWI = new List<MedewerkerInfo>();
            string sql = "select ID,EmployeeName,Address,Email,Phone,RFID FROM Employee";


            DbDataReader reader = Database.GetData(CONNECTIONSTRING, sql);
            
            while (reader.Read())
            {
                string add = reader["Address"].ToString();
                string[] arr = add.Split(';');
                MedewerkerInfo ver = new MedewerkerInfo()
                {
                    ID = (int)reader["ID"],
                    EmployeeName = reader["EmployeeName"].ToString(),
                    Address = reader["Address"].ToString(),
                    Email = reader["Email"].ToString(),
                    Phone = reader["Phone"].ToString(),
                    RFID = reader["RFID"].ToString()
                }; 
                MWI.Add(ver);
            }
            reader.Close();
            return MWI;
        } 
    }
}