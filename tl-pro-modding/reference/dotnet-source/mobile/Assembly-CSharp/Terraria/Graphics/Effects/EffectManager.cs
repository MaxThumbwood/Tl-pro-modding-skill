using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000904 RID: 2308
	[Token(Token = "0x2000904")]
	public abstract class EffectManager<T> where T : GameEffect
	{
		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06004D8C RID: 19852 RVA: 0x00024558 File Offset: 0x00022758
		[Token(Token = "0x1700095E")]
		public bool IsLoaded
		{
			[Token(Token = "0x6004D8C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06004D8D RID: 19853 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004D8E RID: 19854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700095F")]
		public T Item
		{
			[Token(Token = "0x6004D8D")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D8E")]
			set
			{
			}
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D8F")]
		public void Bind(string name, T effect)
		{
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D90")]
		public void Load()
		{
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D91")]
		public T Activate(string name, [Optional] Vector2 position, object[] args)
		{
			return null;
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D92")]
		public void Deactivate(string name, object[] args)
		{
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D93")]
		public virtual void OnActivate(T effect, Vector2 position)
		{
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D94")]
		public virtual void OnDeactivate(T effect)
		{
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D95")]
		protected EffectManager()
		{
		}

		// Token: 0x040092A5 RID: 37541
		[Token(Token = "0x40092A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool _isLoaded;

		// Token: 0x040092A6 RID: 37542
		[Token(Token = "0x40092A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Dictionary<string, T> _effects;
	}
}
