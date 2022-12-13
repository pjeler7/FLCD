Statement: Write a program that reads the elements of a finite automaton from a file and:

  Display set of states, alphabet, transitions, set of final states
  Documentation should also include in BNF or EBNF format the form in which the FA.in file should be written
  
  BONUS : Consider the input data corresponding to the lexical tokens of your programming language, verify if a given string is a valid lexical token.


statement ::= initialStatement | finalStatement | normalStatement 

transition ::= statement, alphabet „->” statement 

alphabet ::= letter | digit 

letter ::= „a” | „b” | ... | „y” | „z” | „A” | „B” | ... | „Y” | „Z” 

digit ::= "0" | "1" | ... | "9" 

initialStatement ::= „{” „q” „0” „}” 

finalStatement ::= „[” „q” digit „]” 

normalStatement ::= „(” „q” digit „)” 



Based on transitions from text file the result is:

![lab3](https://user-images.githubusercontent.com/80889536/207281090-eefea95c-d235-4ae1-87f9-84b38943c328.png)
