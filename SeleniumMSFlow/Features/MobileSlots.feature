@Mobile
Feature: MobileSlots




Scenario: Mobile Slots search functionality
	Given I have opened Adjarabet.com home page
	And I navigate to mobile 'Slots' page
	Then I check Mobile Slots search functional
	| search word  |
	| zzz          |
	| 40 super hot |
	| blackjack    |





Scenario: Check Mobile Slots My Casino as not authorized user
	Given I have opened Adjarabet.com home page
	And I navigate to mobile 'Slots' page
	When I click 'My Casino' on filter
	Then I check mobile Slots My Casino subfilter
	| Category     | Class Validator | UrlPart  |
	| Top თამაშები | crown			 | Top      |
	| ახალი		   | announcement	 | New      |
	| Megaways     | announcement    | Megaways |
	| პოპულარული | star			 | Top      |


Scenario: Check Mobile Slots My Casino as an authorized user
	Given I have opened Adjarabet.com home page
	And I log in using 'geocom68' and 'Paroli1#' credentials
	And I navigate to mobile 'Slots' page
	When I click 'My Casino' on filter
	Then I check mobile Slots My Casino subfilter
	| Category         | Class Validator | UrlPart  |
	| Top თამაშები     | crown           | Top      |
	| ახალი            | announcement    | New      |
	| Megaways         | announcement    | Megaways |
	| ბოლოს ნათამაშები | recently        | 🤷‍♂     |
	| რეკომენდებული   | recommended     | 👉👈   |
	| ტრენდული	   | trending        | 🙄      |
	| პოპულარული     | star            | 🤝      |


Scenario: Open Mobile Slot game as not authorized user
	Given I have opened Adjarabet.com home page
	And I navigate to mobile 'Slots' page
	And I choose 'EGT' from mobile filter
	And I click first mobile game in list
	When I log in using 'geocom68' and 'Paroli1#' from opened login form
	Then EGT mobile game is launched
