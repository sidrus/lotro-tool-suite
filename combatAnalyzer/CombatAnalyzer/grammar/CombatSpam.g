grammar CombatSpam;



tokens {
	DAMAGE='damage';
	
	WOUND='wound';
	WOUNDS='wounds';
	ARE_WOUNDED='are wounded';
	
	WITH='with';
	FOR='for';
	OF='of';
	FROM='from';
}

CHARS	: ('a'..'z'|'A'..'Z');
DIGITS	: '0'..'9';		
POINTS	: 'point' | 'points';
NEWLINE	: '\r'?'\n';

combatLine
	: combatant verb (combatant)? (prep skill)? (prep damageAmount POINTS) (prep damageType (DAMAGE)?)? NEWLINE?
	;

verb		: WOUND | WOUNDS | ARE_WOUNDED;
prep		: WITH | FOR | OF | FROM;
combatant	: CHARS+;
skill		: CHARS+;
damageAmount	: DIGITS+;	
damageType	: CHARS+;
