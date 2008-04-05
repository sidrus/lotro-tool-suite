grammar CombatAnalyzer;

options
{
    language=CSharp;
}

// TOKEN DEFINITIONS
DAMAGE	: 'damage';
WOUND	: ('are '|'is ')? 'wound' ('ed'|'s')?;
HEAL	: ('are '|'is ')? 'heal' ('ed'|'s')?;
REFLECT	: 'reflect' 's'?;
WITH	: 'with';
FOR	: 'for';
OF	: 'of';
FROM	: 'from';
LOGGING	: 'Logging chat tab';
POINTS	: ('point' 's'?);
CHAR	: ('a'..'z'|'A'..'Z');
DIGITS	: ('0'..'9')+;
//NAME	: CHAR+;
NEWLINE	: ('\r'?'\n');

// IGNORED LINES
CL_COMMENT	: '###' (options {greedy=false;} : .)* '###' {$channel=HIDDEN;};
CL_SYS_MSG	: LOGGING (options {greedy=false;} : .)* NEWLINE {$channel=HIDDEN;};
CL_REFLECT_LINE : CHAR+ ' ' REFLECT (options {greedy=false;} : .)* NEWLINE {$channel=HIDDEN;};

// PARSER LINES
chatLine: (CL_COMMENT|CL_SYS_MSG|CL_REFLECT_LINE|combatLine|healLine)+;
combatLine 	: combatant WOUND (combatant)? (prep skill)? prep dmgAmt POINTS (prep dmgType DAMAGE)?;
healLine 	: combatant HEAL combatant prep DIGITS prep;

combatant : CHAR+;
skill	: CHAR+;
dmgType	: CHAR+;
dmgAmt	: DIGITS+;
verb	: (WOUND | HEAL);
prep	: (WITH | FOR | OF | FROM);
