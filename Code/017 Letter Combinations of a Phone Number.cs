public class Solution
{
	/// <summary>
	/// 给一串数字，返回数字所能组成的字母集合（就像在电话上按一样）
	/// 题目地址：https://leetcode.com/problems/letter-combinations-of-a-phone-number/
	/// </summary>
	/// <param name="digits">数字</param>
	/// <returns></returns>
	public IList<string> LetterCombinations(string digits)
	{
		List<string> result = new List<string>();
		digits = digits.Replace("0", "");
		digits = digits.Replace("1", "");

		if (digits.Length != 0)
		{
			Queue<string> queue = new Queue<string>();
			List<List<char>> letters = new List<List<char>>();
			letters.Add(new List<char> { 'a', 'b', 'c' });
			letters.Add(new List<char> { 'd', 'e', 'f' });
			letters.Add(new List<char> { 'g', 'h', 'i' });
			letters.Add(new List<char> { 'j', 'k', 'l' });
			letters.Add(new List<char> { 'm', 'n', 'o' });
			letters.Add(new List<char> { 'p', 'q', 'r', 's' });
			letters.Add(new List<char> { 't', 'u', 'v' });
			letters.Add(new List<char> { 'w', 'x', 'y', 'z' });

			foreach (var ch in letters[digits[0] - '2'])
			{
				queue.Enqueue(ch.ToString());
			}

			string str = "";
			for (int i = 1; i < digits.Length; i++)
			{
				while (queue.Peek().Length == i)
				{
					str = queue.Dequeue();
					foreach (var ch in letters[digits[i] - '2'])
					{
						queue.Enqueue(str + ch);
					}
				}
			}

			result = queue.ToList<string>();
		}

		return result;
	}
}
