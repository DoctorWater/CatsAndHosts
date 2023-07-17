using CatsAndHosts.Interfaces;

namespace CatsAndHosts.Entities;

public class Dog : IPet
{
    public Guid Id { get; }
    public string Name { get; }
    public DateOnly DateOfBirth { get; }
    public Sex Sex { get; }
    public IOwner? Owner { get; set; }

    public Dog(string name, DateOnly dateOfBirth, Sex sex, IOwner? owner)
    {
        Id = new Guid();
        Name = name;
        DateOfBirth = dateOfBirth;
        Sex = sex;
        Owner = owner;
    }

    public bool HasOwner()
    {
        if (Owner is not null)
        {
            return true;
        }

        return false;
    }

    protected bool Equals(Dog other)
    {
        return Id.Equals(other.Id) && Name == other.Name && DateOfBirth.Equals(other.DateOfBirth) && Sex == other.Sex && Equals(Owner, other.Owner);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Dog)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, DateOfBirth, (int)Sex, Owner);
    }
}