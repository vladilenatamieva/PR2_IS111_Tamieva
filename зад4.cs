namespace зад4
{ 
    
        public class Person
        {
            private string Name;

            public Person(string name)
            {
                Name = name;
            }

            ~Person()
            {
                Name = string.Empty;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public class зад4
        {
            public static void Main(string[] args)
            {
                Person[] people = new Person[3];

                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Введите имя человека {i + 1}: ");
                    string name = Console.ReadLine();
                    people[i] = new Person(name);
                }

                Console.WriteLine("Имена людей:");

                foreach (Person person in people)
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }


