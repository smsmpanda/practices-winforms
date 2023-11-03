using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WinformCase.Common
{
    public class FormFactory<T>
    {
        /// <summary>
        /// 窗体缓存
        /// </summary>
        private static Dictionary<T, Form> _formCaches = new Dictionary<T, Form>();

        /// <summary>
        /// 窗体类型缓存
        /// </summary>
        private static List<Type> _formTypes = new List<Type>();

        static FormFactory() 
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            _formTypes = assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Form)))?.ToList();
        }

        public static Form CreateForm(T formName) 
        {
            CloseForm();

            if (_formCaches.ContainsKey(formName)) 
            {
                return _formCaches[formName];
            }
            var currentType = _formTypes.FirstOrDefault(t => t.Name.Equals(formName));
            if (currentType is null) 
            {
                throw new Exception("The currently specified name Form type was not found.");
            }
            var form =  (Form)Activator.CreateInstance(currentType);
            _formCaches.Add(formName, form);
            return form;
        }


        private static void CloseForm() 
        {
            foreach (var form in _formCaches)
            {
                form.Value.Hide();
            }
        }
    }
}
