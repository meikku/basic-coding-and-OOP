using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ada = new Person("Ada");
            Person antti = new Person("Antti");
            Person martin = new Person("Martin");

            ada.PrintPerson();
            antti.PrintPerson();
            martin.PrintPerson();

            Console.WriteLine();

            ada.GrowOlder();
            antti.GrowOlder();
            antti.GrowOlder();

            ada.PrintPerson();
            antti.PrintPerson();
            martin.PrintPerson();
        }
    }
}
