using System;

public class 나이_출력 {
    int answer;
    public int solution(int age) {
        if(age > 0 && age <= 120)
            answer = 2023 - age;
        return answer;
    }
}