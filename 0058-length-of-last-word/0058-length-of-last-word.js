/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function(s) {

    var splitString=s.trim().split(" ")
    return splitString[splitString.length-1].length;

    
};

