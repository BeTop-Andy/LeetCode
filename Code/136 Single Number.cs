public class Solution
{
	/// <summary>
	/// ��һ�����飬�����Ԫ�ض��ǳɶԳ��ֵģ�����һ���������ҳ�������
	/// Ҫ������ʱ�临�Ӷȣ����ö���Ĵ洢�ռ䡣
	/// ��Ŀ��ַ��https://leetcode.com/problems/single-number/
	/// </summary>
	/// <param name="nums">����</param>
	/// <returns>����</returns>
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