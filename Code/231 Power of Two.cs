public class Solution
{
	/// <summary>
	/// 判断一个数是否为2的次方
	/// 题目地址：https://leetcode.com/problems/power-of-two/
	/// </summary>
	/// <param name="n"></param>
	/// <returns></returns>
	public bool IsPowerOfTwo(int n)
	{
		if (n > 0)
		{
			while ((n & 1) == 0)
			{
				n = n >> 1;
			}
		}

		return (n == 1);
	}
}