function solution(num_list) {
    var a = num_list;
    a.at(-1) > a.at(-2) ? a.push(a.at(-1)-a.at(-2)) : a.push(a.at(-1)*2);
    return a;
}

// 더 깔끔하고 간단한 방법
// function solution(num_list) {
//     const [a, b] = [...num_list].reverse();
//     return [...num_list, a > b ? (a-b):a*2];
// }