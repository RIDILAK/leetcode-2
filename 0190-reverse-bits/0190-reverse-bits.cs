public class Solution {
    public uint reverseBits(uint n) {
        uint result=0;
        for(int i=0;i<32;i++,n >>=1)
           result=(result<<1)|(n&1);
        
        return result;
    }
}