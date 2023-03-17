using System;

public class 하샤드_수 {
    public bool solution(int x) {
        int i = 0;
        int k = x;
        while(x>0)
        {
            i += x % 10;
            x = x / 10;
        }
        if(k % i == 0) return true;
        return false;
    }
}