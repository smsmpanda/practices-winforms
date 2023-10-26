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
    public partial class FrmUserManage : Form
    {
        public FrmUserManage()
        {
            InitializeComponent();
        }

        private void FrmUserManage_Load(object sender, EventArgs e)
        {
            BindCbxBase();
        }

        private void BindCbxBase() 
        {
            List<AppraisalBases> appraisals= AppraisalBases.GetAll();
            appraisals.Insert(0, 
                new AppraisalBases {
                    Id = 0,
                    BaseType = "全部"
                });
            cbxBase.DataSource= appraisals;
            cbxBase.DisplayMember = "BaseType";
            cbxBase.ValueMember = "Id";
        }
    }
}
