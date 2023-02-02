using System;

public class 다항식_더하기 {
    public string solution(string polynomial) {
        string answer = "";
        int a = 0;
        int b = 0;
        string c = "";
        string[] str = polynomial.Split(" ");
        for(int i=0; i<str.Length; i++)
        {
            if(Int32.TryParse(str[i], out int j)) b += j;
            if(str[i] == "x" ) a += 1;
            else if(str[i].Contains("x") && str[i].Length > 1)
                a += Convert.ToInt32(str[i].Replace("x", ""));
        }
        if(b != 0) c = b.ToString();
        
        if(a == 1 && b >= 1) answer = "x + " + c;
        else if (a == 1 && b < 1) answer = "x";
        else if(a == 0) answer = c;
        else if(a != 1 && a != 0 && b > 0) answer = a.ToString() + "x + " + c;
        else answer = a.ToString() + "x";
        
        return answer;
    }
}