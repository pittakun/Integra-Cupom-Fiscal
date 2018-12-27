using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrinterUtility;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;
using System.Threading;
namespace GelocarEntregas
{

    public partial class Form1 : Form
    {
        Ux_control control;
        BLL_client bll_client;
        BLL_product bll_product;

        List<BLL_client> L_bllClient;
        List<BLL_product> L_bllProduct;

        List<BLL_product> sellerlist;

        connection con;

        BLL_client sellerClient;

        verify verification;

        MySqlDataReader infos;
        private MySqlCommand command;
        int count_purchase, count_voucher;

        public Form1()
        {
            InitializeComponent();
            control = new Ux_control(gb_order, gb_client, gb_product);
            bll_client = new BLL_client();
            bll_product = new BLL_product();

            L_bllProduct = new List<BLL_product>();
            L_bllClient = new List<BLL_client>();

            sellerlist = new List<BLL_product>();
            sellerClient = new BLL_client();
            verification = new verify();

            count_voucher = 1;

            
            count_purchase = 1;
            con = new connection();


            try
            {
                con.init();
                string query = "SELECT `number` FROM `count` WHERE id like " + 1;
                command = new MySqlCommand(query, con.connect);
                infos = command.ExecuteReader();

                while (infos.Read())
                {
                    count_purchase = Convert.ToInt32(infos["number"]);
                }
                con.disconnect();
                
            }
            catch (Exception excep)
            {
                throw new Exception("Erro de comandos!\n" + excep.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }


        //-------------menu
        private void cmd_cliente_view_Click(object sender, EventArgs e)
        {
            control.View(1);
            lb_changed.Items.Clear();
        }

        private void cmd_order_view_Click(object sender, EventArgs e)
        {
            control.View(0);
            clearproduct();
            lb_ListClient.Items.Clear();
        }

        private void cmd_product_view_Click(object sender, EventArgs e)
        {
            clearproduct();
            control.View(2);
        }

        //colocar na lista
        private void lb_Listproduct_Click(object sender, EventArgs e)
        {
            if (lb_Listproduct.SelectedIndex != -1)
            {
                bll_product.id = L_bllProduct[lb_Listproduct.SelectedIndex].id;
                bll_product.name = txt_productName.Text = L_bllProduct[lb_Listproduct.SelectedIndex].name;
                bll_product.value = txt_productValue.Text = L_bllProduct[lb_Listproduct.SelectedIndex].value;
            }
        }

        private void lb_ListClient_Click(object sender, EventArgs e)
        {
            if (lb_ListClient.SelectedIndex != -1)
            {
                bll_client.id = L_bllClient[lb_ListClient.SelectedIndex].id;
                bll_client.phone = txt_clientePhone.Text = L_bllClient[lb_ListClient.SelectedIndex].phone.ToLower();
                bll_client.address = txt_clientAdress.Text = L_bllClient[lb_ListClient.SelectedIndex].address.ToLower();
            }
        }

        //cliente

        private void cmd_clientInsert_Click(object sender, EventArgs e)
        {
           
            bll_client.phone = txt_clientePhone.Text.ToLower();
            bll_client.address = txt_clientAdress.Text.ToLower();

            if (verification.Txt(bll_client.phone, "Telefone", 15) != "")
            {
                MessageBox.Show(verification.Txt(bll_client.phone, "Endenreço", 15));
            } else if (verification.Txt(bll_client.address, "Endereço", 150) != "")
            {
                MessageBox.Show(verification.Txt(bll_client.address, "Endenreço", 150));
            } else
            {
                verification.trade_CommaToHyphen(bll_client.address);
                MessageBox.Show(bll_client.INSERT());
            }


        }

        private void cmd_selectClient_Click(object sender, EventArgs e)
        {
            bll_client.address = txt_clientAdress.Text;
            L_bllClient = bll_client.SELECT();

            lb_ListClient.Items.Clear();
            for (int i = 0; i < L_bllClient.Count; i++)
            {
                lb_ListClient.Items.Add("  ENDEREÇO: " + L_bllClient[i].address);
            }
        }
        private void txt_clientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                L_bllClient = bll_client.SELECT();

                lb_ListClient.Items.Clear();
                for (int i = 0; i < L_bllClient.Count; i++)
                {
                    lb_ListClient.Items.Add("ENDEREÇO: " + L_bllClient[i].address);
                }
            }
        }

