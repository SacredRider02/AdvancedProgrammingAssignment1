using System.Linq.Expressions;

namespace AdvancedProgrammingAssignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BindUserComboBoxValue();
        }

        private void BindUserComboBoxValue()
        {
            BankStaff user1 = new BankStaff("Bank Staff", "phone number");
            RegularCustomer user2 = new RegularCustomer("Regular Customer", "phone number 2");

            EverydayAccount eAcc1 = new EverydayAccount(100, user1);
            EverydayAccount eAcc2 = new EverydayAccount(100, user2);

            InvestmentAccount iAcc1 = new InvestmentAccount(100, user1, 11.5, 10);
            InvestmentAccount iAcc2 = new InvestmentAccount(100, user2, 11.5, 10);

            OmniAccount oAcc1 = new OmniAccount(100, user1, 11.5, 10, 15);
            OmniAccount oAcc2 = new OmniAccount(100, user2, 11.5, 10, 15);

            userComboBox.DataSource = Customer.customers;
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userComboBox.SelectedItem is Customer customer)
            {
                accountComboBox.Text = "";
                accountComboBox.DataSource = customer.accounts;
                accountComboBox.DisplayMember = "type";
                accountComboBox.ValueMember = "accountID";
            }
        }

        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountComboBox.SelectedItem is Account account)
            {
                textBox1.Text = account.DisplayInfo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accountComboBox.SelectedItem is Account account)
            {
                try
                {
                    Account.transactions.Add(account.Deposit(Double.Parse(amountTextBox.Text)));
                    textBox1.Text = account.DisplayInfo();
                    listBox1.DataSource = null;
                    listBox1.DataSource = Account.transactions;
                }
                catch (Exception ex)
                {
                    amountTextBox.Text = "";
                    textBox1.Text = "Please only input the amount you would like to deposit";
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (accountComboBox.SelectedItem is Account account)
            {
                try
                {
                    Account.transactions.Add(textBox1.Text = account.Withdraw(Double.Parse(amountTextBox.Text)));
                    listBox1.DataSource = null;
                    listBox1.DataSource = Account.transactions;
                }
                catch (Exception ex)
                {
                    amountTextBox.Text = "";
                    textBox1.Text = "Please only input the amount you would like to withdraw";
                }
            }

        }
    }
}
