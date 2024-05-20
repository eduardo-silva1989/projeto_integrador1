using Ouvidoria.Infrastructure.Classes;
using Ouvidoria.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouvidoria.Infrastructure.Repositories
{
    public class UsuarioRepository: GenericRepository<Usuario>,IUsuarioRepository
    {
        public UsuarioRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
