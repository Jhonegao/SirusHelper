using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaseValidator<T>
    {
        private List<string> errors = new List<string>();
        public void AddError(string error)
        {
            errors.Add(error);
        }

        public virtual Response Validate(T item)
        {
            return CheckErrors();
        }
        private Response CheckErrors()
        {
            Response r = new Response();
            if (errors.Count != 0)
            {
                StringBuilder builder = new StringBuilder();
                foreach (string item in errors)
                {
                    builder.AppendLine(item);
                }
                r.Message = builder.ToString();
                r.Sucess = false;
                return r;
            }
            r.Sucess = true;
            return r;
        }
    }
}
