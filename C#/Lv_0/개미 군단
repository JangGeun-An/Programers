using System;

public class 개미_군단 {
    public int solution(int hp) {
        int answer = 0;
        while(true)
        {
            if((hp/5) > 0)
            {
                answer = answer + (hp/5);
                hp = hp % 5;
            }
            
            else if(hp/3>0 && hp<5)
            {
                answer = answer + (hp/3);
                hp = hp % 3;
            }
            else
            {
                answer = answer + hp;
                break;
            }
        }
        return answer;
    }
}