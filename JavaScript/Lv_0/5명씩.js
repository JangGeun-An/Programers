function solution(names) {
    return names.filter((v,i) => (i==0)||(i%5==0));
}

// 식의 간소화
// function solution(names) {
//     return names.filter((_,i) => !(i%5));
// }