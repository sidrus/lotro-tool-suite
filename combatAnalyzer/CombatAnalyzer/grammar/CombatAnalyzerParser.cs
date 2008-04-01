// $ANTLR 3.0.1 C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g 2008-03-31 23:10:07

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public class CombatAnalyzerParser : Parser 
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
		"LOGGING", 
		"CHARS", 
		"DIGITS", 
		"POINTS", 
		"NEWLINE", 
		"CS_COMMENT", 
		"CS_LOG_MSG_SYS"
    };

    public const int WOUNDS = 6;
    public const int NEWLINE = 16;
    public const int POINTS = 15;
    public const int WOUND = 5;
    public const int DIGITS = 14;
    public const int DAMAGE = 4;
    public const int CS_LOG_MSG_SYS = 18;
    public const int CHARS = 13;
    public const int FOR = 9;
    public const int CS_COMMENT = 17;
    public const int ARE_WOUNDED = 7;
    public const int LOGGING = 12;
    public const int FROM = 11;
    public const int OF = 10;
    public const int EOF = -1;
    public const int WITH = 8;
    
    
        public CombatAnalyzerParser(ITokenStream input) 
    		: base(input)
    	{
    		InitializeCyclicDFAs();
        }
        

    override public string[] TokenNames
	{
		get { return tokenNames; }
	}

    override public string GrammarFileName
	{
		get { return "C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g"; }
	}


    
    // $ANTLR start combatLine
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:36:1: combatLine : combatant verb ( combatant )? ( prep skill )? ( prep damageAmount POINTS ) ( prep damageType ( DAMAGE )? )? ( NEWLINE )? ;
    public void combatLine() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:2: ( combatant verb ( combatant )? ( prep skill )? ( prep damageAmount POINTS ) ( prep damageType ( DAMAGE )? )? ( NEWLINE )? )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:4: combatant verb ( combatant )? ( prep skill )? ( prep damageAmount POINTS ) ( prep damageType ( DAMAGE )? )? ( NEWLINE )?
            {
            	PushFollow(FOLLOW_combatant_in_combatLine192);
            	combatant();
            	followingStackPointer_--;

            	PushFollow(FOLLOW_verb_in_combatLine194);
            	verb();
            	followingStackPointer_--;

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:19: ( combatant )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);
            	
            	if ( (LA1_0 == CHARS) )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:20: combatant
            	        {
            	        	PushFollow(FOLLOW_combatant_in_combatLine197);
            	        	combatant();
            	        	followingStackPointer_--;

            	        
            	        }
            	        break;
            	
            	}

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:32: ( prep skill )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);
            	
            	if ( ((LA2_0 >= WITH && LA2_0 <= FROM)) )
            	{
            	    int LA2_1 = input.LA(2);
            	    
            	    if ( (LA2_1 == CHARS) )
            	    {
            	        alt2 = 1;
            	    }
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:33: prep skill
            	        {
            	        	PushFollow(FOLLOW_prep_in_combatLine202);
            	        	prep();
            	        	followingStackPointer_--;

            	        	PushFollow(FOLLOW_skill_in_combatLine204);
            	        	skill();
            	        	followingStackPointer_--;

            	        
            	        }
            	        break;
            	
            	}

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:46: ( prep damageAmount POINTS )
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:47: prep damageAmount POINTS
            	{
            		PushFollow(FOLLOW_prep_in_combatLine209);
            		prep();
            		followingStackPointer_--;

            		PushFollow(FOLLOW_damageAmount_in_combatLine211);
            		damageAmount();
            		followingStackPointer_--;

            		Match(input,POINTS,FOLLOW_POINTS_in_combatLine213); 
            	
            	}

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:73: ( prep damageType ( DAMAGE )? )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);
            	
            	if ( ((LA4_0 >= WITH && LA4_0 <= FROM)) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:74: prep damageType ( DAMAGE )?
            	        {
            	        	PushFollow(FOLLOW_prep_in_combatLine217);
            	        	prep();
            	        	followingStackPointer_--;

            	        	PushFollow(FOLLOW_damageType_in_combatLine219);
            	        	damageType();
            	        	followingStackPointer_--;

            	        	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:90: ( DAMAGE )?
            	        	int alt3 = 2;
            	        	int LA3_0 = input.LA(1);
            	        	
            	        	if ( (LA3_0 == DAMAGE) )
            	        	{
            	        	    alt3 = 1;
            	        	}
            	        	switch (alt3) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:91: DAMAGE
            	        	        {
            	        	        	Match(input,DAMAGE,FOLLOW_DAMAGE_in_combatLine222); 
            	        	        
            	        	        }
            	        	        break;
            	        	
            	        	}

            	        
            	        }
            	        break;
            	
            	}

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:102: ( NEWLINE )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);
            	
            	if ( (LA5_0 == NEWLINE) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:102: NEWLINE
            	        {
            	        	Match(input,NEWLINE,FOLLOW_NEWLINE_in_combatLine228); 
            	        
            	        }
            	        break;
            	
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
        return ;
    }
    // $ANTLR end combatLine

    
    // $ANTLR start verb
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:40:1: verb : ( WOUND | WOUNDS | ARE_WOUNDED );
    public void verb() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:40:7: ( WOUND | WOUNDS | ARE_WOUNDED )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:
            {
            	if ( (input.LA(1) >= WOUND && input.LA(1) <= ARE_WOUNDED) ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
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
        return ;
    }
    // $ANTLR end verb

    
    // $ANTLR start prep
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:41:1: prep : ( WITH | FOR | OF | FROM );
    public void prep() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:41:7: ( WITH | FOR | OF | FROM )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:
            {
            	if ( (input.LA(1) >= WITH && input.LA(1) <= FROM) ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
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
        return ;
    }
    // $ANTLR end prep

    
    // $ANTLR start combatant
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:42:1: combatant : ( CHARS )+ ;
    public void combatant() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:42:11: ( ( CHARS )+ )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:42:13: ( CHARS )+
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:42:13: ( CHARS )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);
            	    
            	    if ( (LA6_0 == CHARS) )
            	    {
            	        alt6 = 1;
            	    }
            	    
            	
            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:42:13: CHARS
            			    {
            			    	Match(input,CHARS,FOLLOW_CHARS_in_combatant275); 
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            		            EarlyExitException eee =
            		                new EarlyExitException(6, input);
            		            throw eee;
            	    }
            	    cnt6++;
            	} while (true);
            	
            	loop6:
            		;	// Stops C# compiler whinging that label 'loop6' has no statements

            
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
        return ;
    }
    // $ANTLR end combatant

    
    // $ANTLR start skill
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:43:1: skill : ( CHARS )+ ;
    public void skill() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:43:8: ( ( CHARS )+ )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:43:10: ( CHARS )+
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:43:10: ( CHARS )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);
            	    
            	    if ( (LA7_0 == CHARS) )
            	    {
            	        alt7 = 1;
            	    }
            	    
            	
            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:43:10: CHARS
            			    {
            			    	Match(input,CHARS,FOLLOW_CHARS_in_skill284); 
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt7 >= 1 ) goto loop7;
            		            EarlyExitException eee =
            		                new EarlyExitException(7, input);
            		            throw eee;
            	    }
            	    cnt7++;
            	} while (true);
            	
            	loop7:
            		;	// Stops C# compiler whinging that label 'loop7' has no statements

            
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
        return ;
    }
    // $ANTLR end skill

    
    // $ANTLR start damageAmount
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:44:1: damageAmount : ( DIGITS )+ ;
    public void damageAmount() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:44:14: ( ( DIGITS )+ )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:44:16: ( DIGITS )+
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:44:16: ( DIGITS )+
            	int cnt8 = 0;
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);
            	    
            	    if ( (LA8_0 == DIGITS) )
            	    {
            	        alt8 = 1;
            	    }
            	    
            	
            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:44:16: DIGITS
            			    {
            			    	Match(input,DIGITS,FOLLOW_DIGITS_in_damageAmount292); 
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt8 >= 1 ) goto loop8;
            		            EarlyExitException eee =
            		                new EarlyExitException(8, input);
            		            throw eee;
            	    }
            	    cnt8++;
            	} while (true);
            	
            	loop8:
            		;	// Stops C# compiler whinging that label 'loop8' has no statements

            
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
        return ;
    }
    // $ANTLR end damageAmount

    
    // $ANTLR start damageType
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:45:1: damageType : ( CHARS )+ ;
    public void damageType() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:45:12: ( ( CHARS )+ )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:45:14: ( CHARS )+
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:45:14: ( CHARS )+
            	int cnt9 = 0;
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);
            	    
            	    if ( (LA9_0 == CHARS) )
            	    {
            	        alt9 = 1;
            	    }
            	    
            	
            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:45:14: CHARS
            			    {
            			    	Match(input,CHARS,FOLLOW_CHARS_in_damageType301); 
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt9 >= 1 ) goto loop9;
            		            EarlyExitException eee =
            		                new EarlyExitException(9, input);
            		            throw eee;
            	    }
            	    cnt9++;
            	} while (true);
            	
            	loop9:
            		;	// Stops C# compiler whinging that label 'loop9' has no statements

            
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
        return ;
    }
    // $ANTLR end damageType


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_combatant_in_combatLine192 = new BitSet(new ulong[]{0x00000000000000E0UL});
    public static readonly BitSet FOLLOW_verb_in_combatLine194 = new BitSet(new ulong[]{0x0000000000002F00UL});
    public static readonly BitSet FOLLOW_combatant_in_combatLine197 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_prep_in_combatLine202 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_skill_in_combatLine204 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_prep_in_combatLine209 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_damageAmount_in_combatLine211 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_POINTS_in_combatLine213 = new BitSet(new ulong[]{0x0000000000010F02UL});
    public static readonly BitSet FOLLOW_prep_in_combatLine217 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_damageType_in_combatLine219 = new BitSet(new ulong[]{0x0000000000010012UL});
    public static readonly BitSet FOLLOW_DAMAGE_in_combatLine222 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_combatLine228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_verb0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_prep0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHARS_in_combatant275 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_CHARS_in_skill284 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_DIGITS_in_damageAmount292 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_CHARS_in_damageType301 = new BitSet(new ulong[]{0x0000000000002002UL});

}
