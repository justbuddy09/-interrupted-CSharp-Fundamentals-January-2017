using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffIntegersSize
{
    public class DiffIntegersSize
    {
        public static void Main(string[] args)
        {
            // Given an input integer, you must determine which primitive data types are capable of properly storing that input
            // sbyte < byte < short < ushort < int < uint < long

            string input = Console.ReadLine();

            bool sbyteCheck = false;
            try
            {
                sbyte sbyteValue = Convert.ToSByte(input);

                if (sbyte.MinValue <= sbyteValue && sbyteValue <= sbyte.MaxValue)
                {
                    sbyteCheck = true;
                }
            }
            catch
            {
                // The exception will show up when the sbyte value is out of range [-128...128] and will not crash the program
            }

            bool byteCheck = false;
            try
            {
                byte byteValue = Convert.ToByte(input);

                if (byte.MinValue <= byteValue && byteValue <= byte.MaxValue)
                {
                    byteCheck = true;
                }
            }
            catch
            {
                // The exception will show up when the sbyte value is out of range [-128...128] and will not crash the program
            }

            bool shortCheck = false;
            try
            {
                short shortValue = Convert.ToInt16(input);

                if (short.MinValue <= shortValue && shortValue <= short.MaxValue)
                {
                    shortCheck = true;
                }
            }
            catch
            {
                // The exception will show up when the sbyte value is out of range [-128...128] and will not crash the program
            }

            bool ushortCheck = false;
            try
            {
                ushort ushortValue = Convert.ToUInt16(input);

                if (ushort.MinValue <= ushortValue && ushortValue <= ushort.MaxValue)
                {
                    ushortCheck = true;
                }
            }
            catch
            {
                // The exception will show up when the sbyte value is out of range [-128...128] and will not crash the program
            }

            bool intCheck = false;
            try
            {
                int intValue = Convert.ToInt32(input);

                if (int.MinValue <= intValue && intValue <= int.MaxValue)
                {
                    intCheck = true;
                }
            }
            catch
            {
                // The exception will show up when the sbyte value is out of range [-128...128] and will not crash the program
            }

            bool uintCheck = false;
            try
            {
                uint uintValue = Convert.ToUInt32(input);

                if (uint.MinValue <= uintValue && uintValue <= uint.MaxValue)
                {
                    uintCheck = true;
                }
            }
            catch
            {
                // The exception will show up when the sbyte value is out of range [-128...128] and will not crash the program
            }

            bool longCheck = false;
            try
            {
                long longValue = Convert.ToInt64(input);

                if (long.MinValue <= longValue && longValue <= long.MaxValue)
                {
                    longCheck = true;
                }

            }
            catch
            {
                // The exception will show up when the sbyte value is out of range [-128...128] and will not crash the program
            }

            bool HasDataTypes = byteCheck || sbyteCheck || shortCheck || ushortCheck || intCheck || uintCheck || longCheck;
            if (!HasDataTypes)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{input} can fit in:");

                if (sbyteCheck)
                {
                    Console.WriteLine("* sbyte");
                }
                if (byteCheck)
                {
                    Console.WriteLine("* byte");
                }
                if (shortCheck)
                {
                    Console.WriteLine("* short");
                }
                if (ushortCheck)
                {
                    Console.WriteLine("* ushort");
                }
                if (intCheck)
                {
                    Console.WriteLine("* int");
                }
                if (uintCheck)
                {
                    Console.WriteLine("* uint");
                }
                if (longCheck)
                {
                    Console.WriteLine("* long");
                }
            }
        }
    }
}