grammar CombatAnalyzer;

options
{
    language=CSharp;
}


tokens 
{
	DAMAGE='damage';
	
	WOUND='wound';
	WOUNDS='wounds';
	ARE_WOUNDED='are wounded';
	
	WITH='with';
	FOR='for';
	OF='of';
	FROM='from';
	
	LOGGING='Logging chat tab';
}

// TOKEN DEFINITIONS
CHARS	: ('a'..'z'|'A'..'Z');
DIGITS	: '0'..'9';		
POINTS	: 'point' | 'points';
NEWLINE	: '\r'?'\n';

// IGNORED LINES
CS_COMMENT	: '###' (options {greedy=false;} : .)* '###' {channel=HIDDEN;};
CS_LOG_MSG_SYS	: LOGGING (options {greedy=false;} : .)* NEWLINE {channel=HIDDEN;};

// PARSER LINES
combatLine
	: combatant verb (combatant)? (prep skill)? (prep damageAmount POINTS) (prep damageType (DAMAGE)?)? NEWLINE?
	;

verb		: WOUND | WOUNDS | ARE_WOUNDED;
prep		: WITH | FOR | OF | FROM;
combatant	: CHARS+;
skill		: CHARS+;
damageAmount	: DIGITS+;	
damageType	: CHARS+;
