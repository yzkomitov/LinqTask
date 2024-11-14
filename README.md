### LINQ Exercise Tasks:
1. You are given a list of integers:
	- 1.1 Get unique numbers from the list in descending order
	- 1.2 Create a new list, containing the last 7 elements from the original list
	- 1.3 Average all without the top 3 items
2. You are given a string array. Get words in alphabetical order that are longer than 4 characters
3. You are given a string array and an accepted values array. From the input array, create an output list, containing only strings in alphabetical order that are present in the acceptedValues array
4. You are given a list of interns. Generate a list of all phone numbers from the list of Interns.
5. You are given a list of strings. Get the first item from the input list, and then every 6th item from the start => input ["a", "b", "f", "g", "y", "x", "z", "a", "z", "y", "g", "y", "x", "z", "a", "b", "f", "g", "y", "x", "z", "a", "b", "f", "g", "y", "x", "z", "y", "x", "z", "a", "z", "y", "g", "y", "x", "z", "a"], expected result ["a", "z", "x", "y",...]
6. Remove every 3rd item from the following list: ["a", "b", "f", "g", "y", "x", "z", "a", "z", "y", "g", "y", "x", "z", "a", "b", "f", "g", "y", "x", "z", "a", "b", "f", "g", "y", "x", "z", "y", "x", "z", "a", "z", "y", "g", "y", "x", "z", "a"] => expected result ["a", "b", "g", "y", "z", "a", "y", "g", "x", "z",...]
7. You are given a list of lists. Flatten the list => expected result - a single list, containing all values
8. You are given a list of strings. Get all items from it until the first null value
9. You are given 3 lists. 
	- Create a new list, containing only items, which are found in all 3 lists
	- Create a new list, containing only items, which are not repeated in any of the lists
10. You are given 2 collections. Check if they contain the same elements
11. Given the following array, output a dictionary, counting 3 items of interest - beer, whiskey and wine, along with all other items as "Other". Input: ["Beer", "Whiskey", "Beer", "Beer", "Water", "Wine", "Wine", "Boza"] => Expected output => Dictionary<string, int> { Beer: 3, Whiskey: 1, Wine: 2, Other: 2 }
12. You are given a string containing integers, which are in order. However, intervals of consecutive integers are abbreviated as follows 3-8, means 3,4,5,6,7,8. Write an LINQ expression that expands the string into a list of integers
	- Example input "2-10,14,18,20-24"
	- Required output [2,3,4,5,6,7,8,9,10,14,18,20,21,22,23,24]