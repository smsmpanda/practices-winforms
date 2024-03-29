﻿using System.Data;
using WinformCase.Utility;

namespace WinformCase.Models
{
    public class AppraisalCoefficients
    {
        public int Id { get; set; }
        public string AppraisalType { get; set; }
        public string AppraisalCoefficient { get; set; }
        public string CalculationMethod { get; set; }
        public int IsDel { get; set; }


        public static List<AppraisalCoefficients> GetAll()
        {
            DataTable dt = SqlHelper.ExecuteTable("select * from AppraisalCoefficients");
            return ConvertDataTableToModel.ToModel<AppraisalCoefficients>(dt);
        }
    }
}
