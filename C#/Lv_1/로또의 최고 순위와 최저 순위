using System;

public class 로또의_최고_순위와_최저_순위 {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int goal = 0;
        int unknown = 0;
        int rank = 1;
        for(int i=0; i<lottos.Length; i++)
        {
            if(lottos[i] == 0) unknown++;
            for(int k=0; k<lottos.Length; k++)
                if(lottos[i] == win_nums[k] && lottos[i] != 0) goal++;
        }
        answer[1] = goal;
        for(int i=6; i>0; i--)
        {
            if(goal+unknown < 2) answer[0] = 6;
            if(goal+unknown == i && goal+unknown > 1) answer[0] = rank;
            if(goal < 2) answer[1] = 6;
            if(goal == i && goal+unknown > 1) answer[1] = rank;
            rank++;
        }
        return answer;
    }
}