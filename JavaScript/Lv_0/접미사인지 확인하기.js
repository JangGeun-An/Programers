function solution(my_string, is_suffix) {
    // const len = my_string.length;
    // for(let i=0; i<len; i++)
    //     {
    //         if(my_string == is_suffix) return 1;
    //         my_string = my_string.substr(1);
    //     }
    // return 0;
    return my_string.endsWith(is_suffix) ? 1 : 0;
}