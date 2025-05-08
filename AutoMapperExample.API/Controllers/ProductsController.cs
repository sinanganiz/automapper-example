using AutoMapper;
using AutoMapperExample.API.Data;
using AutoMapperExample.API.DTOs;
using AutoMapperExample.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperExample.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProductsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseProductDto>>> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            var responseProductDtos = _mapper.Map<List<ResponseProductDto>>(products);
            return Ok(responseProductDtos);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseProductDto>> Create(CreateProductDto createProductDto)
        {
            var product = _mapper.Map<Product>(createProductDto);
            product.CreatedAt = DateTime.UtcNow;
            product.UpdatedAt = DateTime.UtcNow;

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return Ok(_mapper.Map<ResponseProductDto>(product));
        }

    }
}