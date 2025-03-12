public class Solution {
    public int MaximumCount(int[] nums) {
        int post=0;
        int neg=0;
        foreach(int num in nums){
            if(num>0){
               post++;
            } 
            if(num<0){
                neg++;
            }
           }
             return Math.Max(post,neg);
        }
      

        
    }
