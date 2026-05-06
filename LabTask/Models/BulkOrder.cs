namespace LabTask.Models;

public class BulkOrder : Order
{
    public override decimal CalculateTotal() => base.CalculateTotal() * 0.9m;
}
