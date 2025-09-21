using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crc16@crnd@@YAGPEBXIG@Z")]
[DemangledName("unsigned short __cdecl crnd::crc16(void const *, unsigned int, unsigned short)")]
internal static partial class crc16
{
	[return: NativeType("unsigned short")]
	public unsafe static short Invoke([NativeType("void const *")] void* pBuf, [NativeType("unsigned int")] int len, [NativeType("unsigned short")] short crc)
	{
		short num = crc;
		int i = len;
		unchecked
		{
			num = (short)((ushort)num ^ -1);
			void* ptr = pBuf;
			for (; i != 0; i += -1)
			{
				void* ptr2 = ptr;
				ptr = (byte*)ptr2 + 1;
				short num2 = (short)((byte)(*(sbyte*)ptr2) ^ ((ushort)num >> 8));
				num = (short)((ushort)num << 8);
				short num3 = (short)(((ushort)num2 >> 4) ^ (ushort)num2);
				num = (short)((ushort)num ^ (ushort)num3);
				num3 = (short)((ushort)num3 << 5);
				num = (short)((ushort)(short)((ushort)num ^ (ushort)num3) ^ (ushort)(short)((ushort)num3 << 7));
			}
			return (short)((ushort)num ^ -1);
		}
	}
}
