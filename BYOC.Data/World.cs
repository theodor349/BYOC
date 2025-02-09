using System.Diagnostics.CodeAnalysis;
namespace BYOC.Data;
public class World
{
    public int Width { get; set; }
    public int Height { get; set; }
    [AllowNull]
    public Node?[,] Nodes { get; set; }

    public void Reset(int width, int height)
    {
        Width = width;
        Height = height;
        Nodes = new Node?[Width, Height];
    }
}