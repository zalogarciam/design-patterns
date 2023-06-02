public class ImageView {
    private Image Image;

    public ImageView(Image image)
    {
        this.Image = image;
    }

    public void Apply(IIFilter filter) {
        filter.Apply(Image);
    }
}