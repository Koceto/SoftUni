// Write a JS function that outputs a triangle made of stars with variable size, depending on an input parameter.
// The input comes as a single number argument.
// The output is a series of lines printed on the console, forming a triangle of variable size.

function printTriangle(size){
    let triangle = '';

    for (let row = 1; row <= size * 2 - 1; row++) {
        if (row <= size) {
            triangle += '*'.repeat(row) + '\r\n';
        }
        else {
            triangle += '*'.repeat(size - (row - size)) + '\r\n';
        }       
    }

    return triangle;
}

// Write a JS function that outputs a rectangle made of stars with variable size, depending on an input parameter.
// If there is no parameter specified, the rectangle should always be of size 5. Look at the examples to get an idea.
// The input comes as a single number argument.
// The output is a series of lines printed on the console, forming a rectangle of variable size

function printRectangle(size){
    return ('* '.repeat(size) + '\r\n').repeat(size);
}

// Write a JS function that checks if an input string is a palindrome.
// The input comes as a single string argument.
// The output is the return value of your function. It should be true if the string is a palindrome and false if it’s not.

function checkPalidrome(word){
    return word === word.split('').reverse().join('');
}

// Write a JS function that prints a number between 1 and 7 when a day of the week is passed to it as a string
// and an error message if the string is not recognized.
// The input comes as a single string argument.
// The output should be returned as a result of your program.

function dayOfWeek(day){
    let numberOfDay = 0;

    switch (day) {
        case 'Monday':
            numberOfDay = 1;
            break;

        case 'Tuesday':
            numberOfDay = 2;
            break;

        case 'Wednesday':
            numberOfDay = 3;
            break;

        case 'Thursday':
            numberOfDay = 4;
            break;

        case 'Friday':
            numberOfDay = 5;
            break;

        case 'Saturday':
            numberOfDay = 6;
            break;

        case 'Sunday':
            numberOfDay = 7;
            break;

        default:
        numberOfDay = 'error';
            break;
    }

    return numberOfDay;
}

// Write a JS program that receives two variables and an operator and performs a calculation between the variables, using the operator.
// Store the different functions in variables and pass them to your calculator.
// The input comes as three arguments – two numbers, and a string, representing the operator.
// The output should be printed on the console.

function doSomeMath(a, b, operator){
    let functions = {
        '+': (a, b) => a + b,
        '-': (a, b) => a - b,
        '*': (a, b) => a * b,
        '/': (a, b) => a / b
    }
    
    return functions[operator](a, b);
}

// Write a JS program that performs and outputs different operations on an array of elements. Implement the following operations:
// •	Sum(ai) - calculates the sum all elements from the input array
// •	Sum(1/ai) - calculates the sum of the inverse values (1/ai) of all elements from the array
// •	Concat(ai) - concatenates the string representations of all elements from the array
// The input comes as an array of number elements.
// The output should be printed on the console on a new line for each of the operations.

function aggregateElements(numbers){
    function aggregate(func, initialValue){
        let result = initialValue;

        for (const number of numbers) {
            result = func(result, number)
        }

        return result;
    }

    let sumFunc = (a, b) => a + b;
    let sumIverse = (a, b) => a + 1/b;
    let concatFunc = (a, b) => `${a}${b}`;

    return `${aggregate(sumFunc, 0)}\r\n${aggregate(sumIverse, 0)}\r\n${aggregate(concatFunc, '')}`;
}

// Write a JS program that extracts all words from a passed in string and converts them to upper case.
// The extracted words in upper case must be printed back on a single line concatenated by “, “.
// The input comes as a single string argument - the text from which to extract and convert the words.
// The output should be a single line containing the converted string.

function convertToupperCase(stringToConvert){
    let regex = /[^\w]/g;
    let words = stringToConvert.toUpperCase().split(regex).filter(l => l != '');

    return words.join(', ');
}