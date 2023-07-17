using CatsAndHosts.Interfaces;

namespace CatsAndHosts.Entities;

public class Cat : IPet
{
    public Guid Id { get; }
    public string Name { get; }
    public DateOnly DateOfBirth { get; }
    public Sex Sex { get; }
    public IOwner? Owner { get; set; }

    public Cat(string name, DateOnly dateOfBirth, IOwner? host, Sex sex)
    {
        Id = new Guid();
        Name = name;
        DateOfBirth = dateOfBirth;
        Owner = host;
        Sex = sex;
    }

    public bool HasOwner()
    {
        if (Owner is not null)
        {
            return true;
        }

        return false;
    }

    protected bool Equals(Cat other)
    {
        return Id.Equals(other.Id) && Name == other.Name && DateOfBirth.Equals(other.DateOfBirth) && Sex == other.Sex && Equals(Owner, other.Owner);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Cat)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, DateOfBirth, (int)Sex, Owner);
    }
}