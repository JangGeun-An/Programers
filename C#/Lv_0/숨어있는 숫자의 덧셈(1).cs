using System;

public class 숨어있는_숫자의_덧셈1 {
    public int solution(string my_string) {
        int answer = 0;
        for(int i=0; i<my_string.Length; i++)
            if('0' <= my_string[i] && my_string[i] <= '9')
                answer += (Convert.ToInt32(my_string[i]) - 48);
        return answer;
    }
}