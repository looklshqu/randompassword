using System;
using System.Linq;

namespace RandomPassword
{
    public class Program
    {
        static void Main(string[] args)
        {
            GeneratePassword();
        }

        public static void GeneratePassword()
        {
            // 영대소문자
            string alphabet = "abcdefghijhklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alpabetArray = alphabet.ToArray();
            int passwordAlpLimit = 4; // 영대소문자 5자리까지 제한

            // 숫자
            string number = "12334567890";
            char[] numberArray = number.ToArray();
            int passwordNumLimit = 4; // 숫자 5자리까지 제한


            // 특수문자
            string special = "!#$%^*";
            char[] specialArray = special.ToArray();
            int passwordSpecLimit = 2; // 특수문자 5자리까지 제한

            string newPassword = string.Empty;
            int seed = Environment.TickCount;
            Random random = new Random(seed);
            int tempNum = 0;
            int totalCnt = 10; // 비번 생성 개수

            #region 비번 생성(영대소문자5자리 + 숫자5자리 + 특수문자5자리)

            for (int i = 0; i < totalCnt; i++)
            {

                // 영대소문자 5자리 생성
                for (int a = 0; a < passwordAlpLimit; a++)
                {
                    tempNum = random.Next(0, alpabetArray.Length - 1);
                    newPassword += alpabetArray[tempNum];
                }

                // 숫자 5자리 생성
                for (int j = 0; j < passwordNumLimit; j++)
                {
                    tempNum = random.Next(0, numberArray.Length - 1);
                    newPassword += numberArray[tempNum];
                }

                // 특수문자 5자리 생성
                for (int k = 0; k < passwordSpecLimit; k++)
                {
                    tempNum = random.Next(0, specialArray.Length - 1);
                    newPassword += specialArray[tempNum];
                }

                Console.WriteLine("{0}. {1}", i + 1, newPassword);

                newPassword = string.Empty;
            }

            #endregion 비번 생성(영대소문자5자리 + 숫자5자리 + 특수문자5자리)
        }
    }
}
