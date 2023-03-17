using System;

public class 푸드_파이트_대회 {
    public string solution(int[] food) {
        string answer = "0";      
        for(int i=food.Length-1; i>0; i--)
            for(int j=food[i]/2; j>0; j--)
            {
                answer += i.ToString();
                answer = i.ToString() + answer;
            }
        return answer;
    }
}