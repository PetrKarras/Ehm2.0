using System;
using System.Collections.Generic;
using System.Text;

namespace Mortal_Kombat
{
    class Player
    {
        private int hp;
        private int attackmax;
        private int attackmin;
        private int deff;
        private string name;

        public int HP { get { return hp; } set { hp -= value; } }
        public int AttackMax { get { return attackmax; } }
        public int AttackMin { get { return attackmin; } }
        public int Deff { get { return deff; } }
        public string Name { get { return name; } }

        public Player(int _attackMax, int _attackMin, int _deff, string _name)
        {
            hp = 100;
            attackmax = _attackMax;
            attackmin = _attackMin;
            deff = _deff;
            name = _name;
        }
        public Player()
        {

        }
        public override string ToString()
        {
            return $"{name}: ♥  {hp}";
        }
        public void RestoreHP()
        {
            hp = 100;
        }
    
    }
}
