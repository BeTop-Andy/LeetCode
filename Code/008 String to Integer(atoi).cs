public class Solution
{
	/// <summary>
	/// �ַ���ת���֣�
	/// �ɿ�ѡ��+��-��ʼ����ʾ��������
	/// ���������������int.MaxValue���������int.MinValue��
	/// ����ȷ���������0��
	/// ��Ŀ��ַ��https://leetcode.com/problems/string-to-integer-atoi/
	/// </summary>
	/// <param name="str">�ַ���</param>
	/// <returns>����</returns>
	public int MyAtoi(string str)
	{
		int result = 0;
		str = str.Trim();
		var regex = new System.Text.RegularExpressions.Regex(@"^(\+|-)?[0-9]+");
		string num = regex.Match(str).Value;

		try
		{
			result = Convert.ToInt32(num);
		}
		catch (System.OverflowException)
		{
			result = num.StartsWith("-") ? int.MinValue : int.MaxValue;
		}
		catch
		{

		}

		return result;
	}
}