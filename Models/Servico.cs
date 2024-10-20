namespace Agendify.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Preco { get; set; } = 0m;
        public int AreaDeAtuacaoId { get; set; }

        public Area AreaDeAtuacao { get; set; }
    }
}