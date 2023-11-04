using System.Data;
using System.Reflection;

namespace WinformCase.Utility
{
    public class ConvertDataTableToModel
    {
        public static List<T> ToModel<T>(DataTable dataTable) where T : new()
        {
            List<T> list = new List<T>();

            foreach (DataRow row in dataTable.Rows)
            {
                T obj = new T();

                foreach (DataColumn col in dataTable.Columns)
                {
                    PropertyInfo propertyInfo = obj.GetType().GetProperty(col.ColumnName);
                    if (propertyInfo != null && row[col] != DBNull.Value)
                    {
                        propertyInfo.SetValue(obj, Convert.ChangeType(row[col], propertyInfo.PropertyType), null);
                    }
                }

                list.Add(obj);
            }
            return list;
        }
    }
}
