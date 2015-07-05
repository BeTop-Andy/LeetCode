public class Solution
{
	/// <summary>
	/// �Լ�ʵ�ֳ���������ʹ�á�*������/������%��
	/// ��Ŀ��ַ��https://leetcode.com/problems/divide-two-integers/
	/// </summary>
	/// <param name="dividend">������</param>
	/// <param name="divisor">����</param>
	/// <returns>��</returns>
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
	/// ����Ƿ����
	/// </summary>
	/// <param name="dividend">������</param>
	/// <param name="divisor">����</param>
	/// <returns>��/��</returns>
	private bool CheckOverflow(int dividend, int divisor)
	{
		return (divisor == 0)
			|| (dividend == int.MinValue && divisor == -1);
	}
}