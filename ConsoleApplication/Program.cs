using System;

namespace ConsoleApp15
{
    class ArrayHelper<T>
    {
        /////////////// POP ///////////////
        public static T Pop(ref T[] Arrstr)
        {
            T ArrTip = Arrstr[Arrstr.Length - 1];
            Array.Resize(ref Arrstr, Arrstr.Length - 1);
            return ArrTip;
        }
        /////////////// PUSH ///////////////
        public static int Push(ref T[] ArrInt, T IntRar)
        {
            Array.Resize(ref ArrInt, ArrInt.Length + 1);
            ArrInt[ArrInt.Length - 1] = IntRar;
            return ArrInt.Length;
        }
        /////////////// SHIFT ///////////////
        public static T Shift(ref T[] ArrShf)
        {
            T arr = ArrShf[0];
            for (int i = 0; i < ArrShf.Length - 1; i++)
            {
                ArrShf[i] = ArrShf[i + 1];
            }
            Array.Resize(ref ArrShf, ArrShf.Length - 1);
            return arr;
        }
        /////////////// UNSHIFT ///////////////
        public static int UnShift(ref T[] ArrUNSHF, T UNArr)
        {
            Array.Resize(ref ArrUNSHF, ArrUNSHF.Length + 1);
            for (int i = ArrUNSHF.Length - 1; i >= 1; i--)
            {
                ArrUNSHF[i] = ArrUNSHF[i - 1];
            }
            ArrUNSHF[0] = UNArr;
            return ArrUNSHF.Length - 1;
        }

