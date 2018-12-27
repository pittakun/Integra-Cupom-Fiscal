using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace GelocarEntregas
{
    class DAL_cliente
    {
        connection con = new connection();
        private MySqlCommand command;
        private MySqlDataReader infos;

        public string INSERT(BLL_client people)
        {
            try
            {
                con.init();
                string query = "INSERT INTO client(phone,address)VALUES('" + people.phone + "','" + people.address + "')";
                command = new MySqlCommand(query, con.connect);
                command.ExecuteNonQuery();
                con.disconnect();
                return "Adicionado com sucesso";
            }
            catch (Exception excep)
            {
                throw new Exception("Erro de comandos!\n" + excep.Message);
            }



        }

        public List<BLL_client> SELECT( BLL_client bll_client)
        {
            List<BLL_client> returning = new List<BLL_client>();
            try
            {
                con.init();
                string query = "SELECT `id`, `phone`, `address` FROM `client` WHERE address like '%"+ bll_client.address +"%' ORDER BY address DESC ";
                command = new MySqlCommand(query, con.connect);
                infos = command.ExecuteReader();

                while (infos.Read())
                {
                    BLL_client alloc = new BLL_client();
                    alloc.id = Convert.ToInt32( infos["id"]);
                    alloc.phone = infos["phone"].ToString();
                    alloc.address = infos["address"].ToString();

                    returning.Add(alloc);
                }
                con.disconnect();
                return returning;
            }
            catch (Exception excep)
            {
                throw new Exception("Erro de comandos!\n" + excep.Message);
            }
            
        }

        public string UPDATE(BLL_client bll_client)
        {
            try
            {
                con.init();
                string query = "UPDATE client SET phone = '" + bll_client.phone + "',address = '" + bll_client.address + "' WHERE id = '" + bll_client.id + "'";
                command = new MySqlCommand(query, con.connect);
                infos = command.ExecuteReader();
                con.disconnect();
                return "Alterado com sucesso";
            }
            catch (Exception excep)
            {
                throw new Exception("Erro de comandos!\n" + excep.Message);
            }
           
        }

        public string DELETE(BLL_client bll_client)
        {
            try
            {
                con.init();
                string query = "DELETE FROM `client` WHERE id = " + bll_client.id;
                command = new MySqlCommand(query, con.connect);
                infos = command.ExecuteReader();
                con.disconnect();
                return "Excluido com sucesso";
            }
            catch (Exception excep)
            {
                throw new Exception("Erro de comandos!\n" + excep.Message);
            }
        }

        public List<BLL_client> SELECTALL(BLL_client bll_client)
        {
            List<BLL_client> returning = new List<BLL_client>();
            try
            {
                con.init();
                string query = "SELECT * FROM client ORDER BY address ASC ";
                command = new MySqlCommand(query, con.connect);
                infos = command.ExecuteReader();

                while (infos.Read())
                {
                    BLL_client alloc = new BLL_client();
                    alloc.id = Convert.ToInt32(infos["id"]);
                    alloc.phone = infos["phone"].ToString();
                    alloc.address = infos["address"].ToString();

                    returning.Add(alloc);
                }
                con.disconnect();
                return returning;
            }
            catch (Exception excep)
            {
                throw new Exception("Erro de comandos!\n" + excep.Message);
            }

        }
    }
}
