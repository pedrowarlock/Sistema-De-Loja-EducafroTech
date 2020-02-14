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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //TransparetBackground(lblsair);

            //MONTAR OS LABEL
            for (int i = 0; i < Program.produtos.GetLength(0); i++)
            {
                switch (i)
                {
                    case 0:
                        cod1.Text = Program.produtos[i,0];
                        produto1.Text = Program.produtos[i,1];
                        valor1.Text = "R$ " + Program.produtos[i,2];
                        estoque1.Text = Program.produtos[i,3];
                        break;
                    case 1:
                        cod2.Text = Program.produtos[i, 0];
                        produto2.Text = Program.produtos[i, 1];
                        valor2.Text = "R$ " + Program.produtos[i, 2];
                        estoque2.Text = Program.produtos[i, 3];
                        break;
                    case 2:
                        cod3.Text = Program.produtos[i, 0];
                        produto3.Text = Program.produtos[i, 1];
                        valor3.Text = "R$ " + Program.produtos[i, 2];
                        estoque3.Text = Program.produtos[i, 3];
                        break;
                    case 3:
                        cod4.Text = Program.produtos[i, 0];
                        produto4.Text = Program.produtos[i, 1];
                        valor4.Text = "R$ " + Program.produtos[i, 2];
                        estoque4.Text = Program.produtos[i, 3];
                        break;
                    case 4:
                        cod5.Text = Program.produtos[i, 0];
                        produto5.Text = Program.produtos[i, 1];
                        valor5.Text = "R$ " + Program.produtos[i, 2];
                        estoque5.Text = Program.produtos[i, 3];
                        break;
                    case 5:
                        cod6.Text = Program.produtos[i, 0];
                        produto6.Text = Program.produtos[i, 1];
                        valor6.Text = "R$ " + Program.produtos[i, 2];
                        estoque6.Text = Program.produtos[i, 3];
                        break;
                    case 6:
                        cod7.Text = Program.produtos[i, 0];
                        produto7.Text = Program.produtos[i, 1];
                        valor7.Text = "R$ " + Program.produtos[i, 2];
                        estoque7.Text = Program.produtos[i, 3];
                        break;
                    case 7:
                        cod8.Text = Program.produtos[i, 0];
                        produto8.Text = Program.produtos[i, 1];
                        valor8.Text = "R$ " + Program.produtos[i, 2];
                        estoque8.Text = Program.produtos[i, 3];
                        break;
                    case 8:
                        cod9.Text = Program.produtos[i, 0];
                        produto9.Text = Program.produtos[i, 1];
                        valor9.Text = "R$ " + Program.produtos[i, 2];
                        estoque9.Text = Program.produtos[i, 3];
                        break;
                    case 9:
                        cod10.Text = Program.produtos[i, 0];
                        produto10.Text = Program.produtos[i, 1];
                        valor10.Text = "R$ " + Program.produtos[i, 2];
                        estoque10.Text = Program.produtos[i, 3];
                        break;
                    default:
                        break;
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

        private void Estoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                this.Close();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void produto1_Click(object sender, EventArgs e)
        {

        }
    }

}
