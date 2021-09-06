﻿using BTZTransports.Data.Interface;
using BTZTransports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Data.Repo
{
    public class AbastecimentoRepo : BaseRepo<Abastecimento>, IAbastecimentoRepo
    {
        public AbastecimentoRepo(Contexto contexto) : base(contexto)
        {
        }
    }
}
