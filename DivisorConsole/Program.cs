
using Newtonsoft.Json;
using static businesslayer.DivisorService;
// See https://aka.ms/new-console-template for more information



var vish = new businesslayer.DivisorService().GetDivisors(9);




Console.WriteLine(JsonConvert.SerializeObject(vish));
