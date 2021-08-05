using System;
using System.IO;
using System.Text;

namespace DAL
{
    public class CsvFilesManager
    {
        private const string CSV_OPERATION_FILE_PATH = @".\OperationsFile.csv";
        private const string CSV_COMPARISON_FILE_PATH = @".\ComparisonsFile.csv";

        public bool SaveFractionOperationToFile(string fractLeft, string operation, string fractRight, string fractResult)
        {
            try
            {
                string textToSave;
                string listSeparator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;

                if (string.IsNullOrWhiteSpace(listSeparator)) listSeparator = ";";

                if (!File.Exists(CSV_OPERATION_FILE_PATH))
                {
                    textToSave = "Date" + listSeparator +
                                 "Heure" + listSeparator +
                                 "Fraction 1" + listSeparator +
                                 "Opération" + listSeparator +
                                 "Fraction 2" + listSeparator +
                                 "Résultat" + Environment.NewLine;
                    File.WriteAllText(CSV_OPERATION_FILE_PATH, textToSave, Encoding.UTF8);
                }

                DateTime dateTime = DateTime.Now;
                textToSave = dateTime.ToString("d") + listSeparator +
                             dateTime.ToString("T") + listSeparator +
                             fractLeft + listSeparator +
                             operation + listSeparator +
                             fractRight + listSeparator +
                             fractResult + Environment.NewLine;
                File.AppendAllText(CSV_OPERATION_FILE_PATH, textToSave, Encoding.UTF8);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveFractionComparisonToFile(string fractLeft, string comparison, string fractRight)
        {
            try
            {
                string textToSave;
                string listSeparator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;

                if (string.IsNullOrWhiteSpace(listSeparator)) listSeparator = ";";

                if (!File.Exists(CSV_COMPARISON_FILE_PATH))
                {
                    textToSave = "Date" + listSeparator +
                                 "Heure" + listSeparator +
                                 "Fraction 1" + listSeparator +
                                 "Comparaison" + listSeparator +
                                 "Fraction 2" + Environment.NewLine;
                    File.WriteAllText(CSV_COMPARISON_FILE_PATH, textToSave, Encoding.UTF8);
                }

                DateTime dateTime = DateTime.Now;
                textToSave = dateTime.ToString("d") + listSeparator +
                             dateTime.ToString("T") + listSeparator +
                             fractLeft + listSeparator +
                             comparison + listSeparator +
                             fractRight + Environment.NewLine;
                File.AppendAllText(CSV_COMPARISON_FILE_PATH, textToSave, Encoding.UTF8);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
