using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace bootcamp_store_backend.Application.Dtos
{
    public class CategoryDto {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public byte[] Image { get; set; }
    }
}