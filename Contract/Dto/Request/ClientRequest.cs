namespace Contracts.Dto.Request
{
    public class ClientRequest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Cuit { get; set; }
        public long Dni { get; set; }
        public DateTime Nacimiento { get; set; }
        public int Phone { get; set; }
    }
}
