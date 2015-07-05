public class Solution
{
	/// <summary>
	/// 从数组中【删除】所有目标数字，返回删除后的长度。（超过长度的可以不管它有什么，只关注长度内的）
	/// 题目地址：https://leetcode.com/problems/remove-element/
	/// </summary>
	/// <param name="nums"></param>
	/// <param name="val">要删除的数字</param>
	/// <returns></returns>
	public int RemoveElement(int[] nums, int val)
	{
		List<int> list = nums.ToList<int>();
		list.RemoveAll(x => x == val);

		for (int i = 0; i < list.Count; i++)
		{
			nums[i] = list[i];
		}

		return list.Count;
	}
}