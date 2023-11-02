using WinformCase.Common;

namespace WinformCase;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
        Form form = FormFactory<string>.CreateForm("FrmUserManage");
        form.MdiParent = this;
        form.Parent = splitContainer1.Panel2;
        form.Show();
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


        Form form = FormFactory<string>.CreateForm(e.Node.Tag.ToString());
        form.MdiParent = this;
        form.Parent = splitContainer1.Panel2;
        form.Show();
    }
}
