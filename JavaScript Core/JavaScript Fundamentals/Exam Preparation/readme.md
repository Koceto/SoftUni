
# <div align="center">The Hungry Programmer</div>
>*You and your colleagues are on a teambuilding in the mountains. You have reached the closest mountain peak and
now it is time to refresh with a meal. Unfortunately, the rest house is experiencing staff shortage so a helping hand
with the serving is needed. You see an opportunity for abundant overeating and lend your help willingly.*

Write a JavaScript program to help you calculate how many meals have you managed to snatch from the kitchen
without being seen. The input is an array of strings containing the portions of meals for serving and a series of
commands. In case you receive the command **"Serve"**, you must serve the last portion in the line, removing it from
the array and printing on the console **"{meal name} served!"**. Upon receiving the **"Eat"** command, you must eat the
first portion and print **"{meal name} eaten"** to the console. **"Add"** places the given portion at the beginning of the
line. **"Consume"** – eat all portions in the given index range and print **"Burp!"** to the console. **"Shift"** – swap the portions
at the given indexes. Upon receiving the command **"End"** the serving of plates is finished and you head over to
consume your own portion of meal. Check if given indexes are **valid**.

The input consists of the commands described above, in the following format:

* Serve
* Add **{meal}**
* Shift **{index} {index}**
* Eat
* Consume **{start index} {end index}**

If a command does not match the pattern (unrecognized keyword, missing argument) it should be **ignored**.

### Input
>*The input comes as two arrays. The first argument is an array of strings, containing portions of meals. The second
argument is and array of strings, holding the commands that need to be parsed.*

### Output
>*On the first line print the remaining portions of meals in the array in the following format:*

**"Meals left: {meal1}, {meal2}, {meal3}, …"**

>*In case there are **no meals left**, print **"The food is gone"**. On the second line print the number of the eaten meals in the following format:*

**"Meals eaten: {count}"**

---
# <div align="center">Expedition</div>

> You are on an expedition in the mountains but the signs are pointing the wrong way and no one knows how to find you – so you're lost. It is getting dark already and you remember that you have an old map of the surrounding terrain in your backpack. To read it, first you've got to decode it. If you manage to figure out the way back to the rest house, you'll get there safely. Otherwise, you'll have to spend the night in the mountains and, as you know, the night is dark and full of terrors(bears). 

You have an **encrypted** map represented by a **rectangular** matrix (**primary**) with dimensions **N x M** and **random** values of **0** and **1**. An element of the matrix with **value 0** corresponds to a **path** and an element with **value 1** – to an **obstacle** that **cannot be crossed**. In addition to the primary matrix, there is another one – **secondary** rectangular matrix, with dimensions **P x Q**. Its elements are also of **random** values (**0** and **1**). To be able to decode the map, you've got to overlay the secondary matrix on the primary matrix **n-times**. The coordinates of the element from the **primary** matrix, corresponding to the **upper-left** (**0**, **0**) element of the **secondary** matrix, are received from the input. For example, if the received input is [1, 1] you have to place the upper-left (0,0) corner of the secondary matrix at 1, 1 of the primary matrix. Use the following modification criteria for **altering the primary** matrix: 
* Element with **value 1** from the **secondary** matrix **inverts** the value of the corresponding element in the **primary** matrix; 
*  Element with **value 0** from the **secondary** matrix **doesn't change** the value of the corresponding element in the **primary** matrix;

When you're done with **all of the alterations** of the primary matrix you will get the **final** matrix. It represents the **deciphered** map of the terrain and you can use it to find your way back to the rest house. Your current location (**start**) is **always** going to be **on one of the four sides** of the matrix (**excluding the corners**) and the end will not be with the same coordinates as the start. You can only move **up**, **down**, **left** or **right**. At every moment, there will be **only one** possible direction to take, **if any**. In case you've come to a **dead end**, there is no way back and you've got to spend the night in the mountains.

