namespace Quote.Models.Provider
{
    internal class Pagination
    {
        public int ItemsPerPage { get; set; }
        public int Page { get; set; }
        public int? TotalItems { get; set; }
    }
}
