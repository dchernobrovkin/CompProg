using System.Windows;
using System.Windows.Media;

namespace TheGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CharactersViewModel m_CharactersViewModel;

        public MainWindow()
        {
            InitializeComponent();

            m_CharactersViewModel = new CharactersViewModel();

            cmbCharacterLhs.DataContext = m_CharactersViewModel.CharacterList;
            cmbCharacterRhs.DataContext = m_CharactersViewModel.CharacterList;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void cmbCharacterLhs_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var character = (Character)cmbCharacterLhs.SelectedItem;

            if (character != null)
            {
                lblNameValueLhs.Content = character.Name;
                lblAttackValueLhs.Content = character.Attack;
                lblEnduraceValueLhs.Content = character.Endurance;
                lblConstitutionValueLhs.Content = character.Constitution;
                lblDexterityValueLhs.Content = character.Dexterity;
                lblHealthPointsValueLhs.Content = character.HealthPoints;
                lblLevelPointsValueLhs.Content = character.Level;
            }
            else
            {
                lblNameValueLhs.Content = "";
                lblAttackValueLhs.Content = 0;
                lblEnduraceValueLhs.Content = 0;
                lblConstitutionValueLhs.Content = 0;
                lblDexterityValueLhs.Content = 0;
                lblHealthPointsValueLhs.Content = 0;
                lblLevelPointsValueLhs.Content = 0;
            }
        }

        private void cmbCharacterRhs_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var character = (Character)cmbCharacterRhs.SelectedItem;

            if (character != null)
            {
                lblNameValueRhs.Content = character.Name;
                lblAttackValueRhs.Content = character.Attack;
                lblEnduraceValueRhs.Content = character.Endurance;
                lblConstitutionValueRhs.Content = character.Constitution;
                lblDexterityValueRhs.Content = character.Dexterity;
                lblHealthPointsValueRhs.Content = character.HealthPoints;
                lblLevelPointsValueRhs.Content = character.Level;
            }
            else
            {
                lblNameValueRhs.Content = "";
                lblAttackValueRhs.Content = 0;
                lblEnduraceValueRhs.Content = 0;
                lblConstitutionValueRhs.Content = 0;
                lblDexterityValueRhs.Content = 0;
                lblHealthPointsValueRhs.Content = 0;
                lblLevelPointsValueRhs.Content = 0;
            }
        }
    }
}
