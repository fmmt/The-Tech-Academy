import shutil
from tkinter import *
from tkinter import filedialog
import os
from datetime import datetime, timedelta
import sqlite3

# button click event
def fileTransfer():

    # get folder path from entry
    srcPath = varSrc.get()
    dstPath = varDst.get()

    if folderExists(srcPath) and folderExists(dstPath):
        procMain(srcPath, dstPath)
        # record date/time of 'file check' runs
        recordDatetime(datetime.now())
        # update "Date/time of last transfer" Label
        getDatetime()        
        
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

def UserfolderInput(flag):
    if flag == 1:
        labelText = "SourceFile Folder: "
        varSrc = StringVar(root)
        gridRow = 1
        var = varSrc
    elif flag == 2:
        labelText = "Destination Folder: "
        varDst = StringVar(root)
        gridRow = 2
        var = varDst
    label = Label(root, text = labelText).grid(row = gridRow, column = 0)
    entry = Entry(root, textvariable = var, width = 40).grid(row = gridRow, column = 1)
    return var

def getDatetime():
    dt = ""
    with sqlite3.connect('auto_transfer.db') as connection:
        c = connection.cursor()
        # check if table exists
        c.execute("SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'auto_transfer_datetime'")
        if c.fetchone() is None:
            # create table
            c.execute("CREATE TABLE auto_transfer_datetime (dtId INT, datetime TEXT)")
        else:
            # get most recent datetime
            c.execute("SELECT datetime FROM auto_transfer_datetime WHERE dtId = (SELECT MAX(dtId) FROM auto_transfer_datetime)")
            dt = c.fetchone()[0]
            # when there is no record in table
            if dt is None:
                dt = ""

    varDt.set(dt[:19])

def displayDatetime():
    varDt = StringVar(root)
    label = Label(root, text = 'Date/time of last transfer: ').grid(row = 0, column = 0)
    label = Label(root, textvariable = varDt).grid(row = 0, column = 1)
    return varDt

def recordDatetime(dt):
    with sqlite3.connect('auto_transfer.db') as connection:
        c = connection.cursor()
        # get maximum dtId
        c.execute("SELECT MAX(dtId) FROM auto_transfer_datetime")
        dtId = c.fetchone()[0]
        if dtId is None:
            dtId = 0
        # set new dtId
        dtId = dtId + 1
        # insert record
        c.execute("INSERT INTO auto_transfer_datetime(dtId, datetime) VALUES(" + str(dtId) + ", '" + str(dt) + "')")

def reset():
    varSrc.set("")
    varDst.set("")

if __name__ == '__main__':
    root = Tk()
    root.title("Auto File Transfer")

    varDt = displayDatetime()
    getDatetime()
    
    buttonSrc = Button(root, text = 'Brouse', command = lambda: askSource(1)).grid(row = 1, column = 2)
    buttonDst = Button(root, text = 'Brouse', command = lambda: askSource(2)).grid(row = 2, column = 2)
    buttonSt = Button(root, text = "START", command = fileTransfer).grid(row = 3, column = 2)
    buttonRs = Button(root, text = "RESET", command = reset).grid(row = 3, column = 1, sticky = E)

    varSrc = UserfolderInput(1)
    varDst = UserfolderInput(2)

    root.mainloop()


