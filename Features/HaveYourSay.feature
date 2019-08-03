Feature: HaveYourSay
	In order to ensure that Have Your Say input box is in working state
	As test engineer
	I want to validate different input combinations

Background:
	Given I have opened the bbc.com/news web page

Scenario: Valid input and screenshot
	When I click on More
	And I click on HaveYourSay
	And I click on question link
	When input box is opened
	And I have filled all needed fields
	Then the text in message box should have 140 symbols