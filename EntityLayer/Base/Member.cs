using EntityLayer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Base
{
	public class Member
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "İsim")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [StringLength(50, ErrorMessage = "En fazla {1} karakter uzunluğunda olmalıdır.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Ad sadece harflerden oluşmalıdır.")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [StringLength(50, ErrorMessage = "En fazla {1} karakter uzunluğunda olmalıdır.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Ad sadece harflerden oluşmalıdır.")]
        public string Surname { get; set; }

        [Display(Name = "Yaş")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Telefon numarası sadece rakamlardan oluşmalıdır.")]
        public byte Age { get; set; }

        [ForeignKey("CreatedBy")]
        public virtual ICollection<Form> Forms { get; set; }
    }
}
