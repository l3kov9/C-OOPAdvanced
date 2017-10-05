namespace StructDemo
{
    public class Startup
    {
        public static void Main()
        {
            var cat = new Cat("pesho");
            var dog = new Dog("gosho");

            ChangeCatName(cat);
            ChangeDogName(dog);

            System.Console.WriteLine(cat.Name);
            System.Console.WriteLine(dog.Name);
        }

        public static void ChangeCatName(Cat cat)
        {
            cat.Name = "Changed";
        }

        public static void ChangeDogName(Dog dog)
        {
            dog.Name = "Changed";
        }
    }
}
