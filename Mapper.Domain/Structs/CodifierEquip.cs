
using Mapper.Domain.Entities.Enums;
using Mapper.Domain.Extensions;

namespace Mapper.Domain.Structs
{
    public struct CodifierEquip
    {

        private int _index;
        private ETypeEquip _type;

        public ETypeEquip Type { get { return this._type; } }
        public string Result { get 
            {
                return String.Concat(this._type.AbbreviationCode(), _index.ToString("0000"));
            } }


        public CodifierEquip(int index, ETypeEquip type)
        {
            _index = index;
            _type = type;
        }

    }
}
