namespace GelocarEntregas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmd_clearPurchase = new System.Windows.Forms.Button();
            this.rtb_observation = new System.Windows.Forms.RichTextBox();
            this.rb_doublePayment = new System.Windows.Forms.RadioButton();
            this.cb_rate = new System.Windows.Forms.CheckBox();
            this.lbl_finalvalue = new System.Windows.Forms.Label();
            this.txt_sellerClient = new System.Windows.Forms.TextBox();
            this.lb_sellerProducts = new System.Windows.Forms.ListBox();
            this.rb_card = new System.Windows.Forms.RadioButton();
            this.rb_money = new System.Windows.Forms.RadioButton();
            this.cmd_FinishPurchase = new System.Windows.Forms.Button();
            this.cmd_removeProduct = new System.Windows.Forms.Button();
            this.none = new System.Windows.Forms.GroupBox();
            this.lb_changed = new System.Windows.Forms.ListBox();
            this.rb_product = new System.Windows.Forms.RadioButton();
            this.rb_client = new System.Windows.Forms.RadioButton();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_change = new System.Windows.Forms.TextBox();
            this.Cmd_input = new System.Windows.Forms.Button();
            this.cmd_SelectAlter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_cliente_view = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_product_view = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_order_view = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_order = new System.Windows.Forms.GroupBox();
            this.gb_client = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmd_selectClient = new System.Windows.Forms.Button();
            this.cmd_clientInsert = new System.Windows.Forms.Button();
            this.cmg_updateClient = new System.Windows.Forms.Button();
            this.txt_clientAdress = new System.Windows.Forms.TextBox();
            this.txt_clientePhone = new System.Windows.Forms.TextBox();
            this.lb_ListClient = new System.Windows.Forms.ListBox();
            this.cmd_deleteClient = new System.Windows.Forms.Button();
            this.gb_product = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_productSelect = new System.Windows.Forms.Button();
            this.cmd_productInsert = new System.Windows.Forms.Button();
            this.cmd_producUpdate = new System.Windows.Forms.Button();
            this.txt_productValue = new System.Windows.Forms.TextBox();
            this.lb_Listproduct = new System.Windows.Forms.ListBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.cmd_productDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.none.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gb_order.SuspendLayout();
            this.gb_client.SuspendLayout();
            this.gb_product.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmd_clearPurchase);
            this.groupBox1.Controls.Add(this.rtb_observation);
            this.groupBox1.Controls.Add(this.rb_doublePayment);
            this.groupBox1.Controls.Add(this.cb_rate);
            this.groupBox1.Controls.Add(this.lbl_finalvalue);
            this.groupBox1.Controls.Add(this.txt_sellerClient);
            this.groupBox1.Controls.Add(this.lb_sellerProducts);
            this.groupBox1.Controls.Add(this.rb_card);
            this.groupBox1.Controls.Add(this.rb_money);
            this.groupBox1.Controls.Add(this.cmd_FinishPurchase);
            this.groupBox1.Controls.Add(this.cmd_removeProduct);
            this.groupBox1.Location = new System.Drawing.Point(15, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido";
            // 
            // cmd_clearPurchase
            // 
            this.cmd_clearPurchase.Location = new System.Drawing.Point(487, 248);
            this.cmd_clearPurchase.Name = "cmd_clearPurchase";
            this.cmd_clearPurchase.Size = new System.Drawing.Size(75, 23);
            this.cmd_clearPurchase.TabIndex = 13;
            this.cmd_clearPurchase.Text = "limpar";
            this.cmd_clearPurchase.UseVisualStyleBackColor = true;
            this.cmd_clearPurchase.Click += new System.EventHandler(this.cmd_clearPurchase_Click);
            // 
            // rtb_observation
            // 
            this.rtb_observation.Location = new System.Drawing.Point(71, 175);
            this.rtb_observation.Name = "rtb_observation";
            this.rtb_observation.Size = new System.Drawing.Size(221, 96);
            this.rtb_observation.TabIndex = 15;
            this.rtb_observation.Text = "";
            // 
            // rb_doublePayment
            // 
            this.rb_doublePayment.AutoSize = true;
            this.rb_doublePayment.Location = new System.Drawing.Point(547, 171);
            this.rb_doublePayment.Name = "rb_doublePayment";
            this.rb_doublePayment.Size = new System.Drawing.Size(100, 17);
            this.rb_doublePayment.TabIndex = 3;
            this.rb_doublePayment.Text = "Dinheiro/Cartão";
            this.rb_doublePayment.UseVisualStyleBackColor = true;
            // 
            // cb_rate
            // 
            this.cb_rate.AutoSize = true;
            this.cb_rate.Checked = true;
            this.cb_rate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_rate.Location = new System.Drawing.Point(393, 220);
            this.cb_rate.Name = "cb_rate";
            this.cb_rate.Size = new System.Drawing.Size(121, 17);
            this.cb_rate.TabIndex = 0;
            this.cb_rate.Text = "Cobrar taxa R$ 7,00";
            this.cb_rate.UseVisualStyleBackColor = true;
            this.cb_rate.CheckedChanged += new System.EventHandler(this.cb_rate_CheckedChanged);
            // 
            // lbl_finalvalue
            // 
            this.lbl_finalvalue.AutoSize = true;
            this.lbl_finalvalue.Location = new System.Drawing.Point(471, 127);
            this.lbl_finalvalue.Name = "lbl_finalvalue";
            this.lbl_finalvalue.Size = new System.Drawing.Size(0, 13);
            this.lbl_finalvalue.TabIndex = 14;
            // 
            // txt_sellerClient
            // 
            this.txt_sellerClient.Location = new System.Drawing.Point(35, 42);
            this.txt_sellerClient.Name = "txt_sellerClient";
            this.txt_sellerClient.ReadOnly = true;
            this.txt_sellerClient.Size = new System.Drawing.Size(310, 20);
            this.txt_sellerClient.TabIndex = 13;
            // 
            // lb_sellerProducts
            // 
            this.lb_sellerProducts.FormattingEnabled = true;
            this.lb_sellerProducts.Location = new System.Drawing.Point(35, 85);
            this.lb_sellerProducts.Name = "lb_sellerProducts";
            this.lb_sellerProducts.Size = new System.Drawing.Size(310, 69);
            this.lb_sellerProducts.TabIndex = 13;
            // 
            // rb_card
            // 
            this.rb_card.AutoSize = true;
            this.rb_card.Checked = true;
            this.rb_card.Location = new System.Drawing.Point(485, 171);
            this.rb_card.Name = "rb_card";
            this.rb_card.Size = new System.Drawing.Size(56, 17);
            this.rb_card.TabIndex = 2;
            this.rb_card.TabStop = true;
            this.rb_card.Text = "Cartão";
            this.rb_card.UseVisualStyleBackColor = true;
            // 
            // rb_money
            // 
            this.rb_money.AutoSize = true;
            this.rb_money.Location = new System.Drawing.Point(422, 171);
            this.rb_money.Name = "rb_money";
            this.rb_money.Size = new System.Drawing.Size(64, 17);
            this.rb_money.TabIndex = 1;
            this.rb_money.Text = "Dinheiro";
            this.rb_money.UseVisualStyleBackColor = true;
            // 
            // cmd_FinishPurchase
            // 
            this.cmd_FinishPurchase.Location = new System.Drawing.Point(547, 216);
            this.cmd_FinishPurchase.Name = "cmd_FinishPurchase";
            this.cmd_FinishPurchase.Size = new System.Drawing.Size(115, 23);
            this.cmd_FinishPurchase.TabIndex = 4;
            this.cmd_FinishPurchase.Text = "Encerrar pedido";
            this.cmd_FinishPurchase.UseVisualStyleBackColor = true;
            this.cmd_FinishPurchase.Click += new System.EventHandler(this.cmd_FinishPurchase_Click);
            // 
            // cmd_removeProduct
            // 
            this.cmd_removeProduct.Location = new System.Drawing.Point(428, 82);
            this.cmd_removeProduct.Name = "cmd_removeProduct";
            this.cmd_removeProduct.Size = new System.Drawing.Size(134, 23);
            this.cmd_removeProduct.TabIndex = 6;
            this.cmd_removeProduct.Text = "Remover Produto";
            this.cmd_removeProduct.UseVisualStyleBackColor = true;
            this.cmd_removeProduct.Click += new System.EventHandler(this.cmd_removeProduct_Click);
            // 
            // none
            // 
            this.none.Controls.Add(this.lb_changed);
            this.none.Controls.Add(this.rb_product);
            this.none.Controls.Add(this.rb_client);
            this.none.Controls.Add(this.txt_amount);
            this.none.Controls.Add(this.txt_change);
            this.none.Controls.Add(this.Cmd_input);
            this.none.Controls.Add(this.cmd_SelectAlter);
            this.none.Location = new System.Drawing.Point(22, 19);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(708, 195);
            this.none.TabIndex = 1;
            this.none.TabStop = false;
            // 
            // lb_changed
            // 
            this.lb_changed.FormattingEnabled = true;
            this.lb_changed.Location = new System.Drawing.Point(28, 66);
            this.lb_changed.Name = "lb_changed";
            this.lb_changed.Size = new System.Drawing.Size(310, 108);
            this.lb_changed.TabIndex = 12;
            this.lb_changed.DoubleClick += new System.EventHandler(this.lb_changed_DoubleClick);
            // 
            // rb_product
            // 
            this.rb_product.AutoSize = true;
            this.rb_product.Checked = true;
            this.rb_product.Location = new System.Drawing.Point(414, 25);
            this.rb_product.Name = "rb_product";
            this.rb_product.Size = new System.Drawing.Size(62, 17);
            this.rb_product.TabIndex = 3;
            this.rb_product.TabStop = true;
            this.rb_product.Text = "Produto";
            this.rb_product.UseVisualStyleBackColor = true;
            this.rb_product.CheckedChanged += new System.EventHandler(this.rb_product_CheckedChanged);
            // 
            // rb_client
            // 
            this.rb_client.AutoSize = true;
            this.rb_client.Location = new System.Drawing.Point(351, 25);
            this.rb_client.Name = "rb_client";
            this.rb_client.Size = new System.Drawing.Size(57, 17);
            this.rb_client.TabIndex = 2;
            this.rb_client.Text = "Cliente";
            this.rb_client.UseVisualStyleBackColor = true;
            this.rb_client.CheckedChanged += new System.EventHandler(this.rb_client_CheckedChanged);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(467, 93);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(50, 20);
            this.txt_amount.TabIndex = 8;
            this.txt_amount.Text = "1";
            // 
            // txt_change
            // 
            this.txt_change.Location = new System.Drawing.Point(28, 22);
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(221, 20);
            this.txt_change.TabIndex = 0;
            this.txt_change.TextChanged += new System.EventHandler(this.txt_change_TextChanged);
            this.txt_change.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_change_KeyPress);
            // 
            // Cmd_input
            // 
            this.Cmd_input.Location = new System.Drawing.Point(421, 137);
            this.Cmd_input.Name = "Cmd_input";
            this.Cmd_input.Size = new System.Drawing.Size(134, 23);
            this.Cmd_input.TabIndex = 4;
            this.Cmd_input.Text = "Adicionar ao pedido";
            this.Cmd_input.UseVisualStyleBackColor = true;
            this.Cmd_input.Click += new System.EventHandler(this.Cmd_input_Click);
            // 
            // cmd_SelectAlter
            // 
            this.cmd_SelectAlter.Location = new System.Drawing.Point(263, 22);
            this.cmd_SelectAlter.Name = "cmd_SelectAlter";
            this.cmd_SelectAlter.Size = new System.Drawing.Size(75, 23);
            this.cmd_SelectAlter.TabIndex = 1;
            this.cmd_SelectAlter.Text = "buscar";
            this.cmd_SelectAlter.UseVisualStyleBackColor = true;
            this.cmd_SelectAlter.Click += new System.EventHandler(this.cmd_SelectAlter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cmd_order_view});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmd_cliente_view,
            this.cmd_product_view});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 20);
            this.toolStripMenuItem1.Text = "Gerenciamento";
            // 
            // cmd_cliente_view
            // 
            this.cmd_cliente_view.Name = "cmd_cliente_view";
            this.cmd_cliente_view.Size = new System.Drawing.Size(122, 22);
            this.cmd_cliente_view.Text = "Clientes";
            this.cmd_cliente_view.Click += new System.EventHandler(this.cmd_cliente_view_Click);
            // 
            // cmd_product_view
            // 
            this.cmd_product_view.Name = "cmd_product_view";
            this.cmd_product_view.Size = new System.Drawing.Size(122, 22);
            this.cmd_product_view.Text = "Produtos";
            this.cmd_product_view.Click += new System.EventHandler(this.cmd_product_view_Click);
            // 
            // cmd_order_view
            // 
            this.cmd_order_view.Name = "cmd_order_view";
            this.cmd_order_view.Size = new System.Drawing.Size(61, 20);
            this.cmd_order_view.Text = "Pedidos";
            this.cmd_order_view.Click += new System.EventHandler(this.cmd_order_view_Click);
            // 
            // gb_order
            // 
            this.gb_order.Controls.Add(this.none);
            this.gb_order.Controls.Add(this.groupBox1);
            this.gb_order.Location = new System.Drawing.Point(0, 65);
            this.gb_order.Name = "gb_order";
            this.gb_order.Size = new System.Drawing.Size(760, 523);
            this.gb_order.TabIndex = 10;
            this.gb_order.TabStop = false;
            this.gb_order.Text = "Pedidos";
            // 
            // gb_client
            // 
            this.gb_client.Controls.Add(this.label6);
            this.gb_client.Controls.Add(this.label7);
            this.gb_client.Controls.Add(this.cmd_selectClient);
            this.gb_client.Controls.Add(this.cmd_clientInsert);
            this.gb_client.Controls.Add(this.cmg_updateClient);
            this.gb_client.Controls.Add(this.txt_clientAdress);
            this.gb_client.Controls.Add(this.txt_clientePhone);
            this.gb_client.Controls.Add(this.lb_ListClient);
            this.gb_client.Controls.Add(this.cmd_deleteClient);
            this.gb_client.Location = new System.Drawing.Point(21, 46);
            this.gb_client.Name = "gb_client";
            this.gb_client.Size = new System.Drawing.Size(760, 488);
            this.gb_client.TabIndex = 2;
            this.gb_client.TabStop = false;
            this.gb_client.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Telefone";
            // 
            // cmd_selectClient
            // 
            this.cmd_selectClient.Location = new System.Drawing.Point(351, 87);
            this.cmd_selectClient.Name = "cmd_selectClient";
            this.cmd_selectClient.Size = new System.Drawing.Size(126, 23);
            this.cmd_selectClient.TabIndex = 2;
            this.cmd_selectClient.Text = "Buscar";
            this.cmd_selectClient.UseVisualStyleBackColor = true;
            this.cmd_selectClient.Click += new System.EventHandler(this.cmd_selectClient_Click);
            // 
            // cmd_clientInsert
            // 
            this.cmd_clientInsert.Location = new System.Drawing.Point(97, 397);
            this.cmd_clientInsert.Name = "cmd_clientInsert";
            this.cmd_clientInsert.Size = new System.Drawing.Size(75, 23);
            this.cmd_clientInsert.TabIndex = 5;
            this.cmd_clientInsert.Text = "Adicionar";
            this.cmd_clientInsert.UseVisualStyleBackColor = true;
            this.cmd_clientInsert.Click += new System.EventHandler(this.cmd_clientInsert_Click);
            // 
            // cmg_updateClient
            // 
            this.cmg_updateClient.Location = new System.Drawing.Point(198, 397);
            this.cmg_updateClient.Name = "cmg_updateClient";
            this.cmg_updateClient.Size = new System.Drawing.Size(75, 23);
            this.cmg_updateClient.TabIndex = 6;
            this.cmg_updateClient.Text = "Alterar";
            this.cmg_updateClient.UseVisualStyleBackColor = true;
            this.cmg_updateClient.Click += new System.EventHandler(this.cmg_updateClient_Click);
            // 
            // txt_clientAdress
            // 
            this.txt_clientAdress.Location = new System.Drawing.Point(68, 86);
            this.txt_clientAdress.Name = "txt_clientAdress";
            this.txt_clientAdress.Size = new System.Drawing.Size(230, 20);
            this.txt_clientAdress.TabIndex = 4;
            this.txt_clientAdress.TextChanged += new System.EventHandler(this.txt_clientAdress_TextChanged);
            // 
            // txt_clientePhone
            // 
            this.txt_clientePhone.Location = new System.Drawing.Point(68, 321);
            this.txt_clientePhone.Name = "txt_clientePhone";
            this.txt_clientePhone.Size = new System.Drawing.Size(230, 20);
            this.txt_clientePhone.TabIndex = 3;
            // 
            // lb_ListClient
            // 
            this.lb_ListClient.FormattingEnabled = true;
            this.lb_ListClient.Location = new System.Drawing.Point(351, 131);
            this.lb_ListClient.Name = "lb_ListClient";
            this.lb_ListClient.Size = new System.Drawing.Size(345, 225);
            this.lb_ListClient.TabIndex = 15;
            this.lb_ListClient.Click += new System.EventHandler(this.lb_ListClient_Click);
            // 
            // cmd_deleteClient
            // 
            this.cmd_deleteClient.Location = new System.Drawing.Point(496, 397);
            this.cmd_deleteClient.Name = "cmd_deleteClient";
            this.cmd_deleteClient.Size = new System.Drawing.Size(75, 23);
            this.cmd_deleteClient.TabIndex = 7;
            this.cmd_deleteClient.Text = "Excluir";
            this.cmd_deleteClient.UseVisualStyleBackColor = true;
            this.cmd_deleteClient.Click += new System.EventHandler(this.cmd_deleteClient_Click);
            // 
            // gb_product
            // 
            this.gb_product.Controls.Add(this.label3);
            this.gb_product.Controls.Add(this.label1);
            this.gb_product.Controls.Add(this.cmd_productSelect);
            this.gb_product.Controls.Add(this.cmd_productInsert);
            this.gb_product.Controls.Add(this.cmd_producUpdate);
            this.gb_product.Controls.Add(this.txt_productValue);
            this.gb_product.Controls.Add(this.lb_Listproduct);
            this.gb_product.Controls.Add(this.txt_productName);
            this.gb_product.Controls.Add(this.cmd_productDelete);
            this.gb_product.Location = new System.Drawing.Point(92, 27);
            this.gb_product.Name = "gb_product";
            this.gb_product.Size = new System.Drawing.Size(760, 523);
            this.gb_product.TabIndex = 12;
            this.gb_product.TabStop = false;
            this.gb_product.Text = "Produtos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor da Unidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // cmd_productSelect
            // 
            this.cmd_productSelect.Location = new System.Drawing.Point(351, 94);
            this.cmd_productSelect.Name = "cmd_productSelect";
            this.cmd_productSelect.Size = new System.Drawing.Size(126, 23);
            this.cmd_productSelect.TabIndex = 1;
            this.cmd_productSelect.Text = "Buscar";
            this.cmd_productSelect.UseVisualStyleBackColor = true;
            this.cmd_productSelect.Click += new System.EventHandler(this.cmd_productSelect_Click);
            // 
            // cmd_productInsert
            // 
            this.cmd_productInsert.Location = new System.Drawing.Point(104, 404);
            this.cmd_productInsert.Name = "cmd_productInsert";
            this.cmd_productInsert.Size = new System.Drawing.Size(75, 23);
            this.cmd_productInsert.TabIndex = 4;
            this.cmd_productInsert.Text = "Adicionar";
            this.cmd_productInsert.UseVisualStyleBackColor = true;
            this.cmd_productInsert.Click += new System.EventHandler(this.cmd_productInsert_Click);
            // 
            // cmd_producUpdate
            // 
            this.cmd_producUpdate.Location = new System.Drawing.Point(193, 404);
            this.cmd_producUpdate.Name = "cmd_producUpdate";
            this.cmd_producUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmd_producUpdate.TabIndex = 5;
            this.cmd_producUpdate.Text = "Alterar";
            this.cmd_producUpdate.UseVisualStyleBackColor = true;
            this.cmd_producUpdate.Click += new System.EventHandler(this.cmd_producUpdate_Click);
            // 
            // txt_productValue
            // 
            this.txt_productValue.Location = new System.Drawing.Point(76, 343);
            this.txt_productValue.Name = "txt_productValue";
            this.txt_productValue.Size = new System.Drawing.Size(230, 20);
            this.txt_productValue.TabIndex = 3;
            // 
            // lb_Listproduct
            // 
            this.lb_Listproduct.FormattingEnabled = true;
            this.lb_Listproduct.Location = new System.Drawing.Point(351, 138);
            this.lb_Listproduct.Name = "lb_Listproduct";
            this.lb_Listproduct.Size = new System.Drawing.Size(345, 225);
            this.lb_Listproduct.TabIndex = 7;
            this.lb_Listproduct.Click += new System.EventHandler(this.lb_Listproduct_Click);
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(76, 97);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(230, 20);
            this.txt_productName.TabIndex = 0;
            this.txt_productName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productName_KeyPress);
            // 
            // cmd_productDelete
            // 
            this.cmd_productDelete.Location = new System.Drawing.Point(456, 400);
            this.cmd_productDelete.Name = "cmd_productDelete";
            this.cmd_productDelete.Size = new System.Drawing.Size(75, 23);
            this.cmd_productDelete.TabIndex = 6;
            this.cmd_productDelete.Text = "Excluir";
            this.cmd_productDelete.UseVisualStyleBackColor = true;
            this.cmd_productDelete.Click += new System.EventHandler(this.cmd_productDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gb_client);
            this.Controls.Add(this.gb_order);
            this.Controls.Add(this.gb_product);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.none.ResumeLayout(false);
            this.none.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_order.ResumeLayout(false);
            this.gb_client.ResumeLayout(false);
            this.gb_client.PerformLayout();
            this.gb_product.ResumeLayout(false);
            this.gb_product.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmd_FinishPurchase;
        private System.Windows.Forms.Button cmd_removeProduct;
        private System.Windows.Forms.GroupBox none;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_change;
        private System.Windows.Forms.Button Cmd_input;
        private System.Windows.Forms.Button cmd_SelectAlter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmd_cliente_view;
        private System.Windows.Forms.ToolStripMenuItem cmd_product_view;
        private System.Windows.Forms.ToolStripMenuItem cmd_order_view;
        private System.Windows.Forms.GroupBox gb_order;
        private System.Windows.Forms.GroupBox gb_client;
        private System.Windows.Forms.GroupBox gb_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_productSelect;
        private System.Windows.Forms.Button cmd_productInsert;
        private System.Windows.Forms.Button cmd_producUpdate;
        private System.Windows.Forms.TextBox txt_productValue;
        private System.Windows.Forms.ListBox lb_Listproduct;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Button cmd_productDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmd_selectClient;
        private System.Windows.Forms.Button cmd_clientInsert;
        private System.Windows.Forms.Button cmg_updateClient;
        private System.Windows.Forms.TextBox txt_clientAdress;
        private System.Windows.Forms.TextBox txt_clientePhone;
        private System.Windows.Forms.ListBox lb_ListClient;
        private System.Windows.Forms.Button cmd_deleteClient;
        private System.Windows.Forms.RadioButton rb_product;
        private System.Windows.Forms.RadioButton rb_client;
        private System.Windows.Forms.RadioButton rb_card;
        private System.Windows.Forms.RadioButton rb_money;
        private System.Windows.Forms.TextBox txt_sellerClient;
        private System.Windows.Forms.ListBox lb_sellerProducts;
        private System.Windows.Forms.ListBox lb_changed;
        private System.Windows.Forms.Label lbl_finalvalue;
        private System.Windows.Forms.CheckBox cb_rate;
        private System.Windows.Forms.RadioButton rb_doublePayment;
        private System.Windows.Forms.RichTextBox rtb_observation;
        private System.Windows.Forms.Button cmd_clearPurchase;
    }
}

