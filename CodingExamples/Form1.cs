using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingExamples {
    public partial class Form1 : Form {

        
        public Form1() {
            InitializeComponent();

            int x = 1;
            int y = 2;
            int result = x + y;
            int result1 = x - y;
            int result2 = x * y;
            int result3 = x / y;
            int result4 = x % y; //used to determine a even or an odd number
            int result5 = +x + -y;
            int result6 = x++; //adds one to value in variable 
            int result7 = y--; //removes one from value in variable


            decimal discountPercent = .2m;
            decimal price = 100m;
            price = price * (1 - discountPercent);

            double a = 95.0;
            int b = 86, c = 91;
            double average = (a + b + c / 3);




            Console.WriteLine();
        }

    }
}
