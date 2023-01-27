namespace TestApiCb.Models
{
    public class Root
    {
        public string? Date { get; set; }
        public string? PreviousDate { get; set; }
        public string? PreviousURL { get; set; }
        public string? Timestamp { get; set; }
        public Dictionary<string, Valutes>? Valute { get; set; }
    }
}
