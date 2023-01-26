using System;
using System.Linq;

public class k의_개수 {
    public int solution(int i, int j, int k) {
        int answer = 0;
        for(int l=i; l<=j; l++)
            answer += l.ToString().Count(x=>x.ToString().Equals(k.ToString()));
        return answer;
    }
}