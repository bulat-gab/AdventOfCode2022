// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine(Day1Part2());


int Day1()
{
    int maxCalories = 0;
    int currentElfCalories = 0;

    foreach(var line in File.ReadAllLines("./input/day1"))
    {
        if (int.TryParse(line, out var calories))
        {
            currentElfCalories += calories;
        }

        if (string.IsNullOrWhiteSpace(line))
        {
            maxCalories = Math.Max(maxCalories, currentElfCalories);
            currentElfCalories = 0;
        }
    }

    return maxCalories;
}

int Day1Part2()
{
    var caloriesList = new List<int>();
    int currentElfCalories = 0;

    foreach (var line in File.ReadAllLines("./input/day1"))
    {
        if (int.TryParse(line, out var calories))
        {
            currentElfCalories += calories;
        }

        if (string.IsNullOrWhiteSpace(line))
        {
            caloriesList.Add(currentElfCalories);
            currentElfCalories = 0;
        }
    }

    return caloriesList.OrderByDescending(x => x).Take(3).Sum();
}