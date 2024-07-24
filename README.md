# Code Katas

## Sum Of Two
Calculate the sum of two numbers, return array with indexes of the numbers. If not found, return empty array.

|Time Complexity:| O(n)|
|-|-|
|Space Complexity: |O(n)|

*Where 𝑛 is the number of elements in the numbers array.*

### Sample data:
```
var target = 11;
var arrayOfNumbers = new int[] { 1, 2, 3, 9, 0, -1 };
```

-----

## Palindrome
Validate whether a sentence is a palindrome (identical in both ways). Return true or false.

|Time Complexity:| O(n) |
|-|-|
|Space Complexity: |O(1)|

*Where 𝑛 is the length of the phrase String.*

### Sample data:
```
var phrase = "Cigar? Toss it in a can. It is so tragic.";
```

-----

## Anagram
Validate two words are anagrams. Return true or false.

|Time Complexity:| O(n+m)|
|-|-|
|Space Complexity: |O(n+m)|

*Where 𝑛 is the length of the first word String and 𝑚 is the length of the second word String.*

### Sample data:
```
var firstString = "anagram";
var secondString = "nagaram";
```

-----

## Merge Sorted Array
Two sorted arrays. Join the second array to the first and sort ascending. M and n are the number of integers that will be joined in each array. (Zeros in the first array are the numbers that will be replaced).

### Sample data:
```
var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
var nums2 = new int[] { 2, 5, 6 };

int m = 3;
int n = 3;
```

-----

## Remove Element
Remove elements in an array of integers that are equal to value given. Return count of integers remaining in the array. (resulting array doesn´t matter)

### Sample data:
```
var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
var val = 2;
```

-----


## Remove Duplicates From Sorted Array
Remove elements in an array of integers that are duplicate. Return count of integers remaining in the array. (resulting array doesn´t matter)

### Sample data:
```
var numbers = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
```

-----
