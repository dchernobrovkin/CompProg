using System.Windows;
using System.Windows.Media;
using System;

namespace TheGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CharactersViewModel m_CharactersViewModel;

        private Battle NewBat;

        public string def;

        public string attack;

        private string resp;

        public MainWindow()
        {
            InitializeComponent();
            Client.Start();
           
            m_CharactersViewModel = new CharactersViewModel();

      
            //cmbCharacterLhs.DataContext = m_CharactersViewModel.CharacterList;
            //cmbCharacterRhs.DataContext = m_CharactersViewModel.CharacterList;

            var character = new CharactersViewModel().CharacterList[0];

            //if (character != null)
            //{
            lblNameValueLhs.Content = character.Name;
            lblAttackValueLhs.Content = character.Attack;
            lblEnduraceValueLhs.Content = character.Endurance;
            lblConstitutionValueLhs.Content = character.Constitution;
            lblDexterityValueLhs.Content = character.Dexterity;
            maxHP1.Content = character.MaxHealthPoints;
           

            var character2 = new CharactersViewModel().CharacterList[1];

            //if (character != null)
            //{
            lblNameValueRhs.Content = character2.Name;
            lblAttackValueRhs.Content = character2.Attack;
            lblEnduraceValueRhs.Content = character2.Endurance;
            lblConstitutionValueRhs.Content = character2.Constitution;
            lblDexterityValueRhs.Content = character2.Dexterity;
            maxHP2.Content = character2.MaxHealthPoints;
            curHP2.Content = Client.sHP;

            NewBat = new Battle();
            
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public void Conn(object sender, RoutedEventArgs e)
        {
            
            var charFORsend = new CharactersViewModel().CharacterList[0];
            var paramFORsend = charFORsend.Attack + ";" + charFORsend.CurHealthPoints + ";" + charFORsend.Damage_Reduction+";"+charFORsend.Evasion;
            Client.SendMSG(paramFORsend);
            button1.IsEnabled = true;
            button6.IsEnabled = false;
            button7.IsEnabled = true;
        }

        public void Discon(object sender, RoutedEventArgs e)
        {

            Client.sender.Shutdown(System.Net.Sockets.SocketShutdown.Both);
            Client.sender.Close();
            button1.IsEnabled = false;
            button6.IsEnabled = false;
            button7.IsEnabled = true;
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            resp = "";
              //  NewBat.OneRound(m_CharactersViewModel.CharacterList[0], m_CharactersViewModel.CharacterList[1]);
              //  Console.WriteLine(m_CharactersViewModel.CharacterList[0].CurHealthPoints);
              //  Console.WriteLine(m_CharactersViewModel.CharacterList[1].CurHealthPoints);
              //  textBox1.Text += m_CharactersViewModel.CharacterList[0].CurHealthPoints.ToString() + '\n';
              //  textBox1.Text += m_CharactersViewModel.CharacterList[1].CurHealthPoints.ToString() + '\n';

                if (m_CharactersViewModel.CharacterList[0].CurHealthPoints < 1 || m_CharactersViewModel.CharacterList[1].CurHealthPoints < 1)
                {
                    button1.IsEnabled = false;
                }

                if (headAt.IsChecked == true) { Console.WriteLine(1); resp += "head"; attack = "head"; }
                if (bodyAt.IsChecked == true) { Console.WriteLine(2); resp += "body"; attack = "body"; }
                if (handsAt.IsChecked == true) { Console.WriteLine(3); resp += "hands"; attack = "hands"; }
                if (legsAt.IsChecked == true) { Console.WriteLine(4); resp += "legs"; attack = "legs"; }

                resp += "|";

                if (headDef.IsChecked == true) { Console.WriteLine(1); resp += "head"; def = "head"; }
                if (bodyDef.IsChecked == true) { Console.WriteLine(2); resp += "body"; def = "body"; }
                if (handsDef.IsChecked == true) { Console.WriteLine(3); resp += "hands"; def = "hands"; }
                if (legsDef.IsChecked == true) { Console.WriteLine(4); resp += "legs"; def = "legs"; }

                Client.SendMSG(resp);
                
               // label5.Content = Client.sHP;
                textBox1.Text += Client.fHP + '\n';
                textBox1.Text += Client.sHP + '\n';
                curHP1.Content = Client.fHP;
                curHP2.Content = Client.sHP;
                Client.RecieveVOID();
            
        }

        private void Create_Char(object sender, RoutedEventArgs e)
        {
            CharCreation f2 = new CharCreation(this);
            this.Hide();
            f2.Show();
        }

        private void Select_Char(object sender, RoutedEventArgs e)
        {
            resp = "!";
            Client.SendMSG(resp);
        }

        private void cmbCharacterLhs_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var character = new CharactersViewModel().CharacterList[1];

            //if (character != null)
            //{
                lblNameValueLhs.Content = character.Name;
                lblAttackValueLhs.Content = character.Attack;
                lblEnduraceValueLhs.Content = character.Endurance;
                lblConstitutionValueLhs.Content = character.Constitution;
                lblDexterityValueLhs.Content = character.Dexterity;
                maxHP1.Content = character.CurHealthPoints;
                
            //}
            //else
            //{
            //    lblNameValueLhs.Content = "";
            //    lblAttackValueLhs.Content = 0;
            //    lblEnduraceValueLhs.Content = 0;
            //    lblConstitutionValueLhs.Content = 0;
            //    lblDexterityValueLhs.Content = 0;
            //    lblHealthPointsValueLhs.Content = 0;
            //    lblLevelPointsValueLhs.Content = 0;
            //}
        }


        //private void cmbCharacterRhs_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        //{
        //    var character = (Character)cmbCharacterRhs.SelectedItem;

        //    if (character != null)
        //    {
        //        lblNameValueRhs.Content = character.Name;
        //        lblAttackValueRhs.Content = character.Attack;
        //        lblEnduraceValueRhs.Content = character.Endurance;
        //        lblConstitutionValueRhs.Content = character.Constitution;
        //        lblDexterityValueRhs.Content = character.Dexterity;
        //        lblHealthPointsValueRhs.Content = character.HealthPoints;
        //        lblLevelPointsValueRhs.Content = character.Level;
        //    }
        //    else
        //    {
        //        lblNameValueRhs.Content = "";
        //        lblAttackValueRhs.Content = 0;
        //        lblEnduraceValueRhs.Content = 0;
        //        lblConstitutionValueRhs.Content = 0;
        //        lblDexterityValueRhs.Content = 0;
        //        lblHealthPointsValueRhs.Content = 0;
        //        lblLevelPointsValueRhs.Content = 0;
        //    }
        //}
    }
}
