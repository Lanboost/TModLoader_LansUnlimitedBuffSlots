using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LansUnlimitedBuffSlots
{
	public class LansUnlimitedBuffSlots : Mod
	{

		public override uint ExtraPlayerBuffSlots => 200;

		public LansUnlimitedBuffSlots()
		{
		}

	
	}

	public class LPlayer : ModPlayer
	{
		public override void PreUpdateBuffs()
		{
			base.PreUpdateBuffs();
			if (this.Player == Main.LocalPlayer)
			{
				int toRemove = this.Player.CountBuffs() - GetInstance<Config>().MaxBuffSlots;

				

				while (toRemove > 0)
				{
					int num3 = -1;
					for (int l = 0; l < Player.MaxBuffs; l++)
					{
						if (!Main.debuff[Player.buffType[l]] && Player.buffTime[l] > 0)
						{
							num3 = l;
							//break;
						}
					}
					if (num3 == -1)
					{
						return;
					}
					Player.DelBuff(num3);
					toRemove--;
				}
			}
		}
	}
}