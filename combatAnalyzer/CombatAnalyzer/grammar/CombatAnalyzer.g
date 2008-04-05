grammar CombatAnalyzer;

options
{
    language=CSharp;
}

// TOKEN DEFINITIONS
DAMAGE	: 'damage';
WOUND	: ('are '|'is ')? 'wound' ('ed'|'s')?;
HEAL	: ('are '|'is ')? 'heal' ('ed'|'s')?;
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
CS_COMMENT	: '###' (options {greedy=false;} : .)* '###' {skip();};
CS_LOG_MSG_SYS	: LOGGING (options {greedy=false;} : .)* NEWLINE {skip();};

// PARSER LINES
chatLine: (CS_COMMENT|CS_LOG_MSG_SYS|combatLine|healLine)+;

combatLine : combatant WOUND (combatant)? (prep skill)? prep dmgAmt POINTS (prep dmgType DAMAGE)?;
healLine : combatant HEAL combatant prep DIGITS prep;

combatant : CHAR+;
skill	: CHAR+;
dmgType	: CHAR+;
dmgAmt	: DIGITS+;
verb	: (WOUND | HEAL);
prep	: (WITH | FOR | OF | FROM);
