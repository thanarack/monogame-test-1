using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLibrary;

namespace DungeonSlime;

public class Game1 : Core
{

    float count = 0;

    public Game1() : base("Game1 - Dungeon and dragon", 1280, 720, false)
    {

    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        base.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        // float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        Console.WriteLine("dt " + count);
        count += 1;

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Orange);

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
