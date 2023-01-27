internal class Program
{
  private static void Main(string[] args)
  {
    //Console.Clear();
    Console.Write("введите число: ");
    int number1 = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    int number2 = int.Parse(Console.ReadLine());
    if (number1 == number2 * number2)
    {
      Console.WriteLine( number1 + " является квадратом " + number2);
      }
    else 
    {
      Console.WriteLine( number1 + " не является квадратом " + number2);
    }  
  
   
  }
}