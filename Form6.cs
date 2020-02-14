using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormPagamento : Form
    {
        public FormPagamento()
        {
            InitializeComponent();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            TransparetBackground(label1);
            TransparetBackground(label2);
            label1.Text = Program.Total.ToString("0.00");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "")
            {
                if (textBox1.Text.All(char.IsDigit))
                {
                    double Calculo = double.Parse(textBox1.Text) - Program.Total;
                    if (Calculo > 0)
                    {
                        label2.Text = "R$ " + (Calculo).ToString("0.00");
                    }
                }
            }
        }

        void TransparetBackground(Control C)
        {
            C.Visible = false;

            C.Refresh();
            Application.DoEvents();

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;

            C.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                this.Close();
            }
            else if (e.KeyData == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    if (textBox1.Text.All(char.IsDigit))
                    {
                        double Calculo = double.Parse(textBox1.Text) - Program.Total;
                        if (Calculo > 0)
                        {
                            MessageBox.Show("Compra Finalizada!");

                            for (int i = 0; i < Program.Carrinho.GetLength(0); i++) { Program.Carrinho[i, 0] = null; Program.Carrinho[i, 1] = null; Program.Carrinho[i, 2] = null; Program.Carrinho[i, 3] = null; }
                            Program.Total = 0;
                            Program.Cliente = "";
                            Cliente Ts = new Cliente();
                            Ts.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Troco abaixo do total da compra!");
                        }
                    }
                }
               
            }
        }
    }
}
