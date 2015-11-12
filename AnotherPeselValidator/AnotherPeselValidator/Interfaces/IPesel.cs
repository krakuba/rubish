using AnotherPeselValidator.ObjectBasis;

namespace AnotherPeselValidator.Interfaces
{
    public interface IPesel
    {
        void CheckPesel(Pesel p);
        bool CheckBirthDay(Pesel p);
        bool CheckBirthMonth(Pesel p);
        bool CheckControlSum(Pesel p);
    }
}