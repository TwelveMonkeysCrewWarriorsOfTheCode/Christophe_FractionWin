using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMain : Form
    {
        private const int INDEX_OPERATION_UNDEFINED = -1;
        private const int INDEX_OPERATION_ADD = 0;
        private const int INDEX_OPERATION_SUBTRACT = 1;
        private const int INDEX_OPERATION_MULTIPLY = 2;
        private const int INDEX_OPERATION_DIVIDE = 3;

        private const int INDEX_CMP_UNDEFINED = -1;
        private const int INDEX_CMP_INFERIOR = 0;
        private const int INDEX_CMP_EQUAL = 1;
        private const int INDEX_CMP_SUPERIOR = 2;

        public FrmMain()
        {
            InitializeComponent();
            comboBoxOperator.SelectedIndex = INDEX_OPERATION_ADD;
            comboBoxCmpResult.SelectedIndex = INDEX_CMP_UNDEFINED;
        }

        //
        //
        // Onglet 'Arithmétique'
        //
        //

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NumUpDownNumberLeft.Text)) NumUpDownNumberLeft.Text = "0";
            if (string.IsNullOrEmpty(NumUpDownNumeratorLeft.Text)) NumUpDownNumeratorLeft.Text = "0";
            if (string.IsNullOrEmpty(NumUpDownDenominatorLeft.Text)) NumUpDownDenominatorLeft.Text = "1";

            if (string.IsNullOrEmpty(NumUpDownNumberRight.Text)) NumUpDownNumberRight.Text = "0";
            if (string.IsNullOrEmpty(NumUpDownNumeratorRight.Text)) NumUpDownNumeratorRight.Text = "0";
            if (string.IsNullOrEmpty(NumUpDownDenominatorRight.Text)) NumUpDownDenominatorRight.Text = "1";

            Fraction fracLeft;
            Fraction fracRight;
            Fraction fracResult;

            try
            {
                fracLeft = new Fraction((int)NumUpDownNumberLeft.Value,
                                        (int)NumUpDownNumeratorLeft.Value,
                                        (int)NumUpDownDenominatorLeft.Value);
                fracRight = new Fraction((int)NumUpDownNumberRight.Value,
                                         (int)NumUpDownNumeratorRight.Value,
                                         (int)NumUpDownDenominatorRight.Value);

                switch (comboBoxOperator.SelectedIndex)
                {
                    case INDEX_OPERATION_ADD:
                        fracResult = fracLeft + fracRight;
                        break;
                    case INDEX_OPERATION_SUBTRACT:
                        fracResult = fracLeft - fracRight;
                        break;
                    case INDEX_OPERATION_MULTIPLY:
                        fracResult = fracLeft * fracRight;
                        break;
                    case INDEX_OPERATION_DIVIDE:
                        fracResult = fracLeft / fracRight;
                        break;
                    default: // INDEX_OPERATION_UNDEFINED
                        TxtResultOperation.Text = "Sélectionnez l'opération";
                        return;
                }

                TxtResultOperation.Text = fracResult;
            }
            catch (Exception exc)
            {
                TxtResultOperation.Text = "Erreur";
                MessageBox.Show(exc.Message, "Erreur");
                return;
            }

            bool result = FractionsManager.SaveOperation(fracLeft, comboBoxOperator.Text, fracRight, fracResult);
            if (!result)
            {
                MessageBox.Show("Erreur lors de l'enregistrement du calcul dans le fichier historique.", "Erreur");
            }
        }

        private void ClearResultOperation()
        {
            if (TxtResultOperation.TextLength > 0)
            {
                TxtResultOperation.Clear();
            }
        }

        private void NumUpDownOperation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = true;
            }
            else
            {
                ClearResultOperation();
            }
        }

        private void NumUpDownOperation_ValueChanged(object sender, EventArgs e)
        {
            ClearResultOperation();
        }

        private void comboBoxOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearResultOperation();
        }

        //
        //
        // Onglet 'Comparaison'
        //
        //

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NumUpDownCmpNumberLeft.Text)) NumUpDownCmpNumberLeft.Text = "0";
            if (string.IsNullOrEmpty(NumUpDownCmpNumeratorLeft.Text)) NumUpDownCmpNumeratorLeft.Text = "0";
            if (string.IsNullOrEmpty(NumUpDownCmpDenominatorLeft.Text)) NumUpDownCmpDenominatorLeft.Text = "1";

            if (string.IsNullOrEmpty(NumUpDownCmpNumberRight.Text)) NumUpDownCmpNumberRight.Text = "0";
            if (string.IsNullOrEmpty(NumUpDownCmpNumeratorRight.Text)) NumUpDownCmpNumeratorRight.Text = "0";
            if (string.IsNullOrEmpty(NumUpDownCmpDenominatorRight.Text)) NumUpDownCmpDenominatorRight.Text = "1";

            Fraction fracLeft;
            Fraction fracRight;

            try
            {
                fracLeft = new Fraction((int)NumUpDownCmpNumberLeft.Value,
                                        (int)NumUpDownCmpNumeratorLeft.Value,
                                        (int)NumUpDownCmpDenominatorLeft.Value);
                fracRight = new Fraction((int)NumUpDownCmpNumberRight.Value,
                                         (int)NumUpDownCmpNumeratorRight.Value,
                                         (int)NumUpDownCmpDenominatorRight.Value);

                int resultCmp = fracLeft.CompareTo(fracRight);
                if (resultCmp < 0)
                {
                    comboBoxCmpResult.SelectedIndex = INDEX_CMP_INFERIOR;
                }
                else if (resultCmp > 0)
                {
                    comboBoxCmpResult.SelectedIndex = INDEX_CMP_SUPERIOR;
                }
                else
                {
                    comboBoxCmpResult.SelectedIndex = INDEX_CMP_EQUAL;
                }
            }
            catch (Exception exc)
            {
                ClearResultCmp();
                MessageBox.Show(exc.Message, "Erreur");
                return;
            }

            bool result = FractionsManager.SaveComparison(fracLeft, comboBoxCmpResult.Text, fracRight);
            if (!result)
            {
                MessageBox.Show("Erreur lors de l'enregistrement de la comparaison dans le fichier historique.", "Erreur");
            }
        }

        private void ClearResultCmp()
        {
            comboBoxCmpResult.SelectedIndex = INDEX_CMP_UNDEFINED;
        }

        private void NumUpDownCmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = true;
            }
            else
            {
                ClearResultCmp();
            }
        }

        private void NumUpDownCmp_ValueChanged(object sender, EventArgs e)
        {
            ClearResultCmp();
        }
    }
}
