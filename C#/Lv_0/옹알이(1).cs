using System;

public class 옹알이1 {
    public int solution(string[] babbling) {
        int answer = 0;
        for(int i=0; i<babbling.Length; i++)
        {
            if(babbling[i].Contains("aya")) babbling[i] = babbling[i].Replace("aya", "1");
            if(babbling[i].Contains("ye")) babbling[i] = babbling[i].Replace("ye", "2");
            if(babbling[i].Contains("woo")) babbling[i] = babbling[i].Replace("woo", "3");
            if(babbling[i].Contains("ma")) babbling[i] = babbling[i].Replace("ma", "4");
            if(Int32.TryParse(babbling[i], out int j)) answer++;
        }
        return answer;
    }
}