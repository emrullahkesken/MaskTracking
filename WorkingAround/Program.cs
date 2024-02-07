using Business.Concrete;
using Entities.Concrete;

namespace WorkingAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Emrulah";
            person.LastName = "Kesken";
            person.NationalIdentity = 12345678911;
            person.DateOfBirthYear = 1998;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);

        }
    }
}
