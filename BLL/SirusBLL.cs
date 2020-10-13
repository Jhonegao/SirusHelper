using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Extensions;
using DAL;

namespace BLL
{
    public class SirusBLL : BaseValidator<Sirus>
    {
        private SirusDAL sirusDAL= new SirusDAL();

        public Response Insert(Sirus item)
        {
            //Chama o método de validação do cliente
            Response response = Validate(item);

            //Se a validação passar:
            if (response.Success)
            {
                //Em caso de controle de log, poderiamos ter algo parecido com isso!
                //Response dbResponse = clienteDAO.Insert(item);
                //if (!dbResponse.Success)
                //{
                //    //LogError(dbResponse);
                //}
                //Chamar o método que insere o cliente no banco!
                return sirusDAL.Insert(item);
            }
            //Retornar o erro para o cliente
            return response;
        }
        public Response Update(Sirus item)
        {
            Response response = Validate(item);
            if (response.Success)
            {
                return sirusDAL.Insert(item);
            }
            return response;
        }
        public Response GetAll(Sirus item)
        {
            Response response = Validate(item);
            if (response.Success)
            {
                return sirusDAL.GetAll();
            }
            return response;
        }

        public override Response Validate(Sirus item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
            {
                AddError("O Nome deve ser informado");
            }
            else
            {
                item.Nome = item.Nome.Trim().ToLower();
            }
            //else if (item.Nome.Length < 3 || item.Nome.Length > 50)
            //{
            //    AddError("O nome deve conter de 3 a 50 caracteres");
            //}
            AddError(item.Nome.IsValidLenght(3, 70, "Nome"));
            if (item.Awakener < 0 || item.Awakener > 8)
            {
                AddError("Awakener do sirus inválido");
            }

            return base.Validate(item);
        }

    }
}
