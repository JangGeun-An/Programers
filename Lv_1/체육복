using System;
using System.Collections.Generic;

public class 체육복 {
    public int solution(int n, int[] lost, int[] reserve) {
        List<int> lost2 = new List<int>(lost);
        List<int> reserve2 = new List<int>(reserve);
        Array.Sort(reserve);
        lost2.Sort();
        reserve2.Sort();
        
        for (int i = 0; i < reserve.Length; i++)
            if (lost2.Contains(reserve[i]))
            {
                lost2.Remove(reserve[i]);
                reserve2.Remove(reserve[i]);
            }
        
        for (int i = 0; i < reserve2.Count; i++)
        {           
            if (lost2.Contains(reserve2[i] - 1)) lost2.Remove(reserve2[i] - 1);
            else if (lost2.Contains(reserve2[i] + 1)) lost2.Remove(reserve2[i] + 1);
        }
        
        return n - lost2.Count;
    }
}