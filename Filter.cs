using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TechProg8_4
{
    public class Filter
    {
        public static List<string[]> ApplyFilter(List<string[]> matrix, char filterChar1, char filterChar2, bool isUpper, bool isLower, FilterType filterType)
        {
            switch (filterType)
            {
                case FilterType.All:
                    return matrix;
                case FilterType.Numbers:
                    return FilterNumbers(matrix);
                case FilterType.InText:
                    return FilterInText(matrix, filterChar1, filterChar2, isUpper, isLower);
                case FilterType.StartText:
                    return FilterStartText(matrix, filterChar1, filterChar2, isUpper, isLower);
                case FilterType.Signs:
                    return FilterSigns(matrix);
                default:
                    throw new ArgumentException("Ошибка.");
            }
        }
        
        private static List<string[]> FilterInText(List<string[]> matrix, char filterChar1, char filterChar2, bool isUpper, bool isLower)
        {
            List<string[]> filteredMatrix = new List<string[]>();

            foreach (string[] row in matrix)
            {
                List<string> filteredRow = new List<string>();
                foreach (string cell in row)
                {
                    if (string.IsNullOrWhiteSpace(cell))
                    {
                        filteredRow.Add(cell);
                        continue;
                    }

                    if (double.TryParse(cell, out _))
                    {
                        filteredRow.Add("Пусто");
                    }
                    else
                    {
                        if (cell.Contains(filterChar1.ToString()) || cell.Contains(filterChar2.ToString()))
                        {
                            if (isUpper)
                            {
                                filteredRow.Add(cell.ToUpper());
                            }
                            else if (isLower)
                            {
                                filteredRow.Add(cell.ToLower());
                            }
                            else
                            {
                                filteredRow.Add(cell);
                            }
                        }
                        else
                        {
                            filteredRow.Add("Пусто");
                        }

                    }

                }
                filteredMatrix.Add(filteredRow.ToArray());
            }
            return filteredMatrix;
        }

        private static List<string[]> FilterStartText(List<string[]> matrix, char filterChar1, char filterChar2, bool isUpper, bool isLower)
        {
            List<string[]> filteredMatrix = new List<string[]>();

            foreach (string[] row in matrix)
            {
                List<string> filteredRow = new List<string>();
                foreach (string cell in row)
                {
                    if (string.IsNullOrWhiteSpace(cell))
                    {
                        filteredRow.Add(cell);
                        continue;
                    }

                    if (double.TryParse(cell, out _))
                    {
                        filteredRow.Add("Пусто");
                    }
                    else
                    {
                        if (cell[0] == filterChar1 || cell[0] == filterChar2)
                        {
                            if (isUpper)
                            {
                                filteredRow.Add(cell.ToUpper());
                            }
                            else if (isLower)
                            {
                                filteredRow.Add(cell.ToLower());
                            }
                            else
                            {
                                filteredRow.Add(cell);
                            }
                        }
                        else
                        {
                            filteredRow.Add("Пусто");
                        }
                    }

                }
                filteredMatrix.Add(filteredRow.ToArray());
            }
            return filteredMatrix;
        }

        private static List<string[]> FilterNumbers(List<string[]> matrix)
        {
            List<string[]> filteredMatrix = new List<string[]>();

            foreach (string[] row in matrix)
            {
                List<string> filteredRow = new List<string>();
                foreach (string cell in row)
                {
                    if (string.IsNullOrWhiteSpace(cell))
                    {
                        filteredRow.Add(cell);
                        continue;
                    }

                    if (double.TryParse(cell, out double number))
                    {
                        filteredRow.Add(number.ToString());
                    }
                    else
                    {
                        filteredRow.Add("Пусто");
                    }
                }
                filteredMatrix.Add(filteredRow.ToArray());
            }
            return filteredMatrix;
        }     

        private static List<string[]> FilterSigns(List<string[]> matrix)
        {
            List<string[]> filteredMatrix = new List<string[]>();

            foreach (string[] row in matrix)
            {
                List<string> filteredRow = new List<string>();
                foreach (string cell in row)
                {
                    if (string.IsNullOrWhiteSpace(cell))
                    {
                        filteredRow.Add(cell);
                        continue;
                    }

                    if (double.TryParse(cell, out _))
                    {
                        filteredRow.Add("Пусто");                        
                    }
                    else
                    {
                        if (Regex.IsMatch(cell, @"\p{L}"))
                        {
                            filteredRow.Add("Пусто");
                        }
                        else
                        {
                            if (cell.Contains('+') || cell.Contains('-'))
                            {
                                filteredRow.Add(cell);
                            }
                            else
                            {
                                filteredRow.Add("Пусто");
                            }
                        }
                        
                    }

                }
                filteredMatrix.Add(filteredRow.ToArray());
            }
            return filteredMatrix;
        }
    }

    public enum FilterType
    {
        All, Numbers, InText, StartText, Signs       
    }

}

