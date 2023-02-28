namespace WebAPIDossie.Models
{
    public class Atrasos : Entity
    {
        public int MATRICULA { get; set; }
        public DateTime DATA { get; set; }
        public string? OCORRENCIA { get; set; }
    }
}
