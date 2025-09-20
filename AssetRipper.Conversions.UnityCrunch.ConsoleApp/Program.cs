namespace AssetRipper.Conversions.UnityCrunch.ConsoleApp;

internal static class Program
{
	private static void Main(string[] args)
	{
		byte[] data = File.ReadAllBytes(args[0]);
		string outputPath = args.Length > 1 ? args[1] : args[0] + ".dxt";
		if (UnityCrunch.TryDecompress(data, out byte[]? output))
		{
			File.WriteAllBytes(outputPath, output);
			Console.WriteLine($"Decompressed to {outputPath}");
		}
		else
		{
			Console.WriteLine("Decompression failed");
		}
	}
}
