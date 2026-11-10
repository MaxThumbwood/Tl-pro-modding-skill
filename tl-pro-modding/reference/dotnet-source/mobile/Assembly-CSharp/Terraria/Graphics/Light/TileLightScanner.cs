using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.Graphics.Light
{
	// Token: 0x020008FF RID: 2303
	[Token(Token = "0x20008FF")]
	public class TileLightScanner
	{
		// Token: 0x06004D70 RID: 19824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D70")]
		[Address(RVA = "0x6FCC98", Offset = "0x6FCC98", VA = "0x6FCC98")]
		public TileLightScanner()
		{
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06004D71 RID: 19825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095C")]
		private ThreadedRenderManager ThreadManager
		{
			[Token(Token = "0x6004D71")]
			[Address(RVA = "0x6FCCCC", Offset = "0x6FCCCC", VA = "0x6FCCCC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D72")]
		[Address(RVA = "0x6FCD40", Offset = "0x6FCD40", VA = "0x6FCD40")]
		private void ExportBatchFinished(int index)
		{
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06004D73 RID: 19827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095D")]
		private ThreadedRenderManager.BatchProcessCallback ExportBatchFinishedCallback
		{
			[Token(Token = "0x6004D73")]
			[Address(RVA = "0x6FCD44", Offset = "0x6FCD44", VA = "0x6FCD44")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D74")]
		[Address(RVA = "0x6FCDF0", Offset = "0x6FCDF0", VA = "0x6FCDF0")]
		private void ExportToThreaded(Rectangle area, LightMap outputMap)
		{
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D75")]
		[Address(RVA = "0x702434", Offset = "0x702434", VA = "0x702434")]
		public void ExportTo(Rectangle area, LightMap outputMap)
		{
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D76")]
		[Address(RVA = "0x6FD270", Offset = "0x6FD270", VA = "0x6FD270")]
		public void ExportTo(int startX, int startY, int endX, int endY, int lightStartX, int lightStartY, LightMap outputMap)
		{
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x000244B0 File Offset: 0x000226B0
		[Token(Token = "0x6004D77")]
		[Address(RVA = "0x702558", Offset = "0x702558", VA = "0x702558")]
		private bool IsTileNullOrTouchingNull(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D78")]
		[Address(RVA = "0x7026EC", Offset = "0x7026EC", VA = "0x7026EC")]
		public void Update()
		{
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x000244C8 File Offset: 0x000226C8
		[Token(Token = "0x6004D79")]
		[Address(RVA = "0x7026F8", Offset = "0x7026F8", VA = "0x7026F8")]
		public LightMaskMode GetMaskMode(int x, int y)
		{
			return LightMaskMode.None;
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x000244E0 File Offset: 0x000226E0
		[Token(Token = "0x6004D7A")]
		[Address(RVA = "0x702794", Offset = "0x702794", VA = "0x702794")]
		private LightMaskMode GetTileMask(Tile tile)
		{
			return LightMaskMode.None;
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D7B")]
		[Address(RVA = "0x702E08", Offset = "0x702E08", VA = "0x702E08")]
		public void GetTileLight(int x, int y, out Vector3 outputColor)
		{
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D7C")]
		[Address(RVA = "0x70D6BC", Offset = "0x70D6BC", VA = "0x70D6BC")]
		private void ApplyLiquidLight(Tile tile, ref Vector3 lightColor)
		{
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x000244F8 File Offset: 0x000226F8
		[Token(Token = "0x6004D7D")]
		[Address(RVA = "0x702BCC", Offset = "0x702BCC", VA = "0x702BCC")]
		private bool LightIsBlocked(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D7E")]
		[Address(RVA = "0x7058B0", Offset = "0x7058B0", VA = "0x7058B0")]
		private void ApplyWallLight(Tile tile, int x, int y, ref FastRandom localRandom, ref Vector3 lightColor)
		{
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D7F")]
		[Address(RVA = "0x7060E8", Offset = "0x7060E8", VA = "0x7060E8")]
		private void ApplyTileLight(Tile tile, int x, int y, ref FastRandom localRandom, ref Vector3 lightColor)
		{
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D80")]
		[Address(RVA = "0x7030E8", Offset = "0x7030E8", VA = "0x7030E8")]
		private void ApplySurfaceLight(Tile tile, int x, int y, ref Vector3 lightColor)
		{
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D81")]
		[Address(RVA = "0x704780", Offset = "0x704780", VA = "0x704780")]
		private void ApplyHellLight(Tile tile, int x, int y, ref Vector3 lightColor)
		{
		}

		// Token: 0x0400924A RID: 37450
		[Token(Token = "0x400924A")]
		[FieldOffset(Offset = "0x8")]
		private FastRandom _random;

		// Token: 0x0400924B RID: 37451
		[Token(Token = "0x400924B")]
		[FieldOffset(Offset = "0x10")]
		private bool _drawInvisibleWalls;

		// Token: 0x0400924C RID: 37452
		[Token(Token = "0x400924C")]
		[FieldOffset(Offset = "0x14")]
		private ThreadedRenderManager _threadManager;

		// Token: 0x0400924D RID: 37453
		[Token(Token = "0x400924D")]
		[FieldOffset(Offset = "0x18")]
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x0400924E RID: 37454
		[Token(Token = "0x400924E")]
		private const float LESION_R = 0.55f;

		// Token: 0x0400924F RID: 37455
		[Token(Token = "0x400924F")]
		private const float LESION_G = 0.45f;

		// Token: 0x04009250 RID: 37456
		[Token(Token = "0x4009250")]
		private const float LESION_B = 0.95f;

		// Token: 0x04009251 RID: 37457
		[Token(Token = "0x4009251")]
		private const float SOLAR_R = 1f;

		// Token: 0x04009252 RID: 37458
		[Token(Token = "0x4009252")]
		private const float SOLAR_G = 0.6f;

		// Token: 0x04009253 RID: 37459
		[Token(Token = "0x4009253")]
		private const float SOLAR_B = 0.1f;

		// Token: 0x04009254 RID: 37460
		[Token(Token = "0x4009254")]
		private const float VORTEX_R = 0.3f;

		// Token: 0x04009255 RID: 37461
		[Token(Token = "0x4009255")]
		private const float VORTEX_G = 0.75f;

		// Token: 0x04009256 RID: 37462
		[Token(Token = "0x4009256")]
		private const float VORTEX_B = 0.55f;

		// Token: 0x04009257 RID: 37463
		[Token(Token = "0x4009257")]
		private const float NEBULA_R = 0.9f;

		// Token: 0x04009258 RID: 37464
		[Token(Token = "0x4009258")]
		private const float NEBULA_G = 0.55f;

		// Token: 0x04009259 RID: 37465
		[Token(Token = "0x4009259")]
		private const float NEBULA_B = 0.7f;

		// Token: 0x0400925A RID: 37466
		[Token(Token = "0x400925A")]
		private const float STARDUST_R = 0.55f;

		// Token: 0x0400925B RID: 37467
		[Token(Token = "0x400925B")]
		private const float STARDUST_G = 0.85f;

		// Token: 0x0400925C RID: 37468
		[Token(Token = "0x400925C")]
		private const float STARDUST_B = 1f;

		// Token: 0x0400925D RID: 37469
		[Token(Token = "0x400925D")]
		private const float ICE_R = 0.75f;

		// Token: 0x0400925E RID: 37470
		[Token(Token = "0x400925E")]
		private const float ICE_G = 0.85f;

		// Token: 0x0400925F RID: 37471
		[Token(Token = "0x400925F")]
		private const float ICE_B = 1f;

		// Token: 0x04009260 RID: 37472
		[Token(Token = "0x4009260")]
		private const float WARMLIGHT_R = 1f;

		// Token: 0x04009261 RID: 37473
		[Token(Token = "0x4009261")]
		private const float WARMLIGHT_G = 0.95f;

		// Token: 0x04009262 RID: 37474
		[Token(Token = "0x4009262")]
		private const float WARMLIGHT_B = 0.65f;

		// Token: 0x04009263 RID: 37475
		[Token(Token = "0x4009263")]
		private const float OFFWHITE_R = 1f;

		// Token: 0x04009264 RID: 37476
		[Token(Token = "0x4009264")]
		private const float OFFWHITE_G = 0.97f;

		// Token: 0x04009265 RID: 37477
		[Token(Token = "0x4009265")]
		private const float OFFWHITE_B = 0.85f;

		// Token: 0x04009266 RID: 37478
		[Token(Token = "0x4009266")]
		private const float FEYWOOD_R = 1f;

		// Token: 0x04009267 RID: 37479
		[Token(Token = "0x4009267")]
		private const float FEYWOOD_G = 0.6666667f;

		// Token: 0x04009268 RID: 37480
		[Token(Token = "0x4009268")]
		private const float FEYWOOD_B = 0.7764706f;

		// Token: 0x04009269 RID: 37481
		[Token(Token = "0x4009269")]
		private const float HALLOWED_R = 1f;

		// Token: 0x0400926A RID: 37482
		[Token(Token = "0x400926A")]
		private const float HALLOWED_G = 0.95f;

		// Token: 0x0400926B RID: 37483
		[Token(Token = "0x400926B")]
		private const float HALLOWED_B = 0.65f;

		// Token: 0x0400926C RID: 37484
		[Token(Token = "0x400926C")]
		private const float GOTHIC_R = 0.9529412f;

		// Token: 0x0400926D RID: 37485
		[Token(Token = "0x400926D")]
		private const float GOTHIC_G = 0.90588236f;

		// Token: 0x0400926E RID: 37486
		[Token(Token = "0x400926E")]
		private const float GOTHIC_B = 0.36078432f;

		// Token: 0x0400926F RID: 37487
		[Token(Token = "0x400926F")]
		private const float DEMONITE_R = 0.63529414f;

		// Token: 0x04009270 RID: 37488
		[Token(Token = "0x4009270")]
		private const float DEMONITE_G = 0.5019608f;

		// Token: 0x04009271 RID: 37489
		[Token(Token = "0x4009271")]
		private const float DEMONITE_B = 1f;

		// Token: 0x04009272 RID: 37490
		[Token(Token = "0x4009272")]
		private const float CRIMTANE_R = 1f;

		// Token: 0x04009273 RID: 37491
		[Token(Token = "0x4009273")]
		private const float CRIMTANE_G = 0.39215687f;

		// Token: 0x04009274 RID: 37492
		[Token(Token = "0x4009274")]
		private const float CRIMTANE_B = 0.39215687f;

		// Token: 0x04009275 RID: 37493
		[Token(Token = "0x4009275")]
		private const float SNOW_R = 0.74509805f;

		// Token: 0x04009276 RID: 37494
		[Token(Token = "0x4009276")]
		private const float SNOW_G = 0.74509805f;

		// Token: 0x04009277 RID: 37495
		[Token(Token = "0x4009277")]
		private const float SNOW_B = 1f;

		// Token: 0x04009278 RID: 37496
		[Token(Token = "0x4009278")]
		private const float FLINXFUR_R = 0.6666667f;

		// Token: 0x04009279 RID: 37497
		[Token(Token = "0x4009279")]
		private const float FLINXFUR_G = 0.7058824f;

		// Token: 0x0400927A RID: 37498
		[Token(Token = "0x400927A")]
		private const float FLINXFUR_B = 1f;

		// Token: 0x0400927B RID: 37499
		[Token(Token = "0x400927B")]
		private const float PINE_R = 1f;

		// Token: 0x0400927C RID: 37500
		[Token(Token = "0x400927C")]
		private const float PINE_G = 0.95f;

		// Token: 0x0400927D RID: 37501
		[Token(Token = "0x400927D")]
		private const float PINE_B = 0.65f;

		// Token: 0x0400927E RID: 37502
		[Token(Token = "0x400927E")]
		private const float EASTER_R = 1f;

		// Token: 0x0400927F RID: 37503
		[Token(Token = "0x400927F")]
		private const float EASTER_G = 0.95f;

		// Token: 0x04009280 RID: 37504
		[Token(Token = "0x4009280")]
		private const float EASTER_B = 0.75f;

		// Token: 0x04009281 RID: 37505
		[Token(Token = "0x4009281")]
		private const float STONE_R = 1f;

		// Token: 0x04009282 RID: 37506
		[Token(Token = "0x4009282")]
		private const float STONE_G = 0.85499996f;

		// Token: 0x04009283 RID: 37507
		[Token(Token = "0x4009283")]
		private const float STONE_B = 0.585f;

		// Token: 0x04009284 RID: 37508
		[Token(Token = "0x4009284")]
		private const float JELLYFISH_R = 0.5f;

		// Token: 0x04009285 RID: 37509
		[Token(Token = "0x4009285")]
		private const float JELLYFISH_G = 0.9f;

		// Token: 0x04009286 RID: 37510
		[Token(Token = "0x4009286")]
		private const float JELLYFISH_B = 1f;

		// Token: 0x04009287 RID: 37511
		[Token(Token = "0x4009287")]
		private const float HARPY_R = 1f;

		// Token: 0x04009288 RID: 37512
		[Token(Token = "0x4009288")]
		private const float HARPY_G = 0.9f;

		// Token: 0x04009289 RID: 37513
		[Token(Token = "0x4009289")]
		private const float HARPY_B = 0.9f;

		// Token: 0x0400928A RID: 37514
		[Token(Token = "0x400928A")]
		private const float CLOUD_R = 0.7058824f;

		// Token: 0x0400928B RID: 37515
		[Token(Token = "0x400928B")]
		private const float CLOUD_G = 0.9019608f;

		// Token: 0x0400928C RID: 37516
		[Token(Token = "0x400928C")]
		private const float CLOUD_B = 1f;

		// Token: 0x0400928D RID: 37517
		[Token(Token = "0x400928D")]
		private const float MOONPLATE_R = 0.5882353f;

		// Token: 0x0400928E RID: 37518
		[Token(Token = "0x400928E")]
		private const float MOONPLATE_G = 0.92156863f;

		// Token: 0x0400928F RID: 37519
		[Token(Token = "0x400928F")]
		private const float MOONPLATE_B = 0.9607843f;

		// Token: 0x04009290 RID: 37520
		[Token(Token = "0x4009290")]
		private const float LIBRARIAN_R = 0.6666667f;

		// Token: 0x04009291 RID: 37521
		[Token(Token = "0x4009291")]
		private const float LIBRARIAN_G = 0.9607843f;

		// Token: 0x04009292 RID: 37522
		[Token(Token = "0x4009292")]
		private const float LIBRARIAN_B = 1f;

		// Token: 0x04009293 RID: 37523
		[Token(Token = "0x4009293")]
		private const float SPIKE_R = 1f;

		// Token: 0x04009294 RID: 37524
		[Token(Token = "0x4009294")]
		private const float SPIKE_G = 0.95f;

		// Token: 0x04009295 RID: 37525
		[Token(Token = "0x4009295")]
		private const float SPIKE_B = 0.65f;

		// Token: 0x04009296 RID: 37526
		[Token(Token = "0x4009296")]
		private const float OFFICE_R = 1f;

		// Token: 0x04009297 RID: 37527
		[Token(Token = "0x4009297")]
		private const float OFFICE_G = 0.95f;

		// Token: 0x04009298 RID: 37528
		[Token(Token = "0x4009298")]
		private const float OFFICE_B = 0.65f;

		// Token: 0x04009299 RID: 37529
		[Token(Token = "0x4009299")]
		private const float FORBIDDEN_R = 0.92156863f;

		// Token: 0x0400929A RID: 37530
		[Token(Token = "0x400929A")]
		private const float FORBIDDEN_G = 0.4117647f;

		// Token: 0x0400929B RID: 37531
		[Token(Token = "0x400929B")]
		private const float FORBIDDEN_B = 1f;

		// Token: 0x0400929C RID: 37532
		[Token(Token = "0x400929C")]
		private const float WATER_R = 0.74509805f;

		// Token: 0x0400929D RID: 37533
		[Token(Token = "0x400929D")]
		private const float WATER_G = 0.74509805f;

		// Token: 0x0400929E RID: 37534
		[Token(Token = "0x400929E")]
		private const float WATER_B = 1f;

		// Token: 0x0400929F RID: 37535
		[Token(Token = "0x400929F")]
		private const float BOULDER_R = 0.84313726f;

		// Token: 0x040092A0 RID: 37536
		[Token(Token = "0x40092A0")]
		private const float BOULDER_G = 0.6862745f;

		// Token: 0x040092A1 RID: 37537
		[Token(Token = "0x40092A1")]
		private const float BOULDER_B = 0.9607843f;
	}
}
