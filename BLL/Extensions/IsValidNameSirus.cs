using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Extensions
{
    public static class IsValidNameSirus
    {
		public static string IsValidLenght(this string val, int min, int max, string fieldName)
		{
			if (val.Length < min)
			{
				return "O campo " + fieldName + " deve conter no mínimo " + min + " caracteres.";
			}
			return "";
		}

	}
}
