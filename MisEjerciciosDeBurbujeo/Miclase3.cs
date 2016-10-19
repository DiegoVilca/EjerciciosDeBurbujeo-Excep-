using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisEjerciciosDeBurbujeo
{
    public class Miclase3
    {

        public Miclase3()
        {

            try
            {
               MiClase2.MetodoStatic2();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + " - Paso por un constructor");
            }
            
        }

        public static void MetodoStatic1()
        {
            throw new Exception("Parto del primer metodo static");
        }

        public static void Metodostatic2()
        {
            try
            {
                Miclase3.MetodoStatic1();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message + " - Paso por el segundo metodo static");
            }
        }

        public static void MetodoStatic3()
        {
            try
            {
                Miclase3.Metodostatic2();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message + " - Paso por el tercer metodo static");
            }
        }


    }
}
