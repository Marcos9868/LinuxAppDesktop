namespace Domain.ValueObjects
{
    public sealed class ProjectName
    {
       public string Value { get; }
       public ProjectName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Nome do projeto é obrigatório.");

            if (value.Length < 3)
                throw new ArgumentException("Nome do projeto deve ter ao menos 3 caracteres.");

            Value = value.Trim();
        } 
    }
}