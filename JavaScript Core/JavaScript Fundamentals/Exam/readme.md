# <div align="center">Bitcoin "Mining"<div>
> So you have heard that a lot of people are using Bitcoins as alternative currency and mining them can make you rich quickly, without doing anything. Because of this you decided to become a miner at the local mine and start digging Bitcoins out of the ground. Well, after a few days you realized that there are no burried Bitcoins in the ground... But luckily, you started digging up gold and decided to invest it in Bitcoins, because they are cool and gold sucks. So you
started exchanging gold for BGN and buying Bitcoins with the money, and keeping track of the whole process. How many Bitcoins did you buy and how much money were you left with it at the end?

Write a JavaScript program that calculates the **total amount** of **bitcoins** you purchased with the gold you mined during your **shift** at the mine. Your shift consists of a certain number of days where you mine an amount of **gold** in **grams**. Your program will receive an **array with the amount of gold** you mined **each day**, where the **first day** of your **shift** is the **first index of the array**. Also, someone was stealing **every third day** from the start of your shift **30%** from the mined **gold** for **this day**.
For the different exchanges use these prices:
>**1** Bitcoin = **11949.16** lv.<br />
**1 g** of gold = **67.51** lv.

### Input
You will receive an array of **strings** that must be parsed as **numbers**, representing your **shift** at the mine.
### Output
Print on the **console** these lines in the following formats:<br />
* **First line** prints the **total amount** of bought **bitcoins**:<br />
**"Bought Bitcoins: {count}"**<br />
* **Second line** prints **witch day** you **bought** your **first bitcoin**:<br />
**"Day of the first purchased bitcoin: {day}"**<br />
In case you **did not purchase any bitcoins**, do not print the second line.
* **Third line** prints the **amount** of **money** that’s left after the bitcoin purchases **rounded to the second digit** after the decimal point:<br />
**"Left money: {money} lv."**

---
# <div align="center">Air Pollution</div>
> Because of recent events you have become very conscious of the air quality in Sofia. That’s why you decided to keep track of the air pollution levels by making a map. Each block of the map displays a number that represents the current particle pollution in the air at this moment. There are different forces which affect the air quality in various ways. So how clean is the air in Sofia now?
>
Write a JavaScript program that tracks the **pollution in the air** above Sofia. You will receive **two arguments** – the **first** is the **map of Sofia** represented by a **matrix of numbers** and the **second** is an **array of strings** representing the **forces affecting the air quality**. The **map** will **always** be with **5 rows** and **5 columns** in **total of 25 elements - blocks**.
Each block’s particle pollution (PM) is **affected** by **3 forces** received in the following formats:
* **"breeze {index}"** – index is **the row** where **all column’s value drops** by **15** PM
* **"gale {index}"** – index is **the column in all rows** where **value drops** by **20** PM
* **"smog {value}"** – **all blocks** in the map **increase** equally by **the given value’s** PM

The threshold in each block is **50** PM. If it is **below that number**, the block’s air is considered **normal** but if it **reaches or goes over it**, that block’s air is considered **polluted**. Also note, that the **polluted particles** in a block **cannot go
below zero**.
Finally, your program needs to **find** if there are **any polluted blocks** and **print them** in the format given below.
### Input
You will receive **two arguments**:
* The **first** argument is an **array with five strings – rows** of the matrix with **columns separated by space** that must be parsed as **numbers**, representing the **map of Sofia**.
* The **second** argument is an **array of strings** – each **string** consists of one of the **words (breeze/gale/smog)** and a **number separated by space**, representing the **different forces**.
### Output
Print on the **console** a **single line**:
* If there are **polluted blocks** in the map, **use** their **coordinates** in the following format:<br />
	* **"[{rowIndex}-{columnIndex}]"**<br />
Note that you must **start** from the **top left corner** of the map moving to the **bottom right** corner **horizontally**. Then **separate** each **formatted block’s coordinates** with **comma and space** and print them in a single line in the following format:
	* **"Polluted areas: {block1}, {block2}, {block3}, …"**
* If there are **no polluted blocks** in the map print:
	* **"No polluted areas"**
