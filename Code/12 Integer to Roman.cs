public class Solution
{
	/// <summary>
	/// �Ѱ���������ת������������
	/// ��Ŀ��ַ��https://leetcode.com/problems/integer-to-roman/
	/// </summary>
	/// <param name="num">����������</param>
	/// <returns>��������</returns>
	public string IntToRoman(int num)
	{
		string result = "";

		if (num > 0 && num <= 3999)
		{
			string[,] romanNum = {{ "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" },
								   { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" },
								   { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" },
								   { "", "M", "MM", "MMM", "", "", "", "", "", "" }};

			int digit;		// ����
			int count = 0;	// �ڼ�λ
			while (num > 0)
			{
				digit = num % 10;
				num /= 10;

				result = romanNum[count, digit] + result;
				count++;
			}
		}

		return result;
	}
}