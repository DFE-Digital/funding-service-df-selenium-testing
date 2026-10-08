Feature: 004-Digital form- Form Submission
Background:
	Given Navigate to Home page

	###	"is at least": (">="),

#
#"is at most": ("<="),
#
#"is less than": ("<"),
#
#"is more than": (">"),
#
#"is": "=="
#
#"is not": "!="
@SQLRegressionExecution
Scenario: 001_Result condition Worflow
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then Click on test link in dashboard in "<FormName>"
	#Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Enter the number value "<Value>"
	Then Click on 'Continue' Button
	Then Verify "<ConditionPageName>" in page
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	# Then Verify 'What happens next'
	Then close the runner window
Examples:
	| FormName                             | Value | ConditionPageName |
	| Regression_ResultComponent_Condition | 119   | is at least_120   |
	| Regression_ResultComponent_Condition | 94    | is at most_95     |
	| Regression_ResultComponent_Condition | 96    | is less than_99   |
	| Regression_ResultComponent_Condition | 110   | is more than_110  |
	| Regression_ResultComponent_Condition | 107   | is_108            |
	| Regression_ResultComponent_Condition | 106   | is not_98         |


@SQLRegressionExecution
Scenario Outline: 002_Regression pack -UKPRN-optional fields  -UAT Region
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then Click on test link in dashboard in "<FormName>"
	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
	Then verify Organization  "<Org>" and "<FormName>" in your detail page
	#Then Verify 'First page' in page
	Then Click on Save and continue
	Then Select 'Optional Fields' in 'Select component1' with helptext 'Help text (optional)' in "<Org>"
	Then Click on Save and continue
	Then Check all component in 'OptionalFields' page "<Org>"
	Then Click on Save and continue
	Then Verify Summary page with optinal fields
		| ComponentName              | ComponentValue                                  |
		| Select component1          | OptionalFields                                 |
		| Autocomplete component     | OptionalFields                                  |
		| Email address component    | mohamed.irfan@education.gov.uk                  |
		#| File upload component      | Datasetexamples.csv                                 |
		| Multiline text component   | Multiline text component (Optional)             |
		| Number component           | 10                                              |
		| Telephone number component | +447776611574                                     |
		| Text component             | optional                                        |
		| UK address component       | Address line 1, Address line 2, london, ng76lt  |
		| Website component          | Not supplied                                    |
		| Radios component           | Optional Fields                                 |
		| YesNo component            | No                                              |
		| Checkboxes component       | Optional Fields |
	#	| Data Import component      | Dataset_examplessmall_NEW.csv                   |
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then Click on Signout Button
	Then close the runner window
Examples:
	| FormName             | DFEUserName                    | Password | DFESignin | Org      |
	| regressionpack_ukprn | mohamed.irfan@education.gov.uk | Password | UKPRN     | 10004733 |



