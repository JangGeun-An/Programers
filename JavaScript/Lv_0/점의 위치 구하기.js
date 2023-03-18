function solution(dot) {
    let answer = 0;
    if(dot[0] > 0)
        {
            if(dot[1] > 0) answer = 1;
            else answer = 4;
        }
    else if(dot[0] < 0)
        {
            if(dot[1] > 0) answer = 2;
            else answer = 3;
        }
    return answer;
}

// 더 간단한 방법
// function solution(dot) {
//     return dot[0] > 0 ? dot[1] > 0 ? 1 : 4 : dot[1] > 0 ? 2 : 3;
//