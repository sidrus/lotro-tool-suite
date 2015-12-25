// $ANTLR 3.0.1 C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g 2008-04-05 02:44:04

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Debug;
public class CombatAnalyzerParser : DebugParser 
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
    public static readonly string[] ruleNames = new string[] {
        "invalidRule", "chatLine", "combatLine", "healLine", "combatant1", 
        "combatant2", "skill", "dmgType", "dmgAmt", "verb", "prep"
    };
    
    public int ruleLevel = 0;
    public CombatAnalyzerParser(ITokenStream input) : base(input)
    {

    
    }
    public CombatAnalyzerParser(ITokenStream input, IDebugEventListener dbg)
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
		get { return "C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g"; }
	}


    
    // $ANTLR start chatLine
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:45:1: chatLine : ( combatLine )+ ;
    public void chatLine() // throws RecognitionException [1]
    {   
        try 
        {
        	dbg.EnterRule("chatLine");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(45, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:45:9: ( ( combatLine )+ )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:45:11: ( combatLine )+
            {
            	dbg.Location(45,11);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:45:11: ( combatLine )+
            	int cnt1 = 0;
            	try { dbg.EnterSubRule(1);
            	
            	do 
            	{
            	    int alt1 = 2;
            	    try { dbg.EnterDecision(1);
            	
            	    int LA1_0 = input.LA(1);
            	    
            	    if ( (LA1_0 == CHAR) )
            	    {
            	        alt1 = 1;
            	    }
            	    
            	
            	    } finally { dbg.ExitDecision(1); }
            	
            	    switch (alt1) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);
            			
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:45:12: combatLine
            			    {
            			    	dbg.Location(45,12);
            			    	PushFollow(FOLLOW_combatLine_in_chatLine288);
            			    	combatLine();
            			    	followingStackPointer_--;

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee =
            		                new EarlyExitException(1, input);
            		            dbg.RecognitionException(eee);
            	
            		            throw eee;
            	    }
            	    cnt1++;
            	} while (true);
            	
            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements
            	} finally { dbg.ExitSubRule(1); }

            
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
        dbg.Location(45, 24);
        
        }
        finally
        {
            dbg.ExitRule("chatLine");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return ;
    }
    // $ANTLR end chatLine

    
    // $ANTLR start combatLine
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:48:1: combatLine returns [string text] : ( combatant1 ) ( WOUND ) ( combatant2 )? ( prep skill )? ( prep ) ( dmgAmt ) ( POINTS ) ( prep dmgType DAMAGE )? ;
    public string combatLine() // throws RecognitionException [1]
    {   

        string text = null;
    
        IToken WOUND2 = null;
        IToken POINTS6 = null;
        string combatant11 = null;

        combatant2_return combatant23 = null;

        skill_return skill4 = null;

        int dmgAmt5 = 0;

        dmgType_return dmgType7 = null;
        
    
        try 
        {
        	dbg.EnterRule("combatLine");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(48, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:48:33: ( ( combatant1 ) ( WOUND ) ( combatant2 )? ( prep skill )? ( prep ) ( dmgAmt ) ( POINTS ) ( prep dmgType DAMAGE )? )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:49:2: ( combatant1 ) ( WOUND ) ( combatant2 )? ( prep skill )? ( prep ) ( dmgAmt ) ( POINTS ) ( prep dmgType DAMAGE )?
            {
            	dbg.Location(49,2);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:49:2: ( combatant1 )
            	dbg.EnterAlt(1);
            	
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:49:3: combatant1
            	{
            		dbg.Location(49,3);
            		PushFollow(FOLLOW_combatant1_in_combatLine304);
            		combatant11 = combatant1();
            		followingStackPointer_--;

            		dbg.Location(49,17);
            		text += combatant11 + ", ";
            	
            	}

            	dbg.Location(50,2);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:50:2: ( WOUND )
            	dbg.EnterAlt(1);
            	
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:50:3: WOUND
            	{
            		dbg.Location(50,3);
            		WOUND2 = (IToken)input.LT(1);
            		Match(input,WOUND,FOLLOW_WOUND_in_combatLine314); 
            		dbg.Location(50,13);
            		text += WOUND2.Text + ", ";
            	
            	}

            	dbg.Location(51,2);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:51:2: ( combatant2 )?
            	int alt2 = 2;
            	try { dbg.EnterSubRule(2);
            	try { dbg.EnterDecision(2);
            	
            	int LA2_0 = input.LA(1);
            	
            	if ( (LA2_0 == CHAR) )
            	{
            	    alt2 = 1;
            	}
            	} finally { dbg.ExitDecision(2); }
            	
            	switch (alt2) 
            	{
            	    case 1 :
            	        dbg.EnterAlt(1);
            	    
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:51:3: combatant2
            	        {
            	        	dbg.Location(51,3);
            	        	PushFollow(FOLLOW_combatant2_in_combatLine325);
            	        	combatant23 = combatant2();
            	        	followingStackPointer_--;

            	        	dbg.Location(51,18);
            	        	text += input.ToString(combatant23.start,combatant23.stop) + ", ";
            	        
            	        }
            	        break;
            	
            	}
            	} finally { dbg.ExitSubRule(2); }

            	dbg.Location(52,2);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:52:2: ( prep skill )?
            	int alt3 = 2;
            	try { dbg.EnterSubRule(3);
            	try { dbg.EnterDecision(3);
            	
            	int LA3_0 = input.LA(1);
            	
            	if ( ((LA3_0 >= WITH && LA3_0 <= FROM)) )
            	{
            	    int LA3_1 = input.LA(2);
            	    
            	    if ( (LA3_1 == CHAR) )
            	    {
            	        alt3 = 1;
            	    }
            	}
            	} finally { dbg.ExitDecision(3); }
            	
            	switch (alt3) 
            	{
            	    case 1 :
            	        dbg.EnterAlt(1);
            	    
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:52:3: prep skill
            	        {
            	        	dbg.Location(52,3);
            	        	PushFollow(FOLLOW_prep_in_combatLine337);
            	        	prep();
            	        	followingStackPointer_--;

            	        	dbg.Location(52,8);
            	        	PushFollow(FOLLOW_skill_in_combatLine339);
            	        	skill4 = skill();
            	        	followingStackPointer_--;

            	        	dbg.Location(52,17);
            	        	text += input.ToString(skill4.start,skill4.stop) + ", ";
            	        
            	        }
            	        break;
            	
            	}
            	} finally { dbg.ExitSubRule(3); }

            	dbg.Location(53,2);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:53:2: ( prep )
            	dbg.EnterAlt(1);
            	
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:53:3: prep
            	{
            		dbg.Location(53,3);
            		PushFollow(FOLLOW_prep_in_combatLine350);
            		prep();
            		followingStackPointer_--;

            	
            	}

            	dbg.Location(54,2);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:54:2: ( dmgAmt )
            	dbg.EnterAlt(1);
            	
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:54:3: dmgAmt
            	{
            		dbg.Location(54,3);
            		PushFollow(FOLLOW_dmgAmt_in_combatLine361);
            		dmgAmt5 = dmgAmt();
            		followingStackPointer_--;

            		dbg.Location(54,14);
            		text += dmgAmt5.ToString() + ", ";
            	
            	}

            	dbg.Location(55,2);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:55:2: ( POINTS )
            	dbg.EnterAlt(1);
            	
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:55:3: POINTS
            	{
            		dbg.Location(55,3);
            		POINTS6 = (IToken)input.LT(1);
            		Match(input,POINTS,FOLLOW_POINTS_in_combatLine372); 
            		dbg.Location(55,14);
            		text += POINTS6.Text;
            	
            	}

            	dbg.Location(56,2);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:56:2: ( prep dmgType DAMAGE )?
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
            	    
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:56:3: prep dmgType DAMAGE
            	        {
            	        	dbg.Location(56,3);
            	        	PushFollow(FOLLOW_prep_in_combatLine383);
            	        	prep();
            	        	followingStackPointer_--;

            	        	dbg.Location(56,8);
            	        	PushFollow(FOLLOW_dmgType_in_combatLine385);
            	        	dmgType7 = dmgType();
            	        	followingStackPointer_--;

            	        	dbg.Location(56,16);
            	        	Match(input,DAMAGE,FOLLOW_DAMAGE_in_combatLine387); 
            	        	dbg.Location(56,24);
            	        	text += ", " + input.ToString(dmgType7.start,dmgType7.stop);
            	        
            	        }
            	        break;
            	
            	}
            	} finally { dbg.ExitSubRule(4); }

            	dbg.Location(57,2);
            	
            			System.Windows.Forms.MessageBox.Show(text);
            		
            
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
        dbg.Location(60, 2);
        
        }
        finally
        {
            dbg.ExitRule("combatLine");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return text;
    }
    // $ANTLR end combatLine

    
    // $ANTLR start healLine
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:64:1: healLine : combatant1 HEAL combatant2 prep DIGITS prep ;
    public void healLine() // throws RecognitionException [1]
    {   
        IToken HEAL8 = null;
    
        try 
        {
        	dbg.EnterRule("healLine");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(64, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:65:2: ( combatant1 HEAL combatant2 prep DIGITS prep )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:65:4: combatant1 HEAL combatant2 prep DIGITS prep
            {
            	dbg.Location(65,4);
            	PushFollow(FOLLOW_combatant1_in_healLine410);
            	combatant1();
            	followingStackPointer_--;

            	dbg.Location(65,15);
            	HEAL8 = (IToken)input.LT(1);
            	Match(input,HEAL,FOLLOW_HEAL_in_healLine412); 
            	dbg.Location(65,20);
            	PushFollow(FOLLOW_combatant2_in_healLine414);
            	combatant2();
            	followingStackPointer_--;

            	dbg.Location(65,31);
            	PushFollow(FOLLOW_prep_in_healLine416);
            	prep();
            	followingStackPointer_--;

            	dbg.Location(65,36);
            	Match(input,DIGITS,FOLLOW_DIGITS_in_healLine418); 
            	dbg.Location(65,43);
            	PushFollow(FOLLOW_prep_in_healLine420);
            	prep();
            	followingStackPointer_--;

            	dbg.Location(66,2);
            	
            			System.Windows.Forms.MessageBox.Show(HEAL8.Text);
            		
            
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
        dbg.Location(68, 3);
        
        }
        finally
        {
            dbg.ExitRule("healLine");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return ;
    }
    // $ANTLR end healLine

    
    // $ANTLR start combatant1
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:70:1: combatant1 returns [string name] : ( CHAR )+ ;
    public string combatant1() // throws RecognitionException [1]
    {   

        string name = null;
    
        IToken CHAR9 = null;
    
        try 
        {
        	dbg.EnterRule("combatant1");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(70, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:70:35: ( ( CHAR )+ )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:70:37: ( CHAR )+
            {
            	dbg.Location(70,37);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:70:37: ( CHAR )+
            	int cnt5 = 0;
            	try { dbg.EnterSubRule(5);
            	
            	do 
            	{
            	    int alt5 = 2;
            	    try { dbg.EnterDecision(5);
            	
            	    int LA5_0 = input.LA(1);
            	    
            	    if ( (LA5_0 == CHAR) )
            	    {
            	        alt5 = 1;
            	    }
            	    
            	
            	    } finally { dbg.ExitDecision(5); }
            	
            	    switch (alt5) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);
            			
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:70:38: CHAR
            			    {
            			    	dbg.Location(70,38);
            			    	CHAR9 = (IToken)input.LT(1);
            			    	Match(input,CHAR,FOLLOW_CHAR_in_combatant1437); 
            			    	dbg.Location(70,43);
            			    	name+=CHAR9.Text;
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt5 >= 1 ) goto loop5;
            		            EarlyExitException eee =
            		                new EarlyExitException(5, input);
            		            dbg.RecognitionException(eee);
            	
            		            throw eee;
            	    }
            	    cnt5++;
            	} while (true);
            	
            	loop5:
            		;	// Stops C# compiler whinging that label 'loop5' has no statements
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
        dbg.Location(70, 65);
        
        }
        finally
        {
            dbg.ExitRule("combatant1");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return name;
    }
    // $ANTLR end combatant1

    public class combatant2_return : ParserRuleReturnScope 
    {
        public string name;
    };
    
    // $ANTLR start combatant2
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:71:1: combatant2 returns [string name] : ( CHAR )+ ;
    public combatant2_return combatant2() // throws RecognitionException [1]
    {   
        combatant2_return retval = new combatant2_return();
        retval.start = input.LT(1);
    
        IToken CHAR10 = null;
    
        try 
        {
        	dbg.EnterRule("combatant2");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(71, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:71:35: ( ( CHAR )+ )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:71:37: ( CHAR )+
            {
            	dbg.Location(71,37);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:71:37: ( CHAR )+
            	int cnt6 = 0;
            	try { dbg.EnterSubRule(6);
            	
            	do 
            	{
            	    int alt6 = 2;
            	    try { dbg.EnterDecision(6);
            	
            	    int LA6_0 = input.LA(1);
            	    
            	    if ( (LA6_0 == CHAR) )
            	    {
            	        alt6 = 1;
            	    }
            	    
            	
            	    } finally { dbg.ExitDecision(6); }
            	
            	    switch (alt6) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);
            			
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:71:38: CHAR
            			    {
            			    	dbg.Location(71,38);
            			    	CHAR10 = (IToken)input.LT(1);
            			    	Match(input,CHAR,FOLLOW_CHAR_in_combatant2454); 
            			    	dbg.Location(71,43);
            			    	retval.name+=CHAR10.Text;
            			    
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
    
            retval.stop = input.LT(-1);
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        dbg.Location(71, 65);
        
        }
        finally
        {
            dbg.ExitRule("combatant2");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return retval;
    }
    // $ANTLR end combatant2

    public class skill_return : ParserRuleReturnScope 
    {
        public string name;
    };
    
    // $ANTLR start skill
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:72:1: skill returns [string name] : ( CHAR )+ ;
    public skill_return skill() // throws RecognitionException [1]
    {   
        skill_return retval = new skill_return();
        retval.start = input.LT(1);
    
        IToken CHAR11 = null;
    
        try 
        {
        	dbg.EnterRule("skill");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(72, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:72:30: ( ( CHAR )+ )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:72:32: ( CHAR )+
            {
            	dbg.Location(72,32);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:72:32: ( CHAR )+
            	int cnt7 = 0;
            	try { dbg.EnterSubRule(7);
            	
            	do 
            	{
            	    int alt7 = 2;
            	    try { dbg.EnterDecision(7);
            	
            	    int LA7_0 = input.LA(1);
            	    
            	    if ( (LA7_0 == CHAR) )
            	    {
            	        alt7 = 1;
            	    }
            	    
            	
            	    } finally { dbg.ExitDecision(7); }
            	
            	    switch (alt7) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);
            			
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:72:33: CHAR
            			    {
            			    	dbg.Location(72,33);
            			    	CHAR11 = (IToken)input.LT(1);
            			    	Match(input,CHAR,FOLLOW_CHAR_in_skill471); 
            			    	dbg.Location(72,38);
            			    	retval.name+=CHAR11.Text;
            			    
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
    
            retval.stop = input.LT(-1);
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        dbg.Location(72, 60);
        
        }
        finally
        {
            dbg.ExitRule("skill");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return retval;
    }
    // $ANTLR end skill

    public class dmgType_return : ParserRuleReturnScope 
    {
        public string name;
    };
    
    // $ANTLR start dmgType
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:73:1: dmgType returns [string name] : ( CHAR )+ ;
    public dmgType_return dmgType() // throws RecognitionException [1]
    {   
        dmgType_return retval = new dmgType_return();
        retval.start = input.LT(1);
    
        IToken CHAR12 = null;
    
        try 
        {
        	dbg.EnterRule("dmgType");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(73, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:73:32: ( ( CHAR )+ )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:73:34: ( CHAR )+
            {
            	dbg.Location(73,34);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:73:34: ( CHAR )+
            	int cnt8 = 0;
            	try { dbg.EnterSubRule(8);
            	
            	do 
            	{
            	    int alt8 = 2;
            	    try { dbg.EnterDecision(8);
            	
            	    int LA8_0 = input.LA(1);
            	    
            	    if ( (LA8_0 == CHAR) )
            	    {
            	        alt8 = 1;
            	    }
            	    
            	
            	    } finally { dbg.ExitDecision(8); }
            	
            	    switch (alt8) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);
            			
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:73:35: CHAR
            			    {
            			    	dbg.Location(73,35);
            			    	CHAR12 = (IToken)input.LT(1);
            			    	Match(input,CHAR,FOLLOW_CHAR_in_dmgType488); 
            			    	dbg.Location(73,40);
            			    	retval.name+=CHAR12.Text;
            			    
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
    
            retval.stop = input.LT(-1);
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        dbg.Location(73, 62);
        
        }
        finally
        {
            dbg.ExitRule("dmgType");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return retval;
    }
    // $ANTLR end dmgType

    
    // $ANTLR start dmgAmt
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:74:1: dmgAmt returns [int value] : ( DIGITS )+ ;
    public int dmgAmt() // throws RecognitionException [1]
    {   

        int value = 0;
    
        IToken DIGITS13 = null;
    
        try 
        {
        	dbg.EnterRule("dmgAmt");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(74, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:74:30: ( ( DIGITS )+ )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:74:32: ( DIGITS )+
            {
            	dbg.Location(74,32);
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:74:32: ( DIGITS )+
            	int cnt9 = 0;
            	try { dbg.EnterSubRule(9);
            	
            	do 
            	{
            	    int alt9 = 2;
            	    try { dbg.EnterDecision(9);
            	
            	    int LA9_0 = input.LA(1);
            	    
            	    if ( (LA9_0 == DIGITS) )
            	    {
            	        alt9 = 1;
            	    }
            	    
            	
            	    } finally { dbg.ExitDecision(9); }
            	
            	    switch (alt9) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);
            			
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:74:33: DIGITS
            			    {
            			    	dbg.Location(74,33);
            			    	DIGITS13 = (IToken)input.LT(1);
            			    	Match(input,DIGITS,FOLLOW_DIGITS_in_dmgAmt506); 
            			    	dbg.Location(74,40);
            			    	value += Convert.ToInt32(DIGITS13.Text);
            			    
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
        dbg.Location(74, 84);
        
        }
        finally
        {
            dbg.ExitRule("dmgAmt");
            ruleLevel--;
            if ( ruleLevel==0 ) {dbg.Terminate();}
        }
    
        return value;
    }
    // $ANTLR end dmgAmt

    
    // $ANTLR start verb
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:75:1: verb : ( WOUND | HEAL ) ;
    public void verb() // throws RecognitionException [1]
    {   
        try 
        {
        	dbg.EnterRule("verb");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(75, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:75:7: ( ( WOUND | HEAL ) )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:75:9: ( WOUND | HEAL )
            {
            	dbg.Location(75,9);
            	if ( (input.LA(1) >= WOUND && input.LA(1) <= HEAL) ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    dbg.RecognitionException(mse);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_verb518);    throw mse;
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
        dbg.Location(75, 23);
        
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
    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:76:1: prep : ( WITH | FOR | OF | FROM ) ;
    public void prep() // throws RecognitionException [1]
    {   
        try 
        {
        	dbg.EnterRule("prep");
        	if ( ruleLevel==0 ) {dbg.Commence();}
        	ruleLevel++;
        	dbg.Location(76, 1);
    
        try 
    	{
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:76:7: ( ( WITH | FOR | OF | FROM ) )
            dbg.EnterAlt(1);
            
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:76:9: ( WITH | FOR | OF | FROM )
            {
            	dbg.Location(76,9);
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_prep532);    throw mse;
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
        dbg.Location(76, 33);
        
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


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_combatLine_in_chatLine288 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_combatant1_in_combatLine304 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_WOUND_in_combatLine314 = new BitSet(new ulong[]{0x0000000000004F00UL});
    public static readonly BitSet FOLLOW_combatant2_in_combatLine325 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_prep_in_combatLine337 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_skill_in_combatLine339 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_prep_in_combatLine350 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_dmgAmt_in_combatLine361 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_POINTS_in_combatLine372 = new BitSet(new ulong[]{0x0000000000000F02UL});
    public static readonly BitSet FOLLOW_prep_in_combatLine383 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_dmgType_in_combatLine385 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_DAMAGE_in_combatLine387 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_combatant1_in_healLine410 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_HEAL_in_healLine412 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_combatant2_in_healLine414 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_prep_in_healLine416 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DIGITS_in_healLine418 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_prep_in_healLine420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_in_combatant1437 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_CHAR_in_combatant2454 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_CHAR_in_skill471 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_CHAR_in_dmgType488 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_DIGITS_in_dmgAmt506 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_set_in_verb518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_prep532 = new BitSet(new ulong[]{0x0000000000000002UL});

}
