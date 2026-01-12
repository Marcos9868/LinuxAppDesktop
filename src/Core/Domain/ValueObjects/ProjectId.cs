namespace Domain.ValueObjects
{
    public sealed class ProjectId
    {
       public Guid Value { get; }
       public ProjectId(Guid value)
        {
            if (value == Guid.Empty)
                throw new ArgumentException("ProjectId cannot be empty");

            Value = value;
        } 
        public static ProjectId New() => new(Guid.NewGuid());
    }
}