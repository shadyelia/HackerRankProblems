#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the timeInWords function below.
def timeInWords(h, m):
    md = dict({15 : "quarter past ", 30 : "half past ", 45 : "quarter to "})
    number_d = dict({0 : "", 1 : "one", 2 : "two", 3 : "three", 4 : "four", 5 : "five", 6 : "six", 7 : "seven", 8 : "eight", 9 : "nine", 10 : "ten", 11 : "eleven", 12 : "twelve", 13 : "one"})
    number_d_2 = dict({13 : "thirteen", 14 : "fourteen", 16 : "sixteen", 17 : "seventeen", 18 : "eigthteen", 19 : "nineteen"})
    number_d_3 = dict({2 : "twenty", 3 : "thirty"})

    if(m == 0):
        return number_d[h] + " " + "o' clock"
    if(m in md):
        if(m > 30):
            return md[m] + number_d[h+1]
        else:
            return md[m] + number_d[h]
    
    res = ""
    nm = m
    if(nm > 30):
        nm = 60 - nm
        
    if(nm == 1):
        res = "one minute"
    elif(nm <= 12):
        res = number_d[nm] + " minutes"
    elif(nm <= 19):
        res = number_d_2[nm] + " minutes"
    else:
        res = number_d_3[nm//10] + " " + number_d[nm % 10] + " minutes"

    if(m > 30):
        return res + " to " + number_d[h+1]
    return res + " past " + number_d[h]

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    h = int(input())

    m = int(input())

    result = timeInWords(h, m)

    fptr.write(result + '\n')

    fptr.close()
