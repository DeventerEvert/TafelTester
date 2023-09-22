using classLibraryForSums;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for hardWindow.xaml
    /// </summary>
    public partial class hardWindow : Window
    {
        private int generatedResult;
        private int generatedScore;
        public int score = 0;
        public hardWindow()
        {
            InitializeComponent();

            scoreLabel.Content = score;

            randomSumGenerator generator = new randomSumGenerator();

            string randomSum = generator.generateHardRandomSum(out generatedResult);

            hardSum.Text = randomSum;
        }

        private void calcBtn_Click(object sender, RoutedEventArgs e)
        {

            string userInput = inputBox.Text.Trim();

            if (string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("Voer iets in!");
            }
            else
            {
                if (int.TryParse(userInput, out int inputResult))
                {
                    if (inputResult == generatedResult)
                    {
                        score++;
                        MessageBox.Show("Goed gedaan!");
                        inputBox.Text = "";

                        randomSumGenerator generator = new randomSumGenerator();
              
                        string randomSum = generator.generateHardRandomSum(out generatedResult);
                        hardSum.Text = randomSum;

                        scoreLabel.Content = score;
                    }
                    else if (inputResult != generatedResult)
                    {
                        MessageBox.Show("Dit is fout, probeer opniew!");
                        score = 0;
                        scoreLabel.Content = score;
                    }
                }
            }
        }
    }

}

