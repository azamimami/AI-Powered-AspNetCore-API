namespace BtkAkademiAIblog.WebApi.Dtos.ArticleDtos
{
  public class CreatArticleDto
  {
        public  string Title { get; set; }
        public  string CoverImageUrl { get; set; }
        public  string MainImageUrl { get; set; }
        public  string Content { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public int CategoryId { get; set; }
  }
}