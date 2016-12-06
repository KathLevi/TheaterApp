/*SQL STATEMENTS FOR OUR FINAL DATABASE PROJECT*/
-------------
--JUST DATE--
-------------
--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR AFTER A SPCIFIC DATE--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date > {0};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR BEFORE A SPCIFIC DATE--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date < {0};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR ON A SPCIFIC DATE--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date = {0};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR FROM {0} to {1}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date >= {0} AND C.DATE <= {1};

-----------------
--DATE AND TIME--
-----------------
--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR AFTER A SPCIFIC DATE{0} AFTER A SPECIFIC TIME{1}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date > {0} AND S.TIME > {1};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR BEFORE A SPCIFIC DATE{0} AFTER A SPECIFIC TIME{1}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date < {0} AND S.Time > {1};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR ON A SPCIFIC DATE{0} AFTER A SPECIFIC TIME{1}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date = {0} AND S.Time > {1};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR FROM {0} to {1} AFTER A SPECIFIC TIME {2}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date >= {0} AND C.DATE <= {1} AND S.Time > {1};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR AFTER A SPCIFIC DATE{0} BEFORE A SPECIFIC TIME{1}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date > {0} AND S.TIME < {1};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR BEFORE A SPCIFIC DATE{0} BEFORE A SPECIFIC TIME{1}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date < {0} AND S.Time < {1};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR ON A SPCIFIC DATE{0} BEFORE A SPECIFIC TIME{1}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date = {0} AND S.Time < {1};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR FROM {0} to {1} BEFORE A SPECIFIC TIME {2}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date >= {0} AND C.DATE <= {1} AND S.Time < {2};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR AFTER A SPCIFIC DATE{0} AT A SPECIFIC TIME{1}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date > {0} AND S.TIME = {1};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR BEFORE A SPCIFIC DATE{0} AT A SPECIFIC TIME{1}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date < {0} AND S.Time = {1};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR ON A SPCIFIC DATE{0} AT A SPECIFIC TIME{1}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date = {0} AND S.Time = {1};

--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR FROM {0} to {1} AT A SPECIFIC TIME {2}--
SELECT *
FROM Schedule S LEFT OUTER JOIN Calendar C ON S.Schedule_Id = C.Cal_Id LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id
WHERE C.Date >= {0} AND C.DATE <= {1} AND S.Time = {2};

----------------------
--BOX OFFICE QUERIES--
----------------------
--PRICE OF A KID--
SELECT BO.price_kid
FROM Box_Office BO;

--PRICE OF ADULT--
SELECT BO.price_adult
FROM Box_Office BO;

--PRICE OF MATINEE--
SELECT BO.price_matinee
FROM Box_Office BO;

--PRICE OF DISCOUNTED--
Select BO.price_student_senior
FROM Box_Office BO;


---------------------
--INVENTORY QUERIES--
---------------------

-- PRODUCT NAME FOR MENU--
SELECT M.Prod_Name
FROM Menu M
WHERE M.Quantity > 0		--Don't allow out of stock items to be listed in the menu

-- LOW/ OUT OF STOCK PRODUCTS --
SELECT M.Prod_Name
FROM Menu M
WHERE M.Quantity < 50		--Reminder to place order for these items that are low/ out of stock

-- PRODUCT NAME, PRICE, AND QUANITY FOR ADVANCED DETAILS --
CREATE PROCEDURE Advanced_Details_Prod(@User TEXT)			
AS BEGIN
SELECT M.Prod_Name, M.Price, M.Quantity				--when user clicks on an item in the menu panel it will bring
FROM Menu M											--up the advanced details of the item that was clicked
WHERE M.Prod_Name LIKE @User
END

