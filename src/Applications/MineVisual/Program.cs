namespace MineVisual;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread] //指定Windows窗体应用程序是一个单线程单元。
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        //LoginForm loginForm = new LoginForm();
        //DialogResult dialogResult = loginForm.ShowDialog();
        //if (dialogResult == DialogResult.OK)
        //{
        //    Application.Run(new MainForm());
        //}
        //else {
        //    Application.Exit();
        //}

        Application.Run(new MainForm());
    }
}