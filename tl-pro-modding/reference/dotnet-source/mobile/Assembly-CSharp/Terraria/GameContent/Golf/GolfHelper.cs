using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Physics;

namespace Terraria.GameContent.Golf
{
	// Token: 0x02000CCA RID: 3274
	[Token(Token = "0x2000CCA")]
	public static class GolfHelper
	{
		// Token: 0x0600613F RID: 24895 RVA: 0x0002CE68 File Offset: 0x0002B068
		[Token(Token = "0x600613F")]
		[Address(RVA = "0xAABF8C", Offset = "0xAABF8C", VA = "0xAABF8C")]
		public static BallStepResult StepGolfBall(Entity entity, ref float angularVelocity)
		{
			return default(BallStepResult);
		}

		// Token: 0x06006140 RID: 24896 RVA: 0x0002CE80 File Offset: 0x0002B080
		[Token(Token = "0x6006140")]
		[Address(RVA = "0xAAC014", Offset = "0xAAC014", VA = "0xAAC014")]
		public static Vector2 FindVectorOnOval(Vector2 vector, Vector2 radius)
		{
			return default(Vector2);
		}

		// Token: 0x06006141 RID: 24897 RVA: 0x0002CE98 File Offset: 0x0002B098
		[Token(Token = "0x6006141")]
		[Address(RVA = "0xAAC1E0", Offset = "0xAAC1E0", VA = "0xAAC1E0")]
		public static GolfHelper.ShotStrength CalculateShotStrength(Vector2 shotVector, GolfHelper.ClubProperties clubProperties)
		{
			return default(GolfHelper.ShotStrength);
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x0002CEB0 File Offset: 0x0002B0B0
		[Token(Token = "0x6006142")]
		[Address(RVA = "0xAAC3D8", Offset = "0xAAC3D8", VA = "0xAAC3D8")]
		public static bool IsPlayerHoldingClub(Player player)
		{
			return default(bool);
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x0002CEC8 File Offset: 0x0002B0C8
		[Token(Token = "0x6006143")]
		[Address(RVA = "0xAAC460", Offset = "0xAAC460", VA = "0xAAC460")]
		public static GolfHelper.ShotStrength CalculateShotStrength(Projectile golfHelper, Entity golfBall)
		{
			return default(GolfHelper.ShotStrength);
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x0002CEE0 File Offset: 0x0002B0E0
		[Token(Token = "0x6006144")]
		[Address(RVA = "0xAAC66C", Offset = "0xAAC66C", VA = "0xAAC66C")]
		public static GolfHelper.ClubProperties GetClubPropertiesFromGolfHelper(Projectile golfHelper)
		{
			return default(GolfHelper.ClubProperties);
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x0002CEF8 File Offset: 0x0002B0F8
		[Token(Token = "0x6006145")]
		[Address(RVA = "0xAAC780", Offset = "0xAAC780", VA = "0xAAC780")]
		public static GolfHelper.ClubProperties GetClubProperties(short itemId)
		{
			return default(GolfHelper.ClubProperties);
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006146")]
		[Address(RVA = "0xAACAEC", Offset = "0xAACAEC", VA = "0xAACAEC")]
		public static Projectile FindHelperFromGolfBall(Projectile golfBall)
		{
			return null;
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006147")]
		[Address(RVA = "0xAACC00", Offset = "0xAACC00", VA = "0xAACC00")]
		public static Projectile FindGolfBallForHelper(Projectile golfHelper)
		{
			return null;
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x0002CF10 File Offset: 0x0002B110
		[Token(Token = "0x6006148")]
		[Address(RVA = "0xAAD19C", Offset = "0xAAD19C", VA = "0xAAD19C")]
		public static bool IsGolfBallResting(Projectile golfBall)
		{
			return default(bool);
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x0002CF28 File Offset: 0x0002B128
		[Token(Token = "0x6006149")]
		[Address(RVA = "0xAAD2C8", Offset = "0xAAD2C8", VA = "0xAAD2C8")]
		public static bool IsGolfShotValid(Entity golfBall, Player player)
		{
			return default(bool);
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x0002CF40 File Offset: 0x0002B140
		[Token(Token = "0x600614A")]
		[Address(RVA = "0xAACEB0", Offset = "0xAACEB0", VA = "0xAACEB0")]
		public static bool ValidateShot(Entity golfBall, Player player, ref Vector2 shotVector)
		{
			return default(bool);
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614B")]
		[Address(RVA = "0xAAD414", Offset = "0xAAD414", VA = "0xAAD414")]
		public static void HitGolfBall(Entity entity, Vector2 velocity, float roughLandResistance)
		{
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614C")]
		[Address(RVA = "0xAADBA8", Offset = "0xAADBA8", VA = "0xAADBA8")]
		public static void DrawPredictionLine(Entity golfBall, Vector2 impactVelocity, float chargeProgress, float roughLandResistance)
		{
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614D")]
		[Address(RVA = "0xAAE914", Offset = "0xAAE914", VA = "0xAAE914")]
		public static void UpdateDebugDraw(Vector2 position)
		{
		}

		// Token: 0x0400A002 RID: 40962
		[Token(Token = "0x400A002")]
		[FieldOffset(Offset = "0x0")]
		private static FancyGolfPredictionLine _predictionLine;

		// Token: 0x0400A003 RID: 40963
		[Token(Token = "0x400A003")]
		public const int PointsNeededForLevel1 = 500;

		// Token: 0x0400A004 RID: 40964
		[Token(Token = "0x400A004")]
		public const int PointsNeededForLevel2 = 1000;

		// Token: 0x0400A005 RID: 40965
		[Token(Token = "0x400A005")]
		public const int PointsNeededForLevel3 = 2000;

		// Token: 0x0400A006 RID: 40966
		[Token(Token = "0x400A006")]
		[FieldOffset(Offset = "0x4")]
		public static readonly PhysicsProperties PhysicsProperties;

		// Token: 0x0400A007 RID: 40967
		[Token(Token = "0x400A007")]
		[FieldOffset(Offset = "0x8")]
		public static readonly GolfHelper.ContactListener Listener;

		// Token: 0x02000CCB RID: 3275
		[Token(Token = "0x2000CCB")]
		public struct ClubProperties
		{
			// Token: 0x0600614F RID: 24911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600614F")]
			[Address(RVA = "0xAACAD8", Offset = "0xAACAD8", VA = "0xAACAD8")]
			public ClubProperties(Vector2 minimumStrength, Vector2 maximumStrength, float roughLandResistance)
			{
			}

			// Token: 0x0400A008 RID: 40968
			[Token(Token = "0x400A008")]
			[FieldOffset(Offset = "0x0")]
			public readonly Vector2 MinimumStrength;

			// Token: 0x0400A009 RID: 40969
			[Token(Token = "0x400A009")]
			[FieldOffset(Offset = "0x8")]
			public readonly Vector2 MaximumStrength;

			// Token: 0x0400A00A RID: 40970
			[Token(Token = "0x400A00A")]
			[FieldOffset(Offset = "0x10")]
			public readonly float RoughLandResistance;
		}

		// Token: 0x02000CCC RID: 3276
		[Token(Token = "0x2000CCC")]
		public struct ShotStrength
		{
			// Token: 0x06006150 RID: 24912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006150")]
			[Address(RVA = "0xAAC3D0", Offset = "0xAAC3D0", VA = "0xAAC3D0")]
			public ShotStrength(float absoluteStrength, float relativeStrength, float roughLandResistance)
			{
			}

			// Token: 0x0400A00B RID: 40971
			[Token(Token = "0x400A00B")]
			[FieldOffset(Offset = "0x0")]
			public readonly float AbsoluteStrength;

			// Token: 0x0400A00C RID: 40972
			[Token(Token = "0x400A00C")]
			[FieldOffset(Offset = "0x4")]
			public readonly float RelativeStrength;

			// Token: 0x0400A00D RID: 40973
			[Token(Token = "0x400A00D")]
			[FieldOffset(Offset = "0x8")]
			public readonly float RoughLandResistance;
		}

		// Token: 0x02000CCD RID: 3277
		[Token(Token = "0x2000CCD")]
		public class ContactListener : FileAPI
		{
			// Token: 0x06006151 RID: 24913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006151")]
			[Address(RVA = "0xAAEA0C", Offset = "0xAAEA0C", VA = "0xAAEA0C", Slot = "4")]
			public void OnCollision(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref BallCollisionEvent collision)
			{
			}

			// Token: 0x06006152 RID: 24914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006152")]
			[Address(RVA = "0xAAF558", Offset = "0xAAF558", VA = "0xAAF558")]
			public void PutBallInCup(Projectile proj, BallCollisionEvent collision)
			{
			}

			// Token: 0x06006153 RID: 24915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006153")]
			[Address(RVA = "0xAAFD14", Offset = "0xAAFD14", VA = "0xAAFD14")]
			public static void PutBallInCup_TextAndEffects(Point hitLocation, int plr, int numberOfHits, int projid)
			{
			}

			// Token: 0x06006154 RID: 24916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006154")]
			[Address(RVA = "0xAB1154", Offset = "0xAB1154", VA = "0xAB1154", Slot = "5")]
			public void OnPassThrough(PhysicsProperties properties, ref Vector2 position, ref Vector2 velocity, ref float angularVelocity, ref BallPassThroughEvent collision)
			{
			}

			// Token: 0x06006155 RID: 24917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006155")]
			[Address(RVA = "0xAB13F0", Offset = "0xAB13F0", VA = "0xAB13F0")]
			public static void EmitGolfballExplosion_Old(Vector2 Center)
			{
			}

			// Token: 0x06006156 RID: 24918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006156")]
			[Address(RVA = "0xAB02BC", Offset = "0xAB02BC", VA = "0xAB02BC")]
			public static void EmitGolfballExplosion(Vector2 Center)
			{
			}

			// Token: 0x06006157 RID: 24919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006157")]
			[Address(RVA = "0xAB13F4", Offset = "0xAB13F4", VA = "0xAB13F4")]
			private static void EmitGolfballExplosion_v1(Vector2 Center)
			{
			}

			// Token: 0x06006158 RID: 24920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006158")]
			[Address(RVA = "0xAAEA04", Offset = "0xAAEA04", VA = "0xAAEA04")]
			public ContactListener()
			{
			}
		}
	}
}
