using Dapper;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class ConnectionStringService
    {

        public static string GetConnectionString()
        {
            var location = System.AppDomain.CurrentDomain.BaseDirectory + @"\Database\MACPv604.accdb";


            //var connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + location;
            var connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + location;
            //var item = new DatabaseInfoModel();

            //using (var conn = new OleDbConnection(connectionString))
            //{
            //    conn.Open();
            //    var sql = @"select top 1 * from DatabaseInfo";
            //    item = conn.Query<DatabaseInfoModel>(sql).FirstOrDefault();

            //}

            //if (item != null)
            //{
            //    if (!string.IsNullOrEmpty(item.ServerConnectionString))
            //    {
            //        location = item.ServerConnectionString;
            //    }
            //}

            connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + location;

            
            return connectionString;
        }

        //public static string GetLocalConnectionString()
        //{
        //    var location = System.AppDomain.CurrentDomain.BaseDirectory + @"\Database\SDEDatabase.mdb";
        //    var connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + location;

        //    return connectionString;
        //}

        //public static string GetODBCConnectionString()
        //{

        //    var location = System.AppDomain.CurrentDomain.BaseDirectory + @"\Database\SDEDatabase.mdb";


        //    var connectionString = @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" + location +";";
        //    //var connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + location;
        //    var item = new DatabaseInfoModel();

        //    //using (var conn = new odbc.Odbc(connectionString))
        //    //{
        //    //    conn.Open();
        //    //    var sql = @"select top 1 * from DatabaseInfo";
        //    //    item = conn.Query<DatabaseInfoModel>(sql).FirstOrDefault();

        //    //}

        //    //if (item != null)
        //    //{
        //    //    if (!string.IsNullOrEmpty(item.ServerConnectionString))
        //    //    {
        //    //        location = item.ServerConnectionString;
        //    //    }
        //    //}


        //    return connectionString;
        //}
    }
}
