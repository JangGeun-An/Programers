function solution(my_string) {
    let answer = '';
    for(let i of my_string) answer += i === i.toUpperCase() ? i.toLowerCase() : i.toUpperCase();
    return answer;
}