using System;
using System.Linq;

public class 최소직사각형 {
    public int solution(int[,] sizes) {
        int[] arr1 = new int[sizes.GetLength(0)];
        int[] arr2 = new int[sizes.GetLength(0)];
        for(int i=0; i<sizes.GetLength(0); i++)
        {
            if(sizes[i,0] > sizes[i,1])
            {
                arr1[i] = sizes[i,0];
                arr2[i] = sizes[i,1];
            }
            else
            {
                arr1[i] = sizes[i,1];
                arr2[i] = sizes[i,0];
            }
        }
        int answer = arr1.Max() * arr2.Max();
        return answer;
    }
}