        private void cmg_updateClient_Click(object sender, EventArgs e)
        {
            bll_client.phone = txt_clientePhone.Text.ToLower();
            bll_client.address = txt_clientAdress.Text.ToLower();

            if (verification.Txt(bll_client.phone, "Telefone", 15) != "")
            {
                MessageBox.Show(verification.Txt(bll_client.phone, "Endenreço", 15));
            }
            else if (verification.Txt(bll_client.address, "Endereço", 150) != "")
            {
                MessageBox.Show(verification.Txt(bll_client.address, "Endenreço", 150));
            }
            else
            {
                verification.trade_CommaToHyphen(bll_client.address);
                MessageBox.Show(bll_client.UPDATE());
            }
            
            L_bllClient = bll_client.SELECT();

            lb_ListClient.Items.Clear();
            for (int i = 0; i < L_bllClient.Count; i++)
            {
                lb_ListClient.Items.Add("ENDEREÇO: " + L_bllClient[i].address);
            }

        }

        private void cmd_deleteClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bll_client.DELETE());
        }

        //produto
        void clearproduct()
        {
            txt_productName.Text = "";
            txt_productValue.Text = "";
            lb_Listproduct.Items.Clear();
            lb_changed.Items.Clear();
        }

        private void cmd_productInsert_Click(object sender, EventArgs e)
        {
            bll_product.name = txt_productName.Text.ToLower();
            bll_product.value = txt_productValue.Text.ToLower();

            if (verification.Txt(bll_product.name, "Nome", 100) != "")
            {
                MessageBox.Show(verification.Txt(bll_product.name, "Nome", 150));
            }
            else if (verification.number(bll_product.value, "Valor") != "")
            {
                MessageBox.Show(verification.number(bll_product.value, "Valor"));
            }
            else
            {
                verification.trade_CommaToHyphen(bll_product.name);
                verification.trade_CommaToEnd(bll_product.value);
                MessageBox.Show(bll_product.INSERT());
            }
            clearproduct();

        }

        private void cmd_productSelect_Click(object sender, EventArgs e)
        {
            L_bllProduct.Clear();
            bll_product.name = txt_productName.Text.ToLower();
            L_bllProduct = bll_product.SELECT();

            lb_Listproduct.Items.Clear();
            for (int i = 0; i < L_bllProduct.Count; i++)
            {
                lb_Listproduct.Items.Add(L_bllProduct[i].name + " R$ " + L_bllProduct[i].value);
            }
        }

        private void txt_productName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                L_bllProduct.Clear();
                bll_product.name = txt_productName.Text.ToLower();
                L_bllProduct = bll_product.SELECT();

                lb_Listproduct.Items.Clear();
                for (int i = 0; i < L_bllProduct.Count; i++)
                {
                    lb_Listproduct.Items.Add(L_bllProduct[i].name + " R$ " + L_bllProduct[i].value);
                }

            }
        }

        private void cmd_producUpdate_Click(object sender, EventArgs e)
        {
            bll_product.name = txt_productName.Text.ToLower();
            bll_product.value = txt_productValue.Text.ToLower();

            if (verification.Txt(bll_product.name, "Nome", 100) != "")
            {
                MessageBox.Show(verification.Txt(bll_product.name, "Nome", 150));
            }
            else if (verification.number(bll_product.value, "Valor") != "")
            {
                MessageBox.Show(verification.number(bll_product.value, "Valor"));
            }
            else
            {
                verification.trade_CommaToHyphen(bll_product.name);
                verification.trade_CommaToEnd(bll_product.value);
                MessageBox.Show(Text = bll_product.UPDATE());
            }

        }

        private void cmd_productDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bll_product.DELETE());
        }


        //seller

        private void cmd_SelectAlter_Click(object sender, EventArgs e)
        {
            lb_changed.Items.Clear();
            L_bllClient.Clear();
            L_bllProduct.Clear();

            if (rb_product.Checked == true)
            {
                bll_product.name = txt_change.Text;
                L_bllProduct = bll_product.SELECT();


                for (int i = 0; i < L_bllProduct.Count; i++)
                {
                    lb_changed.Items.Add(L_bllProduct[i].name + "  " + L_bllProduct[i].value);
                }
                lbl_finalvalue.Text = finalvalue();
            }
            else if (rb_client.Checked == true)
            {
                bll_client.address = txt_change.Text;
                L_bllClient = bll_client.SELECT();

                for (int i = 0; i < L_bllClient.Count; i++)
                {
                    lb_changed.Items.Add(L_bllClient[i].address);
                }

            }
        }

        private void lb_changed_DoubleClick(object sender, EventArgs e)
        {
            BLL_product selleraux = new BLL_product();
            double pvalue, pamount;

            if (rb_product.Checked == true)
            {
                if (lb_changed.SelectedIndex != -1)
                {

                    selleraux = L_bllProduct[lb_changed.SelectedIndex];
                    pvalue = Convert.ToDouble(selleraux.value);
                    pamount = Convert.ToDouble(txt_amount.Text);
                    double sum = pvalue * pamount;
                    string nname = selleraux.name;
                    selleraux.name = pamount + "x " + nname;
                    selleraux.value = string.Format("{0:n2}", sum);
                    sellerlist.Add(selleraux);
                    lb_changed.Items.Clear();

                    lb_sellerProducts.Items.Add(selleraux.name + "   " + selleraux.value);
                    lbl_finalvalue.Text = finalvalue();
                }
                else
                {
                    MessageBox.Show("Nenhum produto selecionado");
                }
            }
            else if (rb_client.Checked == true)
            {
                if (lb_changed.SelectedIndex != -1)
                {
                    sellerClient = L_bllClient[lb_changed.SelectedIndex];
                    txt_sellerClient.Text = " \n  " + sellerClient.phone + "   " + sellerClient.address;

                }
                else
                {
                    MessageBox.Show("Nenhum Cliente Selecionado");
                }
            }
            txt_amount.Text = "1";
        }

        private void txt_change_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lb_changed.Items.Clear();
                L_bllClient.Clear();
                L_bllProduct.Clear();

                if (rb_product.Checked == true)
                {
                    bll_product.name = txt_change.Text;
                    L_bllProduct = bll_product.SELECT();


                    for (int i = 0; i < L_bllProduct.Count; i++)
                    {
                        lb_changed.Items.Add(L_bllProduct[i].name + "  " + L_bllProduct[i].value);
                    }
                    lbl_finalvalue.Text = finalvalue();
                }
                else if (rb_client.Checked == true)
                {
                    L_bllClient = bll_client.SELECT();

                    for (int i = 0; i < L_bllClient.Count; i++)
                    {
                        lb_changed.Items.Add(L_bllClient[i].address);
                    }

                }
            }
        }

        private void Cmd_input_Click(object sender, EventArgs e)
        {
            BLL_product selleraux = new BLL_product();

            if (rb_product.Checked == true)
            {
                if (lb_changed.SelectedIndex != -1)
                {

                    selleraux = L_bllProduct[lb_changed.SelectedIndex];
                    double var = Convert.ToDouble(selleraux.value) * Convert.ToDouble(txt_amount.Text);
                    selleraux.name = txt_amount.Text + "x " + selleraux.name;
                    selleraux.value = string.Format("{0:n2}", var);
                    sellerlist.Add(selleraux);
                    lb_changed.Items.Clear();

                    lb_sellerProducts.Items.Add(selleraux.name + "   " + string.Format("{0:n2}", selleraux.value));
                    lbl_finalvalue.Text = finalvalue();
                }
                else
                {
                    MessageBox.Show("Nenhum produto selecionado");
                }
            }
            else if (rb_client.Checked == true)
            {
                if (lb_changed.SelectedIndex != -1)
                {
                    sellerClient = L_bllClient[lb_changed.SelectedIndex];
                    txt_sellerClient.Text = sellerClient.phone + "   " + sellerClient.address;

                }
                else
                {
                    MessageBox.Show("Nenhum Cliente Selecionado");
                }
            }
            txt_amount.Text = "1";
        }

        private void cmd_removeProduct_Click(object sender, EventArgs e)
        {
            if (lb_sellerProducts.SelectedIndex != -1)
            {
                sellerlist.RemoveAt(lb_sellerProducts.SelectedIndex);
                lb_sellerProducts.Items.Remove(lb_sellerProducts.SelectedItem);
                lbl_finalvalue.Text = finalvalue();
            } else
            {
                MessageBox.Show("Nenhum produto Selecionado.");
            }
        }

        private void cmd_FinishPurchase_Click(object sender, EventArgs e)
        {
            if ((txt_sellerClient.Text != "") && (lb_sellerProducts.Items.Count != 0))
            {
                
                string print; 
                print = "Gelocar\n";
                print += "Nº: " + count_purchase + "\n";


                if (count_voucher == 1)
                {
                    count_voucher++;
                }else
                {
                    count_voucher = 1;
                    count_purchase++;
                    try
                    {
                        con.init();
                        string query = "UPDATE count SET number = " + count_purchase + " WHERE id = " + 1;
                        command = new MySqlCommand(query, con.connect);
                        infos = command.ExecuteReader();
                        con.disconnect();
                        
                    }
                    catch (Exception excep)
                    {
                        throw new Exception("Erro de comandos!\n" + excep.Message);
                    }
                }

                DateTime date = DateTime.Now;

                print += date.Day + "/" + date.Month + "/" + date.Year + " - " + date.Hour + ":" + date.Minute + ":" + date.Second; 
                print += "\nTelefone: " + sellerClient.phone + "\n"; 
                print += "Endereço: " + sellerClient.address + "\n"; 
                print += "\nProdutos\n"; 

                for (int i = 0; i < sellerlist.Count; i++)
                {
                    print += sellerlist[i].name + "  R$ " + sellerlist[i].value + "\n"; 
                }
                if (cb_rate.Checked)
                {
                    print += "Taxa de entrega R$ 7,00\n"; 

                }
                if (rb_money.Checked)
                    print += "\nPagamento no DINHEIRO"; 

                if (rb_card.Checked)
                    print += "\nPagamento no CARTÃO"; 

                if (rb_doublePayment.Checked)
                    print += "\nPagamento no CARTÃO e Dinheiro";
                print += "\nTOTAL: " + finalvalue();

                print += "\n\nObs:\n" + rtb_observation.Text;

                printin(print);
            }
            else
            {
                MessageBox.Show("Cliente ou Lista de produtos vazio");
            }
        }

        private void rb_product_CheckedChanged(object sender, EventArgs e)
        {
            lb_changed.Items.Clear();
        }

        private void rb_client_CheckedChanged(object sender, EventArgs e)
        {
            lb_changed.Items.Clear();
        }

        string finalvalue()
        {
            double sum = 0;
            int rate = 0;
            for (int i = 0; i < sellerlist.Count; i++)
            {
                sum += Convert.ToDouble(sellerlist[i].value);
            }
            if (cb_rate.Checked)
            {
                rate = 7;
            }
            else
            {
                rate = 0;
            }
            sum += rate;
            return "R$: " + string.Format("{0:n2}", sum);
        }

        private void cb_rate_CheckedChanged(object sender, EventArgs e)
        {

            lbl_finalvalue.Text = finalvalue();
        }


        void clear_purchase()
        {
            txt_change.Text = "";
            lb_changed.Items.Clear();
            txt_sellerClient.Text = "";
            lb_sellerProducts.Items.Clear();
            rtb_observation.Text = "";
            txt_amount.Text = "1";

            sellerlist.Clear();
            lbl_finalvalue.Text = finalvalue();
        }

        private void cmd_clearPurchase_Click(object sender, EventArgs e)
        {
            clear_purchase();
        }

        public static byte[] converttobyteaarrey(string str)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(str);
        }

        private void txt_change_TextChanged(object sender, EventArgs e)
        {
            lb_changed.Items.Clear();
            L_bllClient.Clear();
            L_bllProduct.Clear();

            if (rb_product.Checked == true)
            {
                bll_product.name = txt_change.Text;
                L_bllProduct = bll_product.SELECT();


                for (int i = 0; i < L_bllProduct.Count; i++)
                {
                    lb_changed.Items.Add(L_bllProduct[i].name + "  " + L_bllProduct[i].value);
                }
                lbl_finalvalue.Text = finalvalue();
            }
            else if (rb_client.Checked == true)
            {
                bll_client.address = txt_change.Text;
                L_bllClient = bll_client.SELECT();

                for (int i = 0; i < L_bllClient.Count; i++)
                {
                    lb_changed.Items.Add(L_bllClient[i].address);
                }

            }
        }

        private void txt_clientAdress_TextChanged(object sender, EventArgs e)
        {
            bll_client.address = txt_clientAdress.Text;
            L_bllClient = bll_client.SELECT();

            lb_ListClient.Items.Clear();
            for (int i = 0; i < L_bllClient.Count; i++)
            {
                lb_ListClient.Items.Add("  ENDEREÇO: " + L_bllClient[i].address);
            }
        }

        public void printin(string txt)
        {

            var worldApp = new Microsoft.Office.Interop.Word.Application();
            worldApp.Visible = false;
            var worldDoc = worldApp.Documents.Add(@"C:\Users\Particular\Documents\claudinei\print\pt.docx");


            var paragrafo1 = worldDoc.Content.Paragraphs.Add();
            paragrafo1.Range.Text = txt;
            paragrafo1.Range.InsertParagraphAfter();
            worldDoc.PrintOut();

            Thread.Sleep(2000);
            worldApp.Quit(false);

            


        }
       

    }
}
    