function solution(arr) {
    var answer = [];
    for(let i=0; i<arr.length; i++)
        for(let j=0; j<arr[i]; j++)
            answer.push(arr[i]);
    return answer;
}

// 더 간단한 방법, fill을 사용
// function solution(arr) {
//     return arr.reduce((list, num) => [...list, ...new Array(num).fill(num)], []);
// }