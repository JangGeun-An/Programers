using System;

public class 짝수_홀수_개수 {
    public int[] solution(int[] num_list) {
        int[] answer = new int[2]{0, 0};
        for(int i=0; i<num_list.Length; i++)
        {
            if((num_list[i]%2) == 0)
                answer[0]++;
            else
                answer[1]++;
        }
        return answer;
    }
}