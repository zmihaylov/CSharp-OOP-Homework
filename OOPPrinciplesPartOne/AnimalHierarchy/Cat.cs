namespace AnimalHierarchy
{
    class Cat : Animal, ISound
    {
        public Cat(string name, int age)
            : base(name, age)
        {

        }

        public Cat(string name, int age, Gender sex)
            : base(name, age, sex)
        {

        }

        public virtual string MakeSound()
        {
            return "Miau, miau!";
        }
    }
}
