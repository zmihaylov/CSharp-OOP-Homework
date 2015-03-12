namespace AnimalHierarchy
{
    class Dog : Animal, ISound
    {
        public Dog(string name, int age)
            : base(name, age)
        {

        }

        public Dog(string name, int age, Gender sex)
            : base(name, age, sex)
        {

        }

        public string MakeSound()
        {
            return "Bau, bau!";
        }
    }
}
