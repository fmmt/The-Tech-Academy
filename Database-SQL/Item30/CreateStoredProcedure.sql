USE dbLibrary
GO

--Output number of copies of a particular book in a particular branch
CREATE PROC GetNoOfCopies @Title NVARCHAR(100), @BranchName NVARCHAR(50), @NoOfCopies INT OUT
AS
(
	SELECT 
	@NoOfCopies = No_Of_Copies
	FROM BOOK_COPIES
	INNER JOIN BOOK
	ON BOOK_COPIES.BookId = BOOK.BookId
	INNER JOIN LIBRARY_BRANCH
	ON BOOK_COPIES.BranchId = LIBRARY_BRANCH.BranchId
	WHERE Title = @Title
	AND BranchName = @BranchName
)