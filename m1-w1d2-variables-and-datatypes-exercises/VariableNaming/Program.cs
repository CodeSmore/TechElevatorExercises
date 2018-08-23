using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
        
            /*
            INSTRUCTIONS

            The primary purposes of these exercises are to practice: 
                    
                    1. declaring variables and using assignment statements
                    2. using variables, literals, and operators within arithmetic expressions
                    3. choosing meaningful variable names
                    4. choosing appropriate data types

            One of the hardest things about programming is choosing good names. Spend time
            to find good, meaningful, and descriptive names for your variables. Clarity and
            expressiveness is more important than brevity. Err on the side of longer, more 
            descriptive names over short, cryptic ones.

            Be consistent with your choice of datatypes, especially when it comes to 
            some values like money. There are many different ways to express money. Pick one, 
            and stick with it throughout these exercises.
            
            Keep your code consistent and well formatted. When code is poorly indented, 
            or lost in a flood of blank lines, it can make code difficult to read. 
            */

            /* 
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch? 
            */
            
            // ### EXAMPLE:  
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /* 
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests? 
            */
            
            // ### EXAMPLE: 
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;

            /* 
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods? 
            */

            int numRaccoonsPlayingInWoods = 3;
            int numRaccoonsWentHome = 2;
            int numRaccoonsLeftInWoods = numRaccoonsPlayingInWoods - numRaccoonsWentHome;

            /* 
            4. There are 5 flowers and 3 bees. How many less bees than flowers? 
            */

            int numFlowers = 5;
            int numBees = 3;
            int numLessBeesThanFlowers = numFlowers - numBees;

            /* 
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now? 
            */

            int numOriginalPigeons = 1;
            int numNewArrivalPigeons = 1;
            int numTotalPigeons = numOriginalPigeons + numNewArrivalPigeons;

            /* 
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now? 
            */

            int numOriginalOwlsOnFence = 3;
            int numOwlsJoinedOnFence = 2;
            int totalNumOfOwlsOnFence = numOriginalOwlsOnFence + numOwlsJoinedOnFence;

            /* 
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home? 
            */

            int numWorkingBeavers = 2;
            int numSlackingBeavers = 1;
            int numResponsibleBeavers = numWorkingBeavers - numSlackingBeavers;

            /* 
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all? 
            */

            int numToucansOnTree = 2;
            int numToucansThatJoined = 1;
            int sumToucansOnTree = numToucansOnTree + numToucansThatJoined;

            /* 
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts? 
            */

            int numSquirrelsInTree = 4;
            int numNuts = 2;
            int numMoreSquirrelsThanNuts = numSquirrelsInTree - numNuts;

            /* 
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find? 
            */

            int numQuarters = 1;
            int numDimes = 1;
            int numNickels = 2;
            decimal totalMoneyFound = numQuarters * 0.25M + numDimes * 0.10M + numNickels * 0.05M;

            /* 
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all? 
            */

            int numMuffinsBakedByMrsBriersClass = 18;
            int numMuffinsBakedByMrsMacAdamsClass = 20;
            int numMuffinsBakedByMrsFlannerysClass = 17;
            int numMuffinsBakedByMrsHiltsFavoriteFirstGradeClasses = numMuffinsBakedByMrsBriersClass + numMuffinsBakedByMrsFlannerysClass + numMuffinsBakedByMrsMacAdamsClass;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */

            decimal priceYoyo = 0.24M;
            decimal priceWhistle = 0.14M;
            decimal amountMrsHiltSpent = priceYoyo + priceWhistle;

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */

            int numLargeMarshmallows = 8;
            int numMiniMarshmallows = 10;
            int totalNumMarshmallows = numLargeMarshmallows + numMiniMarshmallows;

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */

            int inchesSnowAtHiltHouse = 29;
            int inchesSnowAtBrecknockElementary = 17;
            int inchesMoreSnowAtHiltHouseThanBrecknockElementary = inchesSnowAtHiltHouse - inchesSnowAtBrecknockElementary;

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */

            decimal totalMoney = 10.0M;
            decimal priceOfToyTruck = 3.0M;
            decimal priceOfPencilCase = 2.0M;
            decimal moneyLeftOver = totalMoney - (priceOfToyTruck + priceOfPencilCase);

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */

            int marblesInCollection = 16;
            int marblesLost = 7;
            int finalNumMarblesInCollection = marblesInCollection - marblesLost;

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */

            int seashellsInHand = 19;
            int desiredSeashellAmount = 25;
            int numAdditionalSeashellsDesired = desiredSeashellAmount - seashellsInHand;

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */

            int totalBalloonCount = 17;
            int redBalloonCount = 8;
            int greenBalloonCount = totalBalloonCount - redBalloonCount;

            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */

            int initialNumBooksOnShelf = 38;
            int numBooksAddedToShelf = 10;
            int finalNumBooksOnShelf = initialNumBooksOnShelf + numBooksAddedToShelf;

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */

            numBees = 8;
            int numLegsPerBee = 6;
            int numLegsEightBeesHave = numBees * numLegsPerBee;

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */

            decimal pricePerIceCreamCone = 0.99M;
            int numIceCreamCones = 2;
            decimal totalPriceForAllIceCreamCones = pricePerIceCreamCone * numIceCreamCones;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */

            int rocksNeededForBorderProject = 125;
            int numRocksOnHand = 64;
            int numAdditionalRocksHiltRequiresForProject = rocksNeededForBorderProject - numRocksOnHand;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */

            int initialNumMarbles = 38;
            int numMarblesLost = 15;
            int numMarblesLeft = initialNumMarbles - numMarblesLost;

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */

            int totalDistanceToConcert = 78;
            int numMilesDriven = 32;
            int numMilesLeftToDrive = totalDistanceToConcert - numMilesDriven;

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */

            int minutesShovelingSnowOnSatMorning = 90;
            int minutesShovelingSnowOnSatAfternoon = 45;
            int totalMinutesShovelingSnowOnSat = minutesShovelingSnowOnSatAfternoon + minutesShovelingSnowOnSatMorning;

            /*    
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */

            decimal costPerHotDog = 0.50M;
            int numHotDogsBought = 6;
            decimal totalPriceForHotDogs = costPerHotDog * numHotDogsBought;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */

            decimal moneyHiltHas = 0.50M;
            decimal costPerPencil = 0.07M;
            int numPencilsHiltCanBuy = (int)(moneyHiltHas / costPerPencil);

            /*    
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */

            int numButterfliesHiltSaw = 33;
            int numOrangeButterflies = 20;
            int numRedButterflies = numButterfliesHiltSaw - numOrangeButterflies;

            /*    
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */

            decimal amountKateGaveClerk = 1.00M;
            decimal costOfKatesCandyPurchase = 0.54M;
            decimal amountOfChangeForKate = amountKateGaveClerk - costOfKatesCandyPurchase;

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */

            int currentAmountOfTreesInMarksYard = 13;
            int amountOfAdditionalTreesToPlant = 12;
            int finalAmountOfTrees = currentAmountOfTreesInMarksYard + amountOfAdditionalTreesToPlant;

            /*    
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */

            int daysTilJoySeesGrandma = 2;
            int numHoursPerDay = 24;
            int hoursTilJoySeesGrandma = daysTilJoySeesGrandma * numHoursPerDay;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */

            int numCousins = 4;
            int numPiecesOfGumPerCousin = 5;
            int numGumKimWillNeed = numCousins * numPiecesOfGumPerCousin;

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */

            decimal dollarsDanHas = 3.00M;
            decimal costOfCandyBar = 1.00M;
            decimal dollarsDanHasLeft = dollarsDanHas - costOfCandyBar;

            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */

            int numBoatsInLake = 5;
            int numPeoplePerBoat = 3;
            int totalNumPeopleOnBoatsInLake = numBoatsInLake * numPeoplePerBoat;

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */

            int initialNumLegosEllenHad = 380;
            int numLegosEllenLost = 57;
            int numLegosEllenHasLeft = initialNumLegosEllenHad - numLegosEllenLost;

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */

            int numMuffinsAlreadyBaked = 35;
            int totalNumMuffinsToBake = 83;
            int numMuffinsLeftToBake = totalNumMuffinsToBake - numMuffinsAlreadyBaked;

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */

            int numCrayonsForWilly = 1400;
            int numCrayonsForLucy = 290;
            int numCrayonsMoreWillyHasThanLucy = numCrayonsForWilly - numCrayonsForLucy;

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */

            int numStickersPerPage = 10;
            int numOfPages = 22;
            int totalNumberOfStickers = numStickersPerPage * numOfPages;

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */

            int totalNumOfCupcakes = 96;
            int numOfChildren = 8;
            int numOfCupcakesPerChild = totalNumOfCupcakes / numOfChildren;

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */

            int totalNumGingerbreadCookies = 47;
            int numCookiesPerJar = 6;
            int numCookiesNotPlacedInJars = totalNumGingerbreadCookies % numCookiesPerJar;

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */

            int totalNumCroissants = 59;
            int numOfNeighbors = 8;
            int numOfCroissantsLeftWithMarian = totalNumCroissants % numOfNeighbors;

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */

            int numCookiesPerTray = 12;
            int totalNumberOfCookies = 276;
            int numTraysNeededToPrepareTotalCookies = totalNumberOfCookies / numCookiesPerTray;

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */

            int totalNumOfPretzels = 480;
            int numPretzelsPerServing = 12;
            int totalNumPretzelServings = totalNumOfPretzels / numPretzelsPerServing;

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */

            int numLemonCupcakesBaked = 53;
            int numLemonCupcakesLeftAtHome = 2;
            int cupcakesPerBox = 3;
            int numBoxesOfLemonCupcakes = (numLemonCupcakesBaked - numLemonCupcakesLeftAtHome) / cupcakesPerBox;

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */

            int totalNumCarrotSticks = 74;
            int numOfPeopleSharingCarrots = 12;
            int numOfLeftOverCarrots = totalNumCarrotSticks % numOfPeopleSharingCarrots;

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */

            int totalNumOfTeddyBears = 98;
            int numTeddyBearsPerShelf = 7;
            int totalNumberOfFilledShelves = totalNumOfTeddyBears / numTeddyBearsPerShelf;

            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */

            int totalNumOfPictures = 480;
            int numPicturesPerAlbum = 20;
            int totalNumberOfAlbums = totalNumOfPictures / numPicturesPerAlbum;

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */

            int numOfTradingCards = 94;
            int cardCapacityOfBox = 8;
            int numOfFullBoxes = numOfTradingCards / cardCapacityOfBox;
            int numOfCardsInUnfilledBox = numOfTradingCards % cardCapacityOfBox;

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */

            int totalNumBooks = 210;
            int totalNumShelves = 10;
            int numBooksPerShelf = totalNumBooks / totalNumShelves;

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */

            int numCroissantsBaked = 17;
            int numGuests = 7;
            int numCroissantsPerGuest = numCroissantsBaked / numGuests;

            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages 
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */

            double roomSizeBillPaintsPerHour = (12 * 14) / (2.15);
            double roomSizeJillPaintsPerHour = (12 * 14) / (1.90);
            double hoursToPaintFiveRooms = (5 * 12 * 14) / (roomSizeBillPaintsPerHour + roomSizeJillPaintsPerHour);
            Console.WriteLine("Hours to paint 5 12x14 Rooms: " + hoursToPaintFiveRooms);

            int totalNumRooms = 623;
            int hoursOfWorkPerDay = 8;

            double numDaysRequiredToPaintAllRooms = ((totalNumRooms * 12 * 14) / (roomSizeBillPaintsPerHour + roomSizeJillPaintsPerHour)) / hoursOfWorkPerDay;
            Console.WriteLine("Number of days to paint 623 rooms at 8 hours/day: " + numDaysRequiredToPaintAllRooms);

            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle inital must end
            with a period.
            Example: "Hopper, Grace B." 
            */

            string firstName = "Peter";
            string lastName = "Kirk";
            string middleInitial = "E";

            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";
            Console.WriteLine("My Full Name: " + fullName);

            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles. 
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */

            int distanceForTripInMiles = 800;
            int distanceAlreadyTraveledInMiles = 537;
            double percentageOfTripCompleted = (double)distanceAlreadyTraveledInMiles / distanceForTripInMiles * 100;
            Console.WriteLine("Percent of Trip Completed: " + percentageOfTripCompleted + " or " + (int)percentageOfTripCompleted + "%");
        }
    }
}
