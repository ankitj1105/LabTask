namespace LabTask.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; } = "New";
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public virtual decimal CalculateTotal()
    {
        return Items.Sum(item => item.TotalPrice);
    }

}
