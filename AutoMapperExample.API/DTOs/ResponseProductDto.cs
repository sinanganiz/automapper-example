namespace AutoMapperExample.API.DTOs
{
    public class ResponseProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
    }
}