namespace LuckyCoffee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            chStudentDisccount = new CheckBox();
            txtQuantity = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            rbJuice = new RadioButton();
            rbCoffee = new RadioButton();
            rbTea = new RadioButton();
            txtCustomer = new TextBox();
            lblCustomerName = new Label();
            lbl_customer = new Label();
            lblTitle = new Label();
            panel3 = new Panel();
            lblLuckyMessage = new Label();
            lbl_totalPrice = new Label();
            calculateBtn = new Button();
            saveBtn = new Button();
            loadBtn = new Button();
            clearBtn = new Button();
            textBox1 = new TextBox();
            lsResult = new ListBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chStudentDisccount);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txtCustomer);
            panel1.Controls.Add(lblCustomerName);
            panel1.Controls.Add(lbl_customer);
            panel1.Location = new Point(38, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 503);
            panel1.TabIndex = 0;
            // 
            // chStudentDisccount
            // 
            chStudentDisccount.AutoSize = true;
            chStudentDisccount.Font = new Font("Segoe UI", 13F);
            chStudentDisccount.Location = new Point(293, 435);
            chStudentDisccount.Name = "chStudentDisccount";
            chStudentDisccount.Size = new Size(350, 40);
            chStudentDisccount.TabIndex = 6;
            chStudentDisccount.Text = "Student Member (10% Off)";
            chStudentDisccount.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 13F);
            txtQuantity.Location = new Point(154, 436);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(88, 42);
            txtQuantity.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(25, 445);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 4;
            label4.Text = "Quanitity:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbJuice);
            groupBox1.Controls.Add(rbCoffee);
            groupBox1.Controls.Add(rbTea);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(36, 221);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 193);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Drink Type";
            // 
            // rbJuice
            // 
            rbJuice.AutoSize = true;
            rbJuice.Font = new Font("Segoe UI", 12F);
            rbJuice.ForeColor = SystemColors.InfoText;
            rbJuice.Location = new Point(23, 142);
            rbJuice.Name = "rbJuice";
            rbJuice.Size = new Size(139, 36);
            rbJuice.TabIndex = 2;
            rbJuice.TabStop = true;
            rbJuice.Text = "Juice ($3)";
            rbJuice.UseVisualStyleBackColor = true;
            // 
            // rbCoffee
            // 
            rbCoffee.AutoSize = true;
            rbCoffee.Font = new Font("Segoe UI", 12F);
            rbCoffee.ForeColor = SystemColors.InfoText;
            rbCoffee.Location = new Point(23, 100);
            rbCoffee.Name = "rbCoffee";
            rbCoffee.Size = new Size(157, 36);
            rbCoffee.TabIndex = 1;
            rbCoffee.TabStop = true;
            rbCoffee.Text = "Coffee ($2)";
            rbCoffee.UseVisualStyleBackColor = true;
            // 
            // rbTea
            // 
            rbTea.AutoSize = true;
            rbTea.Font = new Font("Segoe UI", 12F);
            rbTea.ForeColor = SystemColors.InfoText;
            rbTea.Location = new Point(23, 58);
            rbTea.Name = "rbTea";
            rbTea.Size = new Size(122, 36);
            rbTea.TabIndex = 0;
            rbTea.TabStop = true;
            rbTea.Text = "Tea ($1)";
            rbTea.UseVisualStyleBackColor = true;
            // 
            // txtCustomer
            // 
            txtCustomer.Font = new Font("Segoe UI", 14F);
            txtCustomer.Location = new Point(36, 150);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(607, 45);
            txtCustomer.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F);
            lblCustomerName.Location = new Point(36, 102);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(193, 32);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lbl_customer
            // 
            lbl_customer.AutoSize = true;
            lbl_customer.Font = new Font("Segoe UI", 18F);
            lbl_customer.ForeColor = SystemColors.Highlight;
            lbl_customer.Location = new Point(17, 14);
            lbl_customer.Name = "lbl_customer";
            lbl_customer.Size = new Size(369, 48);
            lbl_customer.TabIndex = 0;
            lbl_customer.Text = "Customer Information";
            lbl_customer.Click += label2_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 28F);
            lblTitle.ForeColor = SystemColors.MenuHighlight;
            lblTitle.Location = new Point(38, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(530, 86);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Lucky Cofe Order";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblLuckyMessage);
            panel3.Controls.Add(lbl_totalPrice);
            panel3.Location = new Point(38, 760);
            panel3.Name = "panel3";
            panel3.Size = new Size(1112, 110);
            panel3.TabIndex = 3;
            // 
            // lblLuckyMessage
            // 
            lblLuckyMessage.AutoSize = true;
            lblLuckyMessage.Font = new Font("Segoe UI", 12F);
            lblLuckyMessage.ForeColor = Color.FromArgb(255, 128, 0);
            lblLuckyMessage.Location = new Point(21, 64);
            lblLuckyMessage.Name = "lblLuckyMessage";
            lblLuckyMessage.Size = new Size(180, 32);
            lblLuckyMessage.TabIndex = 1;
            lblLuckyMessage.Text = "Lucky Message:";
            // 
            // lbl_totalPrice
            // 
            lbl_totalPrice.AutoSize = true;
            lbl_totalPrice.Font = new Font("Segoe UI", 12F);
            lbl_totalPrice.Location = new Point(18, 13);
            lbl_totalPrice.Name = "lbl_totalPrice";
            lbl_totalPrice.Size = new Size(161, 32);
            lbl_totalPrice.TabIndex = 0;
            lbl_totalPrice.Text = "Total Price: 0$";
            // 
            // calculateBtn
            // 
            calculateBtn.BackColor = SystemColors.ScrollBar;
            calculateBtn.FlatAppearance.BorderColor = Color.Black;
            calculateBtn.FlatStyle = FlatStyle.Flat;
            calculateBtn.Font = new Font("Segoe UI", 12F);
            calculateBtn.ForeColor = Color.Black;
            calculateBtn.Location = new Point(54, 646);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(285, 73);
            calculateBtn.TabIndex = 7;
            calculateBtn.Text = "Calculate Order";
            calculateBtn.UseVisualStyleBackColor = false;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.ScrollBar;
            saveBtn.FlatAppearance.BorderColor = Color.Black;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 12F);
            saveBtn.ForeColor = Color.Black;
            saveBtn.Location = new Point(365, 646);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(303, 73);
            saveBtn.TabIndex = 8;
            saveBtn.Text = "Save To File";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.BackColor = SystemColors.ScrollBar;
            loadBtn.FlatAppearance.BorderColor = Color.Black;
            loadBtn.FlatStyle = FlatStyle.Flat;
            loadBtn.Font = new Font("Segoe UI", 12F);
            loadBtn.ForeColor = Color.Black;
            loadBtn.Location = new Point(699, 646);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(291, 73);
            loadBtn.TabIndex = 9;
            loadBtn.Text = "Load From File";
            loadBtn.UseVisualStyleBackColor = false;
            loadBtn.Click += loadBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = SystemColors.ScrollBar;
            clearBtn.FlatAppearance.BorderColor = Color.Black;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI", 12F);
            clearBtn.ForeColor = Color.Black;
            clearBtn.Location = new Point(1026, 646);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(290, 73);
            clearBtn.TabIndex = 10;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(766, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(588, 39);
            textBox1.TabIndex = 7;
            textBox1.Text = "Order List";
            // 
            // lsResult
            // 
            lsResult.Font = new Font("Segoe UI", 11F);
            lsResult.FormattingEnabled = true;
            lsResult.Location = new Point(766, 202);
            lsResult.Name = "lsResult";
            lsResult.Size = new Size(589, 424);
            lsResult.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 882);
            Controls.Add(lsResult);
            Controls.Add(textBox1);
            Controls.Add(clearBtn);
            Controls.Add(loadBtn);
            Controls.Add(saveBtn);
            Controls.Add(calculateBtn);
            Controls.Add(panel3);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label lbl_customer;
        private TextBox txtCustomer;
        private Label lblCustomerName;
        private GroupBox groupBox1;
        private RadioButton rbJuice;
        private RadioButton rbCoffee;
        private RadioButton rbTea;
        private CheckBox chStudentDisccount;
        private TextBox txtQuantity;
        private Label label4;
        private Panel panel3;
        private Label lblLuckyMessage;
        private Label lbl_totalPrice;
        private Button button2;
        private Button calculateBtn;
        private Button saveBtn;
        private Button loadBtn;
        private Button clearBtn;
        private TextBox textBox1;
        private ListBox lsResult;
    }
}
