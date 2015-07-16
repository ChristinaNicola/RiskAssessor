Assumptions and notes:

- Make sure the csv files are in the same folder as the exe.
- RiskAssessorCore.Data represents the data layer for the solution. For the sake of saving time, lots of corners were cut to use the csv files to load the data.
- The same data from the csv files is used as test data in some unit tests.
- So far data structures are ready to support both tasks of the challenge with an emphasis on correct structure rather than fancy UI. Task 1 is implemented. Task 2 is next.
- Unit tests are added to the solution to test data retrieval and correct logic.

Steps to use the tool:
- Select customer ID from combobox. 
- If the customer has unusual winning history a red label will show next to the combobox indicating so.
