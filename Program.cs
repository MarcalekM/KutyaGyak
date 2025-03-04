using KutyaGyak;

List<Kutya> kutyak = Kutya.LoadFromCsv("adatok.csv");

var f6 = kutyak.Average(k =>k.Kor);
Console.WriteLine($"6. feladat: Kutyák átlagéletkora: {f6:0.00} év\n");


var f7 = kutyak.Where(k => k.Kan)
    .OrderByDescending(k => k.Kor)
    .First();
Console.WriteLine($"7. feladat: A legidősebb kan kutya neve és fajtája:\n{f7.ToString()}\n");

Console.WriteLine("8. feladat: Adatok fájlba írása");
var f8 = kutyak.Where(k => k.ChipDatum.Year.Equals(2022))
    .ToList();
using StreamWriter sw = new(
    path: @"../../../src/idei.txt",
    append: false);
foreach (var kutya in f8)  sw.WriteLine($"{f8.IndexOf(kutya) + 1};{kutya.Nev};{kutya.ChipDatum.Year}.{kutya.ChipDatum.Month}.{kutya.ChipDatum.Day}.");