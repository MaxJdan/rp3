Console.Clear();
Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
int sqr = number * number;
Console.WriteLine("квадрат числа " + number + " равен= " + sqr);
