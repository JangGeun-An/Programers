function solution(my_string) {
    var answer = '';
    for(let i of my_string) if(answer.indexOf(i) == (-1)) answer += i;
    return answer;
}

// 더 간단한 방법, Set을 이용한다.
// function solution(my_string) {
//     return [...new Set(my_string)].join('');
// }