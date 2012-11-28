using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TheGame
{
    class CharactersViewModel
    {
        public CharactersViewModel()
        {
            // TODO: replace me
            CharacterList = new ObservableCollection<Character>();
           CharacterList.Add(new Character { Name = "First", Dexterity = 3, Constitution = 5, Strength = 2, Endurance = 3, CurHealthPoints = 50} );
           CharacterList.Add(new Character { Name = "Second", Dexterity = 10, Constitution = 5, Strength = 4, Endurance = 5, CurHealthPoints = 50 });
        }
        public ObservableCollection<Character> CharacterList { get; private set; }
    }
}
