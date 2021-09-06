using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Models
{
    public class Abastecimento : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A Data de Abastecimento precisa ser preenchida")]
        public DateTime Data { get; set; }
        [Required(ErrorMessage = "A Quantidade de combustível Abastecida precisa ser preenchida")]
        public double QuantidadeAbastecida { get; set; }
        [Required(ErrorMessage = "Um Veículo precisa ser escolhido")]
        public int IdVeiculo { get; set; }
        [Required(ErrorMessage = "Um Motorista precisa ser escolhido")]
        public int IdMotorista { get; set; }
        [Required(ErrorMessage = "O Tipo de Combustível precisa ser preenchido")]
        public int IdCombustivel { get; set; }
        public Veiculo Veiculo { get; set; }
        public Motorista Motorista { get; set; }
        public Combustivel Combustivel { get; set; }
    }
}
