namespace BtkAkademiAIblog.WebApi.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }
        public List<Article> Articles { get; set; } = new();

  }
}
