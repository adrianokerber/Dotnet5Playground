using System;
using TestProject.Models;

namespace TestProject
{
    class Program
    {
        protected Program() { }
        static void Main(string[] args)
        {
            Console.WriteLine("Testing values!");

            /////////////////////////////////////////////////
            /// Testing struct type

            Console.WriteLine("Compare Structs - They are value types");

            var personStruct = new PersonStruct { FirstName = "Adriano", LastName = "Kerber" };
            personStruct.MiddleName = "Luís";

            var personStruct2 = new PersonStruct { FirstName = "Adriano", LastName = "Kerber", MiddleName = "Luís" };

            var areEquals = personStruct.Equals(personStruct2)
                .AsText();

            Console.WriteLine($"{personStruct}\nand\n{personStruct2}\nare equal? {areEquals}");

            /////////////////////////////////////////////////
            /// Testing class type

            Console.WriteLine("Compare Classes - They are reference types");

            var personClass = new PersonClass("Adriano", "Kerber");
            personClass.MiddleName = "Luís";

            var personClass2 = new PersonClass("Adriano", "Kerber") { MiddleName = "Luís" };

            areEquals = personClass.Equals(personClass2)
                .AsText();

            Console.WriteLine($"{personClass}\nand\n{personClass2}\nare equal? {areEquals}");

            ////////////////////////////////
            /// Testing record type

            Console.WriteLine("Compare Records - They are reference types");

            var personRecord = new PersonRecord("Adriano", "Kerber");
            personRecord.MiddleName = "Luís";

            var personRecord2 = new PersonRecord("Adriano", "Kerber") { MiddleName = "Luís" };

            areEquals = personRecord.Equals(personRecord2)
                .AsText();

            Console.WriteLine($"{personRecord}\nand\n{personRecord2}\nare equal? {areEquals}");

            ////////////////////////////////

            Console.WriteLine("\n////////////////////////////////\n");

            var p1 = new MutablePoint(1, 2);
            var p2 = p1;
            p2.Y = 200;
            Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
            Console.WriteLine($"{nameof(p2)}: {p2}");

            MutateAndDisplay(p2);
            Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");

            ////////////////////
            /// Another test of record

            PersonRecord recordValueObject = new("Adriano", LastName: "Kerber") { Gender = "Male", Height = 1.78f };
            PersonRecord recordValueObjectCopy = recordValueObject with { Gender = "Female" };

            Console.WriteLine($"{recordValueObject} {recordValueObjectCopy}");

            // Commented line below will files to compile since FirstName is a init-only property
            //recordValueObject.FirstName = "Fake";
        }

        private static void MutateAndDisplay(MutablePoint p)
        {
            p.X = 100;
            Console.WriteLine($"Point mutated in a method: {p}");
        }
    }
}
