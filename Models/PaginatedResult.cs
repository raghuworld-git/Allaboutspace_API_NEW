namespace Core
{
    public class PaginatedResult<T> where T : class
    {
        public int count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public IEnumerable<T> results { get; set; }
    }
}
