namespace Devexpress.TestComponents.Data.Models
{
  public class Person
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Age { get; set; }
    public bool isMarried { get; set; }
    public DateTime? WakesUpAt { get; set; }
    public DateTime? GoesToBedAt { get; set; }
  }
}
