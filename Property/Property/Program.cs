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

        // deklaracija metode za dohvaćanje _passMark
        public int GetPassMark()
        {
            return this._passMark;
        }
        // deklaracija metode za inicijalizaciju _name
        public void SetName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._name = name;
        }
        // deklaracija metode za dohvaćanje _name
        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
        }
        // deklaracija metode za inicijalizaciju _id
        public void SetId(int id)
        {
            if(id <= 0)
            {
                throw new Exception("Student id cannot be negativ or 0");
            }
            this._id = id;
        }
        // deklaracija metode za dohvaćanje _id
        public int GetId()
        {
            return this._id;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.SetId(101);
            S1.SetName("sandro");

            Console.WriteLine("Student Id = {0}", S1.GetId());
            Console.WriteLine("Student Name = {0}", S1.GetName());
            Console.WriteLine("Student PassMark = {0}", S1.GetPassMark());

        }
    }
}
