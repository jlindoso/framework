
using Newtonsoft.Json;
using static businesslayer.DivisorService;
// See https://aka.ms/new-console-template for more information


string input =string.Empty;

var _service = new businesslayer.DivisorService();


do{
     Console.Clear();
    Console.WriteLine("Bem Vindo, digite um número natural maior que 0 ou q para sair:");

    input = Console.ReadLine();
    
    if(Int64.TryParse(input, out Int64 valid)){
        
        var result = _service.GetDivisors(valid);
        Console.WriteLine(string.Format("Número de entrada:{0}", result.InputNumber));
        Console.WriteLine(string.Format("Números Divisores:{0}", JsonConvert.SerializeObject(result.DivisorsList)));
        Console.WriteLine(string.Format("Divisores primos:{0}", JsonConvert.SerializeObject(result.PrimeNumberList)));
        Console.WriteLine("\n\n\n\nPrecione qualquer tecla para continuar");
        Console.Read();

    };

    




}while(!input.Equals("q"));






