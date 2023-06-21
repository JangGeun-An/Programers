function solution(n) {
    let answer = 0;
    if(n%2 == 1) for(let i=1; i<=n; i+=2) answer += i;
    else for(let i=0; i<=n; i+=2) answer += i*i;
    return answer;
}

// 짝수일 때는 등차수열의 합 공식, 홀수일 때는 자연수 거듭제곱의 합 공식, 반복문 사용X
// function solution(n) {
//     if(n%2===1)
//       return  (n+1)/2*((n + 1)/2) ;
//     else
//       return   n*(n+1)*(n+2)/6;
// }