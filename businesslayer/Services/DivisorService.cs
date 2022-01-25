using businesslayer.Interfaces;

namespace businesslayer;
public class DivisorService: IDivisorService
{

    public ResultDTO GetDivisors(Int64 input)
    {
        ResultDTO result = new(){ 
            InputNumber = input,
            DivisorsList = new List<Int64>{1}
        };
        if(input!=1){
            Int64 square = (int)Math.Sqrt(input);
            for(Int64 i = 2; i<square+1; i++){
                if(input%i==0)
                {
                    if(input/i==i) 
                        result.DivisorsList.Add(i);
                    
                    else{
                        result.DivisorsList.AddRange(new List<Int64>(){i, input/i});
                    }

                    if(IsPrimeNumber(i)) result.PrimeNumberList.Add(i);


                }
            }
            result.DivisorsList.Add(input);
            result.DivisorsList = result.DivisorsList.OrderBy(x=>x).ToList();

        }
        return result;

    }

    public bool IsPrimeNumber(Int64 number)
    {
        if(number==1) return false;

        List<Int64> divisors = new();
        Int64 square = (int)Math.Sqrt(number);
            for(Int64 i = 2; i<square+1; i++){
                if(number%i==0)
                {
                        divisors.Add(i);
                        if(divisors.Count>0)
                        return false;

                }
            }


        return true;

    }

}
