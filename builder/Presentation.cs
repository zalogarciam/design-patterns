public class Presentation
{
    private List<Slide> slides = new List<Slide>();

    public void AddSlide(Slide slide)
    {
        slides.Add(slide);
    }

    public void Export(IPresentationBuilder builder)
    {
        builder.AddSlide(new Slide("Copyright"));
        foreach (var slide in slides)
            builder.AddSlide(slide);
            
        // if (format == PresentationFormat.PDF){
        //     var pdf = new PdfDocument();
        //     foreach(var slide in slides)
        //     {
        //         pdf.AddPage(slide.Text);
        //     }
        // }
        // else if (format == PresentationFormat.MOVIE){
        //     var movie = new Movie();
        //     foreach(var slide in slides)
        //     {
        //         movie.AddFrame(slide.Text, 3);
        //     }

        // }
    }
}