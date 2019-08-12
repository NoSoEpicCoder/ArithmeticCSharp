using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            int firstNumber = 10;
            int secondNumber = 32;
            int integerAnswer = firstNumber + secondNumber;

            MessageBox.Show(integerAnswer.ToString());
        }

        private void BtnAddFloats_Click(object sender, EventArgs e) {
            float firstNumber = 10.5F;
            float secondNumber = 32.5F;
            float floatAnswer = firstNumber + secondNumber;

            MessageBox.Show(floatAnswer.ToString());
        }

        private void BtnSubtract_Click(object sender, EventArgs e) {
            int answerSubtract = 50 - 25;

            MessageBox.Show(answerSubtract.ToString());
        }

        private void BtnMixed_Click(object sender, EventArgs e) {
            int firstNumber = 100;
            int secondNumber = 75;
            int thirdNumber = 50;
            int answer = firstNumber + (secondNumber - thirdNumber);

            MessageBox.Show(answer.ToString());
        }
    }
}
