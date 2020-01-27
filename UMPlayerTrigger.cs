using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public enum UMPlayerTrigger : ushort
	{
		Jump,
		Reload,
		OneHanded_Gun_Fire,
		TwoHanded_Gun_Fire,
		OneHanded_Melee_Swing,
		TwoHanded_Melee_Swing,
        CrouchStart,
        CrouchEnd
	}
}