using System.Data;
using WinformCase.Utility;

namespace WinformCase.Models
{
    public class UserAppraisaBases
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Sex { get; set; }
        public string Password { get; set; }
        public int BaseTypeId { get; set; }
        public string BaseType { get; set; }
        public int AppraisaBase { get; set; }
        public int IsDel { get; set; }

        public static List<UserAppraisaBases> GetUserListJoinAppraisal()
        {
            DataTable dt = GetUserAppaisalDataTable();
            return ConvertDataTableToModel.ToModel<UserAppraisaBases>(dt);
        }

        public static DataTable GetUserAppaisalDataTable()
        {
            string sql = @"
                    select
                        u.Id,
                        u.UserName,
                        u.Sex,
                        u.BaseTypeId,
                        u.IsDel,
                        a.AppraisalBase,
                        a.BaseType
                    from Users u Left join AppraisalBases a on u.BaseTypeId = a.Id";

            DataTable dt = SqlHelper.ExecuteTable(sql);
            return dt;
        }
    }
}
