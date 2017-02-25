namespace Carmel.Models
{
    public class Gist
    {
        public int Id { get; set; }
        public bool isPrivate { get; set; } = true;
        public string Url { get; set; }
    }
}
