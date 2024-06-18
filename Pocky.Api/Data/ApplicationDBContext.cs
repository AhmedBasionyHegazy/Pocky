
namespace Pocky.Api.Data
{
    public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):IdentityDbContext<IdentityUser>(options)
    {
    }
}
