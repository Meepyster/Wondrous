/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Ability_Data.AbilityFiles
{
    class DefaultAttack : Ability
    {
        Character[] allyList;
        Character[] enemyList;
        int castIndex;
        int targetIndex;
        public DefaultAttack (Character[] allyList, Character[] enemyList, int castIndex, int targetIndex) : base()
        {
            this.allyList = allyList;
            this.enemyList = enemyList;
            this.castIndex = castIndex;
            this.targetIndex = targetIndex;
        }
        
        public override void Cast() {
            enemyList[targetIndex].set_hp(enemyList[targetIndex].get_hp() - 100);
        }
    }
}*/
