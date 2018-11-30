using PaloItChallenge.DataAccess;
using PaloItChallenge.Helpers;
using PaloItChallenge.Models;

namespace PaloItChallenge.Services
{
    public class BusinessService : IBusinessService
    {
        private IDataAccess _dataAccess;
        public BusinessService(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void SaveFullName(FullName fullName)
        {
            _dataAccess.SaveFullName(fullName);
        }

        public int GetMaxNumOfConsecutiveZerosFromAsciiValueSum(FullName fullName)
        {
            int sumOfAsciiValues = AsciiHelper.SumAsciiValuesInString($"{fullName.FirstName} {fullName.LastName}");
            string sumOfAsciiValuesAsBinaryString = AsciiHelper.ConvertNumToBinaryString(sumOfAsciiValues);
            int maxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(sumOfAsciiValuesAsBinaryString);
            return maxNumOfConsecutiveZeros;
        }
    }
}