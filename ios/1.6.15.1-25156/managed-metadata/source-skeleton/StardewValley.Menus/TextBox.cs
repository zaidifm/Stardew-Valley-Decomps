using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class TextBox : IKeyboardSubscriber
{
	protected Texture2D _textBoxTexture;

	protected Texture2D _caretTexture;

	protected SpriteFont _font;

	public bool drawBackground;

	public bool centerText;

	protected Color _textColor;

	public bool numbersOnly;

	public int textLimit;

	public bool limitWidth;

	private string _text;

	[CompilerGenerated]
	private TextBoxEvent m_OnEnterPressed;

	[CompilerGenerated]
	private TextBoxEvent m_OnTabPressed;

	[CompilerGenerated]
	private TextBoxEvent m_OnBackspacePressed;

	protected bool _showKeyboard;

	private bool _selected;

	public bool isScroll
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public SpriteFont Font
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Color TextColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int X
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int Y
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int Width
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool PasswordBox
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string TitleText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool Selected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public event TextBoxEvent OnEnterPressed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event TextBoxEvent OnTabPressed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event TextBoxEvent OnBackspacePressed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setTextColor(Color newCol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TextBox(Texture2D textBoxTexture, Texture2D caretTexture, SpriteFont font, Color textColor, bool drawBackground = true, bool centerText = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectMe()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch spriteBatch, bool drawShadow = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RecieveTextInput(char inputChar)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RecieveTextInput(string text)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RecieveCommandInput(char command)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PressEnter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecieveSpecialInput(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Hover(int x, int y)
	{
	}
}
