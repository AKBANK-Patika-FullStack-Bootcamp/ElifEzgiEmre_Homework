function First(str) {

    let newString = "";
    for (let i = str.length - 1; i >= 0; i--) {
        newString += str[i];
    }
    return newString;
}
console.log(First("First"));

function Second(str) {

    // return a new array of strings
    const arrayStrings = str.split("");
   
    // reverse the new created array elements
    const reverseArray = arrayStrings.reverse();
 
    // join all elements of the array into a string
    const joinArray = reverseArray.join("");
    
    // return the reversed string
    return joinArray;
}
console.log(Second("Second"));

function Third(str) {
    return (str === '') ? '' : Third(str.substr(1)) + str.charAt(0);
  }
  console.log(Third("Third"));

  const Fourth = (str) => {
    let string = [];
    for (const char of str) {
      string.unshift(char); 
    }
    return string.join("");
  };
  console.log(Fourth("Fourth"));
