namespace зад6
{
    abstract class Animal
    {
        public string Name { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        } 

        public abstract void Eat();
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }
    }

    class зад6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the dog:");
            string dogName = Console.ReadLine();

            Dog dog = new Dog();
            dog.SetName(dogName);

            Console.WriteLine("Dog's name: " + dog.GetName());
            dog.Eat();
        }
    }
}
