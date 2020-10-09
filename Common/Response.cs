using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//calsses que sao referenciadas por todo projeto mas nao sao entidades
namespace Common
{
    public class Response
    {
        public bool Sucess { get; set; }
        public string Message { get; set; }
        public string ExceptionError { get; set; }
        public string StackTrace { get; set; }
    }
}
