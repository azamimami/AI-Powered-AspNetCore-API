namespace BtkAkademiAIblog.WebApi.Entities
{
    public class About
    {
        public int AboutID { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
    }

}
