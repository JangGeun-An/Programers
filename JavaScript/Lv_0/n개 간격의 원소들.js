function solution(num_list, n) {
    return num_list.filter((x,y) => y%n == 0);
}

// 더 간단한 방법, _는 사용하지 않는 변수라는 뜻
// function solution(num_list, n) {
//     return num_list.filter((_,i) => !(i%n));
// }