using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class SirusDAL
    {
        public DBResponse Insert(Sirus sirus)
        {
            DBResponse response = new DBResponse();
            //classe responsavel por realizar conexao fisica com banco de dados
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\dbSirus.mdf;Integrated Security=True;Connect Timeout=30";
            //classe responsavel por realizar um querry no DB
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO SIRUS(NOME,AWAKENER,COMPLETADO,ATIVO) VALUES (@NOME,@AWAKENER,@COMPLETADO,@ATIVO)";
            command.Parameters.AddWithValue("@NOME", sirus.Nome);
            command.Parameters.AddWithValue("@AWAKENER", sirus.Awakener);
            command.Parameters.AddWithValue("@COMPLETADO", sirus.Completado);
            command.Parameters.AddWithValue("@ATIVO", true);                
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Sucess = true;
                response.Message = "Cadastrado com sucess.";
            }
            catch(Exception e)
            {
                response.Sucess = false;
                response.Message = "Erro no Banco de dados, contato o administrador.";
                //estas duas propriedades sao para LOG
                response.StackTrace = e.StackTrace;
                response.ExceptionError = e.Message;
            }
            finally
            {
                //finaly sempre executa.
                connection.Close();
            }
            return response;
        }
        public DBResponse Update(Sirus sirus)
        {
            DBResponse response = new DBResponse();
            //classe responsavel por realizar conexao fisica com banco de dados
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\dbSirus.mdf;Integrated Security=True;Connect Timeout=30";
            //classe responsavel por realizar um querry no DB
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE Sirus SET NOME = @NOME, ATIVO = @ATIVO, AWAKENER = @AWAKENER, COMPLETADO = @COMPLETADO, WHERE ID = @ID";
            command.Parameters.AddWithValue("@NOME", sirus.Nome);
            command.Parameters.AddWithValue("@AWAKENER", sirus.Awakener);
            command.Parameters.AddWithValue("@COMPLETADO", sirus.Completado);
            command.Parameters.AddWithValue("@ID", sirus.ID);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    response.Sucess = false;
                    response.Message = "Registro nao encontrado";
                    return response;
                }
                response.Sucess = true;
                response.Message = "Atualizado com sucesso.";
            }
            catch (Exception e)
            {
                response.Sucess = false;
                response.Message = "Erro no Banco de dados, contato o administrador.";
                //estas duas propriedades sao para LOG
                response.StackTrace = e.StackTrace;
                response.ExceptionError = e.Message;
            }
            finally
            {
                //finaly sempre executa.
                connection.Close();
            }
            return response;
        }
        public DBResponse Delete(Sirus sirus)
        {
            DBResponse response = new DBResponse();
            //classe responsavel por realizar conexao fisica com banco de dados
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\dbSirus.mdf;Integrated Security=True;Connect Timeout=30";
            //classe responsavel por realizar um querry no DB
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE Sirus SET ATIVO = @ATIVO, WHERE ID = @ID";
            command.Parameters.AddWithValue("@ATIVO", false);
            command.Parameters.AddWithValue("@ID", sirus.ID);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    response.Sucess = false;
                    response.Message = "Registro nao encontrado";
                    return response;
                }
                response.Sucess = true;
                response.Message = "Deletado com sucesso";
            }
            catch (Exception e)
            {
                response.Sucess = false;
                response.Message = "Erro no Banco de dados, contato o administrador.";
                //estas duas propriedades sao para LOG
                response.StackTrace = e.StackTrace;
                response.ExceptionError = e.Message;
            }
            finally
            {
                //finaly sempre executa.
                connection.Close();
            }
            return response;
        }
    }
}
