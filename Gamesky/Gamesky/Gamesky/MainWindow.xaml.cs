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

namespace Gamesky
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void hangman_Click(object sender, RoutedEventArgs e)
        {
            HangMan objHangMan = new HangMan();
            this.Close();
            objHangMan.Show();
        }

        private void tic_tac_toe_Click(object sender, RoutedEventArgs e)
        {
            TicTacToe objTicTacToe = new TicTacToe();
            this.Close();
            objTicTacToe.Show();
        }
    }
}
