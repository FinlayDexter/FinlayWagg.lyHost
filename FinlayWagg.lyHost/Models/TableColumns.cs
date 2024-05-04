using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
/* The data gathering info including database column name and display data as well as the Key being 'ID' */
namespace FinlayWagg.lyHost.Models
{
    public class TableColumns
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date")]
        public DateTime LeadDate { get; set; }

        public string Name { get; set; }
        [DisplayName("Dog Owner or Walker (If You're an Owner Please Enter 'Owner of <Dogs Name> a <Dogs Breed>')")]
        public string WalkerOrOwner { get; set; }
        [DisplayName("Client Contact Email")]
        public string Email { get; set; }
        [DisplayName("Suggested Walk Time (Minutes)")]
        public string SuggestedWalkTime { get; set; }
    }
}
