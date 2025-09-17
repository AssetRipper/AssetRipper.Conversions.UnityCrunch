using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crc16@crnd@@YAGPEBXIG@Z")]
[DemangledName("unsigned short __cdecl crnd::crc16(void const *, unsigned int, unsigned short)")]
internal static partial class crc16
{
	public unsafe static short Invoke(void* pBuf, int len, short crc)
	{
		short num = 0;
		int num2 = 0;
		void* ptr = null;
		short num3 = 0;
		short num4 = 0;
		num = crc;
		num2 = len;
		unchecked
		{
			num = (short)((ushort)num ^ -1);
			ptr = pBuf;
			for (; num2 != 0; num2 += -1)
			{
				void* ptr2 = ptr;
				ptr = (byte*)ptr2 + 1;
				num3 = (short)((byte)(*(sbyte*)ptr2) ^ ((ushort)num >> 8));
				num = (short)((ushort)num << 8);
				num4 = (short)(((ushort)num3 >> 4) ^ (ushort)num3);
				num = (short)((ushort)num ^ (ushort)num4);
				num4 = (short)((ushort)num4 << 5);
				num = (short)((ushort)(short)((ushort)num ^ (ushort)num4) ^ (ushort)(short)((ushort)num4 << 7));
			}
			return (short)((ushort)num ^ -1);
		}
	}
}
