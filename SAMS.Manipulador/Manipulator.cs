public class Manipulator
{
    // Método para invertir una cadena
    public string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Método para eliminar los espacios en blanco
    public string RemoveSpaces(string input)
    {
        return input.Replace(" ", "");
    }
}
