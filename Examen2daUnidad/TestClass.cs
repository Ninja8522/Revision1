using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daUnidad
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Suma()
        {
            double[] numeros = { 5, 7, 8, 8, 9, 9, 9, 9, 10, 10 };
            double esperado = 84;
            Pruebas x = new Pruebas();
            var suma = x.suma(numeros);
            Assert.AreEqual(esperado, suma);
        }
        [Test]
        public void Promedio()
        {
            double[] numeros = { 5, 7, 8, 8, 9, 9, 9, 9, 10, 10 };
            double esperado = 8.4;
            Pruebas x = new Pruebas();
            var promedio = x.promedio(numeros);
            Assert.AreEqual(esperado, promedio);
        }
        [Test]
        public void Moda()
        {
            double[] numeros = { 5, 7, 8, 8, 9, 9, 9, 9, 10, 10 };
            double esperado = 9;
            Pruebas x = new Pruebas();
            var promedio = x.moda(numeros);
            Assert.AreEqual(esperado, promedio);
        }
        [Test]
        public void Medaina()
        {
            double[] numeros = { 5, 7, 8, 8, 9, 9, 9, 9, 10, 10 };
            double esperado = 9;
            Pruebas x = new Pruebas();
            var promedio = x.mediana(numeros);
            Assert.AreEqual(esperado, promedio);
        }
    }
}
