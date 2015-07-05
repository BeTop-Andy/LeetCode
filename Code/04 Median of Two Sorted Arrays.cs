public class Solution
{
	/// <summary>
	/// 求两个已排序的数组的中位数（有可能其中一个数组为空），时间复杂度为O(m+n)，需求为O(log(m+n))
	/// 题目地址：https://leetcode.com/problems/median-of-two-sorted-arrays/
	/// </summary>
	/// <param name="nums1"></param>
	/// <param name="nums2"></param>
	/// <returns>中位数</returns>
	public double FindMedianSortedArrays(int[] nums1, int[] nums2)
	{
		double result = 0;
		int count = 0;
		int length1 = nums1.Length;
		int length2 = nums2.Length;

		if (length1 == 0)
		{
			result = FindMedian(nums2);
		}
		else if (length2 == 0)
		{
			result = FindMedian(nums1);
		}
		else
		{
			int i = 0;
			int j = 0;

			if ((length1 + length2) % 2 != 0)
			{
				while (count < (length1 + length2) / 2 + 1)
				{
					if (i < length1 && j < length2)
					{
						if (nums1[i] < nums2[j])
						{
							result = nums1[i];
							i++;
						}
						else
						{
							result = nums2[j];
							j++;
						}
					}
					else if (i < length1)
					{
						result = nums1[i];
						i++;
					}
					else if (j < length2)
					{
						result = nums2[j];
						j++;
					}
					count++;
				}
			}
			else
			{
				int countMax = (length1 + length2) / 2 + 1;
				int result1 = 0;
				int result2 = 0;

				while (count < countMax)
				{
					if (i < length1 && j < length2)
					{
						if (nums1[i] < nums2[j])
						{
							result1 = result2;
							result2 = nums1[i];
							i++;
						}
						else if (nums1[i] > nums2[j])
						{
							result1 = result2;
							result2 = nums2[j];
							j++;
						}
						else
						{
							if (countMax - count == 1)
							{
								if (i + 1 < length1)
								{
									result1 = result2;
									result2 = nums1[i];
									i++;
								}
								else
								{
									result1 = result2;
									result2 = nums2[j];
									j++;
								}
							}
							else
							{
								result1 = nums1[i];
								result2 = nums2[j];
								i++;
								j++;
								count++;
							}
						}
					}
					else if (i < length1)
					{
						result1 = result2;
						result2 = nums1[i];
						i++;
					}
					else if (j < length2)
					{
						result1 = result2;
						result2 = nums2[j];
						j++;
					}

					count++;
				}

				result = Avg(result1, result2);
			}
		}

		return result;
	}

	/// <summary>
	/// 求2个数的平均数
	/// </summary>
	/// <param name="a"></param>
	/// <param name="b"></param>
	/// <returns>平均数</returns>
	private double Avg(int a, int b)
	{
		return (a + b) / 2.0;
	}

	/// <summary>
	/// 求数组的中位数
	/// </summary>
	/// <param name="nums"></param>
	/// <returns>中位数</returns>
	private double FindMedian(int[] nums)
	{
		int length = nums.Length;
		return (length % 2 != 0) ? (nums[length / 2]) : Avg(nums[length / 2 - 1], nums[length / 2]);
	}
}
