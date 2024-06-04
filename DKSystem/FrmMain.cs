using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Guna.UI2.WinForms;

namespace DKSystem
{
    public partial class frmPOS : Form
    {
        private string connString = "Server=localhost;database=sql12707321;user=newname;password=";
        private List<Guna.UI2.WinForms.Guna2CheckBox> foods = new List<Guna.UI2.WinForms.Guna2CheckBox>();
        private Dictionary<Guna.UI2.WinForms.Guna2CheckBox, Panel> checkBoxPanelMap = new Dictionary<Guna.UI2.WinForms.Guna2CheckBox, Panel>();
        private Form1 receipt = new Form1();
        private List<Guna2Panel> dishes = new List<Guna2Panel>();
        private List<Guna2Panel> drinks = new List<Guna2Panel>();
        private List<Guna2Panel> desserts = new List<Guna2Panel>();
        private bool isDish = false, isDrink = false, isDessert = false;
        public frmPOS()
        {
            InitializeComponent();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                orderPanel.Controls.Clear();
                menuContentPanel.Controls.Clear();
                if (!isDish) {
                    MySqlConnection con = new MySqlConnection(connString);
                    con.Open();
                    string qry = "SELECT * FROM `dishes`";
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Guna.UI2.WinForms.Guna2Panel foodPanel = new Guna.UI2.WinForms.Guna2Panel
                        {
                            BackColor = System.Drawing.Color.White,
                            Location = new System.Drawing.Point(3, 3),
                            Name = "foodPanel",
                            Size = new System.Drawing.Size(535, 100),
                            TabIndex = 0
                        };

                        Guna.UI2.WinForms.Guna2CheckBox foodCheck = new Guna.UI2.WinForms.Guna2CheckBox
                        {
                            CheckedState = { BorderColor = System.Drawing.Color.FromArgb(94, 148, 255), BorderRadius = 0, BorderThickness = 0, FillColor = System.Drawing.Color.FromArgb(94, 148, 255) },
                            Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0),
                            Location = new System.Drawing.Point(34, 11),
                            Name = "foodCheck",
                            Size = new System.Drawing.Size(248, 75),
                            TabIndex = 0,
                            Text = reader.GetString("dishName"),
                            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                            UncheckedState = { BorderColor = System.Drawing.Color.FromArgb(125, 137, 149), BorderRadius = 0, BorderThickness = 0, FillColor = System.Drawing.Color.FromArgb(125, 137, 149) }
                        };

                        Label priceLbl = new Label
                        {
                            AutoSize = true,
                            Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(358, 40),
                            Name = "priceLbl",
                            Size = new System.Drawing.Size(45, 16),
                            TabIndex = 1,
                            Text = "Price: ₱" + reader.GetDouble("price")
                        };

                        foodCheck.CheckedChanged += new System.EventHandler(foodCheck_CheckChanged);

                        menuContentPanel.Controls.Add(foodPanel);
                        foodPanel.Controls.Add(foodCheck);
                        foodPanel.Controls.Add(priceLbl);
                        dishes.Add(foodPanel);
                        isDish = true;
                    }
                } 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

        }

        private void btnHam_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foodCheck_CheckChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CheckBox checkbox = sender as Guna.UI2.WinForms.Guna2CheckBox;
            Panel parentPanel = (Panel)checkbox.Parent;
            string[] priceLblSplit = parentPanel.Controls["priceLbl"].Text.Split('₱');
            double price = Convert.ToDouble(priceLblSplit[1]);
            if (checkbox != null)
            {
                if (checkbox.Checked)
                {
                    if (!checkBoxPanelMap.ContainsKey(checkbox))
                    {
                        Panel panel = new Panel
                        {
                            AutoScroll = true,
                            BackColor = System.Drawing.Color.White,
                            Location = new System.Drawing.Point(3, 3),
                            Name = "panel" + checkbox.Name,
                            Size = new System.Drawing.Size(275, 145),
                            TabIndex = 0
                        };
                        
                        Label name = new Label()
                        {
                            AutoSize = true,
                            Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(21, 15),
                            Name = "labelName",
                            Size = new System.Drawing.Size(115, 25),
                            TabIndex = 0,
                            Text = checkbox.Text
                        };

                        Label priceLbl = new Label
                        {
                            AutoSize = true,
                            Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(22, 93),
                            Name = "priceLabel",
                            Size = new System.Drawing.Size(54, 21),
                            TabIndex = 2,
                            Text = "Price: ₱"
                        };

                        Label priceNum = new Label
                        {
                            AutoSize = true,
                            BackColor = System.Drawing.SystemColors.Window,
                            Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(56)))), ((int)(((byte)(236))))),
                            Location = new System.Drawing.Point(90, 93),
                            Name = "priceNum",
                            Size = new System.Drawing.Size(50, 20),
                            TabIndex = 4,
                            Text = Convert.ToString(price)
                        };

                        Label quanLbl = new Label
                        {
                            AutoSize = true,
                            Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(22, 59),
                            Name = "quanLbl",
                            Size = new System.Drawing.Size(80, 21),
                            TabIndex = 1,
                            Text = "Quantity: "
                        };

                        Guna.UI2.WinForms.Guna2NumericUpDown quanNum = new Guna.UI2.WinForms.Guna2NumericUpDown
                        {
                            BackColor = System.Drawing.Color.Transparent,
                            Cursor = System.Windows.Forms.Cursors.IBeam,
                            Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(101, 56),
                            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4),
                            Minimum = new decimal(new int[] {
                                1,
                                0,
                                0,
                                0}),
                            Name = "quanNum",
                            Size = new System.Drawing.Size(69, 23),
                            TabIndex = 3,
                            UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(56)))), ((int)(((byte)(236))))),
                            Value = new decimal(new int[] {
                                1,
                                0,
                                0,
                                0}),
                        };
                        quanNum.ValueChanged += (s, ev) => UpdatePrice();

                        orderPanel.Controls.Add(panel);
                        panel.Controls.Add(name);
                        panel.Controls.Add(priceLbl);
                        panel.Controls.Add(priceNum);
                        panel.Controls.Add(quanLbl);
                        panel.Controls.Add(quanNum);
                        checkBoxPanelMap[checkbox] = panel;
                    }
                }
                else
                {
                    if (checkBoxPanelMap.ContainsKey(checkbox))
                    {
                        Panel panel = checkBoxPanelMap[checkbox];
                        orderPanel.Controls.Remove(panel);
                        checkBoxPanelMap.Remove(checkbox);
                    }
                }
                UpdatePrice();
            }
        }

        private void UpdatePrice()
        {
            double total = 0;
            foreach(Panel panel in orderPanel.Controls)
            {
                string foodName = panel.Controls["labelName"].Text;
                Guna.UI2.WinForms.Guna2NumericUpDown quantitynum = (Guna.UI2.WinForms.Guna2NumericUpDown)panel.Controls["quanNum"];
                double priceFood;

                if (double.TryParse(panel.Controls["priceNum"].Text, out priceFood))
                {
                    total += Convert.ToDouble(quantitynum.Value) * priceFood;
                    
                }
            }
            totalPriceLbl.Text = Convert.ToString(total.ToString("0.00"));
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            orderPanel.Controls.Clear();
            
            foreach(Control cont in menuContentPanel.Controls)
            {
                if (cont is Guna.UI2.WinForms.Guna2Panel foodPanel)
                {
                    foreach (Control control in foodPanel.Controls)
                    {
                        if (control is Guna.UI2.WinForms.Guna2CheckBox check)
                        {
                            check.Checked = false;
                        }
                    }
                }
            }
            UpdatePrice();
        }

        bool isDineIn = false, isTakeOut = false;

        private void dineInBtn_Click(object sender, EventArgs e)
        {
            if (!isDineIn)
            {
                isDineIn = true;
                isTakeOut = false;
                dineInBtn.FillColor = Color.WhiteSmoke;
                takeOutBtn.FillColor = Color.White;
            }
        }

        private void takeOutBtn_Click(object sender, EventArgs e)
        {
            if (!isTakeOut)
            {
                isDineIn = false;
                isTakeOut = true;
                dineInBtn.FillColor = Color.White;
                takeOutBtn.FillColor = Color.WhiteSmoke;
            }
        }

        private int orderNumber = 87482;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            menuBtn.FillColor = Color.Transparent;
            dessertbtn.FillColor = Color.Transparent;
            drinkBtn.FillColor = Color.DarkGray;
            if (!isDrink)
            {
                try
                {
                    menuContentPanel.Controls.Clear();
                    MySqlConnection con = new MySqlConnection(connString);
                    con.Open();
                    string qry = "SELECT * FROM `drinks`";
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Guna.UI2.WinForms.Guna2Panel foodPanel = new Guna.UI2.WinForms.Guna2Panel
                        {
                            BackColor = System.Drawing.Color.White,
                            Location = new System.Drawing.Point(3, 3),
                            Name = "foodPanel",
                            Size = new System.Drawing.Size(535, 100),
                            TabIndex = 0
                        };

                        Guna.UI2.WinForms.Guna2CheckBox foodCheck = new Guna.UI2.WinForms.Guna2CheckBox
                        {
                            CheckedState = { BorderColor = System.Drawing.Color.FromArgb(94, 148, 255), BorderRadius = 0, BorderThickness = 0, FillColor = System.Drawing.Color.FromArgb(94, 148, 255) },
                            Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0),
                            Location = new System.Drawing.Point(34, 11),
                            Name = "foodCheck",
                            Size = new System.Drawing.Size(248, 75),
                            TabIndex = 0,
                            Text = reader.GetString("drinkName"),
                            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                            UncheckedState = { BorderColor = System.Drawing.Color.FromArgb(125, 137, 149), BorderRadius = 0, BorderThickness = 0, FillColor = System.Drawing.Color.FromArgb(125, 137, 149) }
                        };

                        Label priceLbl = new Label
                        {
                            AutoSize = true,
                            Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(358, 40),
                            Name = "priceLbl",
                            Size = new System.Drawing.Size(45, 16),
                            TabIndex = 1,
                            Text = "Price: ₱" + reader.GetDouble("price")
                        };

                        foodCheck.CheckedChanged += new System.EventHandler(foodCheck_CheckChanged);

                        menuContentPanel.Controls.Add(foodPanel);
                        foodPanel.Controls.Add(foodCheck);
                        foodPanel.Controls.Add(priceLbl);
                        drinks.Add(foodPanel);
                        isDrink = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            } else
            {
                menuContentPanel.Controls.Clear();
                foreach(Guna2Panel panel in drinks)
                {
                    menuContentPanel.Controls.Add(panel);
                }
            }
        }

        private void dessertbtn_Click(object sender, EventArgs e)
        {
            drinkBtn.FillColor = Color.Transparent;
            menuBtn.FillColor = Color.Transparent;
            dessertbtn.FillColor = Color.DarkGray;
            if (!isDessert)
            {
                try
                {
                    menuContentPanel.Controls.Clear();
                    MySqlConnection con = new MySqlConnection(connString);
                    con.Open();
                    string qry = "SELECT * FROM `desserts`";
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Guna.UI2.WinForms.Guna2Panel foodPanel = new Guna.UI2.WinForms.Guna2Panel
                        {
                            BackColor = System.Drawing.Color.White,
                            Location = new System.Drawing.Point(3, 3),
                            Name = "foodPanel",
                            Size = new System.Drawing.Size(535, 100),
                            TabIndex = 0
                        };

                        Guna.UI2.WinForms.Guna2CheckBox foodCheck = new Guna.UI2.WinForms.Guna2CheckBox
                        {
                            CheckedState = { BorderColor = System.Drawing.Color.FromArgb(94, 148, 255), BorderRadius = 0, BorderThickness = 0, FillColor = System.Drawing.Color.FromArgb(94, 148, 255) },
                            Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0),
                            Location = new System.Drawing.Point(34, 11),
                            Name = "foodCheck",
                            Size = new System.Drawing.Size(248, 75),
                            TabIndex = 0,
                            Text = reader.GetString("dessertName"),
                            TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                            UncheckedState = { BorderColor = System.Drawing.Color.FromArgb(125, 137, 149), BorderRadius = 0, BorderThickness = 0, FillColor = System.Drawing.Color.FromArgb(125, 137, 149) }
                        };

                        Label priceLbl = new Label
                        {
                            AutoSize = true,
                            Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(358, 40),
                            Name = "priceLbl",
                            Size = new System.Drawing.Size(45, 16),
                            TabIndex = 1,
                            Text = "Price: ₱" + reader.GetDouble("price")
                        };

                        foodCheck.CheckedChanged += new System.EventHandler(foodCheck_CheckChanged);

                        menuContentPanel.Controls.Add(foodPanel);
                        foodPanel.Controls.Add(foodCheck);
                        foodPanel.Controls.Add(priceLbl);
                        desserts.Add(foodPanel);
                        isDessert = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            } else
            {
                menuContentPanel.Controls.Clear();
                foreach(Guna2Panel panels in desserts)
                {
                    menuContentPanel.Controls.Add(panels);
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            drinkBtn.FillColor = Color.Transparent;
            dessertbtn.FillColor = Color.Transparent;
            menuBtn.FillColor = Color.DarkGray;
            menuContentPanel.Controls.Clear();
            if (isDish)
            {
                foreach (Guna2Panel dishPanels in dishes)
                {
                    menuContentPanel.Controls.Add(dishPanels);
                }
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void totalPriceLbl_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_3(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if (!isDineIn && !isTakeOut)
            {
                MessageBox.Show("Please select if you want to Dine In or Take Out");
            } else if (!orderPanel.Controls.OfType<Panel>().Any())
            {
                MessageBox.Show("Please Set An Order");
            }
            else
            {
                DateTime datenow = DateTime.Now;
                string dateonly = Convert.ToString(datenow);
                string[] today = dateonly.Split(' ');
                receipt.date.Text = today[0];
                receipt.orderNum.Text = Convert.ToString(orderNumber);
                RichTextBox rcp = receipt.receiptPrv;
                rcp.Clear();
                rcp.Text = "";
                rcp.AppendText("------------------------------ Receipt #: " + Convert.ToString(orderNumber) + "-------------------------------" + Environment.NewLine);
                rcp.AppendText("---------------------------------------------------------------------------------------------" + Environment.NewLine);
                rcp.AppendText("\t\t" + "DUKE DUKE" + Environment.NewLine);
                rcp.AppendText("---------------------------------------------------------------------------------------------" + Environment.NewLine);
                foreach (Control cont in orderPanel.Controls)
                {
                    if (cont is Panel orderPan)
                    {
                        Control foodName = orderPan.Controls["labelName"];
                        Control foodPrice = orderPan.Controls["priceNum"];
                        Control foodQuan = orderPan.Controls["quanNum"];
                        if (foodName is Label foodLbl)
                        {
                            if (foodPrice is Label priceF)
                            {
                                if (foodQuan is Guna2NumericUpDown quan)
                                {
                                    if (foodLbl.Text.Length < 6)
                                    {
                                        rcp.AppendText(foodLbl.Text + " \t\t\t" + Convert.ToString(quan.Value) + " \t\t" + "₱" + priceF.Text + Environment.NewLine);
                                    }
                                    else if (foodLbl.Text.Length < 14)
                                    {
                                        rcp.AppendText(foodLbl.Text + " \t\t" + Convert.ToString(quan.Value) + " \t\t" + "₱" + priceF.Text + Environment.NewLine);
                                    }
                                    else if (foodLbl.Text.Length < 20)
                                    {
                                        rcp.AppendText(foodLbl.Text + " \t" + Convert.ToString(quan.Value) + " \t\t" + "₱" + priceF.Text + Environment.NewLine);
                                    }
                                    else
                                    {
                                        rcp.AppendText(foodLbl.Text + " " + Convert.ToString(quan.Value) + " \t\t" + "₱" + priceF.Text + Environment.NewLine);
                                    }
                                }
                            }
                        }
                    }
                }
                rcp.AppendText("---------------------------------------------------------------------------------------------" + Environment.NewLine);
                rcp.AppendText("Total Cost \t\t\t\t" + totalPriceLbl.Text + Environment.NewLine);
                rcp.AppendText("---------------------------------------------------------------------------------------------" + Environment.NewLine);
                rcp.AppendText(Convert.ToString(today[0]) + Environment.NewLine);
                receipt.totalPriceLbl.Text = totalPriceLbl.Text;
                receipt.ShowDialog();
                orderNumber++;
                isDineIn = false;
                isTakeOut = false;
                dineInBtn.FillColor = Color.White;
                takeOutBtn.FillColor = Color.White;
            }
        }
    }
}
