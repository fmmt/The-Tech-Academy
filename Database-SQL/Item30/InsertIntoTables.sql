USE dbLibrary
GO

--CREATE TEST TABLE TO INSERT RECORDS IN BOOK TABLE
CREATE TABLE #TEST
(
BookId INT,
Title NVARCHAR(100),
PublisherName NVARCHAR(50)
)

--POPULATE TEST TABLE WITH VALUES
INSERT INTO #TEST
VALUES
(1,'Fifty Shades of Grey','Vintage Books'),
(2,'The Hunger Games','Scholastic Press'),
(3,'Catching Fire','Scholastic Press'),
(4,'Mockingjay','Scholastic Press'),
(5,'Fifty Shades Darker','Vintage Books'),
(6,'StrengthsFinder 2.0','Gallup Press'),
(7,'Gone Girl','Broadway Books'),
(8,'Fifty Shades Freed','Vintage Books'),
(9,'The Help','Berkley'),
(10,'Unbroken: A World War II Story of Survival, Resilience, and Redemption','Random House Trade Paperbacks'),
(11,'The Fault in Our Stars','Penguin Books'),
(12,'The Girl on the Train','Riverhead Books'),
(13,'Divergent','Katherine Tegen Books'),
(14,'Harry Potter and the Deathly Hallows','Arthur A. Levine Books'),
(15,'Heaven is for Real: A Little Boy''s Astounding Story of His Trip to Heaven and Back','Thomas Nelson'),
(16,'The Girl with the Dragon Tattoo','Knopf'),
(17,'Who Moved My Cheese?: An Amazing Way to Deal with Change in Your Work and in Your Life','G. P. Putnam''s Sons'),
(18,'A Game of Thrones','Bantam'),
(19,'The Goldfinch','Back Bay Books'),
(20,'Insurgent','Katherine Tegen Books')

--INSERT RECORDS TO PUBLISHER TABLE
INSERT INTO PUBLISHER
SELECT DISTINCT PublisherName AS Name, NULL, NULL FROM #TEST

--INSERT RECORDS TO BOOK TABLE
INSERT INTO BOOK
SELECT * FROM #TEST;

--CREATE TEST TABLE TO INSERT RECORDS IN BOOK_AUTHORS
CREATE TABLE #TEST2
(
	BookId INT,
	Title NVARCHAR(100),
	AuthorName NVARCHAR(50)
);

--POPULATE TEST TABLE WITH VALUES
INSERT INTO #TEST2
SELECT BookId, Title, NULL FROM BOOK;

--UPDATE TABLE WITH AuthorName
UPDATE #Test2 SET AuthorName = 'E L James' WHERE BookId = 1
UPDATE #Test2 SET AuthorName = 'Suzanne Collins' WHERE BookId = 2
UPDATE #Test2 SET AuthorName = 'Suzanne Collins' WHERE BookId = 3
UPDATE #Test2 SET AuthorName = 'Suzanne Collins' WHERE BookId = 4
UPDATE #Test2 SET AuthorName = 'E L James' WHERE BookId = 5
UPDATE #Test2 SET AuthorName = 'Tom Rath' WHERE BookId = 6
UPDATE #Test2 SET AuthorName = 'Gillian Flynn' WHERE BookId = 7
UPDATE #Test2 SET AuthorName = 'E L James' WHERE BookId = 8
UPDATE #Test2 SET AuthorName = 'Kathryn Stockett' WHERE BookId = 9
UPDATE #Test2 SET AuthorName = 'Laura Hillenbrand' WHERE BookId = 10
UPDATE #Test2 SET AuthorName = 'John Green' WHERE BookId = 11
UPDATE #Test2 SET AuthorName = 'Paula Hawkins' WHERE BookId = 12
UPDATE #Test2 SET AuthorName = 'Veronica Roth' WHERE BookId = 13
UPDATE #Test2 SET AuthorName = 'J. K. Rowling' WHERE BookId = 14
UPDATE #Test2 SET AuthorName = 'Todd Burpo' WHERE BookId = 15
UPDATE #Test2 SET AuthorName = 'Stieg Larsson' WHERE BookId = 16
UPDATE #Test2 SET AuthorName = 'Spencer Johnson' WHERE BookId = 17
UPDATE #Test2 SET AuthorName = 'George R. R. Martin' WHERE BookId = 18
UPDATE #Test2 SET AuthorName = 'Donna Tartt' WHERE BookId = 19
UPDATE #Test2 SET AuthorName = 'Veronica Roth' WHERE BookId = 20

--POPULATE BOOK_AUTHORS TABLE
INSERT INTO BOOK_AUTHORS
SELECT BookId, AuthorName FROM #TEST2

