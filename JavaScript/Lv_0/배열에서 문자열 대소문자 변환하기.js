function solution(strArr) {
    return strArr.map((a,c) => c%2 ==0 ? a.toLowerCase() : a.toUpperCase());
}