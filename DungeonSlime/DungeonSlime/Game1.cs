using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLibrary;
using MonoGameLibrary.Graphics;

namespace DungeonSlime;

public class Game1 : Core
{
    private AnimatedSprite _slime;
    private AnimatedSprite _bat;

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

        _slime = atlas.CreateAnimatedSprite("slime-animation");
        _slime.Scale = new Vector2(4.0f, 4.0f);

        _bat = atlas.CreateAnimatedSprite("bat-animation");
        _bat.Scale = new Vector2(4.0f, 4.0f);
    }

    protected override void Update(GameTime gameTime)
    {
        // float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        // Console.WriteLine("dt " + deltaTime);

        _slime.Update(gameTime);
        _bat.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        SpriteBatch.Begin(samplerState: SamplerState.PointClamp);

        _slime.Draw(SpriteBatch, Vector2.Zero);
        _bat.Draw(SpriteBatch, new Vector2(_slime.Width + 10, 0));

        SpriteBatch.End();

        base.Draw(gameTime);
    }
}
