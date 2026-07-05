using Mapper.Communication.Entities;
using Mapper.Domain.Entities.Commons;
using Mapper.Domain.Structs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text;
using Mapper.Domain.Entities.Enums;

namespace Mapper.Domain.Entities
{
    [Table("Notebook")]
    public class Notebook : Computer
    {

        [Display(Name = "NameNOTE", ResourceType = typeof(Notebook))]
        public string Name { get; set; } = string.Empty;
        [Display(Name ="ModelNOTE",ResourceType = typeof(ResEntities))]
        public string? Model { get; set; } = string.Empty;
        [Display(Name = "ManufactoryNOTE", ResourceType = typeof(ResEntities))]
        public string Manufacturer { get; set; } = string.Empty;
        [Display(Name = "SerialNOTE", ResourceType =typeof(ResEntities))]
        public string? SerialNumber { get; set; }



        public override string getAllInformation()
        {
            var sb = new StringBuilder();
            sb.AppendLine(ResEntities.InfoNOTE);
            sb.AppendLine(this.About());
            return sb.ToString();
        }
        public override CodifierEquip SetEquipament()
        {
            return new CodifierEquip(this.Id, ETypeEquip.Notebook);
        }


        private string About()
        {
            StringBuilder sb = new();

            var properties = typeof(Notebook).GetProperties();
            {
                foreach (var property in properties)
                {
                    var display = property.GetCustomAttribute<DisplayAttribute>();
                    var nome = display?.GetName() ?? property.Name;
                    var valor = property.GetValue(this);
                    sb.AppendLine($"{nome}: {valor}");
                }
            }

            return sb.ToString();
        }
    }
}
