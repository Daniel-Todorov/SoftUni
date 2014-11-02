namespace _03.GenericList
{
    using System;

    public class Tests
    {
        static void Main()
        {
            Type type = typeof(GenericList<string>);
            object[] attributes = type.GetCustomAttributes(false);
            var version = attributes[1] as VersionAttribute;
            Console.WriteLine(version.Version);
        }
    }
}
