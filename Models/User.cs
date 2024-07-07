namespace Bunker_API.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? Isadmin { get; set; }

    public int Roomid { get; set; }

    public int Professionid { get; set; }

    public int Biologyid { get; set; }

    public int Healthid { get; set; }

    public int Hobbyid { get; set; }

    public int Bagid { get; set; }

    public int Factid { get; set; }

    public virtual Bag Bag { get; set; } = null!;

    public virtual Biology Biology { get; set; } = null!;

    public virtual Fact Fact { get; set; } = null!;

    public virtual Health Health { get; set; } = null!;

    public virtual Hobby Hobby { get; set; } = null!;

    public virtual Profession Profession { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
}
