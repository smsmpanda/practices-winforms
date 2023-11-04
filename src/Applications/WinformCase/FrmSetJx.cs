using WinformCase.Controls;
using WinformCase.Models;

namespace WinformCase
{
    public partial class FrmSetJx : Form
    {
        private int _userId;
        private string _year;

        //用于主界面订阅事件（更新主界面）
        public event EventHandler FeedBackParent;

        public FrmSetJx()
        {
            InitializeComponent();
        }

        public FrmSetJx(int userId, string year) : this()
        {
            _userId = userId;
            _year = year;
        }


        private void FrmSetJx_Load(object sender, EventArgs e)
        {
            BindAppraisaTypeItem();
        }

        private void BindAppraisaTypeItem()
        {
            List<UserAppraisaCoefficient> appraisalCoefficients = UserAppraisaCoefficient.GetAppraisaByUserId(_userId, _year);

            foreach (var appraisalCoefficient in appraisalCoefficients)
            {
                TextBoxExt textBoxExt = new TextBoxExt();
                textBoxExt.Tag = appraisalCoefficient.Id;
                textBoxExt.Value = $"{appraisalCoefficient.Count}";
                textBoxExt.LabelName = appraisalCoefficient.AppraisalType;
                flpAppraisaType.Controls.Add(textBoxExt);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var txtboxExts = this.flpAppraisaType.Controls;
            foreach (var txtBoxExt in txtboxExts.OfType<TextBoxExt>())
            {
                int coeffcientId = (int)txtBoxExt.Tag;
                string count = txtBoxExt.Value.ToString();

                if (string.IsNullOrWhiteSpace(count) || count.Equals("0"))
                {
                    continue;
                }

                UserAppraisaCoefficient.Delete(_userId, _year, coeffcientId);
                UserAppraisaCoefficient.Insert(_userId, _year, coeffcientId, count);
            }

            FeedBackParent?.Invoke(this, null);
            MessageBox.Show("修改成功");
        }
    }
}
