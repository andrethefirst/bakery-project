namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Amount { get; set; }
    public int Price { get; set; }

    public Bread(int amount, int price = 0)
    {
      Amount = amount;
      Price = price;
    }
  }
}