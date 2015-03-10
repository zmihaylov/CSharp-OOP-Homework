namespace AttributeVersion
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Method |
        AttributeTargets.Class | AttributeTargets.Interface,
        AllowMultiple = false)]

    public class VersionAttribute : Attribute
    {
        public string Version { get; private set; }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }

    [Version("2.11")]
    class TestAttributeVersion
    {
        static void Main()
        {
            Type type = typeof(TestAttributeVersion);
            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in allAttributes)
            {
                Console.WriteLine(attribute.Version);
            }
        }
    }
}
