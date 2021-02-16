using System; // Important, IDK why it was deleted when I restarted

namespace CsharpTutorial
{
    class Program // A container for the code
    {// Main is the method that executes when we run the program
        static void Main(string[] args) // A method, is the container that will have the code we want to execute
        {
            // Console.WriteLine("Hello World!"); // '' is for single character, "" for strings

            //Console.ReadLine(); // Keeps the windows open until a line of code is written
            ////////     CTRL + K + C == Comment; CTRL + K + U == Uncomment            ///////

            ///////// Declaring variables

            //string myName = "Nicolas";
            //int myAge = 21;
            //Console.WriteLine("Hello my name is " + myName + " and I'm " + myAge + " years old.");
            //// Composite Formatting
            //Console.WriteLine("Hello my name is {0} and I'm {1} years old.", myName, myAge);
            //// Str interpolation
            //Console.WriteLine($"Hello my name is {myName} and I'm {myAge} years old.");
            //Console.ReadLine();

            /////// Datas types
            string phrase = "Ciao Mondo";
            char singleCharacter = 'A';
            int integerValue = -50;
            // floats are less precise, but occupy less space and are have more compatibility
            float floatingValue = 3.75f; // the f or F is important to avoid errors
            // doubles are more precise (15-16 digits)
            double doubleValue = 7.51;
            // decimals are really precise and appropriate for thigns like financial calculations
            // They minimize errors of rounding but are significantly slower than floats and doubles
            decimal decimalValue = 0.3333333333m; // the m or M is important
            // Boolean
            bool isBoolean = true;
            ///////

            //Console.WriteLine(phrase.Length);
            //Console.WriteLine(phrase.Contains("Ciao"));
            //Console.WriteLine(phrase.Substring(5, 5)); // returns str from the desired index, can also put how many char after that
            //////
            //Console.WriteLine(Math.Abs(-20)); // returns absolute value of number
            //Console.WriteLine(Math.Pow(3, 2)); // power of
            //Console.WriteLine(Math.Sqrt(16)); // Square root
            //Console.WriteLine(Math.Max(23, 47)); // returns the biggest number
            //Console.WriteLine(Math.Min(23, 47)); // returns the smallest number

            ///////////

            // Getting user input
            // Write stays in the same line, WriteLine goes to a new one after executing
            //Console.Write("Enter your name:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}! Have a good day!");

            ///////////
            //Convert a str to int
            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine()); // Functions with , not with . idk why

            //Console.WriteLine( num1);
            //Console.WriteLine(num2 );
            //Console.WriteLine( num1 + num2 );
            ///////
            // Arrays

            // What kind of data will be inside needs to be specified
            //int[] luckyNumbers = {1, 2, 3, 5, 8, 13, 21};
            //// Creating an empty array
            //string[] employees = new string[3]; // Need to specify the length
            //employees[0] = "Richard";
            ///////
            // SayHi("Pepito", 112);
            // Console.WriteLine(CubeNumber(3));
            ////////
            // if statements
            //bool isHungry = true;

            //if (isHungry)
            //{
            //    Console.WriteLine("You're hungry!");
            //} else
            //{
            //    Console.WriteLine("You're not hungry!");
            //}
            //
            //Console.WriteLine(GetMax(72, 23, 15));
            ////////
            // Switch Statements
            //Console.WriteLine(GetDay(3));
            //// While Loops
            int index = 1;
            //while(index <= 10)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}
            // do while loops executes the code once before checking the condition
            //do
            //{
            //    Console.WriteLine(index);
            //    index++;
            //} while (index <= 10);
            //////////////
            // For Loops

            //for(int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(Getpow(2, 8));

            /////////
            // 2D arrays, put comma inside the brackets. every comma "adds a dimension"
            int[,] numberGrid =
            {
                {1, 1, 2 },
                {3, 5, 8 },
                {13, 21, 34 }
            };
            // Unknow length
            int[,] unknowArray = new int[2, 4]; // how many columns and rows it will have

            //Console.WriteLine(numberGrid[1, 2]); // expected output : 8
            /////////////
            // Exception Handling
            // Code that can give an error goes inside try and if it does, executes catch 
            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter another number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //} // You can get more info about the error with the parenthesis
            //catch(DivideByZeroException err) // Exception is a data type
            //{
            //    Console.WriteLine(err.Message);
            //}
            //catch(FormatException err)
            //{
            //    Console.WriteLine(err.Message);
            //}
            //finally // This will always get executed, not matter what
            //{
            //    Console.WriteLine("I will always be executed lol");
            //}
            /////////
            // Classes & Objects
            // Create an object (Instance of a class); using MY data type

            Book book1 = new Book();
            book1.title = "Murder on the Orient Express";
            book1.author = "Agatha Christie";
            book1.pages = 256;

            Book book2 = new Book("Under the Dome","Stephen King",1074) ;

            Console.WriteLine(book2.title);
            Console.Clear();
            ///////////////
            // Object Methods
            Student student1 = new Student("Marissa", "Business", 2.8);
            Student student2 = new Student("Anastasia", "Criminology", 3.6);

            //Console.WriteLine(student1.HasHonors());
            //Console.WriteLine(student2.HasHonors());
            /////////
            // Getters and Setters
            // They allow for external code to access and modify data
            Movie avengers = new Movie("The Avengers","Joss Whedon","PG-13");
            Movie shrek = new Movie("Shrek","Adam Adamson","PG");

            //Console.WriteLine(avengers.Rating);
            //////////////
            // Static Attributes
            // its an attribute shared with all the instances of the class
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            // Given that is static, I can access the attribute with the class itself

            //Console.WriteLine(Song.songCount);
            ////////////////////////////
            // Static Methods and Classes
            // a static method belong to the class itself
            // For example:
            Console.WriteLine(Math.Sqrt(25)); // .Sqrt is a static method
            UsefulTools.SayHi("Pepito");
            // You can't create instances of static classes
            ///////////////////////////
            // Inheritance
            // Make a class inherit the functionality of another class
            Chef chef = new Chef();

            chef.MakeChicken();
            //This chef will inherit the chef class
            ItalianChef itaChef = new ItalianChef();
            // He can make chicken like a regular chef!
            itaChef.MakeChicken();
            // But he can also make pasta! Something that the regular chef can't
            itaChef.MakePasta();
            itaChef.MakeSpecial();




            Console.ReadLine();
        }
        /////////
        // Methods. Declare them outside Main
        // The secodn word is the return type // void = no return
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello {0}! You are {1} years old", name, age);
        }
        // This method returns an int
        static int CubeNumber(int num)
        {
            int result = num * num * num;
            return result;
        }
        //
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if(num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if(num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } else
            {
                result = num3;
            }


            return result;
        }
        //////////
        static string GetDay(int dayNum)
        {
            string dayName;
            // switch statement
            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                        break;
                case 2:
                    dayName = "Tuesday";
                        break;
                case 3:
                    dayName = "Wednesday";
                        break;
                case 4:
                    dayName = "Thursday";
                        break;
                case 5:
                    dayName = "Friday";
                        break;
                case 6:
                    dayName = "Saturday";
                        break;
                default:
                    dayName = "Invalid day number";
                    break;
            }


            return dayName;
        }
        //
        static int Getpow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i < powNum; i++)
            {
                result *= baseNum; // compund assigment, same as result = result * baseNum
            }

            return result;
        }

    }
}
