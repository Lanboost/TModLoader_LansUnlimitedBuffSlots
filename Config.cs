using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace LansUnlimitedBuffSlots
{
	class Config : ModConfig
	{
		// You MUST specify a ConfigScope.
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Label("Max Buff Slots")]
		[Tooltip("Limits the maximum amount of buff slots")]
		[Range(1, 200)]
		[Increment(1)]
		[DrawTicks]
		[DefaultValue(200)]
		public int MaxBuffSlots;

	}
}
