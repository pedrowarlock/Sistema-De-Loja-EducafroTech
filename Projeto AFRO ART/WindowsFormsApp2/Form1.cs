using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Input;
using System.IO;


namespace WindowsFormsApp2
{


    public partial class AfroArt : Form
    {

    public AfroArt()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TransparetBackground(lbl_initvenda);
            TransparetBackground(lbltotal);
            TransparetBackground(CodQuantidade);
            TransparetBackground(lblProduto);
            TransparetBackground(lblUnit);
            TransparetBackground(lblEstoque);
            TransparetBackground(lblUnitario);

           


        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            TextBox objTextBox = (TextBox)sender;
            string theText = objTextBox.Text;
            

            for (int i = 0; i < Program.produtos.GetLength(0); i++)
            {

                
                //if (int.Parse(Program.produtos[i, 0]) == int.Parse(theText))
                if (Program.produtos[i, 0].PadLeft(8, '0') == theText.PadLeft(8, '0'))
                {
                    //MessageBox.Show(Program.produtos[i, 0].PadLeft(8, '0') + "///" + theText.PadLeft(8, '0'));
                    lblProduto.Text = Program.produtos[i, 1].ToUpper();
                    lblUnitario.Text = "R$ " + Program.produtos[i, 2];
                    lblUnit.Text = "R$ " + Program.produtos[i, 2];
                    lblEstoque.Text = Program.produtos[i, 3].ToUpper();

                    //string File = ".//img//" + Program.produtos[i, 1] + ".jpg";
                    string File = "..//..//img//" + Program.produtos[i, 1] + ".jpg";
                    pictureBox_Demo.ImageLocation = File;
                    Program.Disponivel = true;
                    break;
                }
                else
                {
                    Program.Disponivel = false;
                    lblUnitario.Text = "";
                    lblProduto.Text = "";
                    lblUnit.Text = "";
                    lblEstoque.Text = "";
                    //string File = ".//img//nopic.png";
                    pictureBox_Demo.ImageLocation = "..//..//img//nopic.png";
                }
                
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void AfroArt_KeyPress(object sender, KeyPressEventArgs e)
        {
          

           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                FormPagamento f1 = new FormPagamento();
                f1.Show();
                richTextBox1.Text = "";
            }
            else if (e.KeyData == Keys.F2)
            {
                Estoque f2 = new Estoque();
                f2.Show();
            }
            else if (e.KeyData == Keys.Enter)
            {
                CodQuantidade.Focus();
                CodQuantidade.Select(0, CodQuantidade.Text.Length);
            }
            

        }

