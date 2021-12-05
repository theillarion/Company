using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Company.Domain.Entities
{
    // Сущность услуг на сайте
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название услуги!")]
        [Display(Name = "Название услуги (заголовок)")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание услуги")]
        public override string SubTitle { get; set; }

        [Display(Name = "Полное описание услуги")]
        public override string Text { get; set; }
    }
}
