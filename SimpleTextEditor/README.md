# Simple Text Editor

In this challenge, you must implement a simple text editor. Initially, your editor contains an empty string,
. You must perform operations of the following types:
1. append - Append string to the end of .
2. delete - Delete the last characters of .
3. print - Print the character of .
4. undo - Undo the last (not previously undone) operation of type or , reverting to the state it
was in prior to that operation.
Input Format
The first line contains an integer, , denoting the number of operations.
Each line of the subsequent lines (where ) defines an operation to be performed. Each
operation starts with a single integer, (where ), denoting a type of operation as defined in
the Problem Statement above. If the operation requires an argument, is followed by its space-separated
argument. For example, if and , line will be 1 abcd .
Constraints
The sum of the lengths of all in the input .
The sum of over all delete operations .
All input characters are lowercase English letters.
It is guaranteed that the sequence of operations given as input is possible to perform.
Output Format
Each operation of type must print the character on a new line.

# Sample Input
8

1 abc

3 3

2 3

1 xy

3 2

4

4

3 1

# Sample Output

c

y

a

Explanation
Initially, is empty. The following sequence of operations are described below:
1. . We append to , so .
2. Print the character on a new line. Currently, the character is c .
3. Delete the last characters in ( ), so .
4. Append to , so .
5. Print the character on a new line. Currently, the character is y .
6. Undo the last update to , making empty again (i.e., ).
7. Undo the next to last update to (the deletion of the last characters), making .
8. Print the character on a new line. Currently, the character is a 