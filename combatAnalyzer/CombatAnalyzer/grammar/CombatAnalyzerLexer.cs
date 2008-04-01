// $ANTLR 3.0.1 C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g 2008-03-31 23:10:07

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public class CombatAnalyzerLexer : Lexer 
{
    public const int WOUND = 5;
    public const int POINTS = 15;
    public const int DIGITS = 14;
    public const int DAMAGE = 4;
    public const int FOR = 9;
    public const int ARE_WOUNDED = 7;
    public const int LOGGING = 12;
    public const int EOF = -1;
    public const int OF = 10;
    public const int Tokens = 19;
    public const int WOUNDS = 6;
    public const int NEWLINE = 16;
    public const int CS_LOG_MSG_SYS = 18;
    public const int CHARS = 13;
    public const int CS_COMMENT = 17;
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:7:8: ( 'damage' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:7:10: 'damage'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:8:7: ( 'wound' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:8:9: 'wound'
            {
            	Match("wound"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end WOUND

    // $ANTLR start WOUNDS 
    public void mWOUNDS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = WOUNDS;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:9:8: ( 'wounds' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:9:10: 'wounds'
            {
            	Match("wounds"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end WOUNDS

    // $ANTLR start ARE_WOUNDED 
    public void mARE_WOUNDED() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ARE_WOUNDED;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:10:13: ( 'are wounded' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:10:15: 'are wounded'
            {
            	Match("are wounded"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ARE_WOUNDED

    // $ANTLR start WITH 
    public void mWITH() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = WITH;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:6: ( 'with' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:11:8: 'with'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:12:5: ( 'for' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:12:7: 'for'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:13:4: ( 'of' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:13:6: 'of'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:14:6: ( 'from' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:14:8: 'from'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:15:9: ( 'Logging chat tab' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:15:11: 'Logging chat tab'
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

    // $ANTLR start CHARS 
    public void mCHARS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = CHARS;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:26:7: ( ( 'a' .. 'z' | 'A' .. 'Z' ) )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:26:9: ( 'a' .. 'z' | 'A' .. 'Z' )
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
    // $ANTLR end CHARS

    // $ANTLR start DIGITS 
    public void mDIGITS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DIGITS;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:27:8: ( '0' .. '9' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:27:10: '0' .. '9'
            {
            	MatchRange('0','9'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DIGITS

    // $ANTLR start POINTS 
    public void mPOINTS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = POINTS;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:28:8: ( 'point' | 'points' )
            int alt1 = 2;
            int LA1_0 = input.LA(1);
            
            if ( (LA1_0 == 'p') )
            {
                int LA1_1 = input.LA(2);
                
                if ( (LA1_1 == 'o') )
                {
                    int LA1_2 = input.LA(3);
                    
                    if ( (LA1_2 == 'i') )
                    {
                        int LA1_3 = input.LA(4);
                        
                        if ( (LA1_3 == 'n') )
                        {
                            int LA1_4 = input.LA(5);
                            
                            if ( (LA1_4 == 't') )
                            {
                                int LA1_5 = input.LA(6);
                                
                                if ( (LA1_5 == 's') )
                                {
                                    alt1 = 2;
                                }
                                else 
                                {
                                    alt1 = 1;}
                            }
                            else 
                            {
                                NoViableAltException nvae_d1s4 =
                                    new NoViableAltException("28:1: POINTS : ( 'point' | 'points' );", 1, 4, input);
                            
                                throw nvae_d1s4;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d1s3 =
                                new NoViableAltException("28:1: POINTS : ( 'point' | 'points' );", 1, 3, input);
                        
                            throw nvae_d1s3;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d1s2 =
                            new NoViableAltException("28:1: POINTS : ( 'point' | 'points' );", 1, 2, input);
                    
                        throw nvae_d1s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d1s1 =
                        new NoViableAltException("28:1: POINTS : ( 'point' | 'points' );", 1, 1, input);
                
                    throw nvae_d1s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("28:1: POINTS : ( 'point' | 'points' );", 1, 0, input);
            
                throw nvae_d1s0;
            }
            switch (alt1) 
            {
                case 1 :
                    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:28:10: 'point'
                    {
                    	Match("point"); 

                    
                    }
                    break;
                case 2 :
                    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:28:20: 'points'
                    {
                    	Match("points"); 

                    
                    }
                    break;
            
            }
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end POINTS

    // $ANTLR start NEWLINE 
    public void mNEWLINE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NEWLINE;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:29:9: ( ( '\\r' )? '\\n' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:29:11: ( '\\r' )? '\\n'
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:29:11: ( '\\r' )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);
            	
            	if ( (LA2_0 == '\r') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:29:11: '\\r'
            	        {
            	        	Match('\r'); 
            	        
            	        }
            	        break;
            	
            	}

            	Match('\n'); 
            
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:32:12: ( '###' ( options {greedy=false; } : . )* '###' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:32:14: '###' ( options {greedy=false; } : . )* '###'
            {
            	Match("###"); 

            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:32:20: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);
            	    
            	    if ( (LA3_0 == '#') )
            	    {
            	        int LA3_1 = input.LA(2);
            	        
            	        if ( (LA3_1 == '#') )
            	        {
            	            int LA3_3 = input.LA(3);
            	            
            	            if ( (LA3_3 == '#') )
            	            {
            	                alt3 = 2;
            	            }
            	            else if ( ((LA3_3 >= '\u0000' && LA3_3 <= '\"') || (LA3_3 >= '$' && LA3_3 <= '\uFFFE')) )
            	            {
            	                alt3 = 1;
            	            }
            	            
            	        
            	        }
            	        else if ( ((LA3_1 >= '\u0000' && LA3_1 <= '\"') || (LA3_1 >= '$' && LA3_1 <= '\uFFFE')) )
            	        {
            	            alt3 = 1;
            	        }
            	        
            	    
            	    }
            	    else if ( ((LA3_0 >= '\u0000' && LA3_0 <= '\"') || (LA3_0 >= '$' && LA3_0 <= '\uFFFE')) )
            	    {
            	        alt3 = 1;
            	    }
            	    
            	
            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:32:47: .
            			    {
            			    	MatchAny(); 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop3;
            	    }
            	} while (true);
            	
            	loop3:
            		;	// Stops C# compiler whinging that label 'loop3' has no statements

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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:33:16: ( LOGGING ( options {greedy=false; } : . )* NEWLINE )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:33:18: LOGGING ( options {greedy=false; } : . )* NEWLINE
            {
            	mLOGGING(); 
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:33:26: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);
            	    
            	    if ( (LA4_0 == '\r') )
            	    {
            	        alt4 = 2;
            	    }
            	    else if ( (LA4_0 == '\n') )
            	    {
            	        alt4 = 2;
            	    }
            	    else if ( ((LA4_0 >= '\u0000' && LA4_0 <= '\t') || (LA4_0 >= '\u000B' && LA4_0 <= '\f') || (LA4_0 >= '\u000E' && LA4_0 <= '\uFFFE')) )
            	    {
            	        alt4 = 1;
            	    }
            	    
            	
            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:33:53: .
            			    {
            			    	MatchAny(); 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop4;
            	    }
            	} while (true);
            	
            	loop4:
            		;	// Stops C# compiler whinging that label 'loop4' has no statements

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
        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:8: ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS )
        int alt5 = 15;
        switch ( input.LA(1) ) 
        {
        case 'd':
        	{
            int LA5_1 = input.LA(2);
            
            if ( (LA5_1 == 'a') )
            {
                alt5 = 1;
            }
            else 
            {
                alt5 = 10;}
            }
            break;
        case 'w':
        	{
            switch ( input.LA(2) ) 
            {
            case 'o':
            	{
                int LA5_13 = input.LA(3);
                
                if ( (LA5_13 == 'u') )
                {
                    int LA5_21 = input.LA(4);
                    
                    if ( (LA5_21 == 'n') )
                    {
                        int LA5_23 = input.LA(5);
                        
                        if ( (LA5_23 == 'd') )
                        {
                            int LA5_25 = input.LA(6);
                            
                            if ( (LA5_25 == 's') )
                            {
                                alt5 = 3;
                            }
                            else 
                            {
                                alt5 = 2;}
                        }
                        else 
                        {
                            NoViableAltException nvae_d5s23 =
                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 23, input);
                        
                            throw nvae_d5s23;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d5s21 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 21, input);
                    
                        throw nvae_d5s21;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d5s13 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 13, input);
                
                    throw nvae_d5s13;
                }
                }
                break;
            case 'i':
            	{
                alt5 = 5;
                }
                break;
            	default:
                	alt5 = 10;
                	break;}
        
            }
            break;
        case 'a':
        	{
            int LA5_3 = input.LA(2);
            
            if ( (LA5_3 == 'r') )
            {
                alt5 = 4;
            }
            else 
            {
                alt5 = 10;}
            }
            break;
        case 'f':
        	{
            switch ( input.LA(2) ) 
            {
            case 'r':
            	{
                alt5 = 8;
                }
                break;
            case 'o':
            	{
                alt5 = 6;
                }
                break;
            	default:
                	alt5 = 10;
                	break;}
        
            }
            break;
        case 'o':
        	{
            int LA5_5 = input.LA(2);
            
            if ( (LA5_5 == 'f') )
            {
                alt5 = 7;
            }
            else 
            {
                alt5 = 10;}
            }
            break;
        case 'L':
        	{
            int LA5_6 = input.LA(2);
            
            if ( (LA5_6 == 'o') )
            {
                int LA5_19 = input.LA(3);
                
                if ( (LA5_19 == 'g') )
                {
                    int LA5_22 = input.LA(4);
                    
                    if ( (LA5_22 == 'g') )
                    {
                        int LA5_24 = input.LA(5);
                        
                        if ( (LA5_24 == 'i') )
                        {
                            int LA5_26 = input.LA(6);
                            
                            if ( (LA5_26 == 'n') )
                            {
                                int LA5_29 = input.LA(7);
                                
                                if ( (LA5_29 == 'g') )
                                {
                                    int LA5_30 = input.LA(8);
                                    
                                    if ( (LA5_30 == ' ') )
                                    {
                                        int LA5_31 = input.LA(9);
                                        
                                        if ( (LA5_31 == 'c') )
                                        {
                                            int LA5_32 = input.LA(10);
                                            
                                            if ( (LA5_32 == 'h') )
                                            {
                                                int LA5_33 = input.LA(11);
                                                
                                                if ( (LA5_33 == 'a') )
                                                {
                                                    int LA5_34 = input.LA(12);
                                                    
                                                    if ( (LA5_34 == 't') )
                                                    {
                                                        int LA5_35 = input.LA(13);
                                                        
                                                        if ( (LA5_35 == ' ') )
                                                        {
                                                            int LA5_36 = input.LA(14);
                                                            
                                                            if ( (LA5_36 == 't') )
                                                            {
                                                                int LA5_37 = input.LA(15);
                                                                
                                                                if ( (LA5_37 == 'a') )
                                                                {
                                                                    int LA5_38 = input.LA(16);
                                                                    
                                                                    if ( (LA5_38 == 'b') )
                                                                    {
                                                                        int LA5_39 = input.LA(17);
                                                                        
                                                                        if ( ((LA5_39 >= '\u0000' && LA5_39 <= '\uFFFE')) )
                                                                        {
                                                                            alt5 = 15;
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt5 = 9;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        NoViableAltException nvae_d5s38 =
                                                                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 38, input);
                                                                    
                                                                        throw nvae_d5s38;
                                                                    }
                                                                }
                                                                else 
                                                                {
                                                                    NoViableAltException nvae_d5s37 =
                                                                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 37, input);
                                                                
                                                                    throw nvae_d5s37;
                                                                }
                                                            }
                                                            else 
                                                            {
                                                                NoViableAltException nvae_d5s36 =
                                                                    new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 36, input);
                                                            
                                                                throw nvae_d5s36;
                                                            }
                                                        }
                                                        else 
                                                        {
                                                            NoViableAltException nvae_d5s35 =
                                                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 35, input);
                                                        
                                                            throw nvae_d5s35;
                                                        }
                                                    }
                                                    else 
                                                    {
                                                        NoViableAltException nvae_d5s34 =
                                                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 34, input);
                                                    
                                                        throw nvae_d5s34;
                                                    }
                                                }
                                                else 
                                                {
                                                    NoViableAltException nvae_d5s33 =
                                                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 33, input);
                                                
                                                    throw nvae_d5s33;
                                                }
                                            }
                                            else 
                                            {
                                                NoViableAltException nvae_d5s32 =
                                                    new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 32, input);
                                            
                                                throw nvae_d5s32;
                                            }
                                        }
                                        else 
                                        {
                                            NoViableAltException nvae_d5s31 =
                                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 31, input);
                                        
                                            throw nvae_d5s31;
                                        }
                                    }
                                    else 
                                    {
                                        NoViableAltException nvae_d5s30 =
                                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 30, input);
                                    
                                        throw nvae_d5s30;
                                    }
                                }
                                else 
                                {
                                    NoViableAltException nvae_d5s29 =
                                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 29, input);
                                
                                    throw nvae_d5s29;
                                }
                            }
                            else 
                            {
                                NoViableAltException nvae_d5s26 =
                                    new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 26, input);
                            
                                throw nvae_d5s26;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d5s24 =
                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 24, input);
                        
                            throw nvae_d5s24;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d5s22 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 22, input);
                    
                        throw nvae_d5s22;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d5s19 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 19, input);
                
                    throw nvae_d5s19;
                }
            }
            else 
            {
                alt5 = 10;}
            }
            break;
        case 'p':
        	{
            int LA5_7 = input.LA(2);
            
            if ( (LA5_7 == 'o') )
            {
                alt5 = 12;
            }
            else 
            {
                alt5 = 10;}
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
            alt5 = 11;
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
        case 'h':
        case 'i':
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
            alt5 = 10;
            }
            break;
        case '\n':
        case '\r':
        	{
            alt5 = 13;
            }
            break;
        case '#':
        	{
            alt5 = 14;
            }
            break;
        	default:
        	    NoViableAltException nvae_d5s0 =
        	        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | LOGGING | CHARS | DIGITS | POINTS | NEWLINE | CS_COMMENT | CS_LOG_MSG_SYS );", 5, 0, input);
        
        	    throw nvae_d5s0;
        }
        
        switch (alt5) 
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
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:23: WOUNDS
                {
                	mWOUNDS(); 
                
                }
                break;
            case 4 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:30: ARE_WOUNDED
                {
                	mARE_WOUNDED(); 
                
                }
                break;
            case 5 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:42: WITH
                {
                	mWITH(); 
                
                }
                break;
            case 6 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:47: FOR
                {
                	mFOR(); 
                
                }
                break;
            case 7 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:51: OF
                {
                	mOF(); 
                
                }
                break;
            case 8 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:54: FROM
                {
                	mFROM(); 
                
                }
                break;
            case 9 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:59: LOGGING
                {
                	mLOGGING(); 
                
                }
                break;
            case 10 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:67: CHARS
                {
                	mCHARS(); 
                
                }
                break;
            case 11 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:73: DIGITS
                {
                	mDIGITS(); 
                
                }
                break;
            case 12 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:80: POINTS
                {
                	mPOINTS(); 
                
                }
                break;
            case 13 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:87: NEWLINE
                {
                	mNEWLINE(); 
                
                }
                break;
            case 14 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:95: CS_COMMENT
                {
                	mCS_COMMENT(); 
                
                }
                break;
            case 15 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatAnalyzer.g:1:106: CS_LOG_MSG_SYS
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
