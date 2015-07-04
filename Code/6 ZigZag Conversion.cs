public class Solution
{
	/// <summary>
	/// 把字符串转换成指定的行数的锯齿状字符串
	/// 题目地址：https://leetcode.com/problems/zigzag-conversion/
	/// </summary>
	/// <param name="s">输入</param>
	/// <param name="numRows">行数</param>
	/// <returns>转换后的字符串</returns>
	public string Convert(string s, int numRows)
	{
		StringBuilder result = new StringBuilder();

		if (s.Length <= 2 || numRows == 1)
		{
			result.Append(s);
		}
		else
		{
			int step = numRows * 2 - 2;		// 下标每次增加的步长
			int step1 = step + 2;			// 步长1
			int step2 = -2;					// 步长2
			bool isFirst;					// 第一次增加
			int index;						// 下标

			for (int row = 0; row < numRows; row++)
			{
				index = row;

				step1 -= 2;
				step2 += 2;
				isFirst = (step1 != 0);

				while (index < s.Length)
				{
					result.Append(s[index]);
					index += isFirst ? step1 : step2;

					if (step1 != 0 && step2 != 0)
					{
						isFirst = !isFirst;
					}
				}
			}
		}

		return result.ToString();
	}
}