using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GIVE_AID.Models
{
    public class donation
    {
        [Key]
        public int donatorId { get; set; }
        [Required]
        public string amount { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string contact { get; set; }

        public int? donationId { get; set; }

        [ForeignKey("donationId")]
        public AddDonation AddDonation { get; set; }

        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public UserReg UserReg { get; set; }

        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }

    }
}
