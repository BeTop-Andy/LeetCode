public class Solution
{
	/// <summary>
	/// 自己实现除法，不能使用“*”，“/”，“%”
	/// 题目地址：https://leetcode.com/problems/divide-two-integers/
	/// </summary>
	/// <param name="dividend">被除数</param>
	/// <param name="divisor">除数</param>
	/// <returns>商</returns>
	public int Divide(int dividend, int divisor)
	{
		int result = 0;

		if (CheckOverflow(dividend, divisor))
		{
			result = int.MaxValue;
		}
		else
		{
			bool isNegative = (dividend < 0 && divisor > 0
							|| dividend > 0 && divisor < 0);
			long a = Math.Abs((long) dividend);
			long b = Math.Abs((long) divisor);

			if (a == b)
			{
				result = isNegative ? -1 : 1;
			}
			else if (a < b)
			{
				result = 0;
			}
			else
			{
				int powers;
				while (a >= Math.Abs(divisor))
				{
					b = Math.Abs(divisor);
					powers = 0;

					while (a >= b + b)
					{
						b += b;
						powers++;
					}

					a -= b;
					result += 1 << powers;
				}

				result = isNegative ? -result : result;
			}
		}


		return result;
	}

	/// <summary>
	/// 检查是否溢出
	/// </summary>
	/// <param name="dividend">被除数</param>
	/// <param name="divisor">除数</param>
	/// <returns>是/否</returns>
	private bool CheckOverflow(int dividend, int divisor)
	{
		return (divisor == 0)
			|| (dividend == int.MinValue && divisor == -1);
	}
}