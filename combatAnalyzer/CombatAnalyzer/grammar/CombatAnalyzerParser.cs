// $ANTLR 3.0.1 C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g 2008-04-05 00:10:49

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
		"HEAL", 
		"REFLECT", 
		"WITH", 
		"FOR", 
		"OF", 
		"FROM", 
		"LOGGING", 
		"POINTS", 
		"CHAR", 
		"DIGITS", 
		"NEWLINE", 
		"CL_COMMENT", 
		"CL_SYS_MSG", 
		"CL_REFLECT_LINE"
    };

    public const int REFLECT = 7;
    public const int CL_REFLECT_LINE = 19;
    public const int HEAL = 6;
    public const int WOUND = 5;
    public const int POINTS = 13;
    public const int DAMAGE = 4;
    public const int DIGITS = 15;
    public const int CHAR = 14;
    public const int FOR = 9;
    public const int LOGGING = 12;
    public const int CL_COMMENT = 17;
    public const int EOF = -1;
    public const int OF = 10;
    public const int NEWLINE = 16;
    public const int CL_SYS_MSG = 18;
    public const int FROM = 11;
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


    
    // $ANTLR start chatLine
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:30:1: chatLine : ( CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE | combatLine | healLine )+ ;
    public void chatLine() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:30:9: ( ( CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE | combatLine | healLine )+ )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:30:11: ( CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE | combatLine | healLine )+
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:30:11: ( CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE | combatLine | healLine )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 6;
            	    alt1 = dfa1.Predict(input);
            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:30:12: CL_COMMENT
            			    {
            			    	Match(input,CL_COMMENT,FOLLOW_CL_COMMENT_in_chatLine254); 
            			    
            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:30:23: CL_SYS_MSG
            			    {
            			    	Match(input,CL_SYS_MSG,FOLLOW_CL_SYS_MSG_in_chatLine256); 
            			    
            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:30:34: CL_REFLECT_LINE
            			    {
            			    	Match(input,CL_REFLECT_LINE,FOLLOW_CL_REFLECT_LINE_in_chatLine258); 
            			    
            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:30:50: combatLine
            			    {
            			    	PushFollow(FOLLOW_combatLine_in_chatLine260);
            			    	combatLine();
            			    	followingStackPointer_--;

            			    
            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:30:61: healLine
            			    {
            			    	PushFollow(FOLLOW_healLine_in_chatLine262);
            			    	healLine();
            			    	followingStackPointer_--;

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee =
            		                new EarlyExitException(1, input);
            		            throw eee;
            	    }
            	    cnt1++;
            	} while (true);
            	
            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements

            
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
    // $ANTLR end chatLine

    
    // $ANTLR start combatLine
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:31:1: combatLine : combatant WOUND ( combatant )? ( prep skill )? prep dmgAmt POINTS ( prep dmgType DAMAGE )? ;
    public void combatLine() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:31:13: ( combatant WOUND ( combatant )? ( prep skill )? prep dmgAmt POINTS ( prep dmgType DAMAGE )? )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:31:15: combatant WOUND ( combatant )? ( prep skill )? prep dmgAmt POINTS ( prep dmgType DAMAGE )?
            {
            	PushFollow(FOLLOW_combatant_in_combatLine272);
            	combatant();
            	followingStackPointer_--;

            	Match(input,WOUND,FOLLOW_WOUND_in_combatLine274); 
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:31:31: ( combatant )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);
            	
            	if ( (LA2_0 == CHAR) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:31:32: combatant
            	        {
            	        	PushFollow(FOLLOW_combatant_in_combatLine277);
            	        	combatant();
            	        	followingStackPointer_--;

            	        
            	        }
            	        break;
            	
            	}

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:31:44: ( prep skill )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);
            	
            	if ( ((LA3_0 >= WITH && LA3_0 <= FROM)) )
            	{
            	    int LA3_1 = input.LA(2);
            	    
            	    if ( (LA3_1 == CHAR) )
            	    {
            	        alt3 = 1;
            	    }
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:31:45: prep skill
            	        {
            	        	PushFollow(FOLLOW_prep_in_combatLine282);
            	        	prep();
            	        	followingStackPointer_--;

            	        	PushFollow(FOLLOW_skill_in_combatLine284);
            	        	skill();
            	        	followingStackPointer_--;

            	        
            	        }
            	        break;
            	
            	}

            	PushFollow(FOLLOW_prep_in_combatLine288);
            	prep();
            	followingStackPointer_--;

            	PushFollow(FOLLOW_dmgAmt_in_combatLine290);
            	dmgAmt();
            	followingStackPointer_--;

            	Match(input,POINTS,FOLLOW_POINTS_in_combatLine292); 
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:31:77: ( prep dmgType DAMAGE )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);
            	
            	if ( ((LA4_0 >= WITH && LA4_0 <= FROM)) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:31:78: prep dmgType DAMAGE
            	        {
            	        	PushFollow(FOLLOW_prep_in_combatLine295);
            	        	prep();
            	        	followingStackPointer_--;

            	        	PushFollow(FOLLOW_dmgType_in_combatLine297);
            	        	dmgType();
            	        	followingStackPointer_--;

            	        	Match(input,DAMAGE,FOLLOW_DAMAGE_in_combatLine299); 
            	        
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

    
    // $ANTLR start healLine
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:32:1: healLine : combatant HEAL combatant prep DIGITS prep ;
    public void healLine() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:32:11: ( combatant HEAL combatant prep DIGITS prep )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:32:13: combatant HEAL combatant prep DIGITS prep
            {
            	PushFollow(FOLLOW_combatant_in_healLine309);
            	combatant();
            	followingStackPointer_--;

            	Match(input,HEAL,FOLLOW_HEAL_in_healLine311); 
            	PushFollow(FOLLOW_combatant_in_healLine313);
            	combatant();
            	followingStackPointer_--;

            	PushFollow(FOLLOW_prep_in_healLine315);
            	prep();
            	followingStackPointer_--;

            	Match(input,DIGITS,FOLLOW_DIGITS_in_healLine317); 
            	PushFollow(FOLLOW_prep_in_healLine319);
            	prep();
            	followingStackPointer_--;

            
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
    // $ANTLR end healLine

    
    // $ANTLR start combatant
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:34:1: combatant : ( CHAR )+ ;
    public void combatant() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:34:11: ( ( CHAR )+ )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:34:13: ( CHAR )+
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:34:13: ( CHAR )+
            	int cnt5 = 0;
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);
            	    
            	    if ( (LA5_0 == CHAR) )
            	    {
            	        alt5 = 1;
            	    }
            	    
            	
            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:34:13: CHAR
            			    {
            			    	Match(input,CHAR,FOLLOW_CHAR_in_combatant327); 
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt5 >= 1 ) goto loop5;
            		            EarlyExitException eee =
            		                new EarlyExitException(5, input);
            		            throw eee;
            	    }
            	    cnt5++;
            	} while (true);
            	
            	loop5:
            		;	// Stops C# compiler whinging that label 'loop5' has no statements

            
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
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:35:1: skill : ( CHAR )+ ;
    public void skill() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:35:7: ( ( CHAR )+ )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:35:9: ( CHAR )+
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:35:9: ( CHAR )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);
            	    
            	    if ( (LA6_0 == CHAR) )
            	    {
            	        alt6 = 1;
            	    }
            	    
            	
            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:35:9: CHAR
            			    {
            			    	Match(input,CHAR,FOLLOW_CHAR_in_skill335); 
            			    
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
    // $ANTLR end skill

    
    // $ANTLR start dmgType
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:36:1: dmgType : ( CHAR )+ ;
    public void dmgType() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:36:9: ( ( CHAR )+ )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:36:11: ( CHAR )+
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:36:11: ( CHAR )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);
            	    
            	    if ( (LA7_0 == CHAR) )
            	    {
            	        alt7 = 1;
            	    }
            	    
            	
            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:36:11: CHAR
            			    {
            			    	Match(input,CHAR,FOLLOW_CHAR_in_dmgType343); 
            			    
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
    // $ANTLR end dmgType

    
    // $ANTLR start dmgAmt
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:1: dmgAmt : ( DIGITS )+ ;
    public void dmgAmt() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:8: ( ( DIGITS )+ )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:10: ( DIGITS )+
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:10: ( DIGITS )+
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
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:37:10: DIGITS
            			    {
            			    	Match(input,DIGITS,FOLLOW_DIGITS_in_dmgAmt351); 
            			    
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
    // $ANTLR end dmgAmt

    
    // $ANTLR start verb
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:38:1: verb : ( WOUND | HEAL ) ;
    public void verb() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:38:6: ( ( WOUND | HEAL ) )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:38:8: ( WOUND | HEAL )
            {
            	if ( (input.LA(1) >= WOUND && input.LA(1) <= HEAL) ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_verb359);    throw mse;
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
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:39:1: prep : ( WITH | FOR | OF | FROM ) ;
    public void prep() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:39:6: ( ( WITH | FOR | OF | FROM ) )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:39:8: ( WITH | FOR | OF | FROM )
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_prep372);    throw mse;
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


   	protected DFA1 dfa1;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
	}

    static readonly short[] DFA1_eot = {
        -1, -1, -1, -1, -1, -1, -1, -1
        };
    static readonly short[] DFA1_eof = {
        1, -1, -1, -1, -1, -1, -1, -1
        };
    static readonly int[] DFA1_min = {
        14, 0, 0, 0, 0, 5, 0, 0
        };
    static readonly int[] DFA1_max = {
        19, 0, 0, 0, 0, 14, 0, 0
        };
    static readonly short[] DFA1_accept = {
        -1, 6, 1, 2, 3, -1, 4, 5
        };
    static readonly short[] DFA1_special = {
        -1, -1, -1, -1, -1, -1, -1, -1
        };
    
    static readonly short[] dfa1_transition_null = null;

    static readonly short[] dfa1_transition0 = {
    	6, 7, -1, -1, -1, -1, -1, -1, -1, 5
    	};
    static readonly short[] dfa1_transition1 = {
    	5, -1, -1, 2, 3, 4
    	};
    
    static readonly short[][] DFA1_transition = {
    	dfa1_transition1,
    	dfa1_transition_null,
    	dfa1_transition_null,
    	dfa1_transition_null,
    	dfa1_transition_null,
    	dfa1_transition0,
    	dfa1_transition_null,
    	dfa1_transition_null
        };
    
    protected class DFA1 : DFA
    {
        public DFA1(BaseRecognizer recognizer) 
        {
            this.recognizer = recognizer;
            this.decisionNumber = 1;
            this.eot = DFA1_eot;
            this.eof = DFA1_eof;
            this.min = DFA1_min;
            this.max = DFA1_max;
            this.accept     = DFA1_accept;
            this.special    = DFA1_special;
            this.transition = DFA1_transition;
        }
    
        override public string Description
        {
            get { return "()+ loopback of 30:11: ( CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE | combatLine | healLine )+"; }
        }
    
    }
    
 

    public static readonly BitSet FOLLOW_CL_COMMENT_in_chatLine254 = new BitSet(new ulong[]{0x00000000000E4002UL});
    public static readonly BitSet FOLLOW_CL_SYS_MSG_in_chatLine256 = new BitSet(new ulong[]{0x00000000000E4002UL});
    public static readonly BitSet FOLLOW_CL_REFLECT_LINE_in_chatLine258 = new BitSet(new ulong[]{0x00000000000E4002UL});
    public static readonly BitSet FOLLOW_combatLine_in_chatLine260 = new BitSet(new ulong[]{0x00000000000E4002UL});
    public static readonly BitSet FOLLOW_healLine_in_chatLine262 = new BitSet(new ulong[]{0x00000000000E4002UL});
    public static readonly BitSet FOLLOW_combatant_in_combatLine272 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_WOUND_in_combatLine274 = new BitSet(new ulong[]{0x0000000000004F00UL});
    public static readonly BitSet FOLLOW_combatant_in_combatLine277 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_prep_in_combatLine282 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_skill_in_combatLine284 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_prep_in_combatLine288 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_dmgAmt_in_combatLine290 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_POINTS_in_combatLine292 = new BitSet(new ulong[]{0x0000000000000F02UL});
    public static readonly BitSet FOLLOW_prep_in_combatLine295 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_dmgType_in_combatLine297 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_DAMAGE_in_combatLine299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_combatant_in_healLine309 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_HEAL_in_healLine311 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_combatant_in_healLine313 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_prep_in_healLine315 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DIGITS_in_healLine317 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_prep_in_healLine319 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_in_combatant327 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_CHAR_in_skill335 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_CHAR_in_dmgType343 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_DIGITS_in_dmgAmt351 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_set_in_verb359 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_prep372 = new BitSet(new ulong[]{0x0000000000000002UL});

}
