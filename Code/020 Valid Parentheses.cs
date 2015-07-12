public class Solution
{
	/// <summary>
	/// ≈–∂œ ‰»Îµƒ¿®∫≈ «∑Ò∆•≈‰
	/// Ã‚ƒøµÿ÷∑£∫https://leetcode.com/problems/valid-parentheses/
	/// </summary>
	/// <param name="s"></param>
	/// <returns></returns>
	public bool IsValid(string s)
	{
		bool result = true;
		Stack<char> stack = new Stack<char>();

		foreach (char ch in s)
		{
			if (ch == '(' || ch == '[' || ch == '{')	// ◊Û¿®∫≈
			{
				stack.Push(ch);
			}
			else
			{
				result = (stack.Count != 0) &&
					(stack.Peek() == '(' && ch == ')'
					|| stack.Peek() == '[' && ch == ']'
					|| stack.Peek() == '{' && ch == '}');

				if (result)
				{
					stack.Pop();
				}
				else
				{
					break;
				}
			}
		}

		return (result && (stack.Count == 0));
	}
}