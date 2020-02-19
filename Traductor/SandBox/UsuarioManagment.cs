using DataAccess.Crud;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class UsuarioManagment
    {
        private UsuarioCrudFactory crudUsuario;

        public UsuarioManagment()
        {
            crudUsuario = new UsuarioCrudFactory();
        }

        public void Create(Usuario usuario)
        {

            crudUsuario.Create(usuario);

        }


        public List<Usuario> RetrieveAll()
        {
            return crudUsuario.RetrieveAll<Usuario>();
        }

        public Usuario RetrieveById(Usuario usuario)
        {
            return crudUsuario.Retrieve<Usuario>(usuario);
        }

        internal void Update(Usuario usuario)
        {
            crudUsuario.Update(usuario);
        }

        internal void Delete(Usuario usuario)
        {
            crudUsuario.Delete(usuario);
        }
    }
}
