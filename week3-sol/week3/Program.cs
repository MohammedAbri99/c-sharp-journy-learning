namespace week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tuesday
            //Products prod1 = new Products("Pen","black color pen",1.5,10,true);
            //Products prod2 = new Products("Labtop", "lenovo labtop", 300, 20, true);
            //Products prod3 = new Products("book", "Excercise Book", 5, 10,false);
            //Products[] products = { prod1, prod2, prod3 };
            //foreach (Products product in products)
            //{
            //    product.displayInformation();
            //}

            #endregion


            #region wednesday
            //Human human1 = new Human("Mohammed Said", 24, "Nizwa,Oman", "MOhammed@gmail.com");
            //human1.displayInformaton();

            //Console.WriteLine("Enter Name");
            //string name = Console.ReadLine();
            //int age;
            //do
            //{
            //    Console.WriteLine("Enter Your Age: ");
            //    int.TryParse(Console.ReadLine(), out age);
            //} while (age<=18 || age>100);

            //Human human2 = new Human(name, age, "Nizwa,Oman", "Mohammed@gmail.com");

            //human2.displayInformaton();
            //human2.Name = "Alabri@gmail.com";
            //human2.displayInformaton();

            //Human human3;
            //Console.WriteLine();
            //Console.WriteLine(JudgeSquareSum(2147483641)); 
            #endregion

            #region Thurseday
            //PhoneBook contact1 = new PhoneBook(5);
            //contact1.SetAll("Mohammed", 95928585);
            //contact1.SetAll("Salim", 99999999);
            //contact1.SetAll ("AbdulKhaleq", 95959595);

            //contact1.displayContents();
            //Console.WriteLine(contact1["Mohammed"]);
            ////    Console.WriteLine(contact1.GetNumberByName(""));
            //contact1["yousef", true] = 91199119;
            //Console.WriteLine(contact1["yousef"]);


            //contact1.displayContents();
            ////    Console.WriteLine(contact1); 


            Student Mohammed = new Student("Mohammed", false, 24, false, "BC.s", true, 99, 10);
            Mohammed.describe();
            #endregion
        }
    }
} 