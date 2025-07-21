namespace Assemente
{
    internal class Program
    {

        #region Q-1
        //    struct Person
        //{
        //    public string Name;
        //    public int Age;
        //}


        //    static void Main()
        //    {

        //        Person[] people = new Person[3];


        //        people[0].Name = "Ahmed";
        //        people[0].Age = 22;

        //        people[1].Name = "Salma";
        //        people[1].Age = 19;

        //        people[2].Name = "Youssef";
        //        people[2].Age = 25;


        //        Console.WriteLine("People Details:");
        //        for (int i = 0; i < people.Length; i++)
        //        {
        //            Console.WriteLine("Name: " + people[i].Name + ", Age: " + people[i].Age);
        //        }
        //    }
        #endregion
        #region Q-2
        //struct Point
        //{
        //    public double X;
        //    public double Y;
        //}


        //    static void Main()
        //    {
        //        Point p1, p2;

        //        Console.WriteLine("Enter X and Y for point 1:");
        //        p1.X = Convert.ToDouble(Console.ReadLine());
        //        p1.Y = Convert.ToDouble(Console.ReadLine());

        //        Console.WriteLine("Enter X and Y for point 2:");
        //        p2.X = Convert.ToDouble(Console.ReadLine());
        //        p2.Y = Convert.ToDouble(Console.ReadLine());

        //        double dx = p2.X - p1.X;
        //        double dy = p2.Y - p1.Y;
        //        double distance = Math.Sqrt(dx * dx + dy * dy);

        //        Console.WriteLine("Distance between the two points is: " + distance);
        //    }
        #endregion
        #region Q-3
        struct Person
        {
            public string Name;
            public int Age;
        }

       
            static void Main()
            {
                Person[] people = new Person[3];

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Enter name of person " + (i + 1) + ":");
                    people[i].Name = Console.ReadLine();

                    Console.WriteLine("Enter age of " + people[i].Name + ":");
                    people[i].Age = Convert.ToInt32(Console.ReadLine());
                }

                Person oldest = people[0];

                for (int i = 1; i < 3; i++)
                {
                    if (people[i].Age > oldest.Age)
                    {
                        oldest = people[i];
                    }
                }

                Console.WriteLine("The oldest person is: " + oldest.Name + " (" + oldest.Age + " years old)");
            }
            #endregion
        }
    
}
