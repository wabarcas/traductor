using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {

            DoIt();

        }

        public static void DoIt()
        {
            bool continuar = true;
            try
            {
                while (continuar==true) {
                    var mngUsuario = new UsuarioManagment();
                    var mngIdioma = new IdiomaManagment();
                    var usuario = new Usuario();
                    var idioma = new Idioma();


                    Console.WriteLine("Traductor");
                    Console.WriteLine("1.Digte el id y el nombre separados por una coma");
                    var user = Console.ReadLine();
                    var infoArrayUsuario = user.Split(',');
                    usuario = new Usuario(infoArrayUsuario);
                    mngUsuario.Create(usuario);
                    Console.WriteLine("Hola" + user);
                    Console.WriteLine("Digite el idioma que desee");
                    var idio = Console.ReadLine();
                    var infoArrayIdioma = idio.Split(',');
                    idioma = new Idioma(infoArrayIdioma);
                    mngIdioma.Create(idioma);


                    Console.WriteLine("¿Desea continuar?");
                    var respuesta = Console.ReadLine();
                    if(respuesta=="si")
                    {
                        continuar = true;
                    }
                    else
                    {
                        continuar = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("***************************");
            }
            finally
            {
                Console.WriteLine("Continue? Y/N");
                var moreActions = Console.ReadLine();

                if (moreActions.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                    DoIt();
            }


        }
    }
}
