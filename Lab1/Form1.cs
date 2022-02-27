using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Numerics;

namespace Lab1
{
    public static class Factorial
    {
        private static BigInteger N;
        private static Form1 Form;
        private static Thread CalcThread = new Thread(Calc);

        public static void StartCalc(Form1 form, int n)
        {
            N = (BigInteger) n;
            Form = form;

            CalcThread = new Thread(Calc);
            CalcThread.Start();
        }

        public static void StopCalc()
        {
            CalcThread.Abort();
        }

        private static void Calc()
        {
            BigInteger res = 1;

            for (BigInteger i = 2; i <= N; i++) {
                res *= i;
                Form1.FactorialCallback(Form, (int) (100 * i / N), 0);
            }

            Form1.FactorialCallback(Form, 100, res);
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FactorialLabel.Text = FactorialTrackBar.Value.ToString();
        }




        public static void FactorialCallback(Form1 form, int percent, BigInteger res)
        {
            if (form.InvokeRequired) {
                form.Invoke((Action<Form1, int, BigInteger>)FactorialCallback, form, percent, res);
            }
            else {
                form.FactorialProgressBar.Value = percent;
                if (res != 0) {
                    form.ResultLabel.Text = /*"Результат : " +*/ res.ToString();
                }
            }
        }

        private void FactorialTrackBar_Scroll(object sender, EventArgs e)
        {
            Factorial.StopCalc();

            FactorialLabel.Text = FactorialTrackBar.Value.ToString();

            Factorial.StartCalc(this, FactorialTrackBar.Value);
        }
    }
}
