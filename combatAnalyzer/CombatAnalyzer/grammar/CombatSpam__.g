lexer grammar CombatSpam;

DAMAGE : 'damage' ;
WOUND : 'wound' ;
WOUNDS : 'wounds' ;
ARE_WOUNDED : 'are wounded' ;
WITH : 'with' ;
FOR : 'for' ;
OF : 'of' ;
FROM : 'from' ;
LOGGING : 'Logging chat tab' ;

// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatSpam.g" 20
CHARS	: ('a'..'z'|'A'..'Z');
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatSpam.g" 21
DIGITS	: '0'..'9';		
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatSpam.g" 22
POINTS	: 'point' | 'points';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatSpam.g" 23
NEWLINE	: '\r'?'\n';

// IGNORED LINES
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatSpam.g" 26
CS_COMMENT	: '###' (options {greedy=false;} : .)* '###' {channel=HIDDEN;};
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatSpam.g" 27
CS_LOG_MSG_SYS	: LOGGING (options {greedy=false;} : .)* NEWLINE {channel=HIDDEN;};

// PARSER LINES
