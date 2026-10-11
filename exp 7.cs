using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharpForms
{
    public class Form1 : Form
    {
        TextBox textBox1;
        TextBox textBox2;
        Button button1;
        Label resultLabel;

        public Form1()
        {
            this.Text = "Addition of Two Numbers";
            this.Size = new Size(500, 350);

            Label label1 = new Label();
            label1.Text = "Enter First Number:";
            label1.Location = new Point(50, 50);
            label1.AutoSize = true;

            textBox1 = new TextBox();
            textBox1.Location = new Point(200, 50);

            Label label2 = new Label();
            label2.Text = "Enter Second Number:";
            label2.Location = new Point(50, 100);
            label2.AutoSize = true;

            textBox2 = new TextBox();
            textBox2.Location = new Point(200, 100);

            button1 = new Button();
            button1.Text = "Add";
            button1.Location = new Point(180, 150);
            button1.Click += Button1_Click;

            resultLabel = new Label();
            resultLabel.Text = "Result:";
            resultLabel.Location = new Point(180, 210);
            resultLabel.AutoSize = true;

            this.Controls.Add(label1);
            this.Controls.Add(textBox1);
            this.Controls.Add(label2);
            this.Controls.Add(textBox2);
            this.Controls.Add(button1);
            this.Controls.Add(resultLabel);
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int sum = num1 + num2;

            resultLabel.Text = "Result: " + sum;
        }
    }
}