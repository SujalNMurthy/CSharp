using System;
public class Arthematic
{
public static void Main(string [] args)
{
System.Console.WriteLine("Enter a First Number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter a Second Number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
try{
System.Console.WriteLine("Adddition     :{0} + {1} = {2}", num1, num2, num1 + num2);
System.Console.WriteLine("Subtraction   :{0} - {1} = {2}", num1, num2, num1 - num2);
System.Console.WriteLine("Multiplication:{0} x {1} = {2}", num1, num2, num1 * num2);
System.Console.WriteLine("Mod		:{0} mod {1} = {2}", num1, num2, num1 % num2);
System.Console.WriteLine("Division      :{0} / {1} = {2}", num1, num2, num1 / num2);

}
 catch (DivideByZeroException ex)
        {
            Console.WriteLine("DivideByZeroException caught!");
            Console.WriteLine(ex.Message);
}
}
}
