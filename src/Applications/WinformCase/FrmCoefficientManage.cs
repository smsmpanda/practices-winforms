using WinformCase.Models;

namespace WinformCase
{
    public partial class FrmCoefficientManage : Form
    {
        public FrmCoefficientManage()
        {
            InitializeComponent();
        }
        private void FrmCoefficientManage_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void BindGridView()
        {
            this.dgvCoeffic.DataSource = AppraisalCoefficients.GetAll();
        }
    }
}
