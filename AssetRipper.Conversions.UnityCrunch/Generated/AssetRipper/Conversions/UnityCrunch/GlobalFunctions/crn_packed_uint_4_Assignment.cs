using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??4?$crn_packed_uint@$03@crnd@@QEAAAEAU01@I@Z")]
[DemangledName("public: struct crnd::crn_packed_uint<4> & __cdecl crnd::crn_packed_uint<4>::operator=(unsigned int)")]
internal static partial class crn_packed_uint_4_Assignment
{
	[return: NativeType("struct crnd::crn_packed_uint<4> &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int val)
	{
		int num = val;
		num <<= 0;
		unchecked
		{
			for (int i = 0; (uint)i < 4u; i++)
			{
				((sbyte*)(&((crnd_crn_packed_uint_25ciii*)@this)->m_buf))[(uint)i] = (sbyte)(num >>> 24);
				num <<= 8;
			}
			return @this;
		}
	}
}
