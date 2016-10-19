using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisEjerciciosDeBurbujeo
{
    public class MiClase2
    {

        string ejercicio;


        public MiClase2()
        {

        }

        public MiClase2(string ejercicio)
        {
            try
            {
                MiClase1.MetodoStatic();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message + " - Paso por el constructor");
            }
        }


        public void MetodoInstancia()
        {
            try
            {
                MiClase1 objClase1 = new MiClase1();
            }
            catch (Exception exAnterior)
            {
                Exception exActual = new Exception(" - Paso por un metodo");

                throw new Exception(exAnterior.Message + exActual.Message);
                
            }
        }

        
        public static void MetodoStatic()
        {
            throw new Exception("Parto del metodo static");
        }


        public void MetodoInstancia2()
        {
            try
            {
                MiClase2.MetodoStatic();
            }
            catch (Exception exAnterior)
            {
                Exception exActual = new Exception(" - Paso por el metodo de instancia");

                throw new Exception(exAnterior.Message + exActual.Message);
            }
        }


        public void MetodoInstancia3()
        {
            throw new Exception("Parto de un Metodo de instancia");
        }

        public static void MetodoStatic2()
        {
            try
            {
                MiClase2 objClase2 = new MiClase2();
                objClase2.MetodoInstancia3();
            }
            catch (Exception exAnterior)
            {
                Exception exActual = new Exception(" - Paso por un metodo static");

                throw new Exception(exAnterior.Message + exActual.Message);
                
            }
        }

    }
}
