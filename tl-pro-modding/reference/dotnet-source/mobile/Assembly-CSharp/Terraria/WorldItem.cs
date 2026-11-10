using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x02000534 RID: 1332
	[Token(Token = "0x2000534")]
	public class WorldItem : Entity
	{
		// Token: 0x06003957 RID: 14679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003957")]
		[Address(RVA = "0x1DE8F4C", Offset = "0x1DE8F4C", VA = "0x1DE8F4C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003958")]
		[Address(RVA = "0x1DE900C", Offset = "0x1DE900C", VA = "0x1DE900C")]
		public void ReplaceWith(Item item)
		{
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06003959 RID: 14681 RVA: 0x0001CF38 File Offset: 0x0001B138
		[Token(Token = "0x17000729")]
		public bool active
		{
			[Token(Token = "0x6003959")]
			[Address(RVA = "0x1DE90D4", Offset = "0x1DE90D4", VA = "0x1DE90D4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600395A RID: 14682 RVA: 0x0001CF50 File Offset: 0x0001B150
		// (set) Token: 0x0600395B RID: 14683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072A")]
		public int type
		{
			[Token(Token = "0x600395A")]
			[Address(RVA = "0x1DE90F8", Offset = "0x1DE90F8", VA = "0x1DE90F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600395B")]
			[Address(RVA = "0x1DE911C", Offset = "0x1DE911C", VA = "0x1DE911C")]
			set
			{
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600395C RID: 14684 RVA: 0x0001CF68 File Offset: 0x0001B168
		// (set) Token: 0x0600395D RID: 14685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072B")]
		public int stack
		{
			[Token(Token = "0x600395C")]
			[Address(RVA = "0x1DE9144", Offset = "0x1DE9144", VA = "0x1DE9144")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600395D")]
			[Address(RVA = "0x1DE9168", Offset = "0x1DE9168", VA = "0x1DE9168")]
			set
			{
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600395E RID: 14686 RVA: 0x0001CF80 File Offset: 0x0001B180
		// (set) Token: 0x0600395F RID: 14687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072C")]
		public byte prefix
		{
			[Token(Token = "0x600395E")]
			[Address(RVA = "0x1DE9190", Offset = "0x1DE9190", VA = "0x1DE9190")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600395F")]
			[Address(RVA = "0x1DE91B4", Offset = "0x1DE91B4", VA = "0x1DE91B4")]
			set
			{
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06003960 RID: 14688 RVA: 0x0001CF98 File Offset: 0x0001B198
		// (set) Token: 0x06003961 RID: 14689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072D")]
		public Color color
		{
			[Token(Token = "0x6003960")]
			[Address(RVA = "0x1DE91DC", Offset = "0x1DE91DC", VA = "0x1DE91DC")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6003961")]
			[Address(RVA = "0x1DE9200", Offset = "0x1DE9200", VA = "0x1DE9200")]
			set
			{
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06003962 RID: 14690 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
		[Token(Token = "0x1700072E")]
		public int value
		{
			[Token(Token = "0x6003962")]
			[Address(RVA = "0x1DE9228", Offset = "0x1DE9228", VA = "0x1DE9228")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06003963 RID: 14691 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		[Token(Token = "0x1700072F")]
		public int maxStack
		{
			[Token(Token = "0x6003963")]
			[Address(RVA = "0x1DE924C", Offset = "0x1DE924C", VA = "0x1DE924C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06003964 RID: 14692 RVA: 0x0001CFE0 File Offset: 0x0001B1E0
		[Token(Token = "0x17000730")]
		public float scale
		{
			[Token(Token = "0x6003964")]
			[Address(RVA = "0x1DE9270", Offset = "0x1DE9270", VA = "0x1DE9270")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06003965 RID: 14693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000731")]
		public string Name
		{
			[Token(Token = "0x6003965")]
			[Address(RVA = "0x1DE9294", Offset = "0x1DE9294", VA = "0x1DE9294")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06003966 RID: 14694 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
		[Token(Token = "0x17000732")]
		public bool IsACoin
		{
			[Token(Token = "0x6003966")]
			[Address(RVA = "0x1DE92B8", Offset = "0x1DE92B8", VA = "0x1DE92B8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06003967 RID: 14695 RVA: 0x0001D010 File Offset: 0x0001B210
		[Token(Token = "0x17000733")]
		public bool IsAir
		{
			[Token(Token = "0x6003967")]
			[Address(RVA = "0x1DE92DC", Offset = "0x1DE92DC", VA = "0x1DE92DC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06003968 RID: 14696 RVA: 0x0001D028 File Offset: 0x0001B228
		// (set) Token: 0x06003969 RID: 14697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000734")]
		public bool favorited
		{
			[Token(Token = "0x6003968")]
			[Address(RVA = "0x1DE9300", Offset = "0x1DE9300", VA = "0x1DE9300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003969")]
			[Address(RVA = "0x1DE9324", Offset = "0x1DE9324", VA = "0x1DE9324")]
			set
			{
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600396A RID: 14698 RVA: 0x0001D040 File Offset: 0x0001B240
		// (set) Token: 0x0600396B RID: 14699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000735")]
		public bool newAndShiny
		{
			[Token(Token = "0x600396A")]
			[Address(RVA = "0x1DE934C", Offset = "0x1DE934C", VA = "0x1DE934C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600396B")]
			[Address(RVA = "0x1DE9370", Offset = "0x1DE9370", VA = "0x1DE9370")]
			set
			{
			}
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396C")]
		[Address(RVA = "0x1DE9398", Offset = "0x1DE9398", VA = "0x1DE9398")]
		public WorldItem()
		{
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396D")]
		[Address(RVA = "0x1DE9410", Offset = "0x1DE9410", VA = "0x1DE9410")]
		public WorldItem(Item item)
		{
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396E")]
		[Address(RVA = "0x1DE9584", Offset = "0x1DE9584", VA = "0x1DE9584")]
		public void TurnToAir()
		{
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396F")]
		[Address(RVA = "0x1DE95A8", Offset = "0x1DE95A8", VA = "0x1DE95A8")]
		public void Prefix(int prefix)
		{
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x0001D058 File Offset: 0x0001B258
		[Token(Token = "0x6003970")]
		[Address(RVA = "0x1DE95D4", Offset = "0x1DE95D4", VA = "0x1DE95D4")]
		public bool OnlyNeedOneInInventory()
		{
			return default(bool);
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003971")]
		[Address(RVA = "0x1DE95F8", Offset = "0x1DE95F8", VA = "0x1DE95F8")]
		public void TryCombiningIntoNearbyItems()
		{
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003972")]
		[Address(RVA = "0x1DE9C20", Offset = "0x1DE9C20", VA = "0x1DE9C20")]
		public void FindOwner(bool forceAssignToServer = false)
		{
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003973")]
		[Address(RVA = "0x1DEA4FC", Offset = "0x1DEA4FC", VA = "0x1DEA4FC")]
		public void ReserveFor(int player, int timeToKeepReservation = 15)
		{
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003974")]
		[Address(RVA = "0x1DEA6F8", Offset = "0x1DEA6F8", VA = "0x1DEA6F8")]
		public void ApplySpawnOwnership(NewItemOwnership owner, int localPlayerIndex)
		{
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003975")]
		[Address(RVA = "0x1DEA8B4", Offset = "0x1DEA8B4", VA = "0x1DEA8B4")]
		public void MakeInstanced(Predicate<Player> shouldSpawnForPlayer, int defaultLifetimeOverride = 0)
		{
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003976")]
		[Address(RVA = "0x1DEB280", Offset = "0x1DEB280", VA = "0x1DEB280")]
		public void UpdateItem(int i)
		{
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003977")]
		[Address(RVA = "0x1DEC1A8", Offset = "0x1DEC1A8", VA = "0x1DEC1A8")]
		private void UpdateShimmer(ref float gravity)
		{
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003978")]
		[Address(RVA = "0x1DEBC08", Offset = "0x1DEBC08", VA = "0x1DEBC08")]
		private void TryFillBucket()
		{
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003979")]
		[Address(RVA = "0x1DEF854", Offset = "0x1DEF854", VA = "0x1DEF854")]
		private void CheckInWorld()
		{
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397A")]
		[Address(RVA = "0x1DEF49C", Offset = "0x1DEF49C", VA = "0x1DEF49C")]
		private void TryGrantingMakeAWishSet()
		{
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397B")]
		[Address(RVA = "0x1DE9B80", Offset = "0x1DE9B80", VA = "0x1DE9B80")]
		public void SyncItem()
		{
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397C")]
		[Address(RVA = "0x1DF5B6C", Offset = "0x1DF5B6C", VA = "0x1DF5B6C")]
		public void TurnToAirAndSync()
		{
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397D")]
		[Address(RVA = "0x1DF5C28", Offset = "0x1DF5C28", VA = "0x1DF5C28")]
		public void SpawnShimmeredItem(int itemNumber, int type, int stack = 1)
		{
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397E")]
		[Address(RVA = "0x1DF5DE8", Offset = "0x1DF5DE8", VA = "0x1DF5DE8")]
		public static void SpawnShimmeredItem(IEntitySource source, Vector2 center, int itemNumber, int type, int stack = 1)
		{
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397F")]
		[Address(RVA = "0x1DEFC78", Offset = "0x1DEFC78", VA = "0x1DEFC78")]
		private void DespawnIfMeetingConditions()
		{
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003980")]
		[Address(RVA = "0x1DEF6FC", Offset = "0x1DEF6FC", VA = "0x1DEF6FC")]
		private void CheckLavaDeath()
		{
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003981")]
		[Address(RVA = "0x1DF6014", Offset = "0x1DF6014", VA = "0x1DF6014")]
		private void VoodooDollLavaDeath()
		{
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x0001D070 File Offset: 0x0001B270
		[Token(Token = "0x6003982")]
		[Address(RVA = "0x1DF4470", Offset = "0x1DF4470", VA = "0x1DF4470")]
		private bool CanShimmerAtPosition()
		{
			return default(bool);
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003983")]
		[Address(RVA = "0x1DED4E8", Offset = "0x1DED4E8", VA = "0x1DED4E8")]
		private void MoveInWorld(float gravity, float maxFallSpeed, ref Vector2 wetVelocity)
		{
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003984")]
		[Address(RVA = "0x1DF041C", Offset = "0x1DF041C", VA = "0x1DF041C")]
		private void ApplyMovement(ref Vector2 wetVelocity)
		{
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003985")]
		[Address(RVA = "0x1DECB04", Offset = "0x1DECB04", VA = "0x1DECB04")]
		private void GetPickedUpByMonsters_Special()
		{
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003986")]
		[Address(RVA = "0x1DECD60", Offset = "0x1DECD60", VA = "0x1DECD60")]
		private void GetPickedUpByMonsters_Money()
		{
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003987")]
		[Address(RVA = "0x1DF0508", Offset = "0x1DF0508", VA = "0x1DF0508")]
		private void UpdateItem_VisualEffects()
		{
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003988")]
		[Address(RVA = "0x1DF668C", Offset = "0x1DF668C", VA = "0x1DF668C")]
		public IEntitySource GetNPCSource_FromThis()
		{
			return null;
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003989")]
		[Address(RVA = "0x1DF5D6C", Offset = "0x1DF5D6C", VA = "0x1DF5D6C")]
		public IEntitySource GetItemSource_Misc(int itemSourceId)
		{
			return null;
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398A")]
		[Address(RVA = "0x1DF6700", Offset = "0x1DF6700", VA = "0x1DF6700")]
		public static void ShimmerEffect(Vector2 shimmerPositon)
		{
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398B")]
		[Address(RVA = "0x1DF46F4", Offset = "0x1DF46F4", VA = "0x1DF46F4")]
		public void GetShimmered()
		{
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398C")]
		[Address(RVA = "0x1DF6ADC", Offset = "0x1DF6ADC", VA = "0x1DF6ADC")]
		private static void SyncItemsInSection(int toClient, Point sectionCoordinates)
		{
		}

		// Token: 0x04004592 RID: 17810
		[Token(Token = "0x4004592")]
		[FieldOffset(Offset = "0x44")]
		public Item inner;

		// Token: 0x04004593 RID: 17811
		[Token(Token = "0x4004593")]
		[FieldOffset(Offset = "0x48")]
		public int playerIndexTheItemIsReservedFor;

		// Token: 0x04004594 RID: 17812
		[Token(Token = "0x4004594")]
		[FieldOffset(Offset = "0x4C")]
		public int timeSinceTheItemHasBeenReservedForSomeone;

		// Token: 0x04004595 RID: 17813
		[Token(Token = "0x4004595")]
		[FieldOffset(Offset = "0x50")]
		public int timeToKeepReservation;

		// Token: 0x04004596 RID: 17814
		[Token(Token = "0x4004596")]
		[FieldOffset(Offset = "0x54")]
		public int grabDelayPlayer;

		// Token: 0x04004597 RID: 17815
		[Token(Token = "0x4004597")]
		[FieldOffset(Offset = "0x58")]
		public int grabDelayTime;

		// Token: 0x04004598 RID: 17816
		[Token(Token = "0x4004598")]
		[FieldOffset(Offset = "0x5C")]
		public int enemyGrabDelayTime;

		// Token: 0x04004599 RID: 17817
		[Token(Token = "0x4004599")]
		public const int DefaultGrabDelay = 100;

		// Token: 0x0400459A RID: 17818
		[Token(Token = "0x400459A")]
		[FieldOffset(Offset = "0x60")]
		private bool frozen;

		// Token: 0x0400459B RID: 17819
		[Token(Token = "0x400459B")]
		[FieldOffset(Offset = "0x61")]
		private byte frozenCount;

		// Token: 0x0400459C RID: 17820
		[Token(Token = "0x400459C")]
		[FieldOffset(Offset = "0x62")]
		public bool shimmered;

		// Token: 0x0400459D RID: 17821
		[Token(Token = "0x400459D")]
		[FieldOffset(Offset = "0x64")]
		public float shimmerTime;

		// Token: 0x0400459E RID: 17822
		[Token(Token = "0x400459E")]
		[FieldOffset(Offset = "0x68")]
		public bool instanced;

		// Token: 0x0400459F RID: 17823
		[Token(Token = "0x400459F")]
		[FieldOffset(Offset = "0x6C")]
		public int timeSinceItemSpawned;

		// Token: 0x040045A0 RID: 17824
		[Token(Token = "0x40045A0")]
		[FieldOffset(Offset = "0x70")]
		public bool beingGrabbed;

		// Token: 0x040045A1 RID: 17825
		[Token(Token = "0x40045A1")]
		[FieldOffset(Offset = "0x71")]
		public bool onConveyor;

		// Token: 0x02000535 RID: 1333
		[Token(Token = "0x2000535")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600398E RID: 14734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600398E")]
			[Address(RVA = "0x1DF6DA4", Offset = "0x1DF6DA4", VA = "0x1DF6DA4")]
			public <>c()
			{
			}

			// Token: 0x0600398F RID: 14735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600398F")]
			[Address(RVA = "0x1DF6DAC", Offset = "0x1DF6DAC", VA = "0x1DF6DAC")]
			internal void <SpawnShimmeredItem>b__69_0(WorldItem item)
			{
			}

			// Token: 0x06003990 RID: 14736 RVA: 0x0001D088 File Offset: 0x0001B288
			[Token(Token = "0x6003990")]
			[Address(RVA = "0x1DF6E10", Offset = "0x1DF6E10", VA = "0x1DF6E10")]
			internal Recipe.RequiredItemEntry <GetShimmered>b__82_0(Item item)
			{
				return default(Recipe.RequiredItemEntry);
			}

			// Token: 0x040045A2 RID: 17826
			[Token(Token = "0x40045A2")]
			[FieldOffset(Offset = "0x0")]
			public static readonly WorldItem.<>c <>9;

			// Token: 0x040045A3 RID: 17827
			[Token(Token = "0x40045A3")]
			[FieldOffset(Offset = "0x4")]
			public static Item.NewItemModifier <>9__69_0;

			// Token: 0x040045A4 RID: 17828
			[Token(Token = "0x40045A4")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Item, Recipe.RequiredItemEntry> <>9__82_0;
		}
	}
}
