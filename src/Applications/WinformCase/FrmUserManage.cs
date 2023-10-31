﻿using System;
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
            BindUserDataGridView();
        }

        private void BindUserDataGridView()
        {
            string name = txtName.Text;
            int baseType = (int)cbxBaseType.SelectedValue;
            int isDel = checkStopWork.Checked ? 1 : 0;

            List<UserAppraisaBases> result = UserAppraisaBases.GetUserListJoinAppraisal();

            if (string.IsNullOrWhiteSpace(name))
            {
                result = result.FindAll(u => u.UserName.Contains(name));
            }
            if (baseType != 0)
            {
                result = result.FindAll(u => u.BaseTypeId == baseType);
            }

            result = result.FindAll(u => u.IsDel == isDel);

            dgvUser.AutoGenerateColumns = false;
            dgvUser.DataSource = result;
        }

        private void BindCbxBase()
        {
            List<AppraisalBases> appraisals = AppraisalBases.GetAll();
            appraisals.Insert(0,
                new AppraisalBases
                {
                    Id = 0,
                    BaseType = "全部"
                });
            cbxBaseType.DataSource = appraisals;
            cbxBaseType.DisplayMember = "BaseType";
            cbxBaseType.ValueMember = "Id";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindUserDataGridView();
        }

        private void dgvUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
            { 
                cmsUserAdd.Visible = true;
                cmsUserDisable.Visible = false;
                cmsUserEdit.Visible = false;
                cmsUserEnable.Visible = false;
            }
        }

        private void dgvUser_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1) 
                {
                    dgvUser.Rows[e.RowIndex].Selected = true;
                    cmsUserAdd.Visible = true;
                    cmsUserEdit.Visible= true;
                    cmsUserDisable.Visible = false;
                    cmsUserEnable.Visible = false;
                }
            }
        }
    }
}
