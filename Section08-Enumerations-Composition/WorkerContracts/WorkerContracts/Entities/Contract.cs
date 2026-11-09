namespace WorkerContracts.Entities;

public class Contract
{
    public DateOnly Date {  get; set; }
    public decimal ValuePerHour { get; set; }
    public int Hours { get; set; }

    public decimal TotalValue()
    {
        return Hours * ValuePerHour;
    }        
}
