using System.ComponentModel;

namespace WinformCase.Controls
{
    public partial class TextBoxExt : UserControl
    {
        [Category("自定义")]
        public string LabelName
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }

        [Category("自定义")]
        public object Tag
        {
            get { return txtText.Tag; }
            set { txtText.Tag = value; }
        }

        [Category("自定义")]
        public string Value
        {
            get { return txtText.Text; }
            set { txtText.Text = value; }
        }

        public TextBoxExt()
        {
            InitializeComponent();
        }
    }
}
