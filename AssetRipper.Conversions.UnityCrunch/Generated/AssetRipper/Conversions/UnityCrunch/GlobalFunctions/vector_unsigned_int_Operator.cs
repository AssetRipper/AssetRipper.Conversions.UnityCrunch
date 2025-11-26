using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??A?$vector@I@crnd@@QEAAAEAII@Z")]
[DemangledName("public: unsigned int & __cdecl crnd::vector<unsigned int>::operator[](unsigned int)")]
internal static partial class vector_unsigned_int_Operator
{
	[return: NativeType("unsigned int &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		unchecked
		{
			if ((uint)i >= (uint)((crnd_vector_rgfndh*)@this)->m_size)
			{
				crnd_assert.Invoke(String_jh2584.__pointer, String_vvx8bt.__pointer, 590);
			}
			return (byte*)((crnd_vector_rgfndh*)@this)->m_p + (nint)(uint)i * (nint)4;
		}
	}
}