---
# <div align="center">Survey Parser</div>
Write a JavaScript program that **parses** a given **document** that may contain the results of a **rating survey** and outputs a **summary** of the votes. You will receive a **string** that contains XML-formatted data. From this data, you must extract a **valid label** and **average rating** (sum of ratings, divided by their count). Input, containing valid survey data will follow these rules:
* The document may contain **any symbol before and after** the survey data
* The survey data **always** begins with **\<svg>** and ends with **\</svg>**:
 * Any text **\<svg>** Survey data **\</svg>** Any text
* Each valid survey will contain **exactly two sections** beginning with **\<cat>** and ending with **\</cat>**
* There may be **whitespace between** the sections<br />
 * **\<cat>** Survey heading and label **</cat><cat>** Ratings **\</cat>**
* The contents of the first **cat** section must begin with **\<text>** and end with **\</text>**; it may contain **any text**, but needs to have a **valid label**, inside brackets **[ ]**
 * **\<text>** Survey heading [ **Survey Label** ]**\</text>**
* The second **cat** section contains all of the **ratings** with each vote beginning with **\<g>** and ending with **\</g>**
* A **valid rating** contains a **value** and **count**, with the **value** surrounded by **\<val>** and **\</val>** and the **count** right **after the value**
* There may be any number of **valid** and **invalid ratings** inside the second cat; you should **only process** the valid ones, and **ignore** the invalid ratings
 * **\<g>\<val>** Rating value **\</val>** Vote count **\</g>**
 * **Valid** rating: **\<g>\<val>1\</val>0\</g>**
 * **Invalid** rating (**ignore** and continue): **\<g>\<val>Seafood\</val>1\</g>**
* The **value** must be a number between **1** and **10**
* The **count** must be a number **0** or larger

If the document **does not** contain survey data (no opening and closing **svg** tags), print on the console **"No survey found"**. If there is survey data, but the rest of the rules aren’t followed, print on the console **"Invalid format"**.
At the **end** of the program, print on the **console** the **label** of the survey and the **average rating**, **rounded** to two decimal places.

---
# <div align="center">Game of Epicness</div>
>Welcome to the Game of Epicness where different kingdoms are fighting for the grant price of a bucket of Bitcoins… EPIC! In this amazing game there are many kingdoms with many generals and every general have their own army. To decide who is the winner for this totally amazing price they fight battles between them. But they are not so awesome at math, so they need you to help them record their battle results.

Write a JavaScript program that **determines** the **winner** from **all battles**. You will receive **two** arguments:
* The **first** argument is an **array of kingdoms** with **generals** and their **army** in the form of an **object** with format:<br />
 * **{ kingdom: String, general: String, army: Number }**

Every **general** has his own **army** that fights for a certain **kingdom**. Note that, every **kingdom’s name** is **unique**, and every **general’s name** is **unique** in **this kingdom**. If the **general** already **exists in** this **kingdom add** the **army** to his current one. After you go through all the kingdoms with their generals with armies and store the information about them, it’s time to start the battles.
* The **second** argument is **matrix of strings** showing which **kingdom’s generals** are **fighting** in this format:<br />
**[<br />
&ensp;&ensp;&ensp;[ "{AttackingKingdom} ", "{AttackingGeneral}", "{DefendingKingdom} ", "DefendingGeneral}" ],<br />
&ensp;&ensp;&ensp;…<br />
]**

The **first two elements** are the **names** of the **attacking general** from certain **kingdom** and the **second two** are the names of the **defending general** from certain **kingdom**. **Compare** the two general’s **armies to determine** who **wins** and who **losses** based on who have the **larger army wins**. The **winner’s army increases** with **10%** and the **loser’s army decreases** with **10%**. Keep in mind to **round** them **down** if there is any **excess army** after the battle. If there is a **draw**, **do not do anything**. **Keep track** of the **wins** and **losses** for every general’s battle.

Note that, **generals** from the **same kingdom cannot attack each other**.

After you finish with all battles you need to **find** which **kingdom wins** the game. To decide that, **first order** them by all their **general’s wins (descending)** then by their **losses (ascending)**, and finally by the **kingdom’s name** in **ascending alphabetical** order.
