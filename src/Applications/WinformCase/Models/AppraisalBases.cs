using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformCase.Utility;

namespace WinformCase.Models
{
    public class AppraisalBases
    {
        public int Id { get; set; }
        public string BaseType { get; set; }
        public int AppraisalBase { get; set; }
        public int IsDel { get; set; }


        public static List<AppraisalBases> GetAll() 
        {
            DataTable dt = SqlHelper.ExecuteTable("select * from AppraisalBases");
            return ConvertDataTableToModel.ToModel<AppraisalBases>(dt);
        }

        public int Update()
        {
            string sql = "Update Users set BaseType = @BaseType,AppraisalBase = @AppraisalBase,BaseTypeId = @BaseTypeId,IsDel=@IsDel  where Id = @Id";
            return SqlHelper.ExecuteNoQuery(sql,
                new MySqlParameter("@BaseType", this.BaseType),
                new MySqlParameter("@AppraisalBase", this.AppraisalBase),
                new MySqlParameter("@IsDel", this.IsDel),
                new MySqlParameter("@Id", this.Id));
        }
    }
}
