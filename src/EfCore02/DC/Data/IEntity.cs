using System;

namespace DC.Data
{
    public interface IEntity
    {
        object Id { get; set; }
    }

    public interface IEntity<T> : IEntity
    {
        new T Id { get; set; }
    }

    public interface ICreateableEntity
    {
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
    }

    public interface IDeletableEntity
    {
        bool IsDeleted { get; set; }
        string DeletedBy { get; set; }
        DateTime? Deleted { get; set; }
    }

    public interface INamedEntity
    {
        string Name { get; set; }
        string Description { get; set; }
    }

    public interface IVersionedEntity
    {
        byte[] Version { get; set; }
    }
}