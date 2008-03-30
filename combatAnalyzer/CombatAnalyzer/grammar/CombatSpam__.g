lexer grammar CombatSpam;
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

// $ANTLR src "C:\Users\Brandon\Documents\The Lord of the Rings Online\CombatSpam.g" 21
CHARS	: ('a'..'z'|'A'..'Z');
// $ANTLR src "C:\Users\Brandon\Documents\The Lord of the Rings Online\CombatSpam.g" 22
DIGITS	: '0'..'9';		
// $ANTLR src "C:\Users\Brandon\Documents\The Lord of the Rings Online\CombatSpam.g" 23
POINTS	: 'point' | 'points';
// $ANTLR src "C:\Users\Brandon\Documents\The Lord of the Rings Online\CombatSpam.g" 24
NEWLINE	: '\r'?'\n';

