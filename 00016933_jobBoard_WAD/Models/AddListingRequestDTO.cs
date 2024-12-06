/*This is work of a student of WIUT with ID of 00016933*/

namespace jobBoardWADCW.Models
{
    public class AddListingRequestDTO
    {
        public required string companyName { get; set; }
        public required string position { get; set; }
        public required string salary { get; set; }
    }
}