namespace MineVisual.Controls
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
