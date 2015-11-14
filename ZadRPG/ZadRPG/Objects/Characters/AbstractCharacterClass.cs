using System;
using System.Dynamic;
using ZadRPG.Interfaces;

namespace ZadRPG.Objects.Characters
{
    public abstract class AbstractCharacterClass : ICharacter
    {
        protected string CharacterName { get; set; }
        protected int VitalityPoints { get; set; }

        protected AbstractCharacterClass()
        {
            
        }

        protected AbstractCharacterClass(string name)
        {
            CharacterName = name;
            VitalityPoints = 100;
        }

        public void NewCharacter(string name)
        {
            throw new NotImplementedException();
        }

        public int CubeThrow()
        {
            var cubeRandom = new Random();
            return cubeRandom.Next(0, 6);
        }

        public void VitalityChanger(int SumOfChange)
        {
            if ((VitalityPoints = +SumOfChange) > 0 && (VitalityPoints =+SumOfChange) <= 100)
            {
                VitalityPoints = +SumOfChange;
            }
            else
            {
                VitalityPoints = (VitalityPoints = +SumOfChange) > 100 ? 100 : 0;
            }
        }
    }
}