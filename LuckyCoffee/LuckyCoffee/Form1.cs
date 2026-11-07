using System.IO;
namespace LuckyCoffee

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Name Validation
                lsResult.Items.Clear();
                string customerName = txtCustomer.Text.Trim();

                if (customerName == "")
                {
                    MessageBox.Show("Please enter your name.");
                    return;
                }

                bool isName = true;

                for (int i = 0; i < customerName.Length; i++)
                {
                    if (customerName[i] >= '0' && customerName[i] <= '9')
                    {
                        isName = false;
                        break;
                    }
                }

                if (isName == false)
                {
                    MessageBox.Show("Please enter a valid name.");
                    return;
                }

                //Quantity Validation

                int quantity = int.Parse(txtQuantity.Text);
                if (quantity < 1)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                //Calculate The Prices
                Random randomNumber = new Random();
                double totalPrice = 0;
                bool hasPrize = false;

                if (rbTea.Checked)
                {
                    int teaPrice = 1;
                    totalPrice = teaPrice * quantity;


                    if (chStudentDisccount.Checked)
                    {
                        totalPrice = totalPrice * 0.9;
                    }

                    lbl_totalPrice.Text = "Total Price: $" + totalPrice.ToString("0.00");



                    for (int i = 1; i <= quantity; i++)
                    {

                        int number = randomNumber.Next(1, 51);
                        if (number == 7 || number == 17)
                        {
                            hasPrize = true;
                        }
                        lsResult.Items.Add(i + ") " + customerName + "-Tea-Lucky-" + number + "-$1.00");
                    }

                    if (hasPrize)
                    {
                        lblLuckyMessage.Text = "Lucky Message: You got a Free Cookie!";
                    }

                    else
                    {
                        lblLuckyMessage.Text = "Lucky Message: No prize this time.";
                    }
                }
                else if (rbCoffee.Checked)
                {
                    int coffePrice = 2;
                    totalPrice = coffePrice * quantity;
                    if (chStudentDisccount.Checked)
                    {
                        totalPrice = totalPrice * 0.9;
                    }
                    lbl_totalPrice.Text = "Total Price: $" + totalPrice.ToString("0.00");



                    for (int i = 1; i <= quantity; i++)
                    {

                        int number = randomNumber.Next(1, 51);
                        if (number == 7 || number == 17)
                        {
                            hasPrize = true;
                        }
                        lsResult.Items.Add(i + ") " + customerName + "-Coffee-Lucky-" + number + "-$2.00");
                    }
                    if (hasPrize)
                    {
                        lblLuckyMessage.Text = "Lucky Message: You got a Free Cookie!";
                    }
                    else
                    {
                        lblLuckyMessage.Text = "Lucky Message: No prize this time.";
                    }
                }
                else if (rbJuice.Checked)
                {
                    int juicePrice = 3;
                    totalPrice = juicePrice * quantity;
                    if (chStudentDisccount.Checked)
                    {
                        totalPrice = totalPrice * 0.9;
                    }
                    lbl_totalPrice.Text = "Total Price: $" + totalPrice.ToString("0.00");
                    for (int i = 1; i <= quantity; i++)
                    {

                        int number = randomNumber.Next(1, 51);
                        if (number == 7 || number == 17)
                        {
                            hasPrize = true;
                        }
                        lsResult.Items.Add(i + ") " + customerName + "-Juice-Lucky-" + number + "-$3.00");
                    }
                    if (hasPrize)
                    {
                        lblLuckyMessage.Text = "Lucky Message: You got a Free Cookie!";
                    }
                    else
                    {
                        lblLuckyMessage.Text = "Lucky Message: No prize this time.";
                    }
                }

                //Sava the Result


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (lsResult.Items.Count == 0)
            {
                MessageBox.Show("No results to save.");
                return;
            }
            StreamWriter saveResult = File.AppendText("Result.txt");
           for(int i = 0; i < lsResult.Items.Count; i++)
            {
                saveResult.WriteLine(lsResult.Items[i].ToString());
            }
            saveResult.WriteLine("Total Price: " + lbl_totalPrice.Text);
            saveResult.WriteLine(lblLuckyMessage.Text);
            saveResult.WriteLine(" ");
            saveResult.WriteLine("-----------------------------");

            saveResult.Close();
            MessageBox.Show("Order Saved");
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Result.txt"))
            {
                MessageBox.Show("No saved results Please save results first..");
                return;
            }
            lsResult.Items.Clear();
            StreamReader loadResult =File.OpenText("Result.txt");
            
            while (!loadResult.EndOfStream)
            {
                string readLine = loadResult.ReadLine();
                lsResult.Items.Add(readLine);
            }
            loadResult.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            lsResult.Items.Clear();
            lbl_totalPrice.Text = "Total Price: $0.00";
            lblLuckyMessage.Text = "Lucky Message: ";
            txtCustomer.Clear();
            txtQuantity.Clear();
            rbTea.Checked = false;
            rbCoffee.Checked = false;
            rbJuice.Checked = false;
            chStudentDisccount.Checked = false;
        }
    }
}