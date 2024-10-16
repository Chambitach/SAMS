using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            // Arrange
            double celsius = 0; // Valor de prueba (Celsius)
            double expectedFahrenheit = 32; // Valor esperado en Fahrenheit

            // Act
            TemperatureConverter converter = new TemperatureConverter(); // Crear una instancia de la clase
            double actualFahrenheit = converter.CelsiusToFahrenheit(celsius); // Ejecutar el método

            // Assert
            Assert.AreEqual(expectedFahrenheit, actualFahrenheit, "La conversión de Celsius a Fahrenheit no es correcta.");
        }
    }
}
