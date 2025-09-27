using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??A?$vector@E@crnd@@QEAAAEAEI@Z")]
[DemangledName("public: unsigned char & __cdecl crnd::vector<unsigned char>::operator[](unsigned int)")]
[CleanName("vector_unsigned_char_Index")]
internal static partial class vector_unsigned_char_Index_o39mi9c
{
	[return: NativeType("unsigned char &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		unchecked
		{
			if ((uint)i >= (uint)((crnd_vector_f3cmzmc*)@this)->m_size)
			{
				crnd_assert.Invoke(String_ededlgd.__pointer, String_yguirrd.__pointer, 590);
			}
			return (byte*)((crnd_vector_f3cmzmc*)@this)->m_p + (uint)i;
		}
	}
}
