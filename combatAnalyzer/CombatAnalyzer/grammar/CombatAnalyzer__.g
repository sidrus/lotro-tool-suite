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
REFLECT	: 'reflect' 's'?;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 13
WITH	: 'with';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 14
FOR	: 'for';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 15
OF	: 'of';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 16
FROM	: 'from';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 17
LOGGING	: 'Logging chat tab';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 18
POINTS	: ('point' 's'?);
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 19
CHAR	: ('a'..'z'|'A'..'Z');
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 20
DIGITS	: ('0'..'9')+;
//NAME	: CHAR+;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 22
NEWLINE	: ('\r'?'\n');

// IGNORED LINES
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 25
CL_COMMENT	: '###' (options {greedy=false;} : .)* '###' {$channel=HIDDEN;};
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 26
CL_SYS_MSG	: LOGGING (options {greedy=false;} : .)* NEWLINE {$channel=HIDDEN;};
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 27
CL_REFLECT_LINE : CHAR+ ' ' REFLECT (options {greedy=false;} : .)* NEWLINE {$channel=HIDDEN;};

// PARSER LINES
