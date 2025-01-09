using Newtonsoft.Json;

public class BadRequestException : Exception
{
    // Constructor con un solo mensaje de error
    public BadRequestException(string message) : base(message) { }

    // Constructor con un mensaje y una descripción adicional
    public BadRequestException(string message, string description) : base(message)
    {
        Description = description;
    }

    // Propiedad para almacenar la descripción adicional
    public string Description { get; }

    // Método para obtener una representación en JSON
    public string GetJsonDescription()
    {
        return JsonConvert.SerializeObject(new { error = Message, description = Description });
    }
}
