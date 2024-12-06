

using jobBoardWADCW.Data;
using jobBoardWADCW.Models;

public class ListingRepository : IListingRepository
{
    private readonly JobBoardDBContext _context;

    public ListingRepository(JobBoardDBContext context)
    {
        _context = context;
    }

    public IEnumerable<Listing> GetAllListings() => _context.Listings.ToList();

    public Listing GetListingById(Guid id) => _context.Listings.Find(id);

    public void AddListing(Listing listing)
    {
        _context.Listings.Add(listing);
        _context.SaveChanges();
    }

    public void DeleteListing(Guid id)
    {
        var listing = _context.Listings.Find(id);
        if (listing != null)
        {
            _context.Listings.Remove(listing);
            _context.SaveChanges();
        }
    }

    public void UpdateListing(Guid id, Listing updatedListing)
    {
        var existingListing = _context.Listings.Find(id);
        if (existingListing != null)
        {
            existingListing.CompanyName = updatedListing.CompanyName;
            existingListing.Position = updatedListing.Position;
            existingListing.Salary = updatedListing.Salary;

            _context.SaveChanges();
        }
    }
}
