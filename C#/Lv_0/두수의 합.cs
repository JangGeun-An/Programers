using System;

public class 두수의_합 {
            int answer;
    public int solution(int num1, int num2) {
        if((num1 >= -50000 && num1 <= 50000)&&(num2 >= -50000 && num2 <= 50000))
            answer = num1 + num2;
        return answer;
    }
}