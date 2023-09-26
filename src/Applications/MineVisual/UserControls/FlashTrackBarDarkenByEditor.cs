using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineVisual.UserControls
{
    public class FlashTrackBarDarkenByEditor : FlashTrackBarValueEditor
    {
        protected override void SetEditorProps(FlashTrackBar editingInstance, FlashTrackBar editor)
        {
            base.SetEditorProps(editingInstance, editor);
            editor.Min = 0;
            editor.Max = byte.MaxValue;
        }
    }
}
