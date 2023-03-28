using System.ComponentModel.DataAnnotations;

namespace DVR_RAMP_Company.Model
{
    public class Tb_Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Rep_Code { get; set; }
        [Required]
        //[DisplayName(Name = "Nome do Representante")]
        public string Rep_Name { get; set; }
        [Required]
        public string Rep_Role { get; set; }

    }

}
