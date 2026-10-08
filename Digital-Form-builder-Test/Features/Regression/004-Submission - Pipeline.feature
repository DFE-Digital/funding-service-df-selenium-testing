Feature: 004-Digital form- Form Submission---pipeline
Background:
	Given Navigate to Home page
	 #dotnet test --filter Category=SQLRegressionExecution ;livingdoc test-assembly "C:\Users\MIRFAN1\OneDrive - Department for Education\Desktop\dfe\Automation\C#\df\digital-form-builder-test-take-two\Digital-Form-builder-Test\bin\Debug\netcoreapp3.1\Digital-Form-builder-Test.dll" -t "C:\Users\MIRFAN1\OneDrive - Department for Education\Desktop\dfe\Automation\C#\df\digital-form-builder-test-take-two\Digital-Form-builder-Test\bin\Debug\netcoreapp3.1\TestExecution.json"
	 # dotnet test --filter Category=Pipelinetest ;livingdoc test-assembly "..\digital-form-builder-test-take-two\Digital-Form-builder-Test\bin\Debug\netcoreapp3.1\Digital-Form-builder-Test.dll" -t "..\digital-form-builder-test-take-two\Digital-Form-builder-Test\bin\Debug\netcoreapp3.1\TestExecution.json"

@Pipelinetest
Scenario Outline: 001-Run all component 
	Given User Navigated to runner
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
		#| Select component1          | Optional Fields                                 |
		| Autocomplete component     | OptionalFields                                  |
		| Email address component    | mohamed.irfan@education.gov.uk                  |
		| Multiline text component   | Multiline text component (Optional)             |
		| Number component           | 10                                              |
		| Telephone number component | 07776611574                                     |
		| Text component             | optional                                        |
		| UK address component       | Address line 1, Address line 2, london, ng76lt  |
		| Website component          | Not supplied                                    |
		| Radios component           | Optional Fields                                 |
		| YesNo component            | No                                              |
		| Checkboxes component       | Mandatory Fields, Optional Fields, Mixed Fields |
		| Data Import component      | Dataset_examplessmall_NEW.csv                   |
		| calculation2               | 210                                             |
	Then Check the file uploaded file
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then Click on Signout Button
Examples:
	| FormName             | DFEUserName                    | Password | DFESignin | Org      |
	| regressionpack_ukprn | mohamed.irfan@education.gov.uk | Password | UKPRN     | 10004733 |




Scenario Outline: 001-Run all component 1
	Given User Navigated to runner
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
		#| Select component1          | Optional Fields                                 |
		| Autocomplete component     | OptionalFields                                  |
		| Email address component    | mohamed.irfan@education.gov.uk                  |
		| Multiline text component   | Multiline text component (Optional)             |
		| Number component           | 10                                              |
		| Telephone number component | 07776611574                                     |
		| Text component             | optional                                        |
		| UK address component       | Address line 1, Address line 2, london, ng76lt  |
		| Website component          | Not supplied                                    |
		| Radios component           | Optional Fields                                 |
		| YesNo component            | No                                              |
		| Checkboxes component       | Mandatory Fields, Optional Fields, Mixed Fields |
		| Data Import component      | Dataset_examplessmall_NEW.csv                   |
		| calculation2               | 210                                             |
	Then Check the file uploaded file
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then Click on Signout Button
Examples:
	| FormName             | DFEUserName                    | Password | DFESignin | Org      |
	| regressionpack_ukprn | mohamed.irfan@education.gov.uk | Password | UKPRN     | 10004733 |
