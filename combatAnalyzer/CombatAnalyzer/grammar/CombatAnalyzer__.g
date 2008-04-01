lexer grammar CombatAnalyzer;
options {
  language=CSharp;

}

DAMAGE : 'damage' ;
WOUND : 'wound' ;
WOUNDS : 'wounds' ;
ARE_WOUNDED : 'are wounded' ;
WITH : 'with' ;
FOR : 'for' ;
OF : 'of' ;
FROM : 'from' ;
LOGGING : 'Logging chat tab' ;

// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 26
CHARS	: ('a'..'z'|'A'..'Z');
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 27
DIGITS	: '0'..'9';		
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 28
POINTS	: 'point' | 'points';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 29
NEWLINE	: '\r'?'\n';

// IGNORED LINES
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 32
CS_COMMENT	: '###' (options {greedy=false;} : .)* '###' {channel=HIDDEN;};
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 33
CS_LOG_MSG_SYS	: LOGGING (options {greedy=false;} : .)* NEWLINE {channel=HIDDEN;};

// PARSER LINES
