using Ouvidoria.Domain.Classes;
using Ouvidoria.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouvidoria.Domain.Domains
{
    public class SindicoDomain : ISindicoDomain
    {
        public bool AtualizarReclamacao(Reclamacao item)
        {
            throw new NotImplementedException();
        }

        public List<Reclamacao> ListarReclamacao()
        {
            throw new NotImplementedException();
        }
    }
}
