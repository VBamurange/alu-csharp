using System;
class Program
{
    public static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int ld = number % 10;
        Console.Write($"The last digit of {number} is {ld}");
        if(ld > 5){
            Console.WriteLine(" and is greater than 5");
        }else if(ld == 0){
            Console.WriteLine(" and is 0");
        }else if(ld < 6 && ld != 0){
            Console.WriteLine(" and is less than 6 and not 0");
        }
    }
}
