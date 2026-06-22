using Mapper.Communication.Entities;
using Mapper.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;



namespace Mapper.Domain.Entities.Commons
{
    public abstract class Computer :AbstractionDAO
    {
        [Display(Name = "CpuCOMPUTER",ResourceType =typeof(ResEntities))]
        public string Cpu { get; set; } = string.Empty;

        [Display(Name = "boardCOMPUTER", ResourceType =typeof(ResEntities))]
        public string Motherboard { get; set; } = string.Empty;

        [Display(Name = "GpuCOMPUTER", ResourceType = typeof(ResEntities))]
        public string Gpu { get; set; } = string.Empty;

        [Display(Name = "RamCOMPUTER",ResourceType = typeof(ResEntities))]
        public string Ram { get; set; } = string.Empty;

        [Display(Name = "StorageComputer")]
        public string Storage { get; set; } = string.Empty;

        [Display(Name = "FonteCOMPUTER",ResourceType =typeof (ResEntities))]
        public string? Font { get; set; }

        public string Information { get
            {
                return getAllInformation();
            } private set; }

        public EStatusComputer Status { get; set; }


        public abstract string getAllInformation();

    }
}
