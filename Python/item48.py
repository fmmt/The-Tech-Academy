def start():
    list1 = [67, 45, 2, 13, 1, 998]
    list2 = [89, 23, 33, 45, 10, 12, 45, 45, 45]
    sortNumbers(list1)
    sortNumbers(list2)
    
def sortNumbers(array):
    print "\nOriginal list of numbers:"
    print array
    
    for idx in range(len(array) - 1, -1, -1):
        for i in range(idx):
            if array[i] > array[i + 1]:
                tmp = array[i + 1]
                array[i + 1] = array[i]
                array[i] = tmp
    print "Sorted:"
    print array

if __name__ == '__main__':
    start()
