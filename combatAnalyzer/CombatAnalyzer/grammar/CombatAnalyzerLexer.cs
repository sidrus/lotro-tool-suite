// $ANTLR 3.0.1 C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g 2008-04-05 00:01:35

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public class CombatAnalyzerLexer : Lexer 
{
    public const int NEWLINE = 15;
    public const int HEAL = 6;
    public const int POINTS = 12;
    public const int WOUND = 5;
    public const int DAMAGE = 4;
    public const int DIGITS = 14;
    public const int CHAR = 13;
    public const int CS_LOG_MSG_SYS = 17;
    public const int FOR = 8;
    public const int CS_COMMENT = 16;
    public const int FROM = 10;
    public const int LOGGING = 11;
    public const int Tokens = 18;
    public const int OF = 9;
    public const int EOF = -1;
    public const int WITH = 7;

    public CombatAnalyzerLexer() 
    {
		InitializeCyclicDFAs();
    }
    public CombatAnalyzerLexer(ICharStream input) 
		: base(input)
	{
		InitializeCyclicDFAs();
    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g";} 
    }

    // $ANTLR start DAMAGE 
    public void mDAMAGE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DAMAGE;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:9:8: ( 'damage' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:9:10: 'damage'
            {
            	Match("damage"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DAMAGE

    // $ANTLR start WOUND 
    public void mWOUND() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = WOUND;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:10:7: ( ( 'are ' | 'is ' )? 'wound' ( 'ed' | 's' )? )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:10:9: ( 'are ' | 'is ' )? 'wound' ( 'ed' | 's' )?
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:10:9: ( 'are ' | 'is ' )?
            	int alt1 = 3;
            	int LA1_0 = input.LA(1);
            	
            	if ( (LA1_0 == 'a') )
            	{
            	    alt1 = 1;
            	}
            	else if ( (LA1_0 == 'i') )
            	{
            	    alt1 = 2;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:10:10: 'are '
            	        {
            	        	Match("are "); 

            	        
            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:10:17: 'is '
            	        {
            	        	Match("is "); 

            	        
            	        }
            	        break;
            	
            	}

            	Match("wound"); 

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:10:33: ( 'ed' | 's' )?
            	int alt2 = 3;
            	int LA2_0 = input.LA(1);
            	
            	if ( (LA2_0 == 'e') )
            	{
            	    alt2 = 1;
            	}
            	else if ( (LA2_0 == 's') )
            	{
            	    alt2 = 2;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:10:34: 'ed'
            	        {
            	        	Match("ed"); 

            	        
            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:10:39: 's'
            	        {
            	        	Match('s'); 
            	        
            	        }
            	        break;
            	
            	}

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end WOUND

    // $ANTLR start HEAL 
    public void mHEAL() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = HEAL;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:6: ( ( 'are ' | 'is ' )? 'heal' ( 'ed' | 's' )? )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:8: ( 'are ' | 'is ' )? 'heal' ( 'ed' | 's' )?
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:8: ( 'are ' | 'is ' )?
            	int alt3 = 3;
            	int LA3_0 = input.LA(1);
            	
            	if ( (LA3_0 == 'a') )
            	{
            	    alt3 = 1;
            	}
            	else if ( (LA3_0 == 'i') )
            	{
            	    alt3 = 2;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:9: 'are '
            	        {
            	        	Match("are "); 

            	        
            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:16: 'is '
            	        {
            	        	Match("is "); 

            	        
            	        }
            	        break;
            	
            	}

            	Match("heal"); 

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:31: ( 'ed' | 's' )?
            	int alt4 = 3;
            	int LA4_0 = input.LA(1);
            	
            	if ( (LA4_0 == 'e') )
            	{
            	    alt4 = 1;
            	}
            	else if ( (LA4_0 == 's') )
            	{
            	    alt4 = 2;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:32: 'ed'
            	        {
            	        	Match("ed"); 

            	        
            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:37: 's'
            	        {
            	        	Match('s'); 
            	        
            	        }
            	        break;
            	
            	}

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end HEAL

    // $ANTLR start WITH 
    public void mWITH() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = WITH;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:12:6: ( 'with' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:12:8: 'with'
            {
            	Match("with"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end WITH

    // $ANTLR start FOR 
    public void mFOR() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = FOR;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:13:5: ( 'for' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:13:7: 'for'
            {
            	Match("for"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end FOR

    // $ANTLR start OF 
    public void mOF() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = OF;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:14:4: ( 'of' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:14:6: 'of'
            {
            	Match("of"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end OF

    // $ANTLR start FROM 
    public void mFROM() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = FROM;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:15:6: ( 'from' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:15:8: 'from'
            {
            	Match("from"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end FROM

    // $ANTLR start LOGGING 
    public void mLOGGING() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LOGGING;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:16:9: ( 'Logging chat tab' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:16:11: 'Logging chat tab'
            {
            	Match("Logging chat tab"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LOGGING

    // $ANTLR start POINTS 
    public void mPOINTS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = POINTS;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:17:8: ( ( 'point' ( 's' )? ) )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:17:10: ( 'point' ( 's' )? )
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:17:10: ( 'point' ( 's' )? )
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:17:11: 'point' ( 's' )?
            	{
            		Match("point"); 

            		// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:17:19: ( 's' )?
            		int alt5 = 2;
            		int LA5_0 = input.LA(1);
            		
            		if ( (LA5_0 == 's') )
            		{
            		    alt5 = 1;
            		}
            		switch (alt5) 
            		{
            		    case 1 :
            		        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:17:19: 's'
            		        {
            		        	Match('s'); 
            		        
            		        }
            		        break;
            		
            		}

            	
            	}

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end POINTS

    // $ANTLR start CHAR 
    public void mCHAR() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = CHAR;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:18:6: ( ( 'a' .. 'z' | 'A' .. 'Z' ) )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:18:8: ( 'a' .. 'z' | 'A' .. 'Z' )
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();
            	
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    Recover(mse);    throw mse;
            	}

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end CHAR

    // $ANTLR start DIGITS 
    public void mDIGITS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DIGITS;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:19:8: ( ( '0' .. '9' )+ )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:19:10: ( '0' .. '9' )+
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:19:10: ( '0' .. '9' )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);
            	    
            	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
            	    {
            	        alt6 = 1;
            	    }
            	    
            	
            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:19:11: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 
            			    
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
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DIGITS

    // $ANTLR start NEWLINE 
    public void mNEWLINE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NEWLINE;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:21:9: ( ( ( '\\r' )? '\\n' ) )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:21:11: ( ( '\\r' )? '\\n' )
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:21:11: ( ( '\\r' )? '\\n' )
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:21:12: ( '\\r' )? '\\n'
            	{
            		// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:21:12: ( '\\r' )?
            		int alt7 = 2;
            		int LA7_0 = input.LA(1);
            		
            		if ( (LA7_0 == '\r') )
            		{
            		    alt7 = 1;
            		}
            		switch (alt7) 
            		{
            		    case 1 :
            		        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:21:12: '\\r'
            		        {
            		        	Match('\r'); 
            		        
            		        }
            		        break;
            		
            		}

            		Match('\n'); 
            	
            	}

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NEWLINE

    // $ANTLR start CS_COMMENT 
    public void mCS_COMMENT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = CS_COMMENT;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:24:12: ( '###' ( options {greedy=false; } : . )* '###' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:24:14: '###' ( options {greedy=false; } : . )* '###'
            {
            	Match("###"); 

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:24:20: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);
            	    
            	    if ( (LA8_0 == '#') )
            	    {
            	        int LA8_1 = input.LA(2);
            	        
            	        if ( (LA8_1 == '#') )
            	        {
            	            int LA8_3 = input.LA(3);
            	            
            	            if ( (LA8_3 == '#') )
            	            {
            	                alt8 = 2;
            	            }
            	            else if ( ((LA8_3 >= '\u0000' && LA8_3 <= '\"') || (LA8_3 >= '$' && LA8_3 <= '\uFFFE')) )
            	            {
            	                alt8 = 1;
            	            }
            	            
            	        
            	        }
            	        else if ( ((LA8_1 >= '\u0000' && LA8_1 <= '\"') || (LA8_1 >= '$' && LA8_1 <= '\uFFFE')) )
            	        {
            	            alt8 = 1;
            	        }
            	        
            	    
            	    }
            	    else if ( ((LA8_0 >= '\u0000' && LA8_0 <= '\"') || (LA8_0 >= '$' && LA8_0 <= '\uFFFE')) )
            	    {
            	        alt8 = 1;
            	    }
            	    
            	
            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:24:47: .
            			    {
            			    	MatchAny(); 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop8;
            	    }
            	} while (true);
            	
            	loop8:
            		;	// Stops C# compiler whinging that label 'loop8' has no statements

            	Match("###"); 

            	channel=HIDDEN;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end CS_COMMENT

    // $ANTLR start CS_LOG_MSG_SYS 
    public void mCS_LOG_MSG_SYS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = CS_LOG_MSG_SYS;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:25:16: ( LOGGING ( options {greedy=false; } : . )* NEWLINE )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:25:18: LOGGING ( options {greedy=false; } : . )* NEWLINE
            {
            	mLOGGING(); 
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:25:26: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);
            	    
            	    if ( (LA9_0 == '\r') )
            	    {
            	        alt9 = 2;
            	    }
            	    else if ( (LA9_0 == '\n') )
            	    {
            	        alt9 = 2;
            	    }
            	    else if ( ((LA9_0 >= '\u0000' && LA9_0 <= '\t') || (LA9_0 >= '\u000B' && LA9_0 <= '\f') || (LA9_0 >= '\u000E' && LA9_0 <= '\uFFFE')) )
            	    {
            	        alt9 = 1;
            	    }
            	    
            	
            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:25:53: .
            			    {
            			    	MatchAny(); 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop9;
            	    }
            	} while (true);
            	
            	loop9:
            		;	// Stops C# compiler whinging that label 'loop9' has no statements

            	mNEWLINE(); 
            	channel=HIDDEN;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end CS_LOG_MSG_SYS

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:8: ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS )
        int alt10 = 14;
        switch ( input.LA(1) ) 
        {
        case 'd':
        	{
            int LA10_1 = input.LA(2);
            
            if ( (LA10_1 == 'a') )
            {
                alt10 = 1;
            }
            else 
            {
                alt10 = 10;}
            }
            break;
        case 'a':
        	{
            int LA10_2 = input.LA(2);
            
            if ( (LA10_2 == 'r') )
            {
                int LA10_15 = input.LA(3);
                
                if ( (LA10_15 == 'e') )
                {
                    int LA10_25 = input.LA(4);
                    
                    if ( (LA10_25 == ' ') )
                    {
                        int LA10_28 = input.LA(5);
                        
                        if ( (LA10_28 == 'w') )
                        {
                            alt10 = 2;
                        }
                        else if ( (LA10_28 == 'h') )
                        {
                            alt10 = 3;
                        }
                        else 
                        {
                            NoViableAltException nvae_d10s28 =
                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 28, input);
                        
                            throw nvae_d10s28;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d10s25 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 25, input);
                    
                        throw nvae_d10s25;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d10s15 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 15, input);
                
                    throw nvae_d10s15;
                }
            }
            else 
            {
                alt10 = 10;}
            }
            break;
        case 'i':
        	{
            int LA10_3 = input.LA(2);
            
            if ( (LA10_3 == 's') )
            {
                int LA10_16 = input.LA(3);
                
                if ( (LA10_16 == ' ') )
                {
                    int LA10_26 = input.LA(4);
                    
                    if ( (LA10_26 == 'h') )
                    {
                        alt10 = 3;
                    }
                    else if ( (LA10_26 == 'w') )
                    {
                        alt10 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d10s26 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 26, input);
                    
                        throw nvae_d10s26;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d10s16 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 16, input);
                
                    throw nvae_d10s16;
                }
            }
            else 
            {
                alt10 = 10;}
            }
            break;
        case 'w':
        	{
            switch ( input.LA(2) ) 
            {
            case 'i':
            	{
                alt10 = 4;
                }
                break;
            case 'o':
            	{
                alt10 = 2;
                }
                break;
            	default:
                	alt10 = 10;
                	break;}
        
            }
            break;
        case 'h':
        	{
            int LA10_5 = input.LA(2);
            
            if ( (LA10_5 == 'e') )
            {
                alt10 = 3;
            }
            else 
            {
                alt10 = 10;}
            }
            break;
        case 'f':
        	{
            switch ( input.LA(2) ) 
            {
            case 'o':
            	{
                alt10 = 5;
                }
                break;
            case 'r':
            	{
                alt10 = 7;
                }
                break;
            	default:
                	alt10 = 10;
                	break;}
        
            }
            break;
        case 'o':
        	{
            int LA10_7 = input.LA(2);
            
            if ( (LA10_7 == 'f') )
            {
                alt10 = 6;
            }
            else 
            {
                alt10 = 10;}
            }
            break;
        case 'L':
        	{
            int LA10_8 = input.LA(2);
            
            if ( (LA10_8 == 'o') )
            {
                int LA10_23 = input.LA(3);
                
                if ( (LA10_23 == 'g') )
                {
                    int LA10_27 = input.LA(4);
                    
                    if ( (LA10_27 == 'g') )
                    {
                        int LA10_29 = input.LA(5);
                        
                        if ( (LA10_29 == 'i') )
                        {
                            int LA10_30 = input.LA(6);
                            
                            if ( (LA10_30 == 'n') )
                            {
                                int LA10_31 = input.LA(7);
                                
                                if ( (LA10_31 == 'g') )
                                {
                                    int LA10_32 = input.LA(8);
                                    
                                    if ( (LA10_32 == ' ') )
                                    {
                                        int LA10_33 = input.LA(9);
                                        
                                        if ( (LA10_33 == 'c') )
                                        {
                                            int LA10_34 = input.LA(10);
                                            
                                            if ( (LA10_34 == 'h') )
                                            {
                                                int LA10_35 = input.LA(11);
                                                
                                                if ( (LA10_35 == 'a') )
                                                {
                                                    int LA10_36 = input.LA(12);
                                                    
                                                    if ( (LA10_36 == 't') )
                                                    {
                                                        int LA10_37 = input.LA(13);
                                                        
                                                        if ( (LA10_37 == ' ') )
                                                        {
                                                            int LA10_38 = input.LA(14);
                                                            
                                                            if ( (LA10_38 == 't') )
                                                            {
                                                                int LA10_39 = input.LA(15);
                                                                
                                                                if ( (LA10_39 == 'a') )
                                                                {
                                                                    int LA10_40 = input.LA(16);
                                                                    
                                                                    if ( (LA10_40 == 'b') )
                                                                    {
                                                                        int LA10_41 = input.LA(17);
                                                                        
                                                                        if ( ((LA10_41 >= '\u0000' && LA10_41 <= '\uFFFE')) )
                                                                        {
                                                                            alt10 = 14;
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt10 = 8;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        NoViableAltException nvae_d10s40 =
                                                                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 40, input);
                                                                    
                                                                        throw nvae_d10s40;
                                                                    }
                                                                }
                                                                else 
                                                                {
                                                                    NoViableAltException nvae_d10s39 =
                                                                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 39, input);
                                                                
                                                                    throw nvae_d10s39;
                                                                }
                                                            }
                                                            else 
                                                            {
                                                                NoViableAltException nvae_d10s38 =
                                                                    new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 38, input);
                                                            
                                                                throw nvae_d10s38;
                                                            }
                                                        }
                                                        else 
                                                        {
                                                            NoViableAltException nvae_d10s37 =
                                                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 37, input);
                                                        
                                                            throw nvae_d10s37;
                                                        }
                                                    }
                                                    else 
                                                    {
                                                        NoViableAltException nvae_d10s36 =
                                                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 36, input);
                                                    
                                                        throw nvae_d10s36;
                                                    }
                                                }
                                                else 
                                                {
                                                    NoViableAltException nvae_d10s35 =
                                                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 35, input);
                                                
                                                    throw nvae_d10s35;
                                                }
                                            }
                                            else 
                                            {
                                                NoViableAltException nvae_d10s34 =
                                                    new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 34, input);
                                            
                                                throw nvae_d10s34;
                                            }
                                        }
                                        else 
                                        {
                                            NoViableAltException nvae_d10s33 =
                                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 33, input);
                                        
                                            throw nvae_d10s33;
                                        }
                                    }
                                    else 
                                    {
                                        NoViableAltException nvae_d10s32 =
                                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 32, input);
                                    
                                        throw nvae_d10s32;
                                    }
                                }
                                else 
                                {
                                    NoViableAltException nvae_d10s31 =
                                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 31, input);
                                
                                    throw nvae_d10s31;
                                }
                            }
                            else 
                            {
                                NoViableAltException nvae_d10s30 =
                                    new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 30, input);
                            
                                throw nvae_d10s30;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d10s29 =
                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 29, input);
                        
                            throw nvae_d10s29;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d10s27 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 27, input);
                    
                        throw nvae_d10s27;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d10s23 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 23, input);
                
                    throw nvae_d10s23;
                }
            }
            else 
            {
                alt10 = 10;}
            }
            break;
        case 'p':
        	{
            int LA10_9 = input.LA(2);
            
            if ( (LA10_9 == 'o') )
            {
                alt10 = 9;
            }
            else 
            {
                alt10 = 10;}
            }
            break;
        case 'A':
        case 'B':
        case 'C':
        case 'D':
        case 'E':
        case 'F':
        case 'G':
        case 'H':
        case 'I':
        case 'J':
        case 'K':
        case 'M':
        case 'N':
        case 'O':
        case 'P':
        case 'Q':
        case 'R':
        case 'S':
        case 'T':
        case 'U':
        case 'V':
        case 'W':
        case 'X':
        case 'Y':
        case 'Z':
        case 'b':
        case 'c':
        case 'e':
        case 'g':
        case 'j':
        case 'k':
        case 'l':
        case 'm':
        case 'n':
        case 'q':
        case 'r':
        case 's':
        case 't':
        case 'u':
        case 'v':
        case 'x':
        case 'y':
        case 'z':
        	{
            alt10 = 10;
            }
            break;
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
        	{
            alt10 = 11;
            }
            break;
        case '\n':
        case '\r':
        	{
            alt10 = 12;
            }
            break;
        case '#':
        	{
            alt10 = 13;
            }
            break;
        	default:
        	    NoViableAltException nvae_d10s0 =
        	        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 10, 0, input);
        
        	    throw nvae_d10s0;
        }
        
        switch (alt10) 
        {
            case 1 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:10: DAMAGE
                {
                	mDAMAGE(); 
                
                }
                break;
            case 2 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:17: WOUND
                {
                	mWOUND(); 
                
                }
                break;
            case 3 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:23: HEAL
                {
                	mHEAL(); 
                
                }
                break;
            case 4 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:28: WITH
                {
                	mWITH(); 
                
                }
                break;
            case 5 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:33: FOR
                {
                	mFOR(); 
                
                }
                break;
            case 6 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:37: OF
                {
                	mOF(); 
                
                }
                break;
            case 7 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:40: FROM
                {
                	mFROM(); 
                
                }
                break;
            case 8 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:45: LOGGING
                {
                	mLOGGING(); 
                
                }
                break;
            case 9 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:53: POINTS
                {
                	mPOINTS(); 
                
                }
                break;
            case 10 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:60: CHAR
                {
                	mCHAR(); 
                
                }
                break;
            case 11 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:65: DIGITS
                {
                	mDIGITS(); 
                
                }
                break;
            case 12 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:72: NEWLINE
                {
                	mNEWLINE(); 
                
                }
                break;
            case 13 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:80: CS_COMMENT
                {
                	mCS_COMMENT(); 
                
                }
                break;
            case 14 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:91: CS_LOG_MSG_SYS
                {
                	mCS_LOG_MSG_SYS(); 
                
                }
                break;
        
        }
    
    }


	private void InitializeCyclicDFAs()
	{
	}

 
    
}
