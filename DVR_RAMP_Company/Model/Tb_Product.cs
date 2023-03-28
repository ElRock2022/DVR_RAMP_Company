using System.ComponentModel.DataAnnotations;

namespace DVR_RAMP_Company.Model
{

    public class Tb_Product
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Marca")]
        public string PRD_Brand { get; set; }
        [Required]
        [Display(Name = "Submarca")]
        public string PRD_SubBrand { get; set; }

        [Required]
        [Display(Name = "Nome do artigo")]
        public string PRD_Name { get; set; }
        
        //[Range(1, 500)]
        public int PRD_Price { get; set; }
        
        public string? PRD_Code { get; set; }
        
        public DateOnly PRD_Date_Launched { get; set; }
        public byte[]? PRD_Image { get; set; }



    }
}
