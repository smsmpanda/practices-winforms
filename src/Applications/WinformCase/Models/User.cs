using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformCase.Utility;

namespace WinformCase.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Sex { get; set; }
        public string Password { get; set; }
        public int BaseTypeId { get; set; }
        public int IsDel { get; set; }

        public int Insert() 
        {
            string sql = $"INSERT INTO Users(UserName,Password,Sex,BaseTypeId,IsDel) values (@UserName,@Password,@Sex,@BaseTypeId,@IsDel)";
            return SqlHelper.ExecuteNoQuery(sql,
                new MySqlParameter("@UserName",this.UserName),
                new MySqlParameter("@Password", this.Password),
                new MySqlParameter("@Sex", this.Sex),
                new MySqlParameter("@BaseTypeId", this.BaseTypeId),
                new MySqlParameter("@IsDel", this.IsDel)
                );
        }

        public static User? GetUserById(int id) 
        {
            string sql = "select Id,UserName,Sex,Password,BaseTypeId,IsDel from Users where id = @uid";
            var users = ConvertDataTableToModel.ToModel<User>(SqlHelper.ExecuteTable(sql,new MySqlParameter("@uid", id)));
            return users.FirstOrDefault();
        }

        public int Update()
        {
            string sql = "Update Users set UserName = @UserName,Sex = @Sex,Password = @Password,BaseTypeId = @BaseTypeId,IsDel=@IsDel  where Id = @Id";
            return SqlHelper.ExecuteNoQuery(sql,
                new MySqlParameter("@UserName", this.UserName),
                new MySqlParameter("@Password", this.Password),
                new MySqlParameter("@Sex", this.Sex),
                new MySqlParameter("@BaseTypeId", this.BaseTypeId),
                new MySqlParameter("@IsDel", this.IsDel),
                new MySqlParameter("@Id", this.Id)
                );
        }
    }
}
