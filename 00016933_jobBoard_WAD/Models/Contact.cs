/*This is work of a student of WIUT with ID of 00016933*/

namespace jobBoardWADCW.Models
{
    public class Listing
    {
        public Guid Id { get; set; }
        public required string CompanyName { get; set; }
        public required string Position { get; set; }
        public required string Salary { get; set; }
    }
}