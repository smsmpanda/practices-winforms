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

        private void dgvBase_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvBase_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
