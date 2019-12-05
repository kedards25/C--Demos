using System;
using System.Collections;

namespace CollectionDemo
{
    class Students
    {
        int id;
        string name;
        double fees;

        public Students(int id, string name, double fees)
        {
            this.fees = fees;
            this.name = name;
            this.id = id;
        }
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public double getFees()
        {
            return fees;
        }
    }
    class Program
    {
        Students s1;
        Students s2;
        Students s3;

        ArrayList stdList;

        public void createDetails()
        {
            s1 = new Students(101, "One", 11.11);
            s2 = new Students(202, "Two", 22.22);
            s3 = new Students(303, "Three", 33.33);

            stdList = new ArrayList();

            stdList.Add(s1);
            stdList.Add(s2);
            stdList.Add(s3);
        }

        public void displayDetails()
        {
            Console.WriteLine("The Details are as follows: ");
            foreach (Students pr in stdList)
            {
                Console.WriteLine("Id:  {0}\nName: {1} \nFees: {2}\n", pr.getId(), pr.getName(), pr.getFees());

            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.createDetails();
            p.displayDetails();
            Console.ReadLine();
        }
    }
}
