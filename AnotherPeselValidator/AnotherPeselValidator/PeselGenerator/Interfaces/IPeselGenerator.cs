using System.Collections.Generic;

namespace AnotherPeselValidator.PeselGenerator.Interfaces
{
    public interface IPeselGenerator
    {

        string GeneratingDateOfBirth();
        string GeneratingRestOfPeselNumbers();

    }
}