
public class VideoEditor
{
    private float Contrat = 0.5f;
    private string Text;

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
        return Contrat;
    }

    public void SetContrast(float contrast)
    {
        this.Contrat = contrast;
    }

    public override String ToString()
    {
        return "VideoEditor{" +
                "contrast=" + Contrat +
                ", text='" + Text + '\'' +
                '}';
    }
}
