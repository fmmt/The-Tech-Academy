USE dbLibrary
GO

/****************************************
1. How many copies of the book titled The Lost Tribe are 
  owned by the library branch whose name is "Sharpstown"?
****************************************/
SELECT 
No_Of_Copies
FROM BOOK_COPIES
INNER JOIN BOOK
ON BOOK_COPIES.BookId = BOOK.BookId
INNER JOIN LIBRARY_BRANCH
ON BOOK_COPIES.BranchId = LIBRARY_BRANCH.BranchId
WHERE Title = 'The Lost Tribe'
AND BranchName = 'Sharpstown'

/****************************************
2. How many copies of the book titled The Lost Tribe are
  owned by each library branch?
****************************************/
SELECT
BranchName
,No_Of_Copies
FROM BOOK_COPIES
INNER JOIN BOOK
ON BOOK_COPIES.BookId = BOOK.BookId
INNER JOIN LIBRARY_BRANCH
ON BOOK_COPIES.BranchId = LIBRARY_BRANCH.BranchId
WHERE Title = 'The Lost Tribe'

/****************************************
3. Retrieve the names of all borrowers   who do not have any books checked out.
****************************************/
SELECT
Name
FROM BORROWER
LEFT JOIN BOOK_LOANS
ON BORROWER.CardNo = BOOK_LOANS.CardNo
WHERE BookId IS NULL

/****************************************
4. For each book that is loaned out from the "Sharpstown" branch 
  and whose DueDate is today, retrieve the book title, 
  the borrower's name, and the borrower's address.
****************************************/
SELECT
Title
,BORROWER.Name
,BORROWER.[Address]
FROM BOOK
INNER JOIN BOOK_LOANS
ON BOOK.BookId = BOOK_LOANS.BookId
INNER JOIN LIBRARY_BRANCH
ON BOOK_LOANS.BranchId = LIBRARY_BRANCH.BranchId
INNER JOIN BORROWER
ON BOOK_LOANS.CardNo = BORROWER.CardNo
WHERE BranchName = 'Sharpstown'
AND DueDate = CONVERT(VARCHAR, GETDATE(), 111)

/****************************************
5. For each library branch, retrieve the branch name 
 and the total number of books loaned out from that branch.
****************************************/
SELECT
BranchName
,TotalBookLoans
FROM
LIBRARY_BRANCH
INNER JOIN
(
	SELECT
	BranchId
	, Count(*) AS TotalBookLoans 
	FROM BOOK_LOANS
	GROUP BY BranchId
) AS TBL
ON LIBRARY_BRANCH.BranchId = TBL.BranchId

/****************************************
6. Retrieve the names, addresses, and number of books checked out 
  for all borrowers who have more than five books checked out.
****************************************/
SELECT
Name
,[Address]
,ISNULL(NoOfBooks, 0) AS NoOfBooks
FROM BORROWER
LEFT JOIN
(
	SELECT
	CardNo,
	COUNT(*) AS NoOfBooks
	FROM BOOK_LOANS
	GROUP BY CardNo
) AS TBL
ON BORROWER.CardNo = TBL.CardNo
WHERE ISNULL(NoOfBooks, 0) >= 5


/****************************************
7. For each book authored (or co-authored) by "Stephen King", 
  retrieve the title and the number of copies
  owned by the library branch whose name is "Central"
****************************************/
SELECT
Title
,No_Of_Copies
FROM BOOK
INNER JOIN BOOK_AUTHORS
ON BOOK.BookId = BOOK_AUTHORS.BookId
INNER JOIN BOOK_COPIES
ON BOOK.bookId = BOOK_COPIES.BookId
INNER JOIN LIBRARY_BRANCH
ON BOOK_COPIES.BranchId = LIBRARY_BRANCH.BranchId
WHERE AuthorName = 'Stephen King'
AND BranchName = 'Central'