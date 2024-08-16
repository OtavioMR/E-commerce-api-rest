using web_api_rest.Models;
using Microsoft.EntityFrameworkCore;

namespace web_api_rest.Data
{
    public class EcommerceSystemDbContext : DbContext
    {
        public EcommerceSystemDbContext(DbContextOptions<EcommerceSystemDbContext> options) : base(options) { }
    }
}
