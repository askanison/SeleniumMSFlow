@Mobile
Feature: MobilePoker
![Mobile Poker](https://res.cloudinary.com/dpr7nvtku/image/upload/v1629661127/Adjarabet/MobilePoker_osehxd.png)
Mobile Poker page with banner and Play New Poker button




 
Scenario: Check Mobile Poker as an authorized user
	Given I have opened Adjarabet.com home page
	And I log in using 'sqatmpoker' and 'Paroli1#' credentials
	And I navigate to mobile 'Poker' page
	When I click Play New Poker button
	Then Mobile Poker game is launched
	| Url |
	| https://poker.adjarabet.com/?https://launch.spribegaming.com/poker?brand=adjarabet.com&currency=GEL&game_id=poker    |
	


Scenario: Check Mobile Poker as not authorized user
	Given I have opened Adjarabet.com home page
	And I navigate to mobile 'Poker' page
	And I click Play New Poker button
	When I log in using 'sqatmpoker' and 'Paroli1#' credentials
	Then Mobile Poker game is launched
	| Url |
	| https://poker.adjarabet.com/?https://launch.spribegaming.com/poker?brand=adjarabet.com&currency=GEL&game_id=poker    |
	