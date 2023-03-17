using System;

public class 배열의_유사도 {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        for(int i=0; i<s1.Length; i++)
            for(int j=0; j<s2.Length; j++)
                if(string.Compare(s1[i], s2[j], false) == 0) answer++;
        return answer;
    }
}