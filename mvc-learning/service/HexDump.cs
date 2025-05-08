using System.Diagnostics;
using System.Runtime.Serialization;

public static class HexDump
{
    private static Process? process;

    public static void DumpHexData()
    {
        if (process == null)
        {
            throw new InvalidProgramException("Your system doesn't havr a hexdump tool available in it's Environment");
        }
    }

}