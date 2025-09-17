using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??A?$vector@E@crnd@@QEBAAEBEI@Z")]
[DemangledName("public: unsigned char const & __cdecl crnd::vector<unsigned char>::operator[](unsigned int) const")]
[CleanName("Index")]
internal static partial class Index_3lowkad
{
	public unsafe static void* Invoke(void* @this, int i)
	{
		int num = 0;
		num = i;
		unchecked
		{
			int num2;
			if ((uint)num < (uint)((crnd_vector*)@this)->field_1)
			{
				num2 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_ededlgd.__pointer, String_yguirrd.__pointer, 586);
				num2 = 0;
			}
			return (byte*)((crnd_vector*)@this)->field_0 + (uint)num;
		}
	}
}
