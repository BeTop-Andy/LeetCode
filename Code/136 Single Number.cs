public class Solution
{
	/// <summary>
	/// 给一个数组，里面的元素都是成对出现的，除了一个单身狗，找出单身狗。
	/// 要求线性时间复杂度，不用额外的存储空间。
	/// 题目地址：https://leetcode.com/problems/single-number/
	/// </summary>
	/// <param name="nums">数组</param>
	/// <returns>单身狗</returns>
	public int SingleNumber(int[] nums)
	{
		int result = 0;

		foreach (int num in nums)
		{
			result = result ^ num;
		}

		return result;
	}
}