Feature: 002-Digital form -Submission -Runner
Background:
	Given Navigate to Home page

@SQLRegressionExecution @DesignerExecution
Scenario Outline: 001_Verify that user should be able to see  Submit the form
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then Click on test link in dashboard in "<FormName>"
	Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Verify 'Second page' in page
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
Examples:
	| FormName        |
	| automationtest1 |


	
@DataSource:../help/sample.xlsx @DataSet:sheet2
@SQLRegressionExecution11 @DesignerExecution
Scenario Outline: 002_Verify that user should be able to see NTP RQ Submit the form
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then Click on test link in dashboard in "<FormName>"
	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
	Then verify Organization  "<Org>" and "<FormName>" in your detail page
	Then Click on Save and continue
	Then Enter the values in NTP form for "<No_OfSchool>"
	Then Verify 'Submit' Button
	Then Verify 'Save summary as PDF' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then close the runner window
Examples:
	| DFEUserName                    | Password | DFESignin | Org      | No_OfSchool | FormName                     |
	| mohamed.irfan@education.gov.uk | Password | UKPRN     | 10004733 | 2     | NTP form load testing_RQ_new |
        
