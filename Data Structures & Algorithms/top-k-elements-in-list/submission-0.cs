public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
         PriorityQueue<int,int> comp = new PriorityQueue<int,int>();
        Dictionary<int,int> hm = new Dictionary<int,int>();
        List<int> sol = new List<int>();

        //Building dictionary done
        for(int i = 0; i < nums.Length; i++){
            if(!hm.ContainsKey(nums[i])){
                hm.Add(nums[i],1);
            } else {
                hm[nums[i]]++;
            }
            
        }
        // process dictionary
        foreach(var (el,freq) in hm){
            comp.Enqueue(el,freq);
            if(comp.Count > k) comp.Dequeue();
        }
        foreach(var (el,freq) in comp.UnorderedItems){
            sol.Add(el);
        }

        return sol.ToArray();
    }
}
