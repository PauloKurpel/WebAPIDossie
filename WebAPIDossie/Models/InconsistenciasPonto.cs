namespace WebAPIDossie.Models
{
    public class InconsistenciasPonto : Entity
    {
        public int MATRICULA { get; set; }
        public DateTime DATA { get; set; }
        public string? DESCRICAO_OCORRENCIA { get; set; }
    }
}
