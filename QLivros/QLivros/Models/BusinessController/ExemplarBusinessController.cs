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
        public IQueryable<Exemplar> FiltrarTitulo(string titulo)
        {
            var lista = db.Exemplar.Where(x => x.Titulo.nome == titulo);
            return lista;
        }
    }
}
