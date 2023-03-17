using System;

public class 캐릭터의_좌표 {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[] {0, 0};
        for(int i=0; i<keyinput.Length; i++)
        {
            if(keyinput[i] == "left" && answer[0] > 0 - (board[0]-1)/2)
                answer[0] -= 1;
            else if(keyinput[i] == "right" && answer[0] < 0 + (board[0]-1)/2)
                answer[0] += 1;
            else if(keyinput[i] == "up" && answer[1] < 0 + (board[1]-1)/2)
                answer[1] += 1;
            else if(keyinput[i] == "down" && answer[1] > 0 - (board[1]-1)/2)
                answer[1] -= 1;
        }
        return answer;
    }
}