namespace AutoMapperExample.API.DTOs
{
    public class CreateProductDto
    {
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
    }
}