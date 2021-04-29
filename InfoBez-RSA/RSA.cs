using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;

namespace InfoBez_RSA_App
{
    class RSA
    {
        Random rnd = new Random();

        public List<ulong> PrimeNumbers = new List<ulong>();
        public ulong PrimesFrom = 10000;
        public ulong PrimesTo = 20000;

        public ulong P = 0;
        public ulong Q = 0;

        private ulong N = 0;
        private ulong F = 0;

        public ulong E = 0;
        public ulong D = 0;

        public string InputText;
        public string EncryptedText;
        public string DecrypredText;

        public void Encrypt()
        {
            var list = new List<BigInteger>();

            for (int i = 0; i < InputText.Length; i++)
            {
                var m = (byte)InputText[i];
                list.Add(BigInteger.ModPow(m, E, N));
            }

            var bytes = new byte[8 * list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                var data = BitConverter.GetBytes((ulong)list[i]);

                for (int j = 0; j < 8; j++)
                {
                    bytes[i * 8 + j] = data[j];
                }
            }

            EncryptedText = ToHex(bytes);
        }

        public void Decrypt()
        {
            var bytes = FromHex(EncryptedText);
            var count = bytes.Length / 8;

            var data = new List<BigInteger>();
            var result = new List<byte>();

            for (int i = 0; i < count; i++)
            {
                var part = new byte[8];

                for (int j = 0; j < 8; j++)
                {
                    part[j] = bytes[i * 8 + j];
                }

                data.Add(new BigInteger(part));
            }

            for (int i = 0; i < data.Count; i++)
            {
                result.Add((byte)BigInteger.ModPow(data[i], D, N));
            }

            DecrypredText = Encoding.ASCII.GetString(result.ToArray());
        }

        public void GenerateP()
        {
            if (PrimeNumbers.Count == 0)
            {
                PrimeNumbers = GeneratePrimeNumbers(PrimesFrom, PrimesTo);
            }

            P = PrimeNumbers[rnd.Next(0, PrimeNumbers.Count - 1)];
            Console.WriteLine("P: " + P);
        }

        public void GenerateQ()
        {
            if (PrimeNumbers.Count == 0)
            {
                PrimeNumbers = GeneratePrimeNumbers(PrimesFrom, PrimesTo);
            }

            Q = PrimeNumbers[rnd.Next(0, PrimeNumbers.Count - 1)];
            Console.WriteLine("Q: " + Q);
        }

        // E должно быть меньше F, E должно быть взаимно простым с F
        public void GenerateE(ulong from)
        {
            N = P * Q;
            F = (P - 1) * (Q - 1);

            ulong e = from;

            while (true)
            {
                if (FindGreatestCommonDivider(e, F) == 1)
                {
                    E = e;
                    Console.WriteLine("E: " + E);
                    return;
                }

                e++;
            }

            throw new ArgumentException("Не удалось найти E, попробуйте подобрать другие значения для from и to");
        }

        public void GenerateD(ulong from)
        {
            ulong d = from;

            while (true)
            {
                if (d * E % F == 1)
                {
                    D = d;
                    Console.WriteLine("D: " + D);
                    return;
                }

                d++;
            }
        }

        public List<ulong> GeneratePrimeNumbers(ulong from, ulong to)
        {
            Console.WriteLine("Generating prime numbers");
            var numbers = new List<ulong>();
            for (ulong i = from; i < to; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine("Generating is done");
            return numbers;
        }

        private bool IsPrime(ulong num)
        {
            if ((num & 1) == 0) return (num == 2);

            var limit = (ulong)Math.Sqrt(num);
            for (ulong i = 3; i <= limit; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        static ulong FindGreatestCommonDivider(ulong num1, ulong num2)
        {
            while (num2 != 0)
            {
                var temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }

            return num1;
        }

        public string ToHex(ICollection<byte> input)
        {
            //var bytes = Encoding.ASCII.GetBytes(input);
            var hexString = BitConverter.ToString(input.ToArray());
            hexString = hexString.Replace("-", " ");
            return hexString;
        }

        public byte[] FromHex(string input)
        {
            input = input.Replace(" ", "");
            byte[] data = new byte[input.Length / 2];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Convert.ToByte(input.Substring(i * 2, 2), 16);
            }

            return data;
        }
    }
}
