using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??4?$crn_packed_uint@$01@crnd@@QEAAAEAU01@I@Z")]
[DemangledName("public: struct crnd::crn_packed_uint<2> & __cdecl crnd::crn_packed_uint<2>::operator=(unsigned int)")]
internal static partial class crn_packed_uint_2_Assignment
{
	[return: NativeType("struct crnd::crn_packed_uint<2> &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int val)
	{
		int num = val;
		num <<= 16;
		unchecked
		{
			for (int i = 0; (uint)i < 2u; i++)
			{
				((sbyte*)(&((crnd_crn_packed_uint_hnsywfd*)@this)->m_buf))[(uint)i] = (sbyte)(num >>> 24);
				num <<= 8;
			}
			return @this;
		}
	}
}
