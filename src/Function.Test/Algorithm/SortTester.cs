using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Function.Test.Algorithm
{
    public class SortTester
    {
        /// <summary>
        /// 输入字符串，全部为小写，无数字，无序字符串
        /// 输出有序字符串并计数
        /// 遍历字符串一次即可实现
        /// 例：becaabc====>a2b2c2e
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string LetterSortAndCount(string input)
        {
            int[] arrayCount = new int[26];
            char[] charArray = new char[]
            {
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
            };

            //set char a index =0
            //then char index subtract a index get int array index for this char
            var length = input.Length;

            for (int i = 0; i < length; i++)
            {
                Char[] currentChars = { input[i] };
                var value = Encoding.ASCII.GetByteCount(currentChars) - Encoding.ASCII.GetByteCount("a");
                arrayCount[value] += 1;
            }

            var sb = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                if (arrayCount[i] != 0)
                {
                    sb.AppendFormat(string.Format("{0}{1}", charArray[i], arrayCount[i]));
                }

            }

            return sb.ToString();
        }

        public string LetterSortAndCountByDictionary(string input)
        {
            Dictionary<Char, int> dic = new Dictionary<char, int>();

            var length = input.Length;

            for (int i = 0; i < length; i++)
            {
                if (!dic.ContainsKey(input[i]))
                {
                    dic.Add(input[i], 1);
                }
                else
                {
                    dic[input[i]] += 1;
                }
            }

            var sb = new StringBuilder();
            foreach (var item in dic)
            {
                sb.Append(item.Key);
                sb.Append(item.Value);
            }

            return sb.ToString();
        }

        [Fact]
        public void LetterSortAndCountTest()
        {
            var input = "becaabca";
            var ret1 = LetterSortAndCount(input);
            var ret2 = LetterSortAndCountByDictionary(input);
            Console.WriteLine(ret1);
            Console.WriteLine(ret2);
        }
    }
}
