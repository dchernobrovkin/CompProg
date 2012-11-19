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
            CharacterList.Add(new Character { Name = "First", Level = 1, Dexterity = 3, Constitution = 2, Attack = 2, Endurance = 1 } );
            CharacterList.Add(new Character { Name = "Second", Level = 3, Dexterity = 10, Constitution = 5, Attack = 4, Endurance = 5 });
        }
        public ObservableCollection<Character> CharacterList { get; private set; }
    }
}
