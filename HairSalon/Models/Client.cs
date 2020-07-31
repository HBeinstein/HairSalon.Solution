namespace HairSalon.Models
{
  public class Client
  {
    // properties
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Notes { get; set; }
    public int StylistId { get; set; }
    public virtual Category Category { get; set; }
  }
}