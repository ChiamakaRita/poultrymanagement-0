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

        public void CheckPrice(string breed)
        {
            Bird bird = Database.Where(x => x.Breed == breed).FirstOrDefault();

            if (bird == null)
            {
                Console.WriteLine($"We do not have {breed}");
                return;
            }

            string amount = bird.Price.ToString("c").Substring(1);

            string result = $"{breed.ToUpper()} is NGN {amount}";

            Console.WriteLine(result);
        }

        public void MakeBirdSick(int id)
        {
            Bird bird = Database.Where(x => x.Id == id).FirstOrDefault();
            
            if(bird == null)
            {
                Console.WriteLine($"Bird with id = {id} is not found");
                return;
            }
            bird.IsSick = true;
        }

        public void NumberOfSickBirds()
        {
            int num = Database.Count(b => b.IsSick == true);
            Console.WriteLine($"There are {num} sick birds");
        }

        public void NumberOfBirdsSold()
        {
            int numSold = Database.Count(b => b.IsSold == true);
            Console.WriteLine($"There are {numSold} bird sold");
        }

        public void SellBird(int id)
        {
            Bird bird = Database.Where(x => x.Id == id).FirstOrDefault();
            if(bird == null)
            {
                Console.WriteLine($"Bird with id = {id} is not found");
                return;
            }
            bird.IsSold = true;
            bird.DateSold = DateTime.Now.AddDays(-2);
            Console.WriteLine($"One {bird.Breed} has been sold!!!");
        }
    }
}