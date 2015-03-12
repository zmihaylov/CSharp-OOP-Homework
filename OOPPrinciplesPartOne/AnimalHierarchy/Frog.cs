namespace AnimalHierarchy
{
    class Frog : Animal, ISound
    {
        public Frog(string name, int age)
            : base(name, age)
        {

        }

        public Frog(string name, int age, Gender sex)
            : base(name, age, sex)
        {

        }

        public string MakeSound()
        {
            return "Kwak, kwak!";
        }
    }
}
