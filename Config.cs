using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace LansAutoJoinTeam
{
	class Config: ModConfig
	{
		// You MUST specify a ConfigScope.
		public override ConfigScope Mode => ConfigScope.ClientSide;


		[DefaultValue(1)]
		[Label("Team that should be joined by each client")]
		[Tooltip("Valid values are 0-5")]
		[Range(0,5)]
		public int TeamToJoin;

	}
}
