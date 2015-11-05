using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLivros.Models.BusinessController
{
    public class ProprietarioBusinessController
    {
        QLivrosEntities db = new QLivrosEntities();

        public Leitor ObterContatos(long id)
        {
            var leitor = db.Leitor.Where(model => model.id.Equals(id)).SingleOrDefault();
            return leitor;
        }
    }
}
