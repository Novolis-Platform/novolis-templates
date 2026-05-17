using Microsoft.Xna.Framework.Graphics;

namespace Novolis.Templates.MonoGame.Models.BasicShapes;

public readonly record struct Vertices(VertexPositionColor[] VertexArray, int VertexCount, int[] Indicies, int IndexCount);