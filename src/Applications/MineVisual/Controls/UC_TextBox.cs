using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
