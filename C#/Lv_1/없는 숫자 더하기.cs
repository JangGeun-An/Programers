using System;

public class 없는_숫자_더하기 {
    public int solution(int[] numbers) {
        int answer = 0;
        string str = String.Join("", numbers);
        for(int i=0; i<10; i++)
            if(!str.Contains(i.ToString())) answer += i;
        return answer;
    }
}