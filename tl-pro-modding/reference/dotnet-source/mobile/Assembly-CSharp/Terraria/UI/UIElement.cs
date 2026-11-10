using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

namespace Terraria.UI
{
	// Token: 0x0200088E RID: 2190
	[Token(Token = "0x200088E")]
	public class UIElement : FileAPI
	{
		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06004A6B RID: 19051 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A6C RID: 19052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000911")]
		public UIElement Parent
		{
			[Token(Token = "0x6004A6B")]
			[Address(RVA = "0x61C9D0", Offset = "0x61C9D0", VA = "0x61C9D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A6C")]
			[Address(RVA = "0x61C9D8", Offset = "0x61C9D8", VA = "0x61C9D8")]
			private set
			{
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06004A6D RID: 19053 RVA: 0x00023880 File Offset: 0x00021A80
		// (set) Token: 0x06004A6E RID: 19054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000912")]
		public int UniqueId
		{
			[Token(Token = "0x6004A6D")]
			[Address(RVA = "0x61C9E0", Offset = "0x61C9E0", VA = "0x61C9E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004A6E")]
			[Address(RVA = "0x61C9E8", Offset = "0x61C9E8", VA = "0x61C9E8")]
			private set
			{
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06004A6F RID: 19055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000913")]
		public IEnumerable<UIElement> Children
		{
			[Token(Token = "0x6004A6F")]
			[Address(RVA = "0x61C9F0", Offset = "0x61C9F0", VA = "0x61C9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06004A70 RID: 19056 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A71 RID: 19057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000049")]
		public event UIElement.MouseEvent OnLeftMouseDown
		{
			[Token(Token = "0x6004A70")]
			[Address(RVA = "0x61C9F8", Offset = "0x61C9F8", VA = "0x61C9F8")]
			add
			{
			}
			[Token(Token = "0x6004A71")]
			[Address(RVA = "0x61CAA8", Offset = "0x61CAA8", VA = "0x61CAA8")]
			remove
			{
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06004A72 RID: 19058 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A73 RID: 19059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004A")]
		public event UIElement.MouseEvent OnLeftMouseUp
		{
			[Token(Token = "0x6004A72")]
			[Address(RVA = "0x61CB58", Offset = "0x61CB58", VA = "0x61CB58")]
			add
			{
			}
			[Token(Token = "0x6004A73")]
			[Address(RVA = "0x61CC08", Offset = "0x61CC08", VA = "0x61CC08")]
			remove
			{
			}
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06004A74 RID: 19060 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A75 RID: 19061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004B")]
		public event UIElement.MouseEvent OnLeftClick
		{
			[Token(Token = "0x6004A74")]
			[Address(RVA = "0x61CCB8", Offset = "0x61CCB8", VA = "0x61CCB8")]
			add
			{
			}
			[Token(Token = "0x6004A75")]
			[Address(RVA = "0x61CD68", Offset = "0x61CD68", VA = "0x61CD68")]
			remove
			{
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06004A76 RID: 19062 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A77 RID: 19063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004C")]
		public event UIElement.MouseEvent OnLeftDoubleClick
		{
			[Token(Token = "0x6004A76")]
			[Address(RVA = "0x61CE18", Offset = "0x61CE18", VA = "0x61CE18")]
			add
			{
			}
			[Token(Token = "0x6004A77")]
			[Address(RVA = "0x61CEC8", Offset = "0x61CEC8", VA = "0x61CEC8")]
			remove
			{
			}
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06004A78 RID: 19064 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A79 RID: 19065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004D")]
		public event UIElement.MouseEvent OnRightMouseDown
		{
			[Token(Token = "0x6004A78")]
			[Address(RVA = "0x61CF78", Offset = "0x61CF78", VA = "0x61CF78")]
			add
			{
			}
			[Token(Token = "0x6004A79")]
			[Address(RVA = "0x61D028", Offset = "0x61D028", VA = "0x61D028")]
			remove
			{
			}
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06004A7A RID: 19066 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A7B RID: 19067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004E")]
		public event UIElement.MouseEvent OnRightMouseUp
		{
			[Token(Token = "0x6004A7A")]
			[Address(RVA = "0x61D0D8", Offset = "0x61D0D8", VA = "0x61D0D8")]
			add
			{
			}
			[Token(Token = "0x6004A7B")]
			[Address(RVA = "0x61D188", Offset = "0x61D188", VA = "0x61D188")]
			remove
			{
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06004A7C RID: 19068 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A7D RID: 19069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004F")]
		public event UIElement.MouseEvent OnRightClick
		{
			[Token(Token = "0x6004A7C")]
			[Address(RVA = "0x61D238", Offset = "0x61D238", VA = "0x61D238")]
			add
			{
			}
			[Token(Token = "0x6004A7D")]
			[Address(RVA = "0x61D2E8", Offset = "0x61D2E8", VA = "0x61D2E8")]
			remove
			{
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06004A7E RID: 19070 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A7F RID: 19071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000050")]
		public event UIElement.MouseEvent OnRightDoubleClick
		{
			[Token(Token = "0x6004A7E")]
			[Address(RVA = "0x61D398", Offset = "0x61D398", VA = "0x61D398")]
			add
			{
			}
			[Token(Token = "0x6004A7F")]
			[Address(RVA = "0x61D448", Offset = "0x61D448", VA = "0x61D448")]
			remove
			{
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x06004A80 RID: 19072 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A81 RID: 19073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000051")]
		public event UIElement.MouseEvent OnMouseOver
		{
			[Token(Token = "0x6004A80")]
			[Address(RVA = "0x61D4F8", Offset = "0x61D4F8", VA = "0x61D4F8")]
			add
			{
			}
			[Token(Token = "0x6004A81")]
			[Address(RVA = "0x61D5A8", Offset = "0x61D5A8", VA = "0x61D5A8")]
			remove
			{
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06004A82 RID: 19074 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A83 RID: 19075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000052")]
		public event UIElement.MouseEvent OnMouseOut
		{
			[Token(Token = "0x6004A82")]
			[Address(RVA = "0x61D658", Offset = "0x61D658", VA = "0x61D658")]
			add
			{
			}
			[Token(Token = "0x6004A83")]
			[Address(RVA = "0x61D708", Offset = "0x61D708", VA = "0x61D708")]
			remove
			{
			}
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06004A84 RID: 19076 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A85 RID: 19077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000053")]
		public event UIElement.ScrollWheelEvent OnScrollWheel
		{
			[Token(Token = "0x6004A84")]
			[Address(RVA = "0x61D7B8", Offset = "0x61D7B8", VA = "0x61D7B8")]
			add
			{
			}
			[Token(Token = "0x6004A85")]
			[Address(RVA = "0x61D868", Offset = "0x61D868", VA = "0x61D868")]
			remove
			{
			}
		}

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x06004A86 RID: 19078 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A87 RID: 19079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000054")]
		public event UIElement.ElementEvent OnUpdate
		{
			[Token(Token = "0x6004A86")]
			[Address(RVA = "0x61D918", Offset = "0x61D918", VA = "0x61D918")]
			add
			{
			}
			[Token(Token = "0x6004A87")]
			[Address(RVA = "0x61D9C8", Offset = "0x61D9C8", VA = "0x61D9C8")]
			remove
			{
			}
		}

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x06004A88 RID: 19080 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004A89 RID: 19081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000055")]
		public event UIElement.DrawEvent OnDraw
		{
			[Token(Token = "0x6004A88")]
			[Address(RVA = "0x61DA78", Offset = "0x61DA78", VA = "0x61DA78")]
			add
			{
			}
			[Token(Token = "0x6004A89")]
			[Address(RVA = "0x61DB28", Offset = "0x61DB28", VA = "0x61DB28")]
			remove
			{
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06004A8A RID: 19082 RVA: 0x00023898 File Offset: 0x00021A98
		// (set) Token: 0x06004A8B RID: 19083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000914")]
		public bool IsMouseHovering
		{
			[Token(Token = "0x6004A8A")]
			[Address(RVA = "0x61DBD8", Offset = "0x61DBD8", VA = "0x61DBD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A8B")]
			[Address(RVA = "0x61DBE0", Offset = "0x61DBE0", VA = "0x61DBE0")]
			private set
			{
			}
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8C")]
		[Address(RVA = "0x61DBE8", Offset = "0x61DBE8", VA = "0x61DBE8")]
		public UIElement()
		{
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8D")]
		[Address(RVA = "0x61DD5C", Offset = "0x61DD5C", VA = "0x61DD5C")]
		public void SetSnapPoint(string name, int id, [Optional] Vector2? anchor, [Optional] Vector2? offset)
		{
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x000238B0 File Offset: 0x00021AB0
		[Token(Token = "0x6004A8E")]
		[Address(RVA = "0x61DF88", Offset = "0x61DF88", VA = "0x61DF88")]
		public bool GetSnapPoint(out SnapPoint point)
		{
			return default(bool);
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8F")]
		[Address(RVA = "0x61DFBC", Offset = "0x61DFBC", VA = "0x61DFBC", Slot = "5")]
		public virtual void ExecuteRecursively(UIElement.UIElementAction action)
		{
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A90")]
		[Address(RVA = "0x61E188", Offset = "0x61E188", VA = "0x61E188", Slot = "6")]
		protected virtual void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A91")]
		[Address(RVA = "0x61E18C", Offset = "0x61E18C", VA = "0x61E18C", Slot = "7")]
		protected virtual void DrawChildren(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A92")]
		[Address(RVA = "0x61E338", Offset = "0x61E338", VA = "0x61E338")]
		public void Append(UIElement element)
		{
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A93")]
		[Address(RVA = "0x61E488", Offset = "0x61E488", VA = "0x61E488")]
		public void Remove()
		{
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A94")]
		[Address(RVA = "0x61E504", Offset = "0x61E504", VA = "0x61E504")]
		public void RemoveChild(UIElement child)
		{
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A95")]
		[Address(RVA = "0x61E584", Offset = "0x61E584", VA = "0x61E584")]
		public void RemoveAllChildren()
		{
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A96")]
		[Address(RVA = "0x61E768", Offset = "0x61E768", VA = "0x61E768", Slot = "8")]
		public virtual void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A97")]
		[Address(RVA = "0x61F950", Offset = "0x61F950", VA = "0x61F950", Slot = "9")]
		public virtual void Update(GameTime gameTime)
		{
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x000238C8 File Offset: 0x00021AC8
		[Token(Token = "0x6004A98")]
		[Address(RVA = "0x61F2A4", Offset = "0x61F2A4", VA = "0x61F2A4")]
		public Rectangle GetClippingRectangle(SpriteBatch spriteBatch)
		{
			return default(Rectangle);
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A99")]
		[Address(RVA = "0x61FB1C", Offset = "0x61FB1C", VA = "0x61FB1C", Slot = "10")]
		public virtual List<SnapPoint> GetSnapPoints()
		{
			return null;
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9A")]
		[Address(RVA = "0x61FE0C", Offset = "0x61FE0C", VA = "0x61FE0C", Slot = "11")]
		public virtual void Recalculate()
		{
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x000238E0 File Offset: 0x00021AE0
		[Token(Token = "0x6004A9B")]
		[Address(RVA = "0x61FFC4", Offset = "0x61FFC4", VA = "0x61FFC4")]
		private CalculatedStyle GetDimensionsBasedOnParentDimensions(CalculatedStyle parentDimensions)
		{
			return default(CalculatedStyle);
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A9C")]
		[Address(RVA = "0x620138", Offset = "0x620138", VA = "0x620138")]
		public UIElement GetElementAt(Vector2 point)
		{
			return null;
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x000238F8 File Offset: 0x00021AF8
		[Token(Token = "0x6004A9D")]
		[Address(RVA = "0x620298", Offset = "0x620298", VA = "0x620298", Slot = "12")]
		public virtual bool ContainsPoint(Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x00023910 File Offset: 0x00021B10
		[Token(Token = "0x6004A9E")]
		[Address(RVA = "0x620388", Offset = "0x620388", VA = "0x620388", Slot = "13")]
		public virtual Rectangle GetViewCullingArea()
		{
			return default(Rectangle);
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A9F")]
		[Address(RVA = "0x6203B8", Offset = "0x6203B8", VA = "0x6203B8")]
		public void SetPadding(float pixels)
		{
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA0")]
		[Address(RVA = "0x6203C8", Offset = "0x6203C8", VA = "0x6203C8", Slot = "14")]
		public virtual void RecalculateChildren()
		{
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x00023928 File Offset: 0x00021B28
		[Token(Token = "0x6004AA1")]
		[Address(RVA = "0x62056C", Offset = "0x62056C", VA = "0x62056C")]
		public CalculatedStyle GetInnerDimensions()
		{
			return default(CalculatedStyle);
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x00023940 File Offset: 0x00021B40
		[Token(Token = "0x6004AA2")]
		[Address(RVA = "0x62057C", Offset = "0x62057C", VA = "0x62057C")]
		public CalculatedStyle GetDimensions()
		{
			return default(CalculatedStyle);
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x00023958 File Offset: 0x00021B58
		[Token(Token = "0x6004AA3")]
		[Address(RVA = "0x62058C", Offset = "0x62058C", VA = "0x62058C")]
		public CalculatedStyle GetOuterDimensions()
		{
			return default(CalculatedStyle);
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA4")]
		[Address(RVA = "0x62059C", Offset = "0x62059C", VA = "0x62059C")]
		public void CopyStyle(UIElement element)
		{
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA5")]
		[Address(RVA = "0x6207C4", Offset = "0x6207C4", VA = "0x6207C4", Slot = "15")]
		public virtual void LeftMouseDown(UIMouseEvent evt)
		{
		}

		// Token: 0x06004AA6 RID: 19110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA6")]
		[Address(RVA = "0x62081C", Offset = "0x62081C", VA = "0x62081C", Slot = "16")]
		public virtual void LeftMouseUp(UIMouseEvent evt)
		{
		}

		// Token: 0x06004AA7 RID: 19111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA7")]
		[Address(RVA = "0x620874", Offset = "0x620874", VA = "0x620874", Slot = "17")]
		public virtual void LeftClick(UIMouseEvent evt)
		{
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA8")]
		[Address(RVA = "0x6208CC", Offset = "0x6208CC", VA = "0x6208CC", Slot = "18")]
		public virtual void LeftDoubleClick(UIMouseEvent evt)
		{
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA9")]
		[Address(RVA = "0x620924", Offset = "0x620924", VA = "0x620924", Slot = "19")]
		public virtual void RightMouseDown(UIMouseEvent evt)
		{
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAA")]
		[Address(RVA = "0x62097C", Offset = "0x62097C", VA = "0x62097C", Slot = "20")]
		public virtual void RightMouseUp(UIMouseEvent evt)
		{
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAB")]
		[Address(RVA = "0x6209D4", Offset = "0x6209D4", VA = "0x6209D4", Slot = "21")]
		public virtual void RightClick(UIMouseEvent evt)
		{
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAC")]
		[Address(RVA = "0x620A2C", Offset = "0x620A2C", VA = "0x620A2C", Slot = "22")]
		public virtual void RightDoubleClick(UIMouseEvent evt)
		{
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAD")]
		[Address(RVA = "0x620A84", Offset = "0x620A84", VA = "0x620A84", Slot = "23")]
		public virtual void MouseOver(UIMouseEvent evt)
		{
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAE")]
		[Address(RVA = "0x620AE4", Offset = "0x620AE4", VA = "0x620AE4", Slot = "24")]
		public virtual void MouseOut(UIMouseEvent evt)
		{
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAF")]
		[Address(RVA = "0x620B44", Offset = "0x620B44", VA = "0x620B44", Slot = "25")]
		public virtual void ScrollWheel(UIScrollWheelEvent evt)
		{
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB0")]
		[Address(RVA = "0x620B9C", Offset = "0x620B9C", VA = "0x620B9C")]
		public void Activate()
		{
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB1")]
		[Address(RVA = "0x620D98", Offset = "0x620D98", VA = "0x620D98", Slot = "26")]
		public virtual void OnActivate()
		{
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB2")]
		[Address(RVA = "0x620D9C", Offset = "0x620D9C", VA = "0x620D9C")]
		public void DrawDebugHitbox(BasicDebugDrawer drawer, float colorIntensity = 0f)
		{
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB3")]
		[Address(RVA = "0x6212F8", Offset = "0x6212F8", VA = "0x6212F8")]
		public void Deactivate()
		{
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB4")]
		[Address(RVA = "0x6214A4", Offset = "0x6214A4", VA = "0x6214A4", Slot = "27")]
		public virtual void OnDeactivate()
		{
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB5")]
		[Address(RVA = "0x620D70", Offset = "0x620D70", VA = "0x620D70")]
		public void Initialize()
		{
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB6")]
		[Address(RVA = "0x6214A8", Offset = "0x6214A8", VA = "0x6214A8", Slot = "28")]
		public virtual void OnInitialize()
		{
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x00023970 File Offset: 0x00021B70
		[Token(Token = "0x6004AB7")]
		[Address(RVA = "0x6214AC", Offset = "0x6214AC", VA = "0x6214AC", Slot = "29")]
		public virtual int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x04008FD3 RID: 36819
		[Token(Token = "0x4008FD3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private UIElement <Parent>k__BackingField;

		// Token: 0x04008FD4 RID: 36820
		[Token(Token = "0x4008FD4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected readonly List<UIElement> Elements;

		// Token: 0x04008FD5 RID: 36821
		[Token(Token = "0x4008FD5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <UniqueId>k__BackingField;

		// Token: 0x04008FD6 RID: 36822
		[Token(Token = "0x4008FD6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public StyleDimension Top;

		// Token: 0x04008FD7 RID: 36823
		[Token(Token = "0x4008FD7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public StyleDimension Left;

		// Token: 0x04008FD8 RID: 36824
		[Token(Token = "0x4008FD8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public StyleDimension Width;

		// Token: 0x04008FD9 RID: 36825
		[Token(Token = "0x4008FD9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public StyleDimension Height;

		// Token: 0x04008FDA RID: 36826
		[Token(Token = "0x4008FDA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public StyleDimension MaxWidth;

		// Token: 0x04008FDB RID: 36827
		[Token(Token = "0x4008FDB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public StyleDimension MaxHeight;

		// Token: 0x04008FDC RID: 36828
		[Token(Token = "0x4008FDC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public StyleDimension MinWidth;

		// Token: 0x04008FDD RID: 36829
		[Token(Token = "0x4008FDD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public StyleDimension MinHeight;

		// Token: 0x04008FEB RID: 36843
		[Token(Token = "0x4008FEB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _isInitialized;

		// Token: 0x04008FEC RID: 36844
		[Token(Token = "0x4008FEC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool IgnoresMouseInteraction;

		// Token: 0x04008FED RID: 36845
		[Token(Token = "0x4008FED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool PassThroughMouseInteraction;

		// Token: 0x04008FEE RID: 36846
		[Token(Token = "0x4008FEE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool OverflowHidden;

		// Token: 0x04008FEF RID: 36847
		[Token(Token = "0x4008FEF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public SamplerState OverrideSamplerState;

		// Token: 0x04008FF0 RID: 36848
		[Token(Token = "0x4008FF0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float PaddingTop;

		// Token: 0x04008FF1 RID: 36849
		[Token(Token = "0x4008FF1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float PaddingLeft;

		// Token: 0x04008FF2 RID: 36850
		[Token(Token = "0x4008FF2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float PaddingRight;

		// Token: 0x04008FF3 RID: 36851
		[Token(Token = "0x4008FF3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float PaddingBottom;

		// Token: 0x04008FF4 RID: 36852
		[Token(Token = "0x4008FF4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float MarginTop;

		// Token: 0x04008FF5 RID: 36853
		[Token(Token = "0x4008FF5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float MarginLeft;

		// Token: 0x04008FF6 RID: 36854
		[Token(Token = "0x4008FF6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float MarginRight;

		// Token: 0x04008FF7 RID: 36855
		[Token(Token = "0x4008FF7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float MarginBottom;

		// Token: 0x04008FF8 RID: 36856
		[Token(Token = "0x4008FF8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float HAlign;

		// Token: 0x04008FF9 RID: 36857
		[Token(Token = "0x4008FF9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float VAlign;

		// Token: 0x04008FFA RID: 36858
		[Token(Token = "0x4008FFA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CalculatedStyle _innerDimensions;

		// Token: 0x04008FFB RID: 36859
		[Token(Token = "0x4008FFB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private CalculatedStyle _dimensions;

		// Token: 0x04008FFC RID: 36860
		[Token(Token = "0x4008FFC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private CalculatedStyle _outerDimensions;

		// Token: 0x04008FFD RID: 36861
		[Token(Token = "0x4008FFD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly RasterizerState OverflowHiddenRasterizerState;

		// Token: 0x04008FFE RID: 36862
		[Token(Token = "0x4008FFE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public bool UseImmediateMode;

		// Token: 0x04008FFF RID: 36863
		[Token(Token = "0x4008FFF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private SnapPoint _snapPoint;

		// Token: 0x04009000 RID: 36864
		[Token(Token = "0x4009000")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool <IsMouseHovering>k__BackingField;

		// Token: 0x04009001 RID: 36865
		[Token(Token = "0x4009001")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int _idCounter;

		// Token: 0x0200088F RID: 2191
		// (Invoke) Token: 0x06004ABA RID: 19130
		[Token(Token = "0x200088F")]
		public delegate void MouseEvent(UIMouseEvent evt, UIElement listeningElement);

		// Token: 0x02000890 RID: 2192
		// (Invoke) Token: 0x06004ABE RID: 19134
		[Token(Token = "0x2000890")]
		public delegate void ScrollWheelEvent(UIScrollWheelEvent evt, UIElement listeningElement);

		// Token: 0x02000891 RID: 2193
		// (Invoke) Token: 0x06004AC2 RID: 19138
		[Token(Token = "0x2000891")]
		public delegate void ElementEvent(UIElement affectedElement);

		// Token: 0x02000892 RID: 2194
		// (Invoke) Token: 0x06004AC6 RID: 19142
		[Token(Token = "0x2000892")]
		public delegate void DrawEvent(UIElement affectedElement, SpriteBatch sb);

		// Token: 0x02000893 RID: 2195
		// (Invoke) Token: 0x06004ACA RID: 19146
		[Token(Token = "0x2000893")]
		public delegate void UIElementAction(UIElement element);
	}
}
