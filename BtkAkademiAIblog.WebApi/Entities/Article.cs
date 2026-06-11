namespace BtkAkademiAIblog.WebApi.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string CoverImageUrl { get; set; }
        public required string MainImageUrl { get; set; }
        public required string Content { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
  }
}
