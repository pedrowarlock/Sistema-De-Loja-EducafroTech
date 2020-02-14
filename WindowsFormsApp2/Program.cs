using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public static class Program
    {

        public static string NotaFiscal01 =
            "*******************************************************************************************************************\r\n" +
            "ㅤ                                      BEM VINDO AO AFRO ART, BOAS COMPRAS!\r\n" +
            "*******************************************************************************************************************\r\n";

        public static string NotaFiscal02 = " COD.\t\t| QUANT. | DESCRIÇÃO\t\t| VALOR UNIT.\t| VALOR TOTAL\r\n";
        public static string NotaFiscal03 =
            "_____________________________________________________________________________" +
            "ㅤIMPOSTOS DE 9%:..........................................................................................| R$ 0,00\r\n" +
            "ㅤVALOR DA COMPRA:......................................................................................| R$ 0,00\r\n" +
            "ㅤTOTAL À PAGAR:............................................................................................| R$ 0,00\r\n" +
            "_____________________________________________________________________________\r\n";


        public static string NotaFiscal04 =
            "*******************************************************************************************************************\r\n" +
            "                      OBRIGADO POR COMPRAR COM A AFROART! VOLTE SEMPRE!                                        \r\n" +
            "*******************************************************************************************************************\r\n";


        public static bool Disponivel = false;
        public static string Codigo;
        public static string Cliente;
        public static double Total;
        

        //
        public static string[,] Carrinho = new string[10, 4];
        // ID DO PRODUTO | NOME DO PRODUTO | QUANTIDADE DO PRODUTO | PREÇO DO PRODUTO    
        public static string[,] produtos =  {
                                            { "001","Bolsa",        "75,00"  ,"20" },
                                            { "002","Batom",        "50,00"  ,"40" },
                                            { "003","Camisa Afro",  "150,00" ,"15" },
                                            { "004","Blusa tipo Capulana",        "30,50"  ,"30" },
                                            { "005","bermuda Afro", "4,50"   ,"20" },
                                            { "006","Chinelo Afro", "60,00"  ,"20" },
                                            { "007","Brinco",       "20,00"  ,"35" },
                                            { "008","Oculos de sol","50,50"  ,"50" },
                                            { "009","Esmalte",      "10,00"  ,"35" },
                                            { "010","Pulseira",     "20,00"  ,"25" },
                                            };

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        for (int i = 0; i < Program.Carrinho.GetLength(0); i++) {Program.Carrinho[i, 0] = null; Program.Carrinho[i, 1] = null; Program.Carrinho[i, 2] = null; Program.Carrinho[i, 3] = null; }
        //Application.Run(new Cadastro());
        //Application.Run(new Estoque());
        
        Application.Run(new Cliente());
        Application.Run(new AfroArt());
        //Application.Run(new Cliente());

        }
    }
}
