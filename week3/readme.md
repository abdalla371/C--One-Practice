# Chapter 3: Making Decisions (C#)
## if-else (Slide 7)
## Slide 7 flowchart img_flowchart_if_else.
- Tests temp > 40
- True: display "hot". False: display "cold"

## Slide 7 code img_code_if_else.
- Temp is 90, so the first block runs
- The else block runs only when the condition is false
- Note: the slide shows "hot" in both blocks. The else should show "cold"

## Test Score Average (Slides 8 and 9)
## Slide 8 form img_form_test_score_average.
- Three TextBoxes for the scores (80, 90, 75)
- A Label shows the Average (81.7)
- Buttons: Calculate Average, Clear, Exit

## Slide 9 code img_code_try_catch_average.

- The code of the Calculate Average button
- `try` runs the code. `catch` shows an error message if something fails
- `const` makes a value that cannot change (HIGH_SCORE is 95)
- `double.Parse` changes text to a number
- Average = (test1 + test2 + test3) / 3.0
- `ToString("n1")` shows 1 decimal. The slide comment says 2 decimals, but n1 means 1
- If the average is more than 95, a congratulations message shows

## Payroll with Overtime (Slide 10)
🟠Slide 10 form img_form_payroll_overtime.
- Shows the form and the name of each control
- hoursWorkedTextBox, hourlyPayRateTextBox, grossPayLabel
- calculateButton, clearButton, exitButton
- Good names make the code easy to read

## Loan Qualify (Slides 11 and 12)
## Slide 11 form img_form_loan_qualify.
- The user types the Annual Salary and the Years at current job
- Button Check Qualification shows the answer in Loan Decision
- Its code is on Slide 12

 ## Slide 12 flowchart img_flowchart_nested_if.
- Step 1: is salary >= 40000? If false: "Minimum salary requirement not met."
- Step 2: if true, is yearsOnJob >= 2?
- False: "Minimum years at current job not met." True: "You qualify for the loan."

## Slide 12 code img_code_nested_if.
- Nested means one if inside another if
- The outer if checks the salary. The inner if checks the years
- salary is 400, so the else runs: "Minimum salary requirement not met."
- To qualify, both conditions must be true
- Note: the slide has a typo: "load" should be "loan"

## if-else-if (Slide 13)
## Slide 13 code img_code_if_else_if.
- Gives a grade from A to F
- The conditions are tested from top to bottom. The first true one runs
- Example: score 85 gives B. Score below 60 gives F
- `int.Parse` gives an error if the text is not a number

## Logical Operators (Slide 15)
## Slide 15 table img_table_and.
- AND (&&) is true only when both sides are true

## Slide 15 table img_table_or.
- OR is true when one side or both sides are true
- It is false only when both sides are false

## Slide 15 table img_table_not.
- NOT (!) reverses the value: true becomes false, false becomes true

## Range Checker (Slide 16)
## Slide 16 form img_form_range_checker.
- The user types an integer
- The program checks if it is from 1 to 10 (use && to join two tests)
- The answer shows in Range Decision
- The slide does not show the code

## bool Flag (Slide 18)
## Slide 18 code img_code_bool_flag.
- A flag is a bool variable. It is true or false
- If points are more than 5000, isGrandMaster is true. If not, false
- `ToString()` changes the bool to text for the label

## Comparing Strings (Slide 19)
## Slide 19 code img_code_compareto.
- `CompareTo` compares two strings
- It returns 0 when they are equal
- If equal, the code inside the braces runs

## ListBox (Slides 28 and 32)
## Slide 28 code img_code_listbox_text.
- `Text` gets the selected item as text
- The text shows in a message box
- If nothing is selected, Text is empty

## Slide 28 code img_code_listbox_count.
- `Items.Count` gives the number of items in the ListBox
- The number shows in a message box

## Slide 32 code img_code_listbox_removeat.
- `SelectedIndex` is the position of the selected item. It starts at 0
- If nothing is selected, it is -1
- Item selected: `RemoveAt` removes it
- Nothing selected: a message asks the user to select an item
- This check stops an error

## slide 4 and slide 22
- Slides 4 and 6: flowcharts (cold outside, wear a coat; sales over 50000, bonus 500)
- Slide 22: Radio Button and Check Box examples