using System.ComponentModel.DataAnnotations;

namespace AspNetCoreAPI.Models
{
    public class FormModel
    {
        [Key]
        public int FormId { get; set; }
        public string? Mc_Nickname { get; set; }
        public string? Dc_Tag { get; set; }
        public string? Reason { get; set; }
    }
}
