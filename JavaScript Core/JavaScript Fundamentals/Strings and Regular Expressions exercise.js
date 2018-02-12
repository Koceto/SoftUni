// Write a JS function that splits a text with a given delimiter.
// The input comes as 2 text arguments.
// The first one is the text you need to split and the second one is the delimiter.
// The output should consist of all elements you’ve received,
// after you’ve split the given text by the given delimiter.
// Each element should be printed on a new line.

function splitBySymbol(text, symbol){
    return text.split(symbol).join('\n');
}

// Write a JS function that repeats a given text, N times.
// The input comes as 2 arguments.
// The first argument is a text that will represent the one you need to times.
// The second one is a number will represent the times you need to times it.
// The output is a big text, containing the given one, repeated N times.

function repeatText(text, times){
    return text.repeat(times);
}

// Write a JS function that checks if a given text, starts with a given substring.
// The input comes as 2 text arguments. The first text will represent the main one. 
// The second one will represent the substring.
// The output is either “true” or “false” based on the result of the check.
// The comparison is case-sensitive!

function checkTextBegining(text, str){
    return text.indexOf(str) == 0;
}

// Write a JS function that capitalizes the given words.
// You need to make every word’s first letter – uppercase and all other letters – lowercase. 
// The input comes as a single string, containing words, separated by a space.
// The output is the same string, however with all of its words capitalized.
// Note: The words can contain any ASCII character. You need to affect only the letters

function capitalizeWords(text){
    return text.split(' ').map(e => e = e.charAt(0).toUpperCase() + e.substr(1).toLowerCase()).join(' ');
}

// Write a JS function that finds all numbers in a sequence of strings.
// The input comes as array of strings. Each element represents one of the strings.
// The output is all the numbers, extracted and printed on a single line,
// each separated by a single space.

function extractnumbers(text){
    const regex = /\d+/g;

    return text.map(e => e.match(regex)).filter(e => e != null).map(e => e.join(' ')).join(' ');
}

// Write a JS function that finds all variable names in a given string.
// A variable name starts with an underscore (“_”) and contains only Capital and Non-Capital
// English Alphabet letters and digits. Extract only their names, without the underscore.
// Try to do this only with regular expressions.
// The input comes as single string, on which you have to perform the matching.
// The output consists of all variable names, extracted and printed on a single line,
// each separated by a comma.

function extractVarNames(text){
    const regex = /\b_([a-zA-Z0-9]+)\b/g;
    let result = [];    
    let match = regex.exec(text);

    while (match) {
        result.push(match[1]);
        match = regex.exec(text);
    }

    return result.join(',');
}

// Write a JS function that finds, how many times a given word, is used in a given sentence.
// Note that letter case does not matter – it is case-insensitive. 
// The input comes as 2 string arguments. The first one will be the sentence,
// and the second one – the word.
// The output is a single number indicating the amount of times the sentence contains the word.

function countOccurrences(text, target){
    const regex = new RegExp(`\\b${target}\\b`, 'gi');

    return text.match(regex).length;
}

// Write a JS function that extracts links from a given text. 
// The text will come in the form of strings, each representing a sentence. 
// You need to extract only the valid links from it.
// The Sub-Domain must always be “www”.
// The Domain name can consist of English alphabet letters (uppercase and lowercase), 
// digits and dashes (“–“). The Domain extension consists of one or more domain blocks,
// a domain block consists of a dot followed by one or more lowercase English alphabet letters, 
// a Domain extension must have at least one domain block in order to be valid. 
// The Sub-Domain and Domain name must be separated by a single dot. 
// Any link that does NOT follow the specified above rules should be treated as invalid.

function extractLinks(text){
    const regex = /www\.([a-zA-Z0-9\-]+)(\.[a-z]+)+/g;

    return text.map(e => e.match(regex)).filter(e => e != null).map(e => e.join('\n')).join('\n');
}

// Write a JS function that hides essential client data from secret documents that went public. 
// You have to hide people’s names, phone numbers, ids and secret base names. 

function hideInformation(text){
    const regex = /[*+!_](.+?)(?=\s)/;
    let match = regex.exec(text);
    
    while (match) {
        text = text.replace(match[0], '|'.repeat(match[0].length))
        match = regex.exec(text);
    }

    return text;
}