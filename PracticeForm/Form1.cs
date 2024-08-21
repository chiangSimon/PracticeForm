using If_greater_than_third_one;
using If_sorted_ascending;
using Positive_NegativeorZero;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PracticeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        static bool UppercaseLetters(string str)
        {
            if ((str[0] >= 65 && str[1]>=65 && str[2] >= 65) && (str[0] <=90 && str[1]<=90 && str[2]<=90))
            {
                return true;
            }
            return false;

        }

        private void btnUppercaseLetters_Click(object sender, EventArgs e)
        {
            Trace.WriteLine(UppercaseLetters("abc"));
            Trace.WriteLine(UppercaseLetters("CCC"));
            Trace.WriteLine(UppercaseLetters("123"));
        }

        private void btnGeaterThanThirdOne_Click(object sender, EventArgs e)
        {
            GreaterThanThirdOneTask GTTO = new GreaterThanThirdOneTask();
            Console.WriteLine(GTTO.IfGreaterThanThirdOne(new int[] {2,7,12 }));
            Console.WriteLine(GTTO.IfGreaterThanThirdOne(new int[] {-5, -8, 50 }));
        }

        private void btnIfSortedAscending_Click(object sender, EventArgs e)
        {
            int[] myarray1 = new int[] {1,2,3};
            int[] myarray2 = new int[] { 3, 7, 10 };
            ISAclass ISA = new ISAclass();
            Console.WriteLine(ISA.IfSortedAsceeding(myarray1));
            Console.WriteLine(ISA.IfSortedAsceeding(myarray2));
            Console.WriteLine(ISA.IfSortedAsceeding(new int[] { 74,62,99}));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PNZclass pz = new PNZclass();
            Console.WriteLine(pz.PNZ(5.24));
            Console.WriteLine(pz.PNZ(0.0));
            Console.WriteLine(pz.PNZ(-994.53));

        }
    }
}
