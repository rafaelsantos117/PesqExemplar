using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLivros.Models.BusinessController
{
    public class ExemplarBusinessController
    {
        QLivrosEntities db = new QLivrosEntities();
        public IQueryable<TabExemplar> FiltrarTitulo(string titulo)
        {
            var lista = db.TabExemplar.Where(x => x.TabTitulo.nmTitulo == titulo);
            return lista;
        }
    }
}
