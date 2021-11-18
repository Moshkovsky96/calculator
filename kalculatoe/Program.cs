// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double first = Input();
char sign = Sign();
double second = Input();
double result = GetResult(first, second, sign);
char sign1 = Sign();
double third = Input();
double result2 = GetResult(result, third, sign1);
char sign2 = Sign();
double fourth = Input();
double result3 = GetResult(result2, fourth, sign2);
char sign3 = Sign();
double fifth = Input();
double result4 = GetResult(result3, fifth, sign3);
Console.WriteLine($"{result4}");



static double Input()
{
    Console.WriteLine("Введите число");
    double num =Convert.ToDouble ( Console.ReadLine());
    
    return num;
} 
static char Sign()
{
    Console.WriteLine("Введите знак");
    char c = Convert.ToChar ( Console.ReadLine());
    return c;
}
static double GetResult(double a, double b,char c)
{
    double result;

    switch (c)
    {
        case '+':
            result = a + b;
            return result;
        case '-':
            result = a - b;
            return result;
        case '*':
            result = a * b;
            return result;
        case '/':
            double zero = CheckZero(b);
            result = a / zero;
            return result;
       default :
             throw new Exception();
    }

}
static double CheckZero(double a)
{
    if (a == 0)
    {
        Console.WriteLine("Деление на 0 не возможно!");
        throw new Exception();
    }
    else
        return a;
}
