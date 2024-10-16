using Xunit;

namespace SAMS.Temperatura.UnitTest.AppxUnit
{
    public class TemperatureTest
    {
        [Fact]
        public void CelsiusToFahrenheit_ShouldReturnCorrectValue()
        {
            // Arrange
            double celsius = 0;
            double expectedFahrenheit = 32;

            // Act
            TemperatureConverter converter = new TemperatureConverter();
            double actualFahrenheit = converter.CelsiusToFahrenheit(celsius);

            // Assert con tolerancia para asegurar que no haya problemas de precisión decimal
            Assert.Equal(expectedFahrenheit, actualFahrenheit, 1);
        }

        [Fact]
        public void FahrenheitToCelsius_ShouldReturnCorrectValue()
        {
            // Arrange
            double fahrenheit = 32;
            double expectedCelsius = 0;

            // Act
            TemperatureConverter converter = new TemperatureConverter();
            double actualCelsius = converter.FahrenheitToCelsius(fahrenheit);

            // Assert con tolerancia para asegurar que no haya problemas de precisión decimal
            Assert.Equal(expectedCelsius, actualCelsius, 1);
        }
    }
}
