namespace businesslayer;
public class ResultDTO
{
    public Int64 InputNumber { get; set; }
    public List<Int64> DivisorsList { get; set; } = new();
    public List<Int64> PrimeNumberList { get; set; } = new();

}
