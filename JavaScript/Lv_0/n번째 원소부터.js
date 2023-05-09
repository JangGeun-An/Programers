function solution(num_list, n) {
    return num_list.filter((x, y) => y >= n-1);
}

// slice를 이용한 방법도 있다.
// function solution(num_list, n) {
//     return num_list.slice(n-1);
// }