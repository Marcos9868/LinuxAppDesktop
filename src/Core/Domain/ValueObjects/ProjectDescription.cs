namespace Domain.ValueObjects
{
    public sealed class ProjectDescription
    {
        public string Value { get; }
        public ProjectDescription(string value)
        {
            if (value.Length > 500)
                throw new ArgumentException("Descrição não pode exceder 500 caracteres.");

            Value = value.Trim();
        }
    }
}