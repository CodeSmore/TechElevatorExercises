-- Write queries to return the following:
-- Make the following changes in the "world" database.

-- 1. Add Superman's hometown, Smallville, Kansas to the city table. The 
-- countrycode is 'USA', and population of 45001. (Yes, I looked it up on 
-- Wikipedia.)

SELECT city.id
FROM city
ORDER BY city.id DESC

INSERT INTO [dbo].[city]
           ([id],
           [name]
           ,[countrycode]
           ,[district]
           ,[population])
     VALUES
           (4080,
           'Smallville'
           ,'USA'
           ,'Kansas'
           ,45001)

SELECT *
FROM city
WHERE city.name = 'Smallville'

-- 2. Add Kryptonese to the countrylanguage table. Kryptonese is spoken by 0.0001
-- percentage of the 'USA' population.

INSERT INTO [dbo].[countrylanguage]
           ([countrycode]
           ,[language]
           ,[isofficial]
           ,[percentage])
     VALUES
           ('USA'
           ,'Kryptonese'
           ,0
           ,0.0001)

SELECT *
FROM countrylanguage cl
WHERE cl.language = 'Kryptonese'

-- 3. After heated debate, "Kryptonese" was renamed to "Krypto-babble", change 
-- the appropriate record accordingly.

UPDATE [dbo].[countrylanguage]
   SET 
      [language] = 'Krypto-babble'
      
 WHERE language = 'Kryptonese'

 SELECT *
FROM countrylanguage cl
WHERE cl.language = 'Kryptonese'
SELECT *
FROM countrylanguage cl
WHERE cl.language = 'Krypto-babble'

-- 4. Set the US captial to Smallville, Kansas in the country table.

UPDATE [dbo].[country]
   SET [capital] = 4080
		
     
 WHERE code = 'USA'

SELECT *
FROM country
WHERE country.code = 'USA'

SELECT *
FROM city 
WHERE city.id = 4080

-- 5. Delete Smallville, Kansas from the city table. (Did it succeed? Why?)

	SELECT * 
	FROM city
	WHERE city.id = 4080

	DELETE
	FROM city
	WHERE city.id = 4080
	--it worked because I'm awesome. Also, probably b/c it wasn't tied to any other tables through a foreign key
-- 6. Return the US captial to Washington.

SELECT *
FROM city
WHERE countrycode = 'USA' AND name LIKE 'W%'

UPDATE [dbo].[country]
   SET [capital] = 3813
		
     
 WHERE code = 'USA'

 SELECT *
FROM country
WHERE country.code = 'USA'

-- 7. Delete Smallville, Kansas from the city table. (Did it succeed? Why?)
DELETE
	FROM city
	WHERE city.id = 4080

	-- It did not succeed b/c it was already destroyed by a meteorite...caused by my actions in problem 5

-- 8. Reverse the "is the official language" setting for all languages where the
-- country's year of independence is within the range of 1800 and 1972 
-- (exclusive). 
-- (590 rows affected)

SELECT *
FROM countrylanguage cl
JOIN country c ON cl.countrycode = c.code
WHERE c.indepyear > 1800 AND c.indepyear < 1972

UPDATE countrylanguage
SET isofficial = 0
FROM countrylanguage cl
JOIN country c ON cl.countrycode = c.code
WHERE c.indepyear > 1800 AND c.indepyear < 1972

-- 9. Convert population so it is expressed in 1,000s for all cities. (Round to
-- the nearest integer value greater than 0.)
-- (4079 rows affected)

SELECT *
FROM city
WHERE population < 1

UPDATE city
SET population = population / 1000

UPDATE city
SET population = 1
WHERE population < 1



-- 10. Assuming a country's surfacearea is expressed in miles, convert it to 
-- meters for all countries where French is spoken by more than 20% of the 
-- population.
-- (7 rows affected)

SELECT c.surfacearea
FROM country c
JOIN countrylanguage cl ON c.code = cl.countrycode
WHERE cl.language = 'French' AND cl.percentage > 20

UPDATE country 
SET surfacearea = surfacearea * 2590000
FROM country c
JOIN countrylanguage cl ON c.code = cl.countrycode
WHERE cl.language = 'French' AND cl.percentage > 20