--POPULATE LIBRARY_BRANCH TABLE
INSERT INTO LIBRARY_BRANCH
VALUES
(1, 'Hillsboro Brookwood Library', '2850 NE Brookwood Pkwy, Hillsboro, OR 97124-5327'),
(2, 'Beaverton City Library', '12375 SW Fifth St, Beaverton, OR 97005-9019'),
(3, 'Aloha Community Library', '17455 SW Farmington Rd, Ste. 26A, Aloha, OR 97078'),
(4, 'Hillsboro Shute Park Library', '775 SE 10th Ave, Hillsboro, OR 97123-4784')

--POPULATE BORROWER TABLE
INSERT INTO BORROWER
VALUES
(1, 'Ken J Sánchez', '1970 Napa Ct.', '697-555-0142'),
(2, 'Terri Lee Duffy', '9833 Mt. Dias Blv.', '819-555-0175'),
(3, 'Roberto Tamburello', '7484 Roundtree Drive', '212-555-0187'),
(4, 'Rob Walters', '9539 Glenside Dr', '612-555-0100'),
(5, 'Gail A Erickson', '1226 Shoe St.', '849-555-0139'),
(6, 'Jossef H Goldberg', '1399 Firestone Drive', '122-555-0189'),
(7, 'Dylan A Miller', '5672 Hale Dr.', '181-555-0156'),
(8, 'Diane L Margheim', '6387 Scenic Avenue', '815-555-0138')

--POPULATE BOOK_COPIES
INSERT INTO BOOK_COPIES
VALUES
(1, 1, 6),
(2, 1, 5),
(4, 1, 4),
(7, 1, 2),
(10, 1, 2),
(11, 1, 2),
(14, 1, 4),
(16, 1, 5),
(17, 1, 2),
(20, 1, 4),
(1, 2, 8),
(2, 2, 5),
(3, 2, 4),
(4, 2, 3),
(6, 2, 5),
(10, 2, 3),
(11, 2, 2),
(12, 2, 4),
(15, 2, 2),
(16, 2, 4),
(19, 3, 2),
(18, 3, 2),
(13, 3, 3),
(9, 3, 4),
(8, 3, 6),
(5, 3, 3),
(4, 3, 4),
(3, 3, 6),
(2, 3, 5),
(1, 3, 6),
(20, 4, 2),
(19, 4, 3),
(18, 4, 5),
(16, 4, 4),
(14, 4, 3),
(13, 4, 2),
(11, 4, 3),
(7, 4, 4),
(2, 4, 6),
(1, 4, 6)

--IMPLEMENTING PREREQUISITES
--1. There is a book called 'The Lost Tribe'
INSERT INTO PUBLISHER
VALUES('Picador USA', NULL, NULL)

INSERT INTO BOOK
VALUES(21, 'The Lost Tribe', 'Picador USA')

INSERT INTO BOOK_AUTHORS
VALUES(21, 'Mark Lee')

--2. There is a library branch called 'Sharpstown' and one called 'Central'.
INSERT INTO LIBRARY_BRANCH
VALUES
(5, 'Sharpstown', '9178 Jumping St.'),
(6, 'Central', '5725 Glaze Drive')

--3. There are at least 20 books in the BOOK table
SELECT COUNT(*) FROM BOOK

--4. There are at least 10 authors in the BOOK_AUTHORS table
SELECT COUNT(DISTINCT(AuthorName)) FROM BOOK_AUTHORS

--5. Each library branch has at least 10 book titles, 
-- and at least two copies of each of those titles
INSERT INTO BOOK_COPIES
VALUES
(21,1,5),
(20,1,8),
(17,1,8),
(12,1,6),
(6,1,10),
(3,1,8),
(1,1,10),
(4,1,3),
(15,1,5),
(8,1,2),
(18,1,2),
(17,2,5),
(16,2,8),
(15,2,7),
(14,2,3),
(12,2,5),
(11,2,9),
(10,2,7),
(9,2,4),
(6,2,9),
(4,2,5),
(3,2,4),
(2,2,3),
(1,2,4),
(21,3,5),
(20,3,10),
(19,3,5),
(18,3,6),
(16,3,10),
(14,3,10),
(13,3,2),
(11,3,3),
(10,3,4),
(7,3,3),
(6,3,2),
(4,3,8),
(3,3,3),
(2,3,3),
(20,4,10),
(19,4,7),
(18,4,9),
(17,4,4),
(16,4,4),
(15,4,3),
(12,4,8),
(10,4,9),
(9,4,2),
(8,4,4),
(6,4,3),
(4,4,2),
(3,4,10),
(2,4,6),
(1,4,6),
(21,5,4),
(20,5,2),
(16,5,7),
(15,5,9),
(14,5,8),
(13,5,7),
(12,5,7),
(11,5,3),
(7,5,5),
(6,5,2),
(5,5,9),
(2,5,7),
(1,5,10),
(21,6,6),
(20,6,10),
(19,6,6),
(18,6,2),
(16,6,5),
(15,6,2),
(14,6,6),
(13,6,6),
(12,6,9),
(11,6,2),
(7,6,7),
(4,6,5),
(3,6,6),
(1,6,5)

