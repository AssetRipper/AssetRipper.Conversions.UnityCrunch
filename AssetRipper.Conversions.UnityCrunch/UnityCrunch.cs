using AssetRipper.Conversions.UnityCrunch.Structures;
using System;
using System.Diagnostics.CodeAnalysis;

namespace AssetRipper.Conversions.UnityCrunch;

public static partial class UnityCrunch
{
	/// <summary>
	/// <see href="https://github.com/Unity-Technologies/crunch/blob/8708900eca8ec609d279270e72936258f81ddfb7/inc/crnlib.h#L92"/>
	/// </summary>
	public const int MaxFaces = 6;

	/// <summary>
	/// <see href="https://github.com/Unity-Technologies/crunch/blob/8708900eca8ec609d279270e72936258f81ddfb7/inc/crnlib.h#L93"/>
	/// </summary>
	public const int MaxLevels = 16;

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

			// m_struct_size
			int width = int.Max(1, textureInfo.field_1 >> levelIndex);
			int height = int.Max(1, textureInfo.field_2 >> levelIndex);
			// m_levels
			int faceCount = textureInfo.field_4;
			int bytesPerBlock = textureInfo.field_5;
			// m_userdata0
			// m_userdata1
			// m_format

			int blocksX = (width + 3) >> 2;
			int blocksY = (height + 3) >> 2;
			int rowPitch = blocksX * crnd_get_bytes_per_dxt_block(textureInfo.field_8);
			int faceSize = rowPitch * blocksY;
			int totalFaceSize = faceCount * faceSize;

			byte[] result = new byte[totalFaceSize];

			fixed (byte* pResult = result)
			{
				byte** pResultArray = stackalloc byte*[MaxFaces] { null, null, null, null, null, null };
				for (int i = 0; i < faceCount; i++)
				{
					pResultArray[i] = pResult + i * faceSize;
				}

				if (!crnd_unpack_level(context, pResultArray, faceSize, rowPitch, levelIndex))
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
