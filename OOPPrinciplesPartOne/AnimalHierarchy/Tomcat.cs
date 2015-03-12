namespace AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age)
        {

        }

        public override string MakeSound()
        {
            return "Roar, roar!";
        }
    }
}
