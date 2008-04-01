// $ANTLR 3.0.1 C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g 2008-03-30 01:20:33

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Debug;
public class CombatSpamParser : DebugParser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"DAMAGE", 
		"WOUND", 
		"WOUNDS", 
		"ARE_WOUNDED", 
		"WITH", 
		"FOR", 
		"OF", 
		"FROM", 
		"CHARS", 
		"DIGITS", 
		"POINTS", 
		"NEWLINE"
    };

    public const int WOUNDS = 6;
    public const int NEWLINE = 15;
    public const int POINTS = 14;
    public const int WOUND = 5;
    public const int DIGITS = 13;
    public const int DAMAGE = 4;
    public const int CHARS = 12;
    public const int FOR = 9;
    public const int ARE_WOUNDED = 7;
    public const int FROM = 11;
    public const int OF = 10;
    public const int EOF = -1;
    public const int WITH = 8;
    public static readonly string[] ruleNames = new string[] {
        "invalidRule", "combatLine", "verb", "prep", "combatant", "skill", 
        "damageAmount", "damageType"
    };
    
    public int ruleLevel = 0;
    public CombatSpamParser(ITokenStream input) : base(input)
    {

    
    }
    public CombatSpamParser(ITokenStream input, IDebugEventListener dbg)
    	: base(input, dbg)
    {
    }
    
    protected bool EvalPredicate(bool result, string predicate) 
    {
        dbg.SemanticPredicate(result, predicate);
        return result;
    }


    override public string[] TokenNames
	{
		get { return tokenNames; }
	}

    override public string GrammarFileName
	{
		get { return "C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g"; }
	}


    
    // $ANTLR start combatLine
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:26:1: combatLine : combatant verb ( combatant )? ( prep skill )? ( prep damageAmount POINTS ) ( prep damageType ( DAMAGE )? )? ( NEWLINE )? ;
    public void combatLine() // throws RecognitionException [1]
    {   
        try 
        {
        	dbg.EnterRule("combatLine");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(26, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:2: ( combatant verb ( combatant )? ( prep skill )? ( prep damageAmount POINTS ) ( prep damageType ( DAMAGE )? )? ( NEWLINE )? )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:4: combatant verb ( combatant )? ( prep skill )? ( prep damageAmount POINTS ) ( prep damageType ( DAMAGE )? )? ( NEWLINE )?
            {
            	dbg.Location(27,4);
            	PushFollow(FOLLOW_combatant_in_combatLine129);
            	combatant();
            	followingStackPointer_--;

            	dbg.Location(27,14);
            	PushFollow(FOLLOW_verb_in_combatLine131);
            	verb();
            	followingStackPointer_--;

            	dbg.Location(27,19);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:19: ( combatant )?
            	int alt1 = 2;
            	try { dbg.EnterSubRule(1);
            	try { dbg.EnterDecision(1);
            	
            	int LA1_0 = input.LA(1);
            	
            	if ( (LA1_0 == CHARS) )
            	{
            	    alt1 = 1;
            	}
            	} finally { dbg.ExitDecision(1); }
            	
            	switch (alt1) 
            	{
            	    case 1 :
            	        dbg.EnterAlt(1);
            	    
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:20: combatant
            	        {
            	        	dbg.Location(27,20);
            	        	PushFollow(FOLLOW_combatant_in_combatLine134);
            	        	combatant();
            	        	followingStackPointer_--;

            	        
            	        }
            	        break;
            	
            	}
            	} finally { dbg.ExitSubRule(1); }

            	dbg.Location(27,32);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:32: ( prep skill )?
            	int alt2 = 2;
            	try { dbg.EnterSubRule(2);
            	try { dbg.EnterDecision(2);
            	
            	int LA2_0 = input.LA(1);
            	
            	if ( ((LA2_0 >= WITH && LA2_0 <= FROM)) )
            	{
            	    int LA2_1 = input.LA(2);
            	    
            	    if ( (LA2_1 == CHARS) )
            	    {
            	        alt2 = 1;
            	    }
            	}
            	} finally { dbg.ExitDecision(2); }
            	
            	switch (alt2) 
            	{
            	    case 1 :
            	        dbg.EnterAlt(1);
            	    
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:33: prep skill
            	        {
            	        	dbg.Location(27,33);
            	        	PushFollow(FOLLOW_prep_in_combatLine139);
            	        	prep();
            	        	followingStackPointer_--;

            	        	dbg.Location(27,38);
            	        	PushFollow(FOLLOW_skill_in_combatLine141);
            	        	skill();
            	        	followingStackPointer_--;

            	        
            	        }
            	        break;
            	
            	}
            	} finally { dbg.ExitSubRule(2); }

            	dbg.Location(27,46);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:46: ( prep damageAmount POINTS )
            	dbg.EnterAlt(1);
            	
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:47: prep damageAmount POINTS
            	{
            		dbg.Location(27,47);
            		PushFollow(FOLLOW_prep_in_combatLine146);
            		prep();
            		followingStackPointer_--;

            		dbg.Location(27,52);
            		PushFollow(FOLLOW_damageAmount_in_combatLine148);
            		damageAmount();
            		followingStackPointer_--;

            		dbg.Location(27,65);
            		Match(input,POINTS,FOLLOW_POINTS_in_combatLine150); 
            	
            	}

            	dbg.Location(27,73);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:73: ( prep damageType ( DAMAGE )? )?
            	int alt4 = 2;
            	try { dbg.EnterSubRule(4);
            	try { dbg.EnterDecision(4);
            	
            	int LA4_0 = input.LA(1);
            	
            	if ( ((LA4_0 >= WITH && LA4_0 <= FROM)) )
            	{
            	    alt4 = 1;
            	}
            	} finally { dbg.ExitDecision(4); }
            	
            	switch (alt4) 
            	{
            	    case 1 :
            	        dbg.EnterAlt(1);
            	    
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:74: prep damageType ( DAMAGE )?
            	        {
            	        	dbg.Location(27,74);
            	        	PushFollow(FOLLOW_prep_in_combatLine154);
            	        	prep();
            	        	followingStackPointer_--;

            	        	dbg.Location(27,79);
            	        	PushFollow(FOLLOW_damageType_in_combatLine156);
            	        	damageType();
            	        	followingStackPointer_--;

            	        	dbg.Location(27,90);
            	        	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:90: ( DAMAGE )?
            	        	int alt3 = 2;
            	        	try { dbg.EnterSubRule(3);
            	        	try { dbg.EnterDecision(3);
            	        	
            	        	int LA3_0 = input.LA(1);
            	        	
            	        	if ( (LA3_0 == DAMAGE) )
            	        	{
            	        	    alt3 = 1;
            	        	}
            	        	} finally { dbg.ExitDecision(3); }
            	        	
            	        	switch (alt3) 
            	        	{
            	        	    case 1 :
            	        	        dbg.EnterAlt(1);
            	        	    
            	        	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:91: DAMAGE
            	        	        {
            	        	        	dbg.Location(27,91);
            	        	        	Match(input,DAMAGE,FOLLOW_DAMAGE_in_combatLine159); 
            	        	        
            	        	        }
            	        	        break;
            	        	
            	        	}
            	        	} finally { dbg.ExitSubRule(3); }

            	        
            	        }
            	        break;
            	
            	}
            	} finally { dbg.ExitSubRule(4); }

            	dbg.Location(27,102);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:102: ( NEWLINE )?
            	int alt5 = 2;
            	try { dbg.EnterSubRule(5);
            	try { dbg.EnterDecision(5);
            	
            	int LA5_0 = input.LA(1);
            	
            	if ( (LA5_0 == NEWLINE) )
            	{
            	    alt5 = 1;
            	}
            	} finally { dbg.ExitDecision(5); }
            	
            	switch (alt5) 
            	{
            	    case 1 :
            	        dbg.EnterAlt(1);
            	    
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:27:102: NEWLINE
            	        {
            	        	dbg.Location(27,102);
            	        	Match(input,NEWLINE,FOLLOW_NEWLINE_in_combatLine165); 
            	        
            	        }
            	        break;
            	
            	}
            	} finally { dbg.ExitSubRule(5); }

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        dbg.Location(28, 2);
        
        }
        finally
        {
            dbg.ExitRule("combatLine");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return ;
    }
    // $ANTLR end combatLine

    
    // $ANTLR start verb
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:30:1: verb : ( WOUND | WOUNDS | ARE_WOUNDED );
    public void verb() // throws RecognitionException [1]
    {   
        try 
        {
        	dbg.EnterRule("verb");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(30, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:30:7: ( WOUND | WOUNDS | ARE_WOUNDED )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:
            {
            	dbg.Location(30,7);
            	if ( (input.LA(1) >= WOUND && input.LA(1) <= ARE_WOUNDED) ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    dbg.RecognitionException(mse);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_verb0);    throw mse;
            	}

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        dbg.Location(30, 37);
        
        }
        finally
        {
            dbg.ExitRule("verb");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return ;
    }
    // $ANTLR end verb

    
    // $ANTLR start prep
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:31:1: prep : ( WITH | FOR | OF | FROM );
    public void prep() // throws RecognitionException [1]
    {   
        try 
        {
        	dbg.EnterRule("prep");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(31, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:31:7: ( WITH | FOR | OF | FROM )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:
            {
            	dbg.Location(31,7);
            	if ( (input.LA(1) >= WITH && input.LA(1) <= FROM) ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    dbg.RecognitionException(mse);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_prep0);    throw mse;
            	}

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        dbg.Location(31, 31);
        
        }
        finally
        {
            dbg.ExitRule("prep");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return ;
    }
    // $ANTLR end prep

    
    // $ANTLR start combatant
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:32:1: combatant : ( CHARS )+ ;
    public void combatant() // throws RecognitionException [1]
    {   
        try 
        {
        	dbg.EnterRule("combatant");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(32, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:32:11: ( ( CHARS )+ )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:32:13: ( CHARS )+
            {
            	dbg.Location(32,13);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:32:13: ( CHARS )+
            	int cnt6 = 0;
            	try { dbg.EnterSubRule(6);
            	
            	do 
            	{
            	    int alt6 = 2;
            	    try { dbg.EnterDecision(6);
            	
            	    int LA6_0 = input.LA(1);
            	    
            	    if ( (LA6_0 == CHARS) )
            	    {
            	        alt6 = 1;
            	    }
            	    
            	
            	    } finally { dbg.ExitDecision(6); }
            	
            	    switch (alt6) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);
            			
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:32:13: CHARS
            			    {
            			    	dbg.Location(32,13);
            			    	Match(input,CHARS,FOLLOW_CHARS_in_combatant212); 
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            		            EarlyExitException eee =
            		                new EarlyExitException(6, input);
            		            dbg.RecognitionException(eee);
            	
            		            throw eee;
            	    }
            	    cnt6++;
            	} while (true);
            	
            	loop6:
            		;	// Stops C# compiler whinging that label 'loop6' has no statements
            	} finally { dbg.ExitSubRule(6); }

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        dbg.Location(32, 19);
        
        }
        finally
        {
            dbg.ExitRule("combatant");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return ;
    }
    // $ANTLR end combatant

    
    // $ANTLR start skill
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:33:1: skill : ( CHARS )+ ;
    public void skill() // throws RecognitionException [1]
    {   
        try 
        {
        	dbg.EnterRule("skill");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(33, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:33:8: ( ( CHARS )+ )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:33:10: ( CHARS )+
            {
            	dbg.Location(33,10);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:33:10: ( CHARS )+
            	int cnt7 = 0;
            	try { dbg.EnterSubRule(7);
            	
            	do 
            	{
            	    int alt7 = 2;
            	    try { dbg.EnterDecision(7);
            	
            	    int LA7_0 = input.LA(1);
            	    
            	    if ( (LA7_0 == CHARS) )
            	    {
            	        alt7 = 1;
            	    }
            	    
            	
            	    } finally { dbg.ExitDecision(7); }
            	
            	    switch (alt7) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);
            			
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:33:10: CHARS
            			    {
            			    	dbg.Location(33,10);
            			    	Match(input,CHARS,FOLLOW_CHARS_in_skill221); 
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt7 >= 1 ) goto loop7;
            		            EarlyExitException eee =
            		                new EarlyExitException(7, input);
            		            dbg.RecognitionException(eee);
            	
            		            throw eee;
            	    }
            	    cnt7++;
            	} while (true);
            	
            	loop7:
            		;	// Stops C# compiler whinging that label 'loop7' has no statements
            	} finally { dbg.ExitSubRule(7); }

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        dbg.Location(33, 16);
        
        }
        finally
        {
            dbg.ExitRule("skill");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return ;
    }
    // $ANTLR end skill

    
    // $ANTLR start damageAmount
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:34:1: damageAmount : ( DIGITS )+ ;
    public void damageAmount() // throws RecognitionException [1]
    {   
        try 
        {
        	dbg.EnterRule("damageAmount");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(34, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:34:14: ( ( DIGITS )+ )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:34:16: ( DIGITS )+
            {
            	dbg.Location(34,16);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:34:16: ( DIGITS )+
            	int cnt8 = 0;
            	try { dbg.EnterSubRule(8);
            	
            	do 
            	{
            	    int alt8 = 2;
            	    try { dbg.EnterDecision(8);
            	
            	    int LA8_0 = input.LA(1);
            	    
            	    if ( (LA8_0 == DIGITS) )
            	    {
            	        alt8 = 1;
            	    }
            	    
            	
            	    } finally { dbg.ExitDecision(8); }
            	
            	    switch (alt8) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);
            			
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:34:16: DIGITS
            			    {
            			    	dbg.Location(34,16);
            			    	Match(input,DIGITS,FOLLOW_DIGITS_in_damageAmount229); 
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt8 >= 1 ) goto loop8;
            		            EarlyExitException eee =
            		                new EarlyExitException(8, input);
            		            dbg.RecognitionException(eee);
            	
            		            throw eee;
            	    }
            	    cnt8++;
            	} while (true);
            	
            	loop8:
            		;	// Stops C# compiler whinging that label 'loop8' has no statements
            	} finally { dbg.ExitSubRule(8); }

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        dbg.Location(34, 23);
        
        }
        finally
        {
            dbg.ExitRule("damageAmount");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return ;
    }
    // $ANTLR end damageAmount

    
    // $ANTLR start damageType
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:35:1: damageType : ( CHARS )+ ;
    public void damageType() // throws RecognitionException [1]
    {   
        try 
        {
        	dbg.EnterRule("damageType");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(35, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:35:12: ( ( CHARS )+ )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:35:14: ( CHARS )+
            {
            	dbg.Location(35,14);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:35:14: ( CHARS )+
            	int cnt9 = 0;
            	try { dbg.EnterSubRule(9);
            	
            	do 
            	{
            	    int alt9 = 2;
            	    try { dbg.EnterDecision(9);
            	
            	    int LA9_0 = input.LA(1);
            	    
            	    if ( (LA9_0 == CHARS) )
            	    {
            	        alt9 = 1;
            	    }
            	    
            	
            	    } finally { dbg.ExitDecision(9); }
            	
            	    switch (alt9) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);
            			
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:35:14: CHARS
            			    {
            			    	dbg.Location(35,14);
            			    	Match(input,CHARS,FOLLOW_CHARS_in_damageType238); 
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt9 >= 1 ) goto loop9;
            		            EarlyExitException eee =
            		                new EarlyExitException(9, input);
            		            dbg.RecognitionException(eee);
            	
            		            throw eee;
            	    }
            	    cnt9++;
            	} while (true);
            	
            	loop9:
            		;	// Stops C# compiler whinging that label 'loop9' has no statements
            	} finally { dbg.ExitSubRule(9); }

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        dbg.Location(35, 20);
        
        }
        finally
        {
            dbg.ExitRule("damageType");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return ;
    }
    // $ANTLR end damageType


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_combatant_in_combatLine129 = new BitSet(new ulong[]{0x00000000000000E0UL});
    public static readonly BitSet FOLLOW_verb_in_combatLine131 = new BitSet(new ulong[]{0x0000000000001F00UL});
    public static readonly BitSet FOLLOW_combatant_in_combatLine134 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_prep_in_combatLine139 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_skill_in_combatLine141 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_prep_in_combatLine146 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_damageAmount_in_combatLine148 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_POINTS_in_combatLine150 = new BitSet(new ulong[]{0x0000000000008F02UL});
    public static readonly BitSet FOLLOW_prep_in_combatLine154 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_damageType_in_combatLine156 = new BitSet(new ulong[]{0x0000000000008012UL});
    public static readonly BitSet FOLLOW_DAMAGE_in_combatLine159 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_combatLine165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_verb0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_prep0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHARS_in_combatant212 = new BitSet(new ulong[]{0x0000000000001002UL});
    public static readonly BitSet FOLLOW_CHARS_in_skill221 = new BitSet(new ulong[]{0x0000000000001002UL});
    public static readonly BitSet FOLLOW_DIGITS_in_damageAmount229 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_CHARS_in_damageType238 = new BitSet(new ulong[]{0x0000000000001002UL});

}
