// Write a JS function that calculates and prints the sum of the first and the last elements in an array.

function sumBorderElements(arr){
    return Number.parseInt(arr[0]) + Number.parseInt(arr[arr.length - 1]);
}

// Write a JS function that finds the elements at even positions in an array.

function findElementsAtEvenPositions(arr){
    let result = '';

    for (let index = 0; index < arr.length; index += 2) {
        result += arr[index] + ' ';
    }

    return result;
}

// Write a JS function that processes the elements in an array one by one and produces a new array.
// Prepend each negative element at the front of the result and append each positive (or 0) element at the end of the result.

function weirdSort(arr){
    let result = [];

    for (let index = 0; index < arr.length; index++) {
        const element = arr[index];

        if (element < 0) {
            result.unshift(element);
        } else {
            result.push(element);
        }
    }

    return result;
}

// Write a JS function that prints the first k and the last k elements from an array of numbers.
// The input comes as array of number elements. The first element represents the number k,
// all other elements are from the array that needs to be processed.
// The output is printed on the console on two lines. On the first line print the first k elements, separated by space.
// On the second line print the last k elements, separated by space.

function findTheNthElement(arr){
    let n = arr.shift();

    return arr.slice(0, n).join(' ') + '\r\n' + arr.slice(n * -1).join(' ');
}

// You are given two integers n and k. Write a JS function that generates and prints the following sequence:
// •	The first element is 1
// •	Every following element equals the sum of the previous k elements
// •	The length of the sequence is n elements
// The input comes as two number arguments. The first element represents the number n, and the second – the number k.

function generateSequence(n, k){
    let result = [1];

    for (let index = 1; index < n; index++) {    
        let startElement = Math.max(0, index - k);   

        result[index] = result.slice(startElement, index).reduce((a, b) => { return a + b }, 0);
    }

    return result;
}

// You are given an array of numbers. Write a JS function that prints the elements at odd positions from the array, doubled and in reverse order.

function reverseSumOdd(arr){
    return arr.filter((e, i) => i % 2 != 0).reverse().map(e => e * 2);
}

// Write a JS function that prints the two smallest elements from an array of numbers.
// The input comes as array of number elements.
// The output is printed on the console on a single line, separated by space.

function smallestTwo(arr){
    return arr.sort((a, b) => a - b).splice(0, 2);
}

// Write a JS function that finds the biggest element inside a matrix.
// The input comes as array of arrays, containing number elements (2D matrix of numbers).
// The output is the return value of your function. Find the biggest element and return it.

function maxInMatrix(matrix){
    return matrix.map(arr => arr.sort((a, b) => b - a)[0]).sort((a, b) => b - a)[0];
}

// A square matrix of numbers comes as an array of strings, each string holding numbers (space separated).
// Write a JS function that finds the sum at the main and at the secondary diagonals.
// The input comes as array of arrays, containing number elements (2D matrix of numbers).
// The output is printed on the console, on a single line separated by space. First print the sum at the main diagonal, then the sum at the secondary diagonal.

function sumDiagonals(matrix){
    let mainDiagonalSum = 0;
    let secondaryDiagonalSum = 0;

    for (let i = 0; i < matrix.length; i++) {
        let secondaryIndex = matrix.length - i - 1;

        mainDiagonalSum += Number.parseInt(matrix[i][i]);
        secondaryDiagonalSum += Number.parseInt(matrix[i][secondaryIndex]);
    }

    return mainDiagonalSum + ' ' + secondaryDiagonalSum;
}

// Write a JS function that finds the number of equal neighbour pairs inside a matrix of variable size and type (numbers or strings).

function findPairsInMatrix(matrix){
    let pairsCount = 0;

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            if (row + 1 < matrix.length) {
                if (matrix[row][col] === matrix[row + 1][col]) {
                    pairsCount++;
                }
            }

            if (col + 1 < matrix[row].length) {
                if (matrix[row][col] === matrix[row][col + 1]) {
                    pairsCount++;
                }
            }
        }        
    }

    return pairsCount;
}