using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;

namespace Terraria.UI
{
	// Token: 0x0200082C RID: 2092
	[Token(Token = "0x200082C")]
	public class ItemSlot
	{
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06004830 RID: 18480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008F0")]
		public static float[] inventoryGlowHue
		{
			[Token(Token = "0x6004830")]
			[Address(RVA = "0x5BF418", Offset = "0x5BF418", VA = "0x5BF418")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008F1")]
		public static int[] inventoryGlowTime
		{
			[Token(Token = "0x6004831")]
			[Address(RVA = "0x5BF480", Offset = "0x5BF480", VA = "0x5BF480")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06004832 RID: 18482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008F2")]
		private static float[] inventoryGlowHueChest
		{
			[Token(Token = "0x6004832")]
			[Address(RVA = "0x5BF4E8", Offset = "0x5BF4E8", VA = "0x5BF4E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06004833 RID: 18483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008F3")]
		private static int[] inventoryGlowTimeChest
		{
			[Token(Token = "0x6004833")]
			[Address(RVA = "0x5BF550", Offset = "0x5BF550", VA = "0x5BF550")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008F4")]
		public static ItemSlot.PulseEffect[] playerSlotPulseEffects
		{
			[Token(Token = "0x6004834")]
			[Address(RVA = "0x5BF5B8", Offset = "0x5BF5B8", VA = "0x5BF5B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06004835 RID: 18485 RVA: 0x000225D8 File Offset: 0x000207D8
		// (set) Token: 0x06004836 RID: 18486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F5")]
		private static int _customCurrencyForSavings
		{
			[Token(Token = "0x6004835")]
			[Address(RVA = "0x5BF620", Offset = "0x5BF620", VA = "0x5BF620")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004836")]
			[Address(RVA = "0x5BF688", Offset = "0x5BF688", VA = "0x5BF688")]
			set
			{
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06004838 RID: 18488 RVA: 0x000225F0 File Offset: 0x000207F0
		[Token(Token = "0x170008F6")]
		public static bool AltInUse
		{
			[Token(Token = "0x6004838")]
			[Address(RVA = "0x5C062C", Offset = "0x5C062C", VA = "0x5C062C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x00022608 File Offset: 0x00020808
		[Token(Token = "0x170008F7")]
		public static bool ShiftInUse
		{
			[Token(Token = "0x6004839")]
			[Address(RVA = "0x5C081C", Offset = "0x5C081C", VA = "0x5C081C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x00022620 File Offset: 0x00020820
		[Token(Token = "0x170008F8")]
		public static bool ControlInUse
		{
			[Token(Token = "0x600483A")]
			[Address(RVA = "0x5C0A0C", Offset = "0x5C0A0C", VA = "0x5C0A0C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x0600483B RID: 18491 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600483C RID: 18492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000048")]
		public static event ItemSlot.ItemTransferEvent OnItemTransferred
		{
			[Token(Token = "0x600483B")]
			[Address(RVA = "0x5C0BFC", Offset = "0x5C0BFC", VA = "0x5C0BFC")]
			add
			{
			}
			[Token(Token = "0x600483C")]
			[Address(RVA = "0x5C0D00", Offset = "0x5C0D00", VA = "0x5C0D00")]
			remove
			{
			}
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600483D")]
		[Address(RVA = "0x5C0E04", Offset = "0x5C0E04", VA = "0x5C0E04")]
		public static void AnnounceTransfer(ItemSlot.ItemTransferInfo info)
		{
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600483E")]
		[Address(RVA = "0x5C0ED4", Offset = "0x5C0ED4", VA = "0x5C0ED4")]
		public static void PrepareForChest(InventoryStorage chest)
		{
		}

		// Token: 0x0600483F RID: 18495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600483F")]
		[Address(RVA = "0x5C10C4", Offset = "0x5C10C4", VA = "0x5C10C4")]
		public static void SetGlowForChest(InventoryStorage chest)
		{
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004840")]
		[Address(RVA = "0x5C1214", Offset = "0x5C1214", VA = "0x5C1214")]
		public static void SetGlow(int index, float hue, bool chest)
		{
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004841")]
		[Address(RVA = "0x5C1498", Offset = "0x5C1498", VA = "0x5C1498")]
		public static void UpdateInterface()
		{
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004842")]
		[Address(RVA = "0x5C1CB4", Offset = "0x5C1CB4", VA = "0x5C1CB4")]
		public static void IndicateBlockedSlot(PlayerItemSlotID.SlotReference slot)
		{
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004843")]
		[Address(RVA = "0x5C1D54", Offset = "0x5C1D54", VA = "0x5C1D54")]
		public static void AddPulseEffect(PlayerItemSlotID.SlotReference slot, Color color)
		{
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004844")]
		[Address(RVA = "0x5C1ECC", Offset = "0x5C1ECC", VA = "0x5C1ECC")]
		public static void Handle(ref Item inv, int context = 0)
		{
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x00022638 File Offset: 0x00020838
		[Token(Token = "0x6004845")]
		[Address(RVA = "0x5C2150", Offset = "0x5C2150", VA = "0x5C2150")]
		public static bool HoverOverrideClick(Item inv, int context = 0)
		{
			return default(bool);
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004846")]
		[Address(RVA = "0x5C1FF8", Offset = "0x5C1FF8", VA = "0x5C1FF8")]
		public static void Handle(Item[] inv, int context = 0, int slot = 0)
		{
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004847")]
		[Address(RVA = "0x5C93C4", Offset = "0x5C93C4", VA = "0x5C93C4")]
		public static void OverrideHover(ref Item inv, int context = 0)
		{
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004848")]
		[Address(RVA = "0x5C22E4", Offset = "0x5C22E4", VA = "0x5C22E4")]
		public static void OverrideHover(Item[] inv, int context = 0, int slot = 0)
		{
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x00022650 File Offset: 0x00020850
		[Token(Token = "0x6004849")]
		[Address(RVA = "0x5C2DD4", Offset = "0x5C2DD4", VA = "0x5C2DD4")]
		private static bool OverrideLeftClick(Item[] inv, int context = 0, int slot = 0)
		{
			return default(bool);
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600484A")]
		[Address(RVA = "0x5C94B4", Offset = "0x5C94B4", VA = "0x5C94B4")]
		private static void ToggleFavorited(Item item)
		{
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600484B")]
		[Address(RVA = "0x5C9518", Offset = "0x5C9518", VA = "0x5C9518")]
		private static void ToggleLoadoutShare(Item[] inv, int context, int slot)
		{
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x00022668 File Offset: 0x00020868
		[Token(Token = "0x600484C")]
		[Address(RVA = "0x5C98E8", Offset = "0x5C98E8", VA = "0x5C98E8")]
		public static bool IsMouseItem(Item[] slots, int index)
		{
			return default(bool);
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600484D")]
		[Address(RVA = "0x5C9A1C", Offset = "0x5C9A1C", VA = "0x5C9A1C")]
		public static void LeftClick(ref Item inv, int context = 0)
		{
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600484E")]
		[Address(RVA = "0x5C976C", Offset = "0x5C976C", VA = "0x5C976C")]
		public static void ClearSlotShareInOtherLoadouts(Item[] inv, int context, int slot)
		{
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600484F")]
		[Address(RVA = "0x5C3E7C", Offset = "0x5C3E7C", VA = "0x5C3E7C")]
		public static void LeftClick(Item[] inv, int context = 0, int slot = 0)
		{
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x00022680 File Offset: 0x00020880
		[Token(Token = "0x6004850")]
		[Address(RVA = "0x5CABA8", Offset = "0x5CABA8", VA = "0x5CABA8")]
		private static bool TryResearchingItem(Item[] inv, int slot, bool onlySacrificeIfItWouldFinishResearch = false)
		{
			return default(bool);
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x00022698 File Offset: 0x00020898
		[Token(Token = "0x6004851")]
		[Address(RVA = "0x5C9640", Offset = "0x5C9640", VA = "0x5C9640")]
		private static bool TryResearchingItem(ref Item item, bool onlySacrificeIfItWouldFinishResearch = false)
		{
			return default(bool);
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x000226B0 File Offset: 0x000208B0
		[Token(Token = "0x6004852")]
		[Address(RVA = "0x5CBE5C", Offset = "0x5CBE5C", VA = "0x5CBE5C")]
		private static bool DisableTrashing()
		{
			return default(bool);
		}

		// Token: 0x06004853 RID: 18515 RVA: 0x000226C8 File Offset: 0x000208C8
		[Token(Token = "0x6004853")]
		[Address(RVA = "0x5C9B0C", Offset = "0x5C9B0C", VA = "0x5C9B0C")]
		private static bool LeftClick_SellOrTrash(Item[] inv, int context, int slot)
		{
			return default(bool);
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004854")]
		[Address(RVA = "0x5CBF24", Offset = "0x5CBF24", VA = "0x5CBF24")]
		private static void SellOrTrash(Item[] inv, int context, int slot)
		{
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004855")]
		[Address(RVA = "0x5CC4B8", Offset = "0x5CC4B8", VA = "0x5CC4B8")]
		private static void UpdateChestOnServer(int context, int slot)
		{
		}

		// Token: 0x06004856 RID: 18518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004856")]
		[Address(RVA = "0x5CAC28", Offset = "0x5CAC28", VA = "0x5CAC28")]
		private static void PlaceItem(ref Item[] inv, ref Item item, int context = 0, int slot = -1, int keepStack = 0)
		{
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x000226E0 File Offset: 0x000208E0
		[Token(Token = "0x6004857")]
		[Address(RVA = "0x5C9CE4", Offset = "0x5C9CE4", VA = "0x5C9CE4")]
		public static int PickItemMovementAction(Item[] inv, int context, int slot, Item checkItem, bool backwardCheck = false, int initialSlot = -1)
		{
			return 0;
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004858")]
		[Address(RVA = "0x5CCBB8", Offset = "0x5CCBB8", VA = "0x5CCBB8")]
		public static void RightClick(ref Item inv, int context = 0)
		{
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x000226F8 File Offset: 0x000208F8
		[Token(Token = "0x6004859")]
		[Address(RVA = "0x5C7F94", Offset = "0x5C7F94", VA = "0x5C7F94")]
		public static bool RightClick(Item[] inv, int context = 0, int slot = 0)
		{
			return default(bool);
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600485A")]
		[Address(RVA = "0x5CF1DC", Offset = "0x5CF1DC", VA = "0x5CF1DC")]
		public static void TakeOne(Item[] inv, int context, int slot)
		{
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600485B")]
		[Address(RVA = "0x5CE734", Offset = "0x5CE734", VA = "0x5CE734")]
		public static void PickupItemIntoMouse(Item[] inv, int context, int slot, Player player)
		{
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600485C")]
		[Address(RVA = "0x5CF13C", Offset = "0x5CF13C", VA = "0x5CF13C")]
		public static void RefreshStackSplitCooldown()
		{
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x00022710 File Offset: 0x00020910
		[Token(Token = "0x600485D")]
		[Address(RVA = "0x5CD164", Offset = "0x5CD164", VA = "0x5CD164")]
		private static bool TryOpenContainer(Item[] inv, int context, int slot, Player player)
		{
			return default(bool);
		}

		// Token: 0x0600485E RID: 18526 RVA: 0x00022728 File Offset: 0x00020928
		[Token(Token = "0x600485E")]
		[Address(RVA = "0x5CF428", Offset = "0x5CF428", VA = "0x5CF428")]
		private static bool TryOpenContainer_GrantItems(Item item, Player player)
		{
			return default(bool);
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x00022740 File Offset: 0x00020940
		[Token(Token = "0x600485F")]
		[Address(RVA = "0x5CD38C", Offset = "0x5CD38C", VA = "0x5CD38C")]
		private static bool SwapVanityEquip(Item[] inv, int context, int slot, Player player)
		{
			return default(bool);
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x00022758 File Offset: 0x00020958
		[Token(Token = "0x6004860")]
		[Address(RVA = "0x5CD8BC", Offset = "0x5CD8BC", VA = "0x5CD8BC")]
		private static bool TryPickupDyeToCursor(int context, Item[] inv, int slot, Player player)
		{
			return default(bool);
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x00022770 File Offset: 0x00020970
		[Token(Token = "0x6004861")]
		[Address(RVA = "0x5CCCA8", Offset = "0x5CCCA8", VA = "0x5CCCA8")]
		public static bool TryItemSwap(Item item)
		{
			return default(bool);
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004862")]
		[Address(RVA = "0x5CF75C", Offset = "0x5CF75C", VA = "0x5CF75C")]
		public static void AfterItemSwap(int oldType, int newType)
		{
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004863")]
		public static void HandleItemPickupAction<TItemInfo>(ItemSlot.ItemPickupAction<TItemInfo> action, TItemInfo entry, int slotItemType, int slotItemStack, ref int stackLimiter)
		{
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004864")]
		[Address(RVA = "0x5CB75C", Offset = "0x5CB75C", VA = "0x5CB75C")]
		private static void HandleShopSlot(Item[] inv, int slot, bool rightClickIsValid, bool leftClickIsValid)
		{
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004865")]
		[Address(RVA = "0x5CF9DC", Offset = "0x5CF9DC", VA = "0x5CF9DC")]
		public static void Draw(SpriteBatch spriteBatch, ref Item inv, int context, Vector2 position)
		{
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004866")]
		[Address(RVA = "0x5CFAAC", Offset = "0x5CFAAC", VA = "0x5CFAAC")]
		public static void Draw(SpriteBatch spriteBatch, ref Item inv, int context, Vector2 position, Color lightColor)
		{
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004867")]
		[Address(RVA = "0x5CFD28", Offset = "0x5CFD28", VA = "0x5CFD28")]
		public static void SetCursorHighlight(bool hasFocus)
		{
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004868")]
		[Address(RVA = "0x5CFD90", Offset = "0x5CFD90", VA = "0x5CFD90")]
		public static void SetSelectHighlight(bool hasFocus, float highlightScale = -1f)
		{
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004869")]
		[Address(RVA = "0x5CFE0C", Offset = "0x5CFE0C", VA = "0x5CFE0C")]
		public static void SetHighlightScaleAnimation(bool highlightScale)
		{
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486A")]
		[Address(RVA = "0x5CFE74", Offset = "0x5CFE74", VA = "0x5CFE74")]
		public static void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Vector2 position)
		{
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486B")]
		[Address(RVA = "0x5CFC54", Offset = "0x5CFC54", VA = "0x5CFC54")]
		public static void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Vector2 position, Color lightColor)
		{
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486C")]
		[Address(RVA = "0x5D75C4", Offset = "0x5D75C4", VA = "0x5D75C4")]
		public static void GetDimSlotForMouseItem(int context, int slot, Item checkItem, out float itemFade)
		{
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x00022788 File Offset: 0x00020988
		[Token(Token = "0x600486D")]
		[Address(RVA = "0x5D7C94", Offset = "0x5D7C94", VA = "0x5D7C94")]
		public static bool CanEquipInArmorSlot(Player player, Item checkItem, int slot)
		{
			return default(bool);
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x000227A0 File Offset: 0x000209A0
		[Token(Token = "0x600486E")]
		[Address(RVA = "0x5D8738", Offset = "0x5D8738", VA = "0x5D8738")]
		public static bool ShouldHighlightSlotForMouseItem(int context, int slot, Item checkItem)
		{
			return default(bool);
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x000227B8 File Offset: 0x000209B8
		[Token(Token = "0x600486F")]
		[Address(RVA = "0x5CC688", Offset = "0x5CC688", VA = "0x5CC688")]
		public static bool CanEquipAccessoryInSlot(Item checkItem, int slot)
		{
			return default(bool);
		}

		// Token: 0x06004870 RID: 18544 RVA: 0x000227D0 File Offset: 0x000209D0
		[Token(Token = "0x6004870")]
		[Address(RVA = "0x5CC97C", Offset = "0x5CC97C", VA = "0x5CC97C")]
		public static bool CanEquipAccessoryInVanitySlot(Item checkItem, int slot)
		{
			return default(bool);
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004871")]
		[Address(RVA = "0x5CFFD8", Offset = "0x5CFFD8", VA = "0x5CFFD8")]
		public static void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Vector2 position, Color lightColor, Color backColor)
		{
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x000227E8 File Offset: 0x000209E8
		[Token(Token = "0x6004872")]
		[Address(RVA = "0x5D8EE0", Offset = "0x5D8EE0", VA = "0x5D8EE0")]
		public static Color GetColorByLoadout(int slot, int context)
		{
			return default(Color);
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x00022800 File Offset: 0x00020A00
		[Token(Token = "0x6004873")]
		[Address(RVA = "0x5D9270", Offset = "0x5D9270", VA = "0x5D9270")]
		public static Color GetHighlightColorByLoadout(int slot, int context)
		{
			return default(Color);
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004874")]
		[Address(RVA = "0x5DAF10", Offset = "0x5DAF10", VA = "0x5DAF10")]
		public static void RecordLoadoutChange()
		{
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x00022818 File Offset: 0x00020A18
		[Token(Token = "0x6004875")]
		[Address(RVA = "0x5D9500", Offset = "0x5D9500", VA = "0x5D9500")]
		public static bool TryGetSlotColor(int loadoutIndex, int context, out Color color)
		{
			return default(bool);
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x00022830 File Offset: 0x00020A30
		[Token(Token = "0x6004876")]
		[Address(RVA = "0x5DAE4C", Offset = "0x5DAE4C", VA = "0x5DAE4C")]
		public static bool TryGetHighlightedSlotColor(int loadoutIndex, int context, out Color color)
		{
			return default(bool);
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x00022848 File Offset: 0x00020A48
		[Token(Token = "0x6004877")]
		[Address(RVA = "0x5DAFBC", Offset = "0x5DAFBC", VA = "0x5DAFBC")]
		public static float ShiftHueByLoadout(float hue, int loadoutIndex)
		{
			return 0f;
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x00022860 File Offset: 0x00020A60
		[Token(Token = "0x6004878")]
		[Address(RVA = "0x5DAFDC", Offset = "0x5DAFDC", VA = "0x5DAFDC")]
		public static Color GetLoadoutColor(int loadoutIndex)
		{
			return default(Color);
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004879")]
		[Address(RVA = "0x5D95C4", Offset = "0x5D95C4", VA = "0x5D95C4")]
		public static Item GetSharedLoadoutItem(int context, int slot, out int? sharedFromLoadout)
		{
			return null;
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x00022878 File Offset: 0x00020A78
		[Token(Token = "0x600487A")]
		[Address(RVA = "0x5D9664", Offset = "0x5D9664", VA = "0x5D9664")]
		public static float DrawItemIcon(Item item, int context, SpriteBatch spriteBatch, Vector2 screenPositionForItemCenter, float scale, float sizeLimit, Color environmentColor, float itemFade = 1f, bool flip = false)
		{
			return 0f;
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x00022890 File Offset: 0x00020A90
		[Token(Token = "0x600487B")]
		[Address(RVA = "0x5DB240", Offset = "0x5DB240", VA = "0x5DB240")]
		public static Color GetTrustyPalGlowColor()
		{
			return default(Color);
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487C")]
		[Address(RVA = "0x5DB3CC", Offset = "0x5DB3CC", VA = "0x5DB3CC")]
		public static void DrawItemIconSlotExtras(SpriteBatch spriteBatch, Item item, ref Rectangle frame, Vector2 screenPositionForItemCenter, float drawScale, Color environmentColor, float itemFade = 1f)
		{
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487D")]
		[Address(RVA = "0x5DB0B8", Offset = "0x5DB0B8", VA = "0x5DB0B8")]
		public static void DrawItem_GetColorAndScale(Item item, float scale, ref Color currentWhite, float sizeLimit, ref Rectangle frame, out Color itemLight, out float finalDrawScale)
		{
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487E")]
		[Address(RVA = "0x5DC37C", Offset = "0x5DC37C", VA = "0x5DC37C")]
		public static void MouseHover(int context = 0)
		{
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487F")]
		[Address(RVA = "0x5DC484", Offset = "0x5DC484", VA = "0x5DC484")]
		public static void MouseHover(ref Item inv, int context = 0)
		{
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004880")]
		[Address(RVA = "0x5DC574", Offset = "0x5DC574", VA = "0x5DC574")]
		public static void UpdateTooltipButton(TransactionButton_Layout button)
		{
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004881")]
		[Address(RVA = "0x5DC7CC", Offset = "0x5DC7CC", VA = "0x5DC7CC")]
		public static void UpdateTooltipContext(int context, int slot)
		{
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004882")]
		[Address(RVA = "0x5C8728", Offset = "0x5C8728", VA = "0x5C8728")]
		public static void MouseHover(Item[] inv, int context = 0, int slot = 0)
		{
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004883")]
		[Address(RVA = "0x5DCA24", Offset = "0x5DCA24", VA = "0x5DCA24")]
		public static void ResetInventoryStateCounters()
		{
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004884")]
		[Address(RVA = "0x5DCA8C", Offset = "0x5DCA8C", VA = "0x5DCA8C")]
		public static void SwapEquip(ref Item inv, int context = 0)
		{
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x000228A8 File Offset: 0x00020AA8
		[Token(Token = "0x6004885")]
		[Address(RVA = "0x5CDD70", Offset = "0x5CDD70", VA = "0x5CDD70")]
		public static bool SwapEquip(Item[] inv, int context, int slot)
		{
			return default(bool);
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x000228C0 File Offset: 0x00020AC0
		[Token(Token = "0x6004886")]
		[Address(RVA = "0x5DD7CC", Offset = "0x5DD7CC", VA = "0x5DD7CC")]
		private static Vector2 GetTransferPosition(int context, int slot)
		{
			return default(Vector2);
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004887")]
		[Address(RVA = "0x5C9768", Offset = "0x5C9768", VA = "0x5C9768")]
		public static void DisplayTransfer_GetItem(Item[] arrayFrom, int fromContext, int fromSlot)
		{
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x000228D8 File Offset: 0x00020AD8
		[Token(Token = "0x6004888")]
		[Address(RVA = "0x5DD884", Offset = "0x5DD884", VA = "0x5DD884")]
		private static int GetTimeToAnimate(Vector2 startPosition, Vector2 endPosition)
		{
			return 0;
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004889")]
		[Address(RVA = "0x5DD950", Offset = "0x5DD950", VA = "0x5DD950")]
		public static void DisplayTransfer_OneWay(Item[] arrayFrom, int fromContext, int fromSlot, Item[] arrayTo, int toContext, int toSlot, int stackSize = 1)
		{
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600488A")]
		[Address(RVA = "0x5DD954", Offset = "0x5DD954", VA = "0x5DD954")]
		public static void DisplayTransfer_TwoWay(Item[] arrayFrom, int fromContext, int fromSlot, Item toItem, int toContext)
		{
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600488B")]
		[Address(RVA = "0x5DCED4", Offset = "0x5DCED4", VA = "0x5DCED4")]
		public static void DisplayTransfer_TwoWay(Item[] arrayFrom, int fromContext, int fromSlot, Item[] arrayTo, int toContext, int toSlot)
		{
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600488C")]
		[Address(RVA = "0x5DD958", Offset = "0x5DD958", VA = "0x5DD958")]
		private static void AddCooldown(int context, int slot, int time)
		{
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x000228F0 File Offset: 0x00020AF0
		[Token(Token = "0x600488D")]
		[Address(RVA = "0x5DDA5C", Offset = "0x5DDA5C", VA = "0x5DDA5C")]
		private static bool TryDisplayTransfer(ref Vector2 pointPositionFrom, ref Vector2 pointPositionTo, Item toItem, int stackSize, int animationTime)
		{
			return default(bool);
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x00022908 File Offset: 0x00020B08
		[Token(Token = "0x600488E")]
		[Address(RVA = "0x5DDA64", Offset = "0x5DDA64", VA = "0x5DDA64")]
		public static bool CanEquipBothAccessories(Item acc1, Item acc2, bool vanity)
		{
			return default(bool);
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x00022920 File Offset: 0x00020B20
		[Token(Token = "0x600488F")]
		[Address(RVA = "0x5DDBC8", Offset = "0x5DDBC8", VA = "0x5DDBC8")]
		public static bool HasIncompatibleAccessory(Item newAcc, bool vanity, ArraySegment<Item> accessories, out int collisionSlot)
		{
			return default(bool);
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x00022938 File Offset: 0x00020B38
		[Token(Token = "0x6004890")]
		[Address(RVA = "0x5D8594", Offset = "0x5D8594", VA = "0x5D8594")]
		public static ArraySegment<Item> ArmorSlots(Player player)
		{
			return default(ArraySegment<Item>);
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x00022950 File Offset: 0x00020B50
		[Token(Token = "0x6004891")]
		[Address(RVA = "0x5D8620", Offset = "0x5D8620", VA = "0x5D8620")]
		public static ArraySegment<Item> AccSlots(Player player)
		{
			return default(ArraySegment<Item>);
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x00022968 File Offset: 0x00020B68
		[Token(Token = "0x6004892")]
		[Address(RVA = "0x5D82F4", Offset = "0x5D82F4", VA = "0x5D82F4")]
		public static ArraySegment<Item> VanityArmorSlots(Player player)
		{
			return default(ArraySegment<Item>);
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x00022980 File Offset: 0x00020B80
		[Token(Token = "0x6004893")]
		[Address(RVA = "0x5D86AC", Offset = "0x5D86AC", VA = "0x5D86AC")]
		public static ArraySegment<Item> VanityAccSlots(Player player)
		{
			return default(ArraySegment<Item>);
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x00022998 File Offset: 0x00020B98
		[Token(Token = "0x6004894")]
		[Address(RVA = "0x5D8380", Offset = "0x5D8380", VA = "0x5D8380")]
		public static bool HasSameItemInSlot(Item newItem, ArraySegment<Item> items)
		{
			return default(bool);
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x000229B0 File Offset: 0x00020BB0
		[Token(Token = "0x6004895")]
		[Address(RVA = "0x5CC8C4", Offset = "0x5CC8C4", VA = "0x5CC8C4")]
		public static bool CanEquipAccessoryInSlot(Item newAcc, bool vanity, ArraySegment<Item> accessories, int slot)
		{
			return default(bool);
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004896")]
		[Address(RVA = "0x5DCB7C", Offset = "0x5DCB7C", VA = "0x5DCB7C")]
		private static Item DyeSwap(Item item, out bool success, out int targetSlot)
		{
			return null;
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004897")]
		[Address(RVA = "0x5DD06C", Offset = "0x5DD06C", VA = "0x5DD06C")]
		private static Item ArmorSwap(Item item, out bool success, out int targetSlot)
		{
			return null;
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004898")]
		[Address(RVA = "0x5DCED8", Offset = "0x5DCED8", VA = "0x5DCED8")]
		private static Item EquipSwap(Item item, Item[] inv, int slot, out bool success)
		{
			return null;
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004899")]
		[Address(RVA = "0x5DDD44", Offset = "0x5DDD44", VA = "0x5DDD44")]
		public static void DrawMoney(SpriteBatch sb, string text, float shopx, float shopy, int[] coinsArray, bool horizontal = false, bool fromSavings = false, [Optional] SpriteBatch textSb)
		{
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489A")]
		[Address(RVA = "0x5DE674", Offset = "0x5DE674", VA = "0x5DE674")]
		public static void DrawCost(SpriteBatch sb, float shopx, float shopy, long cost, [Optional] SpriteBatch textSb)
		{
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489B")]
		[Address(RVA = "0x5DE780", Offset = "0x5DE780", VA = "0x5DE780")]
		public static void DrawSavings(SpriteBatch sb, Panel_Layout savingsBacking, float shopx, float shopy, Vector2 savings1IconOffset, Vector2 savings2Offset, Vector2 savings3Offset, Vector2 savings4Offset, bool horizontal = false, [Optional] SpriteBatch textSb)
		{
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489C")]
		[Address(RVA = "0x5DF5A4", Offset = "0x5DF5A4", VA = "0x5DF5A4")]
		public static void GetItemLight(ref Color currentColor, Item item, bool outInTheWorld = false, float lightScalar = 1f)
		{
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489D")]
		[Address(RVA = "0x5DF690", Offset = "0x5DF690", VA = "0x5DF690")]
		public static void GetItemLight(ref Color currentColor, int type, bool outInTheWorld = false, float lightScalar = 1f)
		{
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489E")]
		[Address(RVA = "0x5DC2DC", Offset = "0x5DC2DC", VA = "0x5DC2DC")]
		public static void GetItemLight(ref Color currentColor, ref float scale, Item item, bool outInTheWorld = false, float lightScalar = 1f)
		{
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x000229C8 File Offset: 0x00020BC8
		[Token(Token = "0x600489F")]
		[Address(RVA = "0x5DF728", Offset = "0x5DF728", VA = "0x5DF728")]
		public static Color GetItemLight(ref Color currentColor, ref float scale, int type, bool outInTheWorld = false, float lightScalar = 1f)
		{
			return default(Color);
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A0")]
		[Address(RVA = "0x5DFB30", Offset = "0x5DFB30", VA = "0x5DFB30")]
		public static void DrawRadialCircular(SpriteBatch sb, Vector2 position, Player.SelectionRadial radial, Item[] items)
		{
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A1")]
		[Address(RVA = "0x5E023C", Offset = "0x5E023C", VA = "0x5E023C")]
		public static void DrawRadialQuicks(SpriteBatch sb, Vector2 position)
		{
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A2")]
		[Address(RVA = "0x5E0CA0", Offset = "0x5E0CA0", VA = "0x5E0CA0")]
		public static void DrawRadialDpad(SpriteBatch sb, Vector2 position)
		{
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x000229E0 File Offset: 0x00020BE0
		[Token(Token = "0x60048A3")]
		[Address(RVA = "0x5E12CC", Offset = "0x5E12CC", VA = "0x5E12CC")]
		public static bool IsABuildingItem(Item item)
		{
			return default(bool);
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A4")]
		[Address(RVA = "0x5E131C", Offset = "0x5E131C", VA = "0x5E131C")]
		public static void SelectEquipPage(Item item)
		{
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A5")]
		[Address(RVA = "0x5E1564", Offset = "0x5E1564", VA = "0x5E1564")]
		public ItemSlot()
		{
		}

		// Token: 0x04008E6F RID: 36463
		[Token(Token = "0x4008E6F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DrawGoldBGForCraftingMaterial;

		// Token: 0x04008E70 RID: 36464
		[Token(Token = "0x4008E70")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool ShiftForcedOn;

		// Token: 0x04008E71 RID: 36465
		[Token(Token = "0x4008E71")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int additionalThrowVelocity;

		// Token: 0x04008E72 RID: 36466
		[Token(Token = "0x4008E72")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool DuplicationMode;

		// Token: 0x04008E73 RID: 36467
		[Token(Token = "0x4008E73")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static int dyeSlotCount;

		// Token: 0x04008E74 RID: 36468
		[Token(Token = "0x4008E74")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int accSlotToSwapTo;

		// Token: 0x04008E75 RID: 36469
		[Token(Token = "0x4008E75")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float CircularRadialOpacity;

		// Token: 0x04008E76 RID: 36470
		[Token(Token = "0x4008E76")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static float QuicksRadialOpacity;

		// Token: 0x04008E77 RID: 36471
		[Token(Token = "0x4008E77")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static Dictionary<ItemSlot.ItemDisplayKey, ulong> _nextTickDrawAvailable;

		// Token: 0x04008E78 RID: 36472
		[Token(Token = "0x4008E78")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Item[] singleSlotArray;

		// Token: 0x04008E79 RID: 36473
		[Token(Token = "0x4008E79")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static bool[] canFavoriteAt;

		// Token: 0x04008E7A RID: 36474
		[Token(Token = "0x4008E7A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static bool[] canShareAt;

		// Token: 0x04008E7B RID: 36475
		[Token(Token = "0x4008E7B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static bool[] retainFavoriteOnClickAt;

		// Token: 0x04008E7C RID: 36476
		[Token(Token = "0x4008E7C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static bool[] canLoadoutShareAt;

		// Token: 0x04008E7E RID: 36478
		[Token(Token = "0x4008E7E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static bool forceClearGlowsOnChest;

		// Token: 0x04008E7F RID: 36479
		[Token(Token = "0x4008E7F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static Item dummyItem;

		// Token: 0x04008E80 RID: 36480
		[Token(Token = "0x4008E80")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static bool CursorHighlight;

		// Token: 0x04008E81 RID: 36481
		[Token(Token = "0x4008E81")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private static bool SelectHighlight;

		// Token: 0x04008E82 RID: 36482
		[Token(Token = "0x4008E82")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static float HighlightScale;

		// Token: 0x04008E83 RID: 36483
		[Token(Token = "0x4008E83")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static bool HighlightAnimationScale;

		// Token: 0x04008E84 RID: 36484
		[Token(Token = "0x4008E84")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static double _lastTimeForVisualEffectsThatLoadoutWasChanged;

		// Token: 0x04008E85 RID: 36485
		[Token(Token = "0x4008E85")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static Color[,] LoadoutSlotColors;

		// Token: 0x04008E86 RID: 36486
		[Token(Token = "0x4008E86")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private static Color[,] LoadoutHighlightSlotColors;

		// Token: 0x04008E87 RID: 36487
		[Token(Token = "0x4008E87")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static float OverdrawGlowSize;

		// Token: 0x04008E88 RID: 36488
		[Token(Token = "0x4008E88")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static Color OverdrawGlowColorMultiplier;

		// Token: 0x04008E89 RID: 36489
		[Token(Token = "0x4008E89")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static int LastHoverContext;

		// Token: 0x04008E8A RID: 36490
		[Token(Token = "0x4008E8A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private static int LastHoverSlot;

		// Token: 0x04008E8B RID: 36491
		[Token(Token = "0x4008E8B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static TransactionButton_Layout LastHoverButton;

		// Token: 0x04008E8C RID: 36492
		[Token(Token = "0x4008E8C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private static int LastButtonFrame;

		// Token: 0x04008E8D RID: 36493
		[Token(Token = "0x4008E8D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static int dyeSwapCounter;

		// Token: 0x04008E8E RID: 36494
		[Token(Token = "0x4008E8E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private static Item[] _dirtyHack;

		// Token: 0x04008E8F RID: 36495
		[Token(Token = "0x4008E8F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static Vector2 defenderTextOffset;

		// Token: 0x04008E90 RID: 36496
		[Token(Token = "0x4008E90")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static Vector2 defenderPigOffset;

		// Token: 0x0200082D RID: 2093
		[Token(Token = "0x200082D")]
		public class Options
		{
			// Token: 0x170008F9 RID: 2297
			// (get) Token: 0x060048A6 RID: 18598 RVA: 0x000229F8 File Offset: 0x00020BF8
			// (set) Token: 0x060048A7 RID: 18599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008F9")]
			public static bool DisableLeftShiftTrashCan
			{
				[Token(Token = "0x60048A6")]
				[Address(RVA = "0x5E8128", Offset = "0x5E8128", VA = "0x5E8128")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60048A7")]
				[Address(RVA = "0x5E8190", Offset = "0x5E8190", VA = "0x5E8190")]
				set
				{
				}
			}

			// Token: 0x170008FA RID: 2298
			// (get) Token: 0x060048A8 RID: 18600 RVA: 0x00022A10 File Offset: 0x00020C10
			// (set) Token: 0x060048A9 RID: 18601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008FA")]
			public static bool HighlightNewItems
			{
				[Token(Token = "0x60048A8")]
				[Address(RVA = "0x5E81FC", Offset = "0x5E81FC", VA = "0x5E81FC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60048A9")]
				[Address(RVA = "0x5E8264", Offset = "0x5E8264", VA = "0x5E8264")]
				set
				{
				}
			}

			// Token: 0x170008FB RID: 2299
			// (get) Token: 0x060048AA RID: 18602 RVA: 0x00022A28 File Offset: 0x00020C28
			// (set) Token: 0x060048AB RID: 18603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170008FB")]
			public static bool DisableQuickTrash
			{
				[Token(Token = "0x60048AA")]
				[Address(RVA = "0x5E82D0", Offset = "0x5E82D0", VA = "0x5E82D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60048AB")]
				[Address(RVA = "0x5E8338", Offset = "0x5E8338", VA = "0x5E8338")]
				set
				{
				}
			}

			// Token: 0x060048AC RID: 18604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60048AC")]
			[Address(RVA = "0x5E83A4", Offset = "0x5E83A4", VA = "0x5E83A4")]
			public Options()
			{
			}
		}

		// Token: 0x0200082E RID: 2094
		[Token(Token = "0x200082E")]
		public struct PulseEffect
		{
			// Token: 0x060048AD RID: 18605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60048AD")]
			[Address(RVA = "0x5E83AC", Offset = "0x5E83AC", VA = "0x5E83AC")]
			public PulseEffect(PlayerItemSlotID.SlotReference slotRef, Color color)
			{
			}

			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x060048AE RID: 18606 RVA: 0x00022A40 File Offset: 0x00020C40
			[Token(Token = "0x170008FC")]
			public bool IsActive
			{
				[Token(Token = "0x60048AE")]
				[Address(RVA = "0x5E83E8", Offset = "0x5E83E8", VA = "0x5E83E8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04008E91 RID: 36497
			[Token(Token = "0x4008E91")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int EffectDuration;

			// Token: 0x04008E92 RID: 36498
			[Token(Token = "0x4008E92")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int NumPulses;

			// Token: 0x04008E93 RID: 36499
			[Token(Token = "0x4008E93")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly Color color;

			// Token: 0x04008E94 RID: 36500
			[Token(Token = "0x4008E94")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public readonly PlayerItemSlotID.SlotReference slotRef;

			// Token: 0x04008E95 RID: 36501
			[Token(Token = "0x4008E95")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public readonly Item itemInSlot;

			// Token: 0x04008E96 RID: 36502
			[Token(Token = "0x4008E96")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int time;
		}

		// Token: 0x0200082F RID: 2095
		[Token(Token = "0x200082F")]
		public enum GUIFakeTooltipContext
		{
			// Token: 0x04008E98 RID: 36504
			[Token(Token = "0x4008E98")]
			DefenseIcon = 49,
			// Token: 0x04008E99 RID: 36505
			[Token(Token = "0x4008E99")]
			HousingMenu,
			// Token: 0x04008E9A RID: 36506
			[Token(Token = "0x4008E9A")]
			PVPMenu,
			// Token: 0x04008E9B RID: 36507
			[Token(Token = "0x4008E9B")]
			ItemDuplication,
			// Token: 0x04008E9C RID: 36508
			[Token(Token = "0x4008E9C")]
			CraftGuide,
			// Token: 0x04008E9D RID: 36509
			[Token(Token = "0x4008E9D")]
			BestiaryDrop,
			// Token: 0x04008E9E RID: 36510
			[Token(Token = "0x4008E9E")]
			Reforge,
			// Token: 0x04008E9F RID: 36511
			[Token(Token = "0x4008E9F")]
			Team,
			// Token: 0x04008EA0 RID: 36512
			[Token(Token = "0x4008EA0")]
			AccessoryInfo,
			// Token: 0x04008EA1 RID: 36513
			[Token(Token = "0x4008EA1")]
			BuilderAccessories,
			// Token: 0x04008EA2 RID: 36514
			[Token(Token = "0x4008EA2")]
			Hotbar,
			// Token: 0x04008EA3 RID: 36515
			[Token(Token = "0x4008EA3")]
			Buffs,
			// Token: 0x04008EA4 RID: 36516
			[Token(Token = "0x4008EA4")]
			Loadout
		}

		// Token: 0x02000830 RID: 2096
		[Token(Token = "0x2000830")]
		public class Context
		{
			// Token: 0x060048B0 RID: 18608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60048B0")]
			[Address(RVA = "0x5E8454", Offset = "0x5E8454", VA = "0x5E8454")]
			public Context()
			{
			}

			// Token: 0x04008EA5 RID: 36517
			[Token(Token = "0x4008EA5")]
			public const int InventoryItem = 0;

			// Token: 0x04008EA6 RID: 36518
			[Token(Token = "0x4008EA6")]
			public const int InventoryCoin = 1;

			// Token: 0x04008EA7 RID: 36519
			[Token(Token = "0x4008EA7")]
			public const int InventoryAmmo = 2;

			// Token: 0x04008EA8 RID: 36520
			[Token(Token = "0x4008EA8")]
			public const int ChestItem = 3;

			// Token: 0x04008EA9 RID: 36521
			[Token(Token = "0x4008EA9")]
			public const int BankItem = 4;

			// Token: 0x04008EAA RID: 36522
			[Token(Token = "0x4008EAA")]
			public const int PrefixItem = 5;

			// Token: 0x04008EAB RID: 36523
			[Token(Token = "0x4008EAB")]
			public const int TrashItem = 6;

			// Token: 0x04008EAC RID: 36524
			[Token(Token = "0x4008EAC")]
			public const int GuideItem = 7;

			// Token: 0x04008EAD RID: 36525
			[Token(Token = "0x4008EAD")]
			public const int EquipArmor = 8;

			// Token: 0x04008EAE RID: 36526
			[Token(Token = "0x4008EAE")]
			public const int EquipArmorVanity = 9;

			// Token: 0x04008EAF RID: 36527
			[Token(Token = "0x4008EAF")]
			public const int EquipAccessory = 10;

			// Token: 0x04008EB0 RID: 36528
			[Token(Token = "0x4008EB0")]
			public const int EquipAccessoryVanity = 11;

			// Token: 0x04008EB1 RID: 36529
			[Token(Token = "0x4008EB1")]
			public const int EquipDye = 12;

			// Token: 0x04008EB2 RID: 36530
			[Token(Token = "0x4008EB2")]
			public const int HotbarItem = 13;

			// Token: 0x04008EB3 RID: 36531
			[Token(Token = "0x4008EB3")]
			public const int ChatItem = 14;

			// Token: 0x04008EB4 RID: 36532
			[Token(Token = "0x4008EB4")]
			public const int ShopItem = 15;

			// Token: 0x04008EB5 RID: 36533
			[Token(Token = "0x4008EB5")]
			public const int EquipGrapple = 16;

			// Token: 0x04008EB6 RID: 36534
			[Token(Token = "0x4008EB6")]
			public const int EquipMount = 17;

			// Token: 0x04008EB7 RID: 36535
			[Token(Token = "0x4008EB7")]
			public const int EquipMinecart = 18;

			// Token: 0x04008EB8 RID: 36536
			[Token(Token = "0x4008EB8")]
			public const int EquipPet = 19;

			// Token: 0x04008EB9 RID: 36537
			[Token(Token = "0x4008EB9")]
			public const int EquipLight = 20;

			// Token: 0x04008EBA RID: 36538
			[Token(Token = "0x4008EBA")]
			public const int MouseItem = 21;

			// Token: 0x04008EBB RID: 36539
			[Token(Token = "0x4008EBB")]
			public const int CraftingMaterial = 22;

			// Token: 0x04008EBC RID: 36540
			[Token(Token = "0x4008EBC")]
			public const int DisplayDollArmor = 23;

			// Token: 0x04008EBD RID: 36541
			[Token(Token = "0x4008EBD")]
			public const int DisplayDollAccessory = 24;

			// Token: 0x04008EBE RID: 36542
			[Token(Token = "0x4008EBE")]
			public const int DisplayDollDye = 25;

			// Token: 0x04008EBF RID: 36543
			[Token(Token = "0x4008EBF")]
			public const int HatRackHat = 26;

			// Token: 0x04008EC0 RID: 36544
			[Token(Token = "0x4008EC0")]
			public const int HatRackDye = 27;

			// Token: 0x04008EC1 RID: 36545
			[Token(Token = "0x4008EC1")]
			public const int GoldDebug = 28;

			// Token: 0x04008EC2 RID: 36546
			[Token(Token = "0x4008EC2")]
			public const int CreativeInfinite = 29;

			// Token: 0x04008EC3 RID: 36547
			[Token(Token = "0x4008EC3")]
			public const int CreativeSacrifice = 30;

			// Token: 0x04008EC4 RID: 36548
			[Token(Token = "0x4008EC4")]
			public const int InWorld = 31;

			// Token: 0x04008EC5 RID: 36549
			[Token(Token = "0x4008EC5")]
			public const int VoidItem = 32;

			// Token: 0x04008EC6 RID: 36550
			[Token(Token = "0x4008EC6")]
			public const int EquipMiscDye = 33;

			// Token: 0x04008EC7 RID: 36551
			[Token(Token = "0x4008EC7")]
			public const int CreativeInfiniteLocked = 34;

			// Token: 0x04008EC8 RID: 36552
			[Token(Token = "0x4008EC8")]
			public const int BannerClaiming = 35;

			// Token: 0x04008EC9 RID: 36553
			[Token(Token = "0x4008EC9")]
			public const int HotbarItemSmartSelected = 36;

			// Token: 0x04008ECA RID: 36554
			[Token(Token = "0x4008ECA")]
			public const int OverdrawGlow = 37;

			// Token: 0x04008ECB RID: 36555
			[Token(Token = "0x4008ECB")]
			public const int DisplayDollWeapon = 38;

			// Token: 0x04008ECC RID: 36556
			[Token(Token = "0x4008ECC")]
			public const int DisplayDollMount = 39;

			// Token: 0x04008ECD RID: 36557
			[Token(Token = "0x4008ECD")]
			public const int InWorldDisplay = 40;

			// Token: 0x04008ECE RID: 36558
			[Token(Token = "0x4008ECE")]
			public const int NewCraftingUIRecipe = 41;

			// Token: 0x04008ECF RID: 36559
			[Token(Token = "0x4008ECF")]
			public const int NewCraftingUICraftSlot = 42;

			// Token: 0x04008ED0 RID: 36560
			[Token(Token = "0x4008ED0")]
			public const int NewCraftingUIMaterial = 43;

			// Token: 0x04008ED1 RID: 36561
			[Token(Token = "0x4008ED1")]
			public const int CreativeResearch = 44;

			// Token: 0x04008ED2 RID: 36562
			[Token(Token = "0x4008ED2")]
			public const int RubbleMaker = 45;

			// Token: 0x04008ED3 RID: 36563
			[Token(Token = "0x4008ED3")]
			public const int RubbleMakerFilter = 46;

			// Token: 0x04008ED4 RID: 36564
			[Token(Token = "0x4008ED4")]
			public const int CraftingStationMaterial = 47;

			// Token: 0x04008ED5 RID: 36565
			[Token(Token = "0x4008ED5")]
			public const int CraftingGuideMaterial = 48;

			// Token: 0x04008ED6 RID: 36566
			[Token(Token = "0x4008ED6")]
			public const int Count = 49;
		}

		// Token: 0x02000831 RID: 2097
		[Token(Token = "0x2000831")]
		public struct ItemDisplayKey
		{
			// Token: 0x060048B1 RID: 18609 RVA: 0x00022A58 File Offset: 0x00020C58
			[Token(Token = "0x60048B1")]
			[Address(RVA = "0x5E845C", Offset = "0x5E845C", VA = "0x5E845C")]
			public bool Equals(ItemSlot.ItemDisplayKey other)
			{
				return default(bool);
			}

			// Token: 0x060048B2 RID: 18610 RVA: 0x00022A70 File Offset: 0x00020C70
			[Token(Token = "0x60048B2")]
			[Address(RVA = "0x5E8480", Offset = "0x5E8480", VA = "0x5E8480", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x060048B3 RID: 18611 RVA: 0x00022A88 File Offset: 0x00020C88
			[Token(Token = "0x60048B3")]
			[Address(RVA = "0x5E8518", Offset = "0x5E8518", VA = "0x5E8518", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x060048B4 RID: 18612 RVA: 0x00022AA0 File Offset: 0x00020CA0
			[Token(Token = "0x60048B4")]
			[Address(RVA = "0x5E8530", Offset = "0x5E8530", VA = "0x5E8530")]
			public static bool operator ==(ItemSlot.ItemDisplayKey left, ItemSlot.ItemDisplayKey right)
			{
				return default(bool);
			}

			// Token: 0x060048B5 RID: 18613 RVA: 0x00022AB8 File Offset: 0x00020CB8
			[Token(Token = "0x60048B5")]
			[Address(RVA = "0x5E8548", Offset = "0x5E8548", VA = "0x5E8548")]
			public static bool operator !=(ItemSlot.ItemDisplayKey left, ItemSlot.ItemDisplayKey right)
			{
				return default(bool);
			}

			// Token: 0x04008ED7 RID: 36567
			[Token(Token = "0x4008ED7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Context;

			// Token: 0x04008ED8 RID: 36568
			[Token(Token = "0x4008ED8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int Slot;
		}

		// Token: 0x02000832 RID: 2098
		[Token(Token = "0x2000832")]
		public struct ItemTransferInfo
		{
			// Token: 0x060048B6 RID: 18614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60048B6")]
			[Address(RVA = "0x5E855C", Offset = "0x5E855C", VA = "0x5E855C")]
			public ItemTransferInfo(Item itemAfter, int fromContext, int toContext, int transferAmount = 0)
			{
			}

			// Token: 0x04008ED9 RID: 36569
			[Token(Token = "0x4008ED9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int ItemType;

			// Token: 0x04008EDA RID: 36570
			[Token(Token = "0x4008EDA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int TransferAmount;

			// Token: 0x04008EDB RID: 36571
			[Token(Token = "0x4008EDB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int FromContenxt;

			// Token: 0x04008EDC RID: 36572
			[Token(Token = "0x4008EDC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int ToContext;
		}

		// Token: 0x02000833 RID: 2099
		// (Invoke) Token: 0x060048B8 RID: 18616
		[Token(Token = "0x2000833")]
		public delegate void ItemTransferEvent(ItemSlot.ItemTransferInfo info);

		// Token: 0x02000834 RID: 2100
		// (Invoke) Token: 0x060048BC RID: 18620
		[Token(Token = "0x2000834")]
		public delegate void ItemPickupAction<TItemInfo>(TItemInfo info, int stackToGet);
	}
}
