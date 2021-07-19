def andXorOr(a):
    if(a[0] < a[1]):
        min0 = a[0]
        min1 = a[1]
    else:
        min0 = a[1]
        min1 = a[0]

    maxResult = min0 ^ min1

    for i in range(0, len(a)-1):
        if(a[i] < min0):
            min0 = a[i]
        elif (a[i] < min1 and a[i] > min0):
            min1 = a[i]
        else:
            continue

        for j in range(i+1, len(a)):
            result = min0 ^ min1
            if(maxResult < result):
                maxResult = result
    return maxResult


if __name__ == '__main__':
    a_count = int(input())

    a = list(map(int, input().rstrip().split()))

    result = andXorOr(a)

    print(str(result) + '\n')
