# Task 1
The problem does not require special explanations, except that the initial 
	coefficients in the condition are not given (forgot to add, or were not given
	on purpose). However, from the test cases, having solved the equation system,
	the coefficients are easy to establish.
# Task 2
To solve this problem, we introduce such a concept as the "strength" of a tire,
	numerically equal to 1 / the number of kilometers that this tire is able to overcome.
	The total "strength" of all tires will be the sum of the endurance of each tire separately.
	Then, dividing the number of available tires by the total "strength" of all tires, we get
	the maximum distance that the car is able to travel, because when the car travels the
	given range, this will mean that the "strength" of all tires has become equal to 0.
# Task 3
Let us formulate the recursion step: the answer will be equal to the maximum of two
	answers to the same problem, the first subproblem, provided that the maximum sum of
	elements is less by A (its result, obviously, should be multiplied by A), 
	the second subproblem is similarly formulated for B. The condition for exiting recursion,
	if the maximum amount is equal to the maximum of the two numbers, then this is the answer;
	if it is less, we return 0.
# Task 4
The answer to the problem is simply the formula: mn + m + n. If the mice did not have a jump
	among the options for the move, then the total amount of such actions would be 
	(m+1)*n + (n+1)*m = 2*m*n + m + n. The number of jumps made by mice is always equal to m * n.
	Since the act of jumping shifts the mouse 2 cells at once, the total number of moves will be m * n less.