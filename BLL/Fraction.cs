using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BLL
{
    public class Fraction : IEquatable<Fraction>, IComparable<Fraction>
    {
        const int DENOMINATOR_NUMBER = 1;
        const int DECIMAL_MAXIMUM_DENOMINATOR = 4096;
        const char SEPARATOR_FRACTION = '/';

        #region Propriétés
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        #endregion

        #region Constructeurs
        public Fraction() : this(0, 0, DENOMINATOR_NUMBER) { }
        public Fraction(int pNumber) : this(0, pNumber, DENOMINATOR_NUMBER) { }
        public Fraction(int pNumerator, int pDenominator) : this(0, pNumerator, pDenominator) { }
        public Fraction(int pNumber, int pNumerator, int pDenominator)
        {
            if (pDenominator == 0)
            {
                throw new ArgumentOutOfRangeException("Denominator", "Le dénominateur d'une fraction ne peut pas être à zéro.");
            }
            if (pNumber != 0)
            {
                // Le dénominateur doit être positif. S'il est négatif, on fait passer le signe du dénominateur vers le numérateur.
                // Si le numérateur ou le nombre devant la fraction est négatif, la fraction enregistrée dans l'objet doit être négative.
                if (pDenominator < 0)
                {
                    pDenominator = -pDenominator;
                    pNumerator = -pNumerator;
                }
                if (pNumerator < 0)
                {
                    pNumerator = -pNumerator;
                    if (pNumber > 0) pNumber = -pNumber;
                }
                if (pNumber < 0)
                {
                    pNumerator = (pNumber * pDenominator) - pNumerator;
                }
                else
                {
                    pNumerator = (pNumber * pDenominator) + pNumerator;
                }
            }
            Numerator = pNumerator;
            Denominator = pDenominator;
            SimplifyFraction();
        }
        public Fraction(decimal pDecimalValue)
        {
            // Référence : https://rosettacode.org/wiki/Convert_decimal_number_to_rational#C.23
            var h = new Int64[3] { 0, 1, 0 };
            var k = new Int64[3] { 1, 0, 0 };
            double f = (double)pDecimalValue;
            Int64 a, x, d, n = 1;
            int i, neg = 0;

            if (f < 0)
            {
                neg = 1;
                f = -f;
            }

            while (f != Math.Floor(f))
            {
                n <<= 1;
                f *= 2;
            }
            d = (Int64)f;

            for (i = 0; i < 64; i++)
            {
                a = (n != 0) ? d / n : 0;
                if ((i != 0) && (a == 0)) break;

                x = d;
                d = n;
                n = x % n;

                x = a;
                if (k[1] * a + k[0] >= DECIMAL_MAXIMUM_DENOMINATOR)
                {
                    x = (DECIMAL_MAXIMUM_DENOMINATOR - k[0]) / k[1];
                    if (x * 2 >= a || k[1] >= DECIMAL_MAXIMUM_DENOMINATOR)
                    {
                        i = 65;
                    }
                    else
                    {
                        break;
                    }
                }

                h[2] = x * h[1] + h[0];
                h[0] = h[1];
                h[1] = h[2];
                k[2] = x * k[1] + k[0];
                k[0] = k[1];
                k[1] = k[2];
            }
            Denominator = (int)k[1];
            Numerator = (int)(neg != 0 ? -h[1] : h[1]);

            SimplifyFraction();
        }

        private void SimplifyFraction()
        {
            if (Numerator == 0)
            {
                Denominator = DENOMINATOR_NUMBER;
            }
            else
            {
                int gcd = CalculateGreatestCommonDivisor(Numerator, Denominator);
                Numerator /= gcd;
                Denominator /= gcd;
                // Le dénominateur doit être positif. S'il est négatif, on fait passer le signe du dénominateur vers le numérateur.
                if (Denominator < 0)
                {
                    Denominator = -Denominator;
                    Numerator = -Numerator;
                }
            }
        }

        private int CalculateGreatestCommonDivisor(int pLeft, int pRight)
        {
            // On utilise la valeur absolue des 2 paramètres.
            pLeft = Math.Abs(pLeft);
            pRight = Math.Abs(pRight);

            // Cas particulier lorsque un des paramètres est à zéro.
            if (pLeft == 0) return pRight;
            if (pRight == 0) return pLeft;

            // Cas particulier lorsque un des paramètres est à un.
            if (pLeft == 1 || pRight == 1) return 1;

            // Cas particulier lorsque les deux paramètres sont identiques.
            if (pLeft == pRight) return pLeft;

            // Détermine le PGCD en utilisant l'algorithme d'Euclide.
            int tmp;
            if (pLeft < pRight)
            {
                tmp = pLeft;
                pLeft = pRight;
                pRight = tmp;
            }
            do
            {
                tmp = pLeft % pRight;
                pLeft = pRight;
                pRight = tmp;
            } while (pRight != 0);

            return pLeft;
        }
        #endregion

        #region Surcharge des opérateurs +, -, * et /.
        public static Fraction operator +(Fraction pLeft, Fraction pRight)
        {
            int numerator = pLeft.Numerator * pRight.Denominator + pRight.Numerator * pLeft.Denominator;
            int denominator = pLeft.Denominator * pRight.Denominator;
            return new Fraction(numerator, denominator);
        }
        public static Fraction operator -(Fraction pLeft, Fraction pRight)
        {
            int numerator = pLeft.Numerator * pRight.Denominator - pRight.Numerator * pLeft.Denominator;
            int denominator = pLeft.Denominator * pRight.Denominator;
            return new Fraction(numerator, denominator);
        }
        public static Fraction operator *(Fraction pLeft, Fraction pRight)
        {
            int numerator = pLeft.Numerator * pRight.Numerator;
            int denominator = pLeft.Denominator * pRight.Denominator;
            return new Fraction(numerator, denominator);
        }
        public static Fraction operator /(Fraction pLeft, Fraction pRight)
        {
            int numerator = pLeft.Numerator * pRight.Denominator;
            int denominator = pLeft.Denominator * pRight.Numerator;
            return new Fraction(numerator, denominator);
        }
        #endregion

        #region Surcharge des opérateurs de convertion.
        public static implicit operator string(Fraction pFrac) => pFrac.ToString();
        public static explicit operator decimal(Fraction pFrac) => pFrac.ToDecimal();
        public static explicit operator Fraction(decimal pDecimalValue) => new Fraction(pDecimalValue);
        #endregion

        #region Surcharge des opérateurs de comparaison.
        public static bool operator <(Fraction pLeft, Fraction pRight) => pLeft.CompareTo(pRight) < 0;
        public static bool operator >(Fraction pLeft, Fraction pRight) => pLeft.CompareTo(pRight) > 0;
        public static bool operator ==(Fraction pLeft, Fraction pRight) => EqualityComparer<Fraction>.Default.Equals(pLeft, pRight);
        public static bool operator !=(Fraction pLeft, Fraction pRight) => !(pLeft == pRight);

        public override bool Equals(object other) => this.Equals(other as Fraction);

        public bool Equals([AllowNull] Fraction other) => other != null && this.Numerator == other.Numerator && this.Denominator == other.Denominator;

        public int CompareTo([AllowNull] Fraction other)
        {
            int left = this.Numerator * other.Denominator;
            int right = this.Denominator * other.Numerator;
            return (other == null) ? 1 : left.CompareTo(right);
        }
        public override int GetHashCode() => Numerator.GetHashCode() ^ Denominator.GetHashCode();
        #endregion

        #region Méthodes To...
        public decimal ToDecimal()
        {
            return (decimal)Numerator / (decimal)Denominator;
        }

        public string ToStringWithOnlyFraction()
        {
            return $"{Numerator}{SEPARATOR_FRACTION}{Denominator}";
        }

        public override string ToString()
        {
            string result;

            if (Numerator == 0)
            {
                result = "0";
            }
            else
            {
                int absNumerator = Math.Abs(Numerator);
                if (absNumerator < Denominator)
                {
                    result = $"{Numerator}{SEPARATOR_FRACTION}{Denominator}";
                }
                else
                {
                    int number = Numerator / Denominator;
                    int rest = absNumerator % Denominator;
                    if (rest == 0)
                    {
                        result = number.ToString();
                    }
                    else
                    {
                        result = $"{number} {rest}{SEPARATOR_FRACTION}{Denominator}";
                    }
                }
            }

            return result;
        }

        /// <summary>
        ///    Convertit la fraction en une chaîne de caractère dont la syntaxe correspond à celle du logiciel Excel.
        ///    De cette manière, si on écrit la chaîne de caractère dans un fichier CSV, Excel pourra la lire et la
        ///    convertir correctement en une fraction. En cliquant sur la cellule contenant la fraction, Excel affichera
        ///    également la valeur décimale représentant la fraction. Grâce à cela, on évite les problèmes des fractions
        ///    transformées en date (1/4 devient 1 avril), les alignements à gauche ou à droite suivant la manière dont
        ///    Excel interpréte le champ (string, nombre entier, fraction, ...), pas besoin d'espace devant la fraction,
        ///    pas besoin de guillemet, etc.
        ///    
        ///    SYNTAXE : {+|-}entier numérateur/dénominateur
        ///    
        ///    EXEMPLES: +0 1/2, -1 2/3, -0 3/5, +5 0/1.
        ///    
        ///    Remarque: j'ai testé aussi avec LibreOffice et cela fonctionne très bien.
        /// </summary>
        /// <returns></returns>
        public string ToStringCSV()
        {
            char sign;
            int numerator;
            if (Numerator < 0)
            {
                sign = '-';
                numerator = -Numerator;
            }
            else
            {
                sign = '+';
                numerator = Numerator;
            }
            int number = numerator / Denominator;
            int rest = numerator % Denominator;
            return $"{sign}{number} {rest}{SEPARATOR_FRACTION}{Denominator}";
        }
        #endregion
    }
}