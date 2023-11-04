using WinformCase.Models;

namespace WinformCase
{
    public partial class FrmSetUser : Form
    {
        //用于主界面订阅事件（更新主界面）
        public event EventHandler FeedBackParent;

        private int _uid;
        public FrmSetUser()
        {
            InitializeComponent();
        }

        public FrmSetUser(int uid) : this()
        {
            _uid = uid;
        }

        private void FrmSetUser_Load(object sender, EventArgs e)
        {
            BindCbxBase();
            AssignMentEditUser();
        }

        private void BindCbxBase()
        {
            List<AppraisalBases> appraisals = AppraisalBases.GetAll();
            cbxBaseType.DataSource = appraisals;
            cbxBaseType.DisplayMember = "BaseType";
            cbxBaseType.ValueMember = "Id";
        }

        private void AssignMentEditUser()
        {
            User? u = User.GetUserById(_uid);
            if (u != null)
            {
                txtUname.Text = u.UserName;
                cbxBaseType.SelectedValue = u.BaseTypeId;
                cbxGender.Text = u.Sex;
                checkIsDel.Checked = u.IsDel == 0 ? false : true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = txtUname.Text.Trim();
            user.BaseTypeId = (int)cbxBaseType.SelectedValue;
            user.Sex = (string)cbxGender.Text;
            user.IsDel = checkIsDel.Checked ? 1 : 0;
            user.Password = "password";
            user.Id = _uid;

            //更新
            if (_uid > 0)
            {
                user.Update();
                MessageBox.Show("更新用户成功");
            }
            else
            {
                user.Insert();
                MessageBox.Show("添加用户成功");
            }

            if (FeedBackParent != null)
            {
                this.FeedBackParent.Invoke(this, null);
            }

            this.Close();
        }
    }
}
