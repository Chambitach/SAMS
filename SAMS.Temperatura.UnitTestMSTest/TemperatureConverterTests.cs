[TestClass]
public class TemperatureConverterTests
{
    private TemperatureConverter _converter;

    public TemperatureConverterTests(TemperatureConverter converter)
    {
        _converter = converter;
    }

    public TemperatureConverter Converter { get => _converter; set => _converter = value; }

    [TestInitialize]
    public void Setup()
    {
        Converter = new TemperatureConverter();
    }

    [TestMethod]
    public void TestCelsiusToFahrenheit()
    {
        double result = Converter.CelsiusToFahrenheit(0);
        Assert.AreEqual(32, result);
    }

    [TestMethod]
    public void TestFahrenheitToCelsius()
    {
        double result = Converter.FahrenheitToCelsius(32);
        Assert.AreEqual(0, result);
    }
}
