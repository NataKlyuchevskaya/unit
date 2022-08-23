void Zadacha64()
{
    //Задайте значения M и N. Напишите программу, которая выведет все  
    //натуральные числа кратные 3-ём в промежутке от M до N.
Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

string Rec(int a, int b)
    {
        if(a<=b) return $"{a}  " + Rec(a+1, b);
        else return String.Empty;
    }
Console.WriteLine(Rec(m, n) + " ");

int fact = 3;
for (int i = 3; i <= m; i++)
{
    fact *= i;
}
Console.WriteLine($" количество чисел кратных 3-м от {m} до {n} равно {fact}");
}



 void Zadacha66()   
 {
    //Задайте значения M и N. Напишите программу, которая найдёт сумму 
    //натуральных элементов в промежутке от M до N.
    Console.WriteLine("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int counter = 1;

    string Recursion(int a, int b, int sum, int counter = 1)
        {
            if (counter > b);
            Console.Write(counter + " ");
            counter++;
            return Recursion(a, b, counter, sum);
        }
    Console.WriteLine($"сумма натуральных элементов от {a} до {b} равна {Recursion(sum)}");
}




//Напишите программу вычисления функции Аккермана с помощью 
//рекурсии. Даны два неотрицательных числа m и n.   m = 2, n = 3 -> A(m,n) = 9

void Recursion(int m, int n, int resalt)
{
        if (m == 0)
            {
            return resalt;
            }
        result = n +1;
        m--;
        return Recursion(m, n, resalt);
        else if (m > 0 && n = 0)
            {
                return resalt;
            }
        resalt = (m - 1, 1);
        m--;
        else if (m > 0 && n > 0)
            {
                return resalt;
            }
        resalt = (m - 1, (m, n - 1));
        m--;
}


//Zadacha64();
//Zadacha66();
Recursion( m, n, resalt);