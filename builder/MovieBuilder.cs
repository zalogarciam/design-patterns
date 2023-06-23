public class MovieBuilder : IPresentationBuilder
{
    private Movie movie = new Movie();
    public void AddSlide(Slide slide)
    {
        movie.AddFrame(slide.Text, 3);
    }


    internal Movie getMovie()
    {
        return movie;
    }

}