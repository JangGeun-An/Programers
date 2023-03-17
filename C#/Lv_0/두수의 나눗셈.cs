using System;

public class 두수의_나눗셈 {
    float answer;
    public int solution(int num1, int num2) {
        float n1 = num1;
        float n2 = num2;
        if((num1 >= 0 && num1 <= 100)&&(num2 >= 0 && num2 <= 100))
            answer = (n1 / n2) * 1000;
        return (int)answer;
    }
}