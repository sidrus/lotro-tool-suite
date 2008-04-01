lexer grammar CombatSpam;

DAMAGE : 'damage' ;
WOUND : 'wound' ;
WOUNDS : 'wounds' ;
ARE_WOUNDED : 'are wounded' ;
WITH : 'with' ;
FOR : 'for' ;
OF : 'of' ;
FROM : 'from' ;

// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatSpam.g" 18
CHARS	: ('a'..'z'|'A'..'Z');
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatSpam.g" 19
DIGITS	: '0'..'9';		
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatSpam.g" 20
POINTS	: 'point' | 'points';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatSpam.g" 21
NEWLINE	: '\r'?'\n';

