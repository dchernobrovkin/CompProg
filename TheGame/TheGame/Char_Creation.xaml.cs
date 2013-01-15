using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Xml;
using System.Data.SqlClient;

namespace TheGame
{
    /// <summary>
    /// Логика взаимодействия для CharCreation.xaml
    /// </summary>
    public partial class CharCreation : Window
    {
        public static int Point = 10;



        public CharCreation()
        {
            InitializeComponent();
        }

        private MainWindow _f1;
        public CharCreation(MainWindow f1)
        {
            InitializeComponent();
            _f1 = f1;
        }


        private void BackBut_Click(object sender, EventArgs e)
        {
            _f1.Show();
            this.Close();
        }

        public int SumPoint()
        {
            int temp = Convert.ToInt32(StrVal.Content) + Convert.ToInt32(EndVal.Content) + Convert.ToInt32(ConstVal.Content) + Convert.ToInt32(DexVal.Content);
            return temp;
        }



        private void StrInc_Click(object sender, RoutedEventArgs e)
        {
            if (SumPoint() < 14)
            {
                StrVal.Content = Convert.ToInt32(StrVal.Content) + 1;
                PointsVal.Content = Convert.ToInt32(PointsVal.Content) - 1;
            }

        }
        private void StrDec_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(StrVal.Content) > 1)
            {
                StrVal.Content = Convert.ToInt32(StrVal.Content) - 1;
                PointsVal.Content = Convert.ToInt32(PointsVal.Content) + 1;
            }


        }
        private void EndInc_Click(object sender, RoutedEventArgs e)
        {
            if (SumPoint() < 14)
            {
                EndVal.Content = Convert.ToInt32(EndVal.Content) + 1;
                PointsVal.Content = Convert.ToInt32(PointsVal.Content) - 1;
            }
        }
        private void EndDec_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(EndVal.Content) > 1)
            {
                EndVal.Content = Convert.ToInt32(EndVal.Content) - 1;
                PointsVal.Content = Convert.ToInt32(PointsVal.Content) + 1;
            }
        }
        private void ConstInc_Click(object sender, RoutedEventArgs e)
        {
            if (SumPoint() < 14)
            {
                ConstVal.Content = Convert.ToInt32(ConstVal.Content) + 1;
                PointsVal.Content = Convert.ToInt32(PointsVal.Content) - 1;
            }
        }
        private void ConstDec_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(ConstVal.Content) > 1)
            {
                ConstVal.Content = Convert.ToInt32(ConstVal.Content) - 1;
                PointsVal.Content = Convert.ToInt32(PointsVal.Content) + 1;
            }
        }
        private void DexInc_Click(object sender, RoutedEventArgs e)
        {
            if (SumPoint() < 14)
            {
                DexVal.Content = Convert.ToInt32(DexVal.Content) + 1;
                PointsVal.Content = Convert.ToInt32(PointsVal.Content) - 1;
            }
        }
        private void DexDec_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(DexVal.Content) > 1)
            {
                DexVal.Content = Convert.ToInt32(DexVal.Content) - 1;
                PointsVal.Content = Convert.ToInt32(PointsVal.Content) + 1;
            }
        }
        private void SecrBut_Click(object sender, RoutedEventArgs e)
        {
            string connStr = @"Data Source=(local);
                                        Initial Catalog=test;
                                        Integrated Security=SSPI";
            using (var connection = new SqlConnection(connStr))
            {
                connection.Open();

                string qr = "CREATE TABLE Character (Name VARCHAR(255), Str INT, Endur INT, Const INT, Dex INT);";
                var cmd = new SqlCommand(qr, connection);
                cmd.ExecuteNonQuery();
            }
        }


        private void CharCreate_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(PointsVal.Content) == 0 && CharNameTextBox.Text != "")
            {
                Character Char = new Character
                {
                    Name = CharNameTextBox.Text,
                    Dexterity = Convert.ToInt32(DexVal.Content),
                    Constitution = Convert.ToInt32(ConstVal.Content),
                    Strength = Convert.ToInt32(StrVal.Content),
                    Endurance = Convert.ToInt32(EndVal.Content),
                    CurHealthPoints = Convert.ToInt32(ConstVal.Content) * 10
                };
                //CharactersViewModel NewChar = new CharactersViewModel();
                //NewChar.CharacterList.Add(Char);

                string connStr = @"Data Source=(local);
                                        Initial Catalog=test;
                                        Integrated Security=SSPI";
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    var qstr = "INSERT INTO dbo.Character (Name, Str, Endur, Const, Dex) VALUES ('" + CharNameTextBox.Text + "', '" +
                        StrVal.Content + "', '" + EndVal.Content + "', '" + ConstVal.Content + "', '" + DexVal.Content + "');";
                    var cmd = new SqlCommand(qstr, connection);
                    cmd.ExecuteNonQuery();

                }

                _f1.Show();
                this.Close();


            }


        }










    }
}
