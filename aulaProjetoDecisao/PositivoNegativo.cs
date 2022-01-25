using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaProjetoDecisao
{
    public partial class PositivoNegativo : Form
    {
        public PositivoNegativo()
        {
            InitializeComponent();
        }

        private void BtnVerifica_Click(object sender, EventArgs e)
        {
            int varNumero;

            varNumero = Convert.ToInt16( txtNumero.Text );

            if (varNumero > 0)
                MessageBox.Show(" Numero Positivo");
            else
                MessageBox.Show(" Não é maior que zero \n Numero Negativo");
            
           // if (varNumero < 0)
           //     MessageBox.Show("Numero Negativo");

                  }

        private void BtnVerificaMaiorMenor_Click(object sender, EventArgs e)
        {
            int varNum1, varNum2;

            varNum1 = Convert.ToInt16(txtNum1.Text);
            varNum2 = Convert.ToInt16(txtNum2.Text);

            if ( varNum1 > varNum2)
                MessageBox.Show( varNum1 + " é maior que " + varNum2);
            else
                MessageBox.Show( varNum2 + " é maior que " + varNum1);


        }

        private void BtnParImpar_Click(object sender, EventArgs e)
        {
            //  11 / 2 = 5  sobra 1 // impar
            //  10 / 2 = 5  sobra 0 // par
            //  22 / 2 = 11 sobra 0 // par
            // regra ao dividir por 2 sobra 0 então é par.

            int numero , resto, result;

            numero = Convert.ToInt16(txtNumero.Text);

            result = numero / 2; // traz o quociente 5

            resto = numero % 2;  // Traz o resto a sobra 0.

            if (resto == 0)  // == significa comparação
                MessageBox.Show(" Resto = " + resto + " entao par");
            else
                MessageBox.Show("Resto " + resto + " Impar ");







          






        }
    }
}
