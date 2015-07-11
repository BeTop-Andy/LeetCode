public class Solution
{
	/// <summary>
	/// �ж�һ�����Ƿ�Ϊ2�Ĵη�
	/// ��Ŀ��ַ��https://leetcode.com/problems/power-of-two/
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