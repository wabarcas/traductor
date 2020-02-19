using DataAccess.Crud;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class IdiomaManagment
    {
        private IdiomaCrudFactory crudIdioma;

        public IdiomaManagment()
        {
            crudIdioma = new IdiomaCrudFactory();
        }

        public void Create(Idioma idioma)
        {

            crudIdioma.Create(idioma);

        }


        public List<Idioma> RetrieveAll()
        {
            return crudIdioma.RetrieveAll<Idioma>();
        }

        public Idioma RetrieveById(Idioma idioma)
        {
            return crudIdioma.Retrieve<Idioma>(idioma);
        }
    }
}