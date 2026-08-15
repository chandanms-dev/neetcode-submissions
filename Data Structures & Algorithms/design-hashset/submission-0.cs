public class MyHashSet {

    public bool[] hs;
    public MyHashSet() {
         hs = new bool[1000001];
    }
    
    public void Add(int key) {
        hs[key] = true;
    }
    
    public void Remove(int key) {
        hs[key] = false;
    }
    
    public bool Contains(int key) {
        return hs[key];
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */