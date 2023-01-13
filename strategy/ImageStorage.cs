public class ImageStorage 
{
    private ICompressor Compressor;
    private IFilter Filter;

    public ImageStorage(ICompressor Compressor, IFilter Filter)
    {
        this.Compressor = Compressor;
        this.Filter = Filter;
    }

    public void Store(string filename)
    {
        Compressor.Compress(filename);
        Filter.Apply(filename);
    }
}