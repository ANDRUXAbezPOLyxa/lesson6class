// программа, принимающая на вход 3 числа и поазывающая есть ли треугольни таой длинны ( длина одной стороны не может превышать сумму двух других)
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("введите третье число");
int c = int.Parse(Console.ReadLine());
if ( (a+b) > c && (b+c)> a && ( a+c) > b)
{
 Console.WriteLine("треугольник со сторонами " + a + "," + b + "," + c + " существует");
}
else
 {
Console.WriteLine("треугольник со сторонами " + a + "," + b + "," + c + " не существует");
 }
