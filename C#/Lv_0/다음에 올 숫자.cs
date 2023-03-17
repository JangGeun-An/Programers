using System;

public class 다음에_올_숫자 {
    public int solution(int[] common) {
        int answer = 0;
        
        if(common[1]-common[0] == common[2]-common[1])
            return common[common.Length-1] + (common[1]-common[0]);
        else if(common[1]/common[0] == common[2]/common[1])
            return common[common.Length-1] * (common[1]/common[0]);
        
        return answer;
    }
}