
INSERT INTO 
BankDetails(EffectiveDate, TransactionCode, TransactionAmount, TransactionDate, TransactionTime,
 DrCrIndicator, StandardBank,BranchCode,ReferenceNumber,AccountNumber,Identifier) VALUES


('2018-02-12', '1394', '337.00', '2018-02-12', '2018-02-12', 'DR', 'STD', '051001', 

'ACC 070370516 DEP BCH 1245', '70370516', 'SBSA'),


('2018-02-18', '1394', '20.00', '2018-02-18', '2018-02-18', 'CR', 'STD', '051001', 

'Test2', '70370516', 'SBSA'),


('2018-02-08', '379', '10.00', '2018-02-08', '2018-02-08', 'CR', 'STD', '051001', 

'Test2', '70370516', 'SBSA');

SELECT * FROM BankDetails
                                                                      