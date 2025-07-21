namespace Assemente
{
    internal class Program
    {

            #region Q-1
            struct Person
        {
            public string Name;
            public int Age;
        }

     
            static void Main()
            {
             
                Person[] people = new Person[3];

                
                people[0].Name = "Ahmed";
                people[0].Age = 22;

                people[1].Name = "Salma";
                people[1].Age = 19;

                people[2].Name = "Youssef";
                people[2].Age = 25;

                
                Console.WriteLine("People Details:");
                for (int i = 0; i < people.Length; i++)
                {
                    Console.WriteLine("Name: " + people[i].Name + ", Age: " + people[i].Age);
                }
            }
            #endregion
        }
    
}
