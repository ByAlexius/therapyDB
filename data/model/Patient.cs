using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace therapyDB.data.model
{
    [Table("patients")]
    public class Patient
    {
        [Key]
        [Column("pat_id")]
        public int Id { get; set; }

        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("address")]
        [ForeignKey("Address")]
        public int AddressId { get; set; }

        public Address Address { get; set; }
    }
}
