// Write a JS function that prints a given array.
// The input comes as array of strings. The last element of the array is the delimiter.
// The output is the same array, printed on the console, each element separated from the others by the given delimiter.

function joinElements(arr){
    let binder = arr.pop();

    return arr.join(binder);
}

// Write a JS function that prints every element of an array, on a given step.
// The input comes as array of strings. The last element is N - the step.
// The output is every element on the N-th step starting from the first one.
// If the step is “3”, you need to print the 1-st, the 4-th, the 7-th … and so on, until you reach the end of the array.
// The elements must be printed each on a new line.

function printNthElement(arr){
    let jump = arr.pop();

    return arr.filter((a, b) => b % jump == 0).join('\r\n');
}

// Write a JS function that adds and removes numbers to / from an array. You will receive a command which can either be “add” or “remove”. 
// The initial number is 1. Each input command should increase that number, regardless of what it is.
// Upon receiving an “add” command you should add the current number to your array. 
// Upon receiving the “remove” command you should remove the last entered number, currently existent in the array.
// The input comes as array of strings. Each element holds a command. 
// The output is the array itself, with each element printed on a new line. In case of an empty array, just print “Empty”.

function addRemoveFromArray(arr){
    let resultArray = [];
    let value = 1;

    for (let i = 0; i < arr.length; i++) {
        const command = arr[i];

        if (command == 'add') {
            resultArray.push(value)
        } else {
            resultArray.pop();
        }

        value++;
    }

    return resultArray.length == 0 ? 'Empty' : resultArray.join('\r\n');
}

// Write a JS function that rotates an array.
// The array should be rotated to the right side, meaning that the last element should become the first, upon rotation. 
// The input comes as array of strings. The last element of the array is the amount of rotation you need to perform.
// The output is the resulted array after the rotations. The elements should be printed on one line, separated by a single space.

function rotateArray(arr){
    let rotations = arr.pop() % arr.length;
    let elementsToMove = arr.splice(arr.length - rotations, rotations);
    
    return elementsToMove.concat(arr).join(' ');
}

// Write a JS function that extracts only those numbers that form a non-decreasing subsequence.
// In other words, you start from the first element and continue to the end of the given array of numbers.
// Any number which is LESS THAN the current biggest one is ignored,
// alternatively if it’s equal or higher than the current biggest one you set it as the current biggest one and you continue to the next number.
// The input comes as array of numbers.
// The output is the processed array after the filtration, which should be a non-decreasing subsequence.
// Each element should be printed on a new line.

function extractIncreasingSequence(arr){
    return arr.filter((e, i) => e >= Math.max.apply(null, arr.slice(0, i))).join('\r\n');
}

// Write a JS function that orders a given array of strings, by length in ascending order as primary criteria,
// and by alphabetical value in ascending order as second criteria. The comparison should be case-insensitive.
// The input comes as array of strings.
// The output is the ordered array of strings.

function sortElements(arr){
    function compareByLengthAndByAlphabet(a, b){
        if (a.length == b.length) {
            return a >= b;
        }
        return a.length >= b.length;
    }
    return arr.sort((a, b) => compareByLengthAndByAlphabet(a, b)).join('\r\n');
}

// Write a JS function that checks if a given matrix of numbers is magical.
// A matrix is magical if the sums of the cells of every row and every column are equal. 
// The input comes as an array of arrays, containing numbers (number 2D matrix).
// The input numbers will always be positive.
// The output is a Boolean result indicating whether the matrix is magical or not.

function checkIfMagical(matrix){
    let sumRow = row => matrix[row].reduce((a, b) => a + b);
    let sumCol = col => matrix.map(row => row[col]).reduce((a, b) => a + b);
    let initialSum = sumRow(0);

    for (let i = 0; i < matrix.length; i++) {
        let rowSum = sumRow(i);
        let colSum = sumCol(i);

        if (rowSum !== initialSum || 
            colSum !== initialSum) {
            return false;
        }
    }

    return true
}