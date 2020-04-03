Feature: Googling
	I want to find info about a given topic

@mytag
Scenario: Search info about a choosen topic
	Given I have navigated to google's homepage
	When I type "Endava" into the search box
	And click on the search button
	Then I should see the new page
