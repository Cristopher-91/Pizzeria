namespace Pizzeria
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
            this.CBPizzas = new System.Windows.Forms.ComboBox();
            this.bPrice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtons = new System.Windows.Forms.Panel();
            this.rLarge = new System.Windows.Forms.RadioButton();
            this.rMedium = new System.Windows.Forms.RadioButton();
            this.rSmall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lFinalPrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lOrderType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bOrder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lMessage = new System.Windows.Forms.Label();
            this.dataGridDB = new System.Windows.Forms.DataGridView();
            this.bDBContent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.RadioButtons.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).BeginInit();
            this.SuspendLayout();
            // 
            // CBPizzas
            // 
            this.CBPizzas.BackColor = System.Drawing.Color.White;
            this.CBPizzas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPizzas.Location = new System.Drawing.Point(6, 44);
            this.CBPizzas.Name = "CBPizzas";
            this.CBPizzas.Size = new System.Drawing.Size(121, 21);
            this.CBPizzas.TabIndex = 1;
            // 
            // bPrice
            // 
            this.bPrice.Location = new System.Drawing.Point(6, 177);
            this.bPrice.Name = "bPrice";
            this.bPrice.Size = new System.Drawing.Size(75, 23);
            this.bPrice.TabIndex = 2;
            this.bPrice.Text = "Show Price";
            this.bPrice.UseVisualStyleBackColor = true;
            this.bPrice.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtons);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBPizzas);
            this.groupBox1.Controls.Add(this.bPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 217);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select ";
            // 
            // RadioButtons
            // 
            this.RadioButtons.Controls.Add(this.rLarge);
            this.RadioButtons.Controls.Add(this.rMedium);
            this.RadioButtons.Controls.Add(this.rSmall);
            this.RadioButtons.Location = new System.Drawing.Point(6, 98);
            this.RadioButtons.Name = "RadioButtons";
            this.RadioButtons.Size = new System.Drawing.Size(103, 77);
            this.RadioButtons.TabIndex = 5;
            // 
            // rLarge
            // 
            this.rLarge.AutoSize = true;
            this.rLarge.Location = new System.Drawing.Point(3, 49);
            this.rLarge.Name = "rLarge";
            this.rLarge.Size = new System.Drawing.Size(87, 17);
            this.rLarge.TabIndex = 7;
            this.rLarge.TabStop = true;
            this.rLarge.Text = "Large (50cm)";
            this.rLarge.UseVisualStyleBackColor = true;
            // 
            // rMedium
            // 
            this.rMedium.AutoSize = true;
            this.rMedium.Location = new System.Drawing.Point(3, 26);
            this.rMedium.Name = "rMedium";
            this.rMedium.Size = new System.Drawing.Size(97, 17);
            this.rMedium.TabIndex = 6;
            this.rMedium.TabStop = true;
            this.rMedium.Text = "Medium (42cm)";
            this.rMedium.UseVisualStyleBackColor = true;
            // 
            // rSmall
            // 
            this.rSmall.AutoSize = true;
            this.rSmall.Location = new System.Drawing.Point(3, 3);
            this.rSmall.Name = "rSmall";
            this.rSmall.Size = new System.Drawing.Size(85, 17);
            this.rSmall.TabIndex = 5;
            this.rSmall.TabStop = true;
            this.rSmall.Text = "Small (32cm)";
            this.rSmall.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(18, 266);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(0, 13);
            this.lPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cost of order:";
            // 
            // lFinalPrice
            // 
            this.lFinalPrice.AutoSize = true;
            this.lFinalPrice.Location = new System.Drawing.Point(82, 67);
            this.lFinalPrice.Name = "lFinalPrice";
            this.lFinalPrice.Size = new System.Drawing.Size(0, 13);
            this.lFinalPrice.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lOrderType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lFinalPrice);
            this.groupBox2.Location = new System.Drawing.Point(190, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 99);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // lOrderType
            // 
            this.lOrderType.AutoSize = true;
            this.lOrderType.Location = new System.Drawing.Point(6, 42);
            this.lOrderType.Name = "lOrderType";
            this.lOrderType.Size = new System.Drawing.Size(0, 13);
            this.lOrderType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbInfo);
            this.groupBox3.Controls.Add(this.tbAdress);
            this.groupBox3.Controls.Add(this.tbPhone);
            this.groupBox3.Controls.Add(this.tbName);
            this.groupBox3.Controls.Add(this.bOrder);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(190, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 199);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order data";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(12, 122);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(182, 38);
            this.tbInfo.TabIndex = 8;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(95, 71);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(99, 20);
            this.tbAdress.TabIndex = 7;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(53, 45);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(141, 20);
            this.tbPhone.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(53, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(141, 20);
            this.tbName.TabIndex = 5;
            // 
            // bOrder
            // 
            this.bOrder.Location = new System.Drawing.Point(12, 167);
            this.bOrder.Name = "bOrder";
            this.bOrder.Size = new System.Drawing.Size(95, 23);
            this.bOrder.TabIndex = 4;
            this.bOrder.Text = "Order!";
            this.bOrder.UseVisualStyleBackColor = true;
            this.bOrder.Click += new System.EventHandler(this.bOrder_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Additional info:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Delivery adress:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mobile:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Location = new System.Drawing.Point(190, 356);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(0, 13);
            this.lMessage.TabIndex = 10;
            // 
            // dataGridDB
            // 
            this.dataGridDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridDB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDB.Location = new System.Drawing.Point(405, 40);
            this.dataGridDB.Name = "dataGridDB";
            this.dataGridDB.Size = new System.Drawing.Size(344, 161);
            this.dataGridDB.TabIndex = 11;
            // 
            // bDBContent
            // 
            this.bDBContent.Location = new System.Drawing.Point(405, 217);
            this.bDBContent.Name = "bDBContent";
            this.bDBContent.Size = new System.Drawing.Size(135, 24);
            this.bDBContent.TabIndex = 12;
            this.bDBContent.Text = "Show all orders";
            this.bDBContent.UseVisualStyleBackColor = true;
            this.bDBContent.Click += new System.EventHandler(this.bDBContent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 378);
            this.Controls.Add(this.bDBContent);
            this.Controls.Add(this.dataGridDB);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Pizzeria Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RadioButtons.ResumeLayout(false);
            this.RadioButtons.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBPizzas;
        private System.Windows.Forms.Button bPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rLarge;
        private System.Windows.Forms.RadioButton rMedium;
        private System.Windows.Forms.RadioButton rSmall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel RadioButtons;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lFinalPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lOrderType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button bOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.DataGridView dataGridDB;
        private System.Windows.Forms.Button bDBContent;
    }
}

