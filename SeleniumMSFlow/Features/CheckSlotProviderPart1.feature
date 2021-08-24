Feature: Check Slot Provider Part 1
Check if slots filter works
Check if provider name is displayed 
Open single game from every provider
	

@Desktop
Scenario: Check slots provider for desktop version
	Given I have opened Adjarabet.com home page
	And I log in using 'slotsprovurld1' and 'Paroli1#' credentials
	And I navigate to desktop 'Slots' page
	When I choose <Provider> from desktop filter
	Then The Title is changed to <Provider>
	When I open random slot game
	Then Correct <Provider> is opened
Examples: 
| Provider |
| EGT      |



@Mobile
Scenario: Check slots provider for mobile version
	Given I have opened Adjarabet.com home page
	And I log in using '{username}' and '{password}' credentials
	And I navigate to mobile 'Slots' page
	When I choose <Provider> from mobile filter
	Then <Url> is changed
	When I open random slot game
	Then Correct <game> is opened
