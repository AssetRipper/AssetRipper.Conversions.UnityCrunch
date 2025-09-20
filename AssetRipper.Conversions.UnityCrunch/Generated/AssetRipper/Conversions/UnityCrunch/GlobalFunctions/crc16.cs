using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crc16@crnd@@YAGPEBXIG@Z")]
[DemangledName("unsigned short __cdecl crnd::crc16(void const *, unsigned int, unsigned short)")]
internal static partial class crc16
{
	[return: NativeType("unsigned short")]
	public unsafe static short Invoke([NativeType("void const *")] void* pBuf, [NativeType("unsigned int")] int len, [NativeType("unsigned short")] short crc)
	{
		short num = 0;
		short num2 = 0;
		short num3 = crc;
		int i = len;
		unchecked
		{
			num3 = (short)((ushort)num3 ^ -1);
			void* ptr = pBuf;
			for (; i != 0; i += -1)
			{
				void* ptr2 = ptr;
				ptr = (byte*)ptr2 + 1;
				num = (short)((byte)(*(sbyte*)ptr2) ^ ((ushort)num3 >> 8));
				num3 = (short)((ushort)num3 << 8);
				num2 = (short)(((ushort)num >> 4) ^ (ushort)num);
				num3 = (short)((ushort)num3 ^ (ushort)num2);
				num2 = (short)((ushort)num2 << 5);
				num3 = (short)((ushort)(short)((ushort)num3 ^ (ushort)num2) ^ (ushort)(short)((ushort)num2 << 7));
			}
			return (short)((ushort)num3 ^ -1);
		}
	}
}
