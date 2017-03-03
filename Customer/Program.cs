using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        class Customer
        {
            private int _id;
            private string _surname;
            private string _name;
            private string _secondName;
            private string _adress;
            private int _creditCard;
            private int _bankNumber;


            public int ID
            {
                get { return _id; }
                set { _id = value; }
            }
            public string Surname
            {
                get { return _surname; }
                set { _surname = value; }
            }
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public string SecondName
            {
                get { return _secondName; }
                set { _secondName = value; }
            }
            public string Adress
            {
                get { return _adress; }
                set { _adress = value; }
            }
            public int CreditCard
            {
                get { return _creditCard; }
                set { _creditCard = value; }
            }
            public int BankNumber
            {
                get { return _bankNumber; }
                set { _bankNumber = value; }
            }
        }











        static void task1(Customer[] customers, int n)
        {
            Array.Sort(customers, (c1, c2) => c1.Name.CompareTo(c2.Name));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("ID: " + customers[i].ID);
                Console.WriteLine("Surname: " + customers[i].Surname);
                Console.WriteLine("Name: " + customers[i].Name);
                Console.WriteLine("Second Name: " + customers[i].SecondName);
                Console.WriteLine("Adress: " + customers[i].Adress);
                Console.WriteLine("Credit card: " + customers[i].CreditCard);
                Console.WriteLine("Bank Number: " + customers[i].BankNumber);
                Console.WriteLine("");
            }
            
        }










        static void task2(Customer[] customers, int n, int x, int y)
        {
            for (int i = 0; i < n; i++)
            {
                if ((customers[i].CreditCard >= x) && (customers[i].CreditCard <= y))
                {
                    Console.WriteLine("ID: " + customers[i].ID);
                    Console.WriteLine("Surname: " + customers[i].Surname);
                    Console.WriteLine("Name: " + customers[i].Name);
                    Console.WriteLine("Second Name: " + customers[i].SecondName);
                    Console.WriteLine("Adress: " + customers[i].Adress);
                    Console.WriteLine("Credit card: " + customers[i].CreditCard);
                    Console.WriteLine("Bank Number: " + customers[i].BankNumber);
                    Console.WriteLine("");
                }
            }
            
        }









        static void Main(string[] args)
        {
            do
            {

                int n = 6;
                Customer[] customerLibrary = new Customer[n];
                for (int i = 0; i < n; i++)
                {
                    customerLibrary[i] = new Customer();
                }
                Random rnd = new Random();

            customerLibrary[0].ID = 1000;
            customerLibrary[0].Surname = "Doroshenko";
            customerLibrary[0].Name = "Dima";
            customerLibrary[0].SecondName = "Dmytry";
            customerLibrary[0].Adress = "Kyiv";
            customerLibrary[0].CreditCard = 20000;
            customerLibrary[0].BankNumber = 9;


            customerLibrary[1].ID = 2000;
            customerLibrary[1].Surname = "Igor";
            customerLibrary[1].Name = "Morenetz";
            customerLibrary[1].SecondName = "Loh";
            customerLibrary[1].Adress = "Selo";
            customerLibrary[1].CreditCard = 30000;
            customerLibrary[1].BankNumber = 18;


            customerLibrary[2].ID = 3000;
            customerLibrary[2].Surname = "Klischenko";
            customerLibrary[2].Name = "Lada";
            customerLibrary[2].SecondName = "Batkovna";
            customerLibrary[2].Adress = "Donbass";
            customerLibrary[2].CreditCard = 40000;
            customerLibrary[2].BankNumber = 27;

            customerLibrary[3].ID = 4000;
            customerLibrary[3].Surname = "Rostik";
            customerLibrary[3].Name = "Hantil";
            customerLibrary[3].SecondName = "Yep";
            customerLibrary[3].Adress = "Priluki";
            customerLibrary[3].CreditCard = 50000;
            customerLibrary[3].BankNumber = 36;

            customerLibrary[4].ID = 5000;
            customerLibrary[4].Surname = "Yarik";
            customerLibrary[4].Name = "Kladko";
            customerLibrary[4].SecondName = "Ec4e";
            customerLibrary[4].Adress = "Lviv";
            customerLibrary[4].CreditCard = 60000;
            customerLibrary[4].BankNumber = 45;

            customerLibrary[5].ID = 6000;
            customerLibrary[5].Surname = "Nastya";
            customerLibrary[5].Name = "Sheludko";
            customerLibrary[5].SecondName = "Oleksandrovna";
            customerLibrary[5].Adress = "Kyiv";
            customerLibrary[5].CreditCard = 70000;
            customerLibrary[5].BankNumber = 56;





                // Виведення задачі 1 
                Console.WriteLine("Alphabet task 1: ");
                task1(customerLibrary, n);

                // Виведення задачі 2
                Console.WriteLine("Task 2: ");
                Console.WriteLine("From 10 000 to 100 000 ");
                Console.WriteLine("Range of card number from: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("to: ");
                int y = int.Parse(Console.ReadLine());

                task2(customerLibrary, n, x, y);



            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);


        }


    }
}