### Input
You will receive four arguments – **primary** matrix, **secondary** matrix, **overlay coordinates** and **starting coordinates**. The overlay coordinates are an array of arrays, holding (x, y) coordinate pairs. The starting coordinates are also an (x, y) coordinate pair.
### Output
The first line of the output contains the number of steps made from the beginning to the end of the path. The starting point is the first step. Each cell of the matrix, holding value 0, corresponds to a single step. In case you find a way out, on the second line you must print "**Top**"/"**Bottom**"/"**Right**"/"**Left**", depending on that on which side of the matrix lies the exit (there won't be an exit in the corners of the matrix). If you've come to a dead end, you must print "**Dead end**", followed by a **quadrant number**, in which the end of the path is.

---

# <div align="center">Lost in the Mountains</div>
>The expedition is over and everyone has returned successfully to the rest house. It turns out, however, that one from the group has fallen behind. He has sent a message to the leader but his device is broken and his message contains unwanted symbols, which prevent it from being read. Since the leader does not understand anything from programming, he has assigned the task of decrypting to you.

You will receive a text (**string**), which can contain **all of the ASCII symbols**, **including new lines** and **tabs**. The location of the lost person and his message must be retrieved from this string. The text contains a **keyword** that indicates the **beginning** and the **end** of the **message**. The geographical coordinates come as **a pair** of longitude ("**east**") and latitude ("**north**") and each coordinate should meet the following conditions:

1. It should start with "**north**"/"**east**", **case-insensitive**;
2. Next come **2 digits**, which form the **whole part of the degrees**;
3. The whole part of the degrees is separated from the decimal part by "**,**" and there may be any number of characters between them, except "**,**"
4. The **decimal part** consists of **6 digits**

In case there is **more than one** longitude or latitude in the text, take the **latter**. The message is surrounded by the **keyword**, which will be the **first argument** from the input. The second argument from the input will be the **text**, containing **both the location** and **the message** of the lost person.
### Input
The first argument contains the keyword and the second argument contains the text. There will always be **at least one pair of coordinates**.
### Output
Print the latitude on the first line of the output in the following format:<br />
**\<degrees>.\<decimal part> N**<br />
On the second line of the output print the longitude in the following format:<br />
**\<degrees>.\<decimal part> E**<br />
On the last line print the message:<br />
**Message: \<message>**

---
# <div align="center">Rest House</div>

> You were able to survive the exams, and now you and your friends from the university have gathered to relax at this year's camp. The bad thing is that the person, responsible for the accommodation of the guests is gone and you can not decide on how to distribute the available rooms. Slowly, anarchy begins to take place among you - the holidaymakers, and it would be a pity to fight like little girls after you have gone through the hardship of the exams. So you decide to take things in your own hands and do the hard job...

You will receive an array of rooms and each room will be an object in the following format:<br />
**{<br />
&ensp;&ensp;&ensp;number: String,<br />
&ensp;&ensp;&ensp;type: String,<br />
}**<br />

The **number** property is the number of the room, **type** is the type of the room: "**double-bedded**" or "**triple**".
Next comes the data for the guests in an array of objects. Each object from the array holds a pair of people, as shown below:<br />
**{<br />
 &ensp;&ensp;&ensp;first:<br />
&ensp;&ensp;&ensp; {<br />
 &ensp;&ensp;&ensp;&ensp;&ensp;&ensp;name: String,<br />
 &ensp;&ensp;&ensp;&ensp;&ensp;&ensp;gender: String,<br />
 &ensp;&ensp;&ensp;&ensp;&ensp;&ensp;age: Number<br />
 &ensp;&ensp;&ensp;},<br />
 &ensp;&ensp;&ensp;second:<br />
&ensp;&ensp;&ensp; {<br />
 &ensp;&ensp;&ensp;&ensp;&ensp;&ensp;name: String,<br />
 &ensp;&ensp;&ensp;&ensp;&ensp;&ensp;gender: String,<br />
 &ensp;&ensp;&ensp;&ensp;&ensp;&ensp;age: Number<br />
 &ensp;&ensp;&ensp;}<br />
}**<br />

The **name** property holds two names – first name and last name of the person, separated by a space. The **gender** property can be one of two values: "**female**" or "**male**".

Accommodation conditions for guests:
* If the couple is a **male and a female**, they must be accommodated in the **first free double** room;
* If the couple is of two people of **the same gender**, they should be accommodated in a **triple** room;
* If there is **free** space in a **triple** room, it must be filled by a **guest** or **guests** of **the same gender** as the one **already staying** in the room;

A couple with guests of the same gender **should be split up** to fill the free beds in a **triple** room. Sort the rooms by room number in **ascending alphanumeric** order.
For each room, print its number:
**Room number: \<room number>**

Sort the guests in each room by their name, in **ascending alphabetical** order, then print their names and age:<br />
**--Guest Name: \<full name>**<br />
**--Guest Age: \<age>**<br /><br />

Print the number of free beds in each room:<br />
**Empty beds in the room: \<number of empty beds>**<br />
The last line from the output should contain the number of people **without a room**, in the following format:<br />
**Guests moved to the tea house: \<number of people>**<br />
