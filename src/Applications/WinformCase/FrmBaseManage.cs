using WinformCase.Models;

namespace WinformCase
{
    public partial class FrmBaseManage : Form
    {
        public FrmBaseManage()
        {
            InitializeComponent();
        }

        private void FrmBaseManage_Load(object sender, EventArgs e)
        {
            dgvBase.DataSource = AppraisalBases.GetAll();
        }
    }
}
