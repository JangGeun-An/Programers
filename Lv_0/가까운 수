using System;

public class 가까운_수 {
    public int solution(int[] array, int n) {
        int answer = 0;
        Array.Sort(array);
        int min = 101;
        for(int i=0; i<array.Length; i++)
            if(Math.Abs(array[i]-n)<min)
            {
                min = Math.Abs(array[i]-n);
                answer = array[i];
            }
        return answer;
    }
}