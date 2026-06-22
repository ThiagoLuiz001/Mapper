using Mapper.Communication.Entities;
using Mapper.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text;

namespace Mapper.Domain.Entities
{
    [Table("Desktop")]
    public class Desktop : Computer
    {
        [Display(Name = "CoolerDESK", ResourceType = typeof(ResEntities))]
        public string Cooler { get; set; } = string.Empty;

        [Display(Name = "FanDESK", ResourceType =typeof(ResEntities))]
        public string? Fan { get; set; }

        [Display(Name = "CabinetDESK", ResourceType =typeof (ResEntities))]
        public string Cabinet { get; set; } = string.Empty;

        public override string getAllInformation()
        {
            var sb = new StringBuilder();
            sb.AppendLine("______Informarções DeskTop______");
            sb.AppendLine(this.About());
            return sb.ToString();
        }


        private string About()
        {
            StringBuilder sb = new();

            var properties = typeof(Desktop).GetProperties();
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
