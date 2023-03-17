public class 문자열_다루기_기본 {
    public bool solution(string s) {
        if((s.Length == 6 || s.Length == 4) && int.TryParse(s, out int i))  return true;
        return false;
    }
}