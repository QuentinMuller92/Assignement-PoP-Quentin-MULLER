using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_PoP_MULLER
{
    public class Student : Person
    {
        private string studentNumber;
        private int age;
        private Address address;
        private string fullName;
        private double[] scores;
        private double averageScore;
        private string fullAddress;

        //Constructors
        public Student(string firstName, string lastName) : base (firstName, lastName) { }

        public Student(string firstName, string lastName, string studentNumber, int age, Address address, double[] scores) : base (firstName, lastName)
        {
            this.studentNumber = studentNumber;
            this.age = age;
            this.address = address;
            this.fullName = firstName + " " + lastName;
            this.scores = scores;

            double sum = 0;
            for(int i = 0; i<scores.Length; i++)
            {
                sum = sum + scores[i];
            }
            this.averageScore = sum/scores.Length;

            this.fullAddress = address.ToString();
        }

        //Properties
        public string StudentNumber
        {
            get { return this.studentNumber; }
        }

        public double AverageScore
        {
            get { return this.averageScore; }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                age = value;
            }
        }

        public string FullAddress
        {
            get { return this.fullAddress ; }
        }

        public Address Address
        {
            get { return this.address; }
        }

        //Method
        public override string ToString()
        {
            string answer = fullName + " lives at the following address : " + fullAddress + ".\nThis student is " + age + ".\nStudent Number = " + studentNumber + "\nScores : ";
            for(int i = 0; i<scores.Length; i++)
            {
                if (i < scores.Length - 1)
                {
                    answer = answer + scores[i] + " - ";
                }
                else
                {
                    answer = answer + scores[i];
                }
            }
            answer = answer + "\nThe average score of " + fullName + " is " + averageScore + ".";
            return answer;
        }
    }
}
