using ZadRPG.Interfaces;

namespace ZadRPG.Objects.Characters
{
    public class CharacterSorcerer : AbstractCharacterClass, ISorcerer
    {
        private int StrengthPoints { get; set; }
        private int MagicPoints { get; set; }

        public CharacterSorcerer(string name, int strPoints, int magPoints) : base(name)
        {
            StrengthPoints = strPoints;
            MagicPoints = magPoints;
        }

        public CharacterSorcerer()
        {
            CharacterName = "Gandalf";
            VitalityPoints = 100;
            for (var i = 1; i < 3; i++)
            {
                MagicPoints = CubeThrow();
            }
            StrengthPoints = CubeThrow();
        }

        public int StandardMagicBall()
        {
            return (StrengthPoints+MagicPoints)*VitalityPoints/100;
        }
    }
}