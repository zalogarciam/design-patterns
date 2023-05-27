public class WavFile
{
    private List<Segment> segments = new List<Segment>();

    public static WavFile read(String fileName)
    {
        // Simulate reading a wav file and building the segments
        var wavFile = new WavFile();
        wavFile.segments.Add(new FormatSegment());
        wavFile.segments.Add(new FactSegment());
        wavFile.segments.Add(new FactSegment());
        wavFile.segments.Add(new FactSegment());

        return wavFile;
    }

    public void reduceNoise()
    {
        foreach (var segment in segments)
            segment.reduceNoise();
    }

    public void addReverb()
    {
        foreach (var segment in segments)
            segment.addReverb();
    }

    public void normalize()
    {
        foreach (var segment in segments)
            segment.normalize();
    }
}
