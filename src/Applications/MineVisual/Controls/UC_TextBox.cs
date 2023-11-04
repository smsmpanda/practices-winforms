using System.ComponentModel;

namespace MineVisual.Controls
{
    public partial class UC_TextBox : UserControl
    {
        public UC_TextBox()
        {
            InitializeComponent();
        }

        private bool _isRound;

        [Category("扩展")]
        public bool IsRound
        {
            get { return _isRound; }
            set { _isRound = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
