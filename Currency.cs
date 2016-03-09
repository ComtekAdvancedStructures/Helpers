// Author: Craig Verburgh
// Created: 02/19/2016, 1:20 PM
// Modified: 03/04/2016, 9:38 AM

namespace Comtek.Helpers
{
    public enum Currency
    {
        CAD = 0,
        USD = 10,
        Euro = 20,
        Unknown = 999
    }

    public static class CurrencyHelper
    {
        public static string ConvertToSysproCurrency(Currency currency)
        {
            switch (currency)
            {
                case Currency.CAD:
                    return "$";
                case Currency.USD:
                    return "US";
                case Currency.Euro:
                    return "EUR";
                case Currency.Unknown:
                    return "Unknown Currency";
                default:
                    return "Unknown Currency";
            }
        }

        public static Currency ConvertFromSysproCurrency(string currency)
        {
            switch (currency.Trim())
            {
                case "$  ":
                case "$":
                    return Currency.CAD;
                case "US ":
                case "US":
                    return Currency.USD;
                case "EUR":
                    return Currency.Euro;
                default:
                    return Currency.Unknown;
            }
        }

        public static string ConvertFromSysproCurrencyToString(string currency)
        {
            switch (currency.Trim())
            {
                case "$  ":
                case "$":
                    return "CAD";
                case "US ":
                case "US":
                    return "USD";
                case "EUR":
                    return "Euro";
                default:
                    return "Unknown";
            }
        }

        public static Currency ConvertFromString(string currency)
        {
            switch (currency.Trim())
            {
                case "CAD":
                case "$":
                case "$  ":
                    return Currency.CAD;
                case "US":
                case "US ":
                case "US DOLLAR":
                case "USD":
                    return Currency.USD;
                case "Euro":
                case "EUR":
                    return Currency.Euro;
                default:
                    return Currency.Unknown;
            }
        }

        public static string ConvertToString(Currency currency)
        {
            switch (currency)
            {
                case Currency.CAD:
                    return "CAD";
                case Currency.USD:
                    return "USD";
                case Currency.Euro:
                    return "Euro";
                case Currency.Unknown:
                    return "Unknown Currency";
                default:
                    return "Unknown Currency";
            }
        }
    }
}