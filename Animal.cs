namespace Ex8
{
    public abstract class Animal
    {
        public static int Number { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Weight { get; set; }
        public string Age { get; set; }
        

        public Animal()
        {
            Number++;
        }

        public abstract void PrintInfo();


    }
}
