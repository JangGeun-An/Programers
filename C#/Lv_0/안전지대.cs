using System;

public class 안전지대 {
    public int solution(int[,] board) {
        int answer = 0;
        int[,] b = board;
        int length = (int)Math.Sqrt(b.Length);

        for(int i = 0; i < length; i++)
            for(int j = 0; j < length; j++)
                if(b[i,j] == 1)
                {    
                    //왼쪽위
                    if(i>0 && j>0) b[i-1,j-1] = b[i-1,j-1]==1 ? 1 : 2;
                    
                    //위
                    if(i>0) b[i-1,j] = b[i-1,j]==1 ? 1 : 2;
                    
                    //오른쪽위
                    if(i>0 && j<length-1) b[i-1,j+1] = b[i-1,j+1]==1 ? 1 : 2;

                    //오른쪽
                    if(j<length-1) b[i,j+1] = b[i,j+1]==1 ? 1 : 2;

                    //오른쪽아래
                    if(i<length-1 && j<length-1) b[i+1,j+1] = b[i+1,j+1]==1 ? 1 : 2;

                    //아래
                    if(i<length-1) b[i+1,j] = b[i+1,j]==1 ? 1 : 2;

                    //왼쪽아래
                    if(i<length-1 && j>0) b[i+1,j-1] = b[i+1,j-1]==1 ? 1 : 2;

                    //왼쪽
                    if(j>0) b[i,j-1] = b[i,j-1]==1 ? 1 : 2;
                }

        for(int i = 0; i < length; i++)
            for(int j = 0; j < length; j++)
               if(b[i,j]==0) answer ++;
               
        return answer;
    }
}