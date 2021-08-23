@Mobile
Feature: MobileCasino
![Mobile Casino](https://res.cloudinary.com/dpr7nvtku/image/upload/v1629652567/Adjarabet/MobileCasino_czkq85.png)
Mobile Casino page with slider, search, category filter and games



Scenario: Check Mobile Casino search
#Checks search functional with random word, correct game name and incorrect game name
	Given I have opened Adjarabet.com home page
	And I navigate to mobile 'Casino' page
	Then I check Mobile Casino search functional
	| search word  |
	| zzz          |
	| blackjack    |
	| 40 super hot |


Scenario: Open Mobile Casino game as not authorized user
#Checks when opened game as not authorized user and log in, game is opened
	Given I have opened Adjarabet.com home page
	And I navigate to mobile 'Casino' page
	And I click first mobile game in list
	When I log in using 'geocom64' and 'P@roli1' from opened login form
	Then Mobile Casino game is opened


Scenario: Check Mobile Casino filters
#Checks if mobile casino filters work
	Given I have opened Adjarabet.com home page
	And I navigate to mobile 'Casino' page
	Then I check mobile casino filter
	| Category			| Url             |
	| TOP თამაშები		| Top             |
	| ჩემი კაზინო		| MyCasino        |
	| AVIATOR CASINO    | AviatorCasino   |
	| რულეტკა			| Roulette        |
	| ბლექჯეკი			| Blackjack       |
	| კაზინო პოკერი		| liveCasinoPoker |
	| ბაკარა				| Baccarat        |
	| თამაში კამათლებით	| Dice            |
	| შოუ თამაშები		| GameShow        |




Scenario: Check if My Casino is available for authorized user
	Given I have opened Adjarabet.com home page
	And I log in using 'geocom64' and 'P@roli1' credentials
	And I navigate to mobile 'Casino' page
	When I click <category> on filter
	Then <Url> is changed


Scenario: Check if My Casino isn't available for not authorized user
	Given I have opened Adjarabet.com home page
	When I navigate to mobile 'Casino' page
	Then My Casino isn't available
