using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisEjerciciosDeBurbujeo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1- constructor - instancia - program
            //2- static - instancia - program
            //3- instancia - static - constructor - program
            //4- 3 metodos static - program
            //5- 3 instancias- static- constructor- program

            //------------------------------------------------------------------

            //Ejercicio 1
            MiClase2 objClase2 = new MiClase2();

            try
            {
                objClase2.MetodoInstancia();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + " - Llegue al Program\n");
            }


            //------------------------------------------------------------------
            //Ejercicio 2

            try
            {
                objClase2.MetodoInstancia2();
            }
            catch (Exception ex)
            {


                Console.WriteLine(ex.Message + " - Llegue al Program\n");
            }

            //------------------------------------------------------------------
            //Ejercicio 3

            try
            {
                Miclase3 objClase3 = new Miclase3();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + " - Llegue al Program\n");
            }

            //------------------------------------------------------------------
            //Ejercicio 4

            try
            {
                Miclase3.MetodoStatic3();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + " - Llegue al Program\n");
            }

            //------------------------------------------------------------------
            //Ejercicio 5

            try
            {
                MiClase2 objClaseDos = new MiClase2("Ejercicio 5"); 
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + " - Llegue al Program\n");
            }



            Console.ReadKey();

        }
    }
}
