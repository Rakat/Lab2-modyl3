using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_modyl3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_(object sender, EventArgs e)
        {
            
        }

        private void b(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Windows.Forms;

namespace PizzaOrderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // Отримання даних з полів першої вкладки
            decimal pizzaPrice = decimal.TryParse(txtPizzaPrice.Text, out pizzaPrice) ? pizzaPrice : 0;
            int pizzaQuantity = (int)numericUpDownPizzaQuantity.Value;

            decimal drinkPrice = decimal.TryParse(txtDrinkPrice.Text, out drinkPrice) ? drinkPrice : 0;
            int drinkQuantity = (int)numericUpDownDrinkQuantity.Value;

            // Обчислення загальної вартості
            decimal total = (pizzaPrice * pizzaQuantity) + (drinkPrice * drinkQuantity);

            // Виведення загальної вартості
            MessageBox.Show($"Загальна вартість замовлення: {total} грн.", "Замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Очистка NumericUpDown для піци та напоїв
            numericUpDownPizzaQuantity.Value = 0;
            numericUpDownDrinkQuantity.Value = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Закриття форми
            this.Close();
        }
    }
}
