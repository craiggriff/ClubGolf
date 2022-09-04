using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ClubGolf.Models
{
    public class Membership 
    {
        [Key]
        public int MembershipId { get; set; }

        public int MembershipTypeId { get; set; }

        public int PersonId { get; set; }

        public bool MembershipActive { get; set; }

        public MembershipType? MembershipType { get; set; }
        public Person? Person { get; set; }

    }



}
