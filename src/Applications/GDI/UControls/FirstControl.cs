using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI.UControls
{
    public class FirstControl : Control
    {
        private ContentAlignment alignmentValue = ContentAlignment.MiddleLeft;


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            StringFormat style = new StringFormat();
            style.Alignment = StringAlignment.Near;

            switch(alignmentValue) 
            {
                case ContentAlignment.MiddleLeft:
                    style.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleRight:
                    style.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.MiddleCenter:
                    style.Alignment = StringAlignment.Center;
                    break;
            }

            e.Graphics.DrawString(this.Text,this.Font,new SolidBrush(this.ForeColor),this.ClientRectangle,style);
        }

        [Category("Custome"),Description("Specifies the alignment of text.")]
        public ContentAlignment TextAlignment
        {

            get => alignmentValue;
            set
            {
                alignmentValue = value;

                // The Invalidate method invokes the OnPaint method described
                // in step 3.
                Invalidate();
            }
        }
    }
}
