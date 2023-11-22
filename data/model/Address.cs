using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace therapyDB.data.model
{
    public class Address
    {
        [Key]
        [Column("add_id")]
        public int Id { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("postal")]
        public string Postal { get; set; }

        [Column("street")]
        public string Street { get; set; }

        [Column("nr")]
        public string HomeNumber { get; set; }

        [InverseProperty("Address")]
        public ICollection<Patient> Patients { get; set; }
    }
}
