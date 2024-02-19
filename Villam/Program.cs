using Villam;
using System.Linq;



List<VillaM> villamok = new();
using StreamReader sr = new(
    path: @"..\..\..\src\villam.txt",
    encoding: System.Text.Encoding.UTF8);
while (!sr.EndOfStream) villamok.Add(new(sr.ReadLine()));


foreach (var i in villamok)
{
    Console.WriteLine(i.ToString());
}



Console.WriteLine();
//var f3 = villamok.Max(x => x.Ora.Count());
//Console.WriteLine($"{f3} órakot rötrént a legtöbb villámlás");

List<int> f3 = new();
int f3Counter = 1;
foreach (var villam in villamok)
{
    for (int i = 0; i < villam.Ora.Count; i++)
    {
        if (villam.Ora[i] > 250 && !f3.Contains(f3Counter)) f3.Add(f3Counter);
    }
    f3Counter++;
}
foreach (var f in f3) Console.WriteLine($"\tasd {f}.");



Console.WriteLine("\n4. feladat:");
Dictionary<int, int> f4 = new();
for (int i = 0; i < villamok.Count; i++)
{
    for (int j = 0; j < villamok[i].Ora.Count; j++)
    {
        if (villamok[i].Ora[j] != 0 && !f4.ContainsKey(i + 1))
        {
            f4.Add(i + 1, j + 1);
        }
    }
    if (!f4.ContainsKey(i + 1)) f4.Add(i + 1, 0);
}
Console.WriteLine(f4);
using StreamWriter sw = new(
                path: @"..\..\..\src\f4.txt",
                encoding: System.Text.Encoding.UTF8,
                append: false);
foreach (var f in f4)
{
    if (f.Value != 0) Console.WriteLine($"\tAugusztus {f.Key}: {f.Value}");
    else Console.WriteLine($"\tAugusztus {f.Key}: null");
    if (f.Value != 0) sw.WriteLine($"\tAugusztus {f.Key}: {f.Value}");
    else sw.WriteLine($"\tAugusztus {f.Key}: null");
}




Console.WriteLine($"\n5. feladat:");
int f5 = 0;
for (int i = 0; i < villamok.Count; i++)
{
    for (int j = 0; j < villamok[i].Ora.Count; j++)
    {
        if (villamok[i].Ora[j] > 0) f5++;
    }
}
Console.WriteLine($"\t{f5} órában villámlott");



Console.ReadKey();
