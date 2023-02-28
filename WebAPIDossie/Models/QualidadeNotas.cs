namespace WebAPIDossie.Models
{
    public class QualidadeNotas : Entity
    {
        public DateTime DT_MONITORIA { get; set; }
        public int CMS { get; set; }
        public string? ILHA { get; set; }
        public float NOTA { get; set; }
    }
}
