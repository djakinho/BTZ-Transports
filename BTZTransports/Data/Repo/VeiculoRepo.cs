using BTZTransports.Data.Interface;
using BTZTransports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Data.Repo
{
    public class VeiculoRepo : BaseRepo<Veiculo>, IVeiculoRepo
    {
        public VeiculoRepo(Contexto contexto) : base(contexto)
        {
        }
    }
}