        private void lblProduto_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyData == Keys.F1)
            {
                FormPagamento f1 = new FormPagamento();
                f1.Show();
                richTextBox1.Text = "";
            }
            else if (e.KeyData == Keys.F2)
            {
                Estoque f2 = new Estoque();
                f2.Show();
            }
            else if (e.KeyData == Keys.Enter)
            {
                if (Program.Disponivel)
                {

                    
                    richTextBox1.Text =
                    "ㅤ                                      BEM VINDO AO AFRO ART, BOAS COMPRAS!\r\n" +
                    "-----------------------------------------------------------------------------------------------------------------------------------------------------------\r\n" +
                    "\t\t\t\tCUPOM FISCAL                              \r\n" +
                    "-----------------------------------------------------------------------------------------------------------------------------------------------------------\r\n" +
                    " Cliente: " + Program.Cliente + "\r\n" +
                    "-----------------------------------------------------------------------------------------------------------------------------------------------------------\r\n";


                    for (int i = 0; i < Program.produtos.GetLength(0); i++)
                    {
                        //Compara o código digitado com todos os códigos do catalogo
                        if (Program.produtos[i, 0].PadLeft(8, '0') == CodText.Text.PadLeft(8, '0'))
                        {
                            for (int k = 0; k < Program.Carrinho.GetLength(0); k++)
                            {
                                if (Program.Carrinho[k, 0] == null || Program.Carrinho[k, 0].PadLeft(8, '0') == CodText.Text.PadLeft(8, '0'))
                                {
                                    if (Program.Carrinho[k, 0] == null) { Program.Carrinho[k, 0] = "0"; Program.Carrinho[k, 1] = "0"; Program.Carrinho[k, 2] = "0"; Program.Carrinho[k, 3] = "0"; }
                                    double count1 = Convert.ToDouble(CodQuantidade.Value);
                                    
                                    // ID DO PRODUTO | NOME DO PRODUTO | QUANTIDADE DO PRODUTO | PREÇO DO PRODUTO  
                                    if (count1 > Double.Parse(Program.produtos[i, 3]))
                                    {
                                        MessageBox.Show("Desculpe, não temos em estoque!");
                                        break;
                                    }

                                    Program.Carrinho[k, 0] = Program.produtos[i, 0];                                        //ID DO PRODUTO
                                    Program.Carrinho[k, 1] = Program.produtos[i, 1];                                        //NOME DO PRODUTODO
                                    Program.Carrinho[k, 2] = (double.Parse(Program.Carrinho[k, 2]) + count1).ToString();    //QUANTIDADE
                                    Program.Carrinho[k, 3] = Convert.ToDouble(Program.produtos[i, 2]).ToString("0.00");                                  //VALOR TOTAL
                                    Program.produtos[i, 3] = (Double.Parse(Program.produtos[i, 3]) - count1).ToString(); 
                                    MessageBox.Show("Adicionado ao carrinho!");
                                    CodText.Text = "";
                                    CodQuantidade.Text = "1";

                                    break;
                                }
                            }

                        }
                    }
                    // FORMATA O CARRINHO NA NOTA FISCAL 
                    richTextBox1.Text += Program.NotaFiscal02;
                    double total = 0;
                    double taxa = 0;
                    for (int j = 0; j < Program.Carrinho.GetLength(0); j++)
                    {
                        if (Program.Carrinho[j, 0] != null)
                        {
                            //MessageBox.Show(Program.Carrinho[i, 0]);
                            richTextBox1.Text += " " +
                                Program.Carrinho[j, 0].PadLeft(8, '0') + "\t|⠀⠀⠀" +
                                Program.Carrinho[j, 2].PadLeft(3, '0') + "⠀| ";

                            richTextBox1.Text += Program.Carrinho[j, 1].PadRight(29, ' ');
                            richTextBox1.Text += "\t| R$ " + ((double.Parse(Program.Carrinho[j, 3])).ToString("0.00")).PadRight(15, ' ');
                            richTextBox1.Text += "\t| R$ " + (double.Parse(Program.Carrinho[j, 3]) * double.Parse(Program.Carrinho[j, 2])).ToString("0.00") + "\r\n";

                            total += double.Parse(Program.Carrinho[j, 2]) * double.Parse(Program.Carrinho[j, 3]);
                            taxa = (total * 0.09);

                        }
                    }
                    //---------------------------------------------------------------------------

                    lbltotal.Text = (total + taxa).ToString("0.00");

                    //ESCREVE O TOTAL
                    richTextBox1.Text +=
                   "_____________________________________________________________________________\r\n" +
                   "⠀VALOR NÃO TRIBUTADO:.................................................................................| R$ " + total.ToString("0.00") + "\r\n" +
                   "⠀VALOR TOTAL:...................................................................................................| R$ " + lbltotal.Text + "\r\n" +
                   "_____________________________________________________________________________\r\n";
                    //richTextBox1.Text += Program.NotaFiscal03;
                    //ESCREVE A BASE DA NOTA FISCAL
                    richTextBox1.Text += Program.NotaFiscal04;
                    Program.Total = double.Parse(lbltotal.Text);
                }
                CodText.Focus();
                CodText.Select(0, CodText.Text.Length);

            }
            if (e.KeyData == Keys.Delete)
            {
                CodText.Focus();
                CodText.Select(0, CodText.Text.Length);

            }
        }

        private void lblUnit_Click(object sender, EventArgs e)
        {

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

        private void CodText_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
