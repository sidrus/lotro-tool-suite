lexer grammar CombatAnalyzer;

// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 11
DAMAGE	: 'damage';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 12
WOUND	: ('are '|'is ')? 'wound' ('ed'|'s')?;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 13
HEAL	: ('are '|'is ')? 'heal' ('ed'|'s')?;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 14
REFLECT	: 'reflect' 's'?;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 15
WITH	: 'with';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 16
FOR		: 'for';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 17
OF		: 'of';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 18
FROM	: 'from';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 19
LOGGING	: 'Logging chat tab';
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 20
POINTS	: ('point' 's'?);
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 21
CHAR	: ('a'..'z'|'A'..'Z');
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 22
DIGITS	: ('0'..'9')+;
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 23
NEWLINE	: ('\r'?'\n');

// IGNORED LINES
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 26
CL_COMMENT	: '###' (options {greedy=false;} : .)* '###' {$channel=HIDDEN;};
// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 27
CL_SYS_MSG	: LOGGING (options {greedy=false;} : .)* NEWLINE 
{
	$channel=HIDDEN;
};

// $ANTLR src "C:\Users\Brandon\Documents\Visual Studio 2005\Projects\CombatAnalyzer\CombatAnalyzer\grammar\CombatAnalyzer.g" 32
CL_REFLECT_LINE returns [String text] : 
	(CHAR {$text+=$CHAR.text;})+ 
	(' ' {$text+=" ";} )
	(REFLECT {$text+=$REFLECT.text;}) 
	(options {greedy=false;} : .)*
	NEWLINE 
	
	{
		//System.Windows.Forms.MessageBox.Show($CL_REFLECT_LINE.text);
		//$channel=HIDDEN;
	};

// PARSER LINES
//chatLine: (CL_COMMENT|CL_SYS_MSG|CL_REFLECT_LINE|combatLine|healLine)+;
