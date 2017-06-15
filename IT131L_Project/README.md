# it131l-project
Project for IT131L AC2 Y2T4

IT131L PROJECT GOALS
I. Log In Screen
	Inputs: accountNumber, accountPIN
	Output:
		Account Number: <textboz>
		PIN: <textbox>
		<button>ENTER</button>
	Description:
		The user will be asked to input both accountNumber and accountPIN.
		Program will check if acccountNumber exists in database.
			If no, program will display error message and restart login process.
			If yes, the following will happen:
		If the credentials match in the database, the LogIn Form will close to open
			MainMenu Form.
		If credentials don't match, error message will display and number of available
			tries will decrease.
		If number of available tries will reach 0, the account will be temporarily
			locked for security reasons. 
	Methods:
		If accountNumber.Exists == true
			If input_pin == accountPIN	
				Close frm_LogIn
				Display frm_MainMenu
			else if retries == 0
				Display "Too many log in attempts. Account will temporarily lock for
					security reasons."
			else
				tries--
				Display "Password and Account Number do not match. Please try again."
		else
			Display "Sorry. Account does not exist."
			
II. Main Menu
	Inputs: Buttons --> BalanceInquiry, WithdrawMoney, FundTransfer, DepositMoney
	Output:
		<button>BALANCE INQUIRY</button>
		<button>WITHDRAW MONEY</button>
		<button>FUND TRANSFER</button>
		<button>DEPOSIT MONEY</button>
		<button>LOG OUT</button>
	Description:
		The MainMenu Form will open and await user's response.
		Upon clicking a button, the button will open a form with its corresponding 
			function.
		While the proccess form is still open, the MainMenu Form will be inaccessible
			until the user closes the process form.
		The user will have to click the LOG OUT Button in order to exit the program
	Methods:
		frm_MainMenu.Enabled = false	--> ????
		If button_Click == LogOut
			Close frm_MainMenu
			Display frm_LogIn
		else if button_Click == BalanceInquiry
			Close frm_MainMenu
			Display frm_BalanceInquiry
		else if button_Click == WithdrawMoney
			Close frm_MainMenu
			Display frm_WithdrawMoney
		else if button_Click == FundTransfer
			Close frm_MainMenu
			Display frm_FundTransfer
		else if button_Click == DepositMoney	
			Close frm_MainMenu
			Display frm_DepositMoney
		frm_MainMenu.Enabled = true		--> ????
		
III. Balance Inquiry
	Inputs: Button --> OK
	Output:
		<ListView>transcation_history</ListView>
		<Label>Current Balance:<balance></label>
		<button>OK</button>
	Description:
		Upon loading the BalanceInquiry Form, a ListView will appear with recent
			transaction history of the account user.
		At the bottom/top of the ListView will be a label displaying the current
			balance of the user.
		The BalanceInquiry Form will close if the user clicks the OK Button
	Methods:
		(I'll be honest, I forgot how to add columns sa ListView, so yeah. Let's
			wing it.)
		
IV. Withdraw Money
	Inputs: withdrawAmount
	Output:
		Amount to withdraw: <textbox>
		<button>WITHRDAW</button><button>CANCEL</button>
	Description:
		The WithdrawMoney Form will open and ask the user to input desired amount to
			withdraw.
		If withdrawAmount is greater than balance or equal to zero, error message
			will display.
		Else, a dialog box will dislpay to confirm the withdrawal.
			If the user selects YES, a dialog box will display a successful withdrawal
				message.
				The balance of the user will be deducted by the value of withdrawAmount.
				The transaction history of the user will be updated with correct
					details.
			Else, a dialog box will display a cancelled withdrawal message.
		The WithdrawMoney Form will close if the user exits the form or clicks on the
			CANCEL Button.
	Methods:
		if withdrawAmount <= 0 || withdrawAmount > balance
			Display "Invalid amount to withdraw"
		else
			Display "Withdraw a total of PHP " + withdrawAmount + "?"
			if dialog.response == YES
				balance -= withdrawAmount
				Display "You have successfully withdrawn " + withdrawAmount
			else
				Display "Withdrawal has been cancelled"
		if button_Click == CANCEL
			Close frm_WithdrawMoney
			Display frm_MainMenu
		--- For Transaction History ---
			Insert (<transactionNum>, <dateTime>, "WITHDRAWAL", <withdrawAmount>)

V. Fund Transfer
	Inputs: transferAmount, recepientAccount
	Output:	
		Amount to transfer: <textbox>
		Recepient account number: <textbox>
		<button>CONFIRM TRANSFER</button> <button>CANCEL</button>
	Description:
		The FundTransfer Form will open and ask the user for the amount to be
			trasnferred and the account number of the receiver.
		If the receiver is nonexistent, an error message will display that the account
			doesn't exist.
		Else, the following will happen:
		If transferAmount is greater than balance or equal to zero, error message
			will display.
		Else, a dialog box will display confirm the transfer.
			If the user selects YES, a dialog box will display a successful transfer
				message.
				The balance of the user will be deducted by the value of transferAmount.
				The transaction history of the user will be updated with correct
					details.
			Else, a dialog box will display a cancelled transfer message.
		The FundTransfer Form will close if the user exits the form or clicks on the
			CANCEL Button.
	Methods:
		if recepientAccount.Exists == false
			Display "Account doesn't exist. Please check the number carefully."
		else
			if transfrAmount <= 0 || transferAmount > balance
				Display "Invalid amount to transfer"
			else
				Display "Transfer PHP " + transferAmount + "to Account #" +
					recepientAccount + "?"
				if dialog.response == YES
					balance -= transferAmount
					Display "You have successfully transferred " + withdrawAmount +
						"to Account #" + recepientAccount
				else
					Display "Transfer has been cancelled"
			if button_Click == CANCEL
				Close frm_FundTransfer
				Display frm_MainMenu
			--- For Transaction History ---
				Insert (<transactionNum>, <dateTime>, "FUND TRANSFER TO " + recepientAccount, 
					<withdrawAmount>)
	
VI. Deposit Money
	Inputs: depositAmount
	Output:
		Amount to deposit: <textbox>
		<button>CONFIRM DEPOSIT</button> <button>CANCEL</button>
	Description:
		The DepositMoney Form will open and ask the user to input desired amount to
			deposit.
		If depositAmount is greater than balance or equal to zero, error message
			will display.
		Else, a dialog box will dislpay to confirm the deposit.
			If the user selects YES, a dialog box will display a successful deposit
				message.
				The balance of the user will be added with the value of withdrawAmount.
				The transaction history of the user will be updated with correct
					details.
			Else, a dialog box will display a cancelled deposit message.
		The DepositMoney Form will close if the user exits the form or clicks on the
			CANCEL Button.
	Methods:
		if depositAmount <= 0 || depositAmount > balance
			Display "Invalid amount to deposit"
		else
			Display "Deposit a total of PHP " + depositAmount + "?"
			if dialog.response == YES
				balance -= depositAmount
				Display "You have successfully desposited " + depositAmount
			else
				Display "Deposit has been cancelled"
		if button_Click == CANCEL
			Close frm_DepositMoney
			Display frm_MainMenu
		--- For Transaction History ---
			Insert (<transactionNum>, <dateTime>, "DEPOSIT", <withdrawAmount>)
