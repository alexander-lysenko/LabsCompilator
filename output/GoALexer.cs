//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.5.1 C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g 2017-03-24 14:33:42

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

namespace  Generated 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.5.1")]
[System.CLSCompliant(false)]
public partial class GoALexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__6=6;
	public const int T__7=7;
	public const int T__8=8;
	public const int T__9=9;
	public const int T__10=10;
	public const int T__11=11;
	public const int T__12=12;
	public const int T__13=13;
	public const int EXPONENT=4;
	public const int FLOAT=5;

	// delegates
	// delegators

	public GoALexer()
	{
		OnCreated();
	}

	public GoALexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public GoALexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_T__6();
	partial void LeaveRule_T__6();

	// $ANTLR start "T__6"
	[GrammarRule("T__6")]
	private void mT__6()
	{
		EnterRule_T__6();
		EnterRule("T__6", 1);
		TraceIn("T__6", 1);
		try
		{
			int _type = T__6;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:9:6: ( '(' )
			DebugEnterAlt(1);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:9:8: '('
			{
			DebugLocation(9, 8);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__6", 1);
			LeaveRule("T__6", 1);
			LeaveRule_T__6();
		}
	}
	// $ANTLR end "T__6"

	partial void EnterRule_T__7();
	partial void LeaveRule_T__7();

	// $ANTLR start "T__7"
	[GrammarRule("T__7")]
	private void mT__7()
	{
		EnterRule_T__7();
		EnterRule("T__7", 2);
		TraceIn("T__7", 2);
		try
		{
			int _type = T__7;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:10:6: ( ')' )
			DebugEnterAlt(1);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:10:8: ')'
			{
			DebugLocation(10, 8);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__7", 2);
			LeaveRule("T__7", 2);
			LeaveRule_T__7();
		}
	}
	// $ANTLR end "T__7"

	partial void EnterRule_T__8();
	partial void LeaveRule_T__8();

	// $ANTLR start "T__8"
	[GrammarRule("T__8")]
	private void mT__8()
	{
		EnterRule_T__8();
		EnterRule("T__8", 3);
		TraceIn("T__8", 3);
		try
		{
			int _type = T__8;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:11:6: ( '*' )
			DebugEnterAlt(1);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:11:8: '*'
			{
			DebugLocation(11, 8);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__8", 3);
			LeaveRule("T__8", 3);
			LeaveRule_T__8();
		}
	}
	// $ANTLR end "T__8"

	partial void EnterRule_T__9();
	partial void LeaveRule_T__9();

	// $ANTLR start "T__9"
	[GrammarRule("T__9")]
	private void mT__9()
	{
		EnterRule_T__9();
		EnterRule("T__9", 4);
		TraceIn("T__9", 4);
		try
		{
			int _type = T__9;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:12:6: ( '+' )
			DebugEnterAlt(1);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:12:8: '+'
			{
			DebugLocation(12, 8);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__9", 4);
			LeaveRule("T__9", 4);
			LeaveRule_T__9();
		}
	}
	// $ANTLR end "T__9"

	partial void EnterRule_T__10();
	partial void LeaveRule_T__10();

	// $ANTLR start "T__10"
	[GrammarRule("T__10")]
	private void mT__10()
	{
		EnterRule_T__10();
		EnterRule("T__10", 5);
		TraceIn("T__10", 5);
		try
		{
			int _type = T__10;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:13:7: ( '-' )
			DebugEnterAlt(1);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:13:9: '-'
			{
			DebugLocation(13, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__10", 5);
			LeaveRule("T__10", 5);
			LeaveRule_T__10();
		}
	}
	// $ANTLR end "T__10"

	partial void EnterRule_T__11();
	partial void LeaveRule_T__11();

	// $ANTLR start "T__11"
	[GrammarRule("T__11")]
	private void mT__11()
	{
		EnterRule_T__11();
		EnterRule("T__11", 6);
		TraceIn("T__11", 6);
		try
		{
			int _type = T__11;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:14:7: ( '/' )
			DebugEnterAlt(1);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:14:9: '/'
			{
			DebugLocation(14, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__11", 6);
			LeaveRule("T__11", 6);
			LeaveRule_T__11();
		}
	}
	// $ANTLR end "T__11"

	partial void EnterRule_T__12();
	partial void LeaveRule_T__12();

	// $ANTLR start "T__12"
	[GrammarRule("T__12")]
	private void mT__12()
	{
		EnterRule_T__12();
		EnterRule("T__12", 7);
		TraceIn("T__12", 7);
		try
		{
			int _type = T__12;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:15:7: ( '^' )
			DebugEnterAlt(1);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:15:9: '^'
			{
			DebugLocation(15, 9);
			Match('^'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__12", 7);
			LeaveRule("T__12", 7);
			LeaveRule_T__12();
		}
	}
	// $ANTLR end "T__12"

	partial void EnterRule_T__13();
	partial void LeaveRule_T__13();

	// $ANTLR start "T__13"
	[GrammarRule("T__13")]
	private void mT__13()
	{
		EnterRule_T__13();
		EnterRule("T__13", 8);
		TraceIn("T__13", 8);
		try
		{
			int _type = T__13;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:16:7: ( 'sqrt(' )
			DebugEnterAlt(1);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:16:9: 'sqrt('
			{
			DebugLocation(16, 9);
			Match("sqrt("); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__13", 8);
			LeaveRule("T__13", 8);
			LeaveRule_T__13();
		}
	}
	// $ANTLR end "T__13"

	partial void EnterRule_FLOAT();
	partial void LeaveRule_FLOAT();

	// $ANTLR start "FLOAT"
	[GrammarRule("FLOAT")]
	private void mFLOAT()
	{
		EnterRule_FLOAT();
		EnterRule("FLOAT", 9);
		TraceIn("FLOAT", 9);
		try
		{
			int _type = FLOAT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:49:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT )
			int alt7=3;
			try { DebugEnterDecision(7, false);
			try
			{
				alt7 = dfa7.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:49:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )?
				{
				DebugLocation(49, 9);
				// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:49:9: ( '0' .. '9' )+
				int cnt1=0;
				try { DebugEnterSubRule(1);
				while (true)
				{
					int alt1=2;
					try { DebugEnterDecision(1, false);
					int LA1_1 = input.LA(1);

					if (((LA1_1>='0' && LA1_1<='9')))
					{
						alt1 = 1;
					}


					} finally { DebugExitDecision(1); }
					switch (alt1)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:
						{
						DebugLocation(49, 9);
						input.Consume();


						}
						break;

					default:
						if (cnt1 >= 1)
							goto loop1;

						EarlyExitException eee1 = new EarlyExitException( 1, input );
						DebugRecognitionException(eee1);
						throw eee1;
					}
					cnt1++;
				}
				loop1:
					;

				} finally { DebugExitSubRule(1); }

				DebugLocation(49, 21);
				Match('.'); 
				DebugLocation(49, 25);
				// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:49:25: ( '0' .. '9' )*
				try { DebugEnterSubRule(2);
				while (true)
				{
					int alt2=2;
					try { DebugEnterDecision(2, false);
					int LA2_1 = input.LA(1);

					if (((LA2_1>='0' && LA2_1<='9')))
					{
						alt2 = 1;
					}


					} finally { DebugExitDecision(2); }
					switch ( alt2 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:
						{
						DebugLocation(49, 25);
						input.Consume();


						}
						break;

					default:
						goto loop2;
					}
				}

				loop2:
					;

				} finally { DebugExitSubRule(2); }

				DebugLocation(49, 37);
				// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:49:37: ( EXPONENT )?
				int alt3=2;
				try { DebugEnterSubRule(3);
				try { DebugEnterDecision(3, false);
				int LA3_1 = input.LA(1);

				if ((LA3_1=='E'||LA3_1=='e'))
				{
					alt3 = 1;
				}
				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:49:37: EXPONENT
					{
					DebugLocation(49, 37);
					mEXPONENT(); 

					}
					break;

				}
				} finally { DebugExitSubRule(3); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:50:9: '.' ( '0' .. '9' )+ ( EXPONENT )?
				{
				DebugLocation(50, 9);
				Match('.'); 
				DebugLocation(50, 13);
				// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:50:13: ( '0' .. '9' )+
				int cnt4=0;
				try { DebugEnterSubRule(4);
				while (true)
				{
					int alt4=2;
					try { DebugEnterDecision(4, false);
					int LA4_1 = input.LA(1);

					if (((LA4_1>='0' && LA4_1<='9')))
					{
						alt4 = 1;
					}


					} finally { DebugExitDecision(4); }
					switch (alt4)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:
						{
						DebugLocation(50, 13);
						input.Consume();


						}
						break;

					default:
						if (cnt4 >= 1)
							goto loop4;

						EarlyExitException eee4 = new EarlyExitException( 4, input );
						DebugRecognitionException(eee4);
						throw eee4;
					}
					cnt4++;
				}
				loop4:
					;

				} finally { DebugExitSubRule(4); }

				DebugLocation(50, 25);
				// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:50:25: ( EXPONENT )?
				int alt5=2;
				try { DebugEnterSubRule(5);
				try { DebugEnterDecision(5, false);
				int LA5_1 = input.LA(1);

				if ((LA5_1=='E'||LA5_1=='e'))
				{
					alt5 = 1;
				}
				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:50:25: EXPONENT
					{
					DebugLocation(50, 25);
					mEXPONENT(); 

					}
					break;

				}
				} finally { DebugExitSubRule(5); }


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:51:9: ( '0' .. '9' )+ EXPONENT
				{
				DebugLocation(51, 9);
				// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:51:9: ( '0' .. '9' )+
				int cnt6=0;
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, false);
					int LA6_1 = input.LA(1);

					if (((LA6_1>='0' && LA6_1<='9')))
					{
						alt6 = 1;
					}


					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:
						{
						DebugLocation(51, 9);
						input.Consume();


						}
						break;

					default:
						if (cnt6 >= 1)
							goto loop6;

						EarlyExitException eee6 = new EarlyExitException( 6, input );
						DebugRecognitionException(eee6);
						throw eee6;
					}
					cnt6++;
				}
				loop6:
					;

				} finally { DebugExitSubRule(6); }

				DebugLocation(51, 21);
				mEXPONENT(); 

				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FLOAT", 9);
			LeaveRule("FLOAT", 9);
			LeaveRule_FLOAT();
		}
	}
	// $ANTLR end "FLOAT"

	partial void EnterRule_EXPONENT();
	partial void LeaveRule_EXPONENT();

	// $ANTLR start "EXPONENT"
	[GrammarRule("EXPONENT")]
	private void mEXPONENT()
	{
		EnterRule_EXPONENT();
		EnterRule("EXPONENT", 10);
		TraceIn("EXPONENT", 10);
		try
		{
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:56:10: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:56:12: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
			{
			DebugLocation(56, 12);
			if (input.LA(1)=='E'||input.LA(1)=='e')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}

			DebugLocation(56, 22);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:56:22: ( '+' | '-' )?
			int alt8=2;
			try { DebugEnterSubRule(8);
			try { DebugEnterDecision(8, false);
			int LA8_1 = input.LA(1);

			if ((LA8_1=='+'||LA8_1=='-'))
			{
				alt8 = 1;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:
				{
				DebugLocation(56, 22);
				input.Consume();


				}
				break;

			}
			} finally { DebugExitSubRule(8); }

			DebugLocation(56, 33);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:56:33: ( '0' .. '9' )+
			int cnt9=0;
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, false);
				int LA9_1 = input.LA(1);

				if (((LA9_1>='0' && LA9_1<='9')))
				{
					alt9 = 1;
				}


				} finally { DebugExitDecision(9); }
				switch (alt9)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:
					{
					DebugLocation(56, 33);
					input.Consume();


					}
					break;

				default:
					if (cnt9 >= 1)
						goto loop9;

					EarlyExitException eee9 = new EarlyExitException( 9, input );
					DebugRecognitionException(eee9);
					throw eee9;
				}
				cnt9++;
			}
			loop9:
				;

			} finally { DebugExitSubRule(9); }


			}

		}
		finally
		{
			TraceOut("EXPONENT", 10);
			LeaveRule("EXPONENT", 10);
			LeaveRule_EXPONENT();
		}
	}
	// $ANTLR end "EXPONENT"

	public override void mTokens()
	{
		// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:1:8: ( T__6 | T__7 | T__8 | T__9 | T__10 | T__11 | T__12 | T__13 | FLOAT )
		int alt10=9;
		try { DebugEnterDecision(10, false);
		switch (input.LA(1))
		{
		case '(':
			{
			alt10 = 1;
			}
			break;
		case ')':
			{
			alt10 = 2;
			}
			break;
		case '*':
			{
			alt10 = 3;
			}
			break;
		case '+':
			{
			alt10 = 4;
			}
			break;
		case '-':
			{
			alt10 = 5;
			}
			break;
		case '/':
			{
			alt10 = 6;
			}
			break;
		case '^':
			{
			alt10 = 7;
			}
			break;
		case 's':
			{
			alt10 = 8;
			}
			break;
		case '.':
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
			alt10 = 9;
			}
			break;
		default:
			{
				NoViableAltException nvae = new NoViableAltException("", 10, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
		}

		} finally { DebugExitDecision(10); }
		switch (alt10)
		{
		case 1:
			DebugEnterAlt(1);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:1:10: T__6
			{
			DebugLocation(1, 10);
			mT__6(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:1:15: T__7
			{
			DebugLocation(1, 15);
			mT__7(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:1:20: T__8
			{
			DebugLocation(1, 20);
			mT__8(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:1:25: T__9
			{
			DebugLocation(1, 25);
			mT__9(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:1:30: T__10
			{
			DebugLocation(1, 30);
			mT__10(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:1:36: T__11
			{
			DebugLocation(1, 36);
			mT__11(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:1:42: T__12
			{
			DebugLocation(1, 42);
			mT__12(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:1:48: T__13
			{
			DebugLocation(1, 48);
			mT__13(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// C:\\Users\\illus\\OneDrive\\?????????\\Visual Studio 2015\\Projects\\Compilators\\GoA.g:1:54: FLOAT
			{
			DebugLocation(1, 54);
			mFLOAT(); 

			}
			break;

		}

	}


	#region DFA
	DFA7 dfa7;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa7 = new DFA7(this);
	}

	private class DFA7 : DFA
	{
		private const string DFA7_eotS =
			"\x5\xFFFF";
		private const string DFA7_eofS =
			"\x5\xFFFF";
		private const string DFA7_minS =
			"\x2\x2E\x3\xFFFF";
		private const string DFA7_maxS =
			"\x1\x39\x1\x65\x3\xFFFF";
		private const string DFA7_acceptS =
			"\x2\xFFFF\x1\x2\x1\x1\x1\x3";
		private const string DFA7_specialS =
			"\x5\xFFFF}>";
		private static readonly string[] DFA7_transitionS =
			{
				"\x1\x2\x1\xFFFF\xA\x1",
				"\x1\x3\x1\xFFFF\xA\x1\xB\xFFFF\x1\x4\x1F\xFFFF\x1\x4",
				"",
				"",
				""
			};

		private static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
		private static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
		private static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
		private static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
		private static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
		private static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
		private static readonly short[][] DFA7_transition;

		static DFA7()
		{
			int numStates = DFA7_transitionS.Length;
			DFA7_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA7_transition[i] = DFA.UnpackEncodedString(DFA7_transitionS[i]);
			}
		}

		public DFA7( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 7;
			this.eot = DFA7_eot;
			this.eof = DFA7_eof;
			this.min = DFA7_min;
			this.max = DFA7_max;
			this.accept = DFA7_accept;
			this.special = DFA7_special;
			this.transition = DFA7_transition;
		}

		public override string Description { get { return "48:1: FLOAT : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion

}

} // namespace  Generated 