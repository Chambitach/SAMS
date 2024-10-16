using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class StringManipulatorTests
{
    [TestMethod]
    public void ReverseString_InputIsHello_ShouldReturnOlleh()
    {
        // Arrange
        Manipulator manipulator = new Manipulator();
        string input = "Hello";
        string expected = "olleH";

        // Act
        string result = manipulator.ReverseString(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void RemoveSpaces_InputIsHelloWorld_ShouldReturnHelloWorld()
    {
        // Arrange
        Manipulator manipulator = new Manipulator();
        string input = "Hello World";
        string expected = "HelloWorld";

        // Act
        string result = manipulator.RemoveSpaces(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
