using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using webAPINmctTemplate1.Helper;
using WebApplication1.Models;

namespace WebApplication1.helper
{
    public class DAKassas
    {
        private const string CONNECTIONSTRING = "DefaultConnection";
        public static List<KassaModel> GetAllKassa()
        {
            DateTime today = DateTime.Today;
            string time = today.ToString("dd-MM-yyyy");
            string sql = "SELECT Id,RegisterName,Device,PurchesData,ExpiresDate FROM Registers";
            DbDataReader reader = Database.GetData(CONNECTIONSTRING, sql);
            List<KassaModel> All = new List<KassaModel>();
            while (reader.Read())
            {
                KassaModel kas = new KassaModel()
                {
                    Id = (int)reader["Id"],
                    RegisterName = reader["RegisterName"].ToString(),
                    Device = reader["Device"].ToString(),
                    PurchesData = reader["PurchesData"].ToString(),
                    ExpiresDate = reader["ExpiresDate"].ToString(),
                };
                All.Add(kas);
            }
            reader.Close();
            return All;
        }
        public static KassaModel GetKassaById(int id) 
        {

        KassaModel kas = new KassaModel();
        string sql = "SELECT Id,RegisterName,Device,PurchesData,ExpiresDate FROM Registers WHERE Id = @id";
        DbParameter par1 = Database.AddParameter(CONNECTIONSTRING, "@id",id);
        DbDataReader reader = Database.GetData(CONNECTIONSTRING, sql, par1);
        while (reader.Read())
        {
                kas.Id = (int)reader["Id"];
                kas.RegisterName = reader["RegisterName"].ToString();
                kas.Device = reader["Device"].ToString();
                kas.PurchesData = reader["PurchesData"].ToString();
                kas.ExpiresDate = reader["ExpiresDate"].ToString();
            };
        return kas;
        }
        public static int NewKassa(string name, string device, string from, string until) {
            string sql = "INSERT INTO Registers (RegisterName, Device, PurchesData, ExpiresDate) VALUES (@Name, @Device,@From,@Until)";
            DbParameter par1 = Database.AddParameter(CONNECTIONSTRING, "@Name", name);
            DbParameter par2 = Database.AddParameter(CONNECTIONSTRING, "@Device", device);
            DbParameter par3 = Database.AddParameter(CONNECTIONSTRING, "@From", from);
            DbParameter par4 = Database.AddParameter(CONNECTIONSTRING, "@Until", until);
            Database.InsertData(CONNECTIONSTRING, sql, par1, par2, par3, par4);
            return 0;
        }
        public static int UploadKassaToVereniging(int KasId, int VerId, string BuyDate, string ExpDate) 
        {
            
            string sql = "INSERT INTO Organistation_Register (OrganisationID, RegisterID, FromData, UntilData) VALUES (@kasId, @VerId,@buy,@exp)";
            DbParameter par1 = Database.AddParameter(CONNECTIONSTRING, "@kasId", KasId);
            DbParameter par2 = Database.AddParameter(CONNECTIONSTRING, "@VerId", VerId);
            DbParameter par3 = Database.AddParameter(CONNECTIONSTRING, "@buy", BuyDate);
            DbParameter par4 = Database.AddParameter(CONNECTIONSTRING, "@exp", ExpDate);
            Database.InsertData(CONNECTIONSTRING, sql, par1, par2, par3, par4);
            return 0;
        }
        public static List<LogboekModel> GetErrors(int Id) 
        { 
            List<LogboekModel> er = new List<LogboekModel>();

            string sql = "SELECT RegisterID,Timestamp,Message,Stacktrace FROM Errorlog WHERE RegisterID = @id";
            DbParameter par1 = Database.AddParameter(CONNECTIONSTRING, "@id", Id);
            DbDataReader reader = Database.GetData(CONNECTIONSTRING, sql, par1);
            while (reader.Read())
            {
                LogboekModel kas = new LogboekModel()
                {
                    RegisterID = (int)reader["RegisterID"],
                    Timestamp = reader["Timestamp"].ToString(),
                    Message = reader["Message"].ToString(),
                    Stacktrace = reader["Stacktrace"].ToString(),
                };
                er.Add(kas);
            }
            reader.Close();
            return er;
        }
    }
}