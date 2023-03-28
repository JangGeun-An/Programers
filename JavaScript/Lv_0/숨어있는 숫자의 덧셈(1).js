function solution(my_string) {
    let answer = 0;
    let str = my_string.replaceAll(/[^0-9]/g, "");
    for(let i of str) answer += ~~i;
    return answer;
}