namespace Agendify.Models
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Servico> Servicos { get; set; }
    }
}