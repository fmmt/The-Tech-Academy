import shutil
from tkinter import *
from tkinter import filedialog
import os
from datetime import datetime, timedelta

# button click event
def fileTransfer():

    # get folder path from entry
    srcPath = varSrc.get()
    dstPath = varDst.get()

    if folderExists(srcPath) and folderExists(dstPath):
        procMain(srcPath, dstPath)
    else:
        print("Error: Please check folder paths.")

# main procedure
def procMain(srcPath, dstPath):

    # initialize count of files copied
    count = 0

    for aFile in os.listdir(srcPath):
        if aFile.endswith('.txt'):
            filePath =  os.path.join(srcPath, aFile)
            if isMod(filePath, 24):
                copyFile(filePath, dstPath)
                count = count + 1

    # show result
    print ("# of files copied: " + str(count))

# check if directory exists
def folderExists(path):
    return os.path.isdir(path)

# check if file is modified in 24 hours
def isMod(filePath, hrs):
    # get datetime modified
    modDt = datetime.fromtimestamp(os.path.getmtime(filePath))
    # get datetime threshold
    thrDt = datetime.now() - timedelta(hours = hrs)
    if modDt >= thrDt:
        rt = True       
    else:
        rt = False
        
    return rt                

# copy file
def copyFile(filePath, dstPath):
    # shutil.copy method overwrites a file
    shutil.copy(filePath, dstPath)

def askSource(flag):
    desName = filedialog.askdirectory()
    if flag == 1:
        var = varSrc
    elif flag == 2:
        var = varDst
    var.set(desName)

def UserfolderInput(gridRow, flag):
    if flag == 1:
        labelText = "SourceFile Folder: "
        varSrc = StringVar(root)
        var = varSrc
    elif flag == 2:
        labelText = "Destination Folder: "
        varDst = StringVar(root)
        var = varDst
    label = Label(root, text = labelText).grid(row = gridRow, column = 0)
    entry = Entry(root, textvariable = var, width = 40).grid(row = gridRow, column = 1)
    return entry, var

def reset():
    varSrc.set("")
    varDst.set("")

if __name__ == '__main__':
    root = Tk()
    root.title("Auto File Transfer")

    buttonSrc = Button(root, text = 'Brouse', command = lambda: askSource(1)).grid(row = 0, column = 2)
    buttonDst = Button(root, text = 'Brouse', command = lambda: askSource(2)).grid(row = 1, column = 2)
    buttonSt = Button(root, text = "START", command = fileTransfer).grid(row = 2, column = 2)
    buttonRs = Button(root, text = "RESET", command = reset).grid(row = 2, column = 1, sticky = E)

    entrySrc, varSrc = UserfolderInput(0, 1)
    entryDst, varDst = UserfolderInput(1, 2)

    root.mainloop()


