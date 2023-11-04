using System.Data;
using WinformCase.Models;

namespace WinformCase
{
    public partial class FrmJxManage : Form
    {
        private List<AppraisalCoefficients> appraisalCoefficients;
        public FrmJxManage()
        {
            InitializeComponent();
        }
        private void FrmJxManage_Load(object sender, EventArgs e)
        {
            DynamicAddGridViewColumn();
            UserAppraisaBind();
        }

        private void DynamicAddGridViewColumn()
        {
            appraisalCoefficients = AppraisalCoefficients.GetAll();
            foreach (var appraisal in appraisalCoefficients)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = $"{appraisal.AppraisalType}※";
                column.DataPropertyName = $"AppraisalType{appraisal.Id}";
                column.Name = appraisal.AppraisalType;
                column.ReadOnly = true;
                column.Width = 90;
                this.dgvJx.Columns.Add(column);

                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "系数";
                column1.DataPropertyName = $"AppraisalCoefficient{appraisal.Id}";
                column1.Name = $"AppraisalCoefficient{appraisal.Id}";
                column1.ReadOnly = true;
                column1.Width = 90;
                this.dgvJx.Columns.Add(column1);

                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                column2.HeaderText = "计算方式";
                column2.DataPropertyName = $"CaculationMethod{appraisal.Id}";
                column2.Name = $"CaculationMethod{appraisal.Id}";
                column2.ReadOnly = true;
                column2.Width = 90;
                this.dgvJx.Columns.Add(column2);
            }

            this.dgvJx.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "考核年度",
                DataPropertyName = "AssessmentYear",
                Name = "AssessmentYear",
                ReadOnly = true,
                Width = 90
            });

            this.dgvJx.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "实发年终奖",
                DataPropertyName = "YearBounds",
                Name = "YearBounds",
                ReadOnly = true,
                Width = 90
            });
        }

        private void UserAppraisaBind()
        {
            DataTable userDt = UserAppraisaBases.GetUserAppaisalDataTable();

            foreach (var appraisal in appraisalCoefficients)
            {
                userDt.Columns.Add(new DataColumn
                {
                    ColumnName = $"AppraisalType{appraisal.Id}",
                });
                userDt.Columns.Add(new DataColumn
                {
                    ColumnName = $"AppraisalCoefficient{appraisal.Id}",
                });
                userDt.Columns.Add(new DataColumn
                {
                    ColumnName = $"CaculationMethod{appraisal.Id}",
                });
            }
            userDt.Columns.Add(new DataColumn
            {
                ColumnName = "YearBounds",
            });
            userDt.Columns.Add(new DataColumn
            {
                ColumnName = "AssessmentYear",
            });

            List<UserAppraisaCoefficient> userAppraisaCoefficients = UserAppraisaCoefficient.GetUserAppraisaCoefficient();


            int currentYear = int.Parse(cbxYear.Text);
            double yearBouds = 0;
            foreach (DataRow row in userDt.Rows)
            {
                yearBouds = 0;

                int userId = row.Field<int>("Id");
                var userAppraisaCoefficient = userAppraisaCoefficients.Where(u => u.UserId == userId && u.AssessmentYear == currentYear);

                foreach (var userAppraisaCoef in userAppraisaCoefficient)
                {
                    string appraisaTypeKey = $"AppraisalType{userAppraisaCoef.CoeffcientId}";
                    int appraisaTypeValue = userAppraisaCoef.Count;

                    string appraaisaCoefficientType = $"AppraisalCoefficient{userAppraisaCoef.CoeffcientId}";
                    double appraaisaCoefficientTypeValue = userAppraisaCoef.AppraisalCoefficient;

                    string caculationMethodKey = $"CaculationMethod{userAppraisaCoef.CoeffcientId}";
                    int caculationMethodValue = userAppraisaCoef.CalculationMethod;

                    row[appraisaTypeKey] = appraisaTypeValue;
                    row[appraaisaCoefficientType] = appraaisaCoefficientTypeValue;
                    row[caculationMethodKey] = caculationMethodValue;

                    //考核项系数
                    //考核系数 x 次数 x 计算方式
                    yearBouds += appraisaTypeValue * appraaisaCoefficientTypeValue * caculationMethodValue;
                }

                row["AssessmentYear"] = currentYear;

                double boundsTotal = (yearBouds + 1) * row.Field<int>("AppraisalBase");
                row["YearBounds"] = boundsTotal <= 0 ? 0 : boundsTotal;

            }
            this.dgvJx.AutoGenerateColumns = false;
            this.dgvJx.DataSource = userDt;
        }

        private void dgvJx_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1)
                {
                    dgvJx.ClearSelection();
                    dgvJx.Rows[e.RowIndex].Selected = true;
                    cmsRecord.Visible = true;
                }
            }
        }

        private void dgvJx_MouseDown(object sender, MouseEventArgs e)
        {
            cmsRecord.Visible = false;
        }

        private void cmsRecord_Click(object sender, EventArgs e)
        {
            int uid = (int)dgvJx.SelectedRows[0].Cells["Id"].Value;
            FrmSetJx frmJx = new FrmSetJx(uid, cbxYear.Text);
            frmJx.FeedBackParent += FrmSetJx_FeedBackParent;
            frmJx.ShowDialog();
        }

        private void FrmSetJx_FeedBackParent(object? sender, EventArgs e)
        {
            UserAppraisaBind();
        }
    }
}
