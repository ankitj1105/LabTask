namespace LabTask.Models;

public class ExpressOrder : Order
{
    public override decimal CalculateTotal() => base.CalculateTotal() + 15m;
}
