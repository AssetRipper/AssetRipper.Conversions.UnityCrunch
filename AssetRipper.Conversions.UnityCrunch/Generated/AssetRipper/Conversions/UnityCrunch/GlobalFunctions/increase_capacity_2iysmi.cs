using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?increase_capacity@?$vector@E@crnd@@AEAA_NI_N@Z")]
[DemangledName("private: bool __cdecl crnd::vector<unsigned char>::increase_capacity(unsigned int, bool)")]
[CleanName("increase_capacity")]
internal static partial class increase_capacity_2iysmi
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint)
	{
		bool flag = increase_capacity_6cy7im.Invoke(@this, min_new_capacity, ((grow_hint ? 1u : 0u) & 1u) == 1, 1, null);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		if (!flag)
		{
			unchecked((crnd_vector_uksit8*)@this)->m_alloc_failed = 1;
			return false;
		}
		return true;
	}
}
