using Dapper;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class InspectionService
    {
        private string _ConnectionString;
        public InspectionService()
        {
            _ConnectionString = ConnectionStringService.GetConnectionString();
        }
        public List<string> GetDrainageAreas()
        {
            using (var conn = new OleDbConnection(_ConnectionString))
            {
                conn.Open();
                var sql = @"select distinct insp.Drainage_Area from MH_Inspections as insp Order By insp.Drainage_Area";
                var list = conn.Query<string>(sql);
                return list.ToList();
            }
        }

        public List<string> GetManholeByDrainageArea(string DrainageArea)
        {
            using (var conn = new OleDbConnection(_ConnectionString))
            {
                conn.Open();
                var sql = @"select insp.Manhole_Number from MH_Inspections insp where insp.Drainage_Area = '" + DrainageArea + "' Order By insp.Manhole_Number";
                var list = conn.Query<string>(sql);
                return list.ToList();
            }
        }


    }
}
