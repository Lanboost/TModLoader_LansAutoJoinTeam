using Terraria;
using Terraria.ModLoader;

namespace LansAutoJoinTeam
{
	public class LansAutoJoinTeam : Mod
	{
		public LansAutoJoinTeam()
		{

		}
	}

	public class LansAutoJoinTeamPlayer : ModPlayer
	{
		public override void DrawEffects(PlayerDrawInfo drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
		{
			base.DrawEffects(drawInfo, ref r, ref g, ref b, ref a, ref fullBright);

			if(Main.player[Main.myPlayer].team != 1) {
				Main.player[Main.myPlayer].team = 1;
				NetMessage.SendData(45, -1, -1, null, Main.myPlayer, 0f, 0f, 0f, 0, 0, 0);
			}
		}
	}
}