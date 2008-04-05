lexer grammar CombatAnalyzer;
options {
  language=CSharp;

}

// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 10
DAMAGE	: 'damage';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 11
WOUND	: ('are '|'is ')? 'wound' ('ed'|'s')?;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 12
HEAL	: ('are '|'is ')? 'heal' ('ed'|'s')?;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 13
REFLECT	: 'reflect' 's'?;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 14
WITH	: 'with';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 15
FOR	: 'for';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 16
OF	: 'of';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 17
FROM	: 'from';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 18
LOGGING	: 'Logging chat tab';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 19
POINTS	: ('point' 's'?);
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 20
CHAR	: ('a'..'z'|'A'..'Z');
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 21
DIGITS	: ('0'..'9')+;
//NAME	: CHAR+;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 23
NEWLINE	: ('\r'?'\n');

// IGNORED LINES
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 26
CL_COMMENT	: '###' (options {greedy=false;} : .)* '###' {$channel=HIDDEN;};
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 27
CL_SYS_MSG	: LOGGING (options {greedy=false;} : .)* NEWLINE {$channel=HIDDEN;};
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 28
CL_REFLECT_LINE : CHAR+ ' ' REFLECT (options {greedy=false;} : .)* NEWLINE {$channel=HIDDEN;};

// PARSER LINES
