public class Clip : IIComponent {
      public IIComponent Clone()
    {
        IIComponent clip = new Clip();
        return clip;
    }
}
