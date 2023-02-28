namespace WebAPIDossie.Models
{
    public class Pesquisa : Entity
    {
        public DateTime DATA { get; set; }
        public string? SISAMIL { get; set; }
        public string? ILHA { get; set; }
        public int RESOLUTIVIDADE { get; set; }
        public string? PROTOCOLO { get; set; }
    }
}
