using poultrymanagement_0.Models;

namespace poultrymanagement_0.Services
{
    public class PoultryService : IPoultryService
    {
        public List<Bird> Database {get; set;} = new List<Bird>();
        public int AddMany(List<Bird> birds)
        {
            throw new NotImplementedException();
        }

        public int AddOne(Bird bird)
        {
            Database.Add(bird);
            Console.WriteLine($"{bird.Breed} with id : {bird.Id} has been added.");
            return bird.Id;
        }

        public List<Bird> GetBirds()
        {
            return Database;
        }

        public void HowManyForSale()
        {
            // int numberForSale = Database.Where(b => b.ReadForSale == true).Count();
            int numberForSale = Database.Count(b => b.ReadForSale == true);

            string result = numberForSale == 1 ? $"There is {numberForSale} bird ready for sale!!!" : $"There are {numberForSale} birds ready for sale!!!";

            Console.WriteLine(result);
        }
    }
}