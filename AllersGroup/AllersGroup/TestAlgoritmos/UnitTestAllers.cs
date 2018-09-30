using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllersGroup;
using System.Collections.Generic;


namespace TestAlgoritmos
{
    [TestClass]
    public class UnitTestAllers
    {

        Controlador controlador;
        public void Escenario()
        {
            
            double minSup = 0.03;
            double mincof = 0.5;
            controlador = new Controlador(mincof,minSup);
        }

        [TestMethod]
        public void TestCargarArticulos()
        {
            Escenario();
            try
            {
                controlador.CargarArticulos();
                Assert.IsNotNull(controlador.Articulos);
            }
            catch
            {
                Assert.Fail();
            }


        }

        [TestMethod]
        public void TestCargarClientes()
        {
            Escenario();
            try
            {
                controlador.CargarClientes();
                Assert.IsNotNull(controlador.Clientes);

            }
            catch
            {
                Assert.Fail();
            }



        }

        [TestMethod]
        public void TestCargarVentas()
        {
            Escenario();

            try
            {
                controlador.CargarVentas(Controlador.rutaVentas);
                Assert.IsNotNull(controlador.Ventas);
            }
            catch
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void TestCombinar()
        {


            Escenario();
            int[] arreglo = { 1, 2, 3 };
            List<List<int>> listResult = new List<List<int>>();
            listResult = controlador.CombinacionHasta7(3, arreglo);

            List<int> comExistente = new List<int>() { 1, 3, 2 };
            List<int> combinacion = new List<int>();

            for (int i = 0; i < listResult.Count; i++)
            {
                combinacion = listResult[i];
                for (int j = 0; j < combinacion.Count; j++)
                {
                    if (combinacion[j] == comExistente[j])
                    {
                        Assert.AreEqual(combinacion[j], comExistente[j]);
                    }

                }

            }
        }

        [TestMethod]
        public void TestRepeticionEnVentas()
        {

            
            Escenario();
            controlador.CargarDatos();

            int[] arreglo = { 1, 2, 3 };
            List<List<int>> numeros = controlador.CombinacionHasta7(2,arreglo);
            List<int> combinacion = new List<int>();
            combinacion = numeros[0];

            int cantRepeticiones = 0;
            cantRepeticiones = controlador.RepeticionEnVentasP(combinacion);
            Assert.AreEqual(cantRepeticiones, 0);
            
        }


        [TestMethod]
        public void TestGenerarAsociaciones()
        {
            Escenario();
            int tamahno = 3;
            int articulos = 5;

            //controlador.generarAsociaciones(tamahno, articulos);

            //Assert.IsNotNull(controlador.CombinacionesPorTamano);
            //Assert.IsNotNull(controlador.RespuestasPorTamano);
            //Assert.IsNotNull(controlador.SuportPorTamano);
            
        }
        
        [TestMethod]
        public void TestSoporteAsociaciones()
        {
            Escenario();

            //controlador.CargarDatos();
            controlador.CargarDatosPrueba();

            controlador.generarAsociaciones(3,5);
            int[] arreglo = { 1, 2, 3 };
            List<List<int>> todo = controlador.CombinacionHasta7(2, arreglo);
            Assert.IsNotNull(todo);
            List<double> soporte = controlador.soporteAsociaciones(todo, 0);
            Assert.AreEqual(soporte[0], 0.8);

            
        }

        [TestMethod]
        public void TestConfianzaAsocianes()
        {
            Escenario();

            controlador.CargarDatosPrueba();
            controlador.generarAsociaciones(3,5);

            int[] arreglo = { 1, 2, 3, 4, 5 };
            List<List<int>> todo = controlador.CombinacionHasta7(4, arreglo);
            Assert.IsNotNull(todo);
            List<double> confianza = controlador.confianzaAsociaciones(todo, 1);
            Assert.AreEqual(confianza[0], 0, 75);
            
        }


    }


        
}
