// $ANTLR 3.0.1 C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g 2008-03-30 01:20:33

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public class CombatSpamLexer : Lexer 
{
    public const int WOUNDS = 6;
    public const int NEWLINE = 15;
    public const int POINTS = 14;
    public const int WOUND = 5;
    public const int DAMAGE = 4;
    public const int DIGITS = 13;
    public const int CHARS = 12;
    public const int FOR = 9;
    public const int ARE_WOUNDED = 7;
    public const int FROM = 11;
    public const int Tokens = 16;
    public const int OF = 10;
    public const int EOF = -1;
    public const int WITH = 8;

    public CombatSpamLexer() 
    {
		InitializeCyclicDFAs();
    }
    public CombatSpamLexer(ICharStream input) 
		: base(input)
	{
		InitializeCyclicDFAs();
    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g";} 
    }

    // $ANTLR start DAMAGE 
    public void mDAMAGE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DAMAGE;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:7:8: ( 'damage' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:7:10: 'damage'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:8:7: ( 'wound' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:8:9: 'wound'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:9:8: ( 'wounds' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:9:10: 'wounds'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:10:13: ( 'are wounded' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:10:15: 'are wounded'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:11:6: ( 'with' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:11:8: 'with'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:12:5: ( 'for' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:12:7: 'for'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:13:4: ( 'of' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:13:6: 'of'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:14:6: ( 'from' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:14:8: 'from'
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

    // $ANTLR start CHARS 
    public void mCHARS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = CHARS;
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:21:7: ( ( 'a' .. 'z' | 'A' .. 'Z' ) )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:21:9: ( 'a' .. 'z' | 'A' .. 'Z' )
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:22:8: ( '0' .. '9' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:22:10: '0' .. '9'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:23:8: ( 'point' | 'points' )
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
                                    new NoViableAltException("23:1: POINTS : ( 'point' | 'points' );", 1, 4, input);
                            
                                throw nvae_d1s4;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d1s3 =
                                new NoViableAltException("23:1: POINTS : ( 'point' | 'points' );", 1, 3, input);
                        
                            throw nvae_d1s3;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d1s2 =
                            new NoViableAltException("23:1: POINTS : ( 'point' | 'points' );", 1, 2, input);
                    
                        throw nvae_d1s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d1s1 =
                        new NoViableAltException("23:1: POINTS : ( 'point' | 'points' );", 1, 1, input);
                
                    throw nvae_d1s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("23:1: POINTS : ( 'point' | 'points' );", 1, 0, input);
            
                throw nvae_d1s0;
            }
            switch (alt1) 
            {
                case 1 :
                    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:23:10: 'point'
                    {
                    	Match("point"); 

                    
                    }
                    break;
                case 2 :
                    // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:23:20: 'points'
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
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:24:9: ( ( '\\r' )? '\\n' )
            // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:24:11: ( '\\r' )? '\\n'
            {
            	// C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:24:11: ( '\\r' )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);
            	
            	if ( (LA2_0 == '\r') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:24:11: '\\r'
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

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:8: ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | CHARS | DIGITS | POINTS | NEWLINE )
        int alt3 = 12;
        switch ( input.LA(1) ) 
        {
        case 'd':
        	{
            int LA3_1 = input.LA(2);
            
            if ( (LA3_1 == 'a') )
            {
                alt3 = 1;
            }
            else 
            {
                alt3 = 9;}
            }
            break;
        case 'w':
        	{
            switch ( input.LA(2) ) 
            {
            case 'o':
            	{
                int LA3_11 = input.LA(3);
                
                if ( (LA3_11 == 'u') )
                {
                    int LA3_18 = input.LA(4);
                    
                    if ( (LA3_18 == 'n') )
                    {
                        int LA3_19 = input.LA(5);
                        
                        if ( (LA3_19 == 'd') )
                        {
                            int LA3_20 = input.LA(6);
                            
                            if ( (LA3_20 == 's') )
                            {
                                alt3 = 3;
                            }
                            else 
                            {
                                alt3 = 2;}
                        }
                        else 
                        {
                            NoViableAltException nvae_d3s19 =
                                new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | CHARS | DIGITS | POINTS | NEWLINE );", 3, 19, input);
                        
                            throw nvae_d3s19;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d3s18 =
                            new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | CHARS | DIGITS | POINTS | NEWLINE );", 3, 18, input);
                    
                        throw nvae_d3s18;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d3s11 =
                        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | CHARS | DIGITS | POINTS | NEWLINE );", 3, 11, input);
                
                    throw nvae_d3s11;
                }
                }
                break;
            case 'i':
            	{
                alt3 = 5;
                }
                break;
            	default:
                	alt3 = 9;
                	break;}
        
            }
            break;
        case 'a':
        	{
            int LA3_3 = input.LA(2);
            
            if ( (LA3_3 == 'r') )
            {
                alt3 = 4;
            }
            else 
            {
                alt3 = 9;}
            }
            break;
        case 'f':
        	{
            switch ( input.LA(2) ) 
            {
            case 'o':
            	{
                alt3 = 6;
                }
                break;
            case 'r':
            	{
                alt3 = 8;
                }
                break;
            	default:
                	alt3 = 9;
                	break;}
        
            }
            break;
        case 'o':
        	{
            int LA3_5 = input.LA(2);
            
            if ( (LA3_5 == 'f') )
            {
                alt3 = 7;
            }
            else 
            {
                alt3 = 9;}
            }
            break;
        case 'p':
        	{
            int LA3_6 = input.LA(2);
            
            if ( (LA3_6 == 'o') )
            {
                alt3 = 11;
            }
            else 
            {
                alt3 = 9;}
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
            alt3 = 10;
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
            alt3 = 9;
            }
            break;
        case '\n':
        case '\r':
        	{
            alt3 = 12;
            }
            break;
        	default:
        	    NoViableAltException nvae_d3s0 =
        	        new NoViableAltException("1:1: Tokens : ( DAMAGE | WOUND | WOUNDS | ARE_WOUNDED | WITH | FOR | OF | FROM | CHARS | DIGITS | POINTS | NEWLINE );", 3, 0, input);
        
        	    throw nvae_d3s0;
        }
        
        switch (alt3) 
        {
            case 1 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:10: DAMAGE
                {
                	mDAMAGE(); 
                
                }
                break;
            case 2 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:17: WOUND
                {
                	mWOUND(); 
                
                }
                break;
            case 3 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:23: WOUNDS
                {
                	mWOUNDS(); 
                
                }
                break;
            case 4 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:30: ARE_WOUNDED
                {
                	mARE_WOUNDED(); 
                
                }
                break;
            case 5 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:42: WITH
                {
                	mWITH(); 
                
                }
                break;
            case 6 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:47: FOR
                {
                	mFOR(); 
                
                }
                break;
            case 7 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:51: OF
                {
                	mOF(); 
                
                }
                break;
            case 8 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:54: FROM
                {
                	mFROM(); 
                
                }
                break;
            case 9 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:59: CHARS
                {
                	mCHARS(); 
                
                }
                break;
            case 10 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:65: DIGITS
                {
                	mDIGITS(); 
                
                }
                break;
            case 11 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:72: POINTS
                {
                	mPOINTS(); 
                
                }
                break;
            case 12 :
                // C:\\Users\\Brandon\\Documents\\Visual Studio 2005\\Projects\\CombatAnalyzer\\CombatAnalyzer\\grammar\\CombatSpam.g:1:79: NEWLINE
                {
                	mNEWLINE(); 
                
                }
                break;
        
        }
    
    }


	private void InitializeCyclicDFAs()
	{
	}

 
    
}
