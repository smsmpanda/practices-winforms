namespace MineVisual;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void OnLogin_Click(object sender, EventArgs e)
    {
        string account = txtAccount.Text;
        string pwd = txtPwd.Text;

        if (!account.Equals("admin"))
        {
            MessageBox.Show("�˺Ų����ڣ�");
            return;
        }

        if (!pwd.Equals("password"))
        {
            MessageBox.Show("�˺Ż��������");
            return;
        }

        this.DialogResult = DialogResult.OK;
    }
}
