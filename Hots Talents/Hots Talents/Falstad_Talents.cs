using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace Hots_Talents
{
    public partial class Falstad_Talents : Form
    {
        public Falstad_Talents()
        {
            InitializeComponent();
            DoubleBuffered = true;

            Falstad1_1.Visible = false;
            Falstad1_2.Visible = false;
            Falstad1_3.Visible = false;
            Falstad1_4.Visible = false;
            Falstad1_5.Visible = false;
            Falstad2_1.Visible = false;
            Falstad2_2.Visible = false;
            Falstad2_3.Visible = false;
            Falstad2_4.Visible = false;
            Falstad3_1.Visible = false;
            Falstad3_2.Visible = false;
            Falstad3_3.Visible = false;
            Falstad3_4.Visible = false;
            Falstad3_5.Visible = false;
            Falstad4_1.Visible = false;
            Falstad4_2.Visible = false;
            Falstad6_1.Visible = false;
            Falstad6_2.Visible = false;
            Falstad6_3.Visible = false;
            Falstad6_4.Visible = false;
            Falstad7_1.Visible = false;
            Falstad7_2.Visible = false;
            Falstad7_3.Visible = false;
            Falstad7_4.Visible = false;
            Falstad8_1.Visible = false;
            Falstad8_2.Visible = false;
            Falstad8_3.Visible = false;
            Falstad8_4.Visible = false;
            Falstad1_1.Visible = true;
            Falstad2_1.Visible = true;
            Falstad3_3.Visible = true;
            Falstad4_1.Visible = true;
            Falstad6_3.Visible = true;
            Falstad7_4.Visible = true;
            Falstad8_3.Visible = true;
        }

        private void FalstadPowerThrow_MouseHover(object sender, EventArgs e)
        {
            FalstadPowerThrow_ToolTip.SetToolTip(FalstadPowerThrow, "Increase the range of Hammerang by 40% and the slow duration by 25%.");
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            FalstadHammerang_ToolTip.SetToolTip(pictureBox6, "70 Mana\n\nCooldown: 10 seconds\n\nSkillshot: Throw out a Hammer that returns to you, dealing 290 (62 + 12 per level) damage and slowing enemies by 25% for 2 seconds.");
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            FalstadLightningRod_ToolTip.SetToolTip(pictureBox5, "70 Mana \n \n Cooldown: 15 seconds\n\nDeal 235 (45 + 10 per level) to an enemy, and an additional 165 (32 + 7 per level) damage per second for 4.25 seconds if you remain close to the target.");
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            FalstadBarrelRoll_ToolTip.SetToolTip(pictureBox4, "75 Mana\n\nCooldown: 14 seconds\n\nDashes forward and grants a 375 (90 + 15 per level) point Shield for 2 seconds.");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            FalstadMightGust_ToolTip.SetToolTip(pictureBox3, "70 Mana\n\nCooldown: 50 seconds\n\nHeroic Ability: Push enemies away and slow their Movement Speed by 60%, decaying over 3 seconds.");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            FalstadHinterland_Tooltip.SetToolTip(pictureBox2, "100 Mana\n\nCooldown: 90 seconds\n\nHeroic Ability: Skillshot: After a short delay, deal 900 (311 + 31 per level) damage to enemies within a long line.");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            FalstadTailwind_ToolTip.SetToolTip(pictureBox1, "Trait: Gain 20% increased Movement Speed after not taking damage for 6 seconds.");
        }

        private void FalstadPowerThrow_Click(object sender, EventArgs e)
        {
            Falstad1_1.Visible = true;
            Falstad1_2.Visible = false;
            Falstad1_3.Visible = false;
            Falstad1_4.Visible = false;
        }

        private void FalstadUpdraft_Click(object sender, EventArgs e)
        {
            Falstad1_1.Visible = false;
            Falstad1_2.Visible = true;
            Falstad1_3.Visible = false;
            Falstad1_4.Visible = false;
        }

        private void FalstadSeasonedMarksman_Click(object sender, EventArgs e)
        {
            Falstad1_1.Visible = false;
            Falstad1_2.Visible = false;
            Falstad1_3.Visible = true;
            Falstad1_4.Visible = false;
        }

        private void FalstadConjuerer_Click(object sender, EventArgs e)
        {
            Falstad1_1.Visible = false;
            Falstad1_2.Visible = false;
            Falstad1_3.Visible = false;
            Falstad1_4.Visible = true;
        }

        private void FalstadBribe_Click(object sender, EventArgs e)
        {
            Falstad1_1.Visible = false;
            Falstad1_2.Visible = false;
            Falstad1_3.Visible = false;
            Falstad1_4.Visible = false;
            Falstad1_5.Visible = true;
        }

        private void FalstadChargedUp_Click(object sender, EventArgs e)
        {
            Falstad2_1.Visible = true;
            Falstad2_2.Visible = false;
            Falstad2_3.Visible = false;
            Falstad2_4.Visible = false;
        }

        private void FalstadFlowRider_Click(object sender, EventArgs e)
        {
            Falstad2_1.Visible = false;
            Falstad2_2.Visible = true;
            Falstad2_3.Visible = false;
            Falstad2_4.Visible = false;
        }

        private void FalstadVampiric_Click(object sender, EventArgs e)
        {
            Falstad2_1.Visible = false;
            Falstad2_2.Visible = false;
            Falstad2_3.Visible = true;
            Falstad2_4.Visible = false;
        }

        private void FalstadGatheringPower_Click(object sender, EventArgs e)
        {
            Falstad2_1.Visible = false;
            Falstad2_2.Visible = false;
            Falstad2_3.Visible = false;
            Falstad2_4.Visible = true;
        }

        private void FalstadMomentum_Click(object sender, EventArgs e)
        {
            Falstad3_1.Visible = true;
            Falstad3_2.Visible = false;
            Falstad3_3.Visible = false;
            Falstad3_4.Visible = false;
            Falstad3_5.Visible = false;
        }

        private void FalstadSecret_Click(object sender, EventArgs e)
        {
            Falstad3_1.Visible = false;
            Falstad3_2.Visible = true;
            Falstad3_3.Visible = false;
            Falstad3_4.Visible = false;
            Falstad3_5.Visible = false;
        }

        private void FalstadBoomerang_Click(object sender, EventArgs e)
        {
            Falstad3_1.Visible = false;
            Falstad3_2.Visible = false;
            Falstad3_3.Visible = true;
            Falstad3_4.Visible = false;
            Falstad3_5.Visible = false;
        }

        private void FalstadFreeRoll_Click(object sender, EventArgs e)
        {
            Falstad3_1.Visible = false;
            Falstad3_2.Visible = false;
            Falstad3_3.Visible = false;
            Falstad3_4.Visible = true;
            Falstad3_5.Visible = false;
        }

        private void FalstadFirstAid_Click(object sender, EventArgs e)
        {
            Falstad3_1.Visible = false;
            Falstad3_2.Visible = false;
            Falstad3_3.Visible = false;
            Falstad3_4.Visible = false;
            Falstad3_5.Visible = true;
        }

        private void FalstadHinterland_Click(object sender, EventArgs e)
        {
            Falstad4_1.Visible = true;
            Falstad4_2.Visible = false;
        }

        private void FalstadMightyGust_Click(object sender, EventArgs e)
        {
            Falstad4_1.Visible = false;
            Falstad4_2.Visible = true;
        }

        private void FalstadGiantKiller_Click(object sender, EventArgs e)
        {
            Falstad6_1.Visible = true;
            Falstad6_2.Visible = false;
            Falstad6_3.Visible = false;
            Falstad6_4.Visible = false;
        }

        private void FalstadCripplingHammer_Click(object sender, EventArgs e)
        {
            Falstad6_1.Visible = false;
            Falstad6_2.Visible = true;
            Falstad6_3.Visible = false;
            Falstad6_4.Visible = false;
        }

        private void FalstadThunderstrikes_Click(object sender, EventArgs e)
        {
            Falstad6_1.Visible = false;
            Falstad6_2.Visible = false;
            Falstad6_3.Visible = true;
            Falstad6_4.Visible = false;
        }

        private void FalstadStaticShield_Click(object sender, EventArgs e)
        {
            Falstad6_1.Visible = false;
            Falstad6_2.Visible = false;
            Falstad6_3.Visible = false;
            Falstad6_4.Visible = true;
        }

        private void FalstadAerieGusts_Click(object sender, EventArgs e)
        {
            Falstad7_1.Visible = true;
            Falstad7_2.Visible = false;
            Falstad7_3.Visible = false;
            Falstad7_4.Visible = false;
        }

        private void FalstadHammerTime_Click(object sender, EventArgs e)
        {
            Falstad7_1.Visible = false;
            Falstad7_2.Visible = true;
            Falstad7_3.Visible = false;
            Falstad7_4.Visible = false;
        }

        private void FalstadAfterburner_Click(object sender, EventArgs e)
        {
            Falstad7_1.Visible = false;
            Falstad7_2.Visible = false;
            Falstad7_3.Visible = true;
            Falstad7_4.Visible = false;
        }

        private void FalstadOverdrive_Click(object sender, EventArgs e)
        {
            Falstad7_1.Visible = false;
            Falstad7_2.Visible = false;
            Falstad7_3.Visible = false;
            Falstad7_4.Visible = true;
        }

        private void FalstadWildhammer_Click(object sender, EventArgs e)
        {
            Falstad8_1.Visible = true;
            Falstad8_2.Visible = false;
            Falstad8_3.Visible = false;
            Falstad8_4.Visible = false;

        }

        private void FalstadWindTunnel_Click(object sender, EventArgs e)
        {
            Falstad8_1.Visible = false;
            Falstad8_2.Visible = true;
            Falstad8_3.Visible = false;
            Falstad8_4.Visible = false;

        }

        private void FalstadNexus_Click(object sender, EventArgs e)
        {
            Falstad8_1.Visible = false;
            Falstad8_2.Visible = false;
            Falstad8_3.Visible = true;
            Falstad8_4.Visible = false;

        }

        private void FalstadEpicMount_Click(object sender, EventArgs e)
        {
            Falstad8_1.Visible = false;
            Falstad8_2.Visible = false;
            Falstad8_3.Visible = false;
            Falstad8_4.Visible = true;

        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {
            btnRecommend.BackColor = Color.Maroon;

            if (btnRecommend.BackColor == Color.Black)
                btnRecommend.BackColor = Color.Maroon;

            Falstad1_1.Visible = true;
            Falstad2_1.Visible = true;
            Falstad3_3.Visible = true;
            Falstad4_1.Visible = true;
            Falstad6_3.Visible = true;
            Falstad7_4.Visible = true;
            Falstad8_3.Visible = true;

            Falstad1_2.Visible = false;
            Falstad1_3.Visible = false;
            Falstad1_4.Visible = false;
            Falstad1_5.Visible = false;
            Falstad2_2.Visible = false;
            Falstad2_3.Visible = false;
            Falstad2_4.Visible = false;
            Falstad3_1.Visible = false;
            Falstad3_2.Visible = false;
            Falstad3_4.Visible = false;
            Falstad3_5.Visible = false;
            Falstad4_2.Visible = false;
            Falstad6_1.Visible = false;
            Falstad6_2.Visible = false;
            Falstad6_4.Visible = false;
            Falstad7_1.Visible = false;
            Falstad7_2.Visible = false;
            Falstad7_3.Visible = false;
            Falstad8_1.Visible = false;
            Falstad8_2.Visible = false;
            Falstad8_4.Visible = false;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            Falstad1_1.Visible = false;
            Falstad2_1.Visible = false;
            Falstad3_3.Visible = false;
            Falstad4_1.Visible = false;
            Falstad6_3.Visible = false;
            Falstad7_4.Visible = false;
            Falstad8_3.Visible = false;
            Falstad1_2.Visible = false;
            Falstad1_3.Visible = false;
            Falstad1_4.Visible = false;
            Falstad1_5.Visible = false;
            Falstad2_2.Visible = false;
            Falstad2_3.Visible = false;
            Falstad2_4.Visible = false;
            Falstad3_1.Visible = false;
            Falstad3_2.Visible = false;
            Falstad3_4.Visible = false;
            Falstad3_5.Visible = false;
            Falstad4_2.Visible = false;
            Falstad6_1.Visible = false;
            Falstad6_2.Visible = false;
            Falstad6_4.Visible = false;
            Falstad7_1.Visible = false;
            Falstad7_2.Visible = false;
            Falstad7_3.Visible = false;
            Falstad8_1.Visible = false;
            Falstad8_2.Visible = false;
            Falstad8_4.Visible = false;
            btnRecommend.BackColor = Color.Black;
         

        }

        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;

        private void btnSave_Click(object sender, EventArgs e)
        {
            bmpScreenshot = new Bitmap(this.Bounds.Width, this.Bounds.Height, PixelFormat.Format32bppArgb); gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(this.Bounds.X, this.Bounds.Y, 0, 0, this.Bounds.Size, CopyPixelOperation.SourceCopy);
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Title = "Select output file:";
            saveImageDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveImageDialog.FileName = "Falstad Talent Build";

            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                bmpScreenshot.Save(saveImageDialog.FileName, ImageFormat.Png);
            }

        }

        private void FalstadUpdraft_MouseHover(object sender, EventArgs e)
        {
            FalstadUpdraft_ToolTip.SetToolTip(FalstadUpdraft, "Increase the range of Barrel Roll by 30%.");
        }

        private void FalstadSeasonedMarksman_MouseHover(object sender, EventArgs e)
        {
            FalstadSeasoned_ToolTip.SetToolTip(FalstadSeasonedMarksman, "For every 6 enemy Minion or Mercenary kills near your Hero, gain 1 Basic Attack damage.\n Hero Takedowns count as 2 Minion kills.");
        }

        private void FalstadConjuerer_MouseHover(object sender, EventArgs e)
        {
            FalstadConjuerer_ToolTip.SetToolTip(FalstadConjuerer, "Increases Mana Regeneration by 0.5 per second.\n Every 3 Regeneration Globes gathered increases this bonus by 0.25.");
        }

        private void FalstadBribe_MouseHover(object sender, EventArgs e)
        {
            FalstadBribe_ToolTip.SetToolTip(FalstadBribe, "Kill enemy Minions to gain stacks of Bribe.\n Use 20 stacks to bribe target Mercenary, instantly defeating them. \n Does not work on Bosses.");
        }

        private void FalstadChargedUp_MouseHover(object sender, EventArgs e)
        {
            FalstadChargedUp_ToolTip.SetToolTip(FalstadChargedUp, "Lightning Rod strikes the target 2 additional times.");
        }

        private void FalstadFlowRider_MouseHover(object sender, EventArgs e)
        {
            FalstadFlowRider_ToolTip.SetToolTip(FalstadFlowRider, "Lowers the cooldown of Barrel Roll by 40%.");
        }

        private void FalstadVampiric_MouseHover(object sender, EventArgs e)
        {
            FalstadVampiric_ToolTip.SetToolTip(FalstadVampiric, "Basic Attacks heal for 15% of the damage dealt to the primary target.");
        }

        private void FalstadGatheringPower_MouseHover(object sender, EventArgs e)
        {
            FalstadGatheringPower_ToolTip.SetToolTip(FalstadGatheringPower, "Passively grants 5% Ability Power.\nEach Hero takedown increases this bonus by 2% to a maximum of 15%.\nThis bonus Ability Power is reset to 5% on death.");
        }

        private void FalstadMomentum_MouseHover(object sender, EventArgs e)
        {
            FalstadBattleMomentum_ToolTip.SetToolTip(FalstadMomentum, "Basic Attacks reduce Ability cooldowns by 0.5 seconds.");
        }

        private void FalstadSecret_MouseHover(object sender, EventArgs e)
        {
            FalstadSecretWeapon_ToolTip.SetToolTip(FalstadSecret, "Weapon Basic Attacks deal 80% bonus damage while Hammerang is in flight.");
        }

        private void FalstadBoomerang_MouseHover(object sender, EventArgs e)
        {
            FalstadBoomerang_ToolTip.SetToolTip(FalstadBoomerang, "Reactivate Hammerang mid-flight to deal 25 damage around the Hammer.");
        }

        private void FalstadFreeRoll_MouseHover(object sender, EventArgs e)
        {
            FalstadFreeRoll_ToolTip.SetToolTip(FalstadFreeRoll, "Barrel Roll costs no mana.");
        }

        private void FalstadFirstAid_MouseHover(object sender, EventArgs e)
        {
            FalstadFirstAid_ToolTip.SetToolTip(FalstadFirstAid, "Cooldown:\n60 seconds\nActivate to heal 11.07% of your max Health over 6 seconds.");
        }

        private void FalstadHinterland_MouseHover(object sender, EventArgs e)
        {
            FalstadHinterland_Tooltip.SetToolTip(FalstadHinterland, "Cooldown:\n90 seconds\nAfter a short delay, deal 280 damage to enemies within a long line.");
        }

        private void FalstadMightyGust_MouseHover(object sender, EventArgs e)
        {
            FalstadMightGust_ToolTip.SetToolTip(FalstadMightyGust, "Cooldown:\n50 seconds\nPush enemies away and slow their Movement Speed by 60%, decaying over 3 seconds.");
        }

        private void FalstadGiantKiller_MouseHover(object sender, EventArgs e)
        {
            FalstadGiantKiller_ToolTip.SetToolTip(FalstadGiantKiller, "Basic Attacks against enemy Heroes deal bonus damage equal to 1.5% of the Hero's maximum Health.");
        }

        private void FalstadCripplingHammer_MouseHover(object sender, EventArgs e)
        {
            FalstadCrippling_ToolTip.SetToolTip(FalstadCripplingHammer, "Increases the Movement Speed Slow of Hammerang to 50%.");
        }

        private void FalstadThunderstrikes_MouseHover(object sender, EventArgs e)
        {
            FalstadThunderstrikes_ToolTip.SetToolTip(FalstadThunderstrikes, "Lightning Rod deals 15% more damage each subsequent strike.");
        }

        private void FalstadStaticShield_MouseHover(object sender, EventArgs e)
        {
            FalstadStatic_ToolTip.SetToolTip(FalstadStaticShield, "Gain a Shield equal to 5% of your maximum Health after every Lightning Rod strike.\nLasts 4 seconds and stacks.");
        }

        private void FalstadAerieGusts_MouseHover(object sender, EventArgs e)
        {
            FalstadAerie_ToolTip.SetToolTip(FalstadAerieGusts, "Reduce activation time for Tailwind to 2 seconds, and increase the Movement Speed bonus to 30%.");
        }

        private void FalstadHammerTime_MouseHover(object sender, EventArgs e)
        {
            FalstadHammerang_ToolTip.SetToolTip(FalstadHammerTime, "Your first Basic Attack against a target slowed by Hammerang will stun them for 0.75 seconds.");
        }

        private void FalstadAfterburner_MouseHover(object sender, EventArgs e)
        {
            FalstadAfterburner_ToolTip.SetToolTip(FalstadAfterburner, "After using Barrel Roll, gain 60% Movement Speed that decreases over 3 seconds.");
        }

        private void FalstadOverdrive_MouseHover(object sender, EventArgs e)
        {
            FalstadOverdrive_ToolTip.SetToolTip(FalstadOverdrive, "Cooldown:\n25 Seconds\nActivate to increase Ability Power by 25% and Mana costs by 40% for 5 seconds.");
        }

        private void FalstadWildhammer_MouseHover(object sender, EventArgs e)
        {
            FalstadWildhammer_ToolTip.SetToolTip(FalstadWildhammer, "Hinterland Blast has double the range and deals 25% more damage.");
        }

        private void FalstadWindTunnel_MouseHover(object sender, EventArgs e)
        {
            FalstadWindTunnel_ToolTip.SetToolTip(FalstadWindTunnel, "Mighty Gust creates a wind tunnel for 4 seconds.\nEnemies caught in the tunnel will periodically be pushed back.");
        }

        private void FalstadNexus_MouseHover(object sender, EventArgs e)
        {
            FalstadNexus_ToolTip.SetToolTip(FalstadNexus, "Increases Attack Speed by 20% and Attack Range by 20%.");
        }

        private void FalstadEpicMount_MouseHover(object sender, EventArgs e)
        {
            FalstadEpicMount_ToolTip.SetToolTip(FalstadEpicMount, "Reduce the cooldown of Flight to 20 seconds,\nreduce the cast time before flying to 0.5 seconds, and increase the speed by 50%.");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
