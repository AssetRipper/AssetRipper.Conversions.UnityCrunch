using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??A?$vector@E@crnd@@QEBAAEBEI@Z")]
[DemangledName("public: unsigned char const & __cdecl crnd::vector<unsigned char>::operator[](unsigned int) const")]
[CleanName("vector_unsigned_char_Index")]
internal static partial class vector_unsigned_char_Index_3lowkad
{
	[return: NativeType("unsigned char const &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		unchecked
		{
			int num;
			if ((uint)i < (uint)((crnd_vector_f3cmzmc*)@this)->field_1)
			{
				num = -1;
			}
			else
			{
				crnd_assert.Invoke(String_ededlgd.__pointer, String_yguirrd.__pointer, 586);
				num = 0;
			}
			return (byte*)((crnd_vector_f3cmzmc*)@this)->field_0 + (uint)i;
		}
	}
}
