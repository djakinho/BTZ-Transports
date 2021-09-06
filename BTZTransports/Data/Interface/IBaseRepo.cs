using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Data.Interface
{
    public interface IBaseRepo<T> where T : class
    {
        void Adicionar(T entity);
        void Editar(T entity);
        T Selecionar(int id);
        List<T> SelecionarTudo();
        void Apagar(int id);
        void Dispose();
    }
}
