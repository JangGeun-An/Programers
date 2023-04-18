function solution(num, k) {
    num = num.toString().split("").indexOf(k.toString());
    return num == -1 ? -1 : num+1;
}