public class Cell
{
    private readonly int row;
    private readonly int column;
    private String content;

    private SharedCell sharedCell;

    public Cell(int row, int column, SharedCell sharedCell)
    {
        this.row = row;
        this.column = column;
        this.sharedCell = sharedCell;
    }

    public String getContent()
    {
        return content;
    }

    public void setContent(String content)
    {
        this.content = content;
    }

    public SharedCell getSharedCell()
    {
        return sharedCell;
    }

    public void setSharedCell(SharedCell sharedCell)
    {
        this.sharedCell = sharedCell;
    }

    public void render()
    {
        System.Console.WriteLine("({0}, {1}): {2} [{3}]\n", row, column, content, sharedCell.getFontFamily());
    }
}