//Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше");
//int a, b;
//Console.WriteLine("Введи свое первое число - ");
//a = Convert.ToInt32(Console.Read());
//Console.WriteLine("Введи свое второе число - ");
//b = Convert.ToInt32(Console.Read());
 
//bool Chto0 = a > b;
//bool Chto1 = a == b;
//bool Chto2 = a < b;
 
//if (Chto0)
//{
    // Console.WriteLine($"Число {a} больше чем {b}");
//}
//else if (Chto1)
//{
    //Console.WriteLine($"Числа {a} и {b} равны");
//}
//else
//{
    //Console.WriteLine($"Число {b} больше чем {a}");
//}

//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Console.WriteLine("Введи 3 числа и мы тебе скажем какое из них MIX");
//Console.WriteLine("Введите число");
//int m1=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число");
//int m2=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число");
//int m3=Convert.ToInt32(Console.ReadLine());
//if (m1 > m2) 
//{
    //int Mmax = 0;
    //m1 = Mmax;
//}
//else
//{
    //int Mmax = 0;
    //m2 = Mmax;
//}
//if (m2 > m3)
//{
    //int Mmax = 0;
    //m2 = Mmax;
//}
//else
//{
    //int Mmax = 0;
    //m3 = Mmax;
//}
//if (m3 > m1)
//{
    //int Mmax = 0;
    //m3 = Mmax;
//}
//else
//{
    //int Mmax = 0;
    //m1 = Mmax;
//}

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

//Console.WriteLine("Уточни число");
//int number = Convert.ToInt32(Console.ReadLine());

//int remDiv = number % 2;

//if(remDiv == 0)
//{
    //Console.WriteLine("Да");
//}
//else
//{
    //Console.WriteLine("Нет");
//}

//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int evenNumber = 2;

//if(number > 1)
//{
    //while(evenNumber <= number)
    //{
        //Console.Write(evenNumber + " ");
        //evenNumber = evenNumber + 2;
    //}
//}

