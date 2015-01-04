using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using webAPINmctTemplate1.Helper;

namespace WebApplication1.helper
{

    public class DAManagement
    {
        private const string CONNECTIONSTRING = "DefaultConnection";
        private const string NewDbConString = "NewDbString";
        private const string VARIABLECONSTRING = "INSERTCOLUMS";
        public static int NieuweOrga(string login, string password, string Dbname, string DbPassword, string VerenigingNaam, string address, string Email, string phone)
        {

            string sql = "INSERT INTO Organisation (login,Password,Dbname,DbPassword,OrganisationName,Address,Email,Phone) VALUES(@login,@Password,@Dbname,@DBpassword,@OrganisationName,@Address,@Email,@Phone)";
            DbParameter par1 = Database.AddParameter(CONNECTIONSTRING, "@Login", login);
            DbParameter par2 = Database.AddParameter(CONNECTIONSTRING, "@Password", password);
            DbParameter par3 = Database.AddParameter(CONNECTIONSTRING, "@Dbname", Dbname);
            DbParameter par4 = Database.AddParameter(CONNECTIONSTRING, "@DBpassword", DbPassword);
            DbParameter par5 = Database.AddParameter(CONNECTIONSTRING, "@OrganisationName", VerenigingNaam);
            DbParameter par6 = Database.AddParameter(CONNECTIONSTRING, "@Address", address);
            DbParameter par7 = Database.AddParameter(CONNECTIONSTRING, "@Email", Email);
            DbParameter par8 = Database.AddParameter(CONNECTIONSTRING, "@Phone", phone);

            return Database.InsertData(CONNECTIONSTRING, sql, par1, par2, par3, par4, par5, par6, par7, par8);
        }
        public static int CreateDataBase(string DbName) 
        {
            
            //string sql = "CREATE DATABASE @name";
            //DbParameter parDatabase = Database.AddParameter(NewDbConString, "@name", DbName);
            //Database.GetData(NewDbConString, sql,parDatabase);
            string sql = "CREATE DATABASE "+DbName+"";
            Database.GetData(NewDbConString, sql);

            return 0;
        }
        public static int FillDataBase(string DbName)
        {
            string sqlTableEmployee = "CREATE TABLE @name.Employee( ID int IDENTITY(1,1) NOT NULL, EmployeeName nvarchar(150) NOT NULL, Address nvarchar(150) NOT NULL, Email nvarchar(150) NOT NULL, Phone nvarchar(150) NOT NULL, RFID nvarchar(150) NOT NULL)";
            DbParameter par1 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.GetData(VARIABLECONSTRING, sqlTableEmployee);

            string sqlTableCustomer = "CREATE TABLE @name.Customers(ID int IDENTITY(1,1) NOT NULL, CustomerName nvarchar(150) NOT NULL, Address nvarchar(150) NOT NULL, Picture image NOT NULL,Balance nvarchar(150) NOT NULL, RijksRegister nvarchar(150) NOT NULL ";
            DbParameter par2 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.GetData(VARIABLECONSTRING, sqlTableCustomer, par2);

            string sqlTableError = "CREATE TABLE @name.Errorlog(RegisterID int IDENTITY(1,1) NOT NULL,Timestamp timestamp NOT NULL";
            DbParameter par3 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.GetData(VARIABLECONSTRING, sqlTableError, par3);

            string sqlTableProduct = "CREATE TABLE @name.Products(ID int IDENTITY(1,1) NOT NULL, ProductName nvarchar(150) NOT NULL,Price nvarchar(150) NOT NULL,Plaats nvarchar(150) NOT NULL,CategoryId nvarchar(150) NOT NULL ";
            DbParameter par4 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.GetData(VARIABLECONSTRING, sqlTableProduct, par4);

            string sqlTableRegister = "CREATE TABLE @name.Register(ID int IDENTITY(1,1) NOT NULL,RegisterName nvarchar(150) NOT NULL,Device nvarchar(150) NOT NULL";
            DbParameter par5 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.GetData(VARIABLECONSTRING, sqlTableRegister, par5);

            string sqlTableRegEmp = "CREATE TABLE @name.Register_employee(RegisterID int NOT NULL,EmployeeID int NOT NULL,Van nvarchar(150) NULL,Until nvarchar(150) NULL";
            DbParameter par6 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.GetData(VARIABLECONSTRING, sqlTableRegEmp, par6);

            string sqlTableSales = "CREATE TABLE @name.Sales(ID int IDENTITY(1,1) NOT NULL,Timestamp timestamp NOT NULL,CustomerID int NOT NULL,RegisterID int NOT NULL,ProductID int NOT NULL,Amount nvarchar(150) NOT NULL,TotalPrice nvarchar(150) NOT NULL";
            DbParameter par7 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.GetData(VARIABLECONSTRING, sqlTableSales, par7);

            string sqlTableCato = "CREATE TABLE @name.Category(Id int IDENTITY(1,1) NOT NULL,Category nvarchar(150) NOT NULL";
            DbParameter par8 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.GetData(VARIABLECONSTRING, sqlTableCato, par8);

            string insert1 = "INSERT @name.Category (Id, Category) VALUES (1, N'bar_softDrnk')";
            DbParameter par9 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.InsertData(VARIABLECONSTRING, insert1, par9);

            string insert2 = "INSERT @name.Category (Id, Category) VALUES (2, N'bar_beer')";
            DbParameter par10 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.InsertData(VARIABLECONSTRING, insert2, par10);

            string insert3 = "INSERT @name.Category (Id, Category) VALUES (3, N'bar_sterkeDrank')";
            DbParameter par11 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.InsertData(VARIABLECONSTRING, insert3, par11);

            string insert4 = "INSERT @name.Category (Id, Category) VALUES (4, N'winkel_kleren')";
            DbParameter par12 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.InsertData(VARIABLECONSTRING, insert4, par12);

            string insert5 = "INSERT @name.Category (Id, Category) VALUES (5, N'winkel_accessoires')";
            DbParameter par13 = Database.AddParameter(NewDbConString, "@name", DbName);
            Database.InsertData(VARIABLECONSTRING, insert5, par13);
            return 0;
        }
    }
}