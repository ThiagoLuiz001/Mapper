using Mapper.Communication.Entities;
using System.ComponentModel.DataAnnotations;

namespace Mapper.Domain.Entities.Commons
{
    public abstract class AbstractionDAO
    {
        [Key]
        [Display(Name ="IdDAO", ResourceType =typeof(ResEntities))]
        public Guid Id { get; set; }

        [Display(Name ="CreateDAO", ResourceType =typeof(ResEntities))]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yy HH:mm}")]
        [DataType(DataType.DateTime)]
        public DateTime CreateAt { get; set; }

        [Display(Name ="UpdateDAO", ResourceType = typeof(ResEntities))]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy HH:mm}")]
        [DataType(DataType.DateTime)]
        public DateTime UpdateAt { get; set; }
        [Display(Name ="ObservationDAO",ResourceType = typeof(ResEntities))]
        public string? Observation { get; set; }
        [Display(Name = "ActiveDAO", ResourceType =typeof(ResEntities))]
        [Required]
        public bool Active { get; set; } = true;



    }
}
