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
