using System;
using System.Linq;

namespace dersde5task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,6, 2, 3, 4, 5, };
            AddElementArray(ref arr, 15);
            string input = "Salam   Baki.";
            Console.WriteLine(char.IsDigit('2'));
            Console.WriteLine(char.IsUpper(input[0]));
            Console.WriteLine(char.IsLower(input[0]));
            Console.WriteLine(char.ToUpper('h'));
            Console.WriteLine(char.ToLower(input[0]));
            Console.WriteLine(char.IsWhiteSpace(input[5]));
            Console.WriteLine(char.IsLetterOrDigit(input[input.Length-1]));

            Console.WriteLine(input.Replace("Sa", "Bb"));
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());
            Console.WriteLine(input.Remove(3,1));
            Console.WriteLine(input.Contains("lam"));
            Console.WriteLine(input.Substring(6,4));
            Console.WriteLine(input.IndexOf('a',6));
            Console.WriteLine(input.Trim());
            Console.WriteLine(input.StartsWith('S'));
            var t = string.Join("+",input);
            Console.WriteLine(t);
     
            Console.WriteLine(Array.IndexOf(arr, 35));
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }



        }
        static void ImproveTen(ref int num)
        {
            //Verilmis ededi 10 vahid artiran metod
            num += 10;
        }
        static void ChangeNum(ref int num)
        {
            //Verilmish deyer menfidirse onu musbete ceviren,
            //100-den boyukdurse 100-e ceviren, 0 ile 100 arasindadirsa oldugu
            //kimi saxlayan metod
            if (num<0)
            {
                num = 0;
            }
            else if (num>100)
            {
                num = 100;
            }
        }
        static void Cut(ref int[]arr)
        {
            //Verilmish ededler siyahisini yalniz cut deyerler qalan yeni bir arraye ceviren metod
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    counter++;
                }
            }
            var result= new int[counter];
            int j = 0;
            for (int i = 0; i <arr.Length ; i++)
            {
                if (arr[i]%2==0)
                {
                    result[j] = arr[i];
                    j++;
                }
            }
            arr= result;
        }
        //Task 1 : - Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod.
        //Misalçün metodu çağırıb array elementimi və 5 dəyəri göndərsəm,
        //arrayim dəyişilməli və arrayin  içində əvəlki elementləri, əlavə
        //olaraq son indexində isə 5 elementi olmalıdır və arrayin uzunluğu 1
        //vahid artmış olmalıdır.
        static void AddElementArray(ref int[]arr,int last)
        {
            int[]newarr= new int[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];
            }
            newarr[newarr.Length-1]= last;
            arr= newarr;
        }
    }
}
