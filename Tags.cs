static class Tags
{
    public static readonly ushort SpawnPlayerTag = 0;
    public static readonly ushort PlayerUpdateTag = 1;
    public static readonly ushort DespawnPlayerTag = 2;

    public static readonly ushort SpawnEntityTag = 3;
    public static readonly ushort TransformEntityTag = 4;
    public static readonly ushort SetStateEntityTag = 5;
    public static readonly ushort DespawnEntityTag = 6;
    public static readonly ushort SetEntityPhysicsHost = 7;
    public static readonly ushort PhysicsUpdateEntityTag = 8;
    public static readonly ushort SetPhysicsEntityTag = 9;

    internal static readonly ushort WeaponFireStartTag = 10;
    internal static readonly ushort WeaponFireEndTag = 11;
    internal static readonly ushort WeaponSwitchTag = 12;
    internal static readonly ushort WeaponActionTag = 13;

    internal static readonly ushort DamageHurtableTag = 14;

    internal static readonly ushort SpawnProceduralShapeEntityTag = 15;

    internal static readonly ushort JoinWorldMessage = 16;
    internal static readonly ushort GetWorldsMessage = 18;
    internal static readonly ushort CreateWorldMessage = 19;

    internal static readonly ushort SetEntityParentTag = 20;
    internal static readonly ushort UseEntityTag = 21;

    internal static readonly ushort GetItems = 22; //#
    internal static readonly ushort AddInventoryItem = 23;
    internal static readonly ushort TransferInventoryItem = 24; //#
    internal static readonly ushort TrashInventoryItem = 25;
    internal static readonly ushort GetInventory = 26; //#V

    internal static readonly ushort LoginTag = 27;
    internal static readonly ushort FireBulletTag = 28;
}