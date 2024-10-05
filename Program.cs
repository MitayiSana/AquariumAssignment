using System;
namespace AquariumAsssignment;

public class Fish
{
    public string Species { get; set; }
    public double PricePerFish { get; set; }
}
//Acquring the properties of Fish
public class FishUtility : Fish
{
    public void AddFish(string species, double pricePerFish)
    {
        Species = species;
        PricePerFish = pricePerFish;
    }

    public bool BuyFish()
    {
        return Species == "Clownfish" || Species == "Goldfish";
    }

    public double CalculatePrice(int numberOfFishes)
    {
        double additionalCharges = Species == "Clownfish" ? 100 : 150;
        return numberOfFishes * PricePerFish + additionalCharges;
    }
}

public class Program
{
    public static void Main()
    {
        FishUtility fishUtility = new FishUtility();

        Console.Write("Enter the species to buy: ");
        string species = Console.ReadLine();

        Console.Write("Enter the price per fish: ");
        double pricePerFish = Convert.ToDouble(Console.ReadLine());

        fishUtility.AddFish(species, pricePerFish);

        //If the species not amongst two then it is invalid.....

        if (!fishUtility.BuyFish())
        {
            Console.WriteLine($"{species} species not found");
            return;
        }

        Console.Write("Enter the number of fishes you need to buy: ");
        int numberOfFishes = Convert.ToInt32(Console.ReadLine());

        double totalCost = fishUtility.CalculatePrice(numberOfFishes);

        Console.WriteLine($"Total cost is {totalCost}");
    }
}
