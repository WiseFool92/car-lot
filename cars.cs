using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public string Message;

  public Car(string makeModel, int price, int miles, string message)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Message = message;
  }

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    bool goodPrice = Price < maxPrice;
    bool goodMiles = Miles < maxMiles;
    return (goodPrice && goodMiles);
  }

}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "This is a weird car");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "This car is probably Russian");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "This car will need to be fixed");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "This car is old");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter max Miles");
    string maxMiles = Console.ReadLine();
    int maxMile = int.Parse(maxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMile))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    if (CarsMatchingSearch.Count == 0)
    {
      Console.WriteLine("Sorry this car is outside of your specifications");
    }
    else
    {
      foreach (Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine(automobile.MakeModel);
        Console.WriteLine(automobile.Message);
      }
    }
  }
}