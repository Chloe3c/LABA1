//U = ln(k- y) + y**4 / e**y + 2,355 * k**2  записать арифметическое выражение на алг языке и указать порядок выполнения действий.
try
{
    Console.Write("введите k: ");
    int k = int.Parse(Console.ReadLine());
    Console.Write("введите y: ");
    int y = int.Parse(Console.ReadLine());
    Console.Write("введите e: ");
    int e = int.Parse(Console.ReadLine());
    double U = (Math.Log(k - y) + Math.Pow(y, 4)) / (Math.Pow(e, y) + 2.355 * Math.Pow(k, 2));
    Console.WriteLine($"{U:F2}");
}
catch 
{
    Console.Write("Введите правильно!");
}