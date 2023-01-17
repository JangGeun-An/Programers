using System;

public class 숫자_비교하기 {
    int answer;
    public int solution(int num1, int num2) {
        if((num1 >= 0 && num1 <= 10000)&&(num2 >= 0 && num2 <= 10000))
        {
            if(num1 == num2)
                answer = 1;
            else
                answer = -1;
        }
        return answer;
    }
}