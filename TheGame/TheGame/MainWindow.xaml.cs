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

        public MainWindow()
        {
            InitializeComponent();
            
           
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
            //curHP1.Content = character.CH;

            var character2 = new CharactersViewModel().CharacterList[1];

            //if (character != null)
            //{
            lblNameValueRhs.Content = character2.Name;
            lblAttackValueRhs.Content = character2.Attack;
            lblEnduraceValueRhs.Content = character2.Endurance;
            lblConstitutionValueRhs.Content = character2.Constitution;
            lblDexterityValueRhs.Content = character2.Dexterity;
            maxHP2.Content = character2.MaxHealthPoints;
           // curHP2.Content = character2.CH;

            NewBat = new Battle();
            
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        
        private void button1_Click(object sender, RoutedEventArgs e)
        {          
                NewBat.OneRound(m_CharactersViewModel.CharacterList[0], m_CharactersViewModel.CharacterList[1]);
                Console.WriteLine(m_CharactersViewModel.CharacterList[0].CurHealthPoints);
                Console.WriteLine(m_CharactersViewModel.CharacterList[1].CurHealthPoints);
                textBox1.Text += m_CharactersViewModel.CharacterList[0].CurHealthPoints.ToString() + '\n';
                textBox1.Text += m_CharactersViewModel.CharacterList[1].CurHealthPoints.ToString() + '\n';

                if (m_CharactersViewModel.CharacterList[0].CurHealthPoints < 1 || m_CharactersViewModel.CharacterList[1].CurHealthPoints < 1)
                {
                    button1.IsEnabled = false;
                }
            
        }

        private void cmbCharacterLhs_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var character = new CharactersViewModel().CharacterList[0];

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
