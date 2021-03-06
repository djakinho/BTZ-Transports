using BTZTransports.Data.Interface;
using BTZTransports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Data.Repo
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class, IEntity
    {
        protected readonly Contexto _contexto;
        public BaseRepo(Contexto contexto)
        {
            _contexto = contexto;
        }

        public virtual void Adicionar(T entity)
        {
            _contexto.Set<T>().Add(entity);
            _contexto.SaveChanges();
        }

        public void Editar(T entity)
        {
            _contexto.Set<T>().Update(entity);
            _contexto.SaveChanges();
        }

        public virtual T Selecionar(int id)
        {
            return _contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public virtual List<T> SelecionarTudo()
        {
            return _contexto.Set<T>().ToList();
        }

        public void Apagar(int id)
        {
            var entity = Selecionar(id);
            _contexto.Set<T>().Remove(entity);
            _contexto.SaveChanges();
        }
        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
