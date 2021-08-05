using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public static class FractionsManager
    {
        public static bool SaveOperation(Fraction fracLeft, string operation, Fraction fracRight, Fraction fractResult)
        {
            if (string.IsNullOrWhiteSpace(operation)) return false;

            string stringFractLeft = fracLeft.ToStringCSV();
            string stringOperation = operation.Trim();
            string stringFractRight = fracRight.ToStringCSV();
            string stringFractResult = fractResult.ToStringCSV();

            CsvFilesManager myCsvFile = new CsvFilesManager();
            return myCsvFile.SaveFractionOperationToFile(stringFractLeft, stringOperation, stringFractRight, stringFractResult);
        }

        public static bool SaveComparison(Fraction fracLeft, string comparison, Fraction fracRight)
        {
            if (string.IsNullOrWhiteSpace(comparison)) return false;

            string stringFractLeft = fracLeft.ToStringCSV();
            string stringComparison = comparison.Trim();
            string stringFractRight = fracRight.ToStringCSV();

            CsvFilesManager myCsvFile = new CsvFilesManager();
            return myCsvFile.SaveFractionComparisonToFile(stringFractLeft, stringComparison, stringFractRight);
        }
    }
}
