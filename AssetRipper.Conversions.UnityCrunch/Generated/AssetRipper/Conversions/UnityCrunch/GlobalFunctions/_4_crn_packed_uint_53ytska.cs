using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??4?$crn_packed_uint@$03@crnd@@QEAAAEAU01@I@Z")]
[DemangledName("public: struct crnd::crn_packed_uint<4> & __cdecl crnd::crn_packed_uint<4>::operator=(unsigned int)")]
[CleanName("_4_crn_packed_uint")]
internal static partial class _4_crn_packed_uint_53ytska
{
	public unsafe static void* Invoke(void* @this, int val)
	{
		int num = 0;
		int num2 = 0;
		num = val;
		num <<= 0;
		unchecked
		{
			for (num2 = 0; (uint)num2 < 4u; num2++)
			{
				((sbyte*)(&((crnd_crn_packed_uint_0*)@this)->field_0))[(uint)num2] = (sbyte)(num >>> 24);
				num <<= 8;
			}
			return @this;
		}
	}
}
