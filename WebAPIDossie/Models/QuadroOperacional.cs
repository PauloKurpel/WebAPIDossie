namespace WebAPIDossie.Models
{
    public class QuadroOperacional : Entity
    {
        public int LOGID { get; set; }
        public int MATRICULA { get; set; }
        public string? FUNCIONARIO { get; set; }
        public string? SITUACAO { get; set; }
        public string? PS { get; set; }
        public string? SUPERVISOR { get; set; }
        public string? COORDENADOR { get; set; }
        public string? CARGA_HORARIA { get; set; }
    }
}