        /////////////// SLICE ///////////////
        public static T[] Slice(ref T[] Array, int? begin_Index = null, int? end_index = null)
        {
            int ArrayLength = Array.Length;
            begin_Index = begin_Index ?? 0;
            end_index = end_index ?? ArrayLength;
            if (end_index < 0) end_index = ArrayLength + end_index;
            if (begin_Index < 0) begin_Index = end_index + begin_Index;
            int newarray = (end_index - begin_Index > 0) ? (int)(end_index - begin_Index) : 0;
            Console.WriteLine($"New Array Length: {newarray}");
            T[] NewArray = new T[newarray];
            for (int i = 0; i < newarray; i++)
                NewArray[i] = Array[i + (int)begin_Index];
            return NewArray;

        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            /////////////// POP ///////////////

            string[] ArrTip = new string[] { "ant", "bison", "camel", "duck", "elephant" };
            string Arrstr = ArrayHelper<string>.Pop(ref ArrTip);
            Console.WriteLine($"Последний элемент: { Arrstr}");

            int[] ArrInt = new int[] { 10, 100, 1000, 10000, 10000 };
            int Arrint = ArrayHelper<int>.Pop(ref ArrInt);
            Console.WriteLine($" POP = { Arrint}");

            double[] Arrdbl = new double[] { 5.5, 10.256, 2.25, 4.2564, 548.2255 };
            double ArrDbl = ArrayHelper<double>.Pop(ref Arrdbl);
            Console.WriteLine($" POP = { ArrDbl}");

            decimal[] ArrDec = new decimal[] { 1m, 10.25m, 254.2456m, 24.21m, 2545.255m };
            decimal Arrdec = ArrayHelper<decimal>.Pop(ref ArrDec);
            Console.WriteLine($" POP = { Arrdec}");

            float[] Arrflt = new float[] { 10.2f, 212.2155f, 0.23213f, 215.025f, 25.021f };
            float ArrFlt = ArrayHelper<float>.Pop(ref Arrflt);
            Console.WriteLine($" POP = { ArrFlt}");

            /////////////// PUSH ///////////////

            Console.WriteLine();
            string[] arrstr = new string[] { "ant", "bison", "camel", "duck", "elephant" };
            int strArr = ArrayHelper<string>.Push(ref arrstr, "dog");
            Console.WriteLine($"Push String: {strArr}");
            int[] arrint = new int[] { 10, 100, 1000, 10000, 10000 };
            int intarr = ArrayHelper<int>.Push(ref arrint, 1452);
            Console.WriteLine($"Push Int: {intarr}");
            double[] arrdbl = new double[] { 5.5, 10.256, 2.25, 4.2564, 548.2255 };
            double dblarr = ArrayHelper<double>.Push(ref arrdbl, 0.5121);
            Console.WriteLine($"Push Double: {dblarr}");
            decimal[] arrdec = new decimal[] { 1m, 10.25m, 254.2456m, 24.21m, 2545.255m };
            decimal decarr = ArrayHelper<decimal>.Push(ref arrdec, 0.00565m);
            Console.WriteLine($"Push Decimal: {decarr}");
            float[] arrflt = new float[] { 10.2f, 212.2155f, 0.23213f, 215.025f, 25.021f };
            float fltarr = ArrayHelper<float>.Push(ref arrflt, 12.0011f);
            Console.WriteLine($"Push Float: {fltarr}");

            /////////////// SHIFT ///////////////

            Console.WriteLine();
            string[] StrArr = new string[] { "ant", "bison", "camel", "duck", "elephant" };
            Console.WriteLine($"Shift String: {ArrayHelper<string>.Shift(ref StrArr)}");
            int[] IntArr = new int[] { 10, 100, 1000, 10000, 10000 };
            Console.WriteLine($"Shift Int: { ArrayHelper<int>.Shift(ref IntArr)}");
            double[] DblArr = new double[] { 5.5, 10.256, 2.25, 4.2564, 548.2255 };
            Console.WriteLine($"Shift Double: {ArrayHelper<double>.Shift(ref DblArr)}");
            decimal[] DecArr = new decimal[] { 1m, 10.25m, 254.2456m, 24.21m, 2545.255m };
            Console.WriteLine($"Shift Decimal: {ArrayHelper<decimal>.Shift(ref DecArr)}");
            float[] FltArr = new float[] { 10.2f, 212.2155f, 0.23213f, 215.025f, 25.021f };
            Console.WriteLine($"Shift Float: {ArrayHelper<float>.Shift(ref FltArr)}");

            /////////////// UNSHIFT ///////////////

            Console.WriteLine();
            string[] newstr = new string[] { "ant", "bison", "camel", "duck", "elephant" };
            int newstrArr = ArrayHelper<string>.UnShift(ref newstr, "Cat");
            Console.WriteLine($"Unshift String: {newstrArr}");
            int[] newint = new int[] { 10, 100, 1000, 10000, 10000 };
            int newintArr = ArrayHelper<int>.UnShift(ref newint, 1455);
            Console.WriteLine($"Unshift Int: {newintArr}");
            double[] newdbl = new double[] { 5.5, 10.256, 2.25, 4.2564, 548.2255 };
            double newdblArr = ArrayHelper<double>.UnShift(ref newdbl, 0.554);
            Console.WriteLine($"Unshift Double {newdblArr}");
            decimal[] newdec = new decimal[] { 1m, 10.25m, 254.2456m, 24.21m, 2545.255m };
            decimal newdecArr = ArrayHelper<decimal>.UnShift(ref newdec, 0.101m);
            Console.WriteLine($"Unshift Decimal: {newdecArr}");
            float[] newflt = new float[] { 10.2f, 212.2155f, 0.23213f, 215.025f, 25.021f };
            float newfltArr = ArrayHelper<float>.UnShift(ref newflt, 5455.561541f);
            Console.WriteLine($"Unshift Float: {newfltArr}");

            /////////////// SLICE ///////////////

            Console.WriteLine();
            string[] Array = new string[] { "ant", "bison", "camel", "duck", "elephant" };
            int? begin_Index = null, end_index = null;
            Console.WriteLine("Если хотите указывать Begin Index нажмите 1");
            Console.WriteLine("Если не хотите указывать Begin Index нажмите 2");
            Console.Write("Введите число: ");
            int inputnumber = int.Parse(Console.ReadLine());
            if (inputnumber == 1)
            {
                Console.Write("Begin Index = ");
                begin_Index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Если хотите указывать End Index нажмите 1");
            Console.WriteLine("Если не хотите указывать End Index нажмите 2");
            Console.Write("Введите число: ");
            inputnumber = int.Parse(Console.ReadLine());
            if (inputnumber == 1)
            {
                Console.Write("End Index = ");
                end_index = int.Parse(Console.ReadLine());
            }
            string[] NewArray = ArrayHelper<string>.Slice(ref Array, begin_Index, end_index);
            Console.WriteLine("Mассив: ");
            for (int i = 0; i < NewArray.Length; i++)
            {
                Console.Write($"{NewArray[i]} ");
            }
        }
    }
}