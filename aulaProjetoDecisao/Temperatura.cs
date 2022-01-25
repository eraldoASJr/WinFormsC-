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
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        private void txtTempCelsius_TextChanged(object sender, EventArgs e)
        {
            float varTempCel, varTempFar;

            if (txtTempCelsius.Text != "")
            {
                varTempCel = Convert.ToSingle(txtTempCelsius.Text);

                varTempFar = (9 * varTempCel + 160) / 5.0f;

                lblTempFar.Text = Convert.ToString(varTempFar) + "°F";
            }
            else
                lblTempFar.Text = " Informe um valor válido";
        }
    }
}
