function bitcoinMine(data) {
    data = data.map(Number).map((e, i) => (i + 1) % 3 == 0 ? e *= 0.70 : e);

    const bitcoinPrice = 11949.16;
    const goldPrice = 67.51;

    let balance = 0;
    let bitcoins = 0;
    let firstDayBought = 0;

    for (const index in data) {
        const dayOfWork = data[index];

        balance += dayOfWork * goldPrice;

        while (balance >= bitcoinPrice) {
            balance -= bitcoinPrice;
            bitcoins++;

            if (firstDayBought === 0) {
                firstDayBought = Number(index) + 1;
            }
        }
    }
    let result = '';

    if (firstDayBought != 0) {
        result = `Bought bitcoins: ${bitcoins}\nDay of the first purchased bitcoin: ${firstDayBought}\nLeft money: ${balance.toFixed(2)} lv.`;
    } else {
        result = `Bought bitcoins: ${bitcoins}\nLeft money: ${balance.toFixed(2)} lv.`
    }

    return result;
}


console.log(bitcoinMine([100, 200, 300]));