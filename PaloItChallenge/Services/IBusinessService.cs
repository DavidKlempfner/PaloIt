using PaloItChallenge.Models;

namespace PaloItChallenge.Services
{
    public interface IBusinessService
    {
        void SaveFullName(FullName fullName);
        int GetMaxNumOfConsecutiveZerosFromAsciiValueSum(FullName fullName);
    }
}
