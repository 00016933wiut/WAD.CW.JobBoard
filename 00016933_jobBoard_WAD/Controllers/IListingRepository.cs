using jobBoardWADCW.Models;

public interface IListingRepository
{
    IEnumerable<Listing> GetAllListings();
    Listing GetListingById(Guid id);
    void AddListing(Listing listing);
    void DeleteListing(Guid id);
    void UpdateListing(Guid id, Listing listing);
}
