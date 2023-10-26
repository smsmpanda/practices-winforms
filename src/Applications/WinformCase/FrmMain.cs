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
        frmUserManage.MdiParent= this;
        frmUserManage.Parent = splitContainer1.Panel2;
        frmUserManage.Show();
    }
}
