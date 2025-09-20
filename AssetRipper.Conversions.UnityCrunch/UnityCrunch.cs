using AssetRipper.Conversions.UnityCrunch.Structures;
using System;
using System.Diagnostics.CodeAnalysis;

namespace AssetRipper.Conversions.UnityCrunch;

public static partial class UnityCrunch
{
	public static bool TryDecompress(ReadOnlySpan<byte> input, [NotNullWhen(true)] out byte[]? output)
	{
		return TryDecompress(input, 0, out output);
	}

	public static unsafe bool TryDecompress(ReadOnlySpan<byte> input, int levelIndex, [NotNullWhen(true)] out byte[]? output)
	{
		if (input.Length == 0)
		{
			output = [];
			return true;
		}

		int inputLength = input.Length;
		fixed (byte* pInput = input)
		{
			crnd_crn_texture_info textureInfo = default;
			textureInfo.field_0 = 36; // size of crnd_crn_texture_info
			if (!crnd_get_texture_info(pInput, inputLength, &textureInfo))
			{
				return False(out output);
			}

			void* context = crnd_unpack_begin(pInput, inputLength);
			if (context is null)
			{
				return False(out output);
			}

			int width = int.Max(1, textureInfo.field_1 >> levelIndex);
			int height = int.Max(1, textureInfo.field_2 >> levelIndex);
			int blocksX = int.Max(1, (width + 3) >> 2);
			int blocksY = int.Max(1, (height + 3) >> 2);
			int rowPitch = blocksX * crnd_get_bytes_per_dxt_block(textureInfo.field_8);
			int totalFaceSize = rowPitch * blocksY;
			byte[] result = new byte[totalFaceSize];
			fixed (byte* pResult = result)
			{
				if (!crnd_unpack_level(context, pResult, totalFaceSize, rowPitch, levelIndex))
				{
					crnd_unpack_end(context);
					return False(out output);
				}
			}
			crnd_unpack_end(context);
			output = result;
		}

		return true;

		static unsafe bool False([NotNullWhen(true)] out byte[]? output)
		{
			output = null;
			return false;
		}
	}
}
