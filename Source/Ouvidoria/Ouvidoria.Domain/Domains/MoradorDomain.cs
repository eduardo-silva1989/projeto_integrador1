using Ouvidoria.Domain.Classes;
using Ouvidoria.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouvidoria.Domain.Domains
{
    public class MoradorDomain : IMoradorDomain
    {
        public bool Criar(Reclamacao item)
        {
            throw new NotImplementedException();
        }

        public List<Reclamacao> Listar(string CodUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
