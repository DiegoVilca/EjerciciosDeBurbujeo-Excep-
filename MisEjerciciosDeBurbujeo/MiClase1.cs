using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisEjerciciosDeBurbujeo
{
    public class MiClase1
    {
        string ejercicio;
        public MiClase1()
        {
            throw new Exception("Parto del constructor");
        }

        public MiClase1(string ejercicio)
        {

        }

        public void MetodoInstancia1()
        {
            throw new Exception("Parto del primer metodo de instancia");
        }

        public void MetodoInstancia2()
        {
            try
            {
                MetodoInstancia1();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message + " - Paso por el segundo metodo de instancia");
            }
        }

        public void MetodoInstancia3()
        {
            try
            {
                MetodoInstancia2();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message + " - Paso por el tercer metodo de instancia");
            }
        }

        public static void MetodoStatic()
        {
            try
            {
                MiClase1 objClase1 = new MiClase1("ejercicio 5");
                objClase1.MetodoInstancia3();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message + " - Paso por el metodo static");
            }
        }
    }
}
