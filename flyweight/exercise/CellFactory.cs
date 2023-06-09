public class CellFactory
{
    private Dictionary<int, SharedCell> dictionary = new Dictionary<int, SharedCell>();

    public SharedCell GetSharedCell(int size, string family, bool isBold)
    {
        var sharedCell = new SharedCell(family, size, isBold);
        var hash = sharedCell.GetHashCode();
        if (!dictionary.ContainsKey(hash))
        {
            dictionary.Add(hash, sharedCell);
        }
        return dictionary[hash];
    }
}