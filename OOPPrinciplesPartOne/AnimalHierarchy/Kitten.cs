namespace AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age)
        {
            this.Sex = Gender.female;
        }

        public override string MakeSound()
        {
            return "Mrrr, mrrrr!";
        }
    }
}
