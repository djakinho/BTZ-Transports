using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Models
{
    public class Veiculo : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Placa precisa ser preenchido")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "O Nome do Veículo precisa ser selecionado")]
        public string NomeVeiculo { get; set; }
        [Required(ErrorMessage = "O Tipo de Combustível precisa ser preenchido")]
        public Combustivel TipoCombustivel { get; set; }
        [Required(ErrorMessage = "O campo Fabricante precisa ser preenchido")]
        public string Fabricante { get; set; }
        [Required(ErrorMessage = "O Ano de Fabricação precisa ser preenchido")]
        public string AnoFabricacao { get; set; }
        [Required(ErrorMessage = "A Capacidade Máxima do Tanque precisa ser preenchida")]
        public decimal CapacidadeMaximaTanque { get; set; }
        public string? Observacao { get; set; }
        public List<Abastecimento> Abastecimentos { get; set; }
        public int IdCombustivel { get; set; }
    }
}
