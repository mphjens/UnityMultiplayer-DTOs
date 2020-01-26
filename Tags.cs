using System;

internal static class Tags
{
	public readonly static ushort SpawnPlayerTag;

	public readonly static ushort PlayerUpdateTag;

	public readonly static ushort DespawnPlayerTag;

	public readonly static ushort SpawnEntityTag;

	public readonly static ushort TransformEntityTag;

	public readonly static ushort SetStateEntityTag;

	public readonly static ushort DespawnEntityTag;

	public readonly static ushort SetEntityPhysicsHost;

	public readonly static ushort PhysicsUpdateEntityTag;

	public readonly static ushort SetPhysicsEntityTag;

	internal readonly static ushort WeaponFireStartTag;

	internal readonly static ushort WeaponFireEndTag;

	internal readonly static ushort WeaponSwitchTag;

	internal readonly static ushort WeaponActionTag;

	internal readonly static ushort DamageHurtableTag;

	internal readonly static ushort SpawnProceduralShapeEntityTag;

	internal readonly static ushort JoinWorldMessage;

	internal readonly static ushort GetWorldsMessage;

	internal readonly static ushort CreateWorldMessage;

	static Tags()
	{
		Tags.SpawnPlayerTag = 0;
		Tags.PlayerUpdateTag = 1;
		Tags.DespawnPlayerTag = 2;
		Tags.SpawnEntityTag = 3;
		Tags.TransformEntityTag = 4;
		Tags.SetStateEntityTag = 5;
		Tags.DespawnEntityTag = 6;
		Tags.SetEntityPhysicsHost = 7;
		Tags.PhysicsUpdateEntityTag = 8;
		Tags.SetPhysicsEntityTag = 9;
		Tags.WeaponFireStartTag = 10;
		Tags.WeaponFireEndTag = 11;
		Tags.WeaponSwitchTag = 12;
		Tags.WeaponActionTag = 13;
		Tags.DamageHurtableTag = 14;
		Tags.SpawnProceduralShapeEntityTag = 15;
		Tags.JoinWorldMessage = 16;
		Tags.GetWorldsMessage = 18;
		Tags.CreateWorldMessage = 19;
	}
}