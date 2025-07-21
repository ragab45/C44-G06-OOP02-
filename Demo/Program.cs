namespace Demo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region V-1
            //     public struct Point
            //{
            //    public Point(int x, int y)
            //    {
            //        X = x;
            //        Y = y;
            //    }

            //    //public Point()
            //    //{
            //    //    X = 0;
            //    //    Y = 0;
            //    //}

            //    public int X { get; set; }
            //    public int Y { get; set; }
            //}



            #endregion

            #region V-2
            // Uncomment the line below if you want to see the initial value of point.X
            // Console.WriteLine(point.X);

            //            // Create the first Point object
            //            Point point01 = new Point(10, 20);
            //        Console.WriteLine($"Point 01 => X = {point01.X}, Y = {point01.Y}");

            //            // Create the second Point object
            //            Point point02 = new Point(30, 40);
            //        Console.WriteLine($"Point 02 => X = {point02.X}, Y = {point02.Y}");

            //            // Assign point01 to point02.
            //            // For structs, this performs a member-wise copy (value type behavior).
            //            point02 = point01;
            //            Console.WriteLine("======== After ========");

            //            // Display the values after assignment
            //            Console.WriteLine($"Point 01 => X = {point01.X}, Y = {point01.Y}");
            //            Console.WriteLine($"Point 02 => X = {point02.X}, Y = {point02.Y}");

            //            // Modify point01's properties
            //            // Since Point is a struct (value type), modifying point01 will not affect point02
            //            // because point02 holds its own copy of the values.
            //            point01.X = 100;
            //            point01.Y = 200;

            //            Console.WriteLine("======== After ========");

            //            // Display the values after modifying point01
            //            Console.WriteLine($"Point 01 => X = {point01.X}, Y = {point01.Y}");
            //            Console.WriteLine($"Point 02 => X = {point02.X}, Y = {point02.Y}");
            //        }
            //}

            //// Assuming the Point struct is defined in the same namespace or accessible
            //// from a referenced assembly, like the one provided in the previous turn.
            //// For completeness, here's a basic Point struct definition:
            //public struct Point
            //{
            //    public int X { get; set; }
            //    public int Y { get; set; }

            //    public Point(int x, int y)
            //    {
            //        X = x;
            //        Y = y;
            //    }
            //}
            #endregion
            #region V-3
             public class Animal
        {
            // Property for the animal's name
            public string Name { get; set; }

            // Method for the animal to eat
            public void Eat()
            {
                Console.WriteLine("Eating ....");
            }
        }

        // Define the Dog class
        public class Dog
        {
            // Property for the dog's name
            public string Name { get; set; }

            // Method for the dog to eat
            public void Eat()
            {
                Console.WriteLine("Eating ....");
            }
        }
        #endregion

    }
    }


