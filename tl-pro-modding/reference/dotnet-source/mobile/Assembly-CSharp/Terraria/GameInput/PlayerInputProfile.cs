using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Terraria.GameInput
{
	// Token: 0x02000827 RID: 2087
	[Token(Token = "0x2000827")]
	public class PlayerInputProfile
	{
		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06004797 RID: 18327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B1")]
		public string ShowName
		{
			[Token(Token = "0x6004797")]
			[Address(RVA = "0x5E39F0", Offset = "0x5E39F0", VA = "0x5E39F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x00021F60 File Offset: 0x00020160
		[Token(Token = "0x170008B2")]
		public bool HotbarAllowsRadial
		{
			[Token(Token = "0x6004798")]
			[Address(RVA = "0x5E39F8", Offset = "0x5E39F8", VA = "0x5E39F8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004799")]
		[Address(RVA = "0x5E3A10", Offset = "0x5E3A10", VA = "0x5E3A10")]
		public PlayerInputProfile(string name)
		{
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479A")]
		[Address(RVA = "0x5E3E24", Offset = "0x5E3E24", VA = "0x5E3E24")]
		public void Initialize(PresetProfiles style)
		{
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479B")]
		[Address(RVA = "0x5E403C", Offset = "0x5E403C", VA = "0x5E403C")]
		public void CopyGameplaySettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479C")]
		[Address(RVA = "0x5E436C", Offset = "0x5E436C", VA = "0x5E436C")]
		public void CopyHotbarSettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479D")]
		[Address(RVA = "0x5E4414", Offset = "0x5E4414", VA = "0x5E4414")]
		public void CopyMapSettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479E")]
		[Address(RVA = "0x5E44BC", Offset = "0x5E44BC", VA = "0x5E44BC")]
		public void CopyGamepadSettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479F")]
		[Address(RVA = "0x5E4574", Offset = "0x5E4574", VA = "0x5E4574")]
		public void CopyGamepadAdvancedSettingsFrom(PlayerInputProfile profile, InputMode mode)
		{
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A0")]
		[Address(RVA = "0x5E40E4", Offset = "0x5E40E4", VA = "0x5E40E4")]
		private void CopyKeysFrom(PlayerInputProfile profile, InputMode mode, TriggerNames[] keysToCopy)
		{
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x00021F78 File Offset: 0x00020178
		[Token(Token = "0x60047A1")]
		[Address(RVA = "0x5E46AC", Offset = "0x5E46AC", VA = "0x5E46AC")]
		public bool UsingDpadHotbar()
		{
			return default(bool);
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x00021F90 File Offset: 0x00020190
		[Token(Token = "0x60047A2")]
		[Address(RVA = "0x5E4C6C", Offset = "0x5E4C6C", VA = "0x5E4C6C")]
		public bool UsingDpadMovekeys()
		{
			return default(bool);
		}

		// Token: 0x04008E15 RID: 36373
		[Token(Token = "0x4008E15")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<InputMode, KeyConfiguration> InputModes;

		// Token: 0x04008E16 RID: 36374
		[Token(Token = "0x4008E16")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		// Token: 0x04008E17 RID: 36375
		[Token(Token = "0x4008E17")]
		[FieldOffset(Offset = "0x10")]
		public bool AllowEditing;

		// Token: 0x04008E18 RID: 36376
		[Token(Token = "0x4008E18")]
		[FieldOffset(Offset = "0x14")]
		public int HotbarRadialHoldTimeRequired;

		// Token: 0x04008E19 RID: 36377
		[Token(Token = "0x4008E19")]
		[FieldOffset(Offset = "0x18")]
		public float TriggersDeadzone;

		// Token: 0x04008E1A RID: 36378
		[Token(Token = "0x4008E1A")]
		[FieldOffset(Offset = "0x1C")]
		public float InterfaceDeadzoneX;

		// Token: 0x04008E1B RID: 36379
		[Token(Token = "0x4008E1B")]
		[FieldOffset(Offset = "0x20")]
		public float LeftThumbstickDeadzoneX;

		// Token: 0x04008E1C RID: 36380
		[Token(Token = "0x4008E1C")]
		[FieldOffset(Offset = "0x24")]
		public float LeftThumbstickDeadzoneY;

		// Token: 0x04008E1D RID: 36381
		[Token(Token = "0x4008E1D")]
		[FieldOffset(Offset = "0x28")]
		public float RightThumbstickDeadzoneX;

		// Token: 0x04008E1E RID: 36382
		[Token(Token = "0x4008E1E")]
		[FieldOffset(Offset = "0x2C")]
		public float RightThumbstickDeadzoneY;

		// Token: 0x04008E1F RID: 36383
		[Token(Token = "0x4008E1F")]
		[FieldOffset(Offset = "0x30")]
		public bool LeftThumbstickInvertX;

		// Token: 0x04008E20 RID: 36384
		[Token(Token = "0x4008E20")]
		[FieldOffset(Offset = "0x31")]
		public bool LeftThumbstickInvertY;

		// Token: 0x04008E21 RID: 36385
		[Token(Token = "0x4008E21")]
		[FieldOffset(Offset = "0x32")]
		public bool RightThumbstickInvertX;

		// Token: 0x04008E22 RID: 36386
		[Token(Token = "0x4008E22")]
		[FieldOffset(Offset = "0x33")]
		public bool RightThumbstickInvertY;

		// Token: 0x04008E23 RID: 36387
		[Token(Token = "0x4008E23")]
		[FieldOffset(Offset = "0x34")]
		public int InventoryMoveCD;

		// Token: 0x04008E24 RID: 36388
		[Token(Token = "0x4008E24")]
		[FieldOffset(Offset = "0x38")]
		public ButtonControlMode PanControl_Keyboard;

		// Token: 0x04008E25 RID: 36389
		[Token(Token = "0x4008E25")]
		[FieldOffset(Offset = "0x3C")]
		public ButtonControlMode PanControl_Gamepad;
	}
}
