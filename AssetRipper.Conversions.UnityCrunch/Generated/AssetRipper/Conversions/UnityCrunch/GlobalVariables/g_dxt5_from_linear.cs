using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("?g_dxt5_from_linear@crnd@@3QBEB")]
[DemangledName("unsigned char const *const crnd::g_dxt5_from_linear")]
internal static partial class g_dxt5_from_linear
{
	public unsafe static InlineArray8_SByte* __pointer;

	public unsafe static InlineArray8_SByte Value
	{
		get
		{
			return *__pointer;
		}
		set
		{
			*__pointer = value;
		}
	}

	unsafe static g_dxt5_from_linear()
	{
		__pointer = unchecked((InlineArray8_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray8_SByte))));
		Value = InlineArrayHelper.Create<InlineArray8_SByte, byte>(new byte[8] { 0, 2, 3, 4, 5, 6, 7, 1 });
	}
}
