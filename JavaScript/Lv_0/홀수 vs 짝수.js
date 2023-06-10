function solution(num_list) {
    var Odd = num_list.filter((v,i) => i%2 == 1).reduce((a,c) => a+=c);
    var Even = num_list.filter((v,i) => i%2 == 0).reduce((a,c) => a+=c);
    return Odd>Even ? Odd : Even;
}