public class Solution
{
	/// <summary>
	/// �������С�ɾ��������Ŀ�����֣�����ɾ����ĳ��ȡ����������ȵĿ��Բ�������ʲô��ֻ��ע�����ڵģ�
	/// ��Ŀ��ַ��https://leetcode.com/problems/remove-element/
	/// </summary>
	/// <param name="nums"></param>
	/// <param name="val">Ҫɾ��������</param>
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