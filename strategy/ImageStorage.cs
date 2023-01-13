public class ImageStorage
{
    public ImageStorage()
    {

    }

    public void Store(string filename, ICompressor Compressor, IFilter Filter)
    {
        Compressor.Compress(filename);
        Filter.Apply(filename);
    }
}