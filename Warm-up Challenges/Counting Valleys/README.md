# Counting Valleys

Gary is an avid hiker. He tracks his hikes meticulously, paying close attention to small details like
topography. During his last hike, he took exactly steps. For every step he took, he noted if it was an uphill
or a downhill step. Gary's hikes start and end at sea level. We define the following terms:
A mountain is a non-empty sequence of consecutive steps above sea level, starting with a step up from
sea level and ending with a step down to sea level.
A valley is a non-empty sequence of consecutive steps below sea level, starting with a step down from
sea level and ending with a step up to sea level.
Given Gary's sequence of up and down steps during his last hike, find and print the number of valleys he
walked through.
Input Format
The first line contains an integer, , denoting the number of steps in Gary's hike.
The second line contains a single string of characters. Each character is (where U indicates a
step up and D indicates a step down), and the character in the string describes Gary's step during the
hike.
Constraints
Output Format
Print a single integer denoting the number of valleys Gary walked through during his hike.

# Sample Input

8

UDDDUDUU

# Sample Output

1

# Explanation
If we represent _ as sea level, a step up as / , and a step down as \ , Gary's hike can be drawn as:
_/\ _
\ /
\/\/
It's clear that there is only one valley there, so we print on a new line


https://hackerrank-challenge-pdfs.s3.amazonaws.com/22936-counting-valleys-English?AWSAccessKeyId=AKIAJ4WZFDFQTZRGO3QA&Expires=1578075251&Signature=Q9vdMe6rOIL9pz4kezbUbZsxrxk%3D&response-content-disposition=inline%3B%20filename%3Dcounting-valleys-English.pdf&response-content-type=application%2Fpdf