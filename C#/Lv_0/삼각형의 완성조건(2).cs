using System;
using System.Linq;

public class 삼각형의_완성조건2 {
    public int solution(int[] sides) {
        int answer = 0;
        int max = sides.Max();
        int min = sides.Min();
        int j = max + 1;
        for(int i=1; i<=max; i++) if(max < min + i) answer++;
        while(j < max + min)
        {
            answer++;
            j++;
        }
        return answer;

        // 두번째 방법, 원리는 모르나 간단함
        // int max = sides.Max();
        // int min = sides.Min();
        // int answer = (max-(max-min)) + (min-1);
        // return answer;
    }
}