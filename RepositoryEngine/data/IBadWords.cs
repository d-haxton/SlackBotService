namespace RepositoryEngine.data
{
    public interface IBadWords
    {
        string Word { get; set; }
        EBadWord Action { get; set; }
    }
}