@Mobile
Feature: MobileTableGames

Scenario: Check mobile Table Games as a logged in user
	Given I have opened Adjarabet.com home page
	And I log in using 'sqatmp2p' and 'Paroli1#' credentials
	And I navigate to mobile 'Poker' page
	When I click '<Table Game>' button 
	Then Table Game is launched
	And '<Url>' is correct

Examples: 
	| Table Game    | Url																					|
	| Dominoes      | https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/domino?user=       |
	| Bura			| https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/bura?user=         |
	| Backgammon    | https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/backgammon?user=   |
	| Seka          | https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/seka?user=		    |


