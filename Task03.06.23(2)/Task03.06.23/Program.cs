//Task 3.1

//int num = 30;
//while (num > 1)
//{
//    if (num % 2 == 0)
//    {
//        Console.WriteLine("2-nin quvvetidir");

//    }

//    else
//    {
//        Console.WriteLine("2-nin quvveti deyil");
//        break;
//    }
//    num /= 2;
//}



////Task 3.2
//String s;
//int num = 15;
//s = num.ToString();
//for (int i = 0; i < num; i++)
//{
//    if (Math.Pow(i, 2) == num)
//    {
//        Console.WriteLine("2nin quvvətidir");
//    }
//}

//Task 3.3
int num1 = 64;
int times = 0;
var a = 1;
int num = num1 * 2;
while (num * 2 > 0)
{
    num /= 2;
    times++;
}
times -= 2;
while (times > 0)
{
    a *= 2;
    times--;
}
if (a == num1)
{
    Console.WriteLine("Rəqəm ikinin qüvvətidir");
}
else
{
    Console.WriteLine("Rəqəm ikinin qüvvəti deyil");
}


// Task 4 
//int num = 24861952;
//var First_wave = 0;
//var Biggest = 0;
//if (num < 0)
//{
//    num *= (-1);
//}
//while (num > 0)
//{
//    First_wave = num % 10;
//    if (First_wave > Biggest)
//    {
//        Biggest = First_wave;
//    }
//    num /= 10;
//}
//Console.WriteLine(Biggest);



