// введите число, его переведут из десятичной системы в двоичную
Console.WriteLine("введите число чтобы преобоазить его в двоичную систему");
int n = int.Parse(Console.ReadLine());
int sum = 0;
string b ="";
while (n >=1)
{
    sum = n % 2;
    b = sum +b;

n = n/2;
}
Console.WriteLine(b);

