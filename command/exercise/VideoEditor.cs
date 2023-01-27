public class VideoEditor
{
    private float Contrast;
    private string Text;

    public string GetText()
    {
        return this.Text;
    }

    public void SetText(String text)
    {
        this.Text = text;
    }

    public void RemoveText()
    {
        this.Text = "";
    }

    public float GetContrast()
    {
        return Contrast;
    }

    public void SetContrast(float contrast)
    {
        this.Contrast = contrast;
    }

    public override String ToString()
    {
        return "VideoEditor{" +
                "contrast=" + Contrast +
                ", text='" + Text + '\'' +
                '}';
    }
}
