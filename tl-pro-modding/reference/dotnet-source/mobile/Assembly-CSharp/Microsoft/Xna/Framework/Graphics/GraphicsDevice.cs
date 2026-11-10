using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.Graphics;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003F3 RID: 1011
	[Token(Token = "0x20003F3")]
	public class GraphicsDevice
	{
		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000331")]
		internal GraphicsCapabilities GraphicsCapabilities
		{
			[Token(Token = "0x6001BA4")]
			[Address(RVA = "0xE802B8", Offset = "0xE802B8", VA = "0xE802B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BA5")]
			[Address(RVA = "0xE802C0", Offset = "0xE802C0", VA = "0xE802C0")]
			private set
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06001BA6 RID: 7078 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001BA7 RID: 7079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000012")]
		public event EventHandler<EventArgs> DeviceLost
		{
			[Token(Token = "0x6001BA6")]
			[Address(RVA = "0xE802C8", Offset = "0xE802C8", VA = "0xE802C8")]
			add
			{
			}
			[Token(Token = "0x6001BA7")]
			[Address(RVA = "0xE80390", Offset = "0xE80390", VA = "0xE80390")]
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06001BA8 RID: 7080 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001BA9 RID: 7081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000013")]
		public event EventHandler<EventArgs> DeviceReset
		{
			[Token(Token = "0x6001BA8")]
			[Address(RVA = "0xE80458", Offset = "0xE80458", VA = "0xE80458")]
			add
			{
			}
			[Token(Token = "0x6001BA9")]
			[Address(RVA = "0xE80520", Offset = "0xE80520", VA = "0xE80520")]
			remove
			{
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06001BAA RID: 7082 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001BAB RID: 7083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000014")]
		public event EventHandler<EventArgs> DeviceResetting
		{
			[Token(Token = "0x6001BAA")]
			[Address(RVA = "0xE805E8", Offset = "0xE805E8", VA = "0xE805E8")]
			add
			{
			}
			[Token(Token = "0x6001BAB")]
			[Address(RVA = "0xE806B0", Offset = "0xE806B0", VA = "0xE806B0")]
			remove
			{
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06001BAC RID: 7084 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001BAD RID: 7085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000015")]
		public event EventHandler<ResourceCreatedEventArgs> ResourceCreated
		{
			[Token(Token = "0x6001BAC")]
			[Address(RVA = "0xE80778", Offset = "0xE80778", VA = "0xE80778")]
			add
			{
			}
			[Token(Token = "0x6001BAD")]
			[Address(RVA = "0xE80840", Offset = "0xE80840", VA = "0xE80840")]
			remove
			{
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06001BAE RID: 7086 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001BAF RID: 7087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000016")]
		public event EventHandler<ResourceDestroyedEventArgs> ResourceDestroyed
		{
			[Token(Token = "0x6001BAE")]
			[Address(RVA = "0xE80908", Offset = "0xE80908", VA = "0xE80908")]
			add
			{
			}
			[Token(Token = "0x6001BAF")]
			[Address(RVA = "0xE809D0", Offset = "0xE809D0", VA = "0xE809D0")]
			remove
			{
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06001BB0 RID: 7088 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001BB1 RID: 7089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000017")]
		public event EventHandler<EventArgs> Disposing
		{
			[Token(Token = "0x6001BB0")]
			[Address(RVA = "0xE80A98", Offset = "0xE80A98", VA = "0xE80A98")]
			add
			{
			}
			[Token(Token = "0x6001BB1")]
			[Address(RVA = "0xE80B60", Offset = "0xE80B60", VA = "0xE80B60")]
			remove
			{
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06001BB2 RID: 7090 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001BB3 RID: 7091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000018")]
		internal event EventHandler<PresentationEventArgs> PresentationChanged
		{
			[Token(Token = "0x6001BB2")]
			[Address(RVA = "0xE80C28", Offset = "0xE80C28", VA = "0xE80C28")]
			add
			{
			}
			[Token(Token = "0x6001BB3")]
			[Address(RVA = "0xE80CF0", Offset = "0xE80CF0", VA = "0xE80CF0")]
			remove
			{
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x0000D200 File Offset: 0x0000B400
		[Token(Token = "0x17000332")]
		internal bool IsRenderTargetBound
		{
			[Token(Token = "0x6001BB4")]
			[Address(RVA = "0xE80DB8", Offset = "0xE80DB8", VA = "0xE80DB8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x0000D218 File Offset: 0x0000B418
		[Token(Token = "0x17000333")]
		internal DepthFormat ActiveDepthFormat
		{
			[Token(Token = "0x6001BB5")]
			[Address(RVA = "0xE80DCC", Offset = "0xE80DCC", VA = "0xE80DCC")]
			get
			{
				return DepthFormat.None;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000334")]
		public GraphicsAdapter Adapter
		{
			[Token(Token = "0x6001BB6")]
			[Address(RVA = "0xE80E14", Offset = "0xE80E14", VA = "0xE80E14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BB7")]
			[Address(RVA = "0xE80E1C", Offset = "0xE80E1C", VA = "0xE80E1C")]
			private set
			{
			}
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB8")]
		[Address(RVA = "0xE80E24", Offset = "0xE80E24", VA = "0xE80E24")]
		internal GraphicsDevice()
		{
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0xE81A70", Offset = "0xE81A70", VA = "0xE81A70")]
		public GraphicsDevice(GraphicsAdapter adapter, GraphicsProfile graphicsProfile, PresentationParameters presentationParameters)
		{
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBA")]
		[Address(RVA = "0xE813AC", Offset = "0xE813AC", VA = "0xE813AC")]
		private void Setup()
		{
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBB")]
		[Address(RVA = "0xE82460", Offset = "0xE82460", VA = "0xE82460", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0000D230 File Offset: 0x0000B430
		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0xE82468", Offset = "0xE82468", VA = "0xE82468")]
		internal int GetClampedMultisampleCount(int multiSampleCount)
		{
			return 0;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0xE81868", Offset = "0xE81868", VA = "0xE81868")]
		internal void Initialize()
		{
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BBF RID: 7103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000335")]
		public RasterizerState RasterizerState
		{
			[Token(Token = "0x6001BBE")]
			[Address(RVA = "0xE82594", Offset = "0xE82594", VA = "0xE82594")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BBF")]
			[Address(RVA = "0xE8227C", Offset = "0xE8227C", VA = "0xE8227C")]
			set
			{
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x0000D248 File Offset: 0x0000B448
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000336")]
		public Color BlendFactor
		{
			[Token(Token = "0x6001BC0")]
			[Address(RVA = "0xE8259C", Offset = "0xE8259C", VA = "0xE8259C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6001BC1")]
			[Address(RVA = "0xE825A4", Offset = "0xE825A4", VA = "0xE825A4")]
			set
			{
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000337")]
		public BlendState BlendState
		{
			[Token(Token = "0x6001BC2")]
			[Address(RVA = "0xE82628", Offset = "0xE82628", VA = "0xE82628")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BC3")]
			[Address(RVA = "0xE81EC4", Offset = "0xE81EC4", VA = "0xE81EC4")]
			set
			{
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000338")]
		public DepthStencilState DepthStencilState
		{
			[Token(Token = "0x6001BC4")]
			[Address(RVA = "0xE82630", Offset = "0xE82630", VA = "0xE82630")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BC5")]
			[Address(RVA = "0xE82100", Offset = "0xE82100", VA = "0xE82100")]
			set
			{
			}
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0xE82638", Offset = "0xE82638", VA = "0xE82638")]
		internal void ApplyState(bool applyShaders)
		{
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0xE8263C", Offset = "0xE8263C", VA = "0xE8263C")]
		public void Clear(Color color)
		{
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0xE82640", Offset = "0xE82640", VA = "0xE82640")]
		public void Clear(ClearOptions options, Color color, float depth, int stencil)
		{
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0xE82644", Offset = "0xE82644", VA = "0xE82644")]
		public void Clear(ClearOptions options, Vector4 color, float depth, int stencil)
		{
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0xE82648", Offset = "0xE82648", VA = "0xE82648")]
		public void Present()
		{
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCB")]
		[Address(RVA = "0xE826B4", Offset = "0xE826B4", VA = "0xE826B4")]
		public void Reset()
		{
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0xE826B8", Offset = "0xE826B8", VA = "0xE826B8")]
		public void Reset(PresentationParameters presentationParameters)
		{
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000339")]
		public DisplayMode DisplayMode
		{
			[Token(Token = "0x6001BCD")]
			[Address(RVA = "0xE81EA0", Offset = "0xE81EA0", VA = "0xE81EA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x0000D260 File Offset: 0x0000B460
		[Token(Token = "0x1700033A")]
		public GraphicsDeviceStatus GraphicsDeviceStatus
		{
			[Token(Token = "0x6001BCE")]
			[Address(RVA = "0xE82724", Offset = "0xE82724", VA = "0xE82724")]
			get
			{
				return GraphicsDeviceStatus.Normal;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033B")]
		public PresentationParameters PresentationParameters
		{
			[Token(Token = "0x6001BCF")]
			[Address(RVA = "0xE8272C", Offset = "0xE8272C", VA = "0xE8272C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BD0")]
			[Address(RVA = "0xE82734", Offset = "0xE82734", VA = "0xE82734")]
			private set
			{
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x0000D278 File Offset: 0x0000B478
		// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033C")]
		public Viewport Viewport
		{
			[Token(Token = "0x6001BD1")]
			[Address(RVA = "0xE8273C", Offset = "0xE8273C", VA = "0xE8273C")]
			get
			{
				return default(Viewport);
			}
			[Token(Token = "0x6001BD2")]
			[Address(RVA = "0xE827B0", Offset = "0xE827B0", VA = "0xE827B0")]
			set
			{
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x0000D290 File Offset: 0x0000B490
		[Token(Token = "0x1700033D")]
		public GraphicsProfile GraphicsProfile
		{
			[Token(Token = "0x6001BD3")]
			[Address(RVA = "0xE827DC", Offset = "0xE827DC", VA = "0xE827DC")]
			get
			{
				return GraphicsProfile.Reach;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033E")]
		public Rectangle ScissorRectangle
		{
			[Token(Token = "0x6001BD4")]
			[Address(RVA = "0xE827E4", Offset = "0xE827E4", VA = "0xE827E4")]
			get
			{
				return default(Rectangle);
			}
			[Token(Token = "0x6001BD5")]
			[Address(RVA = "0xE824C4", Offset = "0xE824C4", VA = "0xE824C4")]
			set
			{
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		[Token(Token = "0x1700033F")]
		public int RenderTargetCount
		{
			[Token(Token = "0x6001BD6")]
			[Address(RVA = "0xE827F4", Offset = "0xE827F4", VA = "0xE827F4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD7")]
		[Address(RVA = "0xE827FC", Offset = "0xE827FC", VA = "0xE827FC")]
		public void SetRenderTarget(RenderTarget2D renderTarget)
		{
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD8")]
		[Address(RVA = "0xE82800", Offset = "0xE82800", VA = "0xE82800")]
		public RenderTargetBinding[] GetRenderTargets()
		{
			return null;
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD9")]
		[Address(RVA = "0xE82870", Offset = "0xE82870", VA = "0xE82870")]
		public void GetRenderTargets(RenderTargetBinding[] outTargets)
		{
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000340")]
		public bool ResourcesLost
		{
			[Token(Token = "0x6001BDA")]
			[Address(RVA = "0xE82884", Offset = "0xE82884", VA = "0xE82884")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BDB")]
			[Address(RVA = "0xE8288C", Offset = "0xE8288C", VA = "0xE8288C")]
			set
			{
			}
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDC")]
		private T[] Clone<T>(T[] srcArray, int Count)
		{
			return null;
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDD")]
		[Address(RVA = "0xE82894", Offset = "0xE82894", VA = "0xE82894")]
		public Material GetMaterial(int offset)
		{
			return null;
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0xE82AAC", Offset = "0xE82AAC", VA = "0xE82AAC")]
		public void DrawGeometry(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, Vector3 position, Vector3 scale)
		{
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDF")]
		[Address(RVA = "0xE82BC4", Offset = "0xE82BC4", VA = "0xE82BC4")]
		private Material[] GetMaterialArray(List<Material> subMeshMaterials)
		{
			return null;
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE0")]
		[Address(RVA = "0xE82CF4", Offset = "0xE82CF4", VA = "0xE82CF4")]
		private Material[] GetMaterialArray(Material[] subMeshMaterials, int subMeshMaterialCount)
		{
			return null;
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE1")]
		[Address(RVA = "0xE82DF0", Offset = "0xE82DF0", VA = "0xE82DF0")]
		public void DrawGeometry(VertexStrip.CustomVertexInfo[] vertices, short[] indices, int vertexCount, int indexCount, Vector3 position, Vector3 scale)
		{
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE2")]
		[Address(RVA = "0xE83280", Offset = "0xE83280", VA = "0xE83280")]
		public void DrawGeometryWithSubMeshes(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, Vector3 position, Vector3 scale, Material[] subMeshMaterials, SubMeshDescriptor[] subMeshPartitions, int subMeshPartitionCount)
		{
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE3")]
		[Address(RVA = "0xE836F4", Offset = "0xE836F4", VA = "0xE836F4")]
		public void DrawGeometryWithSubMeshes(SpriteBatcher_NatureLit.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, Vector3 position, Vector3 scale, Material[] subMeshMaterials, SubMeshDescriptor[] subMeshPartitions, int submeshCount, VertexAttributeDescriptor[] vertexDesc)
		{
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE4")]
		[Address(RVA = "0xE83B2C", Offset = "0xE83B2C", VA = "0xE83B2C")]
		public void DrawGeometryWithSubMeshes(SpriteBatcher_Cloud.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, Vector3 position, Vector3 scale, Material[] subMeshMaterials, SubMeshDescriptor[] subMeshPartitions, int submeshCount, VertexAttributeDescriptor[] vertexDesc)
		{
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[Token(Token = "0x6001BE5")]
		[Address(RVA = "0xE83F64", Offset = "0xE83F64", VA = "0xE83F64")]
		internal static Rectangle GetDefaultTitleSafeArea(int x, int y, int width, int height)
		{
			return default(Rectangle);
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0000D308 File Offset: 0x0000B508
		[Token(Token = "0x6001BE6")]
		[Address(RVA = "0xE83FC4", Offset = "0xE83FC4", VA = "0xE83FC4")]
		internal static Rectangle GetTitleSafeArea(int x, int y, int width, int height)
		{
			return default(Rectangle);
		}

		// Token: 0x04002F7B RID: 12155
		[Token(Token = "0x4002F7B")]
		[FieldOffset(Offset = "0x0")]
		public static GraphicsDevice Instance;

		// Token: 0x04002F7C RID: 12156
		[Token(Token = "0x4002F7C")]
		[FieldOffset(Offset = "0x8")]
		private Viewport _viewport;

		// Token: 0x04002F7D RID: 12157
		[Token(Token = "0x4002F7D")]
		[FieldOffset(Offset = "0x20")]
		private Color _blendFactor;

		// Token: 0x04002F7E RID: 12158
		[Token(Token = "0x4002F7E")]
		[FieldOffset(Offset = "0x24")]
		private bool _blendFactorDirty;

		// Token: 0x04002F7F RID: 12159
		[Token(Token = "0x4002F7F")]
		[FieldOffset(Offset = "0x28")]
		private BlendState _blendState;

		// Token: 0x04002F80 RID: 12160
		[Token(Token = "0x4002F80")]
		[FieldOffset(Offset = "0x2C")]
		private BlendState _actualBlendState;

		// Token: 0x04002F81 RID: 12161
		[Token(Token = "0x4002F81")]
		[FieldOffset(Offset = "0x30")]
		private bool _blendStateDirty;

		// Token: 0x04002F82 RID: 12162
		[Token(Token = "0x4002F82")]
		[FieldOffset(Offset = "0x34")]
		private BlendState _blendStateAdditive;

		// Token: 0x04002F83 RID: 12163
		[Token(Token = "0x4002F83")]
		[FieldOffset(Offset = "0x38")]
		private BlendState _blendStateAlphaBlend;

		// Token: 0x04002F84 RID: 12164
		[Token(Token = "0x4002F84")]
		[FieldOffset(Offset = "0x3C")]
		private BlendState _blendStateNonPremultiplied;

		// Token: 0x04002F85 RID: 12165
		[Token(Token = "0x4002F85")]
		[FieldOffset(Offset = "0x40")]
		private BlendState _blendStateOpaque;

		// Token: 0x04002F86 RID: 12166
		[Token(Token = "0x4002F86")]
		[FieldOffset(Offset = "0x44")]
		private DepthStencilState _depthStencilState;

		// Token: 0x04002F87 RID: 12167
		[Token(Token = "0x4002F87")]
		[FieldOffset(Offset = "0x48")]
		private DepthStencilState _actualDepthStencilState;

		// Token: 0x04002F88 RID: 12168
		[Token(Token = "0x4002F88")]
		[FieldOffset(Offset = "0x4C")]
		private bool _depthStencilStateDirty;

		// Token: 0x04002F89 RID: 12169
		[Token(Token = "0x4002F89")]
		[FieldOffset(Offset = "0x50")]
		private DepthStencilState _depthStencilStateDefault;

		// Token: 0x04002F8A RID: 12170
		[Token(Token = "0x4002F8A")]
		[FieldOffset(Offset = "0x54")]
		private DepthStencilState _depthStencilStateDepthRead;

		// Token: 0x04002F8B RID: 12171
		[Token(Token = "0x4002F8B")]
		[FieldOffset(Offset = "0x58")]
		private DepthStencilState _depthStencilStateNone;

		// Token: 0x04002F8C RID: 12172
		[Token(Token = "0x4002F8C")]
		[FieldOffset(Offset = "0x5C")]
		private RasterizerState _rasterizerState;

		// Token: 0x04002F8D RID: 12173
		[Token(Token = "0x4002F8D")]
		[FieldOffset(Offset = "0x60")]
		private RasterizerState _actualRasterizerState;

		// Token: 0x04002F8E RID: 12174
		[Token(Token = "0x4002F8E")]
		[FieldOffset(Offset = "0x64")]
		private bool _rasterizerStateDirty;

		// Token: 0x04002F8F RID: 12175
		[Token(Token = "0x4002F8F")]
		[FieldOffset(Offset = "0x68")]
		private RasterizerState _rasterizerStateCullClockwise;

		// Token: 0x04002F90 RID: 12176
		[Token(Token = "0x4002F90")]
		[FieldOffset(Offset = "0x6C")]
		private RasterizerState _rasterizerStateCullCounterClockwise;

		// Token: 0x04002F91 RID: 12177
		[Token(Token = "0x4002F91")]
		[FieldOffset(Offset = "0x70")]
		private RasterizerState _rasterizerStateCullNone;

		// Token: 0x04002F92 RID: 12178
		[Token(Token = "0x4002F92")]
		[FieldOffset(Offset = "0x74")]
		private Rectangle _scissorRectangle;

		// Token: 0x04002F93 RID: 12179
		[Token(Token = "0x4002F93")]
		[FieldOffset(Offset = "0x84")]
		private bool _scissorRectangleDirty;

		// Token: 0x04002F94 RID: 12180
		[Token(Token = "0x4002F94")]
		[FieldOffset(Offset = "0x88")]
		private readonly RenderTargetBinding[] _currentRenderTargetBindings;

		// Token: 0x04002F95 RID: 12181
		[Token(Token = "0x4002F95")]
		[FieldOffset(Offset = "0x8C")]
		private int _currentRenderTargetCount;

		// Token: 0x04002F96 RID: 12182
		[Token(Token = "0x4002F96")]
		[FieldOffset(Offset = "0x90")]
		private readonly RenderTargetBinding[] _tempRenderTargetBinding;

		// Token: 0x04002F97 RID: 12183
		[Token(Token = "0x4002F97")]
		[FieldOffset(Offset = "0x94")]
		private GraphicsCapabilities <GraphicsCapabilities>k__BackingField;

		// Token: 0x04002F98 RID: 12184
		[Token(Token = "0x4002F98")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Color DiscardColor;

		// Token: 0x04002F99 RID: 12185
		[Token(Token = "0x4002F99")]
		[FieldOffset(Offset = "0x98")]
		internal Dictionary<int, Effect> EffectCache;

		// Token: 0x04002FA1 RID: 12193
		[Token(Token = "0x4002FA1")]
		[FieldOffset(Offset = "0xB8")]
		private int _maxVertexBufferSlots;

		// Token: 0x04002FA2 RID: 12194
		[Token(Token = "0x4002FA2")]
		[FieldOffset(Offset = "0xBC")]
		internal int MaxTextureSlots;

		// Token: 0x04002FA3 RID: 12195
		[Token(Token = "0x4002FA3")]
		[FieldOffset(Offset = "0xC0")]
		internal int MaxVertexTextureSlots;

		// Token: 0x04002FA4 RID: 12196
		[Token(Token = "0x4002FA4")]
		[FieldOffset(Offset = "0xC4")]
		public Texture2D[] Textures;

		// Token: 0x04002FA5 RID: 12197
		[Token(Token = "0x4002FA5")]
		[FieldOffset(Offset = "0xC8")]
		private GraphicsAdapter <Adapter>k__BackingField;

		// Token: 0x04002FA6 RID: 12198
		[Token(Token = "0x4002FA6")]
		[FieldOffset(Offset = "0xCC")]
		private PresentationParameters <PresentationParameters>k__BackingField;

		// Token: 0x04002FA7 RID: 12199
		[Token(Token = "0x4002FA7")]
		[FieldOffset(Offset = "0xD0")]
		private readonly GraphicsProfile _graphicsProfile;

		// Token: 0x04002FA8 RID: 12200
		[Token(Token = "0x4002FA8")]
		[FieldOffset(Offset = "0xD4")]
		private bool <ResourcesLost>k__BackingField;

		// Token: 0x04002FA9 RID: 12201
		[Token(Token = "0x4002FA9")]
		[FieldOffset(Offset = "0xD5")]
		public bool CachedImmediateDrawMaterialActive;

		// Token: 0x04002FAA RID: 12202
		[Token(Token = "0x4002FAA")]
		[FieldOffset(Offset = "0xD8")]
		private EffectPass _cachedImmediateDrawEffect;

		// Token: 0x04002FAB RID: 12203
		[Token(Token = "0x4002FAB")]
		[FieldOffset(Offset = "0xDC")]
		private int _cachedImmediateDrawEffectState;

		// Token: 0x04002FAC RID: 12204
		[Token(Token = "0x4002FAC")]
		[FieldOffset(Offset = "0xE0")]
		private Material _cachedImmediateDrawMaterial;

		// Token: 0x04002FAD RID: 12205
		[Token(Token = "0x4002FAD")]
		[FieldOffset(Offset = "0xE4")]
		private Texture2D _cachedImmediateTexture0;

		// Token: 0x04002FAE RID: 12206
		[Token(Token = "0x4002FAE")]
		[FieldOffset(Offset = "0xE8")]
		private Texture2D _cachedImmediateTexture1;

		// Token: 0x04002FAF RID: 12207
		[Token(Token = "0x4002FAF")]
		[FieldOffset(Offset = "0xEC")]
		private List<Material[]> MaterialArrays;

		// Token: 0x04002FB0 RID: 12208
		[Token(Token = "0x4002FB0")]
		[FieldOffset(Offset = "0xF0")]
		private Material[] _drawStripGeometryMaterialList;

		// Token: 0x04002FB1 RID: 12209
		[Token(Token = "0x4002FB1")]
		[FieldOffset(Offset = "0xF4")]
		private SubMeshDescriptor[] _drawSriptSubPartitions;

		// Token: 0x04002FB2 RID: 12210
		[Token(Token = "0x4002FB2")]
		[FieldOffset(Offset = "0xF8")]
		public VertexAttributeDescriptor[] stripVertexDescription;
	}
}
