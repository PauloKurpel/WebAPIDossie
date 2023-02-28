namespace WebAPIDossie.Models

{
    public class AderenciaWfo : Entity
    {
        public int MATRICULA { get; set; }
        public DateTime DATA { get; set; }
        public string? FUNCIONARIO { get; set; }
        public string? CELULA { get; set; }
        public float ESCALA { get; set; }
        public float ESCALADO { get; set; }
    }
}
