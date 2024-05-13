using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Gamesky
{
    public partial class HangMan : Window
    {
        public HangMan()
        {
            InitializeComponent();
        }

        public string[] words = { "MARVEL", "ROCKET", "WISELY", "SYMBOL", "PENCIL", "JUNGLE", "WIZARD", "OXYGEN", "MYTHIC", "ANCHOR", "BOXERS", "CASTLE", "PLANET", "GARDEN", "FLOWER" };
        public Random rnd = new Random();
        public string choosen_word;
        public char letter;

        public int rnd_num;
        public string random_word;

        public int help_for_punishment = 1;
        public int num_of_cor_letters = 0;
        public int num_of_incor_letters = 0;
        public int list_pismena;
        public int num_of_win = 0;
        public string zadana_pis;
        public List<char> pismenka_co_zadal = new List<char>();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            grey_block.Visibility = Visibility.Hidden;
            gray_block2.Visibility = Visibility.Visible;
            start_text_label.Visibility = Visibility.Hidden;
            clona.Visibility = Visibility.Hidden;
            cor_or_wrong.Visibility = Visibility.Visible;
            letter_textBox.Visibility = Visibility.Visible;
            over_btn.Visibility = Visibility.Visible;
            rnd_num = rnd.Next(0, 14);
            start.Visibility = Visibility.Hidden;
            random_word = words[rnd_num];
            //napoveda.Text = random_word;
            warnning.Visibility = Visibility.Hidden;
            letterBox_1.Text = "";
            letterBox_2.Text = "";
            letterBox_3.Text = "";
            letterBox_4.Text = "";
            letterBox_5.Text = "";
            letterBox_6.Text = "";
            letter_textBox.Text = "";
        }
        private void over_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain = new MainWindow();
            letter = char.Parse(letter_textBox.Text);

            pismenka_co_zadal.Add(letter);

            zadane_pismena.Text = string.Join(", ", pismenka_co_zadal);

            List<char> pismena = new List<char>();
            object[] boxy = { letterBox_1.Text, letterBox_2.Text, letterBox_3.Text, letterBox_4.Text, letterBox_5.Text, letterBox_6.Text };

            for (int i = 1; i <= 6; i++)
            {
                if (letter == random_word[i - 1])
                {
                    switch (i)
                    {
                        case 1:
                            {
                                letterBox_1.Text = letter.ToString();
                                break;
                            }
                        case 2:
                            {
                                letterBox_2.Text = letter.ToString();
                                break;
                            }
                        case 3:
                            {
                                letterBox_3.Text = letter.ToString();
                                break;
                            }
                        case 4:
                            {
                                letterBox_4.Text = letter.ToString();
                                break;
                            }
                        case 5:
                            {
                                letterBox_5.Text = letter.ToString();
                                break;
                            }
                        case 6:
                            {
                                letterBox_6.Text = letter.ToString();
                                break;
                            }
                        default:
                            break;
                    }
                    num_of_cor_letters++;
                    foreach (var item in pismena)
                    {
                        if (letter == item)
                        {
                            list_pismena++;
                        }
                    }
                    if (list_pismena == 0)
                    {
                        pismena.Add(letter);
                    }
                }
                else if (letter != random_word[i - 1])
                {
                    num_of_incor_letters++;
                }
            }
            if (num_of_cor_letters > 0)
            {
                cor_or_wrong.Background = Brushes.LightGreen;
                cor_or_wrong.Text = "CORRECT";
                num_of_win++;
            }
            else
            {
                switch (help_for_punishment)
                {
                    case 1:
                        {
                            podstava.Visibility = Visibility.Visible;
                            break;
                        }
                    case 2:
                        {
                            tram_1.Visibility = Visibility.Visible;
                            break;
                        }
                    case 3:
                        {
                            tram_2.Visibility = Visibility.Visible;
                            break;
                        }
                    case 4:
                        {
                            podpera.Visibility = Visibility.Visible;
                            break;
                        }
                    case 5:
                        {
                            rope.Visibility = Visibility.Visible;
                            break;
                        }
                    case 6:
                        {
                            man_head.Visibility = Visibility.Visible;
                            break;
                        }
                    case 7:
                        {
                            man_body.Visibility = Visibility.Visible;
                            break;
                        }
                    case 8:
                        {
                            man_L_arm.Visibility = Visibility.Visible;
                            break;
                        }
                    case 9:
                        {
                            man_R_arm.Visibility = Visibility.Visible;
                            break;
                        }
                    case 10:
                        {
                            man_L_leg.Visibility = Visibility.Visible;
                            break;
                        }
                    case 11:
                        {
                            man_R_leg.Visibility = Visibility.Visible;
                            Thread.Sleep(1200);
                            sad_emoji.Visibility = Visibility.Visible;
                            MessageBox.Show("SMŮLA PROHRÁL JSI :DDDDD");
                            Thread.Sleep(3000);
                            this.Close();
                            objMain.Show();
                            break;
                        }
                    default:
                        break;
                }
                help_for_punishment++;
                cor_or_wrong.Background = Brushes.Red;
                cor_or_wrong.Text = "WRONG";
            }
            num_of_cor_letters = 0;
            if (num_of_win == 6)
            {
                gigachad.Visibility = Visibility.Visible;
                winner_text.Visibility = Visibility.Visible;
                MessageBox.Show("GRATULUJI VYHRÁL JSI!!!!!!!!!!");
                this.Close();
                objMain.Show();
            }
            letter_textBox.Text = "";
            list_pismena = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain = new MainWindow();
            this.Close();
            objMain.Show();

        }
    }
}
