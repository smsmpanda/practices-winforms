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
        public bool IsDel { get; set; }


        public static List<AppraisalBases> GetAll() 
        {
            DataTable dt = SqlHelper.ExecuteTable("select * from AppraisalBases");
            return ConvertDataTableToModel.ToModel<AppraisalBases>(dt);
        }
    }
}
