using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??A?$vector@G@crnd@@QEAAAEAGI@Z")]
[DemangledName("public: unsigned short & __cdecl crnd::vector<unsigned short>::operator[](unsigned int)")]
internal static partial class vector_unsigned_short_Index
{
	[return: NativeType("unsigned short &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		unchecked
		{
			if ((uint)i >= (uint)((crnd_vector_rf9iywd*)@this)->m_size)
			{
				crnd_assert.Invoke(String_ededlgd.__pointer, String_yguirrd.__pointer, 590);
			}
			return (byte*)((crnd_vector_rf9iywd*)@this)->m_p + (nint)(uint)i * (nint)2;
		}
	}
}
