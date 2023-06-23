public class HtmlImage : HtmlElement {
    private String source;

    public HtmlImage(String source) {
        this.source = source;
    }

    public String toString() {
        return String.Format("<img src=\"{0}\" />", source);
    }
}
