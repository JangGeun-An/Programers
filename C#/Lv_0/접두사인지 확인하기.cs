using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        if(my_string.Length < is_prefix.Length) return 0;
        return my_string.Substring(0, is_prefix.Length) == is_prefix ? 1 : 0;
    }
}

//더 간단한 방법, IndexOf를 이용하여 찾는 문자열의 위치가 0인지 확인한다
// public class Solution {
//     public int solution(string my_string, string is_prefix) {
//         return my_string.IndexOf(is_prefix) == 0 ? 1 : 0;
//     }
// }