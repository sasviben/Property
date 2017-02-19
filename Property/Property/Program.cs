using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Property example


namespace Property
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        // deklaracija get i set property - automatic

        public string Email
        {
            get;
            set;
        }

        public string Gsm
        {
            get;
            set;
        }

        // deklaracija get property PassMark
        public int PassMark
        {
            get
            {
               return this._passMark;
            }
           
        }
      
        // deklaracija get i set property-a Name
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._name = value;
            }
        }
   
        // deklaracija get i set property-a Id
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
               if (value <= 0)
                {
                    throw new Exception("Student id cannot be negativ or 0");
                }
                this._id = value;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.Id = 101;
            S1.Name = "sandro";
            S1.Email = "sandro@hotmail.com";
            S1.Gsm = "0912380457";

            Console.WriteLine("Student Id = {0}", S1.Id);
            Console.WriteLine("Student Name = {0}", S1.Name);
            Console.WriteLine("Student PassMark = {0}", S1.PassMark);
            Console.WriteLine("Student Email = {0}", S1.Email);
            Console.WriteLine("Student broj mobitela = {0}", S1.Gsm);


        }
    }
}
