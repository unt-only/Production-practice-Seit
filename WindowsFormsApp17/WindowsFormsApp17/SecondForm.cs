using System;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "Выберите вариант", "Доступный 100 Мбит/с", "Премиум 300 Мбит/с", "Турбо 500 Мбит/с", "Тысяча Мбит/с" });
            comboBox1.SelectedIndex = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();

           
            if (selectedOption == "Выберите вариант")
            {
                
                MessageBox.Show("Ошибка: Выберите вариант!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
           
            string userInput = textBox1.Text.Trim(); 
            string userInput2 = textBox2.Text.Trim(); 
            string userInput3 = textBox3.Text.Trim(); 

            
            if (string.IsNullOrEmpty(userInput))
            {
               
                MessageBox.Show("Ошибка: Введите данные в поле!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (string.IsNullOrEmpty(userInput2))
            {
                
                MessageBox.Show("Ошибка: Введите данные в поле!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (string.IsNullOrEmpty(userInput3))
            {
                
                MessageBox.Show("Ошибка: Введите данные в поле!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            MessageBox.Show("Спасибо за оставленную заявку! С вами скоро свяжутся.", "Заявка отправлена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
