using System;

public class 중앙값_구하기 {
    public int solution(int[] array) {
        Array.Sort(array);
        int answer = array[array.Length/2];
        return answer;
    }
}