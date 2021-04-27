using System;


using System.Windows.Forms;
using System.Numerics;
//using BigMath;

namespace RSA_Luis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void passo1()
        {

           
            
            int N, Z , P, Q;
            P = Convert.ToInt32(txtP.Text);
            Q = Convert.ToInt32(txtQ.Text);
            N = P * Q ;
            Z = (P-1) * (Q-1);

            LBN.Text = N.ToString ();
            LBZ.Text = Z.ToString();




        }

 

        //
        // Função mdc
        //
        private int mdc(int num1, int num2)
        {

            int resto;

            do
            {
                resto = num1 % num2;

                num1 = num2;
                num2 = resto;

            } while (resto != 0);

            return num1;
        }



        private void passo2()
        {
            try
            {
                int n1, n2;
                n1 = Convert.ToInt32(LBN.Text);
                n2 = Convert.ToInt32(txtE.Text);

               // mdc(n1, n2);
                LBMDC.Text = mdc(n1, n2).ToString();
            }

            catch
            {
                LBMDC.Text = "Erro";
            }

        }

        private void passo3()
        {
            LB_ModZ1.Text = "";


            int modulo , N1, N2, Multip;
            N1 = Convert.ToInt32(LBZ.Text); //640 Z
            N2 = Convert.ToInt32(txtE.Text); //13 E
           


            for (int i = 2; i <= N1; i++) // Calcula o Número D
            {
                Multip = i * N2;

                modulo = (Multip % N1);

                if (modulo == 1)
                {
                    LB_ModZ1.Text = i.ToString (); // Pega o maior número D
                }
            
            }


            if (LB_ModZ1.Text == "")
            {
                MessageBox.Show("Mod Z é diferente de 1 !");
                LB_ModZ1.Text = "Erro !";
            }

        }

        private void btnChaves_Click(object sender, EventArgs e)
        {
            passo1();
            passo2();
            passo3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int texto;
            int ee, n, d;
            

            ee = Convert.ToInt16(txtE.Text);
            n = Convert.ToInt16(LBN.Text);
            d = Convert.ToInt16(LB_ModZ1.Text);

            texto = Convert.ToInt32(txtTexto.Text);
            BigInteger teste = BigInteger.Parse("912571630183484301672314008717756984377273532301");

            txtGrande.Text = BigInteger.Pow(texto, ee).ToString();

            txtDigitos.Text = txtGrande.Text.Length.ToString();

            teste = (BigInteger.Pow(texto, ee) % n);                    

            txtCripto.Text = teste.ToString();

            BigInteger teste2 = BigInteger.Parse("912571630183484301672314008717756984377273532301");
            teste2 = (BigInteger.Pow(teste, d) % n);

            txtDescripto.Text = teste2.ToString();


        }

        private Int16 Cripta(Int16 n1)
        {
            Int16 saida = 0;
            int ee, n, d;
            string kk;


            ee = Convert.ToInt16(txtE.Text);
            n = Convert.ToInt16(LBN.Text);
            //d = Convert.ToInt16(LB_ModZ1.Text);

            BigInteger rasc = BigInteger.Parse("912571630183484301672314008717756984377273532301");
            rasc = (BigInteger.Pow(n1, ee) % n);

            kk = rasc.ToString();
            saida = Convert.ToInt16(kk);

            return saida;
        }

        private Int16 DesCripta(Int16 n1)
        {
            Int16 saida = 0;
            int ee, n, d;
            string kk;

            ee = Convert.ToInt16(txtE.Text);
            n = Convert.ToInt16(LBN.Text);
            d = Convert.ToInt16(LB_ModZ1.Text);

            BigInteger rasc = BigInteger.Parse("912571630183484301672314008717756984377273532301");
            rasc = (BigInteger.Pow(n1, d) % n);

            kk = rasc.ToString();
            saida = Convert.ToInt16(kk);

            return saida;
        }

        private void Btnchar_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            richTextBox1.Text = "";
            string par = textBox1.Text;
            char[] ch;
            Int16[] ch2 = new Int16[1000];
            Int16[] ch3 = new Int16[1000];
            Int16[] ch4 = new Int16[1000];

            ch = par.ToCharArray();
            

            for (int i = 0; i < ch.Length; i++) 
            {
                ch2[i] = Convert.ToInt16(ch[i]);// transforma em int16
                ch3[i] = Cripta(ch2[i]); // cripta e guarda em ch3

                richTextBox1.Text = richTextBox1.Text  + Convert.ToChar(ch3[i]); ; // mostra
                ch4[i] = DesCripta(ch3[i]); // descripta e guarda em ch4

                textBox2.Text = textBox2.Text + Convert.ToChar(ch4[i]);


            } 


        }
    }
}
