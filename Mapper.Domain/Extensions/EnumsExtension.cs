using Mapper.Domain.Entities.Enums;

namespace Mapper.Domain.Extensions
{
    public static class EnumsExtension
    {
        public static bool IsAvailable(this EStatusComputer status)
        {
            return status.Equals(EStatusComputer.Disponivel) || status.Equals(EStatusComputer.Sobressalente) ;
        }

        public static string  AbbreviationCode(this ETypeEquip equip)
        {
            return equip switch
            {
                ETypeEquip.Desktop => "DESK",
                ETypeEquip.Notebook => "NOTE",
                ETypeEquip.Screen => "SCREEN",
                ETypeEquip.Printer => "PRINT",
                ETypeEquip.Server => "SVD",
                ETypeEquip.Nobreak => "NBRK",
                ETypeEquip.Firewall => "FW"
            };
        }
    }
}
