public class Solution
{
	/// <summary>
	/// 字符串转数字，
	/// 由可选的+或-开始，表示正负数；
	/// 如果溢出，正数输出int.MaxValue；负数输出int.MinValue；
	/// 不正确的输入输出0；
	/// 题目地址：https://leetcode.com/problems/string-to-integer-atoi/
	/// </summary>
	/// <param name="str">字符串</param>
	/// <returns>数字</returns>
	public int MyAtoi(string str)
	{
		int result = 0;
		str = str.Trim();
		var regex = new System.Text.RegularExpressions.Regex(@"^(\+|-)?[0-9]+");
		string num = regex.Match(str).Value;

		try
		{
			result = Convert.ToInt32(num);
		}
		catch (System.OverflowException)
		{
			result = num.StartsWith("-") ? int.MinValue : int.MaxValue;
		}
		catch
		{

		}

		return result;
	}
}