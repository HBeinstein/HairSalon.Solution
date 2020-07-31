using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    // properties
    public int StylistId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Client> Clients { get; set; }

    // contructor
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
  }
}