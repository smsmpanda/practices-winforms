using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformCase.Models;

namespace WinformCase
{
    public partial class FrmSetUser : Form
    {
        public event EventHandler FeedBackParent;
        public FrmSetUser()
        {
            InitializeComponent();
        }

        private void FrmSetUser_Load(object sender, EventArgs e)
        {
            BindCbxBase();
        }


        private void BindCbxBase()
        {
            List<AppraisalBases> appraisals = AppraisalBases.GetAll();
            cbxBaseType.DataSource = appraisals;
            cbxBaseType.DisplayMember = "BaseType";
            cbxBaseType.ValueMember = "Id";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = txtUname.Text.Trim();
            user.BaseTypeId = (int)cbxBaseType.SelectedValue;
            user.Sex = (string)cbxGender.Text;
            user.IsDel = checkIsDel.Checked ? 1 : 0;
            user.Password = "password";
            user.Insert();
            MessageBox.Show("添加用户成功");

            if(FeedBackParent!=null)
            {
                this.FeedBackParent.Invoke(this,null);
            }

            this.Close();
        }
    }
}
