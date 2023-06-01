using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleRecursosDAE.DAO
{
    public interface GenericDAO<T> where T : class
    {
        public int salvar(T entity);
        public int apagar(int id);
        public List<T> listar();
        public int atualizar(T entity);
    }
}
