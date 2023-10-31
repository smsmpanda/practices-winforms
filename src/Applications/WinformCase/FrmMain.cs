namespace WinformCase;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
        FrmUserManage frmUserManage = new FrmUserManage();
        frmUserManage.MdiParent = this;
        frmUserManage.Parent = splitContainer1.Panel2;
        frmUserManage.Show();
    }

    private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e)
    {
        foreach (TreeNode node in trvMenu.Nodes)
        {
            node.BackColor = Color.White; 
            node.ForeColor = Color.Black;
        }
        e.Node.BackColor = SystemColors.Highlight; 
        e.Node.ForeColor = Color.White;
    }
}
