using System;

public static class Tags
{
    //This class should be an enum
    public static readonly ushort SpawnPlayerTag = 999; //Changed from 0 because corrupted messages sometime come in with message tag 0
    public static readonly ushort PlayerUpdateTag = 1;
    public static readonly ushort DespawnPlayerTag = 2;

    public static readonly ushort SpawnEntityTag = 3;
    public static readonly ushort TransformEntityTag = 4;
    public static readonly ushort SetStateEntityTag = 5;
    public static readonly ushort DespawnEntityTag = 6;
    public static readonly ushort SetEntityPhysicsHost = 7;
    public static readonly ushort PhysicsUpdateEntityTag = 8;
    public static readonly ushort SetPhysicsEntityTag = 9;

    public static readonly ushort WeaponFireStartTag = 10;
    public static readonly ushort WeaponFireEndTag = 11;
    public static readonly ushort WeaponSwitchTag = 12;
    public static readonly ushort WeaponActionTag = 13;

    public static readonly ushort DamageHurtableTag = 14;

    public static readonly ushort SpawnProceduralShapeEntityTag = 15;

    public static readonly ushort JoinWorldMessage = 16;
    public static readonly ushort GetWorldsMessage = 18;
    public static readonly ushort CreateWorldMessage = 19;

    public static readonly ushort SetEntityParentTag = 20;
    public static readonly ushort UseEntityTag = 21;

    //TODO: Reimplment the handling of these messages
    public static readonly ushort GetItems = 22; //#
    public static readonly ushort AddInventoryItem = 23;
    public static readonly ushort TransferInventoryItem = 24; //#
    public static readonly ushort TrashInventoryItem = 25;
    public static readonly ushort GetInventory = 26; //#V
    public static readonly ushort SubscribeInventory = 33; //#V
    public static readonly ushort OnInventoryUpdate = 35; //#V

    public static readonly ushort LoginTag = 27;
    public static readonly ushort LoginCharacter = 34;
    public static readonly ushort FireBulletTag = 28;
    public static readonly ushort BulletHitTag = 29;
    //


    public static readonly ushort AddComponentTag = 30;
    public static readonly ushort RemoveComponentTag = 31;
    public static readonly ushort SetComponentPropertyTag = 32;
}