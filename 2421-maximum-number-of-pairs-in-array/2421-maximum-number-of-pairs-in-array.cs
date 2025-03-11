public class Solution {
    public int[] NumberOfPairs(int[] nums) {
        var dict = new Dictionary<int, int>();
        int pairs = 0, leftovers = 0;

        foreach (int num in nums) {
            if (dict.ContainsKey(num)) {
                dict[num]++;
            } else {
                dict[num] = 1;
            }

            if (dict[num] % 2 == 0) {
                pairs++; 
            }
        }

        leftovers = nums.Length - (pairs * 2);
        return new int[] { pairs, leftovers };
    }
}
