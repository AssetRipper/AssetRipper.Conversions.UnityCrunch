using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??A?$vector@E@crnd@@QEBAAEBEI@Z")]
[DemangledName("public: unsigned char const & __cdecl crnd::vector<unsigned char>::operator[](unsigned int) const")]
[CleanName("vector_unsigned_char_Operator")]
internal static partial class vector_unsigned_char_Operator_btiznu
{
	[return: NativeType("unsigned char const &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		unchecked
		{
			if ((uint)i >= (uint)((crnd_vector_uksit8*)@this)->m_size)
			{
				crnd_assert.Invoke(String_jh2584.__pointer, String_vvx8bt.__pointer, 586);
			}
			return (byte*)((crnd_vector_uksit8*)@this)->m_p + (uint)i;
		}
	}
}
