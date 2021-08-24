@Mobile
Feature: MobileTurboGames
![Mobile Turbo Games](https://res.cloudinary.com/dpr7nvtku/image/upload/v1629744765/Adjarabet/MobileTurboGames_ciezep.png)

Scenario: Check mobile Turbo Games as a logged in user
	Given I have opened Adjarabet.com home page
	And I log in using 'sqatmturbo' and 'Paroli1#' credentials
	And I navigate to mobile 'Turbo Games' page
	When I click '<Turbo Game>' button 
	Then Turbo Game is launched
	And '<Url>' is correct

Examples: 
	| Turbo Game    | Url                                                          |
	| Plinko        | https://spgames.adjarabet.com/turbo/play/plinko?user=        |
	| Mines         | https://spgames.adjarabet.com/turbo/play/mines?user=         |
	| Goal          | https://spgames.adjarabet.com/turbo/play/goal?user=          |
	| HiLo          | https://spgames.adjarabet.com/turbo/play/hi-lo?user=         |
	| Dice          | https://spgames.adjarabet.com/turbo/play/dice?user=          |
	| Mini Roulette | https://spgames.adjarabet.com/turbo/play/mini-roulette?user= |

Scenario: Check mobile Turbo Games as a not logged in user
	Given I have opened Adjarabet.com home page
	And I navigate to mobile 'Turbo Games' page
	And I click '<Turbo Game>' button
	When I log in using 'sqatmturbo' and 'Paroli1#' from opened login form
	Then Turbo Game is launched
	And '<Url>' is correct

 Examples: 
	| Turbo Game    | Url                                                          |
	| Plinko        | https://spgames.adjarabet.com/turbo/play/plinko?user=        |
	| Mines         | https://spgames.adjarabet.com/turbo/play/mines?user=         |
	| Goal          | https://spgames.adjarabet.com/turbo/play/goal?user=          |
	| HiLo          | https://spgames.adjarabet.com/turbo/play/hi-lo?user=         |
	| Dice          | https://spgames.adjarabet.com/turbo/play/dice?user=          |
	| Mini Roulette | https://spgames.adjarabet.com/turbo/play/mini-roulette?user= |