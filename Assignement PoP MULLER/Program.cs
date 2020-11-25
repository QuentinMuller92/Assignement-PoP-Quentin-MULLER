using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignement_PoP_MULLER
{
    public class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address(9, " bulgarian street", "Varna", "Bulgaria");
            double[] scores = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Student student = new Student("Jean", "Dupont", "H54EV", 20, address, scores);
            List<Student> students = new List<Student>();
            students.Add(student);

            while (true)
            {
                Console.Clear();

                Console.WriteLine("List of Students :");
                for(int i =0; i<students.Count; i++)
                {
                    Console.WriteLine(students[i].FirstName);
                }

                Console.WriteLine(new string('=', 50));
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Student information");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Exit");
                Console.WriteLine(new string('=', 50));
                

                int choice = 0;
                while (choice < 1 || choice > 4)
                {
                    Console.Write("Please enter your choice: ");
                    int.TryParse(Console.ReadLine(), out choice);
                }

                if (choice == 4)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Adding a student ...\n");

                        Console.Write("First Name > ");
                        string firstName = Console.ReadLine();

                        Console.Write("Last Name > ");
                        string lastName = Console.ReadLine();

                        string studentNumber = "";
                        while (studentNumber.Length != 5 || studentNumber == null)
                        {
                            Console.Write("Student Number > ");
                            studentNumber = Console.ReadLine().ToUpper();
                        }

                        int age = 0;
                        while (age < 1 || age > 120)
                        {
                            Console.Write("Age > ");
                            int.TryParse(Console.ReadLine(), out age);
                        }

                        int streetNumber = 0;
                        while (streetNumber < 1)
                        {
                            Console.Write("Street Number > ");
                            int.TryParse(Console.ReadLine(), out streetNumber);
                        }                        

                        Console.Write("Street > ");
                        string street = Console.ReadLine();

                        Console.Write("City > ");
                        string city = Console.ReadLine();

                        Console.Write("Country > ");
                        string country = Console.ReadLine();

                        int counter = -1;
                        double[] scoresXBis = null;
                        while (counter != 0)
                        {
                            Console.Write("Scores (.-.-.-.-. etc.) > ");
                            string[] scoresX = Console.ReadLine().Split('-');
                            scoresXBis = new double[scoresX.Length];

                            bool test = false;
                            counter = scoresX.Length;
                            for (int i = 0; i < scoresX.Length; i++)
                            {
                                test = double.TryParse(scoresX[i], out scoresXBis[i]);
                                if(test == true && scoresXBis[i] >=0 && scoresXBis[i] <=100)
                                {
                                    counter--;
                                }
                            }
                        }

                        Address addressX = new Address(streetNumber, street, city, country);
                        Student studentX = new Student(firstName, lastName, studentNumber, age, addressX, scoresXBis);
                        students.Add(studentX);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("List of Students :");
                        for (int i = 0; i < students.Count; i++)
                        {
                            Console.WriteLine(students[i].FirstName);
                        }
                        Console.WriteLine();

                        counter = 0;
                        Student attemp = new Student("Test", "TEST");
                        while (counter != 1)
                        {
                            Console.Write("Write the first name of the student > ");
                            string name = Console.ReadLine();
                            for (int i = 0; i < students.Count; i++)
                            {
                                if (students[i].FirstName == name)
                                {
                                    attemp = students[i];
                                    counter++;
                                }
                            }
                        }

                        Console.WriteLine(new string('=', 50));
                        Console.WriteLine("Information available : ");
                        Console.WriteLine("1. Average Score");
                        Console.WriteLine("2. Full Address");
                        Console.WriteLine("3. Student Number");
                        Console.WriteLine("4. Age");
                        Console.WriteLine("5. Street Number");
                        Console.WriteLine("6. Street");
                        Console.WriteLine("7. City");
                        Console.WriteLine("8. Country");
                        Console.WriteLine("9. All data about the student");
                        Console.WriteLine(new string('=', 50));


                        choice = 0;
                        while (choice < 1 || choice > 9)
                        {
                            Console.Write("Please enter your choice: ");
                            int.TryParse(Console.ReadLine(), out choice);
                        }

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine($"Student {attemp.FirstName} {attemp.LastName} average score is {attemp.AverageScore}.");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine($"Student {attemp.FirstName} {attemp.LastName} full address is {attemp.FullAddress}.");
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.WriteLine($"Student {attemp.FirstName} {attemp.LastName} student number is {attemp.StudentNumber}.");
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.WriteLine($"Student {attemp.FirstName} {attemp.LastName} age is {attemp.Age}.");
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.WriteLine($"Student {attemp.FirstName} {attemp.LastName} street number is {attemp.Address.Number}.");
                                Console.ReadKey();
                                break;
                            case 6:
                                Console.WriteLine($"Student {attemp.FirstName} {attemp.LastName} street is {attemp.Address.Street}.");
                                Console.ReadKey();
                                break;
                            case 7:
                                Console.WriteLine($"Student {attemp.FirstName} {attemp.LastName} city is {attemp.Address.City}.");
                                Console.ReadKey();
                                break;
                            case 8:
                                Console.WriteLine($"Student {attemp.FirstName} {attemp.LastName} country is {attemp.Address.Country}.");
                                Console.ReadKey();
                                break;
                            case 9:
                                Console.WriteLine($"All data :\n{attemp.ToString()}");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("List of Students :");
                        for (int i = 0; i < students.Count; i++)
                        {
                            Console.WriteLine(students[i].FirstName);
                        }
                        Console.WriteLine();

                        counter = 0;
                        int index = -1;
                        while (counter != 1)
                        {
                            Console.Write("Write the first name of the student > ");
                            string name = Console.ReadLine();
                            for (int i = 0; i < students.Count; i++)
                            {
                                if (students[i].FirstName == name)
                                {
                                    index = i;
                                    counter++;
                                }
                            }
                        }
                        students.RemoveAt(index);
                        break;
                }
            }

            Console.ReadKey();
        }       
    }
}
