using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SirusBLL : BaseValidator<Sirus>
    {

        public override Response Validate(Sirus item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
            {
                AddError("O Nome deve ser informado");
            }
            else if (item.Nome.Length < 3 || item.Nome.Length > 50)
            {
                AddError("O nome deve conter de 3 a 50 caracteres");
            }
            return base.Validate(item);
        }
    }
}
