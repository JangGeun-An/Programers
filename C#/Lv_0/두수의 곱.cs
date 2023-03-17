using System;

public class 두수의_곱 {
    int answer;
    public int solution(int num1, int num2) {
        if((num1 >= 0 && num1 <= 100)&&(num2 >= 0 && num2 <= 100))
            answer = num1 * num2;
        return answer;
    }
}