
namespace DKSystem
{
    partial class frmPOS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.titleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.drinkBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dessertbtn = new Guna.UI2.WinForms.Guna2Button();
            this.menuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.orderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.takeOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dineInBtn = new Guna.UI2.WinForms.Guna2Button();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuContentPanel.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.orderPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.White;
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Controls.Add(this.btnHam);
            this.titleBar.Location = new System.Drawing.Point(12, 12);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1093, 57);
            this.titleBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "DUKE FOOD TRUCK";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(21, 8);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(43, 45);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 3;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(253, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 53);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "MENU";
            // 
            // menuContentPanel
            // 
            this.menuContentPanel.AutoScroll = true;
            this.menuContentPanel.Controls.Add(this.guna2Panel3);
            this.menuContentPanel.Location = new System.Drawing.Point(253, 135);
            this.menuContentPanel.Name = "menuContentPanel";
            this.menuContentPanel.Size = new System.Drawing.Size(541, 506);
            this.menuContentPanel.TabIndex = 16;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderRadius = 20;
            this.guna2Panel3.Controls.Add(this.label9);
            this.guna2Panel3.Controls.Add(this.guna2CheckBox1);
            this.guna2Panel3.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(528, 93);
            this.guna2Panel3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(348, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Price: ";
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox1.Location = new System.Drawing.Point(34, 11);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(217, 75);
            this.guna2CheckBox1.TabIndex = 0;
            this.guna2CheckBox1.Text = "guna2CheckBox1";
            this.guna2CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.guna2Panel2.Controls.Add(this.drinkBtn);
            this.guna2Panel2.Controls.Add(this.dessertbtn);
            this.guna2Panel2.Controls.Add(this.menuBtn);
            this.guna2Panel2.FillColor = System.Drawing.Color.Black;
            this.guna2Panel2.Location = new System.Drawing.Point(13, 76);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(234, 565);
            this.guna2Panel2.TabIndex = 18;
            // 
            // drinkBtn
            // 
            this.drinkBtn.BackColor = System.Drawing.Color.Transparent;
            this.drinkBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.drinkBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.drinkBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.drinkBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.drinkBtn.FillColor = System.Drawing.Color.Transparent;
            this.drinkBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkBtn.ForeColor = System.Drawing.Color.White;
            this.drinkBtn.Image = global::DKSystem.Properties.Resources.ri_drinks_2_line;
            this.drinkBtn.Location = new System.Drawing.Point(-88, 45);
            this.drinkBtn.Name = "drinkBtn";
            this.drinkBtn.Size = new System.Drawing.Size(323, 45);
            this.drinkBtn.TabIndex = 4;
            this.drinkBtn.Text = "    DRINKS";
            this.drinkBtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // dessertbtn
            // 
            this.dessertbtn.BackColor = System.Drawing.Color.Transparent;
            this.dessertbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dessertbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dessertbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dessertbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dessertbtn.FillColor = System.Drawing.Color.Transparent;
            this.dessertbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertbtn.ForeColor = System.Drawing.Color.White;
            this.dessertbtn.Image = global::DKSystem.Properties.Resources.ep_dessert;
            this.dessertbtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.dessertbtn.Location = new System.Drawing.Point(-92, 86);
            this.dessertbtn.Name = "dessertbtn";
            this.dessertbtn.Size = new System.Drawing.Size(327, 45);
            this.dessertbtn.TabIndex = 3;
            this.dessertbtn.Text = "    DESSERTS";
            this.dessertbtn.TextOffset = new System.Drawing.Point(5, 0);
            this.dessertbtn.Click += new System.EventHandler(this.dessertbtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menuBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menuBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menuBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menuBtn.FillColor = System.Drawing.Color.DarkGray;
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Image = global::DKSystem.Properties.Resources.bx_dish;
            this.menuBtn.Location = new System.Drawing.Point(-88, 0);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(323, 45);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.Text = "    DISHES";
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // orderPanel
            // 
            this.orderPanel.AutoScroll = true;
            this.orderPanel.BackColor = System.Drawing.Color.Silver;
            this.orderPanel.Controls.Add(this.panel2);
            this.orderPanel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPanel.Location = new System.Drawing.Point(804, 76);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(300, 371);
            this.orderPanel.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.guna2NumericUpDown1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 128);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(56)))), ((int)(((byte)(236)))));
            this.label8.Location = new System.Drawing.Point(72, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(101, 56);
            this.guna2NumericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2NumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(69, 23);
            this.guna2NumericUpDown1.TabIndex = 3;
            this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(56)))), ((int)(((byte)(236)))));
            this.guna2NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Price: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "FoodName:";
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.Transparent;
            this.generateBtn.BorderRadius = 18;
            this.generateBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.generateBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(56)))), ((int)(((byte)(236)))));
            this.generateBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.generateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(56)))), ((int)(((byte)(236)))));
            this.generateBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(56)))), ((int)(((byte)(236)))));
            this.generateBtn.Location = new System.Drawing.Point(804, 580);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(301, 62);
            this.generateBtn.TabIndex = 14;
            this.generateBtn.Text = "GENERATE RECEIPT";
            this.generateBtn.Click += new System.EventHandler(this.guna2Button11_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 18;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Location = new System.Drawing.Point(1036, 454);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(69, 62);
            this.guna2Button3.TabIndex = 20;
            this.guna2Button3.Text = "CLEAR";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // takeOutBtn
            // 
            this.takeOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.takeOutBtn.BorderRadius = 18;
            this.takeOutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.takeOutBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.takeOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.takeOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.takeOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.takeOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.takeOutBtn.FillColor = System.Drawing.Color.White;
            this.takeOutBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeOutBtn.ForeColor = System.Drawing.Color.Black;
            this.takeOutBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(56)))), ((int)(((byte)(236)))));
            this.takeOutBtn.HoverState.FillColor = System.Drawing.Color.White;
            this.takeOutBtn.Location = new System.Drawing.Point(958, 522);
            this.takeOutBtn.Name = "takeOutBtn";
            this.takeOutBtn.Size = new System.Drawing.Size(147, 52);
            this.takeOutBtn.TabIndex = 14;
            this.takeOutBtn.Text = "TAKE-OUT";
            this.takeOutBtn.Click += new System.EventHandler(this.takeOutBtn_Click);
            // 
            // dineInBtn
            // 
            this.dineInBtn.BackColor = System.Drawing.Color.Transparent;
            this.dineInBtn.BorderRadius = 18;
            this.dineInBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.dineInBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.dineInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dineInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dineInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dineInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dineInBtn.FillColor = System.Drawing.Color.White;
            this.dineInBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dineInBtn.ForeColor = System.Drawing.Color.Black;
            this.dineInBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(56)))), ((int)(((byte)(236)))));
            this.dineInBtn.HoverState.FillColor = System.Drawing.Color.White;
            this.dineInBtn.Location = new System.Drawing.Point(804, 522);
            this.dineInBtn.Name = "dineInBtn";
            this.dineInBtn.Size = new System.Drawing.Size(147, 52);
            this.dineInBtn.TabIndex = 14;
            this.dineInBtn.Text = "DINE-IN";
            this.dineInBtn.Click += new System.EventHandler(this.dineInBtn_Click);
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.BackColor = System.Drawing.Color.White;
            this.totalPriceLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(56)))), ((int)(((byte)(236)))));
            this.totalPriceLbl.Location = new System.Drawing.Point(888, 472);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(29, 32);
            this.totalPriceLbl.TabIndex = 22;
            this.totalPriceLbl.Text = "0";
            this.totalPriceLbl.Click += new System.EventHandler(this.totalPriceLbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(829, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total: ";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 18;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(804, 453);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(226, 62);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_3);
            // 
            // frmPOS
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1117, 654);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.takeOutBtn);
            this.Controls.Add(this.dineInBtn);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.menuContentPanel);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuContentPanel.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.orderPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel menuContentPanel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.FlowLayoutPanel orderPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button generateBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button takeOutBtn;
        private Guna.UI2.WinForms.Guna2Button dineInBtn;
        private Guna.UI2.WinForms.Guna2Button drinkBtn;
        private Guna.UI2.WinForms.Guna2Button dessertbtn;
        private Guna.UI2.WinForms.Guna2Button menuBtn;
        private System.Windows.Forms.Label totalPriceLbl;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

