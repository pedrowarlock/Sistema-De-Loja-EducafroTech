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
    public partial class RemoverItem : Form
    {
        public RemoverItem()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {

               

            }
            else if (e.KeyData == Keys.Enter)
            {

                for (int i = 0; i < Program.Carrinho.GetLength(0); i++)
                {
                    if (Program.Carrinho[i, 0] != null)
                    {
                        if (Program.Carrinho[i, 0].PadLeft(8, '0') == textBox1.Text.PadLeft(8, '0'))
                        {
                            MessageBox.Show("Item removido do carrinho!");
                            break;
                        }
                    }
                }


            }
        
        }

   

    }
   
}
