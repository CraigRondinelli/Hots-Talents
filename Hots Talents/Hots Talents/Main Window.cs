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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Papachips' HOTS Talent Calculator";

            DoubleBuffered = true;

            picQAbility.Visible = false;
            picWAbility.Visible = false;
            picEAbility.Visible = false;
            picR1Ability.Visible = false;
            picR2Ability.Visible = false;
            picTrait.Visible = false;

            Ability1_1.Visible = false;
            Ability1_2.Visible = false;
            Ability1_3.Visible = false;
            Ability1_4.Visible = false;
            Ability1_5.Visible = false;
            Ability2_1.Visible = false;
            Ability2_2.Visible = false;
            Ability2_3.Visible = false;
            Ability2_4.Visible = false;
            Ability2_5.Visible = false;
            Ability3_1.Visible = false;
            Ability3_2.Visible = false;
            Ability3_3.Visible = false;
            Ability3_4.Visible = false;
            Ability3_5.Visible = false;
            Ability4_1.Visible = false;
            Ability4_2.Visible = false;
            Ability5_1.Visible = false;
            Ability5_2.Visible = false;
            Ability5_3.Visible = false;
            Ability5_4.Visible = false;
            Ability5_5.Visible = false;
            Ability6_1.Visible = false;
            Ability6_2.Visible = false;
            Ability6_3.Visible = false;
            Ability6_4.Visible = false;
            Ability6_5.Visible = false;
            Ability7_1.Visible = false;
            Ability7_2.Visible = false;
            Ability7_3.Visible = false;
            Ability7_4.Visible = false;
            Ability7_5.Visible = false;

            Border1_1.Visible = false;
            Border1_2.Visible = false;
            Border1_3.Visible = false;
            Border1_4.Visible = false;
            Border1_5.Visible = false;
            Border2_1.Visible = false;
            Border2_2.Visible = false;
            Border2_3.Visible = false;
            Border2_4.Visible = false;
            Border2_5.Visible = false;
            Border3_1.Visible = false;
            Border3_2.Visible = false;
            Border3_3.Visible = false;
            Border3_4.Visible = false;
            Border3_5.Visible = false;
            Border4_1.Visible = false;
            Border4_2.Visible = false;
            Border5_1.Visible = false;
            Border5_2.Visible = false;
            Border5_3.Visible = false;
            Border5_4.Visible = false;
            Border5_5.Visible = false;
            Border6_1.Visible = false;
            Border6_2.Visible = false;
            Border6_3.Visible = false;
            Border6_4.Visible = false;
            Border6_5.Visible = false;
            Border7_1.Visible = false;
            Border7_2.Visible = false;
            Border7_3.Visible = false;
            Border7_4.Visible = false;
            Border7_5.Visible = false;

            lblSpecial.Visible = false;
            picSpec1.Visible = false;
            picSpec2.Visible = false;
            picSpec3.Visible = false;
            picSpec4.Visible = false;

            spec1.Visible = false;
            spec2.Visible = false;
            spec3.Visible = false;
            spec4.Visible = false;

            lblQ.Text = "";
            lblW.Text = "";
            lblE.Text = "";
            lblR1.Text = "";
            lblR2.Text = "";
            lblTrait.Text = "";
            lblHero.Text = "";
            lblGold.Text = "";

            picHero.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            label14.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
            label11.Visible = false;
            label10.Visible = false;
            picGold.Visible = false;

            trackbarlabel.Text = "Level " + trackBar1.Value.ToString();
        }

        int growW = 154;
        int growH = 50;

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Thread thrd = new System.Threading.Thread(new System.Threading.ThreadStart(LoadBackgroundImage));
            thrd.Start();
        }
        private void LoadBackgroundImage()
        {
            Image img = Image.FromFile(@"C:\Users\Craig\Desktop\Hots Icons\Wiki-background.bmp");
            this.BackgroundImage = img;
        }

        void initial()
        {
            if (this.Width >= 846)
            {
                panel1.Visible = false;
            }

            if (lblHero.Text == "Abathur")
            {
                lblSpecial.Visible = true;
                picSpec1.Visible = true;
                picSpec2.Visible = true;
                picSpec3.Visible = true;
                picSpec4.Visible = true;
                spec1.Visible = true;
                spec2.Visible = true;
                spec3.Visible = true;
                spec4.Visible = true;

                Border1_1.Visible = false;
                Border1_2.Visible = false;
                Border1_3.Visible = false;
                Border1_4.Visible = false;
                Border1_5.Visible = false;
                Border2_1.Visible = false;
                Border2_2.Visible = false;
                Border2_3.Visible = false;
                Border2_4.Visible = false;
                Border2_5.Visible = false;
                Border3_1.Visible = false;
                Border3_2.Visible = false;
                Border3_3.Visible = false;
                Border3_4.Visible = false;
                Border3_5.Visible = false;
                Border4_1.Visible = false;
                Border4_2.Visible = false;
                Border5_1.Visible = false;
                Border5_2.Visible = false;
                Border5_3.Visible = false;
                Border5_4.Visible = false;
                Border5_5.Visible = false;
                Border6_1.Visible = false;
                Border6_2.Visible = false;
                Border6_3.Visible = false;
                Border6_4.Visible = false;
                Border6_5.Visible = false;
                Border7_1.Visible = false;
                Border7_2.Visible = false;
                Border7_3.Visible = false;
                Border7_4.Visible = false;
                Border7_5.Visible = false;

                Ability1_1.Visible = true;
                Ability1_2.Visible = true;
                Ability1_3.Visible = true;
                Ability1_4.Visible = true;
                Ability2_1.Visible = true;
                Ability2_2.Visible = true;
                Ability2_3.Visible = true;
                Ability2_4.Visible = true;
                Ability3_1.Visible = true;
                Ability3_2.Visible = true;
                Ability3_3.Visible = true;
                Ability3_4.Visible = true;
                Ability4_1.Visible = true;
                Ability4_2.Visible = true;
                Ability5_1.Visible = true;
                Ability5_2.Visible = true;
                Ability5_3.Visible = true;
                Ability5_4.Visible = true;
                Ability6_1.Visible = true;
                Ability6_2.Visible = true;
                Ability6_3.Visible = true;
                Ability6_4.Visible = true;
                Ability7_1.Visible = true;
                Ability7_2.Visible = true;
                Ability7_3.Visible = true;
                Ability7_4.Visible = true;

                picQAbility.Visible = true;
                picWAbility.Visible = true;
                picEAbility.Visible = true;
                picR1Ability.Visible = true;
                picR2Ability.Visible = true;
                picTrait.Visible = true;


                picHero.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label10.Visible = true;
                picGold.Visible = true;

                trackBar1.Value = 1;
            }

            else if (lblHero.Text == "The Lost Vikings")
            {

                lblSpecial.Visible = true;
                picSpec1.Visible = true;
                spec1.Visible = true;


                Border1_1.Visible = false;
                Border1_2.Visible = false;
                Border1_3.Visible = false;
                Border1_4.Visible = false;
                Border1_5.Visible = false;
                Border2_1.Visible = false;
                Border2_2.Visible = false;
                Border2_3.Visible = false;
                Border2_4.Visible = false;
                Border2_5.Visible = false;
                Border3_1.Visible = false;
                Border3_2.Visible = false;
                Border3_3.Visible = false;
                Border3_4.Visible = false;
                Border3_5.Visible = false;
                Border4_1.Visible = false;
                Border4_2.Visible = false;
                Border5_1.Visible = false;
                Border5_2.Visible = false;
                Border5_3.Visible = false;
                Border5_4.Visible = false;
                Border5_5.Visible = false;
                Border6_1.Visible = false;
                Border6_2.Visible = false;
                Border6_3.Visible = false;
                Border6_4.Visible = false;
                Border6_5.Visible = false;
                Border7_1.Visible = false;
                Border7_2.Visible = false;
                Border7_3.Visible = false;
                Border7_4.Visible = false;
                Border7_5.Visible = false;

                Ability1_1.Visible = true;
                Ability1_2.Visible = true;
                Ability1_3.Visible = true;
                Ability1_4.Visible = true;
                Ability2_1.Visible = true;
                Ability2_2.Visible = true;
                Ability2_3.Visible = true;
                Ability2_4.Visible = true;
                Ability3_1.Visible = true;
                Ability3_2.Visible = true;
                Ability3_3.Visible = true;
                Ability3_4.Visible = true;
                Ability4_1.Visible = true;
                Ability4_2.Visible = true;
                Ability5_1.Visible = true;
                Ability5_2.Visible = true;
                Ability5_3.Visible = true;
                Ability5_4.Visible = true;
                Ability6_1.Visible = true;
                Ability6_2.Visible = true;
                Ability6_3.Visible = true;
                Ability6_4.Visible = true;
                Ability7_1.Visible = true;
                Ability7_2.Visible = true;
                Ability7_3.Visible = true;
                Ability7_4.Visible = true;

                picQAbility.Visible = true;
                picWAbility.Visible = true;
                picEAbility.Visible = true;
                picR1Ability.Visible = true;
                picR2Ability.Visible = true;
                picTrait.Visible = true;


                picHero.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label10.Visible = true;
                picGold.Visible = true;

                trackBar1.Value = 1;
            }

            else if (lblHero.Text == "Brightwing")
            {

                lblSpecial.Visible = true;
                picSpec1.Visible = true;
                spec1.Visible = true;


                Border1_1.Visible = false;
                Border1_2.Visible = false;
                Border1_3.Visible = false;
                Border1_4.Visible = false;
                Border1_5.Visible = false;
                Border2_1.Visible = false;
                Border2_2.Visible = false;
                Border2_3.Visible = false;
                Border2_4.Visible = false;
                Border2_5.Visible = false;
                Border3_1.Visible = false;
                Border3_2.Visible = false;
                Border3_3.Visible = false;
                Border3_4.Visible = false;
                Border3_5.Visible = false;
                Border4_1.Visible = false;
                Border4_2.Visible = false;
                Border5_1.Visible = false;
                Border5_2.Visible = false;
                Border5_3.Visible = false;
                Border5_4.Visible = false;
                Border5_5.Visible = false;
                Border6_1.Visible = false;
                Border6_2.Visible = false;
                Border6_3.Visible = false;
                Border6_4.Visible = false;
                Border6_5.Visible = false;
                Border7_1.Visible = false;
                Border7_2.Visible = false;
                Border7_3.Visible = false;
                Border7_4.Visible = false;
                Border7_5.Visible = false;

                Ability1_1.Visible = true;
                Ability1_2.Visible = true;
                Ability1_3.Visible = true;
                Ability1_4.Visible = true;
                Ability2_1.Visible = true;
                Ability2_2.Visible = true;
                Ability2_3.Visible = true;
                Ability2_4.Visible = true;
                Ability3_1.Visible = true;
                Ability3_2.Visible = true;
                Ability3_3.Visible = true;
                Ability3_4.Visible = true;
                Ability4_1.Visible = true;
                Ability4_2.Visible = true;
                Ability5_1.Visible = true;
                Ability5_2.Visible = true;
                Ability5_3.Visible = true;
                Ability5_4.Visible = true;
                Ability6_1.Visible = true;
                Ability6_2.Visible = true;
                Ability6_3.Visible = true;
                Ability6_4.Visible = true;
                Ability7_1.Visible = true;
                Ability7_2.Visible = true;
                Ability7_3.Visible = true;
                Ability7_4.Visible = true;

                picQAbility.Visible = true;
                picWAbility.Visible = true;
                picEAbility.Visible = true;
                picR1Ability.Visible = true;
                picR2Ability.Visible = true;
                picTrait.Visible = true;


                picHero.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label10.Visible = true;
                picGold.Visible = true;

                trackBar1.Value = 1;
            }
            else if (lblHero.Text == "Falstad")
            {

                lblSpecial.Visible = true;
                picSpec1.Visible = true;
                spec1.Visible = true;


                Border1_1.Visible = false;
                Border1_2.Visible = false;
                Border1_3.Visible = false;
                Border1_4.Visible = false;
                Border1_5.Visible = false;
                Border2_1.Visible = false;
                Border2_2.Visible = false;
                Border2_3.Visible = false;
                Border2_4.Visible = false;
                Border2_5.Visible = false;
                Border3_1.Visible = false;
                Border3_2.Visible = false;
                Border3_3.Visible = false;
                Border3_4.Visible = false;
                Border3_5.Visible = false;
                Border4_1.Visible = false;
                Border4_2.Visible = false;
                Border5_1.Visible = false;
                Border5_2.Visible = false;
                Border5_3.Visible = false;
                Border5_4.Visible = false;
                Border5_5.Visible = false;
                Border6_1.Visible = false;
                Border6_2.Visible = false;
                Border6_3.Visible = false;
                Border6_4.Visible = false;
                Border6_5.Visible = false;
                Border7_1.Visible = false;
                Border7_2.Visible = false;
                Border7_3.Visible = false;
                Border7_4.Visible = false;
                Border7_5.Visible = false;

                Ability1_1.Visible = true;
                Ability1_2.Visible = true;
                Ability1_3.Visible = true;
                Ability1_4.Visible = true;
                Ability2_1.Visible = true;
                Ability2_2.Visible = true;
                Ability2_3.Visible = true;
                Ability2_4.Visible = true;
                Ability3_1.Visible = true;
                Ability3_2.Visible = true;
                Ability3_3.Visible = true;
                Ability3_4.Visible = true;
                Ability4_1.Visible = true;
                Ability4_2.Visible = true;
                Ability5_1.Visible = true;
                Ability5_2.Visible = true;
                Ability5_3.Visible = true;
                Ability5_4.Visible = true;
                Ability6_1.Visible = true;
                Ability6_2.Visible = true;
                Ability6_3.Visible = true;
                Ability6_4.Visible = true;
                Ability7_1.Visible = true;
                Ability7_2.Visible = true;
                Ability7_3.Visible = true;
                Ability7_4.Visible = true;

                picQAbility.Visible = true;
                picWAbility.Visible = true;
                picEAbility.Visible = true;
                picR1Ability.Visible = true;
                picR2Ability.Visible = true;
                picTrait.Visible = true;


                picHero.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label10.Visible = true;
                picGold.Visible = true;

                trackBar1.Value = 1;
            }
            else if (lblHero.Text == "Sgt. Hammer")
            {

                lblSpecial.Visible = true;
                picSpec1.Visible = true;
                spec1.Visible = true;


                Border1_1.Visible = false;
                Border1_2.Visible = false;
                Border1_3.Visible = false;
                Border1_4.Visible = false;
                Border1_5.Visible = false;
                Border2_1.Visible = false;
                Border2_2.Visible = false;
                Border2_3.Visible = false;
                Border2_4.Visible = false;
                Border2_5.Visible = false;
                Border3_1.Visible = false;
                Border3_2.Visible = false;
                Border3_3.Visible = false;
                Border3_4.Visible = false;
                Border3_5.Visible = false;
                Border4_1.Visible = false;
                Border4_2.Visible = false;
                Border5_1.Visible = false;
                Border5_2.Visible = false;
                Border5_3.Visible = false;
                Border5_4.Visible = false;
                Border5_5.Visible = false;
                Border6_1.Visible = false;
                Border6_2.Visible = false;
                Border6_3.Visible = false;
                Border6_4.Visible = false;
                Border6_5.Visible = false;
                Border7_1.Visible = false;
                Border7_2.Visible = false;
                Border7_3.Visible = false;
                Border7_4.Visible = false;
                Border7_5.Visible = false;

                Ability1_1.Visible = true;
                Ability1_2.Visible = true;
                Ability1_3.Visible = true;
                Ability1_4.Visible = true;
                Ability2_1.Visible = true;
                Ability2_2.Visible = true;
                Ability2_3.Visible = true;
                Ability2_4.Visible = true;
                Ability3_1.Visible = true;
                Ability3_2.Visible = true;
                Ability3_3.Visible = true;
                Ability3_4.Visible = true;
                Ability4_1.Visible = true;
                Ability4_2.Visible = true;
                Ability5_1.Visible = true;
                Ability5_2.Visible = true;
                Ability5_3.Visible = true;
                Ability5_4.Visible = true;
                Ability6_1.Visible = true;
                Ability6_2.Visible = true;
                Ability6_3.Visible = true;
                Ability6_4.Visible = true;
                Ability7_1.Visible = true;
                Ability7_2.Visible = true;
                Ability7_3.Visible = true;
                Ability7_4.Visible = true;

                picQAbility.Visible = true;
                picWAbility.Visible = true;
                picEAbility.Visible = true;
                picR1Ability.Visible = true;
                picR2Ability.Visible = true;
                picTrait.Visible = true;


                picHero.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label10.Visible = true;
                picGold.Visible = true;

                trackBar1.Value = 1;
            }
            else
            {
                Border1_1.Visible = false;
                Border1_2.Visible = false;
                Border1_3.Visible = false;
                Border1_4.Visible = false;
                Border1_5.Visible = false;
                Border2_1.Visible = false;
                Border2_2.Visible = false;
                Border2_3.Visible = false;
                Border2_4.Visible = false;
                Border2_5.Visible = false;
                Border3_1.Visible = false;
                Border3_2.Visible = false;
                Border3_3.Visible = false;
                Border3_4.Visible = false;
                Border3_5.Visible = false;
                Border4_1.Visible = false;
                Border4_2.Visible = false;
                Border5_1.Visible = false;
                Border5_2.Visible = false;
                Border5_3.Visible = false;
                Border5_4.Visible = false;
                Border5_5.Visible = false;
                Border6_1.Visible = false;
                Border6_2.Visible = false;
                Border6_3.Visible = false;
                Border6_4.Visible = false;
                Border6_5.Visible = false;
                Border7_1.Visible = false;
                Border7_2.Visible = false;
                Border7_3.Visible = false;
                Border7_4.Visible = false;
                Border7_5.Visible = false;

                Ability1_1.Visible = true;
                Ability1_2.Visible = true;
                Ability1_3.Visible = true;
                Ability1_4.Visible = true;
                Ability2_1.Visible = true;
                Ability2_2.Visible = true;
                Ability2_3.Visible = true;
                Ability2_4.Visible = true;
                Ability3_1.Visible = true;
                Ability3_2.Visible = true;
                Ability3_3.Visible = true;
                Ability3_4.Visible = true;
                Ability4_1.Visible = true;
                Ability4_2.Visible = true;
                Ability5_1.Visible = true;
                Ability5_2.Visible = true;
                Ability5_3.Visible = true;
                Ability5_4.Visible = true;
                Ability6_1.Visible = true;
                Ability6_2.Visible = true;
                Ability6_3.Visible = true;
                Ability6_4.Visible = true;
                Ability7_1.Visible = true;
                Ability7_2.Visible = true;
                Ability7_3.Visible = true;
                Ability7_4.Visible = true;

                picQAbility.Visible = true;
                picWAbility.Visible = true;
                picEAbility.Visible = true;
                picR1Ability.Visible = true;
                picR2Ability.Visible = true;
                picTrait.Visible = true;

                lblSpecial.Visible = false;
                picSpec1.Visible = false;
                picSpec2.Visible = false;
                picSpec3.Visible = false;
                picSpec4.Visible = false;

                spec1.Visible = false;
                spec2.Visible = false;
                spec3.Visible = false;
                spec4.Visible = false;

                picHero.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label10.Visible = true;
                picGold.Visible = true;

                trackBar1.Value = 1;
            }
        }


        //**ASSASSINS**//

        System.Media.SoundPlayer open = new System.Media.SoundPlayer(@"open.wav");

        private void pic_assassin_Click(object sender, EventArgs e)
        {
            open.Play();

            while (this.Height < 1000)
            {
                this.Height += growH;
                Application.DoEvents();
            }

            //ASSASSIN PICS SHOW
            picFalstad.Visible = true;
            picIllidan.Visible = true;
            picJania.Visible = true;
            picKael.Visible = true;
            picKerrigan.Visible = true;
            picNova.Visible = true;
            picRaynor.Visible = true;
            picThrall.Visible = true;
            picTychus.Visible = true;
            picValla.Visible = true;
            picZeratul.Visible = true;

            //ASSASSIN LABELS SHOW
            lblFalstad.Visible = true;
            lblIllidan.Visible = true;
            lblJania.Visible = true;
            lblKael.Visible = true;
            lblKerrigan.Visible = true;
            lblNova.Visible = true;
            lblRaynor.Visible = true;
            lblThrall.Visible = true;
            lblTychus.Visible = true;
            lblValla.Visible = true;
            lblZeratul.Visible = true;
            lblAssassins.Visible = true;

            //WARRIOR PICS HIDE
            picAnub.Visible = false;
            picArthas.Visible = false;
            picChen.Visible = false;
            picDiablo.Visible = false;
            picETC.Visible = false;
            picJohanna.Visible = false;
            picMuradin.Visible = false;
            picSonya.Visible = false;
            picStitches.Visible = false;
            picTyrael.Visible = false;

            //WARRIOR LABELS HIDE
            lblWarriors.Visible = false;
            lblAnub.Visible = false;
            lblArthas.Visible = false;
            lblChen.Visible = false;
            lblDiablo.Visible = false;
            lblETC.Visible = false;
            lblJohanna.Visible = false;
            lblMuradin.Visible = false;
            lblSonya.Visible = false;
            lblStiches.Visible = false;
            lblTyrael.Visible = false;

            //SUPPORT LABELS HIDE
            lblBrightwing.Visible = false;
            lblLiLi.Visible = false;
            lblMalfurion.Visible = false;
            lblRehgar.Visible = false;
            lblSupoort.Visible = false;
            lblTassadar.Visible = false;
            lblTyrande.Visible = false;
            lblUther.Visible = false;

            //SUPPORT PICS HIDE
            picBrightwing.Visible = false;
            picLiLi.Visible = false;
            picMalfurion.Visible = false;
            picRehgar.Visible = false;
            picTassadar.Visible = false;
            picTyrande.Visible = false;
            picUther.Visible = false;

            //SPECIALIST PICS HIDE
            picAbathur.Visible = false;
            picAzmodan.Visible = false;
            picGazlowe.Visible = false;
            picHammer.Visible = false;
            picMurky.Visible = false;
            picNazeebo.Visible = false;
            picSylvanas.Visible = false;
            picVikings.Visible = false;
            picZagara.Visible = false;

            //SPECIALIST LABELS HIDE
            lblAbathur.Visible = false;
            lblAzmodan.Visible = false;
            lblGazlowe.Visible = false;
            lblHammer.Visible = false;
            lblMurky.Visible = false;
            lblNazeebo.Visible = false;
            lblSylvanas.Visible = false;
            lblVikings.Visible = false;
            lblZagara.Visible = false;
            lblSpecialists.Visible = false;
        }

        //**WARRIORS**//

        private void pic_warrior_Click(object sender, EventArgs e)
        {
            open.Play();

            while (this.Height < 1000)
            {
                this.Height += growH;
                Application.DoEvents();
            }

            //WARRIOR LABELS SHOW
            lblWarriors.Visible = true;
            lblAnub.Visible = true;
            lblArthas.Visible = true;
            lblChen.Visible = true;
            lblDiablo.Visible = true;
            lblETC.Visible = true;
            lblJohanna.Visible = true;
            lblMuradin.Visible = true;
            lblSonya.Visible = true;
            lblStiches.Visible = true;
            lblTyrael.Visible = true;

            //WARRIOR PICS SHOW
            picAnub.Visible = true;
            picArthas.Visible = true;
            picChen.Visible = true;
            picDiablo.Visible = true;
            picETC.Visible = true;
            picJohanna.Visible = true;
            picMuradin.Visible = true;
            picSonya.Visible = true;
            picStitches.Visible = true;
            picTyrael.Visible = true;

            //ASSASSIN PIC HIDE
            picFalstad.Visible = false;
            picIllidan.Visible = false;
            picJania.Visible = false;
            picKael.Visible = false;
            picKerrigan.Visible = false;
            picNova.Visible = false;
            picRaynor.Visible = false;
            picThrall.Visible = false;
            picTychus.Visible = false;
            picValla.Visible = false;
            picZeratul.Visible = false;

            //ASSASSIN LABELS HIDE
            lblFalstad.Visible = false;
            lblIllidan.Visible = false;
            lblJania.Visible = false;
            lblKael.Visible = false;
            lblKerrigan.Visible = false;
            lblNova.Visible = false;
            lblRaynor.Visible = false;
            lblThrall.Visible = false;
            lblTychus.Visible = false;
            lblValla.Visible = false;
            lblZeratul.Visible = false;
            lblAssassins.Visible = false;

            //SUPPORT LABELS HIDE
            lblBrightwing.Visible = false;
            lblLiLi.Visible = false;
            lblMalfurion.Visible = false;
            lblRehgar.Visible = false;
            lblSupoort.Visible = false;
            lblTassadar.Visible = false;
            lblTyrande.Visible = false;
            lblUther.Visible = false;

            //SUPPORT PICS HIDE
            picBrightwing.Visible = false;
            picLiLi.Visible = false;
            picMalfurion.Visible = false;
            picRehgar.Visible = false;
            picTassadar.Visible = false;
            picTyrande.Visible = false;
            picUther.Visible = false;

            //SPECIALIST PICS HIDE
            picAbathur.Visible = false;
            picAzmodan.Visible = false;
            picGazlowe.Visible = false;
            picHammer.Visible = false;
            picMurky.Visible = false;
            picNazeebo.Visible = false;
            picSylvanas.Visible = false;
            picVikings.Visible = false;
            picZagara.Visible = false;

            //SPECIALIST LABELS HIDE
            lblAbathur.Visible = false;
            lblAzmodan.Visible = false;
            lblGazlowe.Visible = false;
            lblHammer.Visible = false;
            lblMurky.Visible = false;
            lblNazeebo.Visible = false;
            lblSylvanas.Visible = false;
            lblVikings.Visible = false;
            lblZagara.Visible = false;
            lblSpecialists.Visible = false;

        }

        //**SUPPORTS**//

        private void pic_support_Click(object sender, EventArgs e)
        {
            open.Play();

            while (this.Height < 1000)
            {
                this.Height += growH;
                Application.DoEvents();
            }

            //SUPPORT PICS SHOW
            picBrightwing.Visible = true;
            picLiLi.Visible = true;
            picMalfurion.Visible = true;
            picRehgar.Visible = true;
            picTassadar.Visible = true;
            picTyrande.Visible = true;
            picUther.Visible = true;

            //SUPPORT LABELS SHOW
            lblBrightwing.Visible = true;
            lblLiLi.Visible = true;
            lblMalfurion.Visible = true;
            lblRehgar.Visible = true;
            lblSupoort.Visible = true;
            lblTassadar.Visible = true;
            lblTyrande.Visible = true;
            lblUther.Visible = true;

            //WARRIOR PICS HIDE
            picAnub.Visible = false;
            picArthas.Visible = false;
            picChen.Visible = false;
            picDiablo.Visible = false;
            picETC.Visible = false;
            picJohanna.Visible = false;
            picMuradin.Visible = false;
            picSonya.Visible = false;
            picStitches.Visible = false;
            picTyrael.Visible = false;

            //WARRIOR LABELS HIDE
            lblWarriors.Visible = false;
            lblAnub.Visible = false;
            lblArthas.Visible = false;
            lblChen.Visible = false;
            lblDiablo.Visible = false;
            lblETC.Visible = false;
            lblJohanna.Visible = false;
            lblMuradin.Visible = false;
            lblSonya.Visible = false;
            lblStiches.Visible = false;
            lblTyrael.Visible = false;

            //ASSASSIN PICS HIDE
            picFalstad.Visible = false;
            picIllidan.Visible = false;
            picJania.Visible = false;
            picKael.Visible = false;
            picKerrigan.Visible = false;
            picNova.Visible = false;
            picRaynor.Visible = false;
            picThrall.Visible = false;
            picTychus.Visible = false;
            picValla.Visible = false;
            picZeratul.Visible = false;

            //ASSASSIN LABELS HIDE
            lblFalstad.Visible = false;
            lblIllidan.Visible = false;
            lblJania.Visible = false;
            lblKael.Visible = false;
            lblKerrigan.Visible = false;
            lblNova.Visible = false;
            lblRaynor.Visible = false;
            lblThrall.Visible = false;
            lblTychus.Visible = false;
            lblValla.Visible = false;
            lblZeratul.Visible = false;
            lblAssassins.Visible = false;

            //SPECIALISTS PICS HIDE
            picAbathur.Visible = false;
            picAzmodan.Visible = false;
            picGazlowe.Visible = false;
            picHammer.Visible = false;
            picMurky.Visible = false;
            picNazeebo.Visible = false;
            picSylvanas.Visible = false;
            picVikings.Visible = false;
            picZagara.Visible = false;

            //SPECIALISTS LABELS HIDE
            lblAbathur.Visible = false;
            lblAzmodan.Visible = false;
            lblGazlowe.Visible = false;
            lblHammer.Visible = false;
            lblMurky.Visible = false;
            lblNazeebo.Visible = false;
            lblSylvanas.Visible = false;
            lblVikings.Visible = false;
            lblZagara.Visible = false;
            lblSpecialists.Visible = false;
        }

        //**SPECIALISTS**//

        private void pic_specialist_Click(object sender, EventArgs e)
        {
            open.Play();

            {
                while (this.Height < 1000)
                {
                    this.Height += growH;
                    Application.DoEvents();
                }

                //SPECIALISTS PICS SHOW
                picAbathur.Visible = true;
                picAzmodan.Visible = true;
                picGazlowe.Visible = true;
                picHammer.Visible = true;
                picMurky.Visible = true;
                picNazeebo.Visible = true;
                picSylvanas.Visible = true;
                picVikings.Visible = true;
                picZagara.Visible = true;

                //SPECIALISTS LABELS SHOW
                lblAbathur.Visible = true;
                lblAzmodan.Visible = true;
                lblGazlowe.Visible = true;
                lblHammer.Visible = true;
                lblMurky.Visible = true;
                lblNazeebo.Visible = true;
                lblSylvanas.Visible = true;
                lblVikings.Visible = true;
                lblZagara.Visible = true;
                lblSpecialists.Visible = true;

                //WARRIOR PICS HIDE
                picAnub.Visible = false;
                picArthas.Visible = false;
                picChen.Visible = false;
                picDiablo.Visible = false;
                picETC.Visible = false;
                picJohanna.Visible = false;
                picMuradin.Visible = false;
                picSonya.Visible = false;
                picStitches.Visible = false;
                picTyrael.Visible = false;

                //WARRIOR LABELS HIDE
                lblWarriors.Visible = false;
                lblAnub.Visible = false;
                lblArthas.Visible = false;
                lblChen.Visible = false;
                lblDiablo.Visible = false;
                lblETC.Visible = false;
                lblJohanna.Visible = false;
                lblMuradin.Visible = false;
                lblSonya.Visible = false;
                lblStiches.Visible = false;
                lblTyrael.Visible = false;

                //ASSASSIN PICS HIDE
                picFalstad.Visible = false;
                picIllidan.Visible = false;
                picJania.Visible = false;
                picKael.Visible = false;
                picKerrigan.Visible = false;
                picNova.Visible = false;
                picRaynor.Visible = false;
                picThrall.Visible = false;
                picTychus.Visible = false;
                picValla.Visible = false;
                picZeratul.Visible = false;

                //ASSASSIN LABELS HIDE
                lblFalstad.Visible = false;
                lblIllidan.Visible = false;
                lblJania.Visible = false;
                lblKael.Visible = false;
                lblKerrigan.Visible = false;
                lblNova.Visible = false;
                lblRaynor.Visible = false;
                lblThrall.Visible = false;
                lblTychus.Visible = false;
                lblValla.Visible = false;
                lblZeratul.Visible = false;
                lblAssassins.Visible = false;

                //SUPPORT LABELS HIDE
                lblBrightwing.Visible = false;
                lblLiLi.Visible = false;
                lblMalfurion.Visible = false;
                lblRehgar.Visible = false;
                lblSupoort.Visible = false;
                lblTassadar.Visible = false;
                lblTyrande.Visible = false;
                lblUther.Visible = false;

                //SUPPORT PICS HIDE
                picBrightwing.Visible = false;
                picLiLi.Visible = false;
                picMalfurion.Visible = false;
                picRehgar.Visible = false;
                picTassadar.Visible = false;
                picTyrande.Visible = false;
                picUther.Visible = false;

            }
        }


        //private void picFalstad_Click(object sender, EventArgs e)
        //  {
        //     Falstad_Talents falstad = new Falstad_Talents();
        //     falstad.ShowDialog();
        //  }

        public Bitmap renderBmp { get; set; }

        System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"click.wav");

        //**RECOMMENDED BUILD BUTTON**//

        private void btnRecommend_Click(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_1.Visible = true;
                Border2_1.Visible = true;
                Border3_3.Visible = true;
                Border4_1.Visible = true;
                Border5_3.Visible = true;
                Border6_4.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "Illidan")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_2.Visible = true;
                Border2_3.Visible = true;
                Border3_5.Visible = true;
                Border4_1.Visible = true;
                Border5_5.Visible = true;
                Border6_3.Visible = true;
                Border7_4.Visible = true;
            }

            if (lblHero.Text == "Jaina")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_3.Visible = true;
                Border2_4.Visible = true;
                Border3_2.Visible = true;
                Border4_2.Visible = true;
                Border5_4.Visible = true;
                Border6_2.Visible = true;
                Border7_4.Visible = true;
            }

            if (lblHero.Text == "Nova")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_3.Visible = true;
                Border2_3.Visible = true;
                Border3_3.Visible = true;
                Border4_2.Visible = true;
                Border5_3.Visible = true;
                Border6_2.Visible = true;
                Border7_4.Visible = true;
            }

            if (lblHero.Text == "Kerrigan")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_3.Visible = true;
                Border2_5.Visible = true;
                Border3_3.Visible = true;
                Border4_1.Visible = true;
                Border5_4.Visible = true;
                Border6_2.Visible = true;
                Border7_4.Visible = true;
            }

            if (lblHero.Text == "Kael'Thas")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_1.Visible = true;
                Border2_2.Visible = true;
                Border3_1.Visible = true;
                Border4_1.Visible = true;
                Border5_2.Visible = true;
                Border6_1.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "Raynor")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_2.Visible = true;
                Border2_1.Visible = true;
                Border3_2.Visible = true;
                Border4_2.Visible = true;
                Border5_1.Visible = true;
                Border6_5.Visible = true;
                Border7_4.Visible = true;

            }

            if (lblHero.Text == "Thrall")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_3.Visible = true;
                Border2_4.Visible = true;
                Border3_1.Visible = true;
                Border4_1.Visible = true;
                Border5_2.Visible = true;
                Border6_2.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "Tychus")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_1.Visible = true;
                Border2_4.Visible = true;
                Border3_3.Visible = true;
                Border4_1.Visible = true;
                Border5_2.Visible = true;
                Border6_4.Visible = true;
                Border7_1.Visible = true;
            }

            if (lblHero.Text == "Valla")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_4.Visible = true;
                Border2_2.Visible = true;
                Border3_4.Visible = true;
                Border4_2.Visible = true;
                Border5_2.Visible = true;
                Border6_3.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "Zeratul")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_2.Visible = true;
                Border2_3.Visible = true;
                Border3_4.Visible = true;
                Border4_2.Visible = true;
                Border5_3.Visible = true;
                Border6_2.Visible = true;
                Border7_4.Visible = true;
            }

            if (lblHero.Text == "Anub'arak")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_3.Visible = true;
                Border2_4.Visible = true;
                Border3_4.Visible = true;
                Border4_1.Visible = true;
                Border5_2.Visible = true;
                Border6_2.Visible = true;
                Border7_4.Visible = true;
            }

            if (lblHero.Text == "Arthas")
            {
                click.Play();
                initial();
                Ability2_4.Visible = false;
                Ability2_5.Visible = false;
                //**Recommended**//
                Border1_1.Visible = true;
                Border2_2.Visible = true;
                Border3_1.Visible = true;
                Border4_1.Visible = true;
                Border5_2.Visible = true;
                Border6_4.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "Chen")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_2.Visible = true;
                Border2_3.Visible = true;
                Border3_4.Visible = true;
                Border4_1.Visible = true;
                Border5_4.Visible = true;
                Border6_3.Visible = true;
                Border7_4.Visible = true;
            }

            if (lblHero.Text == "Diablo")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_1.Visible = true;
                Border2_1.Visible = true;
                Border3_4.Visible = true;
                Border4_1.Visible = true;
                Border5_1.Visible = true;
                Border6_2.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "E.T.C.")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_2.Visible = true;
                Border2_1.Visible = true;
                Border3_2.Visible = true;
                Border4_1.Visible = true;
                Border5_3.Visible = true;
                Border6_4.Visible = true;
                Border7_1.Visible = true;
            }

            if (lblHero.Text == "Johanna")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_1.Visible = true;
                Border2_4.Visible = true;
                Border3_1.Visible = true;
                Border4_2.Visible = true;
                Border5_1.Visible = true;
                Border6_3.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "Muradin")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_2.Visible = true;
                Border2_4.Visible = true;
                Border3_4.Visible = true;
                Border4_1.Visible = true;
                Border5_3.Visible = true;
                Border6_2.Visible = true;
                Border7_1.Visible = true;
            }

            if (lblHero.Text == "Sonya")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_4.Visible = true;
                Border2_1.Visible = true;
                Border3_2.Visible = true;
                Border4_1.Visible = true;
                Border5_4.Visible = true;
                Border6_4.Visible = true;
                Border7_4.Visible = true;
            }

            if (lblHero.Text == "Stitches")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_3.Visible = true;
                Border2_4.Visible = true;
                Border3_1.Visible = true;
                Border4_2.Visible = true;
                Border5_1.Visible = true;
                Border6_1.Visible = true;
                Border7_4.Visible = true;
            }

            if (lblHero.Text == "Tyrael")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_3.Visible = true;
                Border2_1.Visible = true;
                Border3_1.Visible = true;
                Border4_1.Visible = true;
                Border5_1.Visible = true;
                Border6_4.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "Azmodan")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_2.Visible = true;
                Border2_1.Visible = true;
                Border3_3.Visible = true;
                Border4_1.Visible = true;
                Border5_3.Visible = true;
                Border6_1.Visible = true;
                Border7_1.Visible = true;
            }

            if (lblHero.Text == "Gazlowe")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_4.Visible = true;
                Border2_2.Visible = true;
                Border3_3.Visible = true;
                Border4_2.Visible = true;
                Border5_2.Visible = true;
                Border6_1.Visible = true;
                Border7_2.Visible = true;
            }

            if (lblHero.Text == "Murky")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_2.Visible = true;
                Border2_3.Visible = true;
                Border3_1.Visible = true;
                Border4_2.Visible = true;
                Border5_3.Visible = true;
                Border6_3.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "Nazeebo")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_2.Visible = true;
                Border2_1.Visible = true;
                Border3_1.Visible = true;
                Border4_1.Visible = true;
                Border5_3.Visible = true;
                Border6_2.Visible = true;
                Border7_1.Visible = true;
            }

            if (lblHero.Text == "Sgt. Hammer")
            {
                click.Play();
                initial();
                Ability3_4.Visible = false;
                Ability3_5.Visible = false;
                //**Recommended**//
                Border1_5.Visible = true;
                Border2_3.Visible = true;
                Border3_3.Visible = true;
                Border4_2.Visible = true;
                Border5_1.Visible = true;
                Border6_3.Visible = true;
                Border7_4.Visible = true;
            }

            if (lblHero.Text == "Sylvanas")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_1.Visible = true;
                Border2_4.Visible = true;
                Border3_1.Visible = true;
                Border4_1.Visible = true;
                Border5_2.Visible = true;
                Border6_4.Visible = true;
                Border7_4.Visible = true;
            }

            if (lblHero.Text == "Zagara")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_3.Visible = true;
                Border2_1.Visible = true;
                Border3_5.Visible = true;
                Border4_1.Visible = true;
                Border5_2.Visible = true;
                Border6_2.Visible = true;
                Border7_4.Visible = true;
            }

            if (lblHero.Text == "Brightwing")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_3.Visible = true;
                Border2_2.Visible = true;
                Border3_2.Visible = true;
                Border4_1.Visible = true;
                Border5_3.Visible = true;
                Border6_3.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "Malfurion")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_1.Visible = true;
                Border2_4.Visible = true;
                Border3_2.Visible = true;
                Border4_1.Visible = true;
                Border5_1.Visible = true;
                Border6_1.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "Li Li")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_1.Visible = true;
                Border2_3.Visible = true;
                Border3_3.Visible = true;
                Border4_1.Visible = true;
                Border5_4.Visible = true;
                Border6_2.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "Rehgar")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_4.Visible = true;
                Border2_1.Visible = true;
                Border3_2.Visible = true;
                Border4_1.Visible = true;
                Border5_1.Visible = true;
                Border6_2.Visible = true;
                Border7_1.Visible = true;
            }

            if (lblHero.Text == "Tassadar")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_2.Visible = true;
                Border2_5.Visible = true;
                Border3_2.Visible = true;
                Border4_1.Visible = true;
                Border5_5.Visible = true;
                Border6_3.Visible = true;
                Border7_1.Visible = true;
            }

            if (lblHero.Text == "Tyrande")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_1.Visible = true;
                Border2_2.Visible = true;
                Border3_2.Visible = true;
                Border4_1.Visible = true;
                Border5_1.Visible = true;
                Border6_2.Visible = true;
                Border7_5.Visible = true;
            }

            if (lblHero.Text == "Uther")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_3.Visible = true;
                Border2_2.Visible = true;
                Border3_2.Visible = true;
                Border4_2.Visible = true;
                Border5_3.Visible = true;
                Border6_4.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "Abathur")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_1.Visible = true;
                Border2_4.Visible = true;
                Border3_1.Visible = true;
                Border4_1.Visible = true;
                Border5_4.Visible = true;
                Border6_1.Visible = true;
                Border7_3.Visible = true;
            }

            if (lblHero.Text == "The Lost Vikings")
            {
                click.Play();
                initial();
                //**Recommended**//
                Border1_3.Visible = true;
                Border2_4.Visible = true;
                Border3_4.Visible = true;
                Border4_1.Visible = true;
                Border5_3.Visible = true;
                Border6_2.Visible = true;
                Border7_1.Visible = true;
            }
        }

        private void Ability1_1_Click(object sender, EventArgs e)
        {
            click.Play();

            Border1_1.Visible = true;
            Border1_2.Visible = false;
            Border1_3.Visible = false;
            Border1_4.Visible = false;
            Border1_5.Visible = false;
        }

        private void Ability1_2_Click(object sender, EventArgs e)
        {
            click.Play();

            Border1_1.Visible = false;
            Border1_2.Visible = true;
            Border1_3.Visible = false;
            Border1_4.Visible = false;
            Border1_5.Visible = false;
        }

        private void Ability1_3_Click(object sender, EventArgs e)
        {
            click.Play();

            Border1_1.Visible = false;
            Border1_2.Visible = false;
            Border1_3.Visible = true;
            Border1_4.Visible = false;
            Border1_5.Visible = false;
        }

        private void Ability1_4_Click(object sender, EventArgs e)
        {
            click.Play();

            Border1_1.Visible = false;
            Border1_2.Visible = false;
            Border1_3.Visible = false;
            Border1_4.Visible = true;
            Border1_5.Visible = false;
        }

        private void Ability1_5_Click(object sender, EventArgs e)
        {
            click.Play();

            Border1_1.Visible = false;
            Border1_2.Visible = false;
            Border1_3.Visible = false;
            Border1_4.Visible = false;
            Border1_5.Visible = true;
        }

        private void Ability2_1_Click(object sender, EventArgs e)
        {
            click.Play();

            Border2_1.Visible = true;
            Border2_2.Visible = false;
            Border2_3.Visible = false;
            Border2_4.Visible = false;
            Border2_5.Visible = false;
        }

        private void Ability2_2_Click(object sender, EventArgs e)
        {
            click.Play();

            Border2_1.Visible = false;
            Border2_2.Visible = true;
            Border2_3.Visible = false;
            Border2_4.Visible = false;
            Border2_5.Visible = false;
        }

        private void Ability2_3_Click(object sender, EventArgs e)
        {
            click.Play();

            Border2_1.Visible = false;
            Border2_2.Visible = false;
            Border2_3.Visible = true;
            Border2_4.Visible = false;
            Border2_5.Visible = false;
        }

        private void Ability2_4_Click(object sender, EventArgs e)
        {
            click.Play();

            Border2_1.Visible = false;
            Border2_2.Visible = false;
            Border2_3.Visible = false;
            Border2_4.Visible = true;
            Border2_5.Visible = false;
        }

        private void Ability2_5_Click(object sender, EventArgs e)
        {
            click.Play();

            Border2_1.Visible = false;
            Border2_2.Visible = false;
            Border2_3.Visible = false;
            Border2_4.Visible = false;
            Border2_5.Visible = true;
        }

        private void Ability3_1_Click(object sender, EventArgs e)
        {
            click.Play();

            Border3_1.Visible = true;
            Border3_2.Visible = false;
            Border3_3.Visible = false;
            Border3_4.Visible = false;
            Border3_5.Visible = false;
        }

        private void Ability3_2_Click(object sender, EventArgs e)
        {
            click.Play();

            Border3_1.Visible = false;
            Border3_2.Visible = true;
            Border3_3.Visible = false;
            Border3_4.Visible = false;
            Border3_5.Visible = false;
        }

        private void Ability3_3_Click(object sender, EventArgs e)
        {
            click.Play();

            Border3_1.Visible = false;
            Border3_2.Visible = false;
            Border3_3.Visible = true;
            Border3_4.Visible = false;
            Border3_5.Visible = false;
        }

        private void Ability3_4_Click(object sender, EventArgs e)
        {
            click.Play();

            Border3_1.Visible = false;
            Border3_2.Visible = false;
            Border3_3.Visible = false;
            Border3_4.Visible = true;
            Border3_5.Visible = false;
        }

        private void Ability3_5_Click(object sender, EventArgs e)
        {
            click.Play();

            Border3_1.Visible = false;
            Border3_2.Visible = false;
            Border3_3.Visible = false;
            Border3_4.Visible = false;
            Border3_5.Visible = true;
        }

        private void Ability4_1_Click(object sender, EventArgs e)
        {
            click.Play();

            Border4_1.Visible = true;
            Border4_2.Visible = false;

            if (lblHero.Text == "Tychus")
            {
                picSpec1.Visible = true;
                picSpec2.Visible = true;
                picSpec3.Visible = true;

                spec1.Visible = true;
                spec2.Visible = true;
                spec3.Visible = true;

                spec1.Text = "Annhiliate\nQ";
                spec2.Text = "Ragnarok Missiles\nW";
                spec3.Text = "Thrusters\nE";

                picSpec1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Skills\64-kb-marathon.png");
                picSpec2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Skills\ragnarok-missiles.png");
                picSpec3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Skills\thrusters.png");

                lblSpecial.Visible = true;
            }

            if (lblHero.Text == "Chen")
            {
                picSpec1.Visible = false;
                picSpec2.Visible = false;

                spec1.Visible = false;
                spec2.Visible = false;

                lblSpecial.Visible = false;
            }
        }

        private void Ability4_2_Click(object sender, EventArgs e)
        {
            click.Play();

            Border4_1.Visible = false;
            Border4_2.Visible = true;

            if (lblHero.Text == "Tychus")
            {
                picSpec1.Visible = false;
                picSpec2.Visible = false;
                picSpec3.Visible = false;

                spec1.Visible = false;
                spec2.Visible = false;
                spec3.Visible = false;

                lblSpecial.Visible = false;
            }

            if (lblHero.Text == "Chen")
            {
                picSpec1.Visible = true;
                picSpec2.Visible = true;

                spec1.Visible = true;
                spec2.Visible = true;

                spec1.Text = "Triple Attack\nQ";
                spec2.Text = "Split Up\nW";

                picSpec1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Skills\triple-attack.png");
                picSpec2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Skills\split-up.png");

                lblSpecial.Visible = true;
            }

        }

        private void Ability5_1_Click(object sender, EventArgs e)
        {
            click.Play();

            Border5_1.Visible = true;
            Border5_2.Visible = false;
            Border5_3.Visible = false;
            Border5_4.Visible = false;
            Border5_5.Visible = false;
        }

        private void Ability5_2_Click(object sender, EventArgs e)
        {
            click.Play();

            Border5_1.Visible = false;
            Border5_2.Visible = true;
            Border5_3.Visible = false;
            Border5_4.Visible = false;
            Border5_5.Visible = false;
        }

        private void Ability5_3_Click(object sender, EventArgs e)
        {
            click.Play();

            Border5_1.Visible = false;
            Border5_2.Visible = false;
            Border5_3.Visible = true;
            Border5_4.Visible = false;
            Border5_5.Visible = false;
        }

        private void Ability5_4_Click(object sender, EventArgs e)
        {
            click.Play();

            Border5_1.Visible = false;
            Border5_2.Visible = false;
            Border5_3.Visible = false;
            Border5_4.Visible = true;
            Border5_5.Visible = false;
        }

        private void Ability5_5_Click(object sender, EventArgs e)
        {
            click.Play();

            Border5_1.Visible = false;
            Border5_2.Visible = false;
            Border5_3.Visible = false;
            Border5_4.Visible = false;
            Border5_5.Visible = true;
        }

        private void Ability6_1_Click(object sender, EventArgs e)
        {
            click.Play();

            Border6_1.Visible = true;
            Border6_2.Visible = false;
            Border6_3.Visible = false;
            Border6_4.Visible = false;
            Border6_5.Visible = false;
        }

        private void Ability6_2_Click(object sender, EventArgs e)
        {
            click.Play();

            Border6_1.Visible = false;
            Border6_2.Visible = true;
            Border6_3.Visible = false;
            Border6_4.Visible = false;
            Border6_5.Visible = false;
        }

        private void Ability6_3_Click(object sender, EventArgs e)
        {
            click.Play();

            Border6_1.Visible = false;
            Border6_2.Visible = false;
            Border6_3.Visible = true;
            Border6_4.Visible = false;
            Border6_5.Visible = false;
        }

        private void Ability6_4_Click(object sender, EventArgs e)
        {
            click.Play();

            Border6_1.Visible = false;
            Border6_2.Visible = false;
            Border6_3.Visible = false;
            Border6_4.Visible = true;
            Border6_5.Visible = false;
        }

        private void Ability6_5_Click(object sender, EventArgs e)
        {
            click.Play();

            Border6_1.Visible = false;
            Border6_2.Visible = false;
            Border6_3.Visible = false;
            Border6_4.Visible = false;
            Border6_5.Visible = true;
        }

        private void Ability7_1_Click(object sender, EventArgs e)
        {
            click.Play();

            Border7_1.Visible = true;
            Border7_2.Visible = false;
            Border7_3.Visible = false;
            Border7_4.Visible = false;
            Border7_5.Visible = false;
        }

        private void Ability7_2_Click(object sender, EventArgs e)
        {
            click.Play();

            Border7_1.Visible = false;
            Border7_2.Visible = true;
            Border7_3.Visible = false;
            Border7_4.Visible = false;
            Border7_5.Visible = false;
        }

        private void Ability7_3_Click(object sender, EventArgs e)
        {
            click.Play();

            Border7_1.Visible = false;
            Border7_2.Visible = false;
            Border7_3.Visible = true;
            Border7_4.Visible = false;
            Border7_5.Visible = false;
        }

        private void Ability7_4_Click(object sender, EventArgs e)
        {
            click.Play();

            Border7_1.Visible = false;
            Border7_2.Visible = false;
            Border7_3.Visible = false;
            Border7_4.Visible = true;
            Border7_5.Visible = false;
        }

        private void Ability7_5_Click(object sender, EventArgs e)
        {
            click.Play();

            Border7_1.Visible = false;
            Border7_2.Visible = false;
            Border7_3.Visible = false;
            Border7_4.Visible = false;
            Border7_5.Visible = true;
        }

        //**RESET BUTTON**//

        private void btnReset_Click(object sender, EventArgs e)
        {
            click.Play();

            initial();

            if (lblHero.Text == "Arthas")
            {
                Ability2_4.Visible = false;
                Ability2_5.Visible = false;
            }

            if (lblHero.Text == "Sgt. Hammer")
            {
                Ability3_4.Visible = false;
                Ability3_5.Visible = false;
            }

            if (lblHero.Text == "The Lost Vikings")
            {
                Ability1_4.Visible = false;
                Ability1_5.Visible = false;
                Ability5_4.Visible = false;
                Ability5_5.Visible = false;
                Ability6_4.Visible = false;
                Ability6_5.Visible = false;
            }
        }


        System.Media.SoundPlayer hero = new System.Media.SoundPlayer(@"close.wav");

        //**FALSTAD**//

        private void picFalstad_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Assassins\Falstad.png");
            lblHero.Text = ("Falstad");
            lblGold.Text = ("7,000");

            initial();

            //Recommended Deafult Build
            Border1_1.Visible = true;
            Border2_1.Visible = true;
            Border3_3.Visible = true;
            Border4_1.Visible = true;
            Border5_3.Visible = true;
            Border6_4.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Skills\Hammerang.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Skills\Lightning_Rod.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Skills\Barrel_Roll.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Skills\Mighty_Gust.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Skills\Hinterland_Blast.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Skills\Tailwind.png");
            picSpec1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Skills\Flight.png");

            lblQ.Text = "Hammerang\nQ";
            lblW.Text = "Lightning Rod\nW";
            lblE.Text = "Barrel Roll\nE";
            lblR1.Text = "Mighty Gust\nR (Heroic)";
            lblR2.Text = "Hinterland Blast\nR (Heroic)";
            lblTrait.Text = "Tailwind\nTrait";
            spec1.Text = "Flight";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 1\Power_Throw.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 1\Updraft.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 1\Seasoned_Marksman.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 1\Conjurer's_Pursuit.png");
            Ability1_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 1\Bribe.png");

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 4\Charged_Up.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 4\Flow_Rider.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 4\Vampiric_Assault.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 4\Gathering_Power.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 7\Battle_Momentum.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 7\Secret_Weapon.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 7\BOOMerang.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 7\Free_Roll.png");
            Ability3_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 7\First_Aid.png");

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 10\Hinterland_Blast.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 10\Mighty_Gust.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 13\Giant_Killer.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 13\Crippling_Hammer.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 13\Thunderstrikes.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 13\Static_Shield.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 16\Aerie_Gusts.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 16\Hammer_Time.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 16\Afterburner.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 16\Overdrive.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 20\Call_of_the_Wildhammer.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 20\Wind_Tunnel.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 20\Nexus_Frenzy.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Falstad\Talents\Tier 20\Epic_Mount.png");
            Ability7_5.Visible = false;

            lblHealth.Text = "710";
            lblHealthRegen.Text = "1.4804";
            lblMana.Text = "500";
            lblManaRegen.Text = "3";
            lblSpeed.Text = "1.43";
            lblDamage.Text = "38";
        }

        //**ILLIDAN**//

        private void picIllidan_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Assassins\Illidan.png");
            lblHero.Text = "Illidan";
            lblGold.Text = "7,000";


            initial();

            //Recommened Default Build
            Border1_2.Visible = true;
            Border2_3.Visible = true;
            Border3_5.Visible = true;
            Border4_1.Visible = true;
            Border5_5.Visible = true;
            Border6_3.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Skills\Dive_Icon.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Skills\Sweeping_Strike_Icon.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Skills\Evasion_Icon.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Skills\Metamorphosis_Icon.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Skills\The_Hunt_Icon.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Skills\Betrayer's_Thirst_Icon.png");

            lblQ.Text = "Dive\nQ";
            lblW.Text = "Sweeping Strike\nW";
            lblE.Text = "Evasion\nE";
            lblR1.Text = "Metamorphasis\nR (Heroic)";
            lblR2.Text = "The Hunt\nR (Heroic)";
            lblTrait.Text = "Betrayer's Thirst\n(Trait)";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 1\Battered_Assault_Icon.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 1\Shadow_Shield_Icon.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 1\Regeneration_Master_Icon.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 1\Seasoned_Marksman_Icon.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 4\Marked_For_Death_Icon.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 4\Fel_Reach_Icon.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 4\Immolation_Icon.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 4\Thirsting_Blade_Icon.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 7\Rapid_Chase_Icon.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 7\Reflexive_Block_Icon.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 7\Follow_Through_Icon.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 7\Thrill_of_Battle_Icon.png");
            Ability3_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 7\First_Aid_Icon.png");
            Ability3_5.Visible = true;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 10\Metamorphosis_Icon.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 10\The_Hunt_Icon.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 13\Giant_Killer_Icon.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 13\Lunge_Icon.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 13\Friend_or_Foe_Icon.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 13\Unbound_Icon.png");
            Ability5_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 13\Sixth_Sense_Icon.png");
            Ability5_5.Visible = true;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 16\Hunter's_Onslaught_Icon.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 16\Second_Sweep_Icon.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 16\Blood_for_Blood_Icon.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 16\Stoneskin_Icon.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 20\Demonic_Form_Icon.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 20\Nowhere_to_Hide_Icon.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 20\Nexus_Blades_Icon.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Illidan\Talents\Tier 20\Bolt_of_the_Storm_Icon.png");
            Ability7_5.Visible = false;

            lblHealth.Text = "750";
            lblHealthRegen.Text = "1.7304";
            lblMana.Text = "N/A";
            lblManaRegen.Text = "N/A";
            lblSpeed.Text = "1.67";
            lblDamage.Text = "30";
        }

        //**JAINA**//

        private void picJania_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Assassins\Jaina.png");
            lblHero.Text = "Jaina";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_3.Visible = true;
            Border2_4.Visible = true;
            Border3_2.Visible = true;
            Border4_2.Visible = true;
            Border5_4.Visible = true;
            Border6_2.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Skills\76px-Frostbolt_Icon.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Skills\76px-Blizzard_Icon.png");
            picEAbility.ImageLocation = @"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Skills\76px-Cone_of_Cold_Icon.png";
            picR1Ability.ImageLocation = @"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Skills\76px-Ring_of_Frost_Icon.png";
            picR2Ability.ImageLocation = @"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Skills\76px-Summon_Water_Elemental_Icon.png";
            picTrait.ImageLocation = @"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Skills\76px-Frostbite_Icon.png";

            lblQ.Text = "Frostbolt\nQ";
            lblW.Text = "Blizzard\nW";
            lblE.Text = "Cone of Cold\nE";
            lblR1.Text = "Ring of Frost\nR (Heroic)";
            lblR2.Text = "Summon Water Elemental\nR (Heroic)";
            lblTrait.Text = "Frostbite\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 1\64px-Winter's_Reach_Icon.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 1\64px-Lingering_Chill_Icon.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 1\64px-Deep_Chill_Icon.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 1\Conjurer's_Pursuit_Icon.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 4\64px-Frost_Shards_Icon.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 4\64px-Snowstorm_Icon.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 4\Arcane_Intellect_Icon.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 4\Envenom_Icon.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 7\64px-Ice_Floes_Icon.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 7\64px-Frostbitten_Icon.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 7\Frost_Armor_Icon.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 7\64px-Ice_Lance_Icon.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 10\64px-Ring_of_Frost_Icon.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 10\64px-Summon_Water_Elemental_Icon.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 13\64px-Storm_Front_Icon.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 13\Improved_Ice_Block_Icon.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 13\Icy_Veins_Icon.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 13\Sprint_Icon.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 16\64px-Snow_Crash_Icon.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 16\64px-Northern_Exposure_Icon.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 16\64px-Numbing_Blast_Icon.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 16\64px-Ice_Barrier_Icon.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 20\64px-Cold_Snap_Icon.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 20\64px-Wintermute_Icon.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 20\Arcane_Power_Icon.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Talents\Tier 20\64px-Bolt_of_the_Storm_Icon.png");
            Ability7_5.Visible = false;

            lblHealth.Text = "710";
            lblHealthRegen.Text = "1.4804";
            lblMana.Text = "500";
            lblManaRegen.Text = "3";
            lblSpeed.Text = "1.00";
            lblDamage.Text = "42";
        }

        //**KAEL'THAS**//

        private void picKael_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Assassins\Kael'Thas.png");
            lblHero.Text = "Kael'Thas";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_1.Visible = true;
            Border2_2.Visible = true;
            Border3_1.Visible = true;
            Border4_1.Visible = true;
            Border5_2.Visible = true;
            Border6_1.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Skills\flamestrike.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Skills\living-bomb.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Skills\gravity-lapse.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Skills\phoenix.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Skills\pyroblast.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Skills\verdant-spheres.png");

            lblQ.Text = "Flamestrike\nQ";
            lblW.Text = "Living Bomb\nW";
            lblE.Text = "Gravity Lapse\nE";
            lblR1.Text = "Phoenix\nR (Heroic)";
            lblR2.Text = "Pyroblast\nR (Heroic)";
            lblTrait.Text = "Verdant Spheres\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 1\mana-addict.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 1\convection.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 1\energy-roil.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 1\fel-infusion.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 4\mana-tap.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 4\nether-wind.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 4\gathering-power.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 4\envenom-talent.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 7\fission-bomb.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 7\sunfire-enchantment.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 7\tri-optimal.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 7\clairvoyance-talent.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 10\phoenix-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 10\pyroblast-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 13\flamethrower.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 13\chain-bomb.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 13\pyromaniac.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 13\spell-shield.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 16\ignite.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 16\backdraft.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 16\gravity-throw.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 16\arcane-barrier-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 20\rebirth.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 20\presence-of-mind.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 20\bolt-of-the-storm-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kael'Thas\Talents\Tier 20\arcane-power-talent.png");
            Ability7_5.Visible = false;

            lblHealth.Text = "740";
            lblHealthRegen.Text = "1.539";
            lblMana.Text = "500";
            lblManaRegen.Text = "3";
            lblSpeed.Text = "1.11";
            lblDamage.Text = "39";
        }

        //**KERRIGAN**//

        private void picKerrigan_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Assassins\Kerrigan.png");
            lblHero.Text = "Kerrigan";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_3.Visible = true;
            Border2_5.Visible = true;
            Border3_3.Visible = true;
            Border4_1.Visible = true;
            Border5_4.Visible = true;
            Border6_2.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Skills\76px-Ravage_Icon.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Skills\76px-Impaling_Blades_Icon.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Skills\76px-Primal_Grasp_Icon.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Skills\76px-Maelstrom_Icon.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Skills\76px-Summon_Ultralisk_Icon.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Skills\76px-Assimilation_Icon.png");

            lblQ.Text = "Ravage\nQ";
            lblW.Text = "Impaling Blades\nW";
            lblE.Text = "Primal Grasp\nE";
            lblR1.Text = "Maelstrom\nR (Heroic)";
            lblR2.Text = "Summon Ultralisk\nR (Heroic)";
            lblTrait.Text = "Assimilation\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 1\64px-Siphoning_Impact_Icon.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 1\64px-Sharpened_Blades_Icon.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 1\64px-Sweeping_Grasp_Icon.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 1\Block_Icon.png");
            Ability1_5.Visible = true;
            Ability1_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 1\64px-Seasoned_Marksman_Icon.png");

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 4\Focused_Attack_Icon.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 4\64px-Fury_of_the_Swarm_Icon.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 4\64px-Clean_Kill_Icon.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 4\64px-Psionic_Pulse_Icon.png");
            Ability2_5.Visible = true;
            Ability2_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 4\Envenom_Icon.png");

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 7\Battle_Momentum_Icon.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 7\64px-Impaling_Swarm_Icon.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 7\64px-Adaptation_Icon.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 7\Searing_Attacks_Icon.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 10\64px-Maelstrom_Icon.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 10\64px-Summon_Ultralisk_Icon.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 13\64px-Lingering_Essence_Icon.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 13\64px-Eviscerate_Icon.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 13\64px-Double_Strike_Icon.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 13\Sprint_Icon.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 16\64px-Aggressive_Defense_Icon.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 16\64px-Blade_Torrent_Icon.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 16\Blood_for_Blood_Icon.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 16\Overdrive_Icon.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 20\64px-Omegastorm_Icon.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 20\64px-Torrasque_Icon.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 20\Nexus_Blades_Icon.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 20\64px-Bolt_of_the_Storm_Icon.png");
            Ability7_5.Visible = false;

            lblHealth.Text = "830";
            lblHealthRegen.Text = "1.664";
            lblMana.Text = "500";
            lblManaRegen.Text = "3";
            lblSpeed.Text = "1.25";
            lblDamage.Text = "40";
        }

        //**NOVA**//

        private void picNova_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Assassins\Nova.png");
            lblHero.Text = "Nova";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_3.Visible = true;
            Border2_3.Visible = true;
            Border3_3.Visible = true;
            Border4_2.Visible = true;
            Border5_3.Visible = true;
            Border6_2.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Skills\76px-Snipe_Icon.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Skills\76px-Pinning_Shot_Icon.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Skills\76px-Holo_Decoy_Icon.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Skills\76px-Triple_Tap_Icon.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Skills\76px-Precision_Strike_Icon.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Skills\76px-Permanent_Cloak,_Sniper_Icon.png");

            lblQ.Text = "Snipe\nQ";
            lblW.Text = "Pinning Shot\nW";
            lblE.Text = "Holo Decoy\nE";
            lblR1.Text = "Triple Tap\nR (Heroic)";
            lblR2.Text = "Precision Strike\nR (Heroic)";
            lblTrait.Text = "Permanent Cloak, Sniper\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 1\Conjurer's_Pursuit_Icon.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 1\64px-Psi-Op_Rangefinder_Icon.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 1\64px-Ambush_Snipe_Icon.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 1\64px-Tazer_Rounds_Icon.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 4\64px-Perfect_Shot_Icon.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 4\64px-Remote_Delivery_Icon.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 4\Gathering_Power_Icon.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 4\Envenom_Icon.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 7\64px-Explosive_Round_Icon.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 7\64px-One_in_the_Chamber_Icon.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 7\Anti-Armor_Shells_Icon.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 7\64px-Covert_Ops_Icon.png");

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 10\64px-Triple_Tap_Icon.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 10\64px-Precision_Strike_Icon.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 13\64px-Lethal_Decoy_Icon.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 13\64px-Advanced_Cloaking_Icon.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 13\64px-Headshot_Icon.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 13\64px-Spell_Shield_Icon.png");

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 16\64px-Railgun_Icon.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 16\64px-Crippling_Shot_Icon.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 16\64px-Double_Fake_Icon.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 16\Overdrive_Icon.png");

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 20\64px-Fast_Reload_Icon.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 20\64px-Precision_Barrage_Icon.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 20\Rewind_Icon.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nova\Talents\Tier 20\64px-Bolt_of_the_Storm_Icon.png");

            lblHealth.Text = "700";
            lblHealthRegen.Text = "1.457";
            lblMana.Text = "500";
            lblManaRegen.Text = "3";
            lblSpeed.Text = "1.00";
            lblDamage.Text = "40";
        }

        //**RAYNOR**//

        private void picRaynor_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Assassins\Raynor.png");
            lblHero.Text = "Raynor";
            lblGold.Text = "2,000";

            initial();

            //**Recommended Build**//
            Border1_2.Visible = true;
            Border2_1.Visible = true;
            Border3_2.Visible = true;
            Border4_2.Visible = true;
            Border5_1.Visible = true;
            Border6_5.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Skills\76px-Penetrating_Round_Icon.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Skills\76px-Inspire_Icon.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Skills\76px-Adrenaline_Rush_Icon.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Skills\76px-Hyperion_Icon.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Skills\76px-Raynor's_Raiders_Icon.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Skills\76px-Advanced_Optics_Icon.png");

            lblQ.Text = "Penetrating Round\nQ";
            lblW.Text = "Inspire\nW";
            lblE.Text = "Adrenaline Rush\nE";
            lblR1.Text = "Hyperion\nR (Heroic)";
            lblR2.Text = "Raynor's Raiders\nR (Heroic)";
            lblTrait.Text = "Advanced Optics\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 1\64px-Adrenaline_Rush_Icon.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 1\64px-Seasoned_Marksman_Icon.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 1\raiders-recruitment-talent.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 1\Scouting_Drone_Icon.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 4\Focused_Attack_Icon.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 4\Vampiric_Assault_Icon.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 4\64px-RaynorPenetratingRoundConfidentAimTalent_(Unnamed)_Icon.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 4\64px-Activated_Rush_Icon.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 7\hamstring-shot.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 7\revolution-overdrive.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 7\fight-or-flight.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 7\mercenary-lord.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 10\64px-Hyperion_Icon.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 10\64px-Raynor's_Raiders_Icon.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 13\Giant_Killer_Icon.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 13\64px-Double-Barreled_Icon.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 13\steel-resolve.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 13\Puttin'_On_a_Clinic_Icon.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 16\Executioner_Icon.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 16\64px-Cluster_Round_Icon.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 16\64px-Bullseye_Icon.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 16\relentless-leader.png");
            Ability6_5.Visible = true;
            Ability6_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 16\Berserk_Icon.png");


            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 20\scorched-earth.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 20\dusk-wings.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 20\a-card-to-play.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 20\nexus-frenzy.png");
            Ability7_5.Visible = true;
            Ability7_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Raynor\Talents\Tier 20\bolt-of-the-storm-talent.png");

            lblHealth.Text = "725";
            lblHealthRegen.Text = "1.5117";
            lblMana.Text = "500";
            lblManaRegen.Text = "3";
            lblSpeed.Text = "1.25";
            lblDamage.Text = "35";
        }

        //**THRALL**//

        private void picThrall_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Assassins\Thrall.png");
            lblHero.Text = "Thrall";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_3.Visible = true;
            Border2_4.Visible = true;
            Border3_1.Visible = true;
            Border4_1.Visible = true;
            Border5_2.Visible = true;
            Border6_2.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Skills\chain-lightning.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Skills\feral-spirit.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Skills\windfury.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Skills\earthquake.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Skills\sundering.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Skills\frostwolf-resilience.png");

            lblQ.Text = "Chain Lightning\nQ";
            lblW.Text = "Feral Spirit\nW";
            lblE.Text = "Windfury\nE";
            lblR1.Text = "Earthquake\nR (Heroic)";
            lblR2.Text = "Sundering\nR (Heroic)";
            lblTrait.Text = "Frostwolf Resilience\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 1\block.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 1\rolling-thunder.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 1\rabid-wolves.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 1\seasoned-marksman.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 4\ride-the-lightning.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 4\spirit-journey.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 4\mana-tide.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 4\envenom-talent.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 7\wind-shear.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 7\stone-wolves.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 7\follow-through.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 7\frostwolfs-grace.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 10\earthquake-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 10\sundering-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 13\restless-wolves.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 13\grace-of-air.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 13\giant-killer.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 13\spell-shield.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 16\forked-lightning.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 16\tempest-fury.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 16\ride-the-wind.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 16\blood-for-blood-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 20\worldbreaker.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 20\earthen-shields.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 20\nexus-blades.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Thrall\Talents\Tier 20\bolt-of-the-storm-talent.png");
            Ability7_5.Visible = false;

            lblHealth.Text = "875";
            lblHealthRegen.Text = "1.8242";
            lblMana.Text = "500";
            lblManaRegen.Text = "3";
            lblSpeed.Text = "0.91";
            lblDamage.Text = "55";
        }

        //**TYCHUS**//

        private void picTychus_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Assassins\Tychus.png");
            lblHero.Text = "Tychus";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_1.Visible = true;
            Border2_4.Visible = true;
            Border3_3.Visible = true;
            Border4_1.Visible = true;
            Border5_2.Visible = true;
            Border6_4.Visible = true;
            Border7_1.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Skills\overkill.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Skills\frag-grenade.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Skills\run-and-gun.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Skills\commandeer-odin.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Skills\drakken-laser-drill.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Skills\minigun.png");

            lblQ.Text = "Overkill\nQ";
            lblW.Text = "Frag Grenade\nW";
            lblE.Text = "Run and Gun\nE";
            lblR1.Text = "Commandeer Odin\nR (Heroic)";
            lblR2.Text = "Drakken Laser Drill\nR (Heroic)";
            lblTrait.Text = "Minigun\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 1\armor-piercing-rounds.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 1\shredder-grenade.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 1\dash.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 1\regeneration-master.png");
            Ability1_5.Visible = true;
            Ability1_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 1\scouting-drone-talent.png");

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 4\focused-attack.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 4\vampiric-assault-tychus.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 4\spray-n-pray.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 4\melting-point.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 7\quarterback.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 7\rapid-fire.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 7\first-aid-talent.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 7\searing-attacks-tychus.png");

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 10\commandeer-odin-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 10\drakken-laser-drill-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 13\giant-killer-tychus.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 13\lead-rain.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 13\stim-pack.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 13\relentless.png");

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 16\executioner.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 16\lock-and-load.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 16\concussion-grenade.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 16\stoneskin-talent.png");

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 20\big-red-button.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 20\focusing-diodes.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 20\nexus-frenzy.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Talents\Tier 20\bolt-of-the-storm-talent.png");

            lblHealth.Text = "725";
            lblHealthRegen.Text = "1.5117";
            lblMana.Text = "500";
            lblManaRegen.Text = "3";
            lblSpeed.Text = "0.67";
            lblDamage.Text = "20";

            if (Border4_1.Visible == true)
            {
                picSpec1.Visible = true;
                picSpec2.Visible = true;
                picSpec3.Visible = true;

                spec1.Visible = true;
                spec2.Visible = true;
                spec3.Visible = true;

                spec1.Text = "Annhiliate\nQ";
                spec2.Text = "Ragnarok Missiles\nW";
                spec3.Text = "Thrusters\nE";

                picSpec1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Skills\64-kb-marathon.png");
                picSpec2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Skills\ragnarok-missiles.png");
                picSpec3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tychus\Skills\thrusters.png");

                lblSpecial.Visible = true;
            }
        }

        //**VALLA**//

        private void picValla_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Assassins\Valla.png");
            lblHero.Text = "Valla";
            lblGold.Text = "2,000";

            initial();

            //**Recommended Build**//
            Border1_4.Visible = true;
            Border2_2.Visible = true;
            Border3_4.Visible = true;
            Border4_2.Visible = true;
            Border5_2.Visible = true;
            Border6_3.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Skills\hungering-arrow.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Skills\multishot.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Skills\vault.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Skills\strafe.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Skills\rain-of-vengeance.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Skills\hatred.png");

            lblQ.Text = "Hungering Arrow\nQ";
            lblW.Text = "Multishot\nW";
            lblE.Text = "Vault\nE";
            lblR1.Text = "Strafe\nR (Heroic)";
            lblR2.Text = "Rain of Vengeance\nR (Heroic)";
            lblTrait.Text = "Hatred\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 1\cost-effective-materials.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 1\siphoning-arrow.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 1\composite-arrows.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 1\rancor.png");
            Ability1_5.Visible = true;
            Ability1_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 1\punishment.png");

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 4\vampiric-assault.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 4\manticore.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 4\puncturing-arrow.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 4\arsenal.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 7\caltrops.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 7\hot-pursuit.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 7\repeating-arrow.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 7\searing-attacks-talent.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 10\strafe-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 10\rain-of-vengeance-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 13\giant-killer.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 13\frost-shot.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 13\tempered-by-discipline.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 13\spell-shield.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 16\executioner.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 16\tumble.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 16\blood-for-blood-talent.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 16\stoneskin-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 20\vengeance.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 20\storm-of-vengeance.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 20\nexus-frenzy.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Valla\Talents\Tier 20\bolt-of-the-storm-talent.png");
            Ability7_5.Visible = false;

            lblHealth.Text = "700";
            lblHealthRegen.Text = "1.461";
            lblMana.Text = "500";
            lblManaRegen.Text = "3";
            lblSpeed.Text = "1.67";
            lblDamage.Text = "28";
        }

        //**ZERATUL**//

        private void picZeratul_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Assassins\Zeratul.png");
            lblHero.Text = "Zeratul";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_2.Visible = true;
            Border2_3.Visible = true;
            Border3_4.Visible = true;
            Border4_2.Visible = true;
            Border5_3.Visible = true;
            Border6_2.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Skills\cleave.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Skills\singularity-spike.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Skills\blink.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Skills\shadow-assault.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Skills\void-prison.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Skills\permanent-cloak.png");

            lblQ.Text = "Cleave\nQ";
            lblW.Text = "Singularity Spike\nW";
            lblE.Text = "Blink\nE";
            lblR1.Text = "Shadow Assault\nR (Heroic)";
            lblR2.Text = "Void Prison\nR (Heroic)";
            lblTrait.Text = "Permanent Cloak\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 1\block.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 1\greater-cleave.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 1\rapid-displacement.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 1\regeneration-master.png");
            Ability1_5.Visible = true;
            Ability1_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 1\seasoned-marksman.png");

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 4\focused-attack.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 4\vampiric-assault.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 4\gathering-power.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 4\sustained-anomaly.png");
            Ability2_5.Visible = true;
            Ability2_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 4\vorpal-blade-talent.png");

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 7\follow-through.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 7\void-slash.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 7\shadow-spike.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 7\first-aid-talent.png");
            Ability3_5.Visible = true;
            Ability3_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 7\searing-attacks-talent.png");

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 10\shadow-assault-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 10\void-prison-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 13\giant-killer.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 13\burning-rage.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 13\wormhole.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 13\assassins-blade.png");
            Ability5_5.Visible = true;
            Ability5_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 13\spell-shield.png");

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 16\rending-cleave.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 16\double-bombs.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 16\stoneskin-talent.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 16\berserk-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 20\nerazim-fury.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 20\protective-prison.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 20\nexus-blades.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zeratul\Talents\Tier 20\rewind-talent.png");

            lblHealth.Text = "820";
            lblHealthRegen.Text = "1.707";
            lblMana.Text = "500";
            lblManaRegen.Text = "3";
            lblSpeed.Text = "1.11";
            lblDamage.Text = "47";
        }

        //**ANUB'ARAK**//

        private void picAnub_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Warriors\Anub'arak.png");
            lblHero.Text = "Anub'arak";
            lblGold.Text = "4,000";

            initial();

            //**Recommended Build**//
            Border1_3.Visible = true;
            Border2_4.Visible = true;
            Border3_4.Visible = true;
            Border4_1.Visible = true;
            Border5_2.Visible = true;
            Border6_2.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Skills\impale.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Skills\harden-carapace.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Skills\burrow-charge.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Skills\web-blast.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Skills\locust-swarm.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Skills\scarab-host.png");

            lblQ.Text = "Impale\nQ";
            lblW.Text = "Harden Carapace\nW";
            lblE.Text = "Burrow Charge\nE";
            lblR1.Text = "Web Blast\nR (Heroic)";
            lblR2.Text = "Locust Swarm\nR (Heroic)";
            lblTrait.Text = "Scarab Host\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 1\extended-spikes.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 1\persistent-carapace.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 1\assault-scarab.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 1\regeneration-master.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 4\underking.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 4\superiority.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 4\locust-needles.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 4\legion-of-beetles.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 7\shed-exoskeleton.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 7\urtricating-spines.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 7\bed-of-barbs.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 7\leeching-scarabs.png");
            Ability3_5.Visible = true;
            Ability3_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 7\mercenary-lord.png");

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 10\web-blast-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 10\locust-swarm-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 13\burning-rage.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 13\chitinous-plating.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 13\symbiotic-armor.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 13\spell-shield.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 16\epicenter.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 16\beetle-juiced.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 16\imposing-presence.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 16\blood-for-blood-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 20\hive-master.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 20\cryptweave.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 20\hardened-shield-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Anub'arak\Talents\Tier 20\rewind-talent.png");
            Ability7_5.Visible = false;

            lblHealth.Text = "800";
            lblHealthRegen.Text = "1.668";
            lblMana.Text = "500";
            lblManaRegen.Text = "3";
            lblSpeed.Text = "1.00";
            lblDamage.Text = "45";
        }

        //**ARTHAS**//

        private void picArthas_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Warriors\Arthas.png");
            lblHero.Text = "Arthas";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_1.Visible = true;
            Border2_2.Visible = true;
            Border3_1.Visible = true;
            Border4_1.Visible = true;
            Border5_2.Visible = true;
            Border6_4.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Skills\death-coil.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Skills\howling-blast.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Skills\frozen-tempest.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Skills\army-of-the-dead.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Skills\summon-sindragosa.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Skills\frostmourne-hungers.png");

            lblQ.Text = "Death Coil;\nQ";
            lblW.Text = "Howling Blast\nW";
            lblE.Text = "Frozen Tempest\nE";
            lblR1.Text = "Army of the Dead\nR (Heroic)";
            lblR2.Text = "Summon Sindragosa\nR (Heroic)";
            lblTrait.Text = "Froustmourne Hungers\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 1\block.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 1\eternal-hunger.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 1\frost-presence.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 1\regeneration-master.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 4\superiority.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 4\destruction.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 4\frozen-wastes.png");
            Ability2_4.Visible = false;
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 7\rune-tap.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 7\obliterate.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 7\frost-strike.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 7\death-touch.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 10\army-of-the-dead-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 10\summon-sindragosa-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 13\spell-shield.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 13\relentless.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 13\trail-of-frost.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 13\biting-cold.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 16\frostmourne-feeds.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 16\immortal-coil.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 16\embrace-death.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 16\stoneskin-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 20\legion-of-northrend.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 20\absolute-zero.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 20\hardened-shield-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Arthas\Talents\Tier 20\rewind-talent.png");
            Ability7_5.Visible = false;
        }

        //**CHEN**//

        private void picChen_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Warriors\Chen.png");
            lblHero.Text = "Chen";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_2.Visible = true;
            Border2_3.Visible = true;
            Border3_4.Visible = true;
            Border4_1.Visible = true;
            Border5_4.Visible = true;
            Border6_3.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Skills\flying-kick.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Skills\keg-smash.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Skills\breath-of-fire.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Skills\wandering-keg.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Skills\storm-earth-fire.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Skills\fortifying-brew.png");

            lblQ.Text = "Flying Kick\nQ";
            lblW.Text = "Keg Smash\nW";
            lblE.Text = "Breath of Fire\nE";
            lblR1.Text = "Wandering Keg\nR (Heroic)";
            lblR2.Text = "Storm, Earth, Fire\nR (Heroic)";
            lblTrait.Text = "Fortifying Brew\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 1\bottomless-mug.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 1\full-keg.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 1\consuming-flame.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 1\regeneration-master.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 4\swift-reflexes.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 4\deadly-strike.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 4\amplified-healing.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 4\deep-breath.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 7\keg-toss.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 7\ring-of-fire.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 7\combat-stance.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 7\brewmasters-balance.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 10\wandering-keg-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 10\storm-earth-fire-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 13\brew-strike.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 13\a-touch-of-honey.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 13\enough-to-share.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 13\relentless.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 16\combination-attack.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 16\chug.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 16\pressure-point.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 16\bolder-flavor.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 20\untapped-potential.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 20\elemental-conduit.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 20\hardened-shield-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Chen\Talents\Tier 20\bolt-of-the-storm-talent.png");
            Ability7_5.Visible = false;
        }

        //**DIABLO**//

        private void picDiablo_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Warriors\Diablo.png");
            lblHero.Text = "Diablo";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_1.Visible = true;
            Border2_1.Visible = true;
            Border3_4.Visible = true;
            Border4_1.Visible = true;
            Border5_1.Visible = true;
            Border6_2.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Skills\shadow-charge.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Skills\fire-stomp.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Skills\overpower.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Skills\apocalypse.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Skills\lightning-breath.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Skills\black-soulstone.png");

            lblQ.Text = "Shadow Charge\nQ";
            lblW.Text = "Fire Stomp\nW";
            lblE.Text = "Overpower\nE";
            lblR1.Text = "Apocalypse\nR (Heroic)";
            lblR2.Text = "Lightning Breath\nR (Heroic)";
            lblTrait.Text = "Black Soulstone\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 1\devils-due.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 1\block.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 1\soul-feast.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 1\overwhelming-force.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 4\demonic-strength.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 4\soul-catcher.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 4\essence-of-the-slain.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 4\fire-devil.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 7\battle-momentum.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 7\from-the-shadows.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 7\devastating-charge.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 7\soul-steal.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 10\apocalypse-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 10\lightning-breath-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 13\siphon-the-dead.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 13\spell-shield.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 13\life-leech.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 13\firestorm.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 16\continuous-overpower.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 16\imposing-presence.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 16\domination.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 16\rampage.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 20\dying-breath.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 20\hellstorm.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 20\lord-of-terror-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Diablo\Talents\Tier 20\bolt.png");
            Ability7_5.Visible = false;
        }

        //**E.T.C.**//

        private void picETC_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Warriors\E.t.c._square_tile.png");
            lblHero.Text = "E.T.C.";
            lblGold.Text = "2,000";

            initial();

            //**Recommended Build**//
            Border1_2.Visible = true;
            Border2_1.Visible = true;
            Border3_2.Visible = true;
            Border4_1.Visible = true;
            Border5_3.Visible = true;
            Border6_4.Visible = true;
            Border7_1.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Skills\powerslide.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Skills\face-melt.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Skills\guitar-solo.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Skills\mosh-pit.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Skills\stage-dive.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Skills\rockstar.png");

            lblQ.Text = "Powerslide\nQ";
            lblW.Text = "Face Melt\nW";
            lblE.Text = "Guitar Solo\nE";
            lblR1.Text = "Mosh Pit\nR (Heroic)";
            lblR2.Text = "Stage Dive\nR (Heroic)";
            lblTrait.Text = "Rockstar\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 1\rolling-like-a-stone.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 1\pwn-shop-guitar.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 1\prog-rock.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 1\block.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 4\double-necked-guitar.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 4\mic-check.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 4\hammer-on.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 4\pinball-wizard.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 7\loud-speakers.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 7\guitar-hero.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 7\just-keep-rockin.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 7\follow-through.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 10\mosh-pit-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 10\stage-dive-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 13\groupies.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 13\face-smelt.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 13\show-stopper.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 13\spell-shield.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 16\speed-metal.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 16\echo-pedal.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 16\encore.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 16\imposing-presence.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 20\tour-bus.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 20\crowd-pleaser.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 20\death-metal.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 20\storm-shield-talent.png");
            Ability7_5.Visible = true;
            Ability7_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\E.T.C.\Talents\Tier 20\bolt-of-the-storm-talent.png");
        }

        //**JOHANNA**//

        private void picJohanna_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Warriors\Johanna.png");
            lblHero.Text = "Johanna";
            lblGold.Text = "15,000";

            initial();

            //**Recommended Build**//
            Border1_1.Visible = true;
            Border2_4.Visible = true;
            Border3_1.Visible = true;
            Border4_2.Visible = true;
            Border5_1.Visible = true;
            Border6_3.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Skills\punish.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Skills\condemn.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Skills\shield-glare.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Skills\falling-sword.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Skills\blessed-shield.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Skills\iron-skin.png");

            lblQ.Text = "Punish\nQ";
            lblW.Text = "Condemn\nW";
            lblE.Text = "Shield Glare\nE";
            lblR1.Text = "Falling Sword\nR (Heroic)";
            lblR2.Text = "Blessed Shield\nR (Heroic)";
            lblTrait.Text = "Iron Skin\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 1\reinforce.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 1\knight-takes-pawn.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 1\righteous-smash.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 1\regeneration-master.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 4\amplified-healing.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 4\roar.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 4\eternal-retaliation.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 4\laws-of-hope-talent.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 7\battle-momentum.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 7\sins-exposed.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 7\the-crusade-marches-on.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 7\conviction.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 10\falling-sword-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 10\blessed-shield-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 13\burning-rage.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 13\hold-your-ground.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 13\subdue.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 13\spell-shield.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 16\holy-renewal.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 16\fanaticism.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 16\blessed-hammer.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 16\imposing-presence.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 20\heavens-fury.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 20\radiating-faith.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 20\indestructible-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Johanna\Talents\Tier 20\storm-shield-talent.png");
            Ability7_5.Visible = false;
        }

        //**MURADIN**//

        private void picMuradin_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Warriors\Muradin.png");
            lblHero.Text = "Muradin";
            lblGold.Text = "4,000";

            initial();

            //**Recommended Build**//
            Border1_2.Visible = true;
            Border2_4.Visible = true;
            Border3_4.Visible = true;
            Border4_1.Visible = true;
            Border5_3.Visible = true;
            Border6_2.Visible = true;
            Border7_1.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Skills\stormbolt.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Skills\thunderclap.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Skills\dwarf-toss.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Skills\avatar.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Skills\haymaker.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Skills\second-wind.png");

            lblQ.Text = "Stormbolt\nQ";
            lblW.Text = "Thunderclap\nW";
            lblE.Text = "Dwarf Toss\nE";
            lblR1.Text = "Avatar\nR (Heroic)";
            lblR2.Text = "Haymaker\nR (Heroic)";
            lblTrait.Text = "Second Wind\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 1\block.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 1\infused-hammer.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 1\perfect-storm.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 1\reverberation.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 4\third-wind.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 4\sledgehammer.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 4\crowd-control.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 4\thunder-burn.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 7\piercing-bolt.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 7\landing-momentum.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 7\skullcracker.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 7\battle-momentum.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 10\avatar-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 10\haymaker-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 13\burning-rage.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 13\healing-static.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 13\thunder-strike.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 13\spell-shield.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 16\dwarf-launch.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 16\heavy-impact.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 16\give-em-the-axe.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 16\imposing-presence.png");
            Ability6_5.Visible = true;
            Ability6_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 16\stoneform.png");

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 20\unstoppable-force.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 20\grand-slam.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 20\hardened-shield-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Muradin\Talents\Tier 20\rewind-talent.png");
        }

        //**SONYA**//

        private void picSonya_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Warriors\Sonya.png");
            lblHero.Text = "Sonya";
            lblGold.Text = "4,000";

            initial();

            //**Recommended Build**//
            Border1_4.Visible = true;
            Border2_1.Visible = true;
            Border3_2.Visible = true;
            Border4_1.Visible = true;
            Border5_4.Visible = true;
            Border6_4.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Skills\ancient-spear.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Skills\seismic-slam.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Skills\whirlwind.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Skills\leap.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Skills\wrath-of-the-berserker.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Skills\fury.png");

            lblQ.Text = "Ancient Spear\nQ";
            lblW.Text = "Seismic Slam\nW";
            lblE.Text = "Whirlwind\nE";
            lblR1.Text = "Leap\nR (Heroic)";
            lblR2.Text = "Wrath of the Berserker\nR (Heroic)";
            lblTrait.Text = "Fury\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 1\war-paint.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 1\block.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 1\endless-fury.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 1\shot-of-fury.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 4\focused-attack.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 4\shattered-ground.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 4\hurricane.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 4\superiority.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 7\poisoned-spear.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 7\composite-spear.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 7\follow-through.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 7\ferocious-healing-talent.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 10\leap-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 10\wrath-of-the-berserker-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 13\life-funnel.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 13\aftershock.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 13\mystical-spear.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 13\spell-shield.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 16\furious-blow.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 16\no-escape.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 16\imposing-presence.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 16\nerves-of-steel-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 20\arreat-crater.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 20\anger-management.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 20\nexus-blades.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sonya\Talents\Tier 20\ignore-pain-talent.png");
            Ability7_5.Visible = false;
        }

        //**STITCHES**//

        private void picStitches_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Warriors\Stitches.png");
            lblHero.Text = "Stitches";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_3.Visible = true;
            Border2_4.Visible = true;
            Border3_1.Visible = true;
            Border4_2.Visible = true;
            Border5_1.Visible = true;
            Border6_1.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Skills\hook.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Skills\slam.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Skills\devour.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Skills\putrid-bile.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Skills\gorge.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Skills\vile-gas.png");

            lblQ.Text = "Hook\nQ";
            lblW.Text = "Slam\nW";
            lblE.Text = "Devour\nE";
            lblR1.Text = "Putrid Bile\nR (Heroic)";
            lblR2.Text = "Gorge\nR (Heroic)";
            lblTrait.Text = "Vile Gas\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 1\block.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 1\chew-your-food.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 1\heavy-slam.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 1\regeneration-master.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 4\amplified-healing.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 4\superiority.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 4\vile-cleaver.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 4\putrid-ground.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 7\tenderizer.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 7\toxic-gas.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 7\last-bite.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 7\savor-the-flavor.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 10\putrid-bile-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 10\gorge-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 13\relentless.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 13\mega-smash.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 13\indigestion.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 13\helping-hand.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 16\pulverize.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 16\fishing-hook.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 16\shish-kabob.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 16\imposing-presence.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 20\regenerative-bile.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 20\hungry-hungry-stitches.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 20\hardened-shield-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Stitches\Talents\Tier 20\bolt-of-the-storm-talent.png");
            Ability7_5.Visible = false;

        }

        //**TYRAEL**//

        private void picTyrael_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Warriors\Tyrael.png");
            lblHero.Text = "Tyrael";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_3.Visible = true;
            Border2_1.Visible = true;
            Border3_1.Visible = true;
            Border4_1.Visible = true;
            Border5_1.Visible = true;
            Border6_4.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Skills\eldruins-might.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Skills\righteousness.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Skills\smite.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Skills\judgment.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Skills\sanctification.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Skills\archangels-wrath.png");

            lblQ.Text = "El'Druin's Might\nQ";
            lblW.Text = "Righteousness\nW";
            lblE.Text = "Smite\nE";
            lblR1.Text = "Judgment\nR (Heroic)";
            lblR2.Text = "Sanctification\nR (Heroic)";
            lblTrait.Text = "Archangel's Wrath\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 1\protection-in-death.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 1\horadric-reforging.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 1\purge-evil.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 1\regeneration-master.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 4\amplified-healing.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 4\vampiric-assault.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 4\retribution.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 4\even-in-death.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 7\battle-momentum.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 7\angels-grace.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 7\reciprocate.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 7\zealotry.png");
            Ability3_5.Visible = true;
            Ability3_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 7\searing-attacks-talent.png");

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 10\judgment-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 10\sanctification-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 13\burning-rage.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 13\angelic-absorption.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 13\imposing-will.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 13\angelic-might.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 16\blade-of-justice.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 16\holy-ground.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 16\salvation.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 16\blood-for-blood-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 20\angel-of-justice.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 20\holy-arena.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 20\hardened-shield-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrael\Talents\Tier 20\nexus-blades.png");
            Ability7_5.Visible = false;

        }

        //**ABATHUR**//

        private void picAbathur_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Specialists\Abathur.png");
            lblHero.Text = "Abathur";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_1.Visible = true;
            Border2_4.Visible = true;
            Border3_1.Visible = true;
            Border4_1.Visible = true;
            Border5_4.Visible = true;
            Border6_1.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Skills\symbiote.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Skills\toxic-nest.png");
            picEAbility.Visible = false;
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Skills\ultimate-evolution.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Skills\evolve-monstrosity.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Skills\locust-strain.png");
            picSpec1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Skills\stab.png");
            picSpec2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Skills\spike-burst.png");
            picSpec3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Skills\carapace.png");
            picSpec4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Skills\deep-tunnel.png");

            lblQ.Text = "Symbiote\nQ";
            lblW.Text = "Toxic Nest\nW";
            lblE.Text = "";
            lblR1.Text = "Ultimate Evolution\nR (Heroic)";
            lblR2.Text = "Evolve Monstrosity\nR (Heroic)";
            lblTrait.Text = "Locust Strain\nTrait";
            spec1.Text = "Stab\nQ";
            spec2.Text = "Spike Burst\nW";
            spec3.Text = "Carapace\nE";
            spec4.Text = "Deep Tunnel";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 1\pressurized-glands.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 1\survival-instincts.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 1\regenerative-microbes.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 1\envenomed-nest.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 4\prolific-dispersal.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 4\ballistospores.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 4\sustained-carapace.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 4\adrenal-overload.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 7\needlespine.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 7\vile-nest.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 7\networked-carapace.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 7\calldown-mule-talent.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 10\ultimate-evolution-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 10\evolve-monstrosity-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 13\assault-strain.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 13\bombard-strain.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 13\spatial-efficiency.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 13\soma-transference.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 16\envenomed-spikes.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 16\adrenaline-boost.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 16\locust-brood-talent.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 16\volatile-mutation.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 20\evolutionary-link.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 20\evolution-complete.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 20\hivemind.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Abathur\Talents\Tier 20\locust-nest-talent.png");
            Ability7_5.Visible = false;
        }

        //**AZMODAN**//

        private void picAzmodan_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Specialists\Azmodan.png");
            lblHero.Text = "Azmodan";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_2.Visible = true;
            Border2_1.Visible = true;
            Border3_3.Visible = true;
            Border4_1.Visible = true;
            Border5_3.Visible = true;
            Border6_1.Visible = true;
            Border7_1.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Skills\globe-of-annihilation.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Skills\summon-demon-warrior.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Skills\all-shall-burn.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Skills\demonic-invasion.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Skills\black-pool.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Skills\general-of-hell.png");

            lblQ.Text = "Globe of Annihilation\nQ";
            lblW.Text = "Summon Demon Warrior\nW";
            lblE.Text = "All Shall Burn\nE";
            lblR1.Text = "Demonic Invasion\nR (Heroic)";
            lblR2.Text = "Black Pool\nR (Heroic)";
            lblTrait.Text = "General of Hell\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 1\taste-for-blood.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 1\sieging-wrath.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 1\spare-nothing.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 1\healing-ward-talent.png");
            Ability1_5.Visible = true;
            Ability1_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 1\bribe-talent.png");

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 4\burn-the-weak.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 4\gluttony.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 4\army-of-hell.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 4\bound-minion.png");
            Ability2_5.Visible = true;
            Ability2_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 4\superiority.png");

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 7\enduring-warriors.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 7\master-of-destruction.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 7\infernal-globe.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 7\mercenary-lord.png");
            Ability3_5.Visible = true;
            Ability3_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 7\first-aid-talent.png");


            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 10\demonic-invasion-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 10\black-pool-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 13\hellforged-armor.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 13\blazing-demons.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 13\march-of-sin.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 13\relentless.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 16\battleborn.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 16\demonic-smite.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 16\imposing-presence.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 16\blood-for-blood-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 20\perishing-flame.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 20\fifth-circle.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 20\bolt-of-the-storm-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Azmodan\Talents\Tier 20\storm-shield-talent.png");
        }

        //**GAZLOWE**//

        private void picGazlowe_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Specialists\Gazlowe.png");
            lblHero.Text = "Gazlowe";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_4.Visible = true;
            Border2_2.Visible = true;
            Border3_3.Visible = true;
            Border4_2.Visible = true;
            Border5_2.Visible = true;
            Border6_1.Visible = true;
            Border7_2.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Skills\rock-it-turret.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Skills\deth-lazor.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Skills\xplodium-charge.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Skills\robo-goblin.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Skills\grav-o-bomb-3000.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Skills\salvager.png");

            lblQ.Text = "Rock-It! Turret\nQ";
            lblW.Text = "Deth Lazor\nW";
            lblE.Text = "Xplodium Charge\nE";
            lblR1.Text = "Robo-Goblin\nR (Heroic)";
            lblR2.Text = "Grav-O-Bomb 3000\nR (Heroic)";
            lblTrait.Text = "Salvager\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 1\regeneration-master.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 1\scrap-o-matic-smelter.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 1\break-it-down.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 1\extra-tnt.png");
            Ability1_5.Visible = true;
            Ability1_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 1\demolitionist.png");

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 4\superiority.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 4\reduce-reuse-recycle.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 4\clockwerk-steam-fists.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 4\goblin-fusion.png");
            Ability2_5.Visible = true;
            Ability2_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 4\promote-talent.png");

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 7\mercenary-lord.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 7\rock-it-turret-xl.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 7\engine-gunk.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 7\first-aid-talent.png");
            Ability3_5.Visible = true;
            Ability3_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 7\calldown-mule-talent.png");

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 10\robo-goblin-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 10\grav-o-bomb-3000-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 13\burning-rage.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 13\turret-storage.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 13\ez-pz-dimensional-ripper.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 13\sprint-talent.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 16\long-ranged-turrets.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 16\kwik-release-charge.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 16\hyperfocus-coils.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 16\stoneskin-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 20\mecha-lord.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 20\miniature-black-hole.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 20\fury-of-the-storm.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Gazlowe\Talents\Tier 20\hardened-shield-talent.png");
            Ability7_5.Visible = false;
        }

        //**THE LOST VIKINGS**//

        private void picVikings_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Specialists\Lost_Vikings.png");
            lblHero.Text = "The Lost Vikings";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_3.Visible = true;
            Border2_4.Visible = true;
            Border3_4.Visible = true;
            Border4_1.Visible = true;
            Border5_3.Visible = true;
            Border6_2.Visible = true;
            Border7_1.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Skills\spin-to-win.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Skills\jump.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Skills\norse-force.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Skills\longboat-raid.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Skills\play-again.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Skills\fast-restart.png");
            picSpec1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Skills\go-go-go.png");

            lblQ.Text = "Spin to Win\nQ (Talent)";
            lblW.Text = "Jump!\nW (Talent)";
            lblE.Text = "Norse Force\nE (Talent)";
            lblR1.Text = "Longboat Raid\nR (Heroic)";
            lblR2.Text = "Play Again!\nR (Heroic)";
            lblTrait.Text = "Fast Restart\nTrait";
            spec1.Text = "Go Go Go!";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 1\olaf-the-stout.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 1\spy-games.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 1\viking-hoard.png");
            Ability1_4.Visible = false;
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 4\pain-dont-hurt.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 4\its-a-sabotage.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 4\hardheaded-redhead.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 4\spin-to-win.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 7\baleog-the-fierce.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 7\erik-the-swift.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 7\mercenary-lord.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 7\jump.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 10\longboat-raid-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 10\play-again-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 13\hunka-burning-olaf.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 13\speedrun.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 13\impatience-is-a-virtue.png");
            Ability5_4.Visible = false;
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 16\large-and-in-charge.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 16\64-kb-marathon.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 16\norse-force.png");
            Ability6_4.Visible = false;
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 20\ragnarok-n-roll.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 20\checkpoint-reached.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 20\the-sequel.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Lost Vikings\Talents\Tier 20\viking-fury-of-the-storm.png");
        }

        //**MURKY**//

        private void picMurky_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Specialists\Murky.png");
            lblHero.Text = "Murky";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_2.Visible = true;
            Border2_3.Visible = true;
            Border3_1.Visible = true;
            Border4_2.Visible = true;
            Border5_3.Visible = true;
            Border6_3.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Skills\slime.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Skills\pufferfish.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Skills\safety-bubble.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Skills\march-of-the-murlocs.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Skills\octo-grab.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Skills\spawn-egg.png");

            lblQ.Text = "Slime\nQ";
            lblW.Text = "Pufferfish\nW";
            lblE.Text = "Safety Bubble\nE";
            lblR1.Text = "March of the Murlocs\nR (Heroic)";
            lblR2.Text = "Octo-Grab\nR (Heroic)";
            lblTrait.Text = "Spawn Egg\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 1\block.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 1\bubble-breeze.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 1\assault-egg.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 1\bribe-talent.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 4\bigger-slime.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 4\tufferfish.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 4\living-the-dream.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 4\envenom-talent.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 7\slime-advantage.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 7\hindering-slime.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 7\compressed-air.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 7\clairvoyance-talent.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 10\march-of-the-murlocs-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 10\octo-grab-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 13\continuous-slime.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 13\wrath-of-cod.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 13\bubble-machine.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 13\hidden-assault.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 16\slimy-end.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 16\slimy-pufferfish.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 16\rejuvenating-bubble.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 16\blood-for-blood-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 20\never-ending-murlocs.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 20\and-a-shark-too.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 20\rewind-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Murky\Talents\Tier 20\bolt-of-the-storm-talent.png");
            Ability7_5.Visible = false;
        }

        //**NAZEEBO**//

        private void picNazeebo_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Specialists\Nazeebo.png");
            lblHero.Text = "Nazeebo";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_2.Visible = true;
            Border2_1.Visible = true;
            Border3_1.Visible = true;
            Border4_1.Visible = true;
            Border5_3.Visible = true;
            Border6_2.Visible = true;
            Border7_1.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Skills\corpse-spiders.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Skills\zombie-wall.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Skills\plague-of-toads.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Skills\gargantuan.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Skills\ravenous-spirit.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Skills\voodoo-ritual.png");

            lblQ.Text = "Corpse Spiders\nQ";
            lblW.Text = "Zombie Wall\nW";
            lblE.Text = "Plague of Toads\nE";
            lblR1.Text = "Gargantuan\nR (Heroic)";
            lblR2.Text = "Ravenous Spirits\nR (Heroic)";
            lblTrait.Text = "Voodoo Ritual\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 1\blood-ritual.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 1\death-ritual.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 1\demolitionist.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 1\bribe-talent.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 4\spider-cluster.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 4\gathering-power.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 4\envenom-talent.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 4\promote-talent.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 7\gidbinn.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 7\fresh-corpses.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 7\mercenary-lord.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 7\calldown-mule-talent.png");
            Ability3_5.Visible = true;
            Ability3_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 7\clairvoyance-talent.png");

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 10\gargantuan-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 10\ravenous-spirit-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 13\dead-rush.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 13\toads-of-hugeness.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 13\sprint-talent.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 13\ice-block-talent.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 16\specialized-toxin.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 16\leaping-spiders.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 16\infested-toads.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 16\stoneskin-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 20\humongoid.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 20\annihilating-spirit.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 20\fury-of-the-storm.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Nazeebo\Talents\Tier 20\bolt-of-the-storm-talent.png");
            Ability7_5.Visible = false;
        }

        //**SGT. HAMMER**//

        private void picHammer_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Specialists\Sgt._Hammer.png");
            lblHero.Text = "Sgt. Hammer";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_5.Visible = true;
            Border2_3.Visible = true;
            Border3_3.Visible = true;
            Border4_2.Visible = true;
            Border5_1.Visible = true;
            Border6_3.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Skills\spider-mines.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Skills\concussive-blast.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Skills\siege-mode.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Skills\blunt-force-gun.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Skills\napalm-strike.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Skills\artillery.png");
            picSpec1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Skills\siege-thrusters.png");

            lblQ.Text = "Spider Mines\nQ";
            lblW.Text = "Concussive Blast\nW";
            lblE.Text = "Siege Mode\nE";
            lblR1.Text = "Blunt Force Gun\nR (Heroic)";
            lblR2.Text = "Napalm Strike\nR (Heroic)";
            lblTrait.Text = "Artillery\nTrait";
            spec1.Text = "Siege Thrusters";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 1\advanced-artillery.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 1\lethal-blast.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 1\resistant.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 1\ambush.png");
            Ability1_5.Visible = true;
            Ability1_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 1\regeneration-master.png");

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 4\vampiric-assault.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 4\focused-attack.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 4\maelstrom-shells.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 4\excessive-force.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 7\slowing-mines.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 7\hyper-cooling-engines.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 7\first-aid-talent.png");
            Ability3_4.Visible = false;
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 10\blunt-force-gun-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 10\napalm-strike-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 13\giant-killer.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 13\first-strike.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 13\bullhead-mines.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 13\barricade.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 16\executioner.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 16\mine-field.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 16\hover-siege-mode.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 16\graduating-range.png");
            Ability6_5.Visible = true;
            Ability6_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 16\stoneskin-talent.png");

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 20\orbital-bfg.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 20\advanced-lava-strike.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 20\fury-of-the-storm.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sgt. Hammer\Talents\Tier 20\nexus-frenzy.png");
            Ability7_5.Visible = false;
        }

        //**SYLVANAS**//

        private void picSylvanas_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Specialists\Sylvanas.png");
            lblHero.Text = "Sylvanas";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_1.Visible = true;
            Border2_4.Visible = true;
            Border3_1.Visible = true;
            Border4_1.Visible = true;
            Border5_2.Visible = true;
            Border6_4.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Skills\withering-fire.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Skills\shadow-dagger.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Skills\haunting-wave.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Skills\wailing-arrow.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Skills\possession.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Skills\black-arrows.png");

            lblQ.Text = "Withering Fire\nQ";
            lblW.Text = "Shadow Dagger\nW";
            lblE.Text = "Haunting Wave\nE";
            lblR1.Text = "Wailing Arrow\nR (Heroic)";
            lblR2.Text = "Possession\nR (Heroic)";
            lblTrait.Text = "Black Arrows\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 1\with-the-wind.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 1\lost-soul.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 1\barbed-shot.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 1\corruption.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 4\paralysis.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 4\overflowing-quiver.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 4\rangers-ambush.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 4\envenom-talent.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 7\unstable-poison.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 7\life-drain.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 7\remorseless.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 7\mercenary-lord.png");
            Ability3_5.Visible = true;
            Ability3_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 7\shade-form.png");

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 10\wailing-arrow-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 10\possession-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 13\overwhelming-affliction.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 13\evasive-fire.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 13\splinter-shot.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 13\spell-shield.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 16\windrunner.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 16\cold-embrace.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 16\will-of-the-forsaken-talent.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 16\blood-for-blood-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 20\deafening-blast.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 20\dark-ladys-call.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 20\fury-of-the-storm.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Sylvanas\Talents\Tier 20\bolt-of-the-storm-talent.png");
            Ability7_5.Visible = false;
        }

        //**ZAGARA**//

        private void picZagara_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Specialists\Zagara.png");
            lblHero.Text = "Zagara";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_3.Visible = true;
            Border2_1.Visible = true;
            Border3_5.Visible = true;
            Border4_1.Visible = true;
            Border5_2.Visible = true;
            Border6_2.Visible = true;
            Border7_4.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Skills\baneling-barrage.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Skills\hunter-killer.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Skills\infested-drop.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Skills\devouring-maw.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Skills\nydus-network.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Skills\creep-tumor.png");

            lblQ.Text = "Baneling Barrage\nQ";
            lblW.Text = "Hunter Killer\nW";
            lblE.Text = "Infested Drop\nE";
            lblR1.Text = "Devouring Maw\nR (Heroic)";
            lblR2.Text = "Nydus Network\nR (Heroic)";
            lblTrait.Text = "Creep Tumor\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 1\centrifugal-hooks.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 1\corpse-feeders.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 1\reconstitution.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 1\demolitionist.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 4\envenomed-spines.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 4\medusa-blades.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 4\tumor-clutch.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 4\envenom-talent.png");
            Ability2_5.Visible = true;
            Ability2_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 4\infest-talent.png");

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 7\battle-momentum.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 7\volatile-acid.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 7\ventral-sacs.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 7\endless-creep.png");
            Ability3_5.Visible = true;
            Ability3_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 7\rapid-incubation-talent.png");


            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 10\devouring-maw-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 10\nydus-network-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 13\mutalisk.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 13\grooved-spines.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 13\bile-drop.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 13\giant-killer.png");
            Ability5_5.Visible = true;
            Ability5_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 13\spell-shield.png");

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 16\baneling-massacre.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 16\brood-expansion.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 16\metabolic-boost.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 16\stoneskin-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 20\tyrant-maw.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 20\broodling-nest.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 20\fury-of-the-storm.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Zagara\Talents\Tier 20\bolt-of-the-storm-talent.png");
            Ability7_5.Visible = false;
        }

        //**BRIGHTWING**//

        private void picBrightwing_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Supports\Brightwing.png");
            lblHero.Text = "Brightwing";
            lblGold.Text = "10,000";

            initial();

            //**Recommended Build**//
            Border1_3.Visible = true;
            Border2_2.Visible = true;
            Border3_2.Visible = true;
            Border4_1.Visible = true;
            Border5_3.Visible = true;
            Border6_3.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Skills\arcane-flare.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Skills\polymorph.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Skills\pixie-dust.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Skills\blink-heal.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Skills\emerald-wind.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Skills\soothing-mist.png");
            picSpec1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Skills\phase-shift.png");

            lblQ.Text = "Arcane Flare\nQ";
            lblW.Text = "Polymorph\nW";
            lblE.Text = "Pixie Dust\nE";
            lblR1.Text = "Blink Heal\nR (Heroic)";
            lblR2.Text = "Emerald Wind\nR (Heroic)";
            lblTrait.Text = "Soothing Mist\nTrait";
            spec1.Text = "Phase Shift";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 1\arcane-precision.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 1\shield-dust.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 1\bribe-talent.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 1\scouting-drone-talent.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 4\anti-magic-powder.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 4\protective-shield-talent.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 4\envenom-talent.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 4\promote-talent.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 7\regenerative-rains.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 7\gust-of-healing.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 7\calldown-mule-talent.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 7\cleanse-talent.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 10\blink-heal-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 10\emerald-wind-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 13\sticky-flare.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 13\phase-shield.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 13\sprint-talent.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 13\ice-block-talent.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 16\hardened-focus.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 16\sticky-powder.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 16\critterize.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 16\stoneskin-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 20\yseras-blessing.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 20\continuous-winds.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 20\storm-shield-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Brightwing\Talents\Tier 20\rewind-talent.png");
            Ability7_5.Visible = false;
        }

        //**LI LI**//

        private void picLiLi_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Supports\LiLi.png");
            lblHero.Text = "Li Li";
            lblGold.Text = "2,000";

            initial();

            //**Recommended Build**//
            Border1_1.Visible = true;
            Border2_3.Visible = true;
            Border3_3.Visible = true;
            Border4_1.Visible = true;
            Border5_4.Visible = true;
            Border6_2.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Skills\healing-brew.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Skills\cloud-serpent.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Skills\blinding-wind.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Skills\jug-of-1000-cups.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Skills\water-dragon.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Skills\fast-feet.png");

            lblQ.Text = "Healing Brew\nQ";
            lblW.Text = "Cloud Serpent\nW";
            lblE.Text = "Blinding Wind\nE";
            lblR1.Text = "Jug of 1,000 Cups\nR (Heroic)";
            lblR2.Text = "Water Dragon\nR (Heroic)";
            lblTrait.Text = "Fast Feet\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 1\conjurers-pursuit.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 1\pro-toss.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 1\timeless-creature.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 1\gale-force.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 4\healing-ward-talent.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 4\mending-serpent.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 4\mass-vortex.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 4\lingering-blind.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 7\shake-it-off-talent.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 7\pitch-perfect.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 7\the-good-stuff.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 7\lightning-serpent.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 10\jug-of-1000-cups-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 10\water-dragon-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 13\elusive-feet.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 13\hindering-winds.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 13\surging-winds.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 13\shrink-ray-talent.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 16\safety-sprint.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 16\two-for-one.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 16\herbal-cleanse.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 16\serpent-sidekick.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 20\jug-of-1000000-cups.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 20\double-dragon.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 20\kung-fu-hustle.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 20\storm-shield-talent.png");
            Ability7_5.Visible = true;
            Ability7_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Li Li\Talents\Tier 20\bolt-of-the-storm-talent.png");
        }

        //**MALFURION**//

        private void picMalfurion_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Supports\Malfurion.png");
            lblHero.Text = "Malfurion";
            lblGold.Text = "2,000";

            initial();

            //**Recommended Build**//
            Border1_1.Visible = true;
            Border2_4.Visible = true;
            Border3_2.Visible = true;
            Border4_1.Visible = true;
            Border5_1.Visible = true;
            Border6_1.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Skills\regrowth.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Skills\moonfire.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Skills\entangling-roots.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Skills\tranquility.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Skills\twilight-dream.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Skills\innervate.png");

            lblQ.Text = "Regrowth\nQ";
            lblW.Text = "Moonfire\nW";
            lblE.Text = "Entangling Roots\nE";
            lblR1.Text = "Tranquility\nR (Heroic)";
            lblR2.Text = "Twilight Dream\nR (Heroic)";
            lblTrait.Text = "Innervate\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 1\conjurers-pursuit.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 1\moonburn.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 1\harmony.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 1\scouting-drone-talent.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 4\vengeful-roots.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 4\shandos-clarity.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 4\versatile.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 4\protective-shield-talent.png");
            Ability2_5.Visible = true;
            Ability2_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 4\healing-ward-talent.png");

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 7\battle-momentum.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 7\enduring-growth.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 7\strangling-vines.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 7\elunes-grace.png");
            Ability3_5.Visible = true;
            Ability3_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 7\calldown-mule-talent.png");

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 10\tranquility-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 10\twilight-dream-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 13\life-seed-talent.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 13\full-moonfire.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 13\shrink-ray-talent.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 13\ice-block-talent.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 16\hardened-focus.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 16\hindering-moonfire.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 16\lunar-shower.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 16\tenacious-roots.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 20\serenity.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 20\nightmare.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 20\storm-shield-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 20\rewind-talent.png");
            Ability7_5.Visible = true;
            Ability7_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Malfurion\Talents\Tier 20\bolt-of-the-storm-talent.png");

        }

        //**REHGAR**//

        private void picRehgar_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Supports\Rehgar.png");
            lblHero.Text = "Rehgar";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_4.Visible = true;
            Border2_1.Visible = true;
            Border3_2.Visible = true;
            Border4_1.Visible = true;
            Border5_1.Visible = true;
            Border6_2.Visible = true;
            Border7_1.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Skills\chain-heal.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Skills\lightning-shield.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Skills\earthbind-totem.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Skills\ancestral-healing.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Skills\bloodlust.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Skills\ghost-wolf.png");

            lblQ.Text = "Chain Heal\nQ";
            lblW.Text = "Lightning Shield\nW";
            lblE.Text = "Earthbind Totem\nE";
            lblR1.Text = "Ancestral Healing\nR (Heroic)";
            lblR2.Text = "Bloodlust\nR (Heroic)";
            lblTrait.Text = "Ghost Wolf\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 1\spiritwalkers-grace.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 1\empowering-charge.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 1\colossal-totem.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 1\healing-totem-talent.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 4\feral-heart.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 4\chain-reaction.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 4\focused-attack.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 4\reactive-spark.png");
            Ability2_5.Visible = true;
            Ability2_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 4\farsight-talent.png");

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 7\battle-momentum.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 7\earth-shield.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 7\shadow-wolf.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 7\searing-attacks-talent.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 10\ancestral-healing-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 10\bloodlust-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 13\healing-surge.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 13\stormcaller.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 13\lightning-totem.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 13\feral-lunge.png");
            Ability5_5.Visible = true;
            Ability5_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 13\spell-shield.png");


            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 16\lightning-bond.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 16\earthgrasp-totem.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 16\blood-for-blood-talent.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 16\berserk-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 20\farseers-blessing.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 20\gladiators-war-shout.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 20\rewind-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Rehgar\Talents\Tier 20\storm-shield-talent.png");
            Ability7_5.Visible = false;
        }

        //**TASSADAR**//

        private void picTassadar_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Supports\Tassadar.png");
            lblHero.Text = "Tassadar";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_2.Visible = true;
            Border2_5.Visible = true;
            Border3_2.Visible = true;
            Border4_1.Visible = true;
            Border5_5.Visible = true;
            Border6_3.Visible = true;
            Border7_1.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Skills\plasma-shield.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Skills\psionic-storm.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Skills\dimensional-shift.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Skills\archon.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Skills\force-wall.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Skills\oracle.png");

            lblQ.Text = "Plasma Shield\nQ";
            lblW.Text = "Psionic Storm\nW";
            lblE.Text = "Dimensional Shift\nE";
            lblR1.Text = "Archon\nR (Heroic)";
            lblR2.Text = "Force Wall\nR (Heroic)";
            lblTrait.Text = "Oracle\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 1\conjurers-pursuit.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 1\overload.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 1\psi-infusion.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 1\minion-bulwark.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 4\mental-acuity.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 4\leeching-plasma.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 4\reinforce-structure.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 4\promote-talent.png");
            Ability2_5.Visible = true;
            Ability2_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 4\healing-ward-talent.png");

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 7\khalas-embrace.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 7\static-charge.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 7\deep-shift.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 7\calldown-mule-talent.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 10\archon-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 10\force-wall-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 13\distortion-beam.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 13\prescience.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 13\scryer.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 13\spell-shield.png");
            Ability5_5.Visible = true;
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 13\shrink-ray-talent.png");

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 16\evasive-shielding.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 16\resonation.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 16\second-strike.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 16\dimensional-warp.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 20\twilight-archon.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 20\force-barrier.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 20\storm-shield-talent.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tassadar\Talents\Tier 20\rewind-talent.png");
            Ability7_5.Visible = false;
        }

        //**TYRANDE**//

        private void picTyrande_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Supports\Tyrande.png");
            lblHero.Text = "Tyrande";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_1.Visible = true;
            Border2_2.Visible = true;
            Border3_2.Visible = true;
            Border4_1.Visible = true;
            Border5_1.Visible = true;
            Border6_2.Visible = true;
            Border7_5.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Skills\light-of-elune.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Skills\sentinel.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Skills\lunar-flare.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Skills\starfall.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Skills\shadowstalk.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Skills\hunters-mark.png");

            lblQ.Text = "Light of Elune\nQ";
            lblW.Text = "Sentinel\nW";
            lblE.Text = "Lunar Flare\nE";
            lblR1.Text = "Starfall\nR (Heroic)";
            lblR2.Text = "Shadowstalk\nR (Heroic)";
            lblTrait.Text = "Hunter's Mark\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 1\rangers-mark.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 1\celestial-attunement.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 1\empower.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 1\seasoned-marksman.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 4\pierce.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 4\protective-shield-talent.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 4\focused-attack.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 4\searing-arrows-talent.png");
            Ability2_5.Visible = true;
            Ability2_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 4\healing-ward-talent.png");

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 7\quickening-blessing.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 7\lunar-blaze.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 7\battle-momentum.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 7\calldown-mule-talent.png");
            Ability3_5.Visible = false;

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 10\starfall-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 10\shadowstalk-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 13\overflowing-light.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 13\shrink-ray-talent.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 13\sprint-talent.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 13\huntress-fury.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 16\ranger.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 16\shooting-star.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 16\mark-of-mending.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 16\trueshot-aura.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 20\celestial-wrath.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 20\hunters-prey.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 20\nexus-frenzy.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 20\storm-shield-talent.png");
            Ability7_5.Visible = true;
            Ability7_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Tyrande\Talents\Tier 20\rewind-talent.png");
        }

        //**UTHER**//

        private void picUther_Click(object sender, EventArgs e)
        {
            hero.Play();
            while (this.Width < 1870)
            {
                this.Width += growW;
                Application.DoEvents();
            }

            picHero.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Hero Icons\Supports\Uther.png");
            lblHero.Text = "Uther";
            lblGold.Text = "7,000";

            initial();

            //**Recommended Build**//
            Border1_3.Visible = true;
            Border2_2.Visible = true;
            Border3_2.Visible = true;
            Border4_2.Visible = true;
            Border5_3.Visible = true;
            Border6_4.Visible = true;
            Border7_3.Visible = true;

            picQAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Skills\holy-light.png");
            picWAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Skills\holy-radiance.png");
            picEAbility.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Skills\hammer-of-justice.png");
            picR1Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Skills\divine-shield.png");
            picR2Ability.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Skills\divine-storm.png");
            picTrait.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Skills\eternal-devotion.png");

            lblQ.Text = "Holy Light\nQ";
            lblW.Text = "Holy Radiance\nW";
            lblE.Text = "Hammer of Justice\nE";
            lblR1.Text = "Divine Shield\nR (Heroic)";
            lblR2.Text = "Divine Storm\nR (Heroic)";
            lblTrait.Text = "Eternal Devotion\nTrait";

            Ability1_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 1\conjurers-pursuit.png");
            Ability1_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 1\reach.png");
            Ability1_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 1\fist-of-justice.png");
            Ability1_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 1\block.png");
            Ability1_5.Visible = false;

            Ability2_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 4\boundless-conviction.png");
            Ability2_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 4\hammer-of-the-lightbringer.png");
            Ability2_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 4\amplified-healing.png");
            Ability2_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 4\protective-shield-talent.png");
            Ability2_5.Visible = false;

            Ability3_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 7\wave-of-light.png");
            Ability3_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 7\burden-of-guilt.png");
            Ability3_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 7\holy-fire.png");
            Ability3_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 7\cleanse-talent.png");
            Ability3_5.Visible = true;
            Ability3_5.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 7\clairvoyance-talent.png");

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 10\divine-shield-talent.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 10\divine-storm-talent.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 13\blessed-champion.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 13\spell-shield.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 13\holy-shock.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 13\shrink-ray-talent.png");
            Ability5_5.Visible = false;

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 16\gathering-radiance.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 16\hardened-focus.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 16\imposing-presence.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 16\benediction-talent.png");
            Ability6_5.Visible = false;

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 20\bulwark-of-light.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 20\divine-hurricane.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 20\redemption.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Uther\Talents\Tier 20\storm-shield-talent.png");
            Ability7_5.Visible = false;
        }

        //**TRACKBAR AND STATS+**//

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value <= 25)
            {
                trackbarlabel.Text = "Level " + trackBar1.Value.ToString();
            }

            if (lblHero.Text == "Falstad")
            {
                int FalstadHealth = 710;
                double FalstadHRegen = 1.4804;
                int FalstadMana = 500;
                double FalstadMRegen = 3;
                int FalstadDamage = 38;

                lblHealth.Text = (FalstadHealth + (trackBar1.Value - 1) * 120).ToString();
                lblHealthRegen.Text = (FalstadHRegen + (trackBar1.Value - 1) * .250).ToString();
                lblMana.Text = (FalstadMana + (trackBar1.Value - 1) * 10).ToString();
                lblManaRegen.Text = (FalstadMRegen + (trackBar1.Value - 1) * .098).ToString();
                lblDamage.Text = (FalstadDamage + (trackBar1.Value - 1) * 10).ToString();
            }

            if (lblHero.Text == "Illidan")
            {
                int IllidanHealth = 750;
                double IllidanHRegen = 1.7304;
                int IllidanDamage = 30;

                lblHealth.Text = (IllidanHealth + (trackBar1.Value - 1) * 125).ToString();
                lblHealthRegen.Text = (IllidanHRegen + (trackBar1.Value - 1) * .262).ToString();
                lblDamage.Text = (IllidanDamage + (trackBar1.Value - 1) * 7).ToString();
            }

            if (lblHero.Text == "Jaina")
            {
                int JainaHealth = 710;
                double JainaHRegen = 1.4804;
                int JainaMana = 500;
                double JainaMRegen = 3;
                int JainaDamage = 42;

                lblHealth.Text = (JainaHealth + (trackBar1.Value - 1) * 120).ToString();
                lblHealthRegen.Text = (JainaHRegen + (trackBar1.Value - 1) * .250).ToString();
                lblMana.Text = (JainaMana + (trackBar1.Value - 1) * 10).ToString();
                lblManaRegen.Text = (JainaMRegen + (trackBar1.Value - 1) * .098).ToString();
                lblDamage.Text = (JainaDamage + (trackBar1.Value - 1) * 8).ToString();
            }

            if (lblHero.Text == "Kael'Thas")
            {
                int KaelHealth = 740;
                double KaelHRegen = 1.539;
                int KaelMana = 500;
                double KaelMRegen = 3;
                int KaelDamage = 39;

                lblHealth.Text = (KaelHealth + (trackBar1.Value - 1) * 130).ToString();
                lblHealthRegen.Text = (KaelHRegen + (trackBar1.Value - 1) * .270).ToString();
                lblMana.Text = (KaelMana + (trackBar1.Value - 1) * 10).ToString();
                lblManaRegen.Text = (KaelMRegen + (trackBar1.Value - 1) * .098).ToString();
                lblDamage.Text = (KaelDamage + (trackBar1.Value - 1) * 8).ToString();
            }

            if (lblHero.Text == "Kerrigan")
            {
                int KerriganHealth = 830;
                double KerriganHRegen = 1.644;
                int KerriganMana = 500;
                double KerriganMRegen = 3;
                int KerriganDamage = 40;

                lblHealth.Text = (KerriganHealth + (trackBar1.Value - 1) * 150).ToString();
                lblHealthRegen.Text = (KerriganHRegen + (trackBar1.Value - 1) * .313).ToString();
                lblMana.Text = (KerriganMana + (trackBar1.Value - 1) * 10).ToString();
                lblManaRegen.Text = (KerriganMRegen + (trackBar1.Value - 1) * .098).ToString();
                lblDamage.Text = (KerriganDamage + (trackBar1.Value - 1) * 11).ToString();
            }

            if (lblHero.Text == "Nova")
            {
                int NovaHealth = 700;
                double NovaHRegen = 1.457;
                int NovaMana = 500;
                double NovaMRegen = 3;
                int NovaDamage = 40;

                lblHealth.Text = (NovaHealth + (trackBar1.Value - 1) * 110).ToString();
                lblHealthRegen.Text = (NovaHRegen + (trackBar1.Value - 1) * .227).ToString();
                lblMana.Text = (NovaMana + (trackBar1.Value - 1) * 10).ToString();
                lblManaRegen.Text = (NovaMRegen + (trackBar1.Value - 1) * .098).ToString();
                lblDamage.Text = (NovaDamage + (trackBar1.Value - 1) * 10).ToString();
            }

            if (lblHero.Text == "Raynor")
            {
                int RaynorHealth = 725;
                double RaynorHRegen = 1.5117;
                int RaynorMana = 500;
                double RaynorMRegen = 3;
                int RaynorDamage = 35;

                lblHealth.Text = (RaynorHealth + (trackBar1.Value - 1) * 120).ToString();
                lblHealthRegen.Text = (RaynorHRegen + (trackBar1.Value - 1) * .250).ToString();
                lblMana.Text = (RaynorMana + (trackBar1.Value - 1) * 10).ToString();
                lblManaRegen.Text = (RaynorMRegen + (trackBar1.Value - 1) * .098).ToString();
                lblDamage.Text = (RaynorDamage + (trackBar1.Value - 1) * 12).ToString();
            }

            if (lblHero.Text == "Thrall")
            {
                int ThrallHealth = 875;
                double ThrallHRegen = 1.8242;
                int ThrallMana = 500;
                double ThrallMRegen = 3;
                int ThrallDamage = 55;

                lblHealth.Text = (ThrallHealth + (trackBar1.Value - 1) * 160).ToString();
                lblHealthRegen.Text = (ThrallHRegen + (trackBar1.Value - 1) * .332).ToString();
                lblMana.Text = (ThrallMana + (trackBar1.Value - 1) * 10).ToString();
                lblManaRegen.Text = (ThrallMRegen + (trackBar1.Value - 1) * .098).ToString();
                lblDamage.Text = (ThrallDamage + (trackBar1.Value - 1) * 17).ToString();
            }

            if (lblHero.Text == "Tychus")
            {
                int TychusHealth = 725;
                double TychusHRegen = 1.5117;
                int TychusMana = 500;
                double TychusMRegen = 3;
                int TychusDamage = 20;

                lblHealth.Text = (TychusHealth + (trackBar1.Value - 1) * 140).ToString();
                lblHealthRegen.Text = (TychusHRegen + (trackBar1.Value - 1) * .289).ToString();
                lblMana.Text = (TychusMana + (trackBar1.Value - 1) * 10).ToString();
                lblManaRegen.Text = (TychusMRegen + (trackBar1.Value - 1) * .098).ToString();
                lblDamage.Text = (TychusDamage + (trackBar1.Value - 1) * 4).ToString();
            }

            if (lblHero.Text == "Valla")
            {
                int VallaHealth = 700;
                double VallaHRegen = 1.461;
                int VallaMana = 500;
                double VallaMRegen = 3;
                int VallaDamage = 28;

                lblHealth.Text = (VallaHealth + (trackBar1.Value - 1) * 110).ToString();
                lblHealthRegen.Text = (VallaHRegen + (trackBar1.Value - 1) * .227).ToString();
                lblMana.Text = (VallaMana + (trackBar1.Value - 1) * 10).ToString();
                lblManaRegen.Text = (VallaMRegen + (trackBar1.Value - 1) * .098).ToString();
                lblDamage.Text = (VallaDamage + (trackBar1.Value - 1) * 9).ToString();
            }

            if (lblHero.Text == "Zeratul")
            {
                int ZeratulHealth = 820;
                double ZeratulHRegen = 1.707;
                int ZeratulMana = 500;
                double ZeratulMRegen = 3;
                int ZeratulDamage = 47;

                lblHealth.Text = (ZeratulHealth + (trackBar1.Value - 1) * 135).ToString();
                lblHealthRegen.Text = (ZeratulHRegen + (trackBar1.Value - 1) * .281).ToString();
                lblMana.Text = (ZeratulMana + (trackBar1.Value - 1) * 10).ToString();
                lblManaRegen.Text = (ZeratulMRegen + (trackBar1.Value - 1) * .098).ToString();
                lblDamage.Text = (ZeratulDamage + (trackBar1.Value - 1) * 13).ToString();
            }

            if (lblHero.Text == "Anub'arak")
            {
                int AnubHealth = 800;
                double AnubHRegen = 1.668;
                int AnubMana = 500;
                double AnubMRegen = 3;
                int AnubDamage = 45;

                lblHealth.Text = (AnubHealth + (trackBar1.Value - 1) * 180).ToString();
                lblHealthRegen.Text = (AnubHRegen + (trackBar1.Value - 1) * .375).ToString();
                lblMana.Text = (AnubMana + (trackBar1.Value - 1) * 10).ToString();
                lblManaRegen.Text = (AnubMRegen + (trackBar1.Value - 1) * .098).ToString();
                lblDamage.Text = (AnubDamage + (trackBar1.Value - 1) * 9).ToString();
            }
        }

        //**TOOLTIPS**//

        //**Q ABILITY**//
        private void picQAbility_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Hammerang";
                int falhammer = 50 + (12 * trackBar1.Value);
                toolTip1.SetToolTip(picQAbility, "Mana: 70\nCooldown: 10 seconds\n\nThrow out a Hammer that returns to you, dealing " + falhammer.ToString() + " damage\nand slowing enemies by 25% for 2 seconds.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Dive";
                int illdive = 45 + (5 * trackBar1.Value);
                toolTip1.SetToolTip(picQAbility, "Cooldown: 6 seconds\n\nDive at the target, dealing " + illdive.ToString() + " damage\nand flipping to the other side of the target.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Frostbolt";
                int jainabolt = 50 + (15 * trackBar1.Value);
                toolTip1.SetToolTip(picQAbility, "Mana: 30\nCooldown: 4 seconds\n\nDeal " + jainabolt.ToString() + " damage and Chill the target.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Flamestrike";
                int kaelstrikeone = 74 + (20 * trackBar1.Value);
                int kaelstriketwo = 111 + (30 * trackBar1.Value);
                toolTip1.SetToolTip(picQAbility, "Mana: 70\n\nCooldown: 7 seconds\n\nAfter a short delay, deal " + kaelstrikeone.ToString() + " damage in an area.\nVerdant Spheres increases the radius by 50% and deals " + kaelstriketwo.ToString() + " damage.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Ravage";
                int kerrav = 50 + (20 * trackBar1.Value);
                toolTip1.SetToolTip(picQAbility, "Mana: 75\nCooldown: 8 seconds\n\nLeap to a target, dealing " + kerrav.ToString() + " damage.\nIf this kills the target, its cooldown is instantly reset.");
            }

            if (lblHero.Text == "Nova")
            {
                int novasnipe = 115 + (31 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Snipe";
                toolTip1.SetToolTip(picQAbility, "Mana: 65\nCooldown: 10 seconds\n\nDeals " + novasnipe.ToString() + "  damage to the first enemy hit.");
            }

            if (lblHero.Text == "Raynor")
            {
                int raynorpen = 85 + (22 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Penetrating Round";
                toolTip1.SetToolTip(picQAbility, "Mana: 60\nCooldown: 12 seconds\n\nDeals “ + raynorpen.ToString() + “ damage and knocks enemies back.");
            }

            if (lblHero.Text == "Thrall")
            {
                int thrallchain = 50 + (17 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Chain Lightning";
                toolTip1.SetToolTip(picQAbility, "Mana: 40\nCharge Cooldown: 6 seconds\n\nDeal " + thrallchain.ToString() + " damage to an enemy and half that amount to 2 nearby enemies.");
            }

            if (lblHero.Text == "Tychus")
            {
                int tychusoverone = 280 + (80 * trackBar1.Value);
                int tychusovertow = 140 + (40 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Overkill";
                toolTip1.SetToolTip(picQAbility, "Mana: 75\nCooldown: 15 seconds\n\nDeal " + tychusoverone.ToString() + "damage to the target and " + tychusovertow.ToString() + " damage to nearby targets over 5\nseconds. Reactivate to select a new target. Can move and use Abilities while channelling.");
            }

            if (lblHero.Text == "Valla")
            {
                int vallahungerone = 66 + (15 * trackBar1.Value);
                double vallahungertwo = 33 + (7.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Hungering Arrow";
                toolTip1.SetToolTip(picQAbility, "Mana: 60\nCooldown: 14 seconds\n\nFire an arrow that deals " + vallahungerone.ToString() + "  damage to the first target hit, then seeks up to 2 additional\nenemies dealing " + vallahungertwo.ToString() + " damage. Can hit an enemy multiple times.");
            }

            if (lblHero.Text == "Zeratul")
            {
                int zeratulcleave = 75 + (17 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Cleave";
                toolTip1.SetToolTip(picQAbility, "Mana: 40\nCooldown: 6 seconds\n\nDeal " + zeratulcleave.ToString() + " damage to nearby enemies.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                int anubimpale = 60 + (8 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Impale";
                toolTip1.SetToolTip(picQAbility, "Mana: 65\nCooldown: 12 seconds\n\nDeals " + anubimpale.ToString() + " damage. Stuns for 1 second.");
            }

            if (lblHero.Text == "Arthas")
            {
                int arthascoilone = 80 + (14 * trackBar1.Value);
                int arthascoiltwo = 82 + (22 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Death Coil";
                toolTip1.SetToolTip(picQAbility, "Mana: 50\nCooldown: 9 seconds\n\nDeals " + arthascoilone.ToString() + " damage to target enemy.\n\nCan be self-cast to heal for " + arthascoiltwo.ToString() + " Health.");
            }

            if (lblHero.Text == "Chen")
            {
                int chenkick = 45 + (10 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Flying Kick";
                toolTip1.SetToolTip(picQAbility, "Brew: 10\nCooldown: 5 seconds\n\nKick through target enemy, dealing " + chenkick.ToString() + " damage.");
            }

            if (lblHero.Text == "Diablo")
            {
                int diablocharge = 46 + (8 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Shadow Charge";
                toolTip1.SetToolTip(picQAbility, "Mana: 60\nCooldown 12 seconds\n\nCharge an enemy, dealing " + diablocharge.ToString() + " damage and stunning them 0.5 seconds. If the enemy\ncollides with terrain, they are stunned for 0.75 seconds instead.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                int etcslide = 60 + (7 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Powerslide";
                toolTip1.SetToolTip(picQAbility, "Mana: 60\nCooldown: 12 seconds\n\nSlide to a location dealing " + etcslide.ToString() + " damage and stunning enemies hit for 1 second.");
            }

            if (lblHero.Text == "Johanna")
            {
                int johannapunish = 48 + (10 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Punish";
                toolTip1.SetToolTip(picQAbility, "Mana: 40\nCooldown: 8 seconds\n\nDeal " + johannapunish.ToString() + " damage and slow enemies by 60% decaying over 2 seconds.");
            }

            if (lblHero.Text == "Muradin")
            {
                int muradinbolt = 40 + (10 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Stormbolt";
                toolTip1.SetToolTip(picQAbility, "Mana: 60\nCooldown: 10 seconds\n\nThrow a hammer, dealing " + muradinbolt.ToString() + " damage to the first enemy unit hit and stunning it for 1.5\nseconds.");
            }

            if (lblHero.Text == "Sonya")
            {
                int sonyaspear = 100 + (14 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Ancient Spear";
                toolTip1.SetToolTip(picQAbility, "Cooldown: 13 seconds\n\nThrow out a spear that pulls you to the first enemy hit, dealing " + sonyaspear.ToString() + " damage and briefly\nstunning them. If this hits, generate 40 Fury.");
            }

            if (lblHero.Text == "Stitches")
            {
                int stitcheshook = 40 + (8 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Hook";
                toolTip1.SetToolTip(picQAbility, "Mana: 75\nCooldown: 16 seconds\n\nPull the first enemy hit towards you, dealing " + stitcheshook.ToString() + " damage.");
            }

            if (lblHero.Text == "Tyrael")
            {
                int tyraelmight = 60 + (9 * trackBar1.Value);
                toolTip1.ToolTipTitle = "El'Druin's Might";
                toolTip1.SetToolTip(picQAbility, "Mana: 55\nCooldown: 12 seconds\n\nDeals " + tyraelmight.ToString() + " damage to enemies within target area, slowing them by 25% . Reactivating will\nteleport you to the blade and slow nearby enemies by 25%.");
            }

        }

        //**W ABILITY**//

        private void picWAbility_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Lightning Rod";
                int fallightningone = 35 + (10 * trackBar1.Value);
                int fallightningtwo = 25 + (7 * trackBar1.Value);
                toolTip1.SetToolTip(picWAbility, "Mana: 70\nCooldown: 15 seconds\n\nDeal " + fallightningone.ToString() + " damage to an enemy, and an additional  " + fallightningtwo.ToString() + " damage per second\nfor 4.25 seconds if you remain close to the target.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Sweeping Strike";
                int illsweep = 60 + (10 * trackBar1.Value);
                toolTip1.SetToolTip(picWAbility, "Charge Cooldown: 8 seconds\n\nDash towards target point, dealing " + illsweep.ToString() + " damage to enemies along the way.\nIf you hit an enemy, Basic Attacks do 35% more damage for 4 seconds.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Blizzard";
                int jainablizz = 45 + (16 * trackBar1.Value);
                toolTip1.SetToolTip(picWAbility, "Mana: 75\n\nCooldown: 15 seconds\n\nBombard an area with 2 waves of ice, dealing " + jainablizz.ToString() + " damage each.\nDamaged enemies are Chilled.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Living Bomb";
                int kaelbombone = 60 + (18 * trackBar1.Value);
                int kaelbombtwo = 30 + (9 * trackBar1.Value);
                toolTip1.SetToolTip(picWAbility, "Mana: 50\n\nCooldown: 10 seconds\n\nDeal " + kaelbombone.ToString() + " damage over 3 seconds to an enemy,\nthen they explode dealing " + kaelbombtwo.ToString() + " damage to all nearby enemies.\nCasting a second Living Bomb on an enemy causes the previous Living Bomb to explode immediately.\nVerdant Spheres makes this Ability cost no Mana and have no cooldown.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Imapling Blades";
                int kerimpale = 110 + (22 * trackBar1.Value);
                toolTip1.SetToolTip(picWAbility, "Mana: 60\nCooldown: 12 seconds\n\nDeals " + kerimpale.ToString() + "damage to enemies within the target area, stunning them for 1 second.");
            }


            if (lblHero.Text == "Nova")
            {
                int novapin = 40 + (10 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Pinning Shot";
                toolTip1.SetToolTip(picWAbility, "Mana: 65\nCooldown: 12 seconds\n\nDeal " + novapin.ToString() + " damage to an enemy and slow it by 30% for 2.25 seconds.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Inspire";
                toolTip1.SetToolTip(picWAbility, "Mana: 40 \nCooldown: 10 seconds\n\nGain 30% bonus Attack Speed for 6 seconds.\nNearby allies gain half of the bonus.");
            }

            if (lblHero.Text == "Thrall")
            {
                int thrallferal = 35 + (15 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Feral Spirit";
                toolTip1.SetToolTip(picWAbility, "Mana: 60\nCooldown: 12 seconds\n\nSend out a Feral Spirit that deals " + thrallferal.ToString() + " damage to enemies in its path. Upon\nhitting an enemy Hero, the wolf stops and roots that hero in place for 1 second.");
            }

            if (lblHero.Text == "Tychus")
            {
                int tychusfrag = 60 + (25 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Frag Grenade";
                toolTip1.SetToolTip(picWAbility, "Mana: 50\nCooldown: 10 seconds\n\nLob a grenade that deals " + tychusfrag.ToString() + " damage, knocking enemies away.");
            }

            if (lblHero.Text == "Valla")
            {
                int vallamulti = 60 + (15 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Multishot";
                toolTip1.SetToolTip(picWAbility, "Mana: 60\nCooldown: 8 seconds\n\nDeal " + vallamulti.ToString() + " damage to enemies within the target area.");
            }

            if (lblHero.Text == "Zeratul")
            {
                int zeratulspike = 100 + (20 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Singularity Spike";
                toolTip1.SetToolTip(picWAbility, "Mana: 60\nCooldown: 12 seconds\n\nFlings a Singularity Spike that sticks to the first enemy hit. Deals " + zeratulspike.ToString() + " damage after 1\nsecond and slows the enemy by 40% for 3 seconds.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                int anubharden = 90 + (22 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Harden Carapace";
                toolTip1.SetToolTip(picWAbility, "Mana: 35\nCooldown: 8 seconds\n\nGain a shield that absorbs " + anubharden.ToString() + " damage over 3 seconds.");
            }

            if (lblHero.Text == "Arthas")
            {
                int arthasblast = 30 + (6 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Howling Blast";
                toolTip1.SetToolTip(picWAbility, "Mana: 70\nCooldown: 12 seconds\n\nRoot enemies within the target area for 1.5 seconds and deals " + arthasblast.ToString() + " damage.");
            }

            if (lblHero.Text == "Chen")
            {
                int chensmash = 10 + (5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Keg Smash";
                toolTip1.SetToolTip(picWAbility, "Brew; 20\nCooldown: 5 seconds\n\nSmash your keg, dealing " + chensmash.ToString() + " damage and drenching affected enemies in Brew, slowing\nthem by 25% for 2.5 seconds.");
            }

            if (lblHero.Text == "Diablo")
            {
                int diablostomp = 30 + (9 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Fire Stomp";
                toolTip1.SetToolTip(picWAbility, "Mana: 50\nCooldown: 6 seconds\n\nUnleashes fire waves in all directions that deal " + diablostomp.ToString() + " damage each.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                int etcmelt = 50 + (5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Face Melt";
                toolTip1.SetToolTip(picWAbility, "Mana: 60\nCooldown: 12 seconds\n\nDeals " + etcmelt.ToString() + " damage to nearby enemies, knocking them back.");
            }

            if (lblHero.Text == "Johanna")
            {
                int johannacondem = 20 + (5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Condemn";
                toolTip1.SetToolTip(picWAbility, "Mana: 50\nCooldown: 10 seconds\n\nAfter 1 second, you pull enemies toward you, stunning them for 0.25 seconds and dealing\n" + johannacondem.ToString() + " damage.");
            }

            if (lblHero.Text == "Muradin")
            {
                int muradinthunder = 50 + (8 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Thunderclap";
                toolTip1.SetToolTip(picWAbility, "Mana: 50\nCooldown: 8 seconds\n\nDeals " + muradinthunder.ToString() + " damage in an area around Muradin and slows enemy units by 25% for 2.5\nseconds.");
            }

            if (lblHero.Text == "Sonya")
            {
                int sonyaslamone = 90 + (13 * trackBar1.Value);
                double sonyaslamtwo = 22.5 + (3.25 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Seismic Slam";
                toolTip1.SetToolTip(picWAbility, "Fury: 25\nCooldown: 1 second\n\nDeals " + sonyaslamone.ToString() + " damage to the target enemy, and " + sonyaslamtwo.ToString() + " to enemies behind the\ntarget.");
            }

            if (lblHero.Text == "Stitches")
            {
                int stitchesslam = 55 + (6 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Slam";
                toolTip1.SetToolTip(picWAbility, "Mana: 55\nCooldown: 8 seconds\n\nDeal " + stitchesslam.ToString() + " damage to enemies within the target area.");
            }

            if (lblHero.Text == "Tyrael")
            {
                int tyraelrightone = 200 + (25 * trackBar1.Value);
                int tyraelrighttwo = 80 + (10 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Righteousness";
                toolTip1.SetToolTip(picWAbility, "Mana: 65\nCooldown: 12 seconds\n\n Shields you for " + tyraelrightone.ToString() + " damage and nearby allies for " + tyraelrighttwo.ToString() + " damage for 4\nseconds.");
            }
        }

        //**E ABILITY**//

        private void picEAbility_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Barrel Roll";
                int falbarrel = 75 + (15 * trackBar1.Value);
                toolTip1.SetToolTip(picEAbility, "Mana: 75\nCooldown: 14 seconds\n\nDashes forward and grants a " + falbarrel.ToString() + " point Shield for 2 seconds.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Evasion";
                toolTip1.SetToolTip(picEAbility, "Cooldown: 15 seconds\n\nEvade enemy Basic Attacks for 2 seconds.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Cone of Cold";
                int jainacone = 55 + (18 * trackBar1.Value);
                toolTip1.SetToolTip(picEAbility, "Mana: 50\nCooldown: 10 seconds\n\nDeal " + jainacone.ToString() + " damage and Chill targets.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Gravity Lapse";
                toolTip1.SetToolTip(picEAbility, "Mana: 85\nCooldown: 13 seconds\nStun the first enemy hit for 1.5 seconds.\nVerdant Spheres causes Gravity Lapse to stun the first 3 enemies hit.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Primal Grasp";
                int kerprimal = 50 + (13 * trackBar1.Value);
                toolTip1.SetToolTip(picEAbility, "Mana: 50\nCooldown: 8 seconds\n\nPulls enemies within the target area towards you, dealing " + kerprimal.ToString() + " damage.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Holo Decoy";
                toolTip1.SetToolTip(picEAbility, "Mana: 50\nCooldown: 15 seconds\n\nCreate a decoy for 5 seconds that appears to attack enemies.\n\nUsing this Ability does not break Cloak.");
            }

            if (lblHero.Text == "Raynor")
            {
                int raynorrush = 160 + (40 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Adrenaline Rush";
                toolTip1.SetToolTip(picEAbility, "Cooldown: 45 seconds\n\nAutomatically activates to heal for “ + raynorrush.ToString() + “ when you are\nbelow 30% health.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Windfury";
                toolTip1.SetToolTip(picEAbility, "Mana: 65\nCooldown: 12 seconds\n\nIncrease your Movement Speed by 30% for 4 seconds.\nYour next 3 Basic Attacks occur 100% faster.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Run and Gun";
                toolTip1.SetToolTip(picEAbility, "Mana: 50\nCooldown: 10 seconds\n\nCharge forward and instantly wind up the Minigun.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Vault";
                toolTip1.SetToolTip(picEAbility, "Mana: 75\nCharge Cooldown: 10 seconds\n\nDash to the target area.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Blink";
                toolTip1.SetToolTip(picEAbility, "Mana: 75\nCooldown: 10 seconds\n\nTeleport to the target location.\n\nUsing this Ability does not break cloak.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                int anubburrow = 55 + (9 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Burrow Charge";
                toolTip1.SetToolTip(picEAbility, "Mana: 65\nCooldown: 16 seconds\n\nBurrows to location, dealing " + anubburrow.ToString() + " damage and briefly stunning enemies in a small area upon\nsurfacing. Can reactivate the Ability to surface early.");
            }

            if (lblHero.Text == "Arthas")
            {
                int arthasfrozen = 26 + (4 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Frozen Tempest";
                toolTip1.SetToolTip(picEAbility, "Mana: 15 per second\nCooldown: 1 second\n\nDeals " + arthasfrozen.ToString() + " damage per second to nearby enemies. Slows enemy Move speed by 6% per\nsecond, stacking up to 30%");
            }

            if (lblHero.Text == "Chen")
            {
                int chenfire = 30 + (9 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Breath of Fire";
                toolTip1.SetToolTip(picEAbility, "Brew: 30\nCooldown: 5 seconds\n\nBreathe a cone of flames, dealing " + chenfire.ToString() + " damage. Enemies soaked in Brew are set on fire,\ndealing " + chenfire.ToString() + " damage over 3 seconds.");
            }

            if (lblHero.Text == "Diablo")
            {
                int diablopower = 40 + (6 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Overpower";
                toolTip1.SetToolTip(picEAbility, "Mana: 60\nCharge Cooldown: 12 seconds\n\nGrabs the target and slams it behind Diablo, dealing " + diablopower.ToString() + " damage and stunning for 0.25\nseconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                int etcsolo = 25 + (6 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Guitar Solo";
                toolTip1.SetToolTip(picEAbility, "Mana: 40\nCooldown: 8 seconds\n\nRegenerate  " + etcsolo.ToString() + " Health per second for 4 seconds.");
            }

            if (lblHero.Text == "Johanna")
            {
                int johannaglare = 50 + (4 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Shield Glare";
                toolTip1.SetToolTip(picEAbility, "Mana: 45\nCooldown: 12 seconds\n\nDeal " + johannaglare.ToString() + " damage to enemies and cause them to miss their next 2 Basic Attacks within 4\nseconds.");
            }

            if (lblHero.Text == "Muradin")
            {
                int muradindwarf = 30 + (5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Dwarf Toss";
                toolTip1.SetToolTip(picEAbility, "Mana: 70\nCooldown: 12 seconds\n\nLeap to target location, dealing " + muradindwarf.ToString() + " damage to enemies on landing.");
            }

            if (lblHero.Text == "Sonya")
            {
                int sonyawhirlwind = 225 + (45 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Whirlwind";
                toolTip1.SetToolTip(picEAbility, "Fury: 40\nCooldown: 4 seconds\n\nDeals " + sonyawhirlwind.ToString() + " damage to nearby enemies over 4 seconds, and heals for 25% of damage\ndealt.");
            }

            if (lblHero.Text == "Stitches")
            {
                int stitchesdevourone = 300 + (20 * trackBar1.Value);
                int stitchesdevourtwo = 50 + (10 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Devour";
                toolTip1.SetToolTip(picEAbility, "Mana: 75\nCooldown: 30 seconds\n\nDeal " + stitchesdevourone.ToString() + " damage to Minions or " + stitchesdevourtwo.ToString() + " damage to Heroes. Restores 19.92% of\nyour maximum Health.");
            }

            if (lblHero.Text == "Tyrael")
            {
                int tyraelsmite = 75 + (12 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Smite";
                toolTip1.SetToolTip(picEAbility, "Mana: 50\nCooldown: 7 seconds\n\nRake target area for " + tyraelsmite.ToString() + " damage.Allies moving through the targeted area gain 25%\nincreased Movement Speed for 2 seconds.");
            }
        }

        //**R1 ABILITY**//

        private void picR1Ability_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Mighty Gust";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 70\nCooldown: 50 seconds\n\nPush enemies away and apply an 60% slow that decays over 3 seconds.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Metamorphosis";
                int illmetaone = 200 + (10 * trackBar1.Value);
                int illmetatwo = 100 + (15 * trackBar1.Value);
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nCooldown: 120 seconds\n\nTransform into Demon Form at the target location, dealing " + illmetaone.ToString() + " damage in the area.\nGain " + illmetatwo.ToString() + " temporary max Health for each Hero hit and 20% increased Attack Speed.\nLasts for 18 seconds.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Ring of Frost";
                int jainaring = 200 + (24 * trackBar1.Value);
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 70\nCooldown: 100 seconds\n\nAfter a 1.5 second delay, create a Ring of Frost in an area\nthat deals " + jainaring.ToString() + " damage and roots enemies for 3 seconds.\n\nThe ring persists for 3 seconds afterward, Chilling any enemies who touch it.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Phoenix";
                int kaelphoenix = 10 + (8 * trackBar1.Value);
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 80\nCooldown: 40 seconds\n\nLaunch a Phoenix to an area, dealing " + kaelphoenix.ToString() + " damage to enemies along the way.\nThe Phoenix persists for 7 seconds, attacking enemies for " + kaelphoenix.ToString() + " damage and splashing for 50%.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Maelstrom";
                int kermael = 50 + (5 * trackBar1.Value);
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 100\nCooldown: 120 seconds\n\nDeals " + kermael.ToString() + " damage per second to nearby enemies. Lasts for 9 seconds.");
            }

            if (lblHero.Text == "Nova")
            {
                int novatriple = 80 + (33 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Triple Tap";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nLocks in on the target Hero, then fires 3 shots that hit the first Hero or\nStructure they come in contact with for " + novatriple.ToString() + " damage each.");
            }

            if (lblHero.Text == "Raynor")
            {
                int raynorhyperionone = 25 + (6 * trackBar1.Value);
                int raynorhyperiontwo = 300 + (72 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Hyperion";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nOrder the Hyperion to make a strafing run dealing " + raynorhyperionone.ToString() + "\n hitting up to 4 enemies. Also occasionally fires its Yamato Cannon\non Structures for " + raynorhyperiontwo.ToString() + " damage. Lasts 12 seconds.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Earthquake";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 90\nCooldown: 60 seconds\n\nSummon a massive Earthquake that periodically slows enemies in the area by 70%.\nLasts for 10 seconds.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Commandeer Odin";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nCall down an Odin to pilot. The Odin deals increased Damage, has 100% increased Basic Attack range,\nand uses different Abilities. Lasts 23 seconds.");
            }

            if (lblHero.Text == "Valla")
            {
                double vallastrafe = 15 + (6.75 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Strafe";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 80\nCooldown: 60 seconds\n\nRapidly attack nearby visible enemies for " + vallastrafe.ToString() + " damage per hit, prioritizing heroes over\nminions. Valla is able to move and use Vault while strafing. Lasts for 4 seconds.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Shadow Assault";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nYour Basic Attacks cause you to charge at enemies and have 20% increased Attack Speed. Lasts for 6\nseconds.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Web Blast";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 70\nCooldown: 60 seconds\n\nWraps target enemy Hero in a cocoon for 8 seconds. Enemies wrapped in the cocoon are unable to act\nand untargetable. Allies of the Hero can attack the cocoon to break it and free them early.");
            }

            if (lblHero.Text == "Arthas")
            {
                int arthasarmy = 104 + (24 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Army of the Dead";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nSummons Ghouls that last 15 seconds. Sacrifice Ghouls to heal for " + arthasarmy.ToString() + " Health.");
            }

            if (lblHero.Text == "Chen")
            {
                int chenbarrel = 30 + (5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Wandering Keg";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nBrew: 30\nCooldown: 90 seconds\n\nRoll around inside the barrel, dealing " + chenbarrel.ToString() + " damage to enemies in the way and knocking\nthem back. Lasts for 5 seconds.");
            }

            if (lblHero.Text == "Diablo")
            {
                int diabloapoc = 100 + (10 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Apocalypse";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nCooldown: 100 seconds\n\nCreate a demonic rune under each enemy Hero on the battleground. After 1.75 seconds the rune\nexplodes dealing " + diabloapoc.ToString() + " damage and stunning for 2 seconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Mosh Pit";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 100\nCooldown: 120 seconds\n\nAfter 0.75 seconds, channel to stun nearby enemies for 4 seconds.");
            }

            if (lblHero.Text == "Johanna")
            {
                double johannafalling = 120 + (21.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Falling Sword";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 100\nCooldown: 80 seconds\n\nYou leap towards an area. While in the air, you can steer the landing location by moving.\n\nAfter 2 seconds you land, dealing " + johannafalling.ToString() + " damage to nearby enemies and knocking them\ninto the air.");
            }

            if (lblHero.Text == "Muradin")
            {
                int muradinavatar = 320 + (96 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Avatar";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nTransform for 20 seconds, gaining " + muradinavatar.ToString() + " Health and causing your Basic Attacks to stun\nenemies.");
            }

            if (lblHero.Text == "Sonya")
            {
                int sonyaleap = 50 + (11 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Leap";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nCooldown: 70 seconds\n\nLeap into the air, dealing " + sonyaleap.ToString() + " damage to nearby enemies, and stunning them for 1.5\nseconds.");
            }

            if (lblHero.Text == "Stitches")
            {
                int stitchesbile = 20 + (3 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Putrid Bile";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 75\nCooldown: 60 seconds\n\nEmit bile that deals " + stitchesbile.ToString() + " damage per second to enemies within, slowing them by 35%. You\ngain 20% Movement Speed while emitting bile. Lasts 8 seconds.");
            }

            if (lblHero.Text == "Tyrael")
            {
                int tyraeljudgeone = 60 + (8 * trackBar1.Value);
                int tyraeljudgetwo = 30 + (4 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Judgment";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nCooldown: 80 seconds\n\nCharge the target, dealing " + tyraeljudgeone.ToString() + " damage and stunning them for 1.5 seconds. Nearby\nenemies are knocked away and take " + tyraeljudgetwo.ToString() + " damage.");
            }
        }

        //**R2 ABILITY**//

        private void picR2Ability_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Hinterland Blast";
                int falhinter = 280 + (31 * trackBar1.Value);
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 100\nCooldown: 90 seconds\n\nAfter a short delay, deal " + falhinter.ToString() + " damage to enemies within a long line.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "The Hunt";
                int illhunt = 150 + (20 * trackBar1.Value);
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nCooldown: 60 seconds\nCharge to target unit, dealing " + illhunt.ToString() + " damage on impact and stunning for 1 second.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Summon Water Elemental";
                int jainawater1 = 65 + (7 * trackBar1.Value);
                int jainawater2 = 50 + (6 * trackBar1.Value);
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 75\nCooldown: 80 seconds\n\nSummons a Water Elemental at target location, dealing " + jainawater1.ToString() + " damage and Chilling nearby enemies.\nThe Water Elemental's Basic Attacks do " + jainawater2.ToString() + " damage, splash for 25% damage and Chill.\nCan reactivate the Ability to retarget the Water Elemental.\nLasts 20 seconds.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Pyroblast";
                int kaelpyroone = 300 + (65 * trackBar1.Value);
                double kaelpyrotwo = 150 + (32.5 * trackBar1.Value);
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 80\nCooldown: 50 seconds\n\nAfter 2 seconds, cast a slow-moving fireball that deals " + kaelpyroone.ToString() + " damage\nto an enemy Hero and " + kaelpyrotwo.ToString() + " damage to enemies nearby.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Summon Ultralisk";
                int kerultra = 40 + (8 * trackBar1.Value);
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 100\nCooldown: 80 seconds\n\nSummon an Ultralisk that attacks the target to deal " + kerultra.ToString() + " damage.\nAttacks splash to nearby enemies for 50% damage.\nCan reactivate the Ability to retarget the Ultralisk.\nLasts for 20 seconds.");
            }

            if (lblHero.Text == "Nova")
            {
                int novastrike = 300 + (35 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Precision Strike";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 100\nCharge Cooldown: 60 seconds\n\nAfter a 1.5 second delay, deals " + novastrike.ToString() + " damage to enemies within an area.\n\nUnlimited range.");
            }

            if (lblHero.Text == "Raynor")
            {
                int raynorraider = 16 + (4 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Raynor’s Raiders";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 100\nCooldown: 80 seconds\n\nSummon two Stealthed Banshees that attack an enemy. Each Banshee\ndeals “ + raynorraiders.ToString + “ damage a second and lasts 22 seconds. Can reactivate\nthe Ability to retarget the Banshees.");
            }

            if (lblHero.Text == "Thrall")
            {
                int thrallsunder = 160 + (22 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Sundering";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 75\nCooldown: 70 seconds\n\nAfter a short delay, sunder the earth in a long line, dealing " + thrallsunder.ToString() + " damage and shoving\nenemies to the side, stunning them for 1.5 seconds.");
            }

            if (lblHero.Text == "Tychus")
            {
                int tychusdrill = 30 + (14 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Drakken Laser Drill";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nCall down a Laser Drill to attack nearby enemies,\ndealing " + tychusdrill.ToString() + " damage every second. Reactivate to assign a new target.\nLasts 22 seconds.");
            }

            if (lblHero.Text == "Valla")
            {
                int vallarain = 100 + (23 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Rain of Vengeance";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 100\nCooldown: 90 seconds\n\nLaunch 2 waves of Shadow Beasts that deal " + vallarain.ToString() + " damage to enemies within the target\narea, stunning for 0.5 seconds per wave.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Void Prison";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nSlows time in an area to a near standstill, making allies and enemies invulnerable and unable to act for\n5 seconds. You are not affected.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                int anublocustone = 20 + (8 * trackBar1.Value);
                double anublocusttwo = 10 + (1.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Locust Swarm";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nDeals " + anublocustone.ToString() + " damage per second in an area around Anub'arak. Each enemy damaged heals\nAnub'arak for " + anublocusttwo.ToString() + " health.");
            }

            if (lblHero.Text == "Arthas")
            {
                int arthassin = 150 + (15 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Summon Sindragosa";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 100\nCooldown: 80 seconds\n\nDeals " + arthassin.ToString() + " damage and slows enemies by 60% for 2 seconds. Also disables Minions for 10\nseconds and Structures for 20 seconds.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Storm, Earth, Fire";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nBrew: 10 \nCooldown: 100 seconds\n\nSplit into three elemental spirits for 15.15 seconds, each with 50% of your maximum Health, and\nenables two new leaping attacks for use.");
            }

            if (lblHero.Text == "Diablo")
            {
                int diablobreath = 320 + (72 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Lightning Breath";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 80\nCooldown: 60 seconds\n\nBecome Unstoppable while channeling lightning that deals " + diablobreath.ToString() + " damage over 4 seconds.\nThe direction of the Lightning changes with your mouse cursor position.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                int etcdive = 100 + (12 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Stage Dive";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 100\nCooldown: 75 seconds\n\nLeap to any location. Deals " + etcdive.ToString() + " damage to enemies in the area, slowing them for 3\nseconds.");
            }

            if (lblHero.Text == "Johanna")
            {
                int johannablessedone = 70 + (9 * trackBar1.Value);
                double johannablessedtwo = 35 + (4.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Blessed Shield";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 90 seconds\nCooldown: 60 seconds\n\nDeal " + johannablessedone.ToString() + " damage and stun the first enemy hit for 2 seconds. Blessed Shield then bounces\nto 2 nearby enemies, dealing " + johannablessedtwo.ToString() + " damage and stunning them for 1 second.");
            }

            if (lblHero.Text == "Muradin")
            {
                int muradinhaymakerone = 300 + (20 * trackBar1.Value);
                int muradinhaymakertwo = 75 + (5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Haymaker";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 80\nCharge Cooldown: 40 seconds\n\nStun target enemy Hero, and wind up a punch dealing " + muradinhaymakerone.ToString() + " damage and knocking the\ntarget back, hitting enemies in the way for " + muradinhaymakertwo.ToString() + " damage and knocking them aside.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Wrath of the Berserker";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nCooldown: 45 seconds\n\nGain 40% Bonus Damage on all Basic Attacks and Abilities. Stuns, slows, silences, polymorphs and roots\nagainst you have 50% reduced duration. Lasts 15 seconds, and extends by 1 second for every 10 Fury\ngained while active.");
            }

            if (lblHero.Text == "Stitches")
            {
                int stitchesgorge = 100 + (25 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Gorge";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 80\nCooldown: 80 seconds\n\nConsume an enemy Hero, trapping them for 3.5 seconds. When Gorge ends, the enemy Hero takes " + stitchesgorge.ToString() + "\ndamage. The trapped Hero cannot move or act and doesn't take damage from other\nsources. Stitches' Movement Speed is reduced by 15% while an enemy is Gorged.\n\nCannot be used on Massive Heroes.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Sanctification";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 75\nCooldown: 50 seconds\n\nWhile channeling, Tyrael makes all nearby allied Heroes invulnerable and unstoppable. Lasts 3 seconds.\n\nDoes not affect Tyrael.");
            }
        }

        //**TRAIT**//

        private void picTrait_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Tailwind";
                toolTip1.SetToolTip(picTrait, "Cooldown: 6 seconds\n\nGain 20% increased Movement Speed after not taking damage for 6 seconds.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Betrayer's Trust";
                toolTip1.SetToolTip(picTrait, "Basic Attacks heal for 20% of damage dealt and reduce your Ability cooldowns by 1 second.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Frostbite";
                toolTip1.SetToolTip(picTrait, "All abilities Chill targets, slowing Movement Speed by 25% and amplifying damage from your abilities by 50%.\nLasts 4 seconds.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Verdant Spheres";
                toolTip1.SetToolTip(picTrait, "Cooldown: 6 seconds\n\nActivate to make your next Basic Ability more powerful.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Assimilation";
                int kerass = 200 + (100 * trackBar1.Value);
                toolTip1.SetToolTip(picTrait, "Gain 10% of damage dealt from Basic Attacks and Abilities as Shields for 6 seconds.\nShield amount gained doubled against Heroes.\nCurrent maximum: " + kerass.ToString() + ".");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Permanent Cloak, Sniper";
                toolTip1.SetToolTip(picTrait, "Cooldown: 3 seconds\n\nGain Stealth when out of combat for 3 seconds. Taking damage, attacking, or\nchanneling reveals you.\n\nBasic Attack range is 20% further than other ranged Heroes, and you see 10%\nfurther than other Heroes.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Advanced Optics";
                toolTip1.SetToolTip(picTrait, "Basic Attack range is 20% further than other ranged Heroes, and you\nsee 10% further than other Heroes.");
            }

            if (lblHero.Text == "Thrall")
            {
                int thrallfrostwolf = 60 + (30 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Frostwolf Resilience";
                toolTip1.SetToolTip(picTrait, "Dealing damage with Abilities grants 1 stack of Frostwolf Resilience.At 5 stacks, you are instantly\nhealed for" + thrallfrostwolf.ToString() + " Health.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Minigun";
                toolTip1.SetToolTip(picTrait, "Your Attack Speed increases the longer that you attack, becoming fully wound up after 4 Basic Attacks.\nLasts 3 seconds.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Hatred";
                toolTip1.SetToolTip(picTrait, "Basic Attacks grant a stack of Hatred, up to 10. Each Hatred stack increases Basic Attack damage by\n2% and Movement Speed by 1%.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Permanent Cloak";
                toolTip1.SetToolTip(picTrait, "Cooldown: 3 seconds\n\nGain Stealth when out of combat for seconds.\n\nTaking damage, attacking, or channeling reveals you.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                int anubhost = 8 + (2 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Scarab Host";
                toolTip1.SetToolTip(picTrait, "Spawn a Beetle at Anub'arak's location whenever he casts a spell. Beetles last for 10 seconds, attacking\nnearby enemies for " + anubhost.ToString() + " damage.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Frostmourne Hungers";
                toolTip1.SetToolTip(picTrait, "Cooldown: 12 seconds\n\nActivate to make your next Basic Attack strike immediately, do 100% increased damagte, and restore 30 Mana.");
            }

            if (lblHero.Text == "Chen")
            {
                int chenfortone = 40 + (24 * trackBar1.Value);
                int chenforttwo = 120 + (72 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Fortifying Brew";
                toolTip1.SetToolTip(picTrait, "Cooldown: 5 seconds\n\nDrink from your keg, gaining 40 Brew and " + chenfortone.ToString() + " temporary Shields per second, up to a\nmaximum of " + chenforttwo.ToString() + " while drinking. Shields persist for 2 seconds after you stop drinking.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Black Soulstone";
                toolTip1.SetToolTip(picTrait, "Gain 10 Souls per Hero killed, or 1 per Minion. For each Soul, gain .15% maximum Health. If you have\n100 Souls upon dying, you resurrect in 5 seconds and lose 100 Souls. Maximum 100 Souls.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Rockstar";
                toolTip1.SetToolTip(picTrait, "When you use a Basic or Heroic ability, give 20% Attack Speed for 4 seconds to all nearby allied Heroes.");
            }

            if (lblHero.Text == "Johanna")
            {
                double johannaskin = 193 + (57.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Iron Skin";
                toolTip1.SetToolTip(picTrait, "Mana: 25\nCooldown: 25 seconds\n\nBecome Unstoppable and gain a Shield that absorbs " + johannaskin.ToString() + " damage for 4 seconds.");
            }

            if (lblHero.Text == "Muradin")
            {
                double muradinsecondone = 12 + (3.6 * trackBar1.Value);
                double muradinsecondtwo = 24 + (7.2 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Second Wind";
                toolTip1.SetToolTip(picTrait, "Restore " + muradinsecondone.ToString() + " Health per second when you have not taken damage for 4 seconds. When\nbelow 40% Health, increased to " + muradinsecondtwo.ToString() + " Health per second.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Fury";
                toolTip1.SetToolTip(picTrait, "Use Fury instead of Mana, which is gained by taking or dealing damage. Using an Ability grants 10%\nMovement Speed for 4 seconds.");
            }

              if (lblHero.Text == "Stitches")
            {
				double stitchesgas = 10 + (1.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Vile Gas";
                toolTip1.SetToolTip(picTrait, "When damaged, Stitches emits a gas cloud that persists for 4 seconds. Enemies who enter it are\npoisoned for " + stitchesgas.ToString() + " damage per second for 3 seconds.");
            }

              if (lblHero.Text == "Tyrael")
              {
                  int tyraelwrath = 200 + (40 * trackBar1.Value);
                  toolTip1.ToolTipTitle = "Archangel's Wrath";
                  toolTip1.SetToolTip(picTrait, "When you die, become invulnerable and explode for " + tyraelwrath.ToString() + " damage after 3.5 seconds.");
              }
        }

        //**ABILITY 1_1**//

        private void Ability1_1_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Power Throw";
                toolTip1.SetToolTip(Ability1_1, "Increase the range of Hammerang by 40%\nand the slow duration by 25%.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Battered Assault";
                toolTip1.SetToolTip(Ability1_1, "Increases the Basic Attack bonus of Sweeping Strike to 50%.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Winter's Reach";
                toolTip1.SetToolTip(Ability1_1, "Increases the range of Frostbolt by 30%.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Mana Addict";
                toolTip1.SetToolTip(Ability1_1, "Increase your maximum Mana by 15 when you pick up a Regeneration Globe.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Siphoning Impact";
                toolTip1.SetToolTip(Ability1_1, "Ravage heals you for 10.15% of your maximum\nHealth if it hits an enemy");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Conjurer's Pursuit";
                toolTip1.SetToolTip(Ability1_1, "Increases Mana Regeneration by 0.5 per second.\nEvery 3 Regeneration Globes gathered increases this bonus by 0.25.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Give Me More!";
                toolTip1.SetToolTip(Ability1_1, "Increases Adrenaline Rush healing by 50%.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Block";
                toolTip1.SetToolTip(Ability1_1, "Periodically reduces the damage received from\nHero Basic Attacks by 50% . Stores up to 2\ncharges.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Armor Piercing Rounds";
                toolTip1.SetToolTip(Ability1_1, "Overkill's damage to the primary\ntarget increased by 20%.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Cost-Effective Materials";
                toolTip1.SetToolTip(Ability1_1, "Reduces the Mana cost of Hungering Arrow by 3.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Block";
                toolTip1.SetToolTip(Ability1_1, "Periodically reduces the damage received from\nHero Basic Attacks by 50% . Stores up to 2\ncharges.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Extended Spikes";
                toolTip1.SetToolTip(Ability1_1, "Increases the max range of Impale by 25%.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Block";
                toolTip1.SetToolTip(Ability1_1, "Periodically reduces the damage received from\nHero Basic Attacks by 50%. Stores up to 2\ncharges.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Bottomless Mug";
                toolTip1.SetToolTip(Ability1_1, "Increase maximum Brew by 50.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Devil's Due";
                toolTip1.SetToolTip(Ability1_1, "Reduces Black Soulstone's resurrection cost to\n60 Souls.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Rolling Like A Stone";
                toolTip1.SetToolTip(Ability1_1, "Increases the range of Powerslide by 25%.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Reinforce";
                toolTip1.SetToolTip(Ability1_1, "Using Basic Abilities reduces the next Basic\nAttack against you by 50%. Maximum 2 stacks.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Block";
                toolTip1.SetToolTip(Ability1_1, "Periodically reduces the damage received from\nHero Basic Attacks by 50% . Stores up to 2\ncharges.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "War Paint";
                toolTip1.SetToolTip(Ability1_1, "Basic Attacks heal you for 30% of the damage\ndealt.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Block";
                toolTip1.SetToolTip(Ability1_1, "Periodically reduces the damage received from\nHero Basic Attacks by 50% . Stores up to 2\ncharges.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Protection in Death";
                toolTip1.SetToolTip(Ability1_1, "When Archangel's Wrath explodes, shield nearby\nallies for 50% of their max Health for 5 seconds.");
            }

        }

        //**ABILITY 1_2**//

        private void Ability1_2_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Updraft";
                toolTip1.SetToolTip(Ability1_2, "Increase the range of Barrel Roll by 30%.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Shadow Shield";
                double illshield = 62.5 + (12.5 * trackBar1.Value);
                toolTip1.SetToolTip(Ability1_2, "Evasion grants a " + illshield.ToString() + " point Shield for 5 seconds.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Lingering Chill";
                toolTip1.SetToolTip(Ability1_2, "Increases the duration of Chill from 4 seconds to 6 seconds.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Convection";
                toolTip1.SetToolTip(Ability1_2, "Flamestrike deals 20% bonus damage to\nenemies stunned by Gravity Lapse.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Sharpened Blades";
                toolTip1.SetToolTip(Ability1_2, "Impaling Blades deals 20% more damage.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Psi-Op Rangefinder";
                toolTip1.SetToolTip(Ability1_2, "Increases Snipe's range by 20% and reduces\nthe Cooldown by 2 seconds.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Seasoned Marksman";
                toolTip1.SetToolTip(Ability1_2, "For every 6 enemy Minion or Mercenary kills\nnear your Hero, gain 1 Basic Attack damage.\nHero Takedowns count as 2 Minion kills.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Champions Restitution";
                toolTip1.SetToolTip(Ability1_2, "Increases Chain Lightning's range by 30% and\nattacking enemies recently hit by Chain\nLightning restores 10 Mana.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Shredder Grenade";
                toolTip1.SetToolTip(Ability1_2, "Increases the explosion radius of Frag Grenade\nby 25%.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Siphoning Arrow";
                toolTip1.SetToolTip(Ability1_2, "50% of the damage dealt by Hungering Arrow is\nreturned as Health to Valla.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Greater Cleave";
                toolTip1.SetToolTip(Ability1_2, "Increases the radius of Cleave by 33%.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Persistent Carapace";
                toolTip1.SetToolTip(Ability1_2, "Increases Harden Carapace's Shield duration by\n3 seconds.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Eternal Hunger";
                toolTip1.SetToolTip(Ability1_2, "Mana restored by Frostmourne Hungers\nincreased to 60 .");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Full Keg";
                toolTip1.SetToolTip(Ability1_2, "Increase the duration enemies are slowed by Keg Smash by 1.5\nseconds.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Block";
                toolTip1.SetToolTip(Ability1_2, "Periodically reduces the damage received from\nHero Basic Attacks by 50% . Stores up to 2\ncharges.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Pwn Shop Guitar";
                toolTip1.SetToolTip(Ability1_2, "Reduces Guitar Solo's Mana cost by 40%.");
            }

            if (lblHero.Text == "Johanna")
            {
                int johannapawn = 80 + (20 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Knight Takes Pawn";
                toolTip1.SetToolTip(Ability1_2, "Condemn deals " + johannapawn.ToString() + " additional\ndamage to Minions and Mercenaries and stuns\nthem for 4 seconds.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Infused Hammer";
                toolTip1.SetToolTip(Ability1_2, "Refunds 45 Mana for each enemy hit.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Block";
                toolTip1.SetToolTip(Ability1_2, "Periodically reduces the damage received from\nHero Basic Attacks by 50% . Stores up to 2\ncharges.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Chew Your Food";
                toolTip1.SetToolTip(Ability1_2, "Using Devour also heals you for 9.555% of your\nmax Health over 3.0625 seconds.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Horadric Reforging";
                toolTip1.SetToolTip(Ability1_2, "Increases the damage dealt by El'Druin's Might\nby 30%.");
            }
        }

        //**ABILITY 1_3**//

        private void Ability1_3_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Seasoned Marksman";
                toolTip1.SetToolTip(Ability1_3, "For every 6 enemy Minion or Mercenary kills near your Hero,\ngain 1 Basic Attack damage.\nHero Takedowns count as 2 Minion kills.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Regeneration Master";
                toolTip1.SetToolTip(Ability1_3, "Increases Health Regeneration by 4 per second.\nEvery 3 Regeneration Globes gathered increases this bonus by 4.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Deep Chill";
                toolTip1.SetToolTip(Ability1_3, "Increases the slow of Chill from 25% to 35%.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Energy Roll";
                toolTip1.SetToolTip(Ability1_3, "Gravity Lapse's cooldown is reduced by 3\nseconds for each enemy hit.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Sweeping Grasp";
                toolTip1.SetToolTip(Ability1_3, "Increases the range of Primal Grasp by 20%.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Ambush Snipe";
                toolTip1.SetToolTip(Ability1_3, "Increases Snipe's damage by 20% when used\nfrom Cloak or within one second of being Cloaked.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Raiders Recruitment";
                toolTip1.SetToolTip(Ability1_3, "Kill enemy Minions to gain stacks of\nRecruitment. Use 15 stacks to recruit target\nMercenary, instantly defeating them. Does not\nwork on Bosses. Maximum 50 stacks.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Rabid Wolves";
                toolTip1.SetToolTip(Ability1_3, "Damaging Heroes with Feral Spirit grants 3\nstacks of Frostwolf Resilience");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Dash";
                toolTip1.SetToolTip(Ability1_3, "Increases the range of Run and Gun by 25%.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Composite Arrows";
                toolTip1.SetToolTip(Ability1_3, "Increases the range of Multishot by 20%.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Rapid Displacement";
                toolTip1.SetToolTip(Ability1_3, "Reduces the cooldown of Blink by 1.5 seconds.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Assault Scarab";
                toolTip1.SetToolTip(Ability1_3, "Increases the attack damage of spawned Beetles\nby 25%.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Frost Presence";
                toolTip1.SetToolTip(Ability1_3, "Howling Blast cooldown lowered by 3 seconds.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Consuming Flame";
                toolTip1.SetToolTip(Ability1_3, "Breath of Fire's burn effect when used on Brew-soaked targets is\nincreased by 2 seconds.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Soul Feast";
                toolTip1.SetToolTip(Ability1_3, "Black Soulstone increases your Health\nRegeneration by 3% per Soul.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Prog Rock";
                toolTip1.SetToolTip(Ability1_3, "Each Regeneration Globe you pick up \nermanently increases the healing per second of\nGuitar Solo by 2");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Righteous Smash";
                toolTip1.SetToolTip(Ability1_3, "Punish restores 10 Mana per enemy hit.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Perfect Storm";
                toolTip1.SetToolTip(Ability1_3, "Storm Bolt's damage is permanently increased\nby 5 for each enemy Hero hit.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Endless Fury";
                toolTip1.SetToolTip(Ability1_3, "Increases maximum Fury to 200.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Heavy Slam";
                toolTip1.SetToolTip(Ability1_3, "Slam damage increased by 50%.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Purge Evil";
                toolTip1.SetToolTip(Ability1_3, "Smite deals 25% more damage to Heroes.");
            }
        }

        //**ABILITY 1_4**//

        private void Ability1_4_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Conjurer's Pursuit";
                toolTip1.SetToolTip(Ability1_4, "Increases Mana Regeneration by 0.5 per second.\nEvery 3 Regeneration Globes gathered increases this bonus by 0.25.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Seasoned Marksman";
                toolTip1.SetToolTip(Ability1_4, "For every 6 enemy Minion or Mercenary kills near your Hero,\ngain 1 Basic Attack damage.\nHero Takedowns count as 2 Minion kills.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Conjurer's Pursuit";
                toolTip1.SetToolTip(Ability1_4, "Increases Mana Regeneration by 0.5 per second.\nEvery 3 Regeneration Globes gathered increases this bonus by 0.25.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Fel Infusion";
                int kaelfel = 26 + (9 * trackBar1.Value);
                toolTip1.SetToolTip(Ability1_4, "Heal for " + kaelfel.ToString() + " Health when you\nactivate Verdant Spheres.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Block";
                toolTip1.SetToolTip(Ability1_4, "Periodically reduces the damage received from Hero Basic Attacks by 50%.\nStores up to 2 charges.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Tazer Rounds";
                toolTip1.SetToolTip(Ability1_4, "Increases the duration of Pinning Shot's slow to\n4 seconds.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Scouting Drone";
                toolTip1.SetToolTip(Ability1_4, "Places a Scouting Drone at target location,\nrevealing a large area around it for 45 seconds.\nThis drone cannot be hidden and is killed by\nenemies with 2 Basic Attacks.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Seasoned Marksman";
                toolTip1.SetToolTip(Ability1_4, "For every 6 enemy Minion or Mercenary kills\nnear your Hero, gain 1 Basic Attack damage.\nHero Takedowns count as 2 Minion kills.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Regeneration Master";
                toolTip1.SetToolTip(Ability1_4, "Increases Health Regeneration by 4 per second.\nEvery 3 Regeneration Globes gathered increases\nthis bonus by 4 .");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Rancor";
                toolTip1.SetToolTip(Ability1_4, "Each Hatred stack increases Attack Speed by 1.5%");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Regeneration Master";
                toolTip1.SetToolTip(Ability1_4, "Increases Health Regeneration by 4 per second.\nEvery 3 Regeneration Globes gathered increases\nthis bonus by 4.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Regeneration Master";
                toolTip1.SetToolTip(Ability1_4, "Increases Health Regeneration by 4 per second.\nEvery 3 Regeneration Globes gathered increases\nthis bonus by 4.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Regeneration Master";
                toolTip1.SetToolTip(Ability1_4, "Increases Health Regeneration by 4 per second.\nEvery 3 Regeneration Globes gathered increases\nthis bonus by 4");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Regeneration Master";
                toolTip1.SetToolTip(Ability1_4, "Increases Health Regeneration by 4 per second.\nEvery 3 Regeneration Globes gathered increases\nthis bonus by 4.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Overwhelming Force";
                toolTip1.SetToolTip(Ability1_4, "Increases the range and knockback of Shadow\nCharge by 25% .");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Block";
                toolTip1.SetToolTip(Ability1_4, "Periodically reduces the damage received from\nHero Basic Attacks by 50% . Stores up to 2\ncharges.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Regeneration Master";
                toolTip1.SetToolTip(Ability1_4, "Increases Health Regeneration by 4 per second.\nEvery 3 Regeneration Globes gathered increases\nthis bonus by 4.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Reverberation";
                toolTip1.SetToolTip(Ability1_4, "Enemies hit by Thunder Clap have their Attack\nSpeed reduced by 50% for 3 seconds.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Shot of Fury";
                toolTip1.SetToolTip(Ability1_4, "Activate to gain 50 Fury.\n\nUsable while Whirlwinding.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Regeneration Master";
                toolTip1.SetToolTip(Ability1_4, "Increases Health Regeneration by 4 per second.\nEvery 3 Regeneration Globes gathered increases\nthis bonus by 4.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Regeneration Master";
                toolTip1.SetToolTip(Ability1_4, "Increases Health Regeneration by 4 per second.\nEvery 3 Regeneration Globes gathered increases\nthis bonus by 4.");
            }
        }

        //**ABILITY 1_5**//


        private void Ability1_5_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Bribe";
                toolTip1.SetToolTip(Ability1_5, "Kill enemy Minions to gain up to 50 stacks of Bribe.\nUse 20 stacks to bribe target Mercenary, instantly defeating them.\nDoes not work on Bosses.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Seasoned Marksman";
                toolTip1.SetToolTip(Ability1_5, "For every 6 enemy Minion or Mercenary kills near your Hero,\ngain 1 Basic Attack damage.\nHero Takedowns count as 2 Minion kills.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Scouting Drone";
                toolTip1.SetToolTip(Ability1_5, "Places a Scouting Drone at target location,\nrevealing a large area around it for 45 seconds.\nThis drone cannot be hidden and is killed by\nenemies with 2 Basic Attacks.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Punishment";
                toolTip1.SetToolTip(Ability1_5, "Using an Ability also grants 3 Hatred stacks.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Seasoned Marksman";
                toolTip1.SetToolTip(Ability1_5, "For every 6 enemy Minion or Mercenary kills\nnear your Hero, gain 1 Basic Attack damage.\nHero Takedowns count as 2 Minion kills.");
            }

        }

        //**ABILITY 2_1**//

        private void Ability2_1_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Charged Up";
                toolTip1.SetToolTip(Ability2_1, "Lightning Rod strikes the target 2 additional times.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Marked for Death";
                toolTip1.SetToolTip(Ability2_1, "Your next Basic Attack on the Dive target deals 100% more damage.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Frost Shards";
                toolTip1.SetToolTip(Ability2_1, "Frostbolt will now pierce the first target to hit\nan additional target behind them.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Mana Tap";
                toolTip1.SetToolTip(Ability2_1, "Flamestrike restores 20 Mana per enemy killed.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Focused Attack";
                toolTip1.SetToolTip(Ability2_1, "Every 10 seconds, your next Basic Attack deals\n75% additional damage. Basic Attacks reduce\nthis cooldown by 1 second.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Perfect Shot";
                toolTip1.SetToolTip(Ability2_1, "Hitting an enemy Hero with Snipe refunds 50%\nof the Mana cost. Killing an enemy Hero with\nSnipe refunds 100% of the Mana cost.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Focused Attacks";
                toolTip1.SetToolTip(Ability2_1, "Every 10 seconds, your next Basic Attack deals\n75% additional damage. Basic Attacks reduce\nthis cooldown by 1 second.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Ride The Lightning";
                toolTip1.SetToolTip(Ability2_1, "Chain Lightning can hit 2 additional enemies for\n50% damage.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Focused Attack";
                toolTip1.SetToolTip(Ability2_1, "Every 10 seconds, your next Basic Attack deals\n75% additional damage. Basic Attacks reduce\nthis cooldown by 1 second.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Vampiric Assault";
                toolTip1.SetToolTip(Ability2_1, "Basic Attacks heal for 15% of the damage dealt\nto the primary target.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Focused Attack";
                toolTip1.SetToolTip(Ability2_1, "Every 10 seconds, your next Basic Attack deals\n75% additional damage. Basic Attacks reduce\nthis cooldown by 1 second.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Underking";
                toolTip1.SetToolTip(Ability2_1, "ncreases the range of Burrow Charge by 20%\nand lowers the cooldown by 2 seconds.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Superiority";
                toolTip1.SetToolTip(Ability2_1, "Reduce damage taken from Minions, Structures,\nand Mercenaries by 50%.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Swift Reflexes";
                toolTip1.SetToolTip(Ability2_1, "Every 4 seconds Chen can dodge an enemy Hero's Basic Attack,\npreventing all of its damage.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Demonic Strength";
                toolTip1.SetToolTip(Ability2_1, "Once Overpower's stun expires, the target is\nslowed by 25% for 2 seconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Double-Necked Guitar";
                toolTip1.SetToolTip(Ability2_1, "Increases Powerslide's width by 100% and you\nslide 30% faster.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Amplified Healing";
                toolTip1.SetToolTip(Ability2_1, "Increases regeneration effects and all healing\nreceived by 30%");
            }

            if (lblHero.Text == "Muradin")
            {
                double muradinthirdone = 16 + (4.8 * trackBar1.Value);
                double muradinthirdtwo = 32 + (9.6 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Third Wind";
                toolTip1.SetToolTip(Ability2_1, "Increases Health Restoration rate to " + muradinthirdone.ToString() + "\nper second, and raises Health threshold\nto 50% Health for improved " + muradinthirdtwo.ToString() + "\nper second Restoration.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Focused Attacks";
                toolTip1.SetToolTip(Ability2_1, "Every 10 seconds, your next Basic Attack deals\n75% additional damage. Basic Attacks reduce\nthis cooldown by 1 second.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Amplified Healing";
                toolTip1.SetToolTip(Ability2_1, "Increases regeneration effects and all healing\nreceived by 30%.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Amplified Healing";
                toolTip1.SetToolTip(Ability2_1, "Increases regeneration effects and all healing\nreceived by 30%.");
            }
        }

        //**ABILITY 2_2**//

        private void Ability2_2_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Flow Rider";
                toolTip1.SetToolTip(Ability2_2, "Lowers the cooldown of Barrel Roll by 40%.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Fel Reach";
                toolTip1.SetToolTip(Ability2_2, "Increases the range of Sweeping Strike by 20%.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Snowstorm";
                toolTip1.SetToolTip(Ability2_2, "Increases the radius of Blizzard by 30%.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Nether Wind";
                toolTip1.SetToolTip(Ability2_2, "Increases Gravity Lapse's range and speed by 30%.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Fury of the Swarm";
                toolTip1.SetToolTip(Ability2_2, "Basic Attacks splash for 50% damage around Kerrigan.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Remote Delivery";
                toolTip1.SetToolTip(Ability2_2, "Reduces the cooldown of Holo Decoy by 3\nseconds, and increases the range by 100%.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Vampiric Assault";
                toolTip1.SetToolTip(Ability2_2, "Basic Attacks heal for 15% of the damage dealt\nto the primary target.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Spirit Journey";
                toolTip1.SetToolTip(Ability2_2, "Feral Spirit travels 50% farther.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Vampiric Assault";
                toolTip1.SetToolTip(Ability2_2, "Basic Attacks heal for 15% of the damage dealt\nto the primary target.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Manticore";
                toolTip1.SetToolTip(Ability2_2, "Every 3 Basic Attacks against the same target\ndeals 50% additional damage.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Vampiric Assault";
                toolTip1.SetToolTip(Ability2_2, "Basic Attacks heal for 15% of the damage dealt\nto the primary target.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Superiority";
                toolTip1.SetToolTip(Ability2_2, "Reduce damage taken from Minions, Structures,\nand Mercenaries by 50%.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Destruction";
                toolTip1.SetToolTip(Ability2_2, "Damage boost of Frostmourne Hungers\nincreased to 150% damage.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Deadly Strike";
                toolTip1.SetToolTip(Ability2_2, "Increase the damage of Flying Kick by 50%.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Soul Catcher";
                toolTip1.SetToolTip(Ability2_2, "Black Soulstone passively generates a Soul \nvery 4 seconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Mic Check";
                toolTip1.SetToolTip(Ability2_2, "Hitting at least 3 targets with Face Melt reduces\nits cooldown by 4 seconds.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Roar";
                toolTip1.SetToolTip(Ability2_2, "Increases Punish damage by 50%.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Sledgehammer";
                toolTip1.SetToolTip(Ability2_2, "Deals 400% damage to Minions, Structures and \nercenaries. Destroys 4 ammo from Structures.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Shattered Ground";
                toolTip1.SetToolTip(Ability2_2, "Increases Seismic Slam splash damage to 75%\nof primary target damage.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Superiority";
                toolTip1.SetToolTip(Ability2_2, "Reduce damage taken from Minions, Structures,\nand Mercenaries by 50%.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Vampiric Assault";
                toolTip1.SetToolTip(Ability2_2, "Basic Attacks heal for 15% of the damage dealt\nto the primary target.");
            }
        }

        //**ABILITY 2_3**//

        private void Ability2_3_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Vampiric Assault";
                toolTip1.SetToolTip(Ability2_3, "Basic Attacks heal for 15% of the\ndamage dealt to the primary target.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Immolation";
                double illimm = 13 + (2.5 * trackBar1.Value);
                toolTip1.SetToolTip(Ability2_3, "After using Sweeping Strike, burn nearby enemies for " + illimm.ToString() + " damage a second for 4 seconds.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Arcane Intellect";
                toolTip1.SetToolTip(Ability2_3, "Dealing damage to a Chilled target returns Mana to Jaina.\nBasic Attacks return 5 Mana and abilities return 25.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Gathering Power";
                toolTip1.SetToolTip(Ability2_3, "Passively grants 5% Ability Power.\nEach Hero takedown increases this bonus by 2% to a maximum of 15%.\nThis bonus Ability Power is reset to 5% on death.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Clean Kill";
                toolTip1.SetToolTip(Ability2_3, "If Ravage kills the target, it also restores 100% of its Mana cost.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Gathering Power";
                toolTip1.SetToolTip(Ability2_3, "Passively grants 5% Ability Power.\nEach Hero takedown increases this bonus by 2% to a maximum of 15%.\nThis bonus Ability Power is reset to 5% on death.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Confident Aim";
                toolTip1.SetToolTip(Ability2_3, "Lowers the cooldown of Penetrating Round by 4\nseconds if it hits an enemy Hero.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Mana Tide";
                toolTip1.SetToolTip(Ability2_3, "Frostwolf Resilience also restores 15 Mana.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Spray 'n' Pray";
                toolTip1.SetToolTip(Ability2_3, "Overkill's range increased by 15%.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Puncturing Arrow";
                toolTip1.SetToolTip(Ability2_3, "Hungering Arrow range increased by 25% and\nthe number of times it can bounce to 3.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Gathering Power";
                toolTip1.SetToolTip(Ability2_3, "Passively grants 5% Ability Power. Each Hero\ntakedown increases this bonus by 2% to a\nmaximum of 15% . This bonus Ability Power is\nreset to 5% on death.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Locust Needles";
                toolTip1.SetToolTip(Ability2_3, "Basic Attacks deal 50% of your Basic Attack\nDamage in an area around the target.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Frozen Wastes";
                toolTip1.SetToolTip(Ability2_3, "Frozen Tempest Mana cost reduced by 3 per\n second.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Amplified Healing";
                toolTip1.SetToolTip(Ability2_3, "Increases regeneration effects and all healing received by 30%.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Essence of the Slain";
                toolTip1.SetToolTip(Ability2_3, "When enemy Minions die near you, gain 10\nMana.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Hammer-on";
                toolTip1.SetToolTip(Ability2_3, "Rockstar lasts 2 seconds longer, and while\nRockstar is active your Abilities cost 10 less\nMana.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Eternal Retaliation";
                toolTip1.SetToolTip(Ability2_3, "Condemn's cooldown is lowered by 0.75 seconds\nfor each enemy affected. Maximum of 10\ntargets.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Crowd Control";
                toolTip1.SetToolTip(Ability2_3, "Each enemy hit by Thunder Clap reduces its\ncooldown by 0.75 seconds.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Hurricane";
                toolTip1.SetToolTip(Ability2_3, "Casting Whirlwind removes all slows and roots.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Vile Cleaver";
                toolTip1.SetToolTip(Ability2_3, "Basic Attacks create a cloud of Vile Gas on the\ntarget.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Retribution";
                toolTip1.SetToolTip(Ability2_3, "Cooldown is lowered by 0.5 seconds for each\ntarget hit by Smite.");
            }
        }

        //**ABILITY 2_4**//

        private void Ability2_4_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Gathering Power";
                toolTip1.SetToolTip(Ability2_4, "Passively grants 5% Ability Power.\nEach Hero takedown increases this bonus by 2% to a maximum of 15%.\nThis bonus Ability Power is reset to 5% on death.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Thirsting Blade";
                toolTip1.SetToolTip(Ability2_4, "Healing from Basic Attacks increased to 30% of damage dealt.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Envenom";
                int jainavenom = 180 + (30 * trackBar1.Value);
                toolTip1.SetToolTip(Ability2_4, "Activate to poison an enemy Hero, dealing " + jainavenom.ToString() + " damage over 5 seconds.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Envenom";
                int kaelvenom = 180 + (30 * trackBar1.Value);
                toolTip1.SetToolTip(Ability2_4, "Activate to poison an enemy Hero, dealing " + kaelvenom.ToString() + " damage over 5 seconds.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Psionic Pulse";
                int kerpsi = 60 + (12 * trackBar1.Value);
                toolTip1.SetToolTip(Ability2_4, "After casting Primal Grasp, deal " + kerpsi.ToString() + " damage over 5 seconds to nearby enemies.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Envenom";
                int novavenom = 180 + (30 * trackBar1.Value);
                toolTip1.SetToolTip(Ability2_4, "Activate to poison an enemy Hero, dealing " + novavenom.ToString() + " damage over 5 seconds.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Activated Rush";
                toolTip1.SetToolTip(Ability2_4, "Lowers the cooldown of Adrenaline Rush by 10\nseconds, and it can now be manually activated.");
            }

            if (lblHero.Text == "Thrall")
            {
                int thrallvenom = 180 + (30 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Envenom";
                toolTip1.SetToolTip(Ability2_4, "Activate to poison an enemy Hero, dealing\n" + thrallvenom.ToString() + " damage over 5 seconds.");
            }

            if (lblHero.Text == "Tychus")
            {
                int tychusmelt = 120 + (50 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Melting Point";
                toolTip1.SetToolTip(Ability2_4, "Frag Grenade deals an additional " + tychusmelt.ToString() + "\ndamage over 10 seconds to Minions and Structures.");
            }

            if (lblHero.Text == "Valla")
            {
                double vallaarsenal = 35 + (7.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Arsenal";
                toolTip1.SetToolTip(Ability2_4, "Multishot also fires 3 grenades, which deal " + vallaarsenal.ToString() + " damage.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Sustained Anomaly";
                toolTip1.SetToolTip(Ability2_4, "The Singularity Spike explodes for area damage\nand slows, regardless if it hits a target or not.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Legion of Beetles";
                toolTip1.SetToolTip(Ability2_4, "Anub'arak automatically spawns Beetles every 8\nseconds. Can be toggled on and off.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Deep Breath";
                toolTip1.SetToolTip(Ability2_4, "Range and arc of Breath of Fire increased by 30%.");
            }

            if (lblHero.Text == "Diablo")
            {
                int diablodevil = 10 + (2 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Fire Devil";
                toolTip1.SetToolTip(Ability2_4, "Fire Stomp also surrounds you in flames that\ndeal " + diablodevil.ToString() + " damage every second for 6 seconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Pinball Wizard";
                toolTip1.SetToolTip(Ability2_4, "Face Melt does 50% more damage to enemies\nrecently affected by Powerslide.");
            }

            if (lblHero.Text == "Johanna")
            {
                int johannahope = 1 + (1 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Laws of Hope";
                toolTip1.SetToolTip(Ability2_4, "Regenerate " + johannahope.ToString() + " Health per second.\n\nActivate to heal 20% of your max Health over 4\nseconds.");
            }

            if (lblHero.Text == "Muradin")
            {
                int muradinburn = 25 + (4 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Thunder Burn";
                toolTip1.SetToolTip(Ability2_4, "Thunder Clap leaves a zone on the ground that\nexplodes after 2 seconds dealing " + muradinburn.ToString() + "\ndamage and applying a 25% slow for 2.5\nseconds.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Superiority";
                toolTip1.SetToolTip(Ability2_4, "Reduce damage taken from Minions, Structures,\nand Mercenaries by 50%.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Putrid Ground";
                toolTip1.SetToolTip(Ability2_4, "Enemies hit by Slam are infected with Vile Gas.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Even in Death";
                toolTip1.SetToolTip(Ability2_4, "Non-Heroic abilities can be used before\nexploding, but deal no damage.");
            }

        }

        //**ABILITY 2_5**//

        private void Ability2_5_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Envenom";
                int kerrvenom = 180 + (30 * trackBar1.Value);
                toolTip1.SetToolTip(Ability2_5, "Activate to poison an enemy Hero, dealing " + kerrvenom.ToString() + " damage over 5 seconds.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Vorpal Blade";
                toolTip1.SetToolTip(Ability2_5, "Activate to teleport to the last non-structure\ntarget you attacked within 3 seconds. 15 second\ncooldown.");
            }
        }

        //**ABILITY 3_1**//

        private void Ability3_1_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Battle Momentum";
                toolTip1.SetToolTip(Ability3_1, "Basic Attacks reduce Ability cooldowns by 0.5 seconds.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Rapid Chase";
                toolTip1.SetToolTip(Ability3_1, "Gain 20% Movement Speed for 2 seconds after using Dive.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Ice Floes";
                toolTip1.SetToolTip(Ability3_1, "Doubles the width of Cone of Cold and causes\neach target hit to reduce its cooldown by 0.5 seconds.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Fission Bomb";
                toolTip1.SetToolTip(Ability3_1, "Increases Living Bomb's explosion damage by 75%.");
            }


            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Battle Momentum";
                toolTip1.SetToolTip(Ability3_1, "Basic Attacks reduce Ability cooldowns by 0.5 seconds.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Explosive Round";
                toolTip1.SetToolTip(Ability3_1, "Snipe also deals 50% damage to enemies near\nthe impact.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Hamstring Shot";
                toolTip1.SetToolTip(Ability3_1, "Enemies hit by Penetrating Round have a 20%\nMovement Speed slow for 3 seconds.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Wind Shear";
                toolTip1.SetToolTip(Ability3_1, "Reduces the cooldown of Windfury by 4 seconds.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Quarterback";
                toolTip1.SetToolTip(Ability3_1, "Increases the range of Frag Grenade by 50%.");
            }

            if (lblHero.Text == "Valla")
            {
                int vallatrops = 25 + (2 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Caltrops";
                toolTip1.SetToolTip(Ability3_1, "Drop 3 Caltrops while Vaulting, Caltrops do " + vallatrops.ToString() + "\ndamage and slow enemies by 20%\nfor 2 seconds.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Follow Through";
                toolTip1.SetToolTip(Ability3_1, "After using an ability, your next Basic Attack\nwithin 6 seconds deals 40% additional damage.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Shed Exoskeleton";
                toolTip1.SetToolTip(Ability3_1, "Using Harden Carapace also increases Anub'arak's\nMovement Speed by 25% for 3 seconds.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Rune Tap";
                toolTip1.SetToolTip(Ability3_1, "Every 3rd Basic Attack heals you for 3.12%\nof your max Health.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Keg Toss";
                toolTip1.SetToolTip(Ability3_1, "Increase Keg Smash range by 125%.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Battle Momentum";
                toolTip1.SetToolTip(Ability3_1, "Basic Attacks reduce Ability cooldowns by 0.5\nseconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Loud Speakers";
                toolTip1.SetToolTip(Ability3_1, "Increases Face Melt range and knockback by\n50%.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Battle Momentum";
                toolTip1.SetToolTip(Ability3_1, "Basic Attacks reduce Ability cooldowns by 0.5\nseconds.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Piercing Bolt";
                toolTip1.SetToolTip(Ability3_1, "Penetrates through the first target hit, hitting 1\nadditional target.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Poisoned Spear";
                toolTip1.SetToolTip(Ability3_1, "Ancient Spear deals an additional 75% damage\nover 4 seconds.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Tenderizer";
                toolTip1.SetToolTip(Ability3_1, "Basic Attacks slow enemy Movement Speed by\n25% for 1.5 seconds.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Battle Momentum";
                toolTip1.SetToolTip(Ability3_1, "Basic Attacks reduce Ability cooldowns by 0.5\nseconds.");
            }
        }

        //**ABILITY 3_2**//

        private void Ability3_2_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Secret Weapon";
                toolTip1.SetToolTip(Ability3_2, "Basic Attacks deal 80% bonus damage while Hammerang is in flight.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Reflexive Block";
                toolTip1.SetToolTip(Ability3_2, "Gain 2 charges of Block (50% reduced Basic Attack damage) after Evasion wears off.\nLasts 5 seconds.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Frostbitten";
                toolTip1.SetToolTip(Ability3_2, "Increases the damage bonus of Frostbite from 50% to 65%.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Sunfire Enchantment";
                int kaelsunfire = 78 + (16 * trackBar1.Value);
                toolTip1.SetToolTip(Ability3_2, "Activating Verdant Spheres causes your next\nBasic Attack to instead shoot a spell dealing\n" + kaelsunfire.ToString() +  " damage.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Impaling Swarm";
                toolTip1.SetToolTip(Ability3_2, "Impaling Blades spawns 2 Zerglings at the target location.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "One in the Chamber";
                toolTip1.SetToolTip(Ability3_2, "After using an ability, your next Basic Attack\ndeals 80% additional damage.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Revolution Overdrive";
                toolTip1.SetToolTip(Ability3_2, "Gain 10% Movement Speed while affected by\nInspire. Increase this bonus by 5% for each\nallied Hero nearby when Inspire is cast.");
            }


            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Stone Wolves";
                toolTip1.SetToolTip(Ability3_2, "Increases the duration of Feral Spirit's root from\n1 second to 1.5 seconds.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Rapid Fire";
                toolTip1.SetToolTip(Ability3_2, "Minigun now stacks 2 additional times, further\nincreasing your Attack Speed.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Hot Pursuit";
                toolTip1.SetToolTip(Ability3_2, "When at 10 stacks of Hatred, the Movement\nSpeed bonus increases to 20% total.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Void Slash";
                toolTip1.SetToolTip(Ability3_2, "Cleave deals 30% increased damage if used while Cloaked.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                int anubspines = 50 + (9 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Untricating Spines";
                toolTip1.SetToolTip(Ability3_2, "Casting Harden Carapace will also deal " + anubspines.ToString() + "\ndamage to nearby enemies");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Obliterate";
                toolTip1.SetToolTip(Ability3_2, "Frostmourne Hungers also hits enemies near\nthe target for 50% damage.");
            }

            if (lblHero.Text == "Chen")
            {
                double chenring = 10 + (2.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Ring of Fire";
                toolTip1.SetToolTip(Ability3_2, "After using Breath of Fire, ignite in a fiery aura, dealing  " + chenring.ToString() + "\ndamage every second to nearby enemies for 5 seconds.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "From the Shadows";
                toolTip1.SetToolTip(Ability3_2, "Increases the duration that Shadow Charge\nstuns enemies that collide with terrain to 1.25\nseconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Guitar Hero";
                toolTip1.SetToolTip(Ability3_2, "While Guitar Solo is active, you heal for 50% of\nthe damage dealt by Basic Attacks.");
            }

            if (lblHero.Text == "Johanna")
            {
                int johannasins = 30 + (6 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Sins Exposed";
                toolTip1.SetToolTip(Ability3_2, "Shield Glare marks enemies for 4 seconds. The\nnext time any ally damages them, they take\n" + johannasins.ToString() + " extra damage and the mark is\nremoved.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Landing Momentum";
                toolTip1.SetToolTip(Ability3_2, "Increases your Movement Speed by 20% for 4\nseconds upon landing with Dwarf Toss.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Composite Spear]";
                toolTip1.SetToolTip(Ability3_2, "Increases the range of Ancient Spear by 30%.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Toxic Gas";
                toolTip1.SetToolTip(Ability3_2, "Increases Vile Gas radius by 50% and the duration of the\neffect by 1 second.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Angel's Grace";
                toolTip1.SetToolTip(Ability3_2, "After teleporting using El'Druin's Might, gain\n25% Movement Speed for 3 seconds.");
            }
        }

        //**ABILITY 3_3**//

        private void Ability3_3_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "BOOMerang";
                int falboom = 25 + (12 * trackBar1.Value);
                toolTip1.SetToolTip(Ability3_3, "Reactivate Hammerang mid-flight to deal " + falboom.ToString() + " damage around the Hammer.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Follow Through";
                toolTip1.SetToolTip(Ability3_3, "After using an ability, your next Basic Attack within 6 seconds deals 40% additional damage.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Frost Armor";
                toolTip1.SetToolTip(Ability3_3, "Enemy Heroes that attack you are Chilled.\nAdditionally, every 8 seconds you can block the\nnext Basic Attack from an enemy Hero reducing\nits damage by 24%.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Tri-Optimal";
                toolTip1.SetToolTip(Ability3_3, "Reduces Verdant Spheres' cooldown by 2\nseconds per target hit with Gravity Lapse.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Adapation";
                toolTip1.SetToolTip(Ability3_3, "Ravage can be used to jump to allies for half the cooldown.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Anti-Armor Shells";
                toolTip1.SetToolTip(Ability3_3, "Your Basic Attacks deal 250% damage, but your\nAttack Speed is proportionally slower.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Fight or Flight";
                toolTip1.SetToolTip(Ability3_3, "When Adrenaline Rush activates it removes all\nstuns, roots, silences, and slows.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Follow Through";
                toolTip1.SetToolTip(Ability3_3, "After using an ability, your next Basic Attack\nwithin 6 seconds deals 40% additional damage.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "First Aid";
                toolTip1.SetToolTip(Ability3_3, "Activate to heal 35.49% of your max Health\nover 6 seconds.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Repeating Arrow";
                toolTip1.SetToolTip(Ability3_3, "The cooldown for Hungering Arrow is reset when\nVault is used.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Shadow Spike";
                toolTip1.SetToolTip(Ability3_3, "No longer decloak when using Singularity Spike.\nRange increased by 20%.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                int anubbarbs = 18 + (2 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Bed of Barbs";
                toolTip1.SetToolTip(Ability3_3, "Create a bed of spikes along Impale's path that\nslows enemy Move Speed by 30% and deals " + anubbarbs.ToString() + "\ndamage per second. Spikes persist\nfor 3.5 seconds");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Frost Strike";
                toolTip1.SetToolTip(Ability3_3, "Frostmourne Hungers also slows the target by\n40% for 1.5 seconds.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Combat Stance";
                toolTip1.SetToolTip(Ability3_3, "Shields from Fortifying Brew last for an additional 2 seconds after\ndrinking stops");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Devastating Charge";
                toolTip1.SetToolTip(Ability3_3, "Shadow Charge reduces the duration of silences,\nstuns, slows, roots, and polymorphs against you\nby 50% for 3 seconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Just Keep Rockin'";
                toolTip1.SetToolTip(Ability3_3, "While Guitar Solo is active, the duration of\nsilences, stuns, slows, roots, and polymorphs are\nreduced by 50%");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "The Crusade Marches On";
                toolTip1.SetToolTip(Ability3_3, "Basic and Heroic Abilities lower the cooldown of\nIron Skin by 1.5 seconds.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Skullcracker";
                toolTip1.SetToolTip(Ability3_3, "Every 3 Basic Attacks against the same target\nwill stun them for 0.25 seconds.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Follow Through";
                toolTip1.SetToolTip(Ability3_3, "After using an ability, your next Basic Attack\nwithin 6 seconds deals 40% additional damage.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Last Bite";
                toolTip1.SetToolTip(Ability3_3, "If Devour kills an enemy, the cooldown is\nreduced by 15 seconds.");
            }

            if (lblHero.Text == "Tyrael")
            {
                int tyraelrecip = 90 + (12 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Reciprocate";
                toolTip1.SetToolTip(Ability3_3, "When your shield expires, it explodes for " + tyraelrecip.ToString() + "\ndamage to nearby enemies.");
            }
        }

        //**ABILITY 3_4**//

        private void Ability3_4_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Free Roll";
                toolTip1.SetToolTip(Ability3_4, "Barrel Roll costs no mana.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Thrill of Battle";
                toolTip1.SetToolTip(Ability3_4, "Activate to double the cooldown reduction from Basic Attacks for 8 seconds.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Ice Lance";
                toolTip1.SetToolTip(Ability3_4, "The cooldown of Frostbolt is reduced by 2 seconds if it impacts a Chilled target.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Clairvoyance";
                toolTip1.SetToolTip(Ability3_4, "Activate to reveal an area for 10 seconds.\nEnemies in the area are revealed for 4 seconds.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Searing Attacks";
                toolTip1.SetToolTip(Ability3_4, "Activate to increase Basic Attack damage by 50% for 5 seconds.\nEach attack costs 15 Mana.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Covert Ops";
                toolTip1.SetToolTip(Ability3_4, "Increases the Movement Speed slow of Pinning\nShot by 1% for every second that Nova is\nCloaked, to a maximum of a 50% slow. Bonus\nfades when Nova is un-Cloaked for one second.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Mercenary Lord";
                toolTip1.SetToolTip(Ability3_4, "Siege and Bruiser Mercenaries near your hero\ndeal 50% more damage.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Frostwolf's Grace";
                toolTip1.SetToolTip(Ability3_4, "Frostwolf Resilience can be activated to\nimmediately heal Thrall.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Sizzlin' Attacks";
                toolTip1.SetToolTip(Ability3_4, "Activate to increase Basic Attack damage by\n50% for 5 seconds. Each attack costs 5 Mana.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Searing Attacks";
                toolTip1.SetToolTip(Ability3_4, "Activate to increase Basic Attack damage by\n50% for 5 seconds. Each attack costs 15 Mana.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "First Aid";
                toolTip1.SetToolTip(Ability3_4, "Activate to heal 35.49% of your max Health\nover 6 seconds.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Leeching Scarabs";
                toolTip1.SetToolTip(Ability3_4, "Beetles heal Anub'arak for 50% of their damage\nwith each attack if he is nearby.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Death Touch";
                toolTip1.SetToolTip(Ability3_4, "Death Coil causes enemy Minions to explode,\nkilling the target instantly and dealing its normal\ndamage to other nearby enemies.");
            }

            if (lblHero.Text == "Chen")
            {
                double chenbalance = 10 + (1.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Brewmaster's Balance";
                toolTip1.SetToolTip(Ability3_4, "While at or below 50 Brew, gain 20% Movement Speed. While at or\nabove 50 Brew, regenerate an additional " + chenbalance.ToString() + " Health per\nsecond.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Soul Steal";
                toolTip1.SetToolTip(Ability3_4, "Increases the amount of Health gained from\nBlack Soulstone by 66%.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Follow Through";
                toolTip1.SetToolTip(Ability3_4, "After using an ability, your next Basic Attack\nwithin 6 seconds deals 40% additional damage.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Battle Momentum";
                toolTip1.SetToolTip(Ability3_4, "Basic Attacks reduce Ability cooldowns by 0.5\nseconds.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Ferocious Healing";
                toolTip1.SetToolTip(Ability3_4, "Consume 20 Fury to heal 10.15% of your\nmaximum Health.\n\nUsable while Whirlwinding.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Savor the Flavor";
                toolTip1.SetToolTip(Ability3_4, "Using Devour on an enemy Hero grants a permanent +2 Health\nper second.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Zealotry";
                toolTip1.SetToolTip(Ability3_4, "Increases shield duration by 100%.");
            }
        }

        //**ABILITY 3_5**//

        private void Ability3_5_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "First Aid";
                toolTip1.SetToolTip(Ability3_5, "Activate to heal 35.49% of your max Health over 6 seconds.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "First Aid";
                toolTip1.SetToolTip(Ability3_5, "Activate to heal 35.49% of your max Health over 6 seconds.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Searing Attacks";
                toolTip1.SetToolTip(Ability3_5, "Activate to increase Basic Attack damage by\n50% for 5 seconds. Each attack costs 15 Mana.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Mercenary Lord";
                toolTip1.SetToolTip(Ability3_5, "Siege and Bruiser Mercenaries near your hero\ndeal 50% more damage.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Conviction";
                toolTip1.SetToolTip(Ability3_4, "Condemn increases your Movement Speed by\n25% for 1 second.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Searing Attacks";
                toolTip1.SetToolTip(Ability3_5, "Activate to increase Basic Attack damage by\n50% for 5 seconds. Each attack costs 15 Mana.");
            }
        }

        //**ABILITY 4_1**//

        private void Ability4_1_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Mighty Gust";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 70\nCooldown: 50 seconds\n\nPush enemies away and apply an 60% slow that decays over 3 seconds.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Metamorphosis";
                int illmetaone = 200 + (10 * trackBar1.Value);
                int illmetatwo = 100 + (15 * trackBar1.Value);
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nCooldown: 120 seconds\n\nTransform into Demon Form at the target location, dealing " + illmetaone.ToString() + " damage in the area.\nGain " + illmetatwo.ToString() + " temporary max Health for each Hero hit and 20% increased Attack Speed.\nLasts for 18 seconds.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Ring of Frost";
                int jainaring = 200 + (24 * trackBar1.Value);
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 70\nCooldown: 100 seconds\n\nAfter a 1.5 second delay, create a Ring of Frost in an area\nthat deals " + jainaring.ToString() + " damage and roots enemies for 3 seconds.\n\nThe ring persists for 3 seconds afterward, Chilling any enemies who touch it.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Phoenix";
                int kaelphoenix = 10 + (8 * trackBar1.Value);
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 80\nCooldown: 40 seconds\n\nLaunch a Phoenix to an area, dealing " + kaelphoenix.ToString() + " damage to enemies along the way.\nThe Phoenix persists for 7 seconds, attacking enemies for " + kaelphoenix.ToString() + " damage and splashing for 50%.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Maelstrom";
                int kermael = 50 + (5 * trackBar1.Value);
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 100\nCooldown: 120 seconds\n\nDeals " + kermael.ToString() + " damage per second to nearby enemies. Lasts for 9 seconds.");
            }

            if (lblHero.Text == "Nova")
            {
                int novatriple = 80 + (33 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Triple Tap";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nLocks in on the target Hero, then fires 3 shots that hit the first Hero or\nStructure they come in contact with for " + novatriple.ToString() + " damage each.");
            }

            if (lblHero.Text == "Raynor")
            {
                int raynorhyperionone = 25 + (6 * trackBar1.Value);
                int raynorhyperiontwo = 300 + (72 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Hyperion";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nOrder the Hyperion to make a strafing run dealing " + raynorhyperionone.ToString() + "\n hitting up to 4 enemies. Also occasionally fires its Yamato Cannon\non Structures for " + raynorhyperiontwo.ToString() + " damage. Lasts 12 seconds.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Earthquake";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 90\nCooldown: 60 seconds\n\nSummon a massive Earthquake that periodically slows enemies in the area by 70%.\nLasts for 10 seconds.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Commandeer Odin";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nCall down an Odin to pilot. The Odin deals increased Damage, has 100% increased Basic Attack range,\nand uses different Abilities. Lasts 23 seconds.");
            }

            if (lblHero.Text == "Valla")
            {
                double vallastrafe = 15 + (6.75 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Strafe";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 80\nCooldown: 60 seconds\n\nRapidly attack nearby visible enemies for " + vallastrafe.ToString() + " damage per hit, prioritizing heroes over\nminions. Valla is able to move and use Vault while strafing. Lasts for 4 seconds.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Shadow Assault";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nYour Basic Attacks cause you to charge at enemies and have 20% increased Attack Speed. Lasts for 6\nseconds.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Web Blast";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 70\nCooldown: 60 seconds\n\nWraps target enemy Hero in a cocoon for 8 seconds. Enemies wrapped in the cocoon are unable to act\nand untargetable. Allies of the Hero can attack the cocoon to break it and free them early.");
            }

            if (lblHero.Text == "Arthas")
            {
                int arthasarmy = 104 + (24 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Army of the Dead";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nSummons Ghouls that last 15 seconds. Sacrifice Ghouls to heal for " + arthasarmy.ToString() + " Health.");
            }

            if (lblHero.Text == "Chen")
            {
                int chenbarrel = 30 + (5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Wandering Keg";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nBrew: 30\nCooldown: 90 seconds\n\nRoll around inside the barrel, dealing " + chenbarrel.ToString() + " damage to enemies in the way and knocking\nthem back. Lasts for 5 seconds.");
            }

            if (lblHero.Text == "Diablo")
            {
                int diabloapoc = 100 + (10 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Apocalypse";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nCooldown: 100 seconds\n\nCreate a demonic rune under each enemy Hero on the battleground. After 1.75 seconds the rune\nexplodes dealing " + diabloapoc.ToString() + " damage and stunning for 2 seconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Mosh Pit";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 100\nCooldown: 120 seconds\n\nAfter 0.75 seconds, channel to stun nearby enemies for 4 seconds.");
            }

            if (lblHero.Text == "Johanna")
            {
                double johannafalling = 120 + (21.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Falling Sword";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 100\nCooldown: 80 seconds\n\nYou leap towards an area. While in the air, you can steer the landing location by moving.\n\nAfter 2 seconds you land, dealing " + johannafalling.ToString() + " damage to nearby enemies and knocking them\ninto the air.");
            }

            if (lblHero.Text == "Muradin")
            {
                int muradinavatar = 320 + (96 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Avatar";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nTransform for 20 seconds, gaining " + muradinavatar.ToString() + " Health and causing your Basic Attacks to stun\nenemies.");
            }

            if (lblHero.Text == "Sonya")
            {
                int sonyaleap = 50 + (11 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Leap";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nCooldown: 70 seconds\n\nLeap into the air, dealing " + sonyaleap.ToString() + " damage to nearby enemies, and stunning them for 1.5\nseconds.");
            }

            if (lblHero.Text == "Stitches")
            {
                int stitchesbile = 20 + (3 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Putrid Bile";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 75\nCooldown: 60 seconds\n\nEmit bile that deals " + stitchesbile.ToString() + " damage per second to enemies within, slowing them by 35%. You\ngain 20% Movement Speed while emitting bile. Lasts 8 seconds.");
            }

            if (lblHero.Text == "Tyrael")
            {
                int tyraeljudgeone = 60 + (8 * trackBar1.Value);
                int tyraeljudgetwo = 30 + (4 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Judgment";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nCooldown: 80 seconds\n\nCharge the target, dealing " + tyraeljudgeone.ToString() + " damage and stunning them for 1.5 seconds. Nearby\nenemies are knocked away and take " + tyraeljudgetwo.ToString() + " damage.");
            }
        }

        //**ABILITY 4_2**//

        private void Ability4_2_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Hinterland Blast";
                int falhinter = 280 + (31 * trackBar1.Value);
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 100\nCooldown: 90 seconds\n\nAfter a short delay, deal " + falhinter.ToString() + " damage to enemies within a long line.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "The Hunt";
                int illhunt = 150 + (20 * trackBar1.Value);
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nCooldown: 60 seconds\nCharge to target unit, dealing " + illhunt.ToString() + " damage on impact and stunning for 1 second.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Summon Water Elemental";
                int jainawater1 = 65 + (7 * trackBar1.Value);
                int jainawater2 = 50 + (6 * trackBar1.Value);
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 75\nCooldown: 80 seconds\n\nSummons a Water Elemental at target location, dealing " + jainawater1.ToString() + " damage and Chilling nearby enemies.\nThe Water Elemental's Basic Attacks do " + jainawater2.ToString() + " damage, splash for 25% damage and Chill.\nCan reactivate the Ability to retarget the Water Elemental.\nLasts 20 seconds.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Pyroblast";
                int kaelpyroone = 300 + (65 * trackBar1.Value);
                double kaelpyrotwo = 150 + (32.5 * trackBar1.Value);
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 80\nCooldown: 50 seconds\n\nAfter 2 seconds, cast a slow-moving fireball that deals " + kaelpyroone.ToString() + " damage\nto an enemy Hero and " + kaelpyrotwo.ToString() + " damage to enemies nearby.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Summon Ultralisk";
                int kerultra = 40 + (8 * trackBar1.Value);
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 100\nCooldown: 80 seconds\n\nSummon an Ultralisk that attacks the target to deal " + kerultra.ToString() + " damage.\nAttacks splash to nearby enemies for 50% damage.\nCan reactivate the Ability to retarget the Ultralisk.\nLasts for 20 seconds.");
            }

            if (lblHero.Text == "Nova")
            {
                int novastrike = 300 + (35 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Precision Strike";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 100\nCharge Cooldown: 60 seconds\n\nAfter a 1.5 second delay, deals " + novastrike.ToString() + " damage to enemies within an area.\n\nUnlimited range.");
            }

            if (lblHero.Text == "Raynor")
            {
                int raynorraider = 16 + (4 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Raynor’s Raiders";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 100\nCooldown: 80 seconds\n\nSummon two Stealthed Banshees that attack an enemy. Each Banshee\ndeals “ + raynorraiders.ToString + “ damage a second and lasts 22 seconds. Can reactivate\nthe Ability to retarget the Banshees.");
            }

            if (lblHero.Text == "Thrall")
            {
                int thrallsunder = 160 + (22 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Sundering";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 75\nCooldown: 70 seconds\n\nAfter a short delay, sunder the earth in a long line, dealing " + thrallsunder.ToString() + " damage and shoving\nenemies to the side, stunning them for 1.5 seconds.");
            }

            if (lblHero.Text == "Tychus")
            {
                int tychusdrill = 30 + (14 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Drakken Laser Drill";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nCall down a Laser Drill to attack nearby enemies,\ndealing " + tychusdrill.ToString() + " damage every second. Reactivate to assign a new target.\nLasts 22 seconds.");
            }

            if (lblHero.Text == "Valla")
            {
                int vallarain = 100 + (23 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Rain of Vengeance";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 100\nCooldown: 90 seconds\n\nLaunch 2 waves of Shadow Beasts that deal " + vallarain.ToString() + " damage to enemies within the target\narea, stunning for 0.5 seconds per wave.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Void Prison";
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nSlows time in an area to a near standstill, making allies and enemies invulnerable and unable to act for\n5 seconds. You are not affected.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                int anublocustone = 20 + (8 * trackBar1.Value);
                double anublocusttwo = 10 + (1.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Locust Swarm";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 100\nCooldown: 100 seconds\n\nDeals " + anublocustone.ToString() + " damage per second in an area around Anub'arak. Each enemy damaged heals\nAnub'arak for " + anublocusttwo.ToString() + " health.");
            }

            if (lblHero.Text == "Arthas")
            {
                int arthassin = 150 + (15 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Summon Sindragosa";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 100\nCooldown: 80 seconds\n\nDeals " + arthassin.ToString() + " damage and slows enemies by 60% for 2 seconds. Also disables Minions for 10\nseconds and Structures for 20 seconds.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Storm, Earth, Fire";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nBrew: 10 \nCooldown: 100 seconds\n\nSplit into three elemental spirits for 15.15 seconds, each with 50% of your maximum Health, and\nenables two new leaping attacks for use.");
            }

            if (lblHero.Text == "Diablo")
            {
                int diablobreath = 320 + (72 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Lightning Breath";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 80\nCooldown: 60 seconds\n\nBecome Unstoppable while channeling lightning that deals " + diablobreath.ToString() + " damage over 4 seconds.\nThe direction of the Lightning changes with your mouse cursor position.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                int etcdive = 100 + (12 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Stage Dive";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 100\nCooldown: 75 seconds\n\nLeap to any location. Deals " + etcdive.ToString() + " damage to enemies in the area, slowing them for 3\nseconds.");
            }

            if (lblHero.Text == "Johanna")
            {
                int johannablessedone = 70 + (9 * trackBar1.Value);
                double johannablessedtwo = 35 + (4.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Blessed Shield";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 90 seconds\nCooldown: 60 seconds\n\nDeal " + johannablessedone.ToString() + " damage and stun the first enemy hit for 2 seconds. Blessed Shield then bounces\nto 2 nearby enemies, dealing " + johannablessedtwo.ToString() + " damage and stunning them for 1 second.");
            }

            if (lblHero.Text == "Muradin")
            {
                int muradinhaymakerone = 300 + (20 * trackBar1.Value);
                int muradinhaymakertwo = 75 + (5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Haymaker";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 80\nCharge Cooldown: 40 seconds\n\nStun target enemy Hero, and wind up a punch dealing " + muradinhaymakerone.ToString() + " damage and knocking the\ntarget back, hitting enemies in the way for " + muradinhaymakertwo.ToString() + " damage and knocking them aside.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Wrath of the Berserker";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nCooldown: 45 seconds\n\nGain 40% Bonus Damage on all Basic Attacks and Abilities. Stuns, slows, silences, polymorphs and roots\nagainst you have 50% reduced duration. Lasts 15 seconds, and extends by 1 second for every 10 Fury\ngained while active.");
            }

            if (lblHero.Text == "Stitches")
            {
                int stitchesgorge = 100 + (25 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Gorge";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 80\nCooldown: 80 seconds\n\nConsume an enemy Hero, trapping them for 3.5 seconds. When Gorge ends, the enemy Hero takes " + stitchesgorge.ToString() + "\ndamage. The trapped Hero cannot move or act and doesn't take damage from other\nsources. Stitches' Movement Speed is reduced by 15% while an enemy is Gorged.\n\nCannot be used on Massive Heroes.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Sanctification";
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 75\nCooldown: 50 seconds\n\nWhile channeling, Tyrael makes all nearby allied Heroes invulnerable and unstoppable. Lasts 3 seconds.\n\nDoes not affect Tyrael.");
            }
        }

        //**ABILITY 5_1**//

        private void Ability5_1_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Giant Killer";
                toolTip1.SetToolTip(Ability5_1, "Basic Attacks against enemy Heroes deal bonus damage\nequal to 1.5% of the Hero's maximum Health.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Giant Killer";
                toolTip1.SetToolTip(Ability5_1, "Basic Attacks against enemy Heroes deal bonus damage\nequal to 1.5% of the Hero's maximum Health.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Storm Front";
                toolTip1.SetToolTip(Ability5_1, "Increases the cast range of Blizzard by 100%.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Flamethrower";
                toolTip1.SetToolTip(Ability5_1, "Increases the cast range of Flamestrike by 50%.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Lingering Essence";
                toolTip1.SetToolTip(Ability5_1, "Assimilation Shield duration increased to 12 seconds.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Lethal Decoy";
                toolTip1.SetToolTip(Ability5_1, "Holo Decoy now deals 25% of Nova's damage.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Giant Killer";
                toolTip1.SetToolTip(Ability5_1, "Basic Attacks against enemy Heroes deal bonus\ndamage equal to 1.5% of the Hero's maximum Health.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Restless Wolves";
                toolTip1.SetToolTip(Ability5_1, "If Feral Spirit hits an enemy Hero, its cooldown\nis reduced by 50% .");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Problem Solver";
                toolTip1.SetToolTip(Ability5_1, "Basic Attacks against enemy Heroes deal bonus\ndamage equal to 0.5% of the Hero's maximum\nHealth.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Giant Killer";
                toolTip1.SetToolTip(Ability5_1, "Basic Attacks against enemy Heroes deal bonus\ndamage equal to 1.5% of the Hero's maximum\nHealth.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Giant Killer";
                toolTip1.SetToolTip(Ability5_1, "Basic Attacks against enemy Heroes deal bonus\ndamage equal to 1.5% of the Hero's maximum\nHealth.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                int anubrage = 10 + (2 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Burning Rage";
                toolTip1.SetToolTip(Ability5_1, "Deal " + anubrage.ToString() + " damage per second to\nearby enemies");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Spell Shield";
                toolTip1.SetToolTip(Ability5_1, "Upon taking Ability Damage, reduce that\ndamage and further Ability Damage by 50% for\n2 seconds. Can only trigger once every 30\nseconds.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Brew Strike";
                toolTip1.SetToolTip(Ability5_1, "Hitting a Brew-soaked target with Flying Kick reduces the cooldown by 1\nsecond and restores 10 Brew.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Siphon of the Dead";
                toolTip1.SetToolTip(Ability5_1, "Activate to heal 15% of your maximum Health\nover 3 seconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                int etcgroupies = 24 + (6 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Groupies";
                toolTip1.SetToolTip(Ability5_1, "Guitar Solo also heals nearby allied Heroes for " + etcgroupies.ToString() + "\nHealth every second while it is active.");
            }

            if (lblHero.Text == "Johanna")
            {
                int johannarage = 10 + (2 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Burning Rage";
                toolTip1.SetToolTip(Ability5_1, "Deal " + johannarage.ToString() + " damage per second to\nnearby enemies.");
            }

            if (lblHero.Text == "Muradin")
            {
                int muradinrage = 10 + (2 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Burning Rage";
                toolTip1.SetToolTip(Ability5_1, "Deal " + muradinrage.ToString() + " damage per second to\n nearby enemies.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Life Funnel";
                toolTip1.SetToolTip(Ability5_1, "Using Whirlwind removes all movement\nimpairing effects and increases the amount\nhealed to 35%.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Relentless";
                toolTip1.SetToolTip(Ability5_1, "Reduces the duration of silences, stuns, slows,\nroots, and polymorphs against your Hero by\n50%.");
            }

            if (lblHero.Text == "Tyrael")
            {
                int tyraelrage = 10 + (2 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Burning Rage";
                toolTip1.SetToolTip(Ability5_1, "Deal " + tyraelrage.ToString() + " damage per second to\nnearby enemies.");
            }
        }

        //**ABILITY 5_2**//

        private void Ability5_2_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Crippling Hammer";
                toolTip1.SetToolTip(Ability5_2, "Increases the Movement Speed Slow of Hammerang to 50%.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Lunge";
                toolTip1.SetToolTip(Ability5_2, "Increases the range of Dive by 30%.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Improved Ice Block";
                toolTip1.SetToolTip(Ability5_2, "Activate to place yourself in Stasis and gain\nInvulnerability for 3 seconds. When this effect\nexpires, nearby enemies are Chilled.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Chain Bomb";
                toolTip1.SetToolTip(Ability5_2, "Living Bomb's explosion applies Living Bomb to enemies.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Eviscerate";
                toolTip1.SetToolTip(Ability5_2, "Increases the range of Ravage by 25%.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Advanced Cloaking";
                toolTip1.SetToolTip(Ability5_2, "While Stealthed from Permanent Cloak, your\nMovement Speed is increased by 25% and you\nheal for 1.95% of your maximum Health per second.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Double-Barreled";
                toolTip1.SetToolTip(Ability5_2, "Penetrating Round gains a second charge.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Grace of Air";
                toolTip1.SetToolTip(Ability5_2, "Windfury attacks grant twice as many stacks of\nFrostwolf Resilience.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Lead Rain";
                toolTip1.SetToolTip(Ability5_2, "Overkill applies a stacking slow, up to 20%.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Frost Shot";
                toolTip1.SetToolTip(Ability5_2, "Multishot also slows by 40% for 2 seconds.");
            }

            if (lblHero.Text == "Zeratul")
            {
                int zeratulrage = 10 + (2 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Burning Rage";
                toolTip1.SetToolTip(Ability5_2, "Deal " + zeratulrage.ToString() + " damage per second to nearby enemies");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Chitinous Plating";
                toolTip1.SetToolTip(Ability5_2, "Increases Harden Carapace's Shield amount by 40%.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Relentless";
                toolTip1.SetToolTip(Ability5_2, "Reduces the duration of silences, stuns, slows,\nroots, and polymorphs against your Hero by 50%");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "A Touch of Honey";
                toolTip1.SetToolTip(Ability5_2, "Increase the slow from Keg Smash to 40%.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Spell Shield";
                toolTip1.SetToolTip(Ability5_2, "Upon taking Ability Damage, reduce that\ndamage and further Ability Damage by 50% for\n2 seconds. Can only trigger once every 30\nseconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Face Smelt";
                toolTip1.SetToolTip(Ability5_2, "Face Melt slows enemies by 80% fading over 2\nseconds.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Hold Your Ground";
                toolTip1.SetToolTip(Ability5_2, "Increases Iron Skin's Shield by 20%, and if the\nShield is destroyed by damage the cooldown is\nreduced by 4 seconds.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Healing Static";
                toolTip1.SetToolTip(Ability5_2, "Heal for 1.5% of your Max Health for each\ntarget hit by Thunder Clap.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Aftershock";
                toolTip1.SetToolTip(Ability5_2, "Using Seismic Slam temporarily reduces its Fury\ncost to 50%.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Mega Rush";
                toolTip1.SetToolTip(Ability5_2, "Range and arc of Slam increased by 25%.");
            }

            if (lblHero.Text == "Tyrael")
            {
                int tyraelangelic = 60 + (12 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Angelic Absorption";
                toolTip1.SetToolTip(Ability5_2, "Enemies that attack you while shielded grant " + tyraelangelic.ToString() + "\nHealth over 3 seconds.");
            }
        }

        //**ABILITY 5_3**//

        private void Ability5_3_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Thunderstrikes";
                toolTip1.SetToolTip(Ability5_3, "Lightning Rod deals 15% more damage each subsequent strike.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Friend or Foe";
                toolTip1.SetToolTip(Ability5_3, "Can use Dive on allies (but you will not flip).\nWhen used this way, the cooldown is reduced by 2 seconds.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Icy Veins";
                toolTip1.SetToolTip(Ability5_3, "Activate to make your Basic Abilities' cooldowns\nrecharge three times as fast and reduce their\nMana cost by 50% for 5 seconds.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Pyromaniac";
                toolTip1.SetToolTip(Ability5_3, "Every tick of Living Bomb's damage over time\neffect reduces Basic Ability cooldowns by 1 second.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Double Strike";
                toolTip1.SetToolTip(Ability5_3, "When your Basic Abilities damage an enemy,\nyour next Basic Attack hits for 50% extra damage.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Headshot";
                toolTip1.SetToolTip(Ability5_3, "Reduces your Ability cooldowns by 4 seconds when you kill an enemy Hero.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Steel Resolve";
                toolTip1.SetToolTip(Ability5_3, "Increases Inspire's duration by 50% and causes\nAdrenaline Rush to also apply Inspire.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Giant Killer";
                toolTip1.SetToolTip(Ability5_3, "Basic Attacks against enemy Heroes deal bonus\ndamage equal to 1.5% of the Hero's maximum\nHealth.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Stim Pack";
                toolTip1.SetToolTip(Ability5_3, "After using Run and Gun, gain 20% Attack\nSpeed and 20% Movement Speed for 3 seconds.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Tempered by Discipline";
                toolTip1.SetToolTip(Ability5_3, "Gain up to 10 stacks of Discipline after Hatred\nstacks are maxed. Basic Attacks heal for 3% of\ndamage dealt to the primary target per\nDiscipline stack.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Wormhole";
                toolTip1.SetToolTip(Ability5_3, "For 3 seconds, you can activate Blink again to return to\nthe point where it was cast from.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                int anubarmor = 90 + (22 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Symbiotic Armor";
                toolTip1.SetToolTip(Ability5_3, "Anub'arak's Beetles are also granted a Shield\nequal to " + anubarmor.ToString() + ".");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Trail of Frost";
                toolTip1.SetToolTip(Ability5_3, "Howling Blast impacts enemies while travelling.");
            }

            if (lblHero.Text == "Chen")
            {
                int chenshare = 10 + (6 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Enough to Share";
                toolTip1.SetToolTip(Ability5_3, "Fortifying Brew also Shields nearby allied Heroes for " + chenshare.ToString() + " per\nsecond.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Life Leach";
                toolTip1.SetToolTip(Ability5_3, "Basic Attacks against enemy Heroes deal bonus\ndamage equal to 1% of the Hero's maximum\nHealth and heal you for the same amount.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Show Stopper";
                toolTip1.SetToolTip(Ability5_3, "Reduces all damage taken by 25% for 4 seconds\nafter using Power Slide.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Subdue";
                toolTip1.SetToolTip(Ability5_3, "Increases Punish's slow to 80% decaying over 3\nseconds.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Thunder Strike";
                toolTip1.SetToolTip(Ability5_3, "Thunder Clap deals 300% damage if only one\ntarget is hit.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Mystical Spear";
                toolTip1.SetToolTip(Ability5_3, "Reduces the cooldown of Ancient Spear by 4\nseconds. You are pulled to the target location\neven if you don't hit an enemy.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Indigestion";
                toolTip1.SetToolTip(Ability5_3, "Using Devour also creates a Retchling.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Imposing Will";
                toolTip1.SetToolTip(Ability5_3, "Enemies that attack you while shielded have\ntheir Attack Speed slowed by 50% and\nMovement Speed slowed by 50% for 2 seconds.");
            }
        }
        //**ABILITY 5_4**//

        private void Ability5_4_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Static Shield";
                toolTip1.SetToolTip(Ability5_4, "Gain a Shield equal to 5% of your maximum Health after every Lightning Rod strike.\nLasts 4 seconds and stacks.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Unbound";
                toolTip1.SetToolTip(Ability5_4, "Ignore all collision while using Sweeping Strike, allowing you to go over walls and terrain.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Sprint";
                toolTip1.SetToolTip(Ability5_4, "Activate to gain 75% Movement Speed for 3 seconds.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Spell Shield";
                toolTip1.SetToolTip(Ability5_4, "Upon taking Ability Damage, reduce that\ndamage and further Ability Damage by 50% for 2 seconds.\nCan only trigger once every 30 seconds.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Sprint";
                toolTip1.SetToolTip(Ability5_4, "Activate to gain 75% Movement Speed for 3 seconds.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Spell Shield";
                toolTip1.SetToolTip(Ability5_4, "Upon taking Ability Damage, reduce that\ndamage and further Ability Damage by 50% for 2 seconds.\nCan only trigger once every 30 seconds.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Puttin’ On a Clinic";
                toolTip1.SetToolTip(Ability5_4, "Whenever an enemy you have recently\ndamaged is destroyed, your Ability cooldowns\nare reduced by 1.5 seconds.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Spell Shield";
                toolTip1.SetToolTip(Ability5_4, "Upon taking Ability Damage, reduce that\ndamage and further Ability Damage by 50% for\n2 seconds. Can only trigger once every 30\nseconds.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Relentless";
                toolTip1.SetToolTip(Ability5_4, "Reduces the duration of silences, stuns, slows,\nroots, and polymorphs against your Hero by 50%.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Spell Shield";
                toolTip1.SetToolTip(Ability5_4, "Upon taking Ability Damage, reduce that\ndamage and further Ability Damage by 50% for\n2 seconds. Can only trigger once every 30\nseconds.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Assassin's Blade";
                toolTip1.SetToolTip(Ability5_4, "Gain 25% Attack Damage for 5 seconds when\nbreaking Permanent Cloak. 10% increased\nMovement Speed while Stealthed from\nPermanent Cloak.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Spell Shield";
                toolTip1.SetToolTip(Ability5_4, "Upon taking Ability Damage, reduce that\ndamage and further Ability Damage by 50% for\n2 seconds. Can only trigger once every 30\nseconds.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Biting Cold";
                toolTip1.SetToolTip(Ability5_4, "Frozen Tempest damage increased by 50%.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Relentless";
                toolTip1.SetToolTip(Ability5_4, "Reduces the duration of silences, stuns, slows, roots, and polymorphs\nagainst your Hero by 50%.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Firestorm";
                toolTip1.SetToolTip(Ability5_4, "Fire Stomp waves return to you, dealing 125%\ndamage.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Spell Shield";
                toolTip1.SetToolTip(Ability5_4, "Upon taking Ability Damage, reduce that\ndamage and further Ability Damage by 50% for\n2 seconds. Can only trigger once every 30\nseconds.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Spell Shield";
                toolTip1.SetToolTip(Ability5_4, "Upon taking Ability Damage, reduce that \namage and further Ability Damage by 50% for\n2 seconds. Can only trigger once every 30\nseconds.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Spell Shield";
                toolTip1.SetToolTip(Ability5_4, "Upon taking Ability Damage, reduce that \namage and further Ability Damage by 50% for\n2 seconds. Can only trigger once every 30\nseconds.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Spell Shield";
                toolTip1.SetToolTip(Ability5_4, "Upon taking Ability Damage, reduce that\ndamage and further Ability Damage by 50% for\n2 seconds. Can only trigger once every 30\nseconds.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Helping Hand";
                toolTip1.SetToolTip(Ability5_4, "Hook can also pull allied Heroes (but will not\ndamage them).");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Angelic Might";
                toolTip1.SetToolTip(Ability5_4, "Gain 25% increased damage on your next Basic\nAttack for each target hit by Smite.");
            }
        }

        //**ABILITY 5_5**//

        private void Ability5_5_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Sixth Sense";
                toolTip1.SetToolTip(Ability5_5, "Take 50% reduced damage from Abilities while Evasion is active.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Spell Shield";
                toolTip1.SetToolTip(Ability5_5, "Upon taking Ability Damage, reduce that\ndamage and further Ability Damage by 50% for\n2 seconds. Can only trigger once every 30\nseconds.");
            }
        }

        //**ABILITY 6_1**//

        private void Ability6_1_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Aerie Gusts";
                toolTip1.SetToolTip(Ability6_1, "Reduce activation time for Tailwind to 2 seconds,\nand increase the Movement Speed bonus to 30%.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Hunter's Onslaught";
                toolTip1.SetToolTip(Ability6_1, "Abilities heal for 15% of damage dealt.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Snow Crash";
                toolTip1.SetToolTip(Ability6_1, "Increases the number of Blizzard waves from 2 to 3.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Ignite";
                toolTip1.SetToolTip(Ability6_1, "Flamestrike also applies Living Bomb to Heroes.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Aggressive Defense";
                toolTip1.SetToolTip(Ability6_1, "Assimilation Shields earned from Basic Attacks\nand Abilities increased by 100%.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Railgun";
                toolTip1.SetToolTip(Ability6_1, "Snipe penetrates through the first enemy hit\nand deals 50% damage to subsequent targets.\nSnipe cooldown is reduced by 1 second for each\ntarget hit.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Executioner";
                toolTip1.SetToolTip(Ability6_1, "Basic Attacks deal 40% more damage against\nslowed, rooted, or stunned targets.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Forked Lightning";
                toolTip1.SetToolTip(Ability6_1, "Allows Chain Lightning to hold 2 charges that\ncan be used in quick succession.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Executioner";
                toolTip1.SetToolTip(Ability6_1, "Basic Attacks deal 40% more damage against\nslowed, rooted, or stunned targets.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Executioner";
                toolTip1.SetToolTip(Ability6_1, "Basic Attacks deal 40% more damage against\nslowed, rooted, or stunned targets.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Rending Cleave";
                toolTip1.SetToolTip(Ability6_1, "Cleave deals an additional 50% damage over 5 seconds.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Epicenter";
                toolTip1.SetToolTip(Ability6_1, "Increases the impact area and damage of\nBurrow Charge by 85%.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Frostmourne Feeds";
                toolTip1.SetToolTip(Ability6_1, "Increased application to your next 2 Basic Attacks.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Combination Attack";
                toolTip1.SetToolTip(Ability6_1, "The next Basic Attack after using Flying Kick deals 100% bonus\ndamage.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Continuous Overpower";
                toolTip1.SetToolTip(Ability6_1, "Overpower can store 2 charges.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Speed Metal";
                toolTip1.SetToolTip(Ability6_1, "Rockstar also gives 20% Movement Speed for 2\nseconds.");
            }

            if (lblHero.Text == "Johanna")
            {
                double johannarenewal = 100 + (7.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Holy Renewal";
                toolTip1.SetToolTip(Ability6_1, "Every enemy Hero affected by Shield Glare heals\nyou for " + johannarenewal.ToString() + ".");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Dwarf Launch";
                toolTip1.SetToolTip(Ability6_1, "Increases the range and impact radius of Dwarf \noss by 50%.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Furious Blow";
                toolTip1.SetToolTip(Ability6_1, "Seismic Slam damage and cost increased by\n40%, but now costs 35 Fury.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Pulverize";
                toolTip1.SetToolTip(Ability6_1, "Decreases Slam's cooldown by 2 seconds and it\nalso slows enemies by 75% for 1 second.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Blade of Justice";
                toolTip1.SetToolTip(Ability6_1, "After teleporting using El'Druin's Might, your\nnext 3 Basic Attacks within 5 seconds deal 75%\nmore damage.");
            }
        }

        //**ABILITY 6_2**//

        private void Ability6_2_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Hammer Time";
                toolTip1.SetToolTip(Ability6_2, "Your first Basic Attack against a target slowed by\nHammerang will stun them for 0.75 seconds.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Second Sweep";
                toolTip1.SetToolTip(Ability6_2, "Store up to 2 charges of Sweeping Strike.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Northern Exposure";
                toolTip1.SetToolTip(Ability6_2, "Enemies damaged by Cone of Cold are also\nafflicted with Vulnerable, increasing the damage\nthey take by 25% for 2 seconds.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Backdraft";
                toolTip1.SetToolTip(Ability6_2, "Living Bomb's explosion slows enemies\nMovement Speed by 40% for 2.5 seconds.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Blade Torrent";
                toolTip1.SetToolTip(Ability6_2, "Impaling Blades radius increased by 30%.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Crippling Shot";
                toolTip1.SetToolTip(Ability6_2, "Enemies hit by Pinning shot become Vulnerable,\ntaking 25% increased damage for the duration\nof the slow.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Cluster Round";
                toolTip1.SetToolTip(Ability6_2, "Penetrating Round damage is increased by 10%\nfor each additional target hit, and the width is\nincreased by 50% .");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Tempest Fury";
                toolTip1.SetToolTip(Ability6_2, "The final strike of Windfury hits 3 times for 75%\nnormal damage.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Lock and Load";
                toolTip1.SetToolTip(Ability6_2, "While the Minigun is wound up, gain 15%\nincreased Move Speed.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Tumble";
                toolTip1.SetToolTip(Ability6_2, "Vault gains an additional charge, allowing it to\nbe cast twice in quick succession.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Double Bombs";
                toolTip1.SetToolTip(Ability6_2, "After you cast Singularity Spike, you can cast a\nsecond one for free within 3 seconds for 50%\nnormal damage.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Beetle,Juiced";
                toolTip1.SetToolTip(Ability6_2, "If a Beetle kills an enemy its duration is\nrefreshed, becomes fully healed, and gains\n100% bonus Health and damage. This effect can\nonly occur once per Beetle.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Immortal Coil";
                toolTip1.SetToolTip(Ability6_2, "Death Coil also heals when used on enemies.\nWhen used on self, the amount healed is\nincreased by 50% .");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Chug";
                toolTip1.SetToolTip(Ability6_2, "Gain Brew twice as fast while using Fortifying Brew.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Imposing Presence";
                toolTip1.SetToolTip(Ability6_2, "Enemies that attack you have their Attack\nSpeed slowed by 50% .");
            }

            if (lblHero.Text == "E.T.C.")
            {
                int etcpedal = 30 + (5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Echo Pedal";
                toolTip1.SetToolTip(Ability6_2, "Using a Basic or Heroic ability releases two\npulses of " + etcpedal.ToString() + " damage. The first\noccurs instantly, the second occurs 2 seconds\nlater.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Fanaticism";
                toolTip1.SetToolTip(Ability6_2, "While Iron Skin is active, gain 8% Movement\nSpeed each time you take damage. Stacks up to 40%");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Heavy Impact";
                toolTip1.SetToolTip(Ability6_2, "Enemies hit by Dwarf Toss are stunned for 0.75 \neconds.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "No Escape";
                toolTip1.SetToolTip(Ability6_2, "Increase the Movement Speed bonus from using\nabilities to 25%.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Fishing Hook";
                toolTip1.SetToolTip(Ability6_2, "Hook has an additional 40% range.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Holy Ground";
                toolTip1.SetToolTip(Ability6_2, "Create a ring that blocks enemies from entering\nthe area teleported to using El'Druin's Might.");
            }
        }

        //**ABILITY 6_3**//

        private void Ability6_3_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Afterburner";
                toolTip1.SetToolTip(Ability6_3, "After using Barrel Roll, gain 60% Movement\nSpeed that decreases over 3 seconds.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Blood for Blood";
                toolTip1.SetToolTip(Ability6_3, "Activate to steal 15% of target enemy Hero's\nMax Health and slow its Movement Speed by\n30% for 3 seconds.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Numbing Blast";
                toolTip1.SetToolTip(Ability6_3, "Cone of Cold also roots Chilled targets for 1 second.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Gravity Throw";
                toolTip1.SetToolTip(Ability6_3, "Increases the duration of Gravity Lapse's stun\nby 33% and causes it to instantly destroy Minions.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Blood for Blood";
                toolTip1.SetToolTip(Ability6_3, "Activate to steal 15% of target enemy Hero's\nMax Health and slow its Movement Speed by\n30% for 3 seconds.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Double Fake";
                toolTip1.SetToolTip(Ability6_3, "Casting Holo Decoy creates an additional Decoy\nat your current location.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Bullseye";
                toolTip1.SetToolTip(Ability6_3, "The first enemy hit by Penetrating Round is\nstunned for 1 second and takes 50% more damage.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Ride The Wind";
                toolTip1.SetToolTip(Ability6_3, "Increases Windfury's Movement Speed bonus\nfrom 30% to 40% . Windfury attacks increase\nthe Movement Speed duration by 1 second.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Concussion Grenade";
                toolTip1.SetToolTip(Ability6_3, "Increases the knockback of Frag Grenade by 100%.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Blood for Blood";
                toolTip1.SetToolTip(Ability6_3, "Activate to steal 15% of target enemy Hero's\nMax Health and slow its Movement Speed by\n30% for 3 seconds.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Stoneskin";
                toolTip1.SetToolTip(Ability6_3, "Activate to gain 30% of your maximum Health\nas a Shield for 5 seconds.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Imposing Presence";
                toolTip1.SetToolTip(Ability6_3, "Enemies that attack you have their Attack\nSpeed slowed by 50%.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Embrace Death";
                toolTip1.SetToolTip(Ability6_3, "Death Coil deals 20% more damage for each\n10% of life you are missing.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Pressure Point";
                toolTip1.SetToolTip(Ability6_3, "tFlying Kick slows the target enemy by 90% for 1 second.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Domination";
                toolTip1.SetToolTip(Ability6_3, "Overpower reduces the cooldown of Shadow\nCharge by 8 seconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Encore";
                toolTip1.SetToolTip(Ability6_3, "Face Melt leaves an Amp behind, which will\nknock enemies away again 2 seconds later.");
            }

            if (lblHero.Text == "Johanna")
            {
                double johannahammer = 40 + (2.5 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Blessed Hammer";
                toolTip1.SetToolTip(Ability6_3, "Condemn also creates a hammer that spirals\naround you, dealing " + johannahammer.ToString() + " damage\nto enemies it hits.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Give 'em the Axe!";
                toolTip1.SetToolTip(Ability6_3, "Basic Attacks deal 75% more damage against\nslowed, rooted, or stunned targets.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Imposing Presence";
                toolTip1.SetToolTip(Ability6_3, "Enemies that attack you have their Attack\nSpeed slowed by 50%.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Shish Kabob";
                toolTip1.SetToolTip(Ability6_3, "Hook can pull up to 2 targets.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Salvation";
                toolTip1.SetToolTip(Ability6_3, "Shield is 25% stronger for each allied Hero that\ngets shielded.");
            }
        }

        //**ABILITY 6_4**//

        private void Ability6_4_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Overdrive";
                toolTip1.SetToolTip(Ability6_4, "Activate to increase Ability Power by 25% and\nMana costs by 40% for 5 seconds.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Stoneskin";
                toolTip1.SetToolTip(Ability6_4, "Activate to gain 30% of your maximum Health as a Shield for 5 seconds.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Ice Barrier";
                toolTip1.SetToolTip(Ability6_4, "When Jaina does increased damage from\nFrostbite, she is shielded for 25% of the total\ndamage dealt. This Shield lasts 3 seconds.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Arcane Barrier";
                toolTip1.SetToolTip(Ability6_4, "Activate to gain a Shield equal to 200% of your\nmaximum Mana for 3 seconds.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Overdrive";
                toolTip1.SetToolTip(Ability6_4, "Activate to increase Ability Power by 25% and\nMana costs by 40% for 5 seconds.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Overdrive";
                toolTip1.SetToolTip(Ability6_4, "Activate to increase Ability Power by 25% and\nMana costs by 40% for 5 seconds.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Relentless Leader";
                toolTip1.SetToolTip(Ability6_4, "Reduces the duration of silences, stuns, slows,\nroots, and polymorphs against you by 50%.\nOnce every 5 seconds, if you are stunned you\nknock nearby enemies away.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Blood for Blood";
                toolTip1.SetToolTip(Ability6_4, "Activate to steal 15% of target enemy Hero's\nMax Health and slow its Movement Speed by\n30% for 3 seconds.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Stoneskin";
                toolTip1.SetToolTip(Ability6_4, "Activate to gain 30% of your maximum Health\nas a Shield for 5 seconds.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Stoneskin";
                toolTip1.SetToolTip(Ability6_4, "Activate to gain 30% of your maximum Health\nas a Shield for 5 seconds.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Berserk";
                toolTip1.SetToolTip(Ability6_4, "Activate to increase your Attack Speed by 40%\nand Movement Speed by 10% for 4 seconds.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Blood for Blood";
                toolTip1.SetToolTip(Ability6_4, "Activate to steal 15% of target enemy Hero's\nMax Health and slow its Movement Speed by\n30% for 3 seconds.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Stoneskin";
                toolTip1.SetToolTip(Ability6_4, "Activate to gain 30% of your maximum Health\nas a Shield for 5 seconds.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Bolder Flavor";
                toolTip1.SetToolTip(Ability6_4, "Increase Shield generation rate and maximum amount from Fortifying\nBrew by 40%.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Rampage";
                toolTip1.SetToolTip(Ability6_4, "Fire Stomp increases Diablo's Movement Speed\nby 20% and Basic Attack damage by 50% for 2\nseconds.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Imposing Presence";
                toolTip1.SetToolTip(Ability6_4, "Enemies that attack you have their Attack\nSpeed slowed by 50%");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Imposing Presence";
                toolTip1.SetToolTip(Ability6_4, "Enemies that attack you have their Attack\nSpeed slowed by 50%.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Imposing Presence";
                toolTip1.SetToolTip(Ability6_4, "Enemies that attack you have their Attack\nSpeed slowed by 50%.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Nerves of Steel";
                toolTip1.SetToolTip(Ability6_4, "Activate to gain 30% of your maximum Health\nas a Shield for 5 seconds.\n\nUsaable while Whirlwinding.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Imposing Presence";
                toolTip1.SetToolTip(Ability6_4, "Enemies that attack you have their Attack\nSpeed slowed by 50%.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Blood for Blood";
                toolTip1.SetToolTip(Ability6_4, "Activate to steal 15% of target enemy Hero's\nMax Health and slow its Movement Speed by\n30% for 3 seconds.");
            }

        }

        //**ABILITY 6_5**//

        private void Ability6_5_MouseHover(object sender, EventArgs e)
        {

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Berserk";
                toolTip1.SetToolTip(Ability6_5, "Activate to increase your Attack Speed by 40%\nand Movement Speed by 10% for 4 seconds.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Stoneform";
                toolTip1.SetToolTip(Ability6_5, "Activate to heal for 50% of your maximum\nHealth over 8 seconds. Second Wind is disabled\nduring this time.");
            }
        }

        //**ABILITY 7_1**//

        private void Ability7_1_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Call of the Wildhammer";
                toolTip1.SetToolTip(Ability7_1, "Hinterland Blast has double the range and deals\n25% more damage.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Demonic Form";
                toolTip1.SetToolTip(Ability7_1, "Permanently remain in Demonic Form.\nIncreases the Attack Speed bonus of Demonic Form to 30%\nand grants a 50% reduction in the duration of disabling effects.\nIllidan can now mount in this form.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Cold Snap";
                toolTip1.SetToolTip(Ability7_1, "The center of the ring also explodes with frost\nafter the first ring expires.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Rebirth";
                toolTip1.SetToolTip(Ability7_1, "Increases Phoenix duration by 100%.\nYou may order the Phoenix to move to a different location once\nwhile the Phoenix is alive.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Omegastorm";
                toolTip1.SetToolTip(Ability7_1, "Maelstrom size increased by 25%.\nAmount of Assimilation Shields generated by Maelstrom\nincreased by 100%.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Fast Reload";
                toolTip1.SetToolTip(Ability7_1, "Triple Tap's cooldown is reset if it kills an enemy Hero.");
            }

            if (lblHero.Text == "Raynor")
            {
                double raynorearth = 15 + (3.6 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Scorched Earth";
                toolTip1.SetToolTip(Ability7_1, "An additional set of lasers blast the ground 5\ntimes per second, dealing “ + raynorearth.ToString() + “ damage in an area.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Worldbreaker";
                toolTip1.SetToolTip(Ability7_1, "Sundering travels indefinitely.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Big Red Button";
                toolTip1.SetToolTip(Ability7_1, "Odin lasts 50% longer and Ragnarok Missiles\nalso launches a Nuclear Missile.");
            }

            if (lblHero.Text == "Valla")
            {
                double vallaveng = 7.5 + (3.375 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Vengeance";
                toolTip1.SetToolTip(Ability7_1, "Strafe also fires penetrating bolts in a line for " + vallaveng.ToString() + " damage every 0.25 seconds.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Nerazim Fury";
                toolTip1.SetToolTip(Ability7_1, "Shadow Assault grants 30% Life Steal, and the\nduration is increased by 50%.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                int anubmasterone = 16 + (16 * trackBar1.Value);
                int anubmastertwo = 20 + (3 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Hive Master";
                toolTip1.SetToolTip(Ability7_1, "Anub'arak gains a permanent Vampire Locust\nthat attacks a nearby enemy every 3 seconds.\nThe Vampire Locust deals " + anubmasterone.ToString() + "\ndamage and returns to heal Anub'arak for " + anubmastertwo.ToString() + " health.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Legion of Northrend";
                toolTip1.SetToolTip(Ability7_1, "3 additional Ghouls are created. Ghouls heal for\nan additional 25% and last 5 seconds longer.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Untapped Potential";
                toolTip1.SetToolTip(Ability7_1, "Increases duration by 2 seconds. Additionally, gain an extra 5%\nMovement Speed whenever an enemy is hit, up to 100%.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Dying Breath";
                toolTip1.SetToolTip(Ability7_1, "Apocalypse's cooldown is reduced by 20 seconds\nand is cast for free when you die.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Tour Bus";
                toolTip1.SetToolTip(Ability7_1, "Mosh Pit refreshes the cooldown of Powerslide.\nYou can Powerslide during Mosh Pit, which also\nincreases its duration by 2 seconds.");
            }

            if (lblHero.Text == "Johanna")
            {
                int johannafury = 25 + (7 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Heaven's Fury";
                toolTip1.SetToolTip(Ability7_1, "While in the air, holy bolts rain down on\nenemies dealing " + johannafury.ToString() + " damage and\nreducing the cooldown of Falling Sword by 2\nseconds for each enemy hit.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Unstoppable Force";
                toolTip1.SetToolTip(Ability7_1, "Increases the duration of Avatar by 30%, and\nthe duration of Disables are reduced by 75%\nwhile in Avatar.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Arreat Crater";
                toolTip1.SetToolTip(Ability7_1, "Leaves behind an impassable crater for 4\nseconds.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Regenerative Bile";
                toolTip1.SetToolTip(Ability7_1, "Putrid Bile lasts 2 seconds longer, grants an\nadditional 10% Movement Speed and heals for\n50% of the damage dealt.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Angel of Justice";
                toolTip1.SetToolTip(Ability7_1, "Increases the cast range of Judgment by 50%,\nand reduces the cooldown by 30 seconds.");
            }
        }

        //**ABILITY 7_2**//

        private void Ability7_2_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Wind Tunnel";
                toolTip1.SetToolTip(Ability7_2, "Mighty Gust creates a wind tunnel for 4 seconds.\nEnemies caught in the tunnel will periodically be pushed back.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Nowhere to Hide";
                toolTip1.SetToolTip(Ability7_2, "Grants The Hunt global range.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Wintermute";
                toolTip1.SetToolTip(Ability7_2, "Your Water Elemental will now mimic your\nFrostbolt, Blizzard, and Cone of Cold Abilities for\n50% damage. Cast range increased by 50%.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Presence of Mind";
                toolTip1.SetToolTip(Ability7_2, "Increases Pyroblast's explosion radius by 50%\nand reduces its cooldown by 10 seconds per\nenemy Hero hit.");
            }


            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Torrasque";
                toolTip1.SetToolTip(Ability7_2, "The Ultralisk morphs into an egg when it dies.\nIf the egg isn't killed within 8 seconds, a new Ultralisk is born.\nThis can only occur once per Ultralisk.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Precision Barrage";
                toolTip1.SetToolTip(Ability7_2, "Precision Strike now holds two charges with a short cooldown.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Dusk Wings";
                toolTip1.SetToolTip(Ability7_2, "Banshees remain Stealthed while attacking and fire\n50% more frequently.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Eathern Shields";
                toolTip1.SetToolTip(Ability7_2, "You and your allies within the Earthquake area\ngain a Shield equal to 15% of max Health each\npulse. This shield lasts 4 seconds.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Focusing Diodes";
                toolTip1.SetToolTip(Ability7_2, "Increases the range of the Drakken Laser Drill\nby 50% . Deals increased damage the longer it\nremains on a single target, up to 100% extra\ndamage.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Storm of Vengeance";
                toolTip1.SetToolTip(Ability7_2, "Increases the number of Shadow Beast waves to 4.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Protection Prison";
                toolTip1.SetToolTip(Ability7_2, "Allies are also no longer affected by Void Prison.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Cryptweave";
                toolTip1.SetToolTip(Ability7_2, "Gain the ability to channel on Web Blast victims\nfor 4 seconds to increase the duration by 4\nseconds. Usable once per Web Blast.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Absolute Zero";
                toolTip1.SetToolTip(Ability7_2, "Sindragosa flies twice as far. Enemy Heroes are\nrooted for 2 seconds, and then slowed by 60%\nfor 2 seconds.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Elemental Conduit";
                toolTip1.SetToolTip(Ability7_2, "Using an Ability will cause one of the elemental spirits to fight with you\nfor 4 seconds. Only one spirit can be active at a time.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Hellstorm";
                toolTip1.SetToolTip(Ability7_2, "Lightning Breath lasts and reaches 50% longer.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Crowd Pleaser";
                toolTip1.SetToolTip(Ability7_2, "Stage Dive's impact area is 50% bigger, and its\ncooldown is reduced by 15 seconds for every\nenemy Hero hit.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Radiating Faith";
                toolTip1.SetToolTip(Ability7_2, "Increases Blessed Shield's range by 25%, the\ndistance the shield bounces by 25%, and\nmaximum enemies hit by 2.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Grand Slam";
                toolTip1.SetToolTip(Ability7_2, "Damage of Haymaker increased by 25% , Mana\ncost lowered by 40 , and can store 2 charges.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Anger Management";
                toolTip1.SetToolTip(Ability7_2, "Increases Wrath of the Berserker's reduction of\ndisables to 75% , and also increases all Fury\ngenerated during Wrath by 50%.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Hungry Hungry Stitches";
                toolTip1.SetToolTip(Ability7_2, "While active, Gorge can be repeatedly recast\nuntil the first target is expelled. The self slow is\nremoved and the duration is increased by 1\nsecond.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Holy Arena";
                toolTip1.SetToolTip(Ability7_2, "Increases duration of Sanctification by 1 second\nand increases the damage of allies by 25% ");
            }

        }

        //**ABILITY 7_3**//

        private void Ability7_3_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Nexus Frenzy";
                toolTip1.SetToolTip(Ability7_3, "Increases Attack Speed by 20% and Attack Range by 20%.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Nexus Blades";
                toolTip1.SetToolTip(Ability7_3, "Basic attacks deal 20% more damage and slow the target for 1 second.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Arcane Power";
                toolTip1.SetToolTip(Ability7_3, "Activate to instantly restore 400 Mana\nand increase Ability Power by 15% for 5 seconds.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_3, "Activate to teleport to a nearby location.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Nexus Blades";
                toolTip1.SetToolTip(Ability7_3, "Basic attacks deal 20% more damage and slow\nthe target for 1 second.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Rewind";
                toolTip1.SetToolTip(Ability7_3, "Activate to reset the cooldowns of your Basic Abilities.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "A Card to Play";
                toolTip1.SetToolTip(Ability7_3, "Whenever a Hero (ally or enemy) is killed, the\ncooldown of your Heroic Ability is reduced by 10\nseconds.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Nexus Blades";
                toolTip1.SetToolTip(Ability7_3, "Basic attacks deal 20% more damage and slow\nthe target for 1 second.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Nexus Frenzy";
                toolTip1.SetToolTip(Ability7_3, "Increases Attack Speed by 20% and Attack\nRange by 20%.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Nexus Frenzy";
                toolTip1.SetToolTip(Ability7_3, "Increases Attack Speed by 20% and Attack\nRange by 20%.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Nexus Blades";
                toolTip1.SetToolTip(Ability7_3, "Basic attacks deal 20% more damage and slow\nthe target for 1 second.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Hardened Shield";
                toolTip1.SetToolTip(Ability7_3, "Activate to reduce damage taken by 75% for 4\nseconds.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Hardened Shield";
                toolTip1.SetToolTip(Ability7_3, "Activate to reduce damage taken by 75% for 4\nseconds.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Hardened Shield";
                toolTip1.SetToolTip(Ability7_3, "Cooldown: 60 seconds\n\nActivate to reduce damage taken by 75% for 4 seconds.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Lord of Terror";
                toolTip1.SetToolTip(Ability7_3, "Activate to steal 10% of the maximum Health of\nnearby enemy Heroes.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Death Metal";
                toolTip1.SetToolTip(Ability7_3, "Upon dying, a ghost uses Mosh Pit at your\nlocation.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Indestructible";
                toolTip1.SetToolTip(Ability7_3, "Upon taking fatal damage, gain a Shield equal to\nyour maximum Health for 5 seconds. This ability\nhas a 120 second cooldown.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Hardened Shield";
                toolTip1.SetToolTip(Ability7_3, "Activate to reduce damage taken by 75% for 4\nseconds.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Nexus Blades";
                toolTip1.SetToolTip(Ability7_3, "Basic attacks deal 20% more damage and slow\nthe target for 1 second.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Hardened Shield";
                toolTip1.SetToolTip(Ability7_3, "Activate to reduce damage taken by 75% for 4\nseconds.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Hardened Shield";
                toolTip1.SetToolTip(Ability7_3, "Activate to reduce damage taken by 75% for 4\nseconds.");
            }

        }

        //**ABILITY 7_4**//

        private void Ability7_4_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Epic Mount";
                toolTip1.SetToolTip(Ability7_4, "Reduce the cooldown of Flight to 20 seconds,\nreduce the cast time before flying to 0.5 seconds,\nand increase the speed by 50%.");
            }

            if (lblHero.Text == "Illidan")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_4, "Activate to teleport to a nearby location.");
            }

            if (lblHero.Text == "Jaina")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_4, "Activate to teleport to a nearby location.");
            }

            if (lblHero.Text == "Kael'Thas")
            {
                toolTip1.ToolTipTitle = "Arcane Power";
                toolTip1.SetToolTip(Ability7_4, "Activate to instantly restore 400 Mana =\nand increase Ability Power by 15% for 5 seconds.");
            }

            if (lblHero.Text == "Kerrigan")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_4, "Activate to teleport to a nearby location.");
            }

            if (lblHero.Text == "Nova")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_4, "Activate to teleport to a nearby location.");
            }

            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Nexus Frenzy";
                toolTip1.SetToolTip(Ability7_4, "Increases Attack Speed by 20% and Attack\nRange by 20%.");
            }

            if (lblHero.Text == "Thrall")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_4, "Activate to teleport to a nearby location.");
            }

            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_4, "Activate to teleport to a nearby location.");
            }

            if (lblHero.Text == "Valla")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_4, "Activate to teleport to a nearby location.");
            }

            if (lblHero.Text == "Zeratul")
            {
                toolTip1.ToolTipTitle = "Rewind";
                toolTip1.SetToolTip(Ability7_4, "Activate to reset the cooldowns of your Basic\nAbilities.");
            }

            if (lblHero.Text == "Anub'arak")
            {
                toolTip1.ToolTipTitle = "Rewind";
                toolTip1.SetToolTip(Ability7_4, "Activate to reset the cooldowns of your Basic\nAbilities.");
            }

            if (lblHero.Text == "Arthas")
            {
                toolTip1.ToolTipTitle = "Rewind";
                toolTip1.SetToolTip(Ability7_4, "Activate to reset the cooldowns of your Basic\nAbilities.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_4, "Cooldown: 40 seconds\n\nActivate to teleport to a nearby location.");
            }

            if (lblHero.Text == "Diablo")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_4, "Activate to teleport to a nearby location.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Storm Shield";
                toolTip1.SetToolTip(Ability7_4, "Activate to give all nearby allied Heroes a Shield\nfor 20% of their max Health for 3 seconds.");
            }

            if (lblHero.Text == "Johanna")
            {
                toolTip1.ToolTipTitle = "Storm Shield";
                toolTip1.SetToolTip(Ability7_4, "Activate to give all nearby allied Heroes a Shield\nfor 20% of their max Health for 3 seconds.");
            }

            if (lblHero.Text == "Muradin")
            {
                toolTip1.ToolTipTitle = "Rewind";
                toolTip1.SetToolTip(Ability7_4, "Activate to reset the cooldowns of your Basic\nAbilities.");
            }

            if (lblHero.Text == "Sonya")
            {
                toolTip1.ToolTipTitle = "Ignore Pain";
                toolTip1.SetToolTip(Ability7_4, "Activate to reduce damage taken by 75% for 4\nseconds.\n\nUsable while Whirlwinding.");
            }

            if (lblHero.Text == "Stitches")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_4, "Activate to teleport to a nearby location.");
            }

            if (lblHero.Text == "Tyrael")
            {
                toolTip1.ToolTipTitle = "Nexus Blades";
                toolTip1.SetToolTip(Ability7_4, "Basic attacks deal 20% more damage and slow\nthe target for 1 second.");
            }
        }

        //**ABILITY 7_5**//

        private void Ability7_5_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Raynor")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_5, "Activate to teleport to a nearby location.");
            }

            if (lblHero.Text == "E.T.C.")
            {
                toolTip1.ToolTipTitle = "Bolt of the Storm";
                toolTip1.SetToolTip(Ability7_5, "Activate to teleport to a nearby location.");
            }
        }

        //**SPECIAL 1**//

        private void picSpec1_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Flight\nZ";
                toolTip1.SetToolTip(picSpec1, "Cooldown: 45 seconds\n\nInstead of mounting, you can fly a great distance over terrain.");
            }

            if (lblHero.Text == "Tychus")
            {
                int tychusannihilate = 70 + (18 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Annihilate";
                toolTip1.SetToolTip(picSpec1, "Cooldown: 7 seconds\n\nFire the Odin's cannons in a straight line, dealing " + tychusannihilate.ToString() + " damage\nto everything in the path.");
            }

              if (lblHero.Text == "Chen")
            {
                int chentriple = 10 + (4 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Triple Attack";
                toolTip1.SetToolTip(picSpec1, "Cooldown: 6 seconds\n\nOrder the Spirits to smash the targeted point, dealing " + chentriple.ToString() + " damage per Spirit alive and\nslowing enemies in the targeted area by 20% for 2 seconds.");
            }
        }

        //**SPECIAL 2**//

        private void picSpec2_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Tychus")
            {
                int tychusrag = 30 + (13 * trackBar1.Value);
                toolTip1.ToolTipTitle = "Ragnarok Missles";
                toolTip1.SetToolTip(picSpec2, "Cooldown: 7 seconds\n\nLaunches a volley of missiles at target area, " + tychusrag.ToString() + "\ndamage and slowing enemy Movement\nSpeed by 30% for 2 seconds.");
            }

            if (lblHero.Text == "Chen")
            {
                toolTip1.ToolTipTitle = "Split Up";
                toolTip1.SetToolTip(picSpec2, "Cooldown: 6 seconds\n\nOrder the Spirits to immediately spread out, jumping a short distance away from each other.");
            }
        }

        //**SPECIAL 3**//

        private void picSpec3_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Tychus")
            {
                toolTip1.ToolTipTitle = " Thrusters";
                toolTip1.SetToolTip(picSpec3, "Cooldown: 8 seconds\n\nDash in target direction.");
            }
        }

        //**SPECIAL 4**//

        private void picSpec4_MouseHover(object sender, EventArgs e)
        {

        }
    }
}