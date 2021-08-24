@Mobile
Feature: MobileSportsBook
![Mobile SportsBook](https://res.cloudinary.com/dpr7nvtku/image/upload/v1629744560/Adjarabet/MobileSportsBook_wbknoh.png)



Scenario: Mobile SportsBook as an authorized user
	Given I have opened Adjarabet.com home page
	And I log in using 'sqatmsports' and 'Paroli1#' credentials
	When I navigate to mobile 'SportsBook' page
	Then User is logged in on mobile SportsBook page
	And I navigate to 'Home' page from mobile Sportsbook
	And I log out
	When I navigate to mobile 'SportsBook' page
	Then User is logged out on mobile SportsBook page


Scenario: Mobile SportsBook as not authorized user
	Given I have opened Adjarabet.com home page
	And I navigate to mobile 'SportsBook' page
	And I log in from mobile SportsBook page using 'sqatmsports' and 'Paroli1#'
	When I navigate to 'Home' page from mobile Sportsbook
	Then User is logged in
	And I navigate to mobile 'SportsBook' page
	And I log out on mobile SportsBook page
	When I navigate to 'Home' page from mobile Sportsbook
	Then User is logged out