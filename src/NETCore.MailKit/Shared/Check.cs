using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace NETCore.MailKit.Shared
{
    internal class Check
    {
        internal Check()
        {

        }

        internal class Argument
        {
            internal Argument()
            {
            }

            internal static void IsNotValid(string argument, string argumentName)
            {
                throw new ArgumentException($"\"{argumentName}\" cannot be valide .", argumentName);

            }

            internal static void IsNotEmpty(Guid argument, string argumentName)
            {
                if (argument == Guid.Empty)
                {
                    throw new ArgumentException($"\"{argumentName}\" cannot be empty guid.", argumentName);
                }
            }

            internal static void IsNotEmpty(string argument, string argumentName)
            {
                if (string.IsNullOrEmpty((argument ?? string.Empty).Trim()))
                {
                    throw new ArgumentException($"\"{argumentName}\" cannot be emtpy .", argumentName);
                }
            }

            internal static void IsNotOutOfLength(string argument, int length, string argumentName)
            {
                if (argument.Trim().Length > length)
                {
                    throw new ArgumentException($"\"{argumentName}\" not out of {length} character.", argumentName);
                }
            }

            internal static void IsNotNull(object argument, string argumentName, string message = "")
            {
                if (argument == null)
                {
                    throw new ArgumentNullException(argumentName, message);
                }
            }

            internal static void IsNotNegative(int argument, string argumentName)
            {
                if (argument < 0)
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }

            internal static void IsNotNegativeOrZero(int argument, string argumentName)
            {
                if (argument <= 0)
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }

            internal static void IsNotNegative(long argument, string argumentName)
            {
                if (argument < 0)
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }
            internal static void IsNotNegativeOrZero(long argument, string argumentName)
            {
                if (argument <= 0)
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }

            internal static void IsNotNegative(float argument, string argumentName)
            {
                if (argument < 0)
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }

            internal static void IsNotNegativeOrZero(float argument, string argumentName)
            {
                if (argument <= 0)
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }
            internal static void IsNotNegative(decimal argument, string argumentName)
            {
                if (argument < 0)
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }

            internal static void IsNotNegativeOrZero(decimal argument, string argumentName)
            {
                if (argument <= 0)
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }

            internal static void IsNotInvalidDate(DateTime argument, string argumentName)
            {
                DateTime MinDate = new DateTime(1900, 1, 1);
                DateTime MaxDate = new DateTime(9999, 12, 31, 23, 59, 59, 999);

                if (!((argument >= MinDate) && (argument <= MaxDate)))
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }

            internal static void IsNotInPast(DateTime argument, string argumentName)
            {
                if (argument < DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }

            internal static void IsNotInFuture(DateTime argument, string argumentName)
            {
                if (argument > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }

            internal static void IsNotNegative(TimeSpan argument, string argumentName)
            {
                if (argument < TimeSpan.Zero)
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }

            internal static void IsNotNegativeOrZero(TimeSpan argument, string argumentName)
            {
                if (argument <= TimeSpan.Zero)
                {
                    throw new ArgumentOutOfRangeException(argumentName);
                }
            }

            internal static void IsNotEmpty<T>(ICollection<T> argument, string argumentName)
            {
                IsNotNull(argument, argumentName, "collection not be null");

                if (argument.Count == 0)
                {
                    throw new ArgumentException("collection not be empty.", argumentName);
                }
            }
            internal static void IsNotOutOfRange(int argument, int min, int max, string argumentName)
            {
                if ((argument < min) || (argument > max))
                {
                    throw new ArgumentOutOfRangeException(argumentName, $"{argumentName} must be in range \"{min}\"-\"{max}\".");
                }
            }
        }
    }
}
