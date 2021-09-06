using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Models
{
    public class Motorista : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome precisa ser preenchido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo CPF precisa ser preenchido")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O campo CNH precisa ser preenchido")]
        public string Cnh { get; set; }
        [Required(ErrorMessage = "A Categoria da CNH precisa ser preenchida")]
        public string CategoriaCnh { get; set; }
        [Required(ErrorMessage = "A Data de Nascimento do Motorista precisa ser preenchida")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "O Status do Motorista precisa ser preenchido")]
        public bool Status { get; set; }
        public List<Abastecimento> Abastecimentos { get; set; }
    }
}
