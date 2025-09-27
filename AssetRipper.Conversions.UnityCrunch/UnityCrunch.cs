using AssetRipper.Conversions.UnityCrunch.Enumerations;
using AssetRipper.Conversions.UnityCrunch.Structures;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace AssetRipper.Conversions.UnityCrunch;

public static partial class UnityCrunch
{
	public const int MaxFaces = (int)crn_limits.cCRNMaxFaces;

	public const int MaxLevels = (int)crn_limits.cCRNMaxLevels;

	public static unsafe bool TryDecompress(ReadOnlySpan<byte> input, [NotNullWhen(true)] out byte[]? output)
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
			textureInfo.m_struct_size = sizeof(crnd_crn_texture_info);
			if (!crnd_get_texture_info(pInput, inputLength, &textureInfo))
			{
				return False(out output);
			}

			void* context = crnd_unpack_begin(pInput, inputLength);
			if (context is null)
			{
				return False(out output);
			}

			int fullWidth = textureInfo.m_width;
			int fullHeight = textureInfo.m_height;
			int levelCount = textureInfo.m_levels;
			int faceCount = textureInfo.m_faces;
			int bytesPerDxtBlock = textureInfo.m_bytes_per_block;

			Debug.Assert(bytesPerDxtBlock == crnd_get_bytes_per_dxt_block(textureInfo.m_format));

			if (levelCount < 1 || levelCount > MaxLevels || faceCount < 1 || faceCount > MaxFaces)
			{
				crnd_unpack_end(context);
				return False(out output);
			}

			int completeImageSize = CalculateCompleteImageSize(fullWidth, fullHeight, bytesPerDxtBlock, levelCount);

			byte[] result = new byte[completeImageSize * faceCount];

			byte** pResultArray = stackalloc byte*[MaxFaces];

			fixed (byte* pResult = result)
			{
				int offset = 0;
				for (int levelIndex = 0; levelIndex < levelCount; levelIndex++)
				{
					int width = int.Max(1, fullWidth >> levelIndex);
					int height = int.Max(1, fullHeight >> levelIndex);
					int blocksX = (width + 3) >> 2;
					int blocksY = (height + 3) >> 2;
					int rowPitch = blocksX * bytesPerDxtBlock;
					int faceSize = rowPitch * blocksY;

					new Span<nint>(pResultArray, MaxFaces).Clear();
					for (int i = 0; i < faceCount; i++)
					{
						pResultArray[i] = pResult + offset + i * completeImageSize;
					}

					if (!crnd_unpack_level(context, pResultArray, faceSize, rowPitch, levelIndex))
					{
						crnd_unpack_end(context);
						return False(out output);
					}

					offset += faceSize;
				}
			}
			crnd_unpack_end(context);
			output = result;
		}

		return true;

		static bool False([NotNullWhen(true)] out byte[]? output)
		{
			output = null;
			return false;
		}

		static int CalculateCompleteImageSize(int width, int height, int bytesPerDxtBlock, int levelCount)
		{
			int totalSize = 0;
			for (int levelIndex = 0; levelIndex < levelCount; levelIndex++)
			{
				int levelWidth = int.Max(1, width >> levelIndex);
				int levelHeight = int.Max(1, height >> levelIndex);
				int blocksX = (levelWidth + 3) >> 2;
				int blocksY = (levelHeight + 3) >> 2;
				totalSize += blocksX * blocksY * bytesPerDxtBlock;
			}
			return totalSize;
		}
	}
}
