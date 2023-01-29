using System;

public class 직사각형_넓이_구하기 {
    public int solution(int[,] dots) {
        int garo = 0;
        int sero = 0;
        
        for(int i=0; i<2; i++)
        {
            if(dots[i,0] != dots[i+1,0])
            {
                garo = dots[i,0]-dots[i+1,0];
                garo = Math.Abs(garo);
            }
            
            if(dots[i,1] != dots[i+1,1])
            {
                sero = dots[i,1]-dots[i+1,1];
                sero = Math.Abs(sero);
            }
        }
                    
        int answer = garo * sero;
        return answer;
    }
}