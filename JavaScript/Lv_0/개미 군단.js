function solution(hp) {
    let answer = 0;
    for(let i=5; i>=1; i-=2)
        {
            answer += ~~(hp/i);
            hp = ~~(hp%i);
        }
    return answer;
}

// 더 간단하게 하는 방법
// function solution(hp) {
//     return ~~(hp/5) + ~~((hp%5)/3) + ~~((hp%5)%3);
// }