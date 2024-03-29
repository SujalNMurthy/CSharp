using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------");	
			Console.WriteLine("-- WELCOME TO C# MENU DRIVEN PROGRAM --");
			Console.WriteLine("---------------------------------------------------------------------");	
			Console.WriteLine("Name:SUJAL.N.MURTHY");
			Console.WriteLine("---------------------------------------------------------------------");
			Console.WriteLine("USN:4MH21CS105");
			Console.WriteLine("---------------------------------------------------------------------");
			Console.WriteLine("Faculty Name:Victor Ikechukwu Agughasi");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---                Select the Program from 1 to 12                ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 1  : Arithmetic Operations                          ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 2  : Armstrong Numbers                              ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 3  : Substring of Strings                           ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 4  : Divide By Zero Exception                       ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 5  : Pascal of a Triangle(Print Pattern)            ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 6  : Floyd,s Triangle                               ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 7  : Read and Copy a Text File                      ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 8  : Implementation of Stack Operations             ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 9  : Complex Numbers                                ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 10 : Polymorphism Concepts                          ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 11 : Abstract Class for Calculating the Perimeter   ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 12 : Interface for Resizable                        ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---                         0 For  E X I T                        ---");
            Console.WriteLine("---------------------------------------------------------------------");
			


            int choice;
			bool isValidInput = false;

		do
		{
    Console.WriteLine("Select the program (1-12):");
    string userInput = Console.ReadLine().Trim();

    if (int.TryParse(userInput, out choice))
    {
        if (choice >= 1 && choice <= 12)
            isValidInput = true;
        else
            Console.WriteLine("Please enter a number between 1 and 12.");
    }
    else if (userInput.Length == 1 && char.IsLetter(userInput[0]))
    {
        isValidInput = true;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number or alphabet.");
    }
} while (!isValidInput);
            
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Program 1  : Arithmetic Operation");
                        pro11.pro1();

                        break;
                    case 2:
                        Console.WriteLine("Program 2  : Armstrong Numbers");
                        pro12.pro2();
                        break;
                    case 3:
                        Console.WriteLine("Program 3  : Substring of Strings");
                        pro13.pro3();
                        break;
                    case 4:
                        Console.WriteLine("Program 4  : Divide By Zero Exception");
                        pro14.pro4();
                        break;
                    case 5:
                        Console.WriteLine("Program 5  : Pascal of a Triangle(Print Pattern)");

                        pro15.pro5();
                        break;
                    case 6:
                        Console.WriteLine("Program 6  : Floyd,s Triangle");
                        pro16.pro6();
                        break;
                    case 7:
                        Console.WriteLine("Program 7  : Read and Copy a Text File");
                        pro17.pro7();
                        break;
                    case 8:
                        Console.WriteLine("Program 8  : Implementation of Stack Operations");
                        pro18.pro8();
                        break;
                    case 9:
                        Console.WriteLine("Program 9  : Complex Numbers");
                        pro19.pro9();
                        break;
                    case 10:
                        Console.WriteLine("Program 10 : Polymorphism Concepts");
                        pro110.Program10.pro10();
                        break;
                    case 11:
                        Console.WriteLine("Program 11 : Abstract Class for Calculating the Perimeter");
                        pro111.ShapeClient.pro11();
                        break;
                    case 12:
                        Console.WriteLine("Program 12 : Interface for Resizable");
                        pro112.Program12.pro12();
                        break;
                    case 0:
                        Environment.Exit(1);
                        break;



                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
				
            


            Console.ReadKey();
        }



    }
    public class pro11
    {
        public static void pro1()
        {
	
			
           Console.WriteLine("Enter a First Number: ");
        int num1;
        bool isNum1Valid = int.TryParse(Console.ReadLine(), out num1);

        Console.WriteLine("Enter a Second Number: ");
        int num2;
        bool isNum2Valid = int.TryParse(Console.ReadLine(), out num2);

        if (!isNum1Valid || !isNum2Valid)
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
            return;
        }
 Console.WriteLine("Enter the operator (+, -, *, /, %): ");
        char operation = Convert.ToChar(Console.ReadLine());
		double result = 0;
switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine("Result: {0} + {1} = {2}", num1, num2, result);
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine("Result: {0} - {1} = {2}", num1, num2, result);
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine("Result: {0} * {1} = {2}", num1, num2, result);
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: {0} / {1} = {2}", num1, num2, result);
                }
                break;
            case '%':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Modulo by zero is not allowed.");
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine("Result: {0} % {1} = {2}", num1, num2, result);
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                break;
        }		


	}
	}
    public class pro12
    {
        public static void pro2()
        {
           Console.WriteLine("Enter the starting number: ");
        int start;
        if (!int.TryParse(Console.ReadLine(), out start))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        Console.WriteLine("Enter the ending number: ");
        int end;
if (!int.TryParse(Console.ReadLine(), out end))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }		
		

        Console.WriteLine("Armstrong numbers between {0} and {1}:", start, end);
        for (int i = start; i <= end; i++)
        {
            if (IsArmstrongNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    // Function to check if a number is an Armstrong number
    static bool IsArmstrongNumber(int number)
    {
        int originalNumber, remainder, result = 0, n = 0;

        originalNumber = number;

        // Count the number of digits
        for (originalNumber = number; originalNumber != 0; originalNumber /= 10, ++n) ;

        originalNumber = number;

        // Calculate the sum of nth power of each digit
        while (originalNumber != 0)
        {
            remainder = originalNumber % 10;
            result += (int)Math.Pow(remainder, n);
            originalNumber /= 10;
        }

        // Check if the number is an Armstrong number
        return result == number;

        }
    }
   public class pro13
{
    // Function to check if a string contains numeric characters
    public static bool ContainsNumeric(string str)
    {
        return str.Any(char.IsDigit);
    }

    public static void find_substrings(string input_string)
    {
        // Check if the input string contains numeric characters
        if (ContainsNumeric(input_string))
        {
            Console.WriteLine("Invalid input. The input string should not contain numeric characters.");
            return;
        }

        // Iterate through all possible substrings
        for (int i = 1; i <= input_string.Length; i++)
        {
            for (int j = 0; j <= input_string.Length - i; j++)
            {
                string substring = input_string.Substring(j, i);

                // Print the substring
                Console.WriteLine(substring);
            }
        }
    }

    public static void pro3()
    {
        string input_string;
        Console.WriteLine("Enter a String:");
        input_string = Console.ReadLine();
        find_substrings(input_string);
    }
}

    public class pro14
    {
        public static void pro4()
        {
            try
            {
                int result = 15 / int.Parse("0");
                System.Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.ReadLine();
            }
            System.Console.ReadLine();
            Program.Main(null);
        }
    }

    public class pro15
    {


        public static void pro5()
        {


            Console.Write("Enter the number of rows for Pascal's Triangle: ");
            int numRows;
			        if (!int.TryParse(Console.ReadLine(), out numRows))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }


            Console.Write("Pascal's Triangle:\n");

            for (int i = 0; i < numRows; i++)
            {
                // Print leading spaces
                for (int j = 0; j < numRows - i - 1; j++)
                {
                    Console.Write("  ");
                }

                // Print asterisks representing the numbers in Pascal's Triangle
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*   ");
                }

                Console.WriteLine();  // Move to the next line for the next row
            }
            System.Console.ReadLine();
            Program.Main(null);

        }
    }
    public class pro16
    {

        public static void pro6()
        {

            int row, i, j, num = 1; Console.Write("Enter the number of rows: ");
			        if (!int.TryParse(Console.ReadLine(), out row))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

          
            Console.WriteLine("");
            for (i = 1; i <= row; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
            System.Console.ReadLine();
            Program.Main(null);

        }
    }
    public class pro17
    {



        public static void pro7()
        {

            string file = @"C:\Users\EliteBook\Downloads\document.txt";
            System.Console.WriteLine("Reading File using File.ReadAllText()");
            if (File.Exists(file))
            {
                string str = File.ReadAllText(file);
                System.Console.WriteLine(str);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Reading File using File.ReadAllLines()");
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                foreach (string ln in lines)
                    System.Console.WriteLine(ln);
            }
            System.Console.WriteLine();
            Console.WriteLine("Reading File using StreamReader");
            if (File.Exists(file))
            {
                StreamReader Textfile = new StreamReader(file);
                string line;
                while ((line = Textfile.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                }
                Textfile.Close();
                System.Console.ReadKey();
            }
            System.Console.WriteLine();
            System.Console.ReadLine();
            Program.Main(null);

        }

    }
    public class pro18
    {

        public static void pro8()
        {


            StackImplementation stack = new StackImplementation();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nStack MENU(size -- 10)");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. See the Top element.");
                Console.WriteLine("3. Remove top element.");
                Console.WriteLine("4. Display stack elements.");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter an Element : ");
                            stack.Push(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Top element is: {0}", stack.Peek());
                            break;
                        case 3:
                            Console.WriteLine("Element removed: {0}", stack.Pop());
                            break;
                        case 4:
                            stack.Display();
                            break;
                        case 5:

                            Program.Main(null);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.ReadKey();
            }



        }


        public interface IStackADT
        {
            bool isEmpty();
            void Push(object element);
            object Pop();
            object Peek();
            void Display();
        }

        public class StackImplementation : IStackADT
        {
            private const int StackSize = 10;
            private int top;
            private readonly object[] items;

            public StackImplementation()
            {
                items = new object[StackSize];
                top = -1;
            }

            public bool isEmpty()
            {
                return top == -1;
            }

            public void Push(object element)
            {
                if (top == (StackSize - 1))
                {
                    Console.WriteLine("Stack is full!");
                }
                else
                {
                    items[++top] = element;
                    Console.WriteLine("Item pushed successfully!");
                }
            }

            public object Pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty!");
                    return "No elements";
                }
                else
                {
                    return items[top--];
                }
            }

            public object Peek()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty!");
                    return "No elements";
                }
                else
                {
                    return items[top];
                }
            }

            public void Display()
            {
                for (int i = top; i > -1; i--)
                {
                    Console.WriteLine("Item {0}: {1}", (i + 1), items[i]);
                }
            }
        }
    }

    public class pro19
    {


        public struct Complex
        {
            public int real;
            public int imaginary;
            public Complex(int real, int imaginary)
            {
                this.real = real;
                this.imaginary = imaginary;
            }
            public static Complex operator +(Complex one, Complex two)
            {
                return new Complex(one.real + two.real, one.imaginary + two.imaginary);
            }
            public override string ToString()
            {
                return (String.Format("{0} + {1}i", real, imaginary));
            }
        }
        public static void pro9()
        {
            Complex val1 = new Complex(7, 1);
            Complex val2 = new Complex(2, 6);
            Complex res = val1 + val2;
            System.Console.WriteLine("First: {0}", val1);
            System.Console.WriteLine("Second: {0}", val2);
            System.Console.WriteLine("Result (Sum): {0}", res);
            System.Console.ReadLine();
            System.Console.ReadLine();
            Program.Main(null);
        }
    }

    public class pro110
    {

        public class Shape
        {
            public virtual void draw()
            {
                Console.WriteLine("Drawing Shape");
            }
            public virtual void erase()
            {
                Console.WriteLine("Erasing Shape");
            }
        }
        public class Circle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("Drawing Circle");
            }
            public override void erase()
            {
                Console.WriteLine("Erasing Circle");
            }
        }
        public class Triangle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("Drawing Triangle");
            }
            public override void erase()
            {
                Console.WriteLine("Erasing Triangle");
            }
        }
        public class Square : Shape
        {
            public override void draw()
            {
                Console.WriteLine("Drawing Square");
            }
            public override void erase()
            {
                Console.WriteLine("Erasing Square");
            }
        }
        public class Program10
        {
            public static void pro10()
            {
                Shape[] shapes = new Shape[3];
                shapes[0] = new Circle();
                shapes[1] = new Triangle();
                shapes[2] = new Square();
                foreach (Shape shape in shapes)
                {
                    shape.draw(); shape.erase();
                }
                System.Console.ReadLine();
                Program.Main(null);

            }
        }

    }
    public class pro111
    {




        public abstract class Shape
        {
            public abstract double GetPerimeter();
            public abstract double GetArea();
        }
        public class Circle : Shape
        {
            private double radius;
            private readonly double pi = Math.PI; public Circle()
            {
                this.radius = 1;
            }
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public override double GetArea()
            {
                return pi * Math.Pow(radius, 2);
            }
            public override double GetPerimeter()
            {
                return 2 * pi * radius;
            }
        }
        public class Triangle : Shape
        {
            private double width, height; public Triangle()
            {
                this.width = 1;
                this.height = 1;
            }
            public Triangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
            public override double GetArea()
            {
                return width * height;
            }
            public override double GetPerimeter()
            {
                return width + height + Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            }
        }
        public class ShapeClient
        {
            public static void pro11()
            {
                double width = 13, length = 9;
                Shape triangle = new Triangle(width, length);
                Console.WriteLine("The width of the triangle is: " + width
                + "\nThe height of the triangle is: " + length
                + "\nThe area of the triangle is: " + triangle.GetArea()
                + "\nThe perimeter of the triangle is: " + triangle.GetPerimeter() + "."); double radius = 3;
                Shape circle = new Circle(radius);
                Console.WriteLine("\nThe radius of the circle is: " + radius
                + "\nThe area of the circle is: " + circle.GetArea()
                + "\nThe perimeter of the circle is: " + circle.GetPerimeter() + ".");
                System.Console.ReadLine();
                Program.Main(null);
            }
        }

    }

    public class pro112
    {



        public interface IResizable
        {
            void ResizeWidth(int width);
            void ResizeHeight(int height);
        }
        public class Rectangle : IResizable
        {
            private int width;
            private int height; public Rectangle(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
            public void ResizeWidth(int width)
            {
                this.width = width;
            }
            public void ResizeHeight(int height)
            {
                this.height = height;
            }
            public void PrintSize()
            {
                Console.WriteLine("Width: " + width + ", Height: " + height);
            }
        }
        public class Program12
        {
            public static void pro12()
            {
                Rectangle rectangle = new Rectangle(100, 150);
                rectangle.PrintSize();
                rectangle.ResizeWidth(150);
                rectangle.ResizeHeight(200);
                rectangle.PrintSize();
                System.Console.ReadLine();
                System.Console.ReadLine();
                Program.Main(null);

            }
        }

    }
}