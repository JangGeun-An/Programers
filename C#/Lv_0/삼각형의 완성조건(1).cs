using System;

public class 삼각형의_완성조건1 {
    public int solution(int[] sides) {
        int answer = 0;
        if((sides[0] + sides[1] > sides[2]) && (sides[1] + sides[2] > sides[0]) && (sides[2] + sides[0] > sides[1]))
            answer = 1;
        else
            answer = 2;
        return answer;
    }
}