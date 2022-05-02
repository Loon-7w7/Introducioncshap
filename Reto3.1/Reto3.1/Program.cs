using System;

namespace Reto3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ClassTopic = "Métodos de strings";
            string School = "Platzi";
            Console.WriteLine("Estoy aprendiendo de " + ClassTopic + " en " + School + ".");

            //  Clone()
            Console.WriteLine("\n Clone()");
            string SchoolClone = School.Clone().ToString();
            Console.WriteLine(SchoolClone);

            //CompareTo()
            Console.WriteLine("\n CompareTo()");
            Console.WriteLine(ClassTopic.CompareTo(School));
            Console.WriteLine(School.CompareTo(SchoolClone));

            //Contains()
            Console.WriteLine("\n Contains()");
            Console.WriteLine(School.Contains("Pla"));

            //EndsWith()
            Console.WriteLine("\n EndsWith()");
            Console.WriteLine(School.EndsWith("zi"));

            //StartsWith()
            Console.WriteLine("\n StartsWith()");
            Console.WriteLine(School.StartsWith("Pl"));

            //Equals()
            Console.WriteLine("\n //Equals()");
            Console.WriteLine(School.Equals(SchoolClone));

            //IndexOf()
            Console.WriteLine("\n IndexOf()");
            Console.WriteLine(School.IndexOf("a"));

            //ToLower() y ToUpper()
            Console.WriteLine("\n ToLower() y ToUpper()");
            Console.WriteLine(ClassTopic.ToLower());
            Console.WriteLine(ClassTopic.ToUpper());

            //Insert()
            Console.WriteLine("\n Insert()");
            Console.WriteLine(School.Insert(6, " es educación online efectiva"));

            //LastIndexOf()
            Console.WriteLine("\n LastIndexOf()");
            Console.WriteLine(ClassTopic.LastIndexOf("s"));

            //Remove()
            Console.WriteLine("\n Remove()");
            Console.WriteLine(ClassTopic.Remove(6));

            //Replace()
            Console.WriteLine("\n Replace()");
            Console.WriteLine(ClassTopic.Replace("s", "z"));

            //Split()
            Console.WriteLine("\n Split()");
            string[] split = ClassTopic.Split(new char[] { 's' });

            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            //Substring()
            Console.WriteLine("\n Substring()");
            Console.WriteLine(ClassTopic.Substring(2, 10));

            //ToCharArray()
            Console.WriteLine("\n ToCharArray()");
            School.ToCharArray();

            //Trim()
            Console.WriteLine("\n Trim()");
            string TextWithSpaces = "  hola, había espacios al principio y al final ";
            Console.WriteLine(TextWithSpaces.Trim());



        }
    }
}
