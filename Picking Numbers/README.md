# Picking Numbers
- Given an array of integers, find and print the maximum number of integers you can select from the array
such that the absolute difference between any two of the chosen integers is .
Input Format
The first line contains a single integer, , denoting the size of the array.
The second line contains space-separated integers describing the respective values of .
Constraints
The answer will be .
Output Format
A single integer denoting the maximum number of integers you can choose from the array such that the
absolute difference between any two of the chosen integers is .

# Sample Input 0
* 6
* 4 6 5 3 3 1

# Sample Output 0
* 3

# Explanation 0
- We choose the following multiset of integers from the array: . Each pair in the multiset has an
absolute difference (i.e., and ), so we print the number of chosen integers, ,
as our answer.

# Sample Input 1
* 6
* 1 2 2 3 1 2
# Sample Output 1
* 5

# Explanation 1
- We choose the following multiset of integers from the array: . Each pair in the multiset has
an absolute difference (i.e., , , and ), so we print the number of
chosen integers, , as our answer.