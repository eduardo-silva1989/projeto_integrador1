using Ouvidoria.Domain.Classes;
using Ouvidoria.Domain.Interfaces;
using Ouvidoria.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouvidoria.Domain.Domains
{
    public class UsuarioDomain : IUsuarioDomain
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioDomain(IUsuarioRepository usuarioRepository) {
            _usuarioRepository = usuarioRepository;
        }
        public Usuario Autenticar(string login, string senha)
        {
            return _usuarioRepository.
        }
    }
}
