using Mapper.Communication.Entities;
using Mapper.Domain.Entities.Enums;
using Mapper.Domain.Structs;
using System.ComponentModel.DataAnnotations;



namespace Mapper.Domain.Entities.Commons
{
    public abstract class Computer :AbstractionIntDAO
    {
        [Display(Name = "GuidCOMPUTER",ResourceType =typeof(ResEntities))]
        public Guid? EquipamentId { get; set; }
        [Display(Name = "EquipamentCOMPUTER", ResourceType = typeof(ResEntities))]
        public Equipament? Equipament { get; set; }
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
        [Display(Name = "MacCOMPUTER", ResourceType = typeof(ResEntities))]
        public string? MacAddress { get; set; }

        public EStatusComputer Status { get; set; }


        public abstract string getAllInformation();
        public abstract CodifierEquip SetEquipament();

    }
}
