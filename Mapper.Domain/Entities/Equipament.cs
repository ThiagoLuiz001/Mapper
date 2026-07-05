using Mapper.Domain.Entities.Commons;
using Mapper.Domain.Entities.Enums;
using Mapper.Domain.Extensions;
using Mapper.Domain.Structs;


namespace Mapper.Domain.Entities
{
    public class Equipament : AbstractionDAO
    {
        public ETypeEquip Type { get; set; }
       
        public string? Code { get;  set; }

        public Equipament(CodifierEquip codifier)
        {
            Type = codifier.Type;
            Code = codifier.Result;
        }
        public Equipament() { }
        List<string> GetEquipments()
        {
            var list = new List<string>();
            
        }

    }
}
