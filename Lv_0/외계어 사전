using System;
using System.Linq;

public class 외계어_사전 {
    public int solution(string[] spell, string[] dic) {
        int answer = 2;
        string sp = string.Concat(spell.OrderBy(x=>x));
        for(int i=0; i<dic.Length; i++)
        {
            dic[i] = string.Concat(dic[i].OrderBy(x=>x));
            if(dic[i].Contains(sp)) answer = 1;
        }
        return answer;
    }
}