public class MyHashMap {
public int?[] hm;
    public MyHashMap() {
         hm = new int?[1000001];
    }
    
    public void Put(int key, int value) {
        hm[key] = value;
    }
    
    public int Get(int key) {
        return hm[key] is null?-1:(int) hm[key];
    }
    
    public void Remove(int key) {
        hm[key] = null;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */