Feature: TopStories
	In order to ensure that top stories are shown correctly
	As test engineer
	I want to validate that top stories are present on the page

Background:
	Given I have opened bbc.com/news web page

Scenario: Presence of the Top Story
	When News page is opened
	Then the top story should be present

Scenario: Presence of the Second Top Story
	When News page is opened
	Then the second top story should be present