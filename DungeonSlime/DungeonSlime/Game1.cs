using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLibrary;
using MonoGameLibrary.Graphics;

namespace DungeonSlime;

public class Game1 : Core
{
    private TextureRegion _slime;
    private TextureRegion _bat;

    // const float SPEED = 50.0f;

    public Game1()
        : base("Game1 - Dungeon and dragon", 1280, 720, false) { }

    protected override void LoadContent()
    {
        // Texture2D atlasTexture = Content.Load<Texture2D>("images/atlas");
        // TextureAtlas atlas = new(atlasTexture);
        // atlas.AddRegion("slime", 0, 0, 20, 20);
        // atlas.AddRegion("bat", 20, 0, 20, 20);
        // _slime = atlas.GetRegion("slime");
        // _bat = atlas.GetRegion("bat");
        TextureAtlas atlas = TextureAtlas.FromFile(Content, "images/atlas-defination.xml");
        _slime = atlas.GetRegion("slime");
        _bat = atlas.GetRegion("bat");
    }

    protected override void Update(GameTime gameTime)
    {
        // float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        // Console.WriteLine("dt " + count);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        SpriteBatch.Begin(samplerState: SamplerState.PointClamp);

        _slime.Draw(
            SpriteBatch,
            Vector2.Zero,
            Color.White,
            0.0f,
            Vector2.One,
            4.0f,
            SpriteEffects.None,
            0.0f
        );

        _bat.Draw(
            SpriteBatch,
            new Vector2((_slime.Width * 4.0f) + 10, 0),
            Color.White,
            0.0f,
            Vector2.One,
            4.0f,
            SpriteEffects.None,
            0.0f
        );

        SpriteBatch.End();

        base.Draw(gameTime);
    }
}
