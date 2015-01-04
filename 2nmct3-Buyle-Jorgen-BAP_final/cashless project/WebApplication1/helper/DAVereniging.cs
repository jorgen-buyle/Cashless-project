using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using webAPINmctTemplate1.Helper;
using WebApplication1.Models;

namespace WebApplication1.helper
{
    public class DAVereniging
    {
        private const string CONNECTIONSTRING = "DefaultConnection";
        public static List<Vereniging> GetVerenigingen() 
        {
            string sql = "SELECT id,login,Password,Dbname,DbPassword,OrganisationName,Address,Email,Phone FROM Organisation";

            DbDataReader reader = Database.GetData(CONNECTIONSTRING, sql);
            List<Vereniging> verenigingen = new List<Vereniging>();
            while (reader.Read())
            {
                string add = reader["Address"].ToString();
                string[] arr = add.Split(';');
                Vereniging ver = new Vereniging()
                {
                    Id = (int)reader["Id"],
                    login = reader["login"].ToString(),
                    Passwoord = reader["Password"].ToString(),
                    Dbname = reader["Dbname"].ToString(),
                    VerenigingNaam = reader["OrganisationName"].ToString(),
                    StraatNr = arr[0],
                    Postcode = arr[1],
                    Locatie = arr[2],
                    Email = reader["Email"].ToString(),
                    Telefoon = reader["Phone"].ToString(),    
                };
                verenigingen.Add(ver);
            }
            reader.Close();
            return verenigingen;
        }

        public static Vereniging GetVerenigingenById(int id) 
        {
            string sql = "SELECT id,login,Password,Dbname,DbPassword,OrganisationName,Address,Email,Phone FROM Organisation WHERE id = @id";
            DbParameter par1 = Database.AddParameter(CONNECTIONSTRING, "@id", id);
            DbDataReader reader = Database.GetData(CONNECTIONSTRING, sql, par1);
            Vereniging verenigingen = new Vereniging();
            while (reader.Read())
            {
                string add = reader["Address"].ToString();
                string[] arr = add.Split(';');   
                    verenigingen.Id = (int)reader["Id"];
                    verenigingen.login = reader["login"].ToString();
                    verenigingen.Passwoord = reader["Password"].ToString();
                    verenigingen.Dbname = reader["Dbname"].ToString();
                    verenigingen.DbPasswoord = reader["DbPassword"].ToString();
                    verenigingen.VerenigingNaam = reader["OrganisationName"].ToString();
                    verenigingen.StraatNr = arr[0];
                    verenigingen.Postcode = arr[1];
                    verenigingen.Locatie = arr[2];
                    verenigingen.Email = reader["Email"].ToString();
                    verenigingen.Telefoon = reader["Phone"].ToString();      
            }
            reader.Close();
            return verenigingen;
        }
        public static int UpdateVerenigingen(string login, string password, string Dbname, string DbPassword, string VerenigingNaam, string address, string Email, string phone, int id) 
        {
            string sql = "Update Organisation SET login = @login,Password = @Password, Dbname = @Dbname, DbPassword = @DBpassword,"+
                         " OrganisationName = @OrganisationName, Address = @Address, Email = @Email, Phone = @Phone" +
                         " WHERE id = @id ";
            DbParameter par1 = Database.AddParameter(CONNECTIONSTRING, "@Login", login);
            DbParameter par2 = Database.AddParameter(CONNECTIONSTRING, "@Password", password);
            DbParameter par3 = Database.AddParameter(CONNECTIONSTRING, "@Dbname", Dbname);
            DbParameter par4 = Database.AddParameter(CONNECTIONSTRING, "@DBpassword", DbPassword);
            DbParameter par5 = Database.AddParameter(CONNECTIONSTRING, "@OrganisationName", VerenigingNaam);
            DbParameter par6 = Database.AddParameter(CONNECTIONSTRING, "@Address", address);
            DbParameter par7 = Database.AddParameter(CONNECTIONSTRING, "@Email", Email);
            DbParameter par8 = Database.AddParameter(CONNECTIONSTRING, "@Phone", phone);
            DbParameter par9 = Database.AddParameter(CONNECTIONSTRING, "@id", id);

            return Database.ModifyData(CONNECTIONSTRING, sql, par1, par2, par3, par4, par5, par6, par7, par8, par9);
        }
        public static List<KassaVerenigingModel> GetKassasVoorVereniging(int id) 
        {
            
            string sql = "SELECT R.ID, R.RegisterName, R.Device, Organistation_Register.FromData, Organistation_Register.UntilData FROM Registers R  " +
                         "INNER JOIN Organistation_Register ON Organistation_Register.RegisterID = R.ID WHERE Organistation_Register.OrganisationID = @ID";
            DbParameter par1 = Database.AddParameter(CONNECTIONSTRING, "@ID", id);
            DbDataReader reader = Database.GetData(CONNECTIONSTRING, sql, par1);
            List<KassaVerenigingModel> KVM = new List<KassaVerenigingModel>();
            while (reader.Read())
            {
                
                KassaVerenigingModel kas = new KassaVerenigingModel()
                {
                    Id = (int) reader["ID"],
                    RegisterName = reader["RegisterName"].ToString(),
                    Device = reader["Device"].ToString(),
                    FromData = reader["FromData"].ToString(),
                    UntilData = reader["UntilData"].ToString(),
                };
                KVM.Add(kas);
            }
            reader.Close();
            return KVM;
        }
        public static int DeleteKassaUitVereniging(int id) {
            string sql = "DELETE FROM Organistation_Register WHERE RegisterID = @id;";
            DbParameter par1 = Database.AddParameter(CONNECTIONSTRING, "@id", id);
            return Database.ModifyData(CONNECTIONSTRING,sql,par1);
        }
    }
}