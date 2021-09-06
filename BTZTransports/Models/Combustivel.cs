using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Models
{
    public class Combustivel : IEntity
    {
        protected internal readonly string Nome;
        protected internal readonly decimal Preco;

        private Combustivel(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
            //_ = new Combustivel("Gasolina", 4.29m);
            //_ = new Combustivel("Etanol", 2.99m);
            //_ = new Combustivel("Diesel", 2.09m);
        }

        public int Id { get; set; }
        public List<Abastecimento> Abastecimentos { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    }
}
