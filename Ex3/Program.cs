// Нахождение факториала методом рекурсии
//5!=5*4*3*2*1
//   5*!4
//     4*!3
//       3*!2
//          2*!1

double Factorial (int n)
{
    if (n == 1) 
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}
//Console.WriteLine(Factorial(5));
    
    for (int i = 1; i < 40; i++)
    {
        Console.WriteLine($"!{i} = {Factorial(i)}");
    }

