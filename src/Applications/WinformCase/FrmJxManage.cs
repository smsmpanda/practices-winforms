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
    public partial class FrmJxManage : Form
    {
        public FrmJxManage()
        {
            InitializeComponent();
        }

        private void BindJx() 
        {
            dgvJx.DataSource = AppraisalCoefficients.GetAll();
        }

        private void FrmJxManage_Load(object sender, EventArgs e)
        {
            BindJx();
        }
    }
}
