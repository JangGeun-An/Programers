using System;
using System.Linq;

public class 최빈값_구하기 {
    public int solution(int[] array) {
        int[] val = array.Distinct().ToArray();
        int[] count = new int[val.Length];
        for(int i=0; i<count.Length; i++) count[i] = 0;
        
        for(int i=0; i<array.Length; i++)
            for(int j=0; j<val.Length; j++)
                if(array[i] == val[j]) count[j]++;
        
        Array.Sort(count, val);
        int answer = val[val.Length-1];
        int a = 0;
        for(int i=0; i<count.Length; i++)
        {
            if(count.Max() == count[i]) a++;
            if(a > 1) return -1;
        }
        return answer;
    }
}