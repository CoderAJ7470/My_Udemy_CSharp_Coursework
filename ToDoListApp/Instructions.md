## Create a simple todo list app that allows the user to add, show and remove todo items. The app should check that no emtpy todos are being added. The usr should also not be allowed to incorrect inputs when removing todos, which will be done by the todo number in the list (numbered list).

# Order of program flow:
- Show the user the options on app start
- The user must select using only the letters S, A, R or E, but can also be lowercase. If none of these valid options are chosen, the user should be shown an informative message, and allowed to re-choose a valid option. This should continue till a valid option has been selected, or the user decides to exit the program.
- Showing all todos: if one/more todos are present in the list, they should be shown. If none are present, the message "No todos have been added yet." should be shown, followed by the options.
- Adding a todo: the user must enter a unique, non-empty todo. If the user tries to enter an empty one, the message "You cannot enter an empty todo" should be shown. If the user tries to enter a duplicate todo, the message "This todo already exists in your list" should be shown. Upon successfully adding a non-empty, unique todo, the message "Your todo was successfully added" should be shown. The added todo can be checked with the option "[S]how all todos".
- Removing a todo:
	- Empty list: "No todos to remove. The todo list is empty" should be shown
	- Empty user input/invalid todo number: "Sorry, you need to enter a valid todo number from the list in order to remove it" should be shown
	- Upon successful removal: "The selected todo was removed from the list" should be shown
- Exit: quits the program, as long as the user inputs either "E" or "e".