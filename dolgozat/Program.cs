using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> osvenyek = File.ReadAllLines("osvenyek.txt").Select(x => x.Trim()).ToList();
        List<int> dobasok = File.ReadAllText("dobasok.txt").Trim().Split().Select(int.Parse).ToList();



        Console.WriteLine("\n2. feladat");
        Console.WriteLine($"A dobások száma: {dobasok.Count}");
        Console.WriteLine($"Az ösvények száma: {osvenyek.Count}");
        Console.WriteLine("-------------------------------------------------");



        Console.WriteLine("\n3. feladat");
        int maxOsveny = osvenyek.FindIndex(osveny => osveny.Length == osvenyek.Max(x => x.Length)) + 1;

        Console.WriteLine($"Az egyik leghosszabb a(z) {maxOsveny}. ösvény, hossza: {osvenyek[maxOsveny - 1].Length}");
        Console.WriteLine("-------------------------------------------------");


        Console.WriteLine("\n4. feladat");
        Console.Write("Adja meg egy ösvény sorszámát! ");

        int osvenySorszam = int.Parse(Console.ReadLine());

        Console.Write("Adja meg a játékosok számát! ");

        int jatekosSzam = int.Parse(Console.ReadLine());
        string osveny = osvenyek[osvenySorszam - 1];
        Console.WriteLine("-------------------------------------------------");



        Console.WriteLine("\n5. feladat");

        var szotar = osveny.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        foreach (var szotarElem in szotar)

        {
            Console.WriteLine($"{szotarElem.Key}: {szotarElem.Value} darab");
        }
        Console.WriteLine("-------------------------------------------------");

        Console.WriteLine("\n6. feladat");        
        File.WriteAllLines("kulonleges.txt", osveny.Select((mezo, sorszam) => mezo != 'M' ? $"{sorszam + 1}\t{mezo}" : null).Where(x => x != null));
        Console.WriteLine("Sikeres Kiiratás ");

    }

}

// Segítségek:
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.findindex?view=net-8.0
// https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.todictionary?view=net-8.0
 


//   __           __         ______     __   __   ______           __    __     ______     ______     __  __     __     __     ______     ______     ______  
//  /\ \         /\ \       /\  __ \   /\ \ / /  /\  ___\         /\ "-./  \   /\  ___\   /\  ___\   /\ \_\ \   /\ \  _ \ \   /\  __ \   /\  == \   /\__  _\ 
//  \ \ \        \ \ \____  \ \ \/\ \  \ \ \'/   \ \  __\         \ \ \-./\ \  \ \  __\   \ \ \____  \ \  __ \  \ \ \/ ".\ \  \ \  __ \  \ \  __<   \/_/\ \/ 
//   \ \_\        \ \_____\  \ \_____\  \ \__|    \ \_____\        \ \_\ \ \_\  \ \_____\  \ \_____\  \ \_\ \_\  \ \__/".~\_\  \ \_\ \_\  \ \_\ \_\    \ \_\ 
//    \/_/         \/_____/   \/_____/   \/_/      \/_____/         \/_/  \/_/   \/_____/   \/_____/   \/_/\/_/   \/_/   \/_/   \/_/\/_/   \/_/ /_/     \/_/ 
                                                                                                                                                         