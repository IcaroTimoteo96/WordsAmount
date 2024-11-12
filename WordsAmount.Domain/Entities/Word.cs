namespace WordsAmount.Domain.Entities
{
    public class Word
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
