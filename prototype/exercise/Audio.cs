public class Audio : IIComponent
{
    public IIComponent Clone()
    {
        IIComponent audio = new Audio();
        return audio;
    }
}
