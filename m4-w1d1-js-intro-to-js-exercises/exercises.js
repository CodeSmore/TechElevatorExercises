function sumDouble(x, y) {
	let sum = x + y;
	
	if (x === y)
	{
		sum *= 2;
	}
	return sum;
}

function hasTeen (x, y, z) {
	let array = [x,y,z];
	
	for (let i = 0; i < array.length; ++i)
	{
		if (array[i] >= 13 && array[i] <= 19)
		{
			return true;
		}
	}
	
	return false;
}

function lastDigit (x, y) {
	if (x % 10 == y % 10)
	{
		return true;
	}
	return false;
}

function seeColor (theString)
{
	if (theString.substring(0, 4) == "blue")
	{
		return "blue";
	}
	else if (theString.substring(0, 3) == "red") {
		return "red";
	}
	else {
		return "";
	}
}

function middleThree (theString) {
	let numExtraLetters = (theString.length - 3) / 2;
	
	return theString.substring(numExtraLetters, theString.length - numExtraLetters);
}

function frontAgain (theString) {
	if (theString.substring(0, 2) == theString.substring(theString.length - 2)) {
		return true;
	}
	
	return false;
}

function alarmClock (day, onVaca) {
	let resultStr = "";
	
	switch (day) {
		case (0):
			resultStr = "Sunday";
			break;
		
		case (1):
			resultStr = "Monday";
			break;
		
		case (2):
			resultStr = "Tuesday";
			break;
		
		case (3):
			resultStr = "Wednesday";
			break;
		
		case (4):
			resultStr = "Thursday";
			break;
		
		case (5):
			resultStr = "Friday";
			break;
		
		case (6):
			resultStr = "Saturday";
			break;
		
	}
	
	let str2 = "";
	
	if (!onVaca) {
		if (day == 0 || day == 6) {
			str2 = " 10:00";
		}
		else {
			str2 = " 7:00";
		}
	}
	else {
		if (day == 0 || day == 6) {
				str2 = " off";
		}
		else {
				str2 = " 10:00";
		}
	}
	
	return resultStr + str2;
}

function makeMiddle (array) {
	if (array.length == 0 || array.length % 2 != 0)
	{
		return [];
	}
	
	let startPoint = (array.length / 2);
	
	return [array[startPoint-1], array[startPoint]];
}

function oddOnly (array) {
	let newArray = [];
	
	for (let i = 0; i < array.length; ++i) {
		if (array[i] % 2 != 0) {
			newArray.push(array[i]);
		}
	}
	
	return newArray;
}

function weave (ar1, ar2) {
	let diff = ar1.length - ar2.length;
	let result = [];
	
	for (let i = 0; (i < ar1.length && i < ar2.length); ++i) {
		result.push(ar1[i]);
		result.push(ar2[i]);
	}
	
	if (diff > 0)
	{
		for (let i = ar2.length; i < ar1.length; ++i) {
			result.push(ar1[i]);
		}
	}
	else if (diff < 0)
	{
		for (let i = ar1.length; i < ar2.length; ++i) {
			result.push(ar2[i]);
		}
	}
	
	return result;
}
	
function cigarParty (numCigars, isWeekend) {
	if (isWeekend) {
		if (numCigars >= 40) {
			return true;
		}
	}
	else {
		if (numCigars >= 40 && numCigars <= 60) {
			return true;
		}
	}

	return false;
}	

function stringSplosion (string) {
	result = "";
	
	for (let i = 1; i <= string.length; ++i) {
		result += string.substring(0, i);
	}
	
	return result;
}

function fizzBuzz (num) {
	if (num % 3 == 0 && num % 5 == 0) {
		return "FizzBuzz";
	}
	else if (num % 3 == 0) {
		return "Fizz";
	}
	else if (num % 5 == 0) {
		return "Buzz";
	}
	return num;
}

function countValues (array) {
	result = [];
	
	found = false;
	finalResult = [];
	
	result.push({
		key: array[0].toString(),
		value: 1
	});
	
	for (let i = 1; i < array.length; ++i) {
		console.log(result[array[i].toString()]);
		console.log(array[i]);
		if (array[i] in result) {
			result[array[i].toString()].value += 1;
			console.log("inHere");
		}
		else {
			result.push({
				key: array[i].toString(),
				value: 1
			});
		}
	}
	
	return result;
}

function reverseArray (array) {
	newArray = [];
	
	for (let i = 1; i <= array.length; ++i) {
		newArray.push(array[array.length - i]);
	}
	
	return newArray;
}

function blackJack (x, y) {
	if (x > 21 && y > 21) {
		return 0;
	}
	
	if (x <= 21 && y > 21) {
		return x;
	}
	else if (x > 21 && y <= 21) {
		return y;
	}
	
	if (x > y) {
		return x;
	}
	
	return y;
}