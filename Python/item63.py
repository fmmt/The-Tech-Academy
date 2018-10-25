import shutil
from Tkinter import *
from os import listdir

def start():
    root = Tk()
    button = Button(root, text = "Move Files")
    button.pack()
    button.config(command = callback)

    root.mainloop()

def callback():
    moveFiles('C:\\Users\\Fumi\\Desktop\\FolderA\\', 'C:\\Users\\Fumi\\Desktop\\FolderB\\')

def moveFiles(srcPath, dstPath):
    count = 0
    newPaths = []
    for aFile in listdir(srcPath):
        if aFile.endswith('.txt'):
            try:
                shutil.move(srcPath + aFile, dstPath)
                count = count + 1
                newPaths.append(dstPath + aFile)
            except:
                print "unknown error"
                break

    print "\n" + str(count) + " files have been moved to FolderB from FolderA."
    for newPath in newPaths:
        print newPath



if __name__ == "__main__":
    start()
