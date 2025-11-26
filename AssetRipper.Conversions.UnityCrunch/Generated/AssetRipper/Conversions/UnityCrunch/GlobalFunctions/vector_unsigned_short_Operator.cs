using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??A?$vector@G@crnd@@QEAAAEAGI@Z")]
[DemangledName("public: unsigned short & __cdecl crnd::vector<unsigned short>::operator[](unsigned int)")]
internal static partial class vector_unsigned_short_Operator
{
	[return: NativeType("unsigned short &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		unchecked
		{
			if ((uint)i >= (uint)((crnd_vector_h6df48*)@this)->m_size)
			{
				crnd_assert.Invoke(String_jh2584.__pointer, String_vvx8bt.__pointer, 590);
			}
			return (byte*)((crnd_vector_h6df48*)@this)->m_p + (nint)(uint)i * (nint)2;
		}
	}
}
