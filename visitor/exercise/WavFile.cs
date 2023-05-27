public class WavFile
{
    private List<ISegment> segments = new List<ISegment>();

    public static WavFile read(String fileName)
    {
        // Simulate reading a wav file and building the segments
        var wavFile = new WavFile();
        wavFile.segments.Add(new FormatSegment());
        wavFile.segments.Add(new FactSegment());
        wavFile.segments.Add(new FactSegment());
        wavFile.segments.Add(new FactSegment());


        wavFile.segments[0].execute(new NormalizeOperation());
        wavFile.segments[1].execute(new AddReverbOperation());
        wavFile.segments[2].execute(new ReduceNoiseOperation());
        wavFile.segments[3].execute(new NormalizeOperation());

        return wavFile;
    }

}
