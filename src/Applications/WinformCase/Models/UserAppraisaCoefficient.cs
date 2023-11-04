using MySql.Data.MySqlClient;
using System.Data;
using WinformCase.Utility;

namespace WinformCase.Models
{
    public class UserAppraisaCoefficient
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CoeffcientId { get; set; }
        public int Count { get; set; }
        public int AssessmentYear { get; set; }
        public string AppraisalType { get; set; }
        public double AppraisalCoefficient { get; set; }
        public int CalculationMethod { get; set; }
        public int IsDel { get; set; }

        public static List<UserAppraisaCoefficient> GetUserAppraisaCoefficient()
        {
            DataTable dt = GetUserAppraisaCoefficientDataTable();
            return ConvertDataTableToModel.ToModel<UserAppraisaCoefficient>(dt);
        }

        public static DataTable GetUserAppraisaCoefficientDataTable()
        {
            string sql = @"
                    SELECT 
                    ua.*,
                    ac.AppraisalType,
                    ac.AppraisalCoefficient,
                    ac.CalculationMethod
                    FROM UserAppraisals ua LEFT JOIN AppraisalCoefficients ac ON ua.CoeffcientId = ac.Id";

            DataTable dt = SqlHelper.ExecuteTable(sql);
            return dt;
        }

        public static List<UserAppraisaCoefficient> GetAppraisaByUserId(int userId, string year)
        {
            string sql = @" select ac.Id,ac.AppraisalType,ua.Count from AppraisalCoefficients ac left join UserAppraisals  ua on ac.Id=ua.CoeffcientId and ua.UserId = @UserId and ua.AssessmentYear = @AssessmentYear";
            DataTable dt = SqlHelper.ExecuteTable(sql, new MySqlParameter[] {
                new MySqlParameter("@UserId",userId),
                 new MySqlParameter("@AssessmentYear",year)
            });
            return ConvertDataTableToModel.ToModel<UserAppraisaCoefficient>(dt);
        }

        public static List<UserAppraisaCoefficient> GetUserAppraisaByIdAndYear(int userId, string year)
        {
            string sql = @" select * from UserAppraisals  where UserId = @UserId and AssessmentYear = @AssessmentYear ";
            DataTable dt = SqlHelper.ExecuteTable(sql, new MySqlParameter[] {
                new MySqlParameter("@UserId",userId),
                new MySqlParameter("@AssessmentYear",year),
            });
            return ConvertDataTableToModel.ToModel<UserAppraisaCoefficient>(dt);
        }

        public static int Delete(int userId, string assessmentYear, int coefficimentId)
        {
            string sql = "Delete from UserAppraisals  where UserId = @UserId and AssessmentYear = @AssessmentYear and CoeffcientId = @CoeffcientId";
            return SqlHelper.ExecuteNoQuery(sql,
                new MySqlParameter("@UserId", userId),
                new MySqlParameter("@AssessmentYear", assessmentYear),
                new MySqlParameter("@CoeffcientId", coefficimentId)
                );
        }

        public static int Insert(int userId, string assessmentYear, int coefficimentId, string count)
        {
            string sql = $"INSERT INTO UserAppraisals(UserId,CoeffcientId,Count,AssessmentYear,IsDel) values (@UserId,@CoeffcientId,@Count,@AssessmentYear,0)";
            return SqlHelper.ExecuteNoQuery(sql,
                new MySqlParameter("@UserId", userId),
                new MySqlParameter("@CoeffcientId", coefficimentId),
                new MySqlParameter("@Count", count),
                new MySqlParameter("@AssessmentYear", assessmentYear)
                );
        }
    }
}
