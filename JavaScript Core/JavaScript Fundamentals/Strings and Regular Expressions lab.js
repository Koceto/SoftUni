// Write a JS function that prints all the symbols of a string, each on a new line.
// The input comes as a single string argument.
// The output is printed on the console, each letter on a new line.

function printLetters(str){
    let result = '';

    for (let i = 0; i < str.length; i++) {
        result += `str[${i}] -> ${str[i]}\n`        
    }

    return result.trim();
}

// Write a JS function that reverses a series of strings and prints them concatenated from last to first.
// The input comes as an array of strings.
// The output is printed on the console. Print all strings concatenated on a single line, starting from the last input string,
// going to the first. Reverse each individual string’s letters.

function concatAndReverse(arr){
    return arr.join('').split('').reverse().join('');
}

// Write a JS function that counts how many times a string occurs in a given text. Overlapping strings are allowed.
// The input comes as two string arguments.
// The first element is the target string and the second element is the text in which to search for occurrences.
// The output should be a number, printed on the console.

function countOccurrences(target, message){
    return message.split(target).length - 1;
}

// You will be given a text as a string. Write a JS function that extracts and prints only the text that’s surrounded by parentheses.
// The input comes as a single string argument.
// The output is printed on the console on a single line, in the form of a comma-separated list.

function extractText(text){
    const regex = /(?<=\().+?(?=\))/g;

    return text.match(regex).join(', ');
}

// You will be given a list of towns and incomes for each town, formatted in a table, separated by pipes (|).
// Write a JS function that extracts the names of all towns and produces a sum of the incomes.
// Note that splitting may result in empty string elements and the number of spaces may be different in every table.
// The input comes as array of string elements. Each element is one row in a formatted table.
// The output is printed on the console on two lines.
// On the first line, print a comma-separated list of all towns and on the second, the sum of all incomes.

function aggregateData(data){
    const regex = /(\w+\s*\w+)\s+\|\s+(\d+)/;
    let result = [];
    let sum = 0;

    for (let i = 0; i < data.length; i++) {
        const element = data[i];        
        let match = regex.exec(element);
        
        if (match != null) {            
            result.push(match[1]);
            sum += Number(match[2]);
        }
    }

    return result.join(', ') + '\n' + sum;
}

// You are tasked to write a JS function that receives an array of purchases and their prices and prints all your purchases
// and their total sum.
// The input comes as an array of string elements – the elements on even indexes (0, 2, 4…) are the product names,
// while the elements on odd indexes (1, 3, 5…) are the corresponding prices.
// The output should be printed on the console - a single sentence containing all products and their total sum in the format 
// “You purchased {all products separated by comma + space} for a total sum of {total sum of products}”.

function restaurantBill(data){
    let articles = data.filter((e, i) => i % 2 == 0);
    let totalSum = data.filter((e, i) => i % 2 != 0).map(Number).reduce((a, b) => a + b);

    return `You purchased ${articles.join(', ')} for a total sum of ${totalSum}`;
}

// Write a JS function that parses a list of emails and returns a list of usernames, generated from them.
// Each username is composed from the name of the email address, a period and the first letter of every element in the domain name.
// See the examples for more information.
// The input comes as array of string elements. Each element is an email address.
// The output is printed on the console on a single line as a comma-formatted list.

function getUserNames(data){
    const regex = /(\w+)@([\w\s\.]+)/;
    let usernames = [];

    for (let i = 0; i < data.length; i++) {
        const element = data[i];
        const match = regex.exec(element);
        
        usernames.push(match[1] + '.' + match[2].split('.').map(a => a[0]).join(''));
    }

    return usernames.join(', ');
}


// The thought police are at it again and they need your help! Write a JS function that would censor news articles.
// You will be given a text and then a list of strings that need to be blacked out from the text.
// Replace all occurrences of the strings with dashes of the same length as the string.
// The strings will not overlap, so order of processing is not important. See the examples for more information.
// The input comes as two arguments – one string and one array of strings. 
// The first element is the text to scan and the array contains the strings to be censored.
// The output is the return value of your functions. Save the censored results in a string and return it.

function censorText(text, censorData) {
    for (let i = 0; i < censorData.length; i++) {
        const element = censorData[i];
        let regex = new RegExp(element, 'g');
        
        text = text.replace(regex, '-'.repeat(element.length))
    }

    return text;
}

// You will be given a list of strings, containing user-submitted data.
// Write a JS function that prints an HTML list from the data. 
// The strings, however, may contain special HTML characters, which is an oft-used method for injection attacks. 
// To prevent unwanted behavior or harmful content,
// all special characters need to be replaced with their encoded counterparts – they will look the same to the user,
// but will not pose a security risk.

function htmlEscape(input) {
    const regex = /[<>&"]/g;
    const symbols = {
        '<': '&lt;', 
        '>': '&gt;', 
        '&': '&amp;', 
        '"': '&quot;'
    }
    
    let result = '<ul>\n';

    for (let inputIndex = 0; inputIndex < input.length; inputIndex++) {
        let userStr = input[inputIndex];
        let matches = userStr.match(regex);
        
        for (const matchIndex in matches) {
            const match = matches[matchIndex];
            
            userStr = userStr.replace(match, symbols[match]);
        }
        
        result += `\t<li>${userStr}</li>\n`;
    }    

    result += '</ul>'

    return result;
}