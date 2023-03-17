using System;

public class 옹알이2 {
    public int solution(string[] babbling) {
        int answer = 0;
        for(int i=0; i<babbling.Length; i++)
        {
            int cnt = 0;
            if(babbling[i].Contains("aya")) babbling[i] = babbling[i].Replace("aya", "1");
            if(babbling[i].Contains("ye")) babbling[i] = babbling[i].Replace("ye", "2");
            if(babbling[i].Contains("woo")) babbling[i] = babbling[i].Replace("woo", "3");
            if(babbling[i].Contains("ma")) babbling[i] = babbling[i].Replace("ma", "4");
            for(int j=0; j<babbling[i].Length-1; j++) if(babbling[i][j] == babbling[i][j+1]) cnt++;
            if(Int32.TryParse(babbling[i], out int k) && cnt == 0) answer++;
        }
        return answer;

        //두번째 방법, 더 간결하고 빠름!
        // int answer = 0;
        // string[] str = new string[] {"aya", "ye", "woo", "ma" };
        // for(int i=0; i<babbling.Length; i++)
        // {
        //     string tmp = babbling[i];
        //     for(int j = 0; j < str.Length; j++)
        //         if(!tmp.Contains(str[j]+str[j])) tmp = tmp.Replace(str[j], " ");
        //     tmp = tmp.Replace(" ", "");
        //     if(tmp == "") answer++;
        // }
        // return answer;
    }
}