using System;

public class 구슬을_나누는_경우의_수 {
    public int solution(int balls, int share) {
        double a = 1;
        double b = 1;
        double c = 1;
        for(int i=1; i<=balls; i++) a *= i;
        for(int i=1; i<=(balls-share); i++) b *= i;
        for(int i=1; i<=share; i++) c *= i;
        int answer = Convert.ToInt32(a/(b*c));
        return answer;
    }
}