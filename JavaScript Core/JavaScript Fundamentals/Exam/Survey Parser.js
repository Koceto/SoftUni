function surveyParser(dataStr) {
    const surveyDataRegex = /<svg>(.*?)<\/svg>/g;
    const headingLabelAndTextCombinedRegex = /<cat>(?:.*?<text>(.+?)\[(.+?)\]<\/text>.*?)<\/cat>\s*<cat>(.*?)<\/cat>/g;
    const ratingAndValueRegex = /<g><val>(\d+)<\/val>(\d+)<\/g>/g;

    let surveyDataMatch = surveyDataRegex.exec(dataStr);

    if (surveyDataMatch == undefined) {
        return 'No survey found';
    }
    let surveyData = surveyDataMatch[1];

    let headingLebelAndTextMatches = headingLabelAndTextCombinedRegex.exec(surveyData);

    if (headingLebelAndTextMatches == null) {
        return 'Invalid format';
    }
    let heading = headingLebelAndTextMatches[1];
    let label = headingLebelAndTextMatches[2].trim();

    if (label.length < 1) {
        return 'Invalid format'; 
    }

    let text = headingLebelAndTextMatches[3];
    let ratingAndValueMatch = ratingAndValueRegex.exec(text);
    
    let totalVotes = 0;
    let totalVoteValue = 0;

    while (ratingAndValueMatch) {
        let count = Number(ratingAndValueMatch[2]);
        let value = Number(ratingAndValueMatch[1]);

        if (value <= 0 ||
            value > 10 ||
            count < 0) {
            ratingAndValueMatch = ratingAndValueRegex.exec(text);
            continue;
        }
        totalVotes += count;
        totalVoteValue += count * value;

        ratingAndValueMatch = ratingAndValueRegex.exec(text);
    }
    

    return `${label}: ${parseFloat((totalVoteValue / totalVotes).toFixed(2))}`;
}



console.log(surveyParser('<p>Some random text</p><svg><cat>   <text>How do you rate our food? [ some test ]</text>   </cat>   <cat>   <g><val>1</val>0</g><g><val>2</val>1</g><g><val>3</val>3</g><g><val>4</val>10</g><g><val>5</val>7</g><g><val>1</val>0</g>   </cat>    </svg><p>Some more random text</p>'));
console.log(surveyParser('<svg><cat><text>How do you rate the special menu? [Food - Special]</text></cat> <cat><g><val>1</val>5</g><g><val>5</val>13</g><g><val>10</val>22</g></cat></svg>'));
console.log(surveyParser("<p>How do you suggest we improve our service?</p><p>More tacos.</p><p>It's great, don't mess with it!</p><p>I'd like to have the option for delivery</p>"));
console.log(surveyParser('<svg><cat><text>Which is your favourite meal from our selection?</text></cat><cat><g><val>Fish</val>15</g><g><val>Prawns</val>31</g><g><val>Crab Langoon</val>12</g><g><val>Calamari</val>17</g></cat></svg>'));