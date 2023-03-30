using EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Classes
{
    public class Form
    {
        [Key]
        public Guid Id { get; set; }= Guid.NewGuid();

        [Display(Name = "Form Adı")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [StringLength(50, ErrorMessage = "En fazla {1} karakter uzunluğunda olmalıdır.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Ad sadece harflerden oluşmalıdır.")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [StringLength(250, ErrorMessage = "En fazla {1} karakter uzunluğunda olmalıdır.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Ad sadece harflerden oluşmalıdır.")]
        public string Description { get; set; }

        [Display(Name = "Oluşturma Tarihi")]
        [DataType(DataType.Date)]

        public DateTime CreatedAt { get; set; }

        [Display(Name = "Oluşturan Kişi")]
        [ForeignKey("CreatedBy")]
        public int CreatedBy { get; set; }
        public virtual LoginMember Member { get; set; }
    }
}
