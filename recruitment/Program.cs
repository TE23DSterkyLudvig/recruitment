//List<string> names = ["Ludde", "Kotte", "Bertil"];

// names[1] = "bertina";

// names.Add("luddeman");
// names.Add("Robust");
// names.Remove("Ludde");

// //System.Console.WriteLine(string.Join("\n",names));


// for (int i = 0; i < names.Count; i++)
// {
//    Console.WriteLine(names[i]) ;
// }


//String name = Console.ReadLine();
//if (name == names[1]){
// System.Console.WriteLine("Hej dummer!");
//}

//System.Console.WriteLine(names[1]);

// Console.ReadLine();
List<string> recruites = ["John", "Johan", "Josef", "Jonkler"];
List<string> platser = [];

while (recruites.Count >= 1)
{
   //List<string>recruites = ["John", "Johan", "Josef", "Jonkler"];
   //List<string>platser =["plats1","plats2", "plats3"];

   System.Console.WriteLine($"Du är sergant för Helldivers och din uppgift är att överskåda nya recruits och sätta dem i tjänst.");
   Thread.Sleep(800);
   System.Console.WriteLine($"Det är {recruites.Count} stycken recruits men du har bara {3 - platser.Count} platser.");
   Thread.Sleep(800);
   // System.Console.WriteLine("Du kan välja mellan Nummer 1 John, nummer 2 Johan, nummer 3 Josef eller nummer 4 Jonkler.");
   for (int i = 0; i < recruites.Count; i++)
   {
      Console.WriteLine($"{i + 1}. {recruites[i]}");

   }


   int namnnum = 1000;
   while (namnnum > recruites.Count)
   {
      System.Console.WriteLine("Skriv ett av nummerna 1 till 4");
      string namn = Console.ReadLine();
      int.TryParse(namn, out namnnum);
      namnnum -= 1;
      // System.Console.WriteLine(Skriv);
   }
   //platser.RemoveAt(namnnum);
   platser.Add(recruites[namnnum]);
   recruites.RemoveAt(namnnum);

}
if (recruites.Count == 1)
{
   System.Console.WriteLine($"Du har nu {platser.Count} färdigutbildade helldivers redo för strid.");
   System.Console.WriteLine($"{platser[0]} och {platser[1]} och {platser[2]}");
}

Console.ReadLine();