import shutil
from Tkinter import *
import tkFileDialog 
import os
from datetime import datetime, timedelta

# button click event
def callback():

    # get folder path from entry
    srcPath = entryOrg.get()
    dstPath = entryDst.get()

    if folderExists(srcPath) and folderExists(dstPath):
        procMain(srcPath, dstPath)
    else:
        print "Error: Please check folder paths."

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
    print "# of files copied: " + str(count)

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

#
def askSource():
    varS = StringVar()
    desName = tkFileDialog.askdirectory()
    varS.set(desName)

def UserfolderInput(status, labelText):
    frame = Frame(root)
    label = Label(frame, text = labelText)
    label.pack(side = LEFT)
    text = status
    var = StringVar(root)
    var.set(text)
    w = Entry(frame, textvariable = var)
    w.pack(side = LEFT)
    frame.pack()
    return w, var

# draw GUI
root = Tk()
root.title("Auto File Transfer")
#brouseButton = Button(text = 'SourceFile Folder', command = askSource).grid(row = 0, column = 0)
labelSrc = Label(root, text = "Source Folder: ", width = 15).grid(row = 0, column = 0)
entrySrc = Entry(root, width = 40)
entrySrc.grid(row = 0, column = 1)
buttonSrc = Button(text = 'Brouse', command = askSource).grid(row = 0, column = 2)
labelDst = Label(root, text = "Destination Folder: ", width = 15).grid(row = 1, column = 0)
entryDst = Entry(root, width = 40)
entryDst.grid(row = 1, column = 1)
buttonDst = Button(text = 'Brouse', command = askSource).grid(row = 1, column = 2)
button = Button(root, width = 10, text = "START")
button.grid(row = 2, column = 1, sticky = E)
button.config(command = callback)

w,var = UserfolderInput("", "Source")

root.mainloop()





