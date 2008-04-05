lexer grammar CombatAnalyzer;
options {
  language=CSharp;

}

// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 9
DAMAGE	: 'damage';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 10
WOUND	: ('are '|'is ')? 'wound' ('ed'|'s')?;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 11
HEAL	: ('are '|'is ')? 'heal' ('ed'|'s')?;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 12
WITH	: 'with';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 13
FOR	: 'for';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 14
OF	: 'of';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 15
FROM	: 'from';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 16
LOGGING	: 'Logging chat tab';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 17
POINTS	: ('point' 's'?);
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 18
CHAR	: ('a'..'z'|'A'..'Z');
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 19
DIGITS	: ('0'..'9')+;
//NAME	: CHAR+;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 21
NEWLINE	: ('\r'?'\n');

// IGNORED LINES
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 24
CS_COMMENT	: '###' (options {greedy=false;} : .)* '###' {skip();};
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 25
CS_LOG_MSG_SYS	: LOGGING (options {greedy=false;} : .)* NEWLINE {skip();};

// PARSER LINES
