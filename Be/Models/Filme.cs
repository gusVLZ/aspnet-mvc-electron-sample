using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Be.Models
{
    public class Filme
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Nome do filme")]
        public string Nome { get; set; }
        [DisplayName("Sinopse do filme")]
        public string Descricao { get; set; }
        [DisplayName("Ano de lançamento")]
        public int AnoLancamento { get; set; }
    }
}
