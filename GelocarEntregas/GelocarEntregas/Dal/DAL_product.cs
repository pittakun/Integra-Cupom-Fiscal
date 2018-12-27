using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GelocarEntregas
{
    class DAL_product
    {
        connection con = new connection();
        private MySqlCommand command;
        private MySqlDataReader infos;

        public string INSERT (BLL_product product)
        {
            try
            {
                con.init();
                string query = "INSERT INTO product(name,value)VALUES('" + product.name + "','" + product.value + "')";
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

        public List<BLL_product> SELECT(BLL_product bll_product)
        {
            List<BLL_product> returning = new List<BLL_product>();
            try
            {
                con.init();
                string query = "SELECT * FROM `product` WHERE name like '%" + bll_product.name + "%' ORDER BY name DESC ";
                command = new MySqlCommand(query, con.connect);
                infos = command.ExecuteReader();

                while (infos.Read())
                {
                    BLL_product alloc = new BLL_product();
                    alloc.id = Convert.ToInt32(infos["id"]);
                    alloc.name = infos["name"].ToString();
                    alloc.value = infos["value"].ToString();
                    
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

        public string UPDATE(BLL_product bll_product)
        {
            try
            {
                con.init();
                string query = "UPDATE product SET name ='" + bll_product.name  + "' , value = '" + bll_product.value + "' WHERE id = " + bll_product.id ;
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

        public string DELETE(BLL_product bll_product)
        {
            try
            {
                con.init();
                string query = "DELETE FROM `product` WHERE id = " + bll_product.id;
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

        public List<BLL_product> SELECTALL()
        {
            List<BLL_product> returning = new List<BLL_product>();
            try
            {
                con.init();
                string query = "SELECT * FROM `product` ORDER BY name ASC ";
                command = new MySqlCommand(query, con.connect);
                infos = command.ExecuteReader();

                while (infos.Read())
                {
                    BLL_product alloc = new BLL_product();
                    alloc.id = Convert.ToInt32(infos["id"]);
                    alloc.name = infos["name"].ToString();
                    alloc.value = infos["value"].ToString();
                   
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
