function decodeTheMessage(keyWord, message) {
    let coordsRegex = /(north|east)[^0-9]*(\d{2})[^,]*?,.*?(\d{6})/gi;
    const messageRegex = new RegExp(`(${keyWord})(.+)\\1`, 'g')

    let hiddenMessage = messageRegex.exec(message)[2];
    const matches = message.match(coordsRegex);
    
    let latitude = '';
    let longitude = '';

    for (let match of matches) {
        let coordsRegex = /(north|east)[^0-9]*(\d{2})[^,]*?,.*?(\d{6})/gi;
        match = coordsRegex.exec(match);

        if (match[1].toLowerCase() == 'north') {
            longitude = `${match[2]}.${match[3]} N`
        } else {
            latitude = `${match[2]}.${match[3]} E`
        }
    }

    return `${longitude}\n${latitude}\nMessage: ${hiddenMessage.trim()}`
}

console.log(decodeTheMessage('<>', 'o u%&lu43t&^ftgv><nortH4276hrv756dcc, jytbu64574655k <>ThE sanDwich is iN the refrIGErator<>yl i75evEAsTer23,lfwe 987324tlblu6b'));
console.log(decodeTheMessage('4ds', 'eaSt 19,432567noRt north east 53,123456north 43,3213454dsNot all those who wander are lost.4dsnorth 47,874532'));
console.log(decodeTheMessage('keyword',	'keyword  let them eat cake!keywordNORTHEASTNORTH again42,north234567,dsae345East	23,432568'));
