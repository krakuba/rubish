using System;

namespace ZadRPG.Interfaces
{
    public interface ICharacter
    {
        void NewCharacter(string name);

        int CubeThrow();
        void VitalityChanger(int SumOfChange);
    }
}