--6. There are at least 8 borrowers in the BORROWER table, 
SELECT COUNT(*) FROM BORROWER

--7. There are at least 4 branches in the LIBRARY_BRANCH table.
SELECT COUNT(*) FROM LIBRARY_BRANCH

--9. There must be at least one book written by 'Stephen King'INSERT INTO PUBLISHERVALUES('Pocket Books', NULL, NULL)UPDATE BOOKSET Title = 'End of Watch', PublisherName = 'Pocket Books'WHERE BookId = 20
UPDATE BOOK_AUTHORS
SET AuthorName = 'Stephen King' WHERE BookId = 20

--8. There are at least 50 loans in the BOOK_LOANS table.--POPULATE BOOK_LOANS TABLE--DATE AND NUMBERS ARE CALUCULATED RANDOMLY BY MSEXCEL--PERIOD OF LOAN IS ASSUMED TO BE THREE WEEKSINSERT INTO BOOK_LOANSVALUES(7, 4, 2, '2015/04/02', '2015/04/23'),
(20, 4, 5, '2016/02/23', '2016/03/15'),
(15, 3, 5, '2016/07/05', '2016/07/26'),
(20, 3, 3, '2016/10/12', '2016/11/02'),
(4, 2, 3, '2017/03/15', '2017/04/05'),
(3, 3, 3, '2015/09/30', '2015/10/21'),
(17, 1, 8, '2016/12/29', '2017/01/19'),
(3, 2, 2, '2017/01/25', '2017/02/15'),
(17, 1, 2, '2016/07/30', '2016/08/20'),
(20, 3, 8, '2015/09/28', '2015/10/19'),
(19, 2, 5, '2015/06/20', '2015/07/11'),
(1, 3, 4, '2015/04/21', '2015/05/12'),
(18, 6, 6, '2017/03/19', '2017/04/09'),
(13, 4, 4, '2015/05/06', '2015/05/27'),
(5, 1, 2, '2016/06/17', '2016/07/08'),
(12, 4, 8, '2016/05/12', '2016/06/02'),
(1, 2, 5, '2015/07/20', '2015/08/10'),
(21, 5, 4, '2016/02/17', '2016/03/09'),
(4, 4, 7, '2016/03/19', '2016/04/09'),
(14, 4, 2, '2015/05/22', '2015/06/12'),
(4, 2, 7, '2016/04/29', '2016/05/20'),
(6, 5, 7, '2017/01/03', '2017/01/24'),
(15, 5, 1, '2016/12/25', '2017/01/15'),
(4, 5, 4, '2016/05/28', '2016/06/18'),
(13, 4, 5, '2016/05/04', '2016/05/25'),
(19, 3, 7, '2016/06/16', '2016/07/07'),
(19, 2, 4, '2017/04/10', '2017/05/01'),
(20, 3, 4, '2015/09/24', '2015/10/15'),
(10, 4, 7, '2017/03/18', '2017/04/08'),
(17, 5, 1, '2015/08/23', '2015/09/13'),
(3, 4, 7, '2015/09/22', '2015/10/13'),
(13, 6, 3, '2016/08/27', '2016/09/17'),
(9, 5, 6, '2015/06/05', '2015/06/26'),
(6, 4, 6, '2016/04/20', '2016/05/11'),
(18, 6, 3, '2016/08/08', '2016/08/29'),
(16, 3, 6, '2015/12/23', '2016/01/13'),
(2, 1, 6, '2016/06/12', '2016/07/03'),
(19, 4, 6, '2016/07/08', '2016/07/29'),
(21, 2, 6, '2017/04/01', '2017/04/22'),
(12, 5, 3, '2015/07/10', '2015/07/31'),
(13, 6, 1, '2016/06/04', '2016/06/25'),
(6, 3, 3, '2015/05/10', '2015/05/31'),
(11, 4, 2, '2016/03/12', '2016/04/02'),
(4, 4, 8, '2017/02/20', '2017/03/13'),
(6, 4, 2, '2017/03/17', '2017/04/07'),
(7, 3, 6, '2015/04/07', '2015/04/28'),
(5, 3, 5, '2017/03/01', '2017/03/22'),
(17, 4, 5, '2016/04/10', '2016/05/01'),
(6, 6, 2, '2015/09/28', '2015/10/19'),
(4, 4, 5, '2017/03/14', '2017/04/04'),
(13, 1, 5, '2016/05/04', '2016/05/25'),
(19, 5, 7, '2016/11/19', '2016/12/10')

--6. and at least 2 of those borrowers have more than 5 books loaned to them
SELECT CardNo, COUNT(BookId)
FROM BOOK_LOANS
GROUP BY CardNo