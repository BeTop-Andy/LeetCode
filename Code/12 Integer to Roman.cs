public class Solution
{
	/// <summary>
	/// 把阿拉伯数字转换成罗马数字
	/// 题目地址：https://leetcode.com/problems/integer-to-roman/
	/// </summary>
	/// <param name="num">阿拉伯数字</param>
	/// <returns>罗马数字</returns>
	public string IntToRoman(int num)
	{
		string result = "";

		if (num > 0 && num <= 3999)
		{
			string[,] romanNum = {{ "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" },
								   { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" },
								   { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" },
								   { "", "M", "MM", "MMM", "", "", "", "", "", "" }};

			int digit;		// 数字
			int count = 0;	// 第几位
			while (num > 0)
			{
				digit = num % 10;
				num /= 10;

				result = romanNum[count, digit] + result;
				count++;
			}
		}

		return result;
	}
}