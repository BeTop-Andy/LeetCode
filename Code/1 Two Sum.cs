public class Solution
{
	/// <summary>
	/// 在一个数组中找到两个数，它们的和等于目标数。（假设给的数一定有解）
	/// 题目地址：https://leetcode.com/problems/two-sum/
	/// </summary>
	/// <param name="nums">数组</param>
	/// <param name="target">目标数</param>
	/// <returns>两个数的下标（从1开始）</returns>
	public int[] TwoSum(int[] nums, int target)
	{
		int[] result = new int[2];
		var list = new List<NumWithIndex>();

		for (int i = 0; i < nums.Length; i++)
		{
			list.Add(new NumWithIndex(nums[i], i + 1));
		}

		list.Sort((a, b) => a.Num.CompareTo(b.Num));

		int q = 0;
		int p = list.Count - 1;

		while (q < p)
		{
			if (list[q].Num + list[p].Num < target)
			{
				q++;
			}
			else if (list[q].Num + list[p].Num > target)
			{
				p--;
			}
			else
			{
				if (list[q].Index > list[p].Index)
				{
					result[0] = list[p].Index;
					result[1] = list[q].Index;
				}
				else
				{
					result[0] = list[q].Index;
					result[1] = list[p].Index;
				}
				break;
			}
		}

		return result;
	}
}

/// <summary>
/// 带下标的数字
/// </summary>
public class NumWithIndex
{
	private int num;
	public int Num
	{
		get
		{
			return num;
		}
		set
		{
			num = value;
		}
	}

	private int index;
	public int Index
	{
		get
		{
			return index;
		}
		set
		{
			index = value;
		}
	}

	public NumWithIndex(int num, int index)
	{
		this.num = num;
		this.index = index;
	}
}