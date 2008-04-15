grammar CombatAnalyzer;

/*options
{
    language=CSharp;
}
*/


// TOKEN DEFINITIONS
DAMAGE	: 'damage';
WOUND	: ('are '|'is ')? 'wound' ('ed'|'s')?;
HEAL	: ('are '|'is ')? 'heal' ('ed'|'s')?;
REFLECT	: 'reflect' 's'?;
WITH	: 'with';
FOR		: 'for';
OF		: 'of';
FROM	: 'from';
LOGGING	: 'Logging chat tab';
POINTS	: ('point' 's'?);
CHAR	: ('a'..'z'|'A'..'Z');
DIGITS	: ('0'..'9')+;
NEWLINE	: ('\r'?'\n');

// IGNORED LINES
CL_COMMENT	: '###' (options {greedy=false;} : .)* '###' {$channel=HIDDEN;};
CL_SYS_MSG	: LOGGING (options {greedy=false;} : .)* NEWLINE 
{
	$channel=HIDDEN;
};

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
//chatLine: (combatLine|CL_REFLECT_LINE|CL_COMMENT|CL_SYS_MSG|healLine)+;


combatLine:
	combatant1 WOUND combatant2? (prep skill)? prep dmgAmt POINTS (prep dmgType DAMAGE)?
	;
	


healLine 
	: combatant1 HEAL combatant2 prep DIGITS prep
	{
		//System.Windows.Forms.MessageBox.Show($HEAL.text);
		System.out.println($HEAL.text);
	};

combatant1 	: CHAR+;//(CHAR+ {$name+=$CHAR.text;});
combatant2 	: CHAR+;//(CHAR {$name+=$CHAR.text;})+;
skill		: CHAR+;//(CHAR {$name+=$CHAR.text;})+;
dmgType		: CHAR+;//(CHAR {$name+=$CHAR.text;})+;
dmgAmt		: DIGITS+;//(DIGITS {$value += Integer.valueOf($DIGITS.text).intValue();})+;
verb		: (WOUND | HEAL);
prep		: (WITH | FOR | OF | FROM);
