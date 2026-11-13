 Chapter 4: Loops, Files, and Random Numbers (C#)
## while Loop (Slide 3)
🟠Slide 3 flowchart img_flowchart_while_loop.
- Test the Boolean expression first
- True: run the statement(s), then test again. False: leave the loop
- It tests first, so it is a pretest loop

## Ending Balance (Slides 8 and 9)
🟠Slide 8 code img_code_interest_rate_constant.
- `const` makes a value that cannot change
- INTEREST_RATE is 0.005 (0.5 percent each month)
- The letter `m` means the number is a decimal

🟠Slide 8 form img_form_ending_balance.
- startingBalTextBox: the starting balance
- monthsTextBox: the number of months
- endingBalanceLabel: shows the ending balance
- Buttons: calculateButton, clearButton, exitButton

🟠Slide 8 code img_code_add_interest.
- Finds the interest (INTEREST_RATE * balance) and adds it to the balance
- This line runs once for each month, inside a loop
- Example: 1000 becomes 1005

🟠Slide 9 form img_form_ending_balance_modified.
- The same form with a new ListBox named detailListBox
- Each month's result is added to this ListBox

🟠Slide 9 code img_code_detail_listbox.
- `Items.Add` adds one new line to the ListBox
- `count` is the month number
- `ToString("c")` shows money, like $1,005.00
- The `+` joins pieces of text into one line

🟠Slide 9 output img_output_ending_balance.
- Starting Balance 1000, Number of Months 8
- The ListBox shows month 1 ($1,005.00) to month 8 ($1,040.71)
- The Ending Balance label shows the last value

## Postfix and Prefix (Slides 11 and 12)
🟠Slide 11 code img_code_postfix.
- Postfix: the operator is after the variable
- Use the old value first, then change it

🟠Slide 11 code img_code_prefix.
- Prefix: the operator is before the variable
- Change the value first, then use it

🟠Slide 12 code img_code_postfix_example.
- count is 5 and x is 0. Then x = count++
- x gets 5 (the old value), then count becomes 6
- The second text in MessageBox.Show is the title of the box

🟠Slide 12 code img_code_prefix_example.
- count is 5 and x is 0. Then x = ++count
- count becomes 6 first, then x gets 6

## Questions: ++ and while (Slide 13)
🟠Slide 13 questions img_questions_increment_loop.
- 5.9: number is 5. After ++ it shows 6. After -- it shows 5
- 5.10: the loop runs 4 times and shows 0, 1, 2, 3
- When count is 4, the condition is false and the loop stops

## Squares Form (Slide 17)
🟠Slide 17 form img_form_squares.
- Left: the empty form with outputListBox and goButton
- Right: after clicking Go, the ListBox shows the squares of 1 to 10
- Example: "The square of 10 is 100"
- The slide does not show the code. A for loop from 1 to 10 can do it

## do-while Loop (Slides 18 and 20)
🟠Slide 18 flowchart img_flowchart_do_while.
- Run the statement(s) first, then test the Boolean expression
- True: run again. False: leave the loop
- It always runs at least one time (posttest loop)

🟠Slide 20 questions img_questions_do_while.
- 5.15: a posttest loop tests its condition after each iteration
- 5.16: while tests first. do-while tests after
- 5.17: the loop runs 1 time. It shows 0, then the test is false


## Writing to a File (Slide 24)
🟠Slide 24 output img_output_writeline_write.
- WriteLine writes the item and starts a new line
- Write writes the item without a new line
- Left file: One, Two, Three on separate lines
- Right file: OneTwoThree on one line

## Ways to Read a File (Slide 28)
All four examples read the file lstcourse.doc and use a ListBox.

🟠Slide 28 code img_code_readalltext.
- `File.ReadAllText` opens, reads everything, and closes the file
- The whole text is added as one item

🟠Slide 28 code img_code_readtoend.
- `File.OpenText` opens the file with a StreamReader
- `ReadToEnd()` reads from the current position to the end
- `Close()` closes the file

🟠Slide 28 code img_code_readline.
- `ReadLine()` reads one line only
- It runs once here, so only the first line is read
- The green line is a warning from Visual Studio

🟠Slide 28 code img_code_read_char.
- `Read()` reads one character
- `(char)` changes the number that Read returns into a character
- Only the first character is added to the ListBox

## Reading a File with a Loop (Slide 30)
🟠Slide 30 code img_code_read_file_loop.
- Opens the file from a full path. Double backslash is needed in a string
- `EndOfStream` is true at the end of the file
- The loop reads line after line and adds each line to the ListBox
- `catch` shows an error message if something fails (for example, a missing file)

## Dialog Boxes (Slides 31 and 32)
🟠Slide 31 dialog img_dialog_open.
- The standard Windows Open box (OpenFileDialog)
- Has a File name field and the buttons Open and Cancel

🟠Slide 31 dialog img_dialog_save_as.
- The standard Windows Save As box (SaveFileDialog)
- Has File name, Save as type, and the buttons Save and Cancel

🟠Slide 32 designer img_designer_open_file_dialog.
- The Toolbox has OpenFileDialog and SaveFileDialog under Dialogs
- A dialog control does not show on the form
- It shows in the component tray as openFileDialog1
- `ShowDialog()` shows the box

## Using the Dialog Result (Slides 34 and 36)
🟠Slide 34 code img_code_open_dialog_result.
- `ShowDialog()` returns the button the user clicked
- OK: open the file and read a line. Cancel: show a message
- `"Path"` is only a placeholder. Real code uses `openFileDialog1.FileName`

🟠Slide 36 code img_code_open_dialog_filename.
- `FileName` holds the path and name of the selected file
- Opens it, reads line by line with a loop, adds the lines to the ListBox, then closes it
- Warning: it does not check OK or Cancel. Cancel can cause an error

## Save Dialog (Slide 38)
🟠Slide 38 code img_code_save_dialog.
- Shows the Save As box
- OK: creates the file at the chosen place and writes "Mohamed" in it
- Cancel: shows a message
- `CreateText` erases the old content if the file already exists

