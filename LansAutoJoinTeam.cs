using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

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
		public override void DrawEffects(PlayerDrawSet drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
		{
			base.DrawEffects(drawInfo, ref r, ref g, ref b, ref a, ref fullBright);


			if(GetInstance<Config>().TeamToJoin < 0 || GetInstance<Config>().TeamToJoin>= 6)
			{
				GetInstance<Config>().TeamToJoin = 1;
			}

			var team = GetInstance<Config>().TeamToJoin;


			if (Main.player[Main.myPlayer].team == 0) {
				Main.player[Main.myPlayer].team = team;
				NetMessage.SendData(MessageID.PlayerTeam, -1, -1, null, Main.myPlayer);
			}
		}
	}
}