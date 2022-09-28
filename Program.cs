using poultrymanagement_0.Models;
using poultrymanagement_0.Services;

PoultryService poultryService = new();

Bird firstBird = new Bird() {
    Id = 1,
    Breed = "Layers",
    Weight = 3.5,
    DateAdded = DateTime.Now,
    IsSold = false,
    IsSick = false,
    ReadForSale = false,
    DateSold = DateTime.MinValue,
    Price = 2000
};

Bird secondBird = new Bird() {
    Id = 2,
    Breed = "Broilers",
    Weight = 4.5,
    DateAdded = DateTime.Now,
    IsSold = false,
    IsSick = false,
    ReadForSale = true,
    DateSold = DateTime.MinValue,
    Price = 4000
};

poultryService.AddOne(firstBird);
poultryService.AddOne(secondBird);

Console.WriteLine("==========================");

poultryService.HowManyForSale();
poultryService.CheckPrice("Broilers");
poultryService.CheckPrice("broiler");
poultryService.CheckPrice("Layers");
poultryService.MakeBirdSick(1);
poultryService.MakeBirdSick(2);
poultryService.NumberOfSickBirds();
poultryService.NumberOfBirdsSold();
poultryService.SellBird(2);
poultryService.NumberOfBirdsSold();
