/*This is work of a student of WIUT with ID of 00016933*/

using jobBoardWADCW.Models;
using Microsoft.EntityFrameworkCore;
namespace jobBoardWADCW.Data
{
    public class JobBoardDBContext : DbContext
    {
        public JobBoardDBContext(DbContextOptions options):base(options) {}

        public DbSet<Listing> Listings { get; set; }
    }
}