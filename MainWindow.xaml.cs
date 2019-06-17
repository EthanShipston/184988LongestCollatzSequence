/* Ethan Shipston
 * June 17, 2019
 * ICS4U
 * A program which finds the longest collatz sequence below one million.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _184988LongestCollatzSequence
{
    /// <summary>
    /// longeraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            long dep = 1000000;
            long n = 0;
            long seed = 0;
            long count = 0;

            for (long i = 837799; i <= dep; i++)
            {
                n = i;
                long tempseed = n;
                long tempcount = 0;
                for (long ii = 1; ii < 1000000; ii++)
                {
                    if (ii == 58)
                    {

                    }
                    if (n == 1)
                        ii = dep;

                    else
                    {
                        if (n % 2 == 0)
                        {
                            n = n / 2;
                        }
                        else
                        {
                            n = (3 * n) + 1;
                        }
                    }
                    tempcount++;


                }

                if (count < tempcount)
                {
                    seed = tempseed;
                    count = tempcount;
                }
            }
            MessageBox.Show(seed + " count: " + count);
        }
    }
}
