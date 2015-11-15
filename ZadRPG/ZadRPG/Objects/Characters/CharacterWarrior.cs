using System;
using System.Collections;
using ZadRPG.Interfaces;

namespace ZadRPG.Objects.Characters
{
    public class CharacterWarrior : AbstractCharacterClass, IWarrior
    { 
        private int StrengthPoints { get; set; }
        public CharacterWarrior(string name, int strPoints) : base(name)
        {
            StrengthPoints = strPoints;

        }

        public CharacterWarrior()
        {
            CharacterName = "Xardas";
            VitalityPoints = 100;
            for (var i = 1; i < 4; i++)
            {
                StrengthPoints = CubeThrow();
            }
        }


        public int NormalAttack()
        {
            if (VitalityPoints >= 5)
            {
                return StrengthPoints*VitalityPoints/100;
            }
                return StrengthPoints;
        }
    }
}