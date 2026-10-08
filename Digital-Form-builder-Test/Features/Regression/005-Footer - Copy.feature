Feature: 005-Digital form- Footer
Background:
	Given Navigate to Home page


	@SQLRegressionExecution
Scenario Outline: 001 Check footers link -Information guide
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then Check Footer link 'Information guide' section


@SQLRegressionExecution
Scenario Outline: 002 Check footers link -Support shortcuts
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then Check Footer link 'Support shortcuts' section


@SQLRegressionExecution
Scenario Outline: 003 Check footers link -CopyRight
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then Check Footer link 'Copy Right' section

@SQLRegressionExecution
Scenario Outline: 004 Check footers link -Accessibility statement
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then Check Footer "Accessibility statement" and URL "/help/accessibility-statement"


@SQLRegressionExecution
Scenario Outline: 005_footer-runner -Accessibility statement
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then Click on test link in dashboard in "<FormName>"
	Then Verify 'First page' in page
	Then Check Footer "Accessibility statement" and URL "digital-forms.education.gov.uk/accessibility-statement"
	Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 006_footer-runner -Cookies
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then Click on test link in dashboard in "<FormName>"
	Then Verify 'First page' in page
	Then Check Footer "Cookies" and URL "/cookies"
	Examples:
	| FormName        |
	| automationtest1 |


@SQLRegressionExecution
Scenario Outline: 007_footer-runner -Privacy
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then Click on test link in dashboard in "<FormName>"
	Then Verify 'First page' in page
	Then Check Footer "Privacy" and URL "https://www.gov.uk/government/publications/privacy-information-education-providers-workforce-including-teachers/privacy-information-education-providers-workforce-including-teachers"
	Examples:
	| FormName        |
	| automationtest1 |