﻿@Mobile
Feature: MobileTableGames
![Mobile Table Games](https://res.cloudinary.com/dpr7nvtku/image/upload/v1629734374/Adjarabet/MobileTableGames_fgsfqk.png)

Scenario: Check mobile Table Games as an authorized user
	Given I have opened Adjarabet.com home page
	And I log in using 'sqatmp2p' and 'Paroli1#' credentials
	And I navigate to mobile 'Table Games' page
	When I click '<Table Game>' button 
	Then Table Game is launched
	And '<Url>' is correct

Examples: 
	| Table Game    | Url																					|
	| Dominoes      | https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/domino?user=       |
	| Bura			| https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/bura?user=         |
	| Backgammon    | https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/backgammon?user=   |
	| Seka          | https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/seka?user=		    |


Scenario: Check mobile Table Games as not authorized user
	Given I have opened Adjarabet.com home page
	And I navigate to mobile 'Table Games' page
	And I click '<Table Game>' button 
	When I log in using 'sqatmp2p' and 'Paroli1#' from opened login form
	Then Table Game is launched
	And '<Url>' is correct
Examples: 
	| Table Game    | Url																					|
	| Dominoes      | https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/domino?user=       |
	| Bura			| https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/bura?user=         |
	| Backgammon    | https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/backgammon?user=   |
	| Seka          | https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/seka?user=		    |
