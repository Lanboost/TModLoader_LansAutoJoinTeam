using Terraria;
using Terraria.ModLoader;

namespace SimpleHealthbar
{
	public class SimpleHealthbar : Mod
	{
		public SimpleHealthbar()
		{

		}
	}

	public class SimpleHealthbarPlayer : ModPlayer
	{
		public override void DrawEffects(PlayerDrawInfo drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
		{
			var num25 = Main.myPlayer;
			base.DrawEffects(drawInfo, ref r, ref g, ref b, ref a, ref fullBright);

			if (Main.player[num25].active && !Main.player[num25].ghost && !Main.player[num25].dead && Main.player[num25].statLife != Main.player[num25].statLifeMax2)
			{
				if (Main.HealthBarDrawSettings == 1)
				{
					int num26 = 10;




					Main.instance.DrawHealthBar(Main.player[num25].position.X + (float)(Main.player[num25].width / 2), Main.player[num25].position.Y + (float)Main.player[num25].height + (float)num26 + Main.player[num25].gfxOffY, Main.player[num25].statLife, Main.player[num25].statLifeMax2, Lighting.Brightness((int)((Main.player[num25].position.X + (float)(Main.player[num25].width / 2)) / 16f), (int)((Main.player[num25].position.Y + (float)(Main.player[num25].height / 2) + Main.player[num25].gfxOffY) / 16f)), 1f);
				}
				else if (Main.HealthBarDrawSettings == 2)
				{
					int num27 = -20;
					Main.instance.DrawHealthBar(Main.player[num25].position.X + (float)(Main.player[num25].width / 2), Main.player[num25].position.Y + (float)num27 + Main.player[num25].gfxOffY, Main.player[num25].statLife, Main.player[num25].statLifeMax2, Lighting.Brightness((int)((Main.player[num25].position.X + (float)(Main.player[num25].width / 2)) / 16f), (int)((Main.player[num25].position.Y + (float)(Main.player[num25].height / 2) + Main.player[num25].gfxOffY) / 16f)), 1f);
				}
			}
		}
	}
}