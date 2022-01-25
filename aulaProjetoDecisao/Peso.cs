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
    public partial class Peso : Form
    {
        public Peso()
        {
            InitializeComponent();
        }

        private void Peso_Load(object sender, EventArgs e)
        {
        }

        private void BtnPesoJoaoMaria_Click(object sender, EventArgs e)
        {
            float pesoJoao, pesoMaria;

            pesoJoao = 110.00f;
            pesoMaria = 120.00f;

            if (pesoJoao > pesoMaria)
                MessageBox.Show(" Peso Joao > que Peso Maria");
            else if (pesoMaria > pesoJoao)
                MessageBox.Show("Peso da Maria é maior que o peso do João");
            else
                MessageBox.Show(" Os dois possuem o mesmo peso ");

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            float varPeso1, varPeso2,varDiferenca,varImc;
            float varAltura1, varAltura2;
                        
            varPeso1 = Convert.ToSingle(txtPeso1.Text);
            varPeso2 = Convert.ToSingle(txtPeso2.Text);
            varAltura1 = Convert.ToSingle(txtAltura1.Text);
            varAltura2 = Convert.ToSingle(txtAltura2.Text);


            if (varPeso1 > varPeso2)
            {
                varDiferenca = varPeso1 - varPeso2;
                varImc = varPeso1 / (varAltura1 * varAltura1);
                MessageBox.Show(" Peso maior: " + txtNome1.Text + " Diferença " + varDiferenca);
                MessageBox.Show(" IMC : " + varImc);
            }
            else
            {
                varImc = varPeso2 / (varAltura2 * varAltura2);
                varDiferenca = varPeso2 - varPeso1;
                MessageBox.Show("Peso maior: " + txtNome2.Text + " Diferença " + varDiferenca);
                MessageBox.Show(" IMC : " + varImc);
            }

            if (varImc < 17)
                MessageBox.Show("Muito abaixo do peso");
            else if (varImc <= 18.49)
                MessageBox.Show("Abaixo do peso");
            else if (varImc <= 24.99)
                MessageBox.Show("Peso Normal");
            else if (varImc <= 29.99)
                MessageBox.Show(" Acima do peso");
            else if (varImc <= 34.99)
                MessageBox.Show(" Obesidade I");
            else if (varImc <= 39.99)
                MessageBox.Show(" Obesidade II");
            else
                MessageBox.Show(" Obesidade III");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAltura1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
