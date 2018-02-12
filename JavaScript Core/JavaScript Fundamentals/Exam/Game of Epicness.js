function gameOfEpicness(generals, fights) {
    let score = new Map();
    let kingdoms = new Map();
    let parseGenerals = (kingdoms, generals) => {
        for (const general of generals) {
            if (kingdoms.has(general.kingdom)) {
                if (!kingdoms.get(general.kingdom).generals.has(general.general)) {
                    kingdoms.get(general.kingdom).generals.set(general.general, { army: Number(general.army), wins: 0, losses: 0 });
                } else {
                    kingdoms.get(general.kingdom).generals.get(general.general).army += Number(general.army);
                }
            } else {
                kingdoms.set(general.kingdom, { generals: new Map(), totalWins: 0, totalLosses: 0 });
                kingdoms.get(general.kingdom).generals.set(general.general, { army: Number(general.army), wins: 0, losses: 0 });
            }
        }
    }
    let scoreHandler = (kingdoms, general, generalScoreVariable, kingdomScoreVariable, score) => {
        kingdoms.get(general.kingdom).generals.get(general.general.name).army = Math.floor(general.general.army *= 1.1);
        kingdoms.get(general.kingdom).generals.get(general.general.name)[generalScoreVariable] += score;
        kingdoms.get(general.kingdom)[kingdomScoreVariable] += score;
    }
    let fightWinner = (kingdoms, winner, looser) => {
        scoreHandler(kingdoms, winner, 'wins', 'totalWins', 1);
        scoreHandler(kingdoms, looser, 'losses', 'totalLosses', -1);

        // kingdoms.get(winner.kingdom).generals.get(winner.general.name).army = Math.floor(winner.general.army *= 1.1);
        // kingdoms.get(winner.kingdom).generals.get(winner.general.name).wins++;
        // kingdoms.get(winner.kingdom).totalWins++;

        // kingdoms.get(looser.kingdom).generals.get(looser.general.name).army = Math.floor(looser.general.army *= 0.9);
        // kingdoms.get(looser.kingdom).generals.get(looser.general.name).losses++;
        // kingdoms.get(looser.kingdom).totalLosses++;
    }
    let startFights = (kingdoms, fights) => {
        for (const fight of fights) {
            let attackingKingdomName = fight[0];            
            let attackingKingdom = kingdoms.get(attackingKingdomName);
            let attackingGeneralArmy = attackingKingdom.generals.get(fight[1]);

            let defendingKingdomName = fight[2];            
            let defendingKingdom = kingdoms.get(defendingKingdomName);
            let defendingGeneralArmy = defendingKingdom.generals.get(fight[3]);

            let first = { kingdom: attackingKingdomName, general: { name: fight[1], army: attackingGeneralArmy.army } };
            let second = { kingdom: defendingKingdomName, general: { name: fight[3], army: defendingGeneralArmy.army } };
            
            if (fight[0] == fight[2]) {
                continue;
            }

            if (first.general.army > second.general.army) {
                fightWinner(kingdoms, first, second);
            } else if (first.general.army < second.general.army) {
                fightWinner(kingdoms, second, first);
            }
        }
    }

    parseGenerals(kingdoms, generals);
    startFights(kingdoms, fights);

    let winner = [...kingdoms].sort((a, b) => a[1].totalWins > b[1].totalWins ? -1 : 
                                            a[1].totalWins < b[1].totalWins ? 1 : 
                                            a[1].totalLosses < b[1].totalLosses ? -1 : 
                                            a[1].totalLosses > b[1].totalLosses ? 1 : 
                                            a[0] < b[0] ? -1 :
                                            a[0] > b[0] ? 1 : 0).splice(0, 1);

    let generalWinners = [...winner[0][1].generals].sort((a, b) => a[1].army > b[1].army ? -1 : a[1].army < b[1].army ? 1 : 0);
    
    result = `Winner: ${winner[0][0]}\n`;    

    for (const general of generalWinners) {
        result += `/\\general: ${general[0]}\n`;
        result += `---army: ${general[1].army}\n`;
        result += `---wins: ${general[1].wins}\n`;
        result += `---losses: ${general[1].losses}\n`;
    }

    return result;
}

console.log(gameOfEpicness([ { kingdom: "Maiden Way", general: "Merek", army: 5000 },
{ kingdom: "Stonegate", general: "Ulric", army: 4900 },
{ kingdom: "Stonegate", general: "Doran", army: 70000 },
{ kingdom: "YorkenShire", general: "Quinn", army: 0 },
{ kingdom: "YorkenShire", general: "Quinn", army: 2000 },
{ kingdom: "Maiden Way", general: "Berinon", army: 100000 } ],
[ ["YorkenShire", "Quinn", "Stonegate", "Ulric"],
["Stonegate", "Ulric", "Stonegate", "Doran"],
["Stonegate", "Doran", "Maiden Way", "Merek"],
["Stonegate", "Ulric", "Maiden Way", "Merek"],
["Maiden Way", "Berinon", "Stonegate", "Ulric"] ]));