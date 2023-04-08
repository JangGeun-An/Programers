function solution(box, n) {
    return ~~(box[0]/n)*~~(box[1]/n)*~~(box[2]/n);
}

// reduce 메서드를 이용한 방법
// function solution(box, n) {
//     return box.reduce((acc,v) => acc * Math.floor(v / n), 1);
// }