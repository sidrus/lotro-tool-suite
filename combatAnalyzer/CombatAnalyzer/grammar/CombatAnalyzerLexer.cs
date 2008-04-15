// $ANTLR 3.0.1 C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g 2008-04-05 02:44:04

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public class CombatAnalyzerLexer : Lexer 
{
    public const int CL_REFLECT_LINE = 19;
    public const int REFLECT = 7;
    public const int HEAL = 6;
    public const int WOUND = 5;
    public const int POINTS = 13;
    public const int DAMAGE = 4;
    public const int DIGITS = 15;
    public const int CHAR = 14;
    public const int FOR = 9;
    public const int LOGGING = 12;
    public const int CL_COMMENT = 17;
    public const int Tokens = 20;
    public const int EOF = -1;
    public const int OF = 10;
    public const int NEWLINE = 16;
    public const int CL_SYS_MSG = 18;
    public const int FROM = 11;
    public const int WITH = 8;

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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:10:8: ( 'damage' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:10:10: 'damage'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:7: ( ( 'are ' | 'is ' )? 'wound' ( 'ed' | 's' )? )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:9: ( 'are ' | 'is ' )? 'wound' ( 'ed' | 's' )?
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:9: ( 'are ' | 'is ' )?
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
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:10: 'are '
            	        {
            	        	Match("are "); 

            	        
            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:17: 'is '
            	        {
            	        	Match("is "); 

            	        
            	        }
            	        break;
            	
            	}

            	Match("wound"); 

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:33: ( 'ed' | 's' )?
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
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:34: 'ed'
            	        {
            	        	Match("ed"); 

            	        
            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:39: 's'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:12:6: ( ( 'are ' | 'is ' )? 'heal' ( 'ed' | 's' )? )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:12:8: ( 'are ' | 'is ' )? 'heal' ( 'ed' | 's' )?
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:12:8: ( 'are ' | 'is ' )?
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
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:12:9: 'are '
            	        {
            	        	Match("are "); 

            	        
            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:12:16: 'is '
            	        {
            	        	Match("is "); 

            	        
            	        }
            	        break;
            	
            	}

            	Match("heal"); 

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:12:31: ( 'ed' | 's' )?
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
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:12:32: 'ed'
            	        {
            	        	Match("ed"); 

            	        
            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:12:37: 's'
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

    // $ANTLR start REFLECT 
    public void mREFLECT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = REFLECT;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:13:9: ( 'reflect' ( 's' )? )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:13:11: 'reflect' ( 's' )?
            {
            	Match("reflect"); 

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:13:21: ( 's' )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);
            	
            	if ( (LA5_0 == 's') )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:13:21: 's'
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
    // $ANTLR end REFLECT

    // $ANTLR start WITH 
    public void mWITH() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = WITH;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:14:6: ( 'with' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:14:8: 'with'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:15:6: ( 'for' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:15:8: 'for'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:16:5: ( 'of' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:16:7: 'of'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:17:6: ( 'from' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:17:8: 'from'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:18:9: ( 'Logging chat tab' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:18:11: 'Logging chat tab'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:19:8: ( ( 'point' ( 's' )? ) )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:19:10: ( 'point' ( 's' )? )
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:19:10: ( 'point' ( 's' )? )
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:19:11: 'point' ( 's' )?
            	{
            		Match("point"); 

            		// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:19:19: ( 's' )?
            		int alt6 = 2;
            		int LA6_0 = input.LA(1);
            		
            		if ( (LA6_0 == 's') )
            		{
            		    alt6 = 1;
            		}
            		switch (alt6) 
            		{
            		    case 1 :
            		        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:19:19: 's'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:20:6: ( ( 'a' .. 'z' | 'A' .. 'Z' ) )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:20:8: ( 'a' .. 'z' | 'A' .. 'Z' )
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:21:8: ( ( '0' .. '9' )+ )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:21:10: ( '0' .. '9' )+
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:21:10: ( '0' .. '9' )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);
            	    
            	    if ( ((LA7_0 >= '0' && LA7_0 <= '9')) )
            	    {
            	        alt7 = 1;
            	    }
            	    
            	
            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:21:11: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 
            			    
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:22:9: ( ( ( '\\r' )? '\\n' ) )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:22:11: ( ( '\\r' )? '\\n' )
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:22:11: ( ( '\\r' )? '\\n' )
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:22:12: ( '\\r' )? '\\n'
            	{
            		// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:22:12: ( '\\r' )?
            		int alt8 = 2;
            		int LA8_0 = input.LA(1);
            		
            		if ( (LA8_0 == '\r') )
            		{
            		    alt8 = 1;
            		}
            		switch (alt8) 
            		{
            		    case 1 :
            		        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:22:12: '\\r'
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

    // $ANTLR start CL_COMMENT 
    public void mCL_COMMENT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = CL_COMMENT;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:25:12: ( '###' ( options {greedy=false; } : . )* '###' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:25:14: '###' ( options {greedy=false; } : . )* '###'
            {
            	Match("###"); 

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:25:20: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);
            	    
            	    if ( (LA9_0 == '#') )
            	    {
            	        int LA9_1 = input.LA(2);
            	        
            	        if ( (LA9_1 == '#') )
            	        {
            	            int LA9_3 = input.LA(3);
            	            
            	            if ( (LA9_3 == '#') )
            	            {
            	                alt9 = 2;
            	            }
            	            else if ( ((LA9_3 >= '\u0000' && LA9_3 <= '\"') || (LA9_3 >= '$' && LA9_3 <= '\uFFFE')) )
            	            {
            	                alt9 = 1;
            	            }
            	            
            	        
            	        }
            	        else if ( ((LA9_1 >= '\u0000' && LA9_1 <= '\"') || (LA9_1 >= '$' && LA9_1 <= '\uFFFE')) )
            	        {
            	            alt9 = 1;
            	        }
            	        
            	    
            	    }
            	    else if ( ((LA9_0 >= '\u0000' && LA9_0 <= '\"') || (LA9_0 >= '$' && LA9_0 <= '\uFFFE')) )
            	    {
            	        alt9 = 1;
            	    }
            	    
            	
            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:25:47: .
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

            	Match("###"); 

            	channel=HIDDEN;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end CL_COMMENT

    // $ANTLR start CL_SYS_MSG 
    public void mCL_SYS_MSG() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = CL_SYS_MSG;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:26:12: ( LOGGING ( options {greedy=false; } : . )* NEWLINE )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:26:14: LOGGING ( options {greedy=false; } : . )* NEWLINE
            {
            	mLOGGING(); 
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:26:22: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);
            	    
            	    if ( (LA10_0 == '\r') )
            	    {
            	        alt10 = 2;
            	    }
            	    else if ( (LA10_0 == '\n') )
            	    {
            	        alt10 = 2;
            	    }
            	    else if ( ((LA10_0 >= '\u0000' && LA10_0 <= '\t') || (LA10_0 >= '\u000B' && LA10_0 <= '\f') || (LA10_0 >= '\u000E' && LA10_0 <= '\uFFFE')) )
            	    {
            	        alt10 = 1;
            	    }
            	    
            	
            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:26:49: .
            			    {
            			    	MatchAny(); 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop10;
            	    }
            	} while (true);
            	
            	loop10:
            		;	// Stops C# compiler whinging that label 'loop10' has no statements

            	mNEWLINE(); 
            	
            		channel=HIDDEN;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end CL_SYS_MSG

    // $ANTLR start CL_REFLECT_LINE 
    public void mCL_REFLECT_LINE() // throws RecognitionException [2]
    {

        string text = null;
    
        try 
    	{
            int _type = CL_REFLECT_LINE;
            Token CHAR1 = null;
            Token REFLECT2 = null;
    
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:31:39: ( ( CHAR )+ ( ' ' ) ( REFLECT ) ( options {greedy=false; } : . )* NEWLINE )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:32:2: ( CHAR )+ ( ' ' ) ( REFLECT ) ( options {greedy=false; } : . )* NEWLINE
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:32:2: ( CHAR )+
            	int cnt11 = 0;
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);
            	    
            	    if ( ((LA11_0 >= 'A' && LA11_0 <= 'Z') || (LA11_0 >= 'a' && LA11_0 <= 'z')) )
            	    {
            	        alt11 = 1;
            	    }
            	    
            	
            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:32:3: CHAR
            			    {
            			    	int CHAR1Start247 = CharIndex;
            			    	mCHAR(); 
            			    	CHAR1 = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, CHAR1Start247, CharIndex-1);
            			    	text+=CHAR1.Text;
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt11 >= 1 ) goto loop11;
            		            EarlyExitException eee =
            		                new EarlyExitException(11, input);
            		            throw eee;
            	    }
            	    cnt11++;
            	} while (true);
            	
            	loop11:
            		;	// Stops C# compiler whinging that label 'loop11' has no statements

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:33:2: ( ' ' )
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:33:3: ' '
            	{
            		Match(' '); 
            		text+=" ";
            	
            	}

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:34:2: ( REFLECT )
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:34:3: REFLECT
            	{
            		int REFLECT2Start264 = CharIndex;
            		mREFLECT(); 
            		REFLECT2 = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, REFLECT2Start264, CharIndex-1);
            		text+=REFLECT2.Text;
            	
            	}

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:35:2: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);
            	    
            	    if ( (LA12_0 == '\r') )
            	    {
            	        alt12 = 2;
            	    }
            	    else if ( (LA12_0 == '\n') )
            	    {
            	        alt12 = 2;
            	    }
            	    else if ( ((LA12_0 >= '\u0000' && LA12_0 <= '\t') || (LA12_0 >= '\u000B' && LA12_0 <= '\f') || (LA12_0 >= '\u000E' && LA12_0 <= '\uFFFE')) )
            	    {
            	        alt12 = 1;
            	    }
            	    
            	
            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:35:29: .
            			    {
            			    	MatchAny(); 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop12;
            	    }
            	} while (true);
            	
            	loop12:
            		;	// Stops C# compiler whinging that label 'loop12' has no statements

            	mNEWLINE(); 
            	
            			//System.Windows.Forms.MessageBox.Show(text);
            			//channel=HIDDEN;
            		
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end CL_REFLECT_LINE

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:8: ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE )
        int alt13 = 16;
        switch ( input.LA(1) ) 
        {
        case 'd':
        	{
            switch ( input.LA(2) ) 
            {
            case 'a':
            	{
                int LA13_15 = input.LA(3);
                
                if ( (LA13_15 == 'm') )
                {
                    int LA13_29 = input.LA(4);
                    
                    if ( (LA13_29 == 'a') )
                    {
                        int LA13_41 = input.LA(5);
                        
                        if ( (LA13_41 == 'g') )
                        {
                            int LA13_53 = input.LA(6);
                            
                            if ( (LA13_53 == 'e') )
                            {
                                int LA13_62 = input.LA(7);
                                
                                if ( (LA13_62 == ' ' || (LA13_62 >= 'A' && LA13_62 <= 'Z') || (LA13_62 >= 'a' && LA13_62 <= 'z')) )
                                {
                                    alt13 = 16;
                                }
                                else 
                                {
                                    alt13 = 1;}
                            }
                            else if ( (LA13_53 == ' ' || (LA13_53 >= 'A' && LA13_53 <= 'Z') || (LA13_53 >= 'a' && LA13_53 <= 'd') || (LA13_53 >= 'f' && LA13_53 <= 'z')) )
                            {
                                alt13 = 16;
                            }
                            else 
                            {
                                NoViableAltException nvae_d13s53 =
                                    new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 53, input);
                            
                                throw nvae_d13s53;
                            }
                        }
                        else if ( (LA13_41 == ' ' || (LA13_41 >= 'A' && LA13_41 <= 'Z') || (LA13_41 >= 'a' && LA13_41 <= 'f') || (LA13_41 >= 'h' && LA13_41 <= 'z')) )
                        {
                            alt13 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d13s41 =
                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 41, input);
                        
                            throw nvae_d13s41;
                        }
                    }
                    else if ( (LA13_29 == ' ' || (LA13_29 >= 'A' && LA13_29 <= 'Z') || (LA13_29 >= 'b' && LA13_29 <= 'z')) )
                    {
                        alt13 = 16;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s29 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 29, input);
                    
                        throw nvae_d13s29;
                    }
                }
                else if ( (LA13_15 == ' ' || (LA13_15 >= 'A' && LA13_15 <= 'Z') || (LA13_15 >= 'a' && LA13_15 <= 'l') || (LA13_15 >= 'n' && LA13_15 <= 'z')) )
                {
                    alt13 = 16;
                }
                else 
                {
                    NoViableAltException nvae_d13s15 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 15, input);
                
                    throw nvae_d13s15;
                }
                }
                break;
            case ' ':
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
            case 'L':
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
            case 'd':
            case 'e':
            case 'f':
            case 'g':
            case 'h':
            case 'i':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'o':
            case 'p':
            case 'q':
            case 'r':
            case 's':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
            	{
                alt13 = 16;
                }
                break;
            	default:
                	alt13 = 11;
                	break;}
        
            }
            break;
        case 'a':
        	{
            switch ( input.LA(2) ) 
            {
            case 'r':
            	{
                int LA13_18 = input.LA(3);
                
                if ( (LA13_18 == 'e') )
                {
                    int LA13_30 = input.LA(4);
                    
                    if ( (LA13_30 == ' ') )
                    {
                        switch ( input.LA(5) ) 
                        {
                        case 'w':
                        	{
                            alt13 = 2;
                            }
                            break;
                        case 'h':
                        	{
                            alt13 = 3;
                            }
                            break;
                        case 'r':
                        	{
                            alt13 = 16;
                            }
                            break;
                        	default:
                        	    NoViableAltException nvae_d13s42 =
                        	        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 42, input);
                        
                        	    throw nvae_d13s42;
                        }
                    
                    }
                    else if ( ((LA13_30 >= 'A' && LA13_30 <= 'Z') || (LA13_30 >= 'a' && LA13_30 <= 'z')) )
                    {
                        alt13 = 16;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s30 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 30, input);
                    
                        throw nvae_d13s30;
                    }
                }
                else if ( (LA13_18 == ' ' || (LA13_18 >= 'A' && LA13_18 <= 'Z') || (LA13_18 >= 'a' && LA13_18 <= 'd') || (LA13_18 >= 'f' && LA13_18 <= 'z')) )
                {
                    alt13 = 16;
                }
                else 
                {
                    NoViableAltException nvae_d13s18 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 18, input);
                
                    throw nvae_d13s18;
                }
                }
                break;
            case ' ':
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
            case 'L':
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
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'e':
            case 'f':
            case 'g':
            case 'h':
            case 'i':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'o':
            case 'p':
            case 'q':
            case 's':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
            	{
                alt13 = 16;
                }
                break;
            	default:
                	alt13 = 11;
                	break;}
        
            }
            break;
        case 'i':
        	{
            switch ( input.LA(2) ) 
            {
            case 's':
            	{
                int LA13_19 = input.LA(3);
                
                if ( (LA13_19 == ' ') )
                {
                    switch ( input.LA(4) ) 
                    {
                    case 'r':
                    	{
                        alt13 = 16;
                        }
                        break;
                    case 'w':
                    	{
                        alt13 = 2;
                        }
                        break;
                    case 'h':
                    	{
                        alt13 = 3;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d13s31 =
                    	        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 31, input);
                    
                    	    throw nvae_d13s31;
                    }
                
                }
                else if ( ((LA13_19 >= 'A' && LA13_19 <= 'Z') || (LA13_19 >= 'a' && LA13_19 <= 'z')) )
                {
                    alt13 = 16;
                }
                else 
                {
                    NoViableAltException nvae_d13s19 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 19, input);
                
                    throw nvae_d13s19;
                }
                }
                break;
            case ' ':
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
            case 'L':
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
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'e':
            case 'f':
            case 'g':
            case 'h':
            case 'i':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'o':
            case 'p':
            case 'q':
            case 'r':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
            	{
                alt13 = 16;
                }
                break;
            	default:
                	alt13 = 11;
                	break;}
        
            }
            break;
        case 'w':
        	{
            switch ( input.LA(2) ) 
            {
            case 'o':
            	{
                int LA13_20 = input.LA(3);
                
                if ( (LA13_20 == 'u') )
                {
                    int LA13_32 = input.LA(4);
                    
                    if ( (LA13_32 == 'n') )
                    {
                        int LA13_45 = input.LA(5);
                        
                        if ( (LA13_45 == 'd') )
                        {
                            switch ( input.LA(6) ) 
                            {
                            case 'e':
                            	{
                                int LA13_63 = input.LA(7);
                                
                                if ( (LA13_63 == 'd') )
                                {
                                    int LA13_71 = input.LA(8);
                                    
                                    if ( (LA13_71 == ' ' || (LA13_71 >= 'A' && LA13_71 <= 'Z') || (LA13_71 >= 'a' && LA13_71 <= 'z')) )
                                    {
                                        alt13 = 16;
                                    }
                                    else 
                                    {
                                        alt13 = 2;}
                                }
                                else if ( (LA13_63 == ' ' || (LA13_63 >= 'A' && LA13_63 <= 'Z') || (LA13_63 >= 'a' && LA13_63 <= 'c') || (LA13_63 >= 'e' && LA13_63 <= 'z')) )
                                {
                                    alt13 = 16;
                                }
                                else 
                                {
                                    NoViableAltException nvae_d13s63 =
                                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 63, input);
                                
                                    throw nvae_d13s63;
                                }
                                }
                                break;
                            case 's':
                            	{
                                int LA13_64 = input.LA(7);
                                
                                if ( (LA13_64 == ' ' || (LA13_64 >= 'A' && LA13_64 <= 'Z') || (LA13_64 >= 'a' && LA13_64 <= 'z')) )
                                {
                                    alt13 = 16;
                                }
                                else 
                                {
                                    alt13 = 2;}
                                }
                                break;
                            case ' ':
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
                            case 'L':
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
                            case 'a':
                            case 'b':
                            case 'c':
                            case 'd':
                            case 'f':
                            case 'g':
                            case 'h':
                            case 'i':
                            case 'j':
                            case 'k':
                            case 'l':
                            case 'm':
                            case 'n':
                            case 'o':
                            case 'p':
                            case 'q':
                            case 'r':
                            case 't':
                            case 'u':
                            case 'v':
                            case 'w':
                            case 'x':
                            case 'y':
                            case 'z':
                            	{
                                alt13 = 16;
                                }
                                break;
                            	default:
                                	alt13 = 2;
                                	break;}
                        
                        }
                        else if ( (LA13_45 == ' ' || (LA13_45 >= 'A' && LA13_45 <= 'Z') || (LA13_45 >= 'a' && LA13_45 <= 'c') || (LA13_45 >= 'e' && LA13_45 <= 'z')) )
                        {
                            alt13 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d13s45 =
                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 45, input);
                        
                            throw nvae_d13s45;
                        }
                    }
                    else if ( (LA13_32 == ' ' || (LA13_32 >= 'A' && LA13_32 <= 'Z') || (LA13_32 >= 'a' && LA13_32 <= 'm') || (LA13_32 >= 'o' && LA13_32 <= 'z')) )
                    {
                        alt13 = 16;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s32 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 32, input);
                    
                        throw nvae_d13s32;
                    }
                }
                else if ( (LA13_20 == ' ' || (LA13_20 >= 'A' && LA13_20 <= 'Z') || (LA13_20 >= 'a' && LA13_20 <= 't') || (LA13_20 >= 'v' && LA13_20 <= 'z')) )
                {
                    alt13 = 16;
                }
                else 
                {
                    NoViableAltException nvae_d13s20 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 20, input);
                
                    throw nvae_d13s20;
                }
                }
                break;
            case 'i':
            	{
                int LA13_21 = input.LA(3);
                
                if ( (LA13_21 == 't') )
                {
                    int LA13_33 = input.LA(4);
                    
                    if ( (LA13_33 == 'h') )
                    {
                        int LA13_46 = input.LA(5);
                        
                        if ( (LA13_46 == ' ' || (LA13_46 >= 'A' && LA13_46 <= 'Z') || (LA13_46 >= 'a' && LA13_46 <= 'z')) )
                        {
                            alt13 = 16;
                        }
                        else 
                        {
                            alt13 = 5;}
                    }
                    else if ( (LA13_33 == ' ' || (LA13_33 >= 'A' && LA13_33 <= 'Z') || (LA13_33 >= 'a' && LA13_33 <= 'g') || (LA13_33 >= 'i' && LA13_33 <= 'z')) )
                    {
                        alt13 = 16;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s33 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 33, input);
                    
                        throw nvae_d13s33;
                    }
                }
                else if ( (LA13_21 == ' ' || (LA13_21 >= 'A' && LA13_21 <= 'Z') || (LA13_21 >= 'a' && LA13_21 <= 's') || (LA13_21 >= 'u' && LA13_21 <= 'z')) )
                {
                    alt13 = 16;
                }
                else 
                {
                    NoViableAltException nvae_d13s21 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 21, input);
                
                    throw nvae_d13s21;
                }
                }
                break;
            case ' ':
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
            case 'L':
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
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'e':
            case 'f':
            case 'g':
            case 'h':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'p':
            case 'q':
            case 'r':
            case 's':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
            	{
                alt13 = 16;
                }
                break;
            	default:
                	alt13 = 11;
                	break;}
        
            }
            break;
        case 'h':
        	{
            switch ( input.LA(2) ) 
            {
            case 'e':
            	{
                int LA13_22 = input.LA(3);
                
                if ( (LA13_22 == 'a') )
                {
                    int LA13_34 = input.LA(4);
                    
                    if ( (LA13_34 == 'l') )
                    {
                        switch ( input.LA(5) ) 
                        {
                        case 'e':
                        	{
                            int LA13_56 = input.LA(6);
                            
                            if ( (LA13_56 == 'd') )
                            {
                                int LA13_65 = input.LA(7);
                                
                                if ( (LA13_65 == ' ' || (LA13_65 >= 'A' && LA13_65 <= 'Z') || (LA13_65 >= 'a' && LA13_65 <= 'z')) )
                                {
                                    alt13 = 16;
                                }
                                else 
                                {
                                    alt13 = 3;}
                            }
                            else if ( (LA13_56 == ' ' || (LA13_56 >= 'A' && LA13_56 <= 'Z') || (LA13_56 >= 'a' && LA13_56 <= 'c') || (LA13_56 >= 'e' && LA13_56 <= 'z')) )
                            {
                                alt13 = 16;
                            }
                            else 
                            {
                                NoViableAltException nvae_d13s56 =
                                    new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 56, input);
                            
                                throw nvae_d13s56;
                            }
                            }
                            break;
                        case 's':
                        	{
                            int LA13_57 = input.LA(6);
                            
                            if ( (LA13_57 == ' ' || (LA13_57 >= 'A' && LA13_57 <= 'Z') || (LA13_57 >= 'a' && LA13_57 <= 'z')) )
                            {
                                alt13 = 16;
                            }
                            else 
                            {
                                alt13 = 3;}
                            }
                            break;
                        case ' ':
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
                        case 'L':
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
                        case 'a':
                        case 'b':
                        case 'c':
                        case 'd':
                        case 'f':
                        case 'g':
                        case 'h':
                        case 'i':
                        case 'j':
                        case 'k':
                        case 'l':
                        case 'm':
                        case 'n':
                        case 'o':
                        case 'p':
                        case 'q':
                        case 'r':
                        case 't':
                        case 'u':
                        case 'v':
                        case 'w':
                        case 'x':
                        case 'y':
                        case 'z':
                        	{
                            alt13 = 16;
                            }
                            break;
                        	default:
                            	alt13 = 3;
                            	break;}
                    
                    }
                    else if ( (LA13_34 == ' ' || (LA13_34 >= 'A' && LA13_34 <= 'Z') || (LA13_34 >= 'a' && LA13_34 <= 'k') || (LA13_34 >= 'm' && LA13_34 <= 'z')) )
                    {
                        alt13 = 16;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s34 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 34, input);
                    
                        throw nvae_d13s34;
                    }
                }
                else if ( (LA13_22 == ' ' || (LA13_22 >= 'A' && LA13_22 <= 'Z') || (LA13_22 >= 'b' && LA13_22 <= 'z')) )
                {
                    alt13 = 16;
                }
                else 
                {
                    NoViableAltException nvae_d13s22 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 22, input);
                
                    throw nvae_d13s22;
                }
                }
                break;
            case ' ':
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
            case 'L':
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
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'f':
            case 'g':
            case 'h':
            case 'i':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'o':
            case 'p':
            case 'q':
            case 'r':
            case 's':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
            	{
                alt13 = 16;
                }
                break;
            	default:
                	alt13 = 11;
                	break;}
        
            }
            break;
        case 'r':
        	{
            switch ( input.LA(2) ) 
            {
            case 'e':
            	{
                int LA13_23 = input.LA(3);
                
                if ( (LA13_23 == 'f') )
                {
                    int LA13_35 = input.LA(4);
                    
                    if ( (LA13_35 == 'l') )
                    {
                        int LA13_48 = input.LA(5);
                        
                        if ( (LA13_48 == 'e') )
                        {
                            int LA13_58 = input.LA(6);
                            
                            if ( (LA13_58 == 'c') )
                            {
                                int LA13_66 = input.LA(7);
                                
                                if ( (LA13_66 == 't') )
                                {
                                    switch ( input.LA(8) ) 
                                    {
                                    case ' ':
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
                                    case 'L':
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
                                    case 'a':
                                    case 'b':
                                    case 'c':
                                    case 'd':
                                    case 'e':
                                    case 'f':
                                    case 'g':
                                    case 'h':
                                    case 'i':
                                    case 'j':
                                    case 'k':
                                    case 'l':
                                    case 'm':
                                    case 'n':
                                    case 'o':
                                    case 'p':
                                    case 'q':
                                    case 'r':
                                    case 't':
                                    case 'u':
                                    case 'v':
                                    case 'w':
                                    case 'x':
                                    case 'y':
                                    case 'z':
                                    	{
                                        alt13 = 16;
                                        }
                                        break;
                                    case 's':
                                    	{
                                        int LA13_75 = input.LA(9);
                                        
                                        if ( (LA13_75 == ' ' || (LA13_75 >= 'A' && LA13_75 <= 'Z') || (LA13_75 >= 'a' && LA13_75 <= 'z')) )
                                        {
                                            alt13 = 16;
                                        }
                                        else 
                                        {
                                            alt13 = 4;}
                                        }
                                        break;
                                    	default:
                                        	alt13 = 4;
                                        	break;}
                                
                                }
                                else if ( (LA13_66 == ' ' || (LA13_66 >= 'A' && LA13_66 <= 'Z') || (LA13_66 >= 'a' && LA13_66 <= 's') || (LA13_66 >= 'u' && LA13_66 <= 'z')) )
                                {
                                    alt13 = 16;
                                }
                                else 
                                {
                                    NoViableAltException nvae_d13s66 =
                                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 66, input);
                                
                                    throw nvae_d13s66;
                                }
                            }
                            else if ( (LA13_58 == ' ' || (LA13_58 >= 'A' && LA13_58 <= 'Z') || (LA13_58 >= 'a' && LA13_58 <= 'b') || (LA13_58 >= 'd' && LA13_58 <= 'z')) )
                            {
                                alt13 = 16;
                            }
                            else 
                            {
                                NoViableAltException nvae_d13s58 =
                                    new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 58, input);
                            
                                throw nvae_d13s58;
                            }
                        }
                        else if ( (LA13_48 == ' ' || (LA13_48 >= 'A' && LA13_48 <= 'Z') || (LA13_48 >= 'a' && LA13_48 <= 'd') || (LA13_48 >= 'f' && LA13_48 <= 'z')) )
                        {
                            alt13 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d13s48 =
                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 48, input);
                        
                            throw nvae_d13s48;
                        }
                    }
                    else if ( (LA13_35 == ' ' || (LA13_35 >= 'A' && LA13_35 <= 'Z') || (LA13_35 >= 'a' && LA13_35 <= 'k') || (LA13_35 >= 'm' && LA13_35 <= 'z')) )
                    {
                        alt13 = 16;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s35 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 35, input);
                    
                        throw nvae_d13s35;
                    }
                }
                else if ( (LA13_23 == ' ' || (LA13_23 >= 'A' && LA13_23 <= 'Z') || (LA13_23 >= 'a' && LA13_23 <= 'e') || (LA13_23 >= 'g' && LA13_23 <= 'z')) )
                {
                    alt13 = 16;
                }
                else 
                {
                    NoViableAltException nvae_d13s23 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 23, input);
                
                    throw nvae_d13s23;
                }
                }
                break;
            case ' ':
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
            case 'L':
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
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'f':
            case 'g':
            case 'h':
            case 'i':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'o':
            case 'p':
            case 'q':
            case 'r':
            case 's':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
            	{
                alt13 = 16;
                }
                break;
            	default:
                	alt13 = 11;
                	break;}
        
            }
            break;
        case 'f':
        	{
            switch ( input.LA(2) ) 
            {
            case 'r':
            	{
                int LA13_24 = input.LA(3);
                
                if ( (LA13_24 == 'o') )
                {
                    int LA13_36 = input.LA(4);
                    
                    if ( (LA13_36 == 'm') )
                    {
                        int LA13_49 = input.LA(5);
                        
                        if ( (LA13_49 == ' ' || (LA13_49 >= 'A' && LA13_49 <= 'Z') || (LA13_49 >= 'a' && LA13_49 <= 'z')) )
                        {
                            alt13 = 16;
                        }
                        else 
                        {
                            alt13 = 8;}
                    }
                    else if ( (LA13_36 == ' ' || (LA13_36 >= 'A' && LA13_36 <= 'Z') || (LA13_36 >= 'a' && LA13_36 <= 'l') || (LA13_36 >= 'n' && LA13_36 <= 'z')) )
                    {
                        alt13 = 16;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s36 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 36, input);
                    
                        throw nvae_d13s36;
                    }
                }
                else if ( (LA13_24 == ' ' || (LA13_24 >= 'A' && LA13_24 <= 'Z') || (LA13_24 >= 'a' && LA13_24 <= 'n') || (LA13_24 >= 'p' && LA13_24 <= 'z')) )
                {
                    alt13 = 16;
                }
                else 
                {
                    NoViableAltException nvae_d13s24 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 24, input);
                
                    throw nvae_d13s24;
                }
                }
                break;
            case 'o':
            	{
                int LA13_25 = input.LA(3);
                
                if ( (LA13_25 == 'r') )
                {
                    int LA13_37 = input.LA(4);
                    
                    if ( (LA13_37 == ' ' || (LA13_37 >= 'A' && LA13_37 <= 'Z') || (LA13_37 >= 'a' && LA13_37 <= 'z')) )
                    {
                        alt13 = 16;
                    }
                    else 
                    {
                        alt13 = 6;}
                }
                else if ( (LA13_25 == ' ' || (LA13_25 >= 'A' && LA13_25 <= 'Z') || (LA13_25 >= 'a' && LA13_25 <= 'q') || (LA13_25 >= 's' && LA13_25 <= 'z')) )
                {
                    alt13 = 16;
                }
                else 
                {
                    NoViableAltException nvae_d13s25 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 25, input);
                
                    throw nvae_d13s25;
                }
                }
                break;
            case ' ':
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
            case 'L':
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
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'e':
            case 'f':
            case 'g':
            case 'h':
            case 'i':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'p':
            case 'q':
            case 's':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
            	{
                alt13 = 16;
                }
                break;
            	default:
                	alt13 = 11;
                	break;}
        
            }
            break;
        case 'o':
        	{
            switch ( input.LA(2) ) 
            {
            case 'f':
            	{
                int LA13_26 = input.LA(3);
                
                if ( (LA13_26 == ' ' || (LA13_26 >= 'A' && LA13_26 <= 'Z') || (LA13_26 >= 'a' && LA13_26 <= 'z')) )
                {
                    alt13 = 16;
                }
                else 
                {
                    alt13 = 7;}
                }
                break;
            case ' ':
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
            case 'L':
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
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'e':
            case 'g':
            case 'h':
            case 'i':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'o':
            case 'p':
            case 'q':
            case 'r':
            case 's':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
            	{
                alt13 = 16;
                }
                break;
            	default:
                	alt13 = 11;
                	break;}
        
            }
            break;
        case 'L':
        	{
            switch ( input.LA(2) ) 
            {
            case 'o':
            	{
                int LA13_27 = input.LA(3);
                
                if ( (LA13_27 == 'g') )
                {
                    int LA13_39 = input.LA(4);
                    
                    if ( (LA13_39 == 'g') )
                    {
                        int LA13_51 = input.LA(5);
                        
                        if ( (LA13_51 == 'i') )
                        {
                            int LA13_60 = input.LA(6);
                            
                            if ( (LA13_60 == 'n') )
                            {
                                int LA13_67 = input.LA(7);
                                
                                if ( (LA13_67 == 'g') )
                                {
                                    int LA13_73 = input.LA(8);
                                    
                                    if ( (LA13_73 == ' ') )
                                    {
                                        int LA13_76 = input.LA(9);
                                        
                                        if ( (LA13_76 == 'c') )
                                        {
                                            int LA13_77 = input.LA(10);
                                            
                                            if ( (LA13_77 == 'h') )
                                            {
                                                int LA13_78 = input.LA(11);
                                                
                                                if ( (LA13_78 == 'a') )
                                                {
                                                    int LA13_79 = input.LA(12);
                                                    
                                                    if ( (LA13_79 == 't') )
                                                    {
                                                        int LA13_80 = input.LA(13);
                                                        
                                                        if ( (LA13_80 == ' ') )
                                                        {
                                                            int LA13_81 = input.LA(14);
                                                            
                                                            if ( (LA13_81 == 't') )
                                                            {
                                                                int LA13_82 = input.LA(15);
                                                                
                                                                if ( (LA13_82 == 'a') )
                                                                {
                                                                    int LA13_83 = input.LA(16);
                                                                    
                                                                    if ( (LA13_83 == 'b') )
                                                                    {
                                                                        int LA13_84 = input.LA(17);
                                                                        
                                                                        if ( ((LA13_84 >= '\u0000' && LA13_84 <= '\uFFFE')) )
                                                                        {
                                                                            alt13 = 15;
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt13 = 9;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        NoViableAltException nvae_d13s83 =
                                                                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 83, input);
                                                                    
                                                                        throw nvae_d13s83;
                                                                    }
                                                                }
                                                                else 
                                                                {
                                                                    NoViableAltException nvae_d13s82 =
                                                                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 82, input);
                                                                
                                                                    throw nvae_d13s82;
                                                                }
                                                            }
                                                            else 
                                                            {
                                                                NoViableAltException nvae_d13s81 =
                                                                    new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 81, input);
                                                            
                                                                throw nvae_d13s81;
                                                            }
                                                        }
                                                        else 
                                                        {
                                                            NoViableAltException nvae_d13s80 =
                                                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 80, input);
                                                        
                                                            throw nvae_d13s80;
                                                        }
                                                    }
                                                    else 
                                                    {
                                                        NoViableAltException nvae_d13s79 =
                                                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 79, input);
                                                    
                                                        throw nvae_d13s79;
                                                    }
                                                }
                                                else 
                                                {
                                                    NoViableAltException nvae_d13s78 =
                                                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 78, input);
                                                
                                                    throw nvae_d13s78;
                                                }
                                            }
                                            else 
                                            {
                                                NoViableAltException nvae_d13s77 =
                                                    new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 77, input);
                                            
                                                throw nvae_d13s77;
                                            }
                                        }
                                        else if ( (LA13_76 == 'r') )
                                        {
                                            alt13 = 16;
                                        }
                                        else 
                                        {
                                            NoViableAltException nvae_d13s76 =
                                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 76, input);
                                        
                                            throw nvae_d13s76;
                                        }
                                    }
                                    else if ( ((LA13_73 >= 'A' && LA13_73 <= 'Z') || (LA13_73 >= 'a' && LA13_73 <= 'z')) )
                                    {
                                        alt13 = 16;
                                    }
                                    else 
                                    {
                                        NoViableAltException nvae_d13s73 =
                                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 73, input);
                                    
                                        throw nvae_d13s73;
                                    }
                                }
                                else if ( (LA13_67 == ' ' || (LA13_67 >= 'A' && LA13_67 <= 'Z') || (LA13_67 >= 'a' && LA13_67 <= 'f') || (LA13_67 >= 'h' && LA13_67 <= 'z')) )
                                {
                                    alt13 = 16;
                                }
                                else 
                                {
                                    NoViableAltException nvae_d13s67 =
                                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 67, input);
                                
                                    throw nvae_d13s67;
                                }
                            }
                            else if ( (LA13_60 == ' ' || (LA13_60 >= 'A' && LA13_60 <= 'Z') || (LA13_60 >= 'a' && LA13_60 <= 'm') || (LA13_60 >= 'o' && LA13_60 <= 'z')) )
                            {
                                alt13 = 16;
                            }
                            else 
                            {
                                NoViableAltException nvae_d13s60 =
                                    new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 60, input);
                            
                                throw nvae_d13s60;
                            }
                        }
                        else if ( (LA13_51 == ' ' || (LA13_51 >= 'A' && LA13_51 <= 'Z') || (LA13_51 >= 'a' && LA13_51 <= 'h') || (LA13_51 >= 'j' && LA13_51 <= 'z')) )
                        {
                            alt13 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d13s51 =
                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 51, input);
                        
                            throw nvae_d13s51;
                        }
                    }
                    else if ( (LA13_39 == ' ' || (LA13_39 >= 'A' && LA13_39 <= 'Z') || (LA13_39 >= 'a' && LA13_39 <= 'f') || (LA13_39 >= 'h' && LA13_39 <= 'z')) )
                    {
                        alt13 = 16;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s39 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 39, input);
                    
                        throw nvae_d13s39;
                    }
                }
                else if ( (LA13_27 == ' ' || (LA13_27 >= 'A' && LA13_27 <= 'Z') || (LA13_27 >= 'a' && LA13_27 <= 'f') || (LA13_27 >= 'h' && LA13_27 <= 'z')) )
                {
                    alt13 = 16;
                }
                else 
                {
                    NoViableAltException nvae_d13s27 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 27, input);
                
                    throw nvae_d13s27;
                }
                }
                break;
            case ' ':
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
            case 'L':
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
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'e':
            case 'f':
            case 'g':
            case 'h':
            case 'i':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'p':
            case 'q':
            case 'r':
            case 's':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
            	{
                alt13 = 16;
                }
                break;
            	default:
                	alt13 = 11;
                	break;}
        
            }
            break;
        case 'p':
        	{
            switch ( input.LA(2) ) 
            {
            case 'o':
            	{
                int LA13_28 = input.LA(3);
                
                if ( (LA13_28 == 'i') )
                {
                    int LA13_40 = input.LA(4);
                    
                    if ( (LA13_40 == 'n') )
                    {
                        int LA13_52 = input.LA(5);
                        
                        if ( (LA13_52 == 't') )
                        {
                            switch ( input.LA(6) ) 
                            {
                            case 's':
                            	{
                                int LA13_68 = input.LA(7);
                                
                                if ( (LA13_68 == ' ' || (LA13_68 >= 'A' && LA13_68 <= 'Z') || (LA13_68 >= 'a' && LA13_68 <= 'z')) )
                                {
                                    alt13 = 16;
                                }
                                else 
                                {
                                    alt13 = 10;}
                                }
                                break;
                            case ' ':
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
                            case 'L':
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
                            case 'a':
                            case 'b':
                            case 'c':
                            case 'd':
                            case 'e':
                            case 'f':
                            case 'g':
                            case 'h':
                            case 'i':
                            case 'j':
                            case 'k':
                            case 'l':
                            case 'm':
                            case 'n':
                            case 'o':
                            case 'p':
                            case 'q':
                            case 'r':
                            case 't':
                            case 'u':
                            case 'v':
                            case 'w':
                            case 'x':
                            case 'y':
                            case 'z':
                            	{
                                alt13 = 16;
                                }
                                break;
                            	default:
                                	alt13 = 10;
                                	break;}
                        
                        }
                        else if ( (LA13_52 == ' ' || (LA13_52 >= 'A' && LA13_52 <= 'Z') || (LA13_52 >= 'a' && LA13_52 <= 's') || (LA13_52 >= 'u' && LA13_52 <= 'z')) )
                        {
                            alt13 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d13s52 =
                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 52, input);
                        
                            throw nvae_d13s52;
                        }
                    }
                    else if ( (LA13_40 == ' ' || (LA13_40 >= 'A' && LA13_40 <= 'Z') || (LA13_40 >= 'a' && LA13_40 <= 'm') || (LA13_40 >= 'o' && LA13_40 <= 'z')) )
                    {
                        alt13 = 16;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s40 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 40, input);
                    
                        throw nvae_d13s40;
                    }
                }
                else if ( (LA13_28 == ' ' || (LA13_28 >= 'A' && LA13_28 <= 'Z') || (LA13_28 >= 'a' && LA13_28 <= 'h') || (LA13_28 >= 'j' && LA13_28 <= 'z')) )
                {
                    alt13 = 16;
                }
                else 
                {
                    NoViableAltException nvae_d13s28 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 28, input);
                
                    throw nvae_d13s28;
                }
                }
                break;
            case ' ':
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
            case 'L':
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
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'e':
            case 'f':
            case 'g':
            case 'h':
            case 'i':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'p':
            case 'q':
            case 'r':
            case 's':
            case 't':
            case 'u':
            case 'v':
            case 'w':
            case 'x':
            case 'y':
            case 'z':
            	{
                alt13 = 16;
                }
                break;
            	default:
                	alt13 = 11;
                	break;}
        
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
        case 's':
        case 't':
        case 'u':
        case 'v':
        case 'x':
        case 'y':
        case 'z':
        	{
            int LA13_11 = input.LA(2);
            
            if ( (LA13_11 == ' ' || (LA13_11 >= 'A' && LA13_11 <= 'Z') || (LA13_11 >= 'a' && LA13_11 <= 'z')) )
            {
                alt13 = 16;
            }
            else 
            {
                alt13 = 11;}
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
            alt13 = 12;
            }
            break;
        case '\n':
        case '\r':
        	{
            alt13 = 13;
            }
            break;
        case '#':
        	{
            alt13 = 14;
            }
            break;
        	default:
        	    NoViableAltException nvae_d13s0 =
        	        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | HEAL | REFLECT | WITH | FOR | OF | FROM | LOGGING | POINTS | CHAR | DIGITS | NEWLINE | CL_COMMENT | CL_SYS_MSG | CL_REFLECT_LINE );", 13, 0, input);
        
        	    throw nvae_d13s0;
        }
        
        switch (alt13) 
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
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:28: REFLECT
                {
                	mREFLECT(); 
                
                }
                break;
            case 5 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:36: WITH
                {
                	mWITH(); 
                
                }
                break;
            case 6 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:41: FOR
                {
                	mFOR(); 
                
                }
                break;
            case 7 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:45: OF
                {
                	mOF(); 
                
                }
                break;
            case 8 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:48: FROM
                {
                	mFROM(); 
                
                }
                break;
            case 9 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:53: LOGGING
                {
                	mLOGGING(); 
                
                }
                break;
            case 10 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:61: POINTS
                {
                	mPOINTS(); 
                
                }
                break;
            case 11 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:68: CHAR
                {
                	mCHAR(); 
                
                }
                break;
            case 12 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:73: DIGITS
                {
                	mDIGITS(); 
                
                }
                break;
            case 13 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:80: NEWLINE
                {
                	mNEWLINE(); 
                
                }
                break;
            case 14 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:88: CL_COMMENT
                {
                	mCL_COMMENT(); 
                
                }
                break;
            case 15 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:99: CL_SYS_MSG
                {
                	mCL_SYS_MSG(); 
                
                }
                break;
            case 16 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:110: CL_REFLECT_LINE
                {
                	mCL_REFLECT_LINE(); 
                
                }
                break;
        
        }
    
    }


	private void InitializeCyclicDFAs()
	{
	}

 
    
}
