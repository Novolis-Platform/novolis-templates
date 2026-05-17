using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Novolis.Templates.MonoGame.Models.BasicShapes;

internal readonly record struct Triangle(VertexPosition A, VertexPosition B, VertexPosition C, Color Color);