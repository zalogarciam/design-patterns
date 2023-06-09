public class SpreadSheet
{
    private readonly int MAX_ROWS = 3;
    private readonly int MAX_COLS = 3;

    // In a real app, these values should not be hardcoded here.
    // They should be read from a configuration file.
    private readonly String fontFamily = "Times New Roman";
    private readonly int fontSize = 12;
    private readonly bool isBold = false;

    private Cell[,] cells;

    public SpreadSheet()
    {
        cells = new Cell[MAX_ROWS, MAX_COLS];
        generateCells();
    }

    public void setContent(int row, int col, String content)
    {
        ensureCellExists(row, col);

        cells[row,col].setContent(content);
    }

    public void setFontFamily(int row, int col, String fontFamily)
    {
        ensureCellExists(row, col);

        var cell = cells[row,col];
        cells[row,col].setFontFamily(fontFamily);
    }

    private void ensureCellExists(int row, int col)
    {
        if (row < 0 || row >= MAX_ROWS)
            throw new Exception();

        if (col < 0 || col >= MAX_COLS)
            throw new Exception();
    }

    private void generateCells()
    {
        for (var row = 0; row < MAX_ROWS; row++)
            for (var col = 0; col < MAX_COLS; col++)
            {
                var cell = new Cell(row, col);
                cell.setFontFamily(fontFamily);
                cells[row,col] = cell;
            }
    }

    public void render()
    {
        for (var row = 0; row < MAX_ROWS; row++)
            for (var col = 0; col < MAX_COLS; col++)
                cells[row,col].render();
    }
}
