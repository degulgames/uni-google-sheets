namespace GoogleSheet
{
    public interface ITable
    {
        string GetSheetID();
        List<ITable> GetList();
        Dictionary<int, ITable> GetDictionary();
    }
}