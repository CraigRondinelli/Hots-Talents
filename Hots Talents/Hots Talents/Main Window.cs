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

        int growW = 150;
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

            if (lblHero.Text == "Johanna")
            {
                click.Play();
                initial();
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
        }

        private void Ability4_2_Click(object sender, EventArgs e)
        {
            click.Play();

            Border4_1.Visible = false;
            Border4_2.Visible = true;
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
            picR1Ability.ImageLocation = @"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Skills\76px-Summon_Water_Elemental_Icon.png";
            picR2Ability.ImageLocation = @"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Skills\76px-Ring_of_Frost_Icon.png";
            picTrait.ImageLocation = @"C:\Users\Craig\Desktop\Hots Icons\Abilites\Jaina\Skills\76px-Frostbite_Icon.png";

            lblQ.Text = "Frostbolt\nQ";
            lblW.Text = "Blizzard\nW";
            lblE.Text = "Cone of Cold\nE";
            lblR1.Text = "Summon Water Elemental\nR (Heroic)";
            lblR2.Text = "Ring of Frost\nR (Heroic)";
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

            Ability4_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 10\64px-Maelstrom_Icon.png");
            Ability4_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 10\64px-Summon_Ultralisk_Icon.png");

            Ability5_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 13\64px-Lingering_Essence_Icon.png");
            Ability5_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 13\64px-Eviscerate_Icon.png");
            Ability5_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 13\64px-Double_Strike_Icon.png");
            Ability5_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 13\Sprint_Icon.png");

            Ability6_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 16\64px-Aggressive_Defense_Icon.png");
            Ability6_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 16\64px-Blade_Torrent_Icon.png");
            Ability6_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 16\Blood_for_Blood_Icon.png");
            Ability6_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 16\Overdrive_Icon.png");

            Ability7_1.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 20\64px-Omegastorm_Icon.png");
            Ability7_2.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 20\64px-Torrasque_Icon.png");
            Ability7_3.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 20\Nexus_Blades_Icon.png");
            Ability7_4.ImageLocation = (@"C:\Users\Craig\Desktop\Hots Icons\Abilites\Kerrigan\Talents\Tier 20\64px-Bolt_of_the_Storm_Icon.png");

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
            lblHero.Text = "Anub'Arak";
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
            Border1_3.Visible = true;
            Border2_4.Visible = true;
            Border3_2.Visible = true;
            Border4_2.Visible = true;
            Border5_4.Visible = true;
            Border6_2.Visible = true;
            Border7_4.Visible = true;
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

        //**TRACKBAR LABEL**//

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            trackbarlabel.Text = "Level " + trackBar1.Value.ToString();
        }

        //FALSTAD TOOLTIPS**//

        private void picQAbility_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Hammerang";
                int falhammer = 50 + (12 * trackBar1.Value);
                toolTip1.SetToolTip(picQAbility, "Mana: 70\nCooldown: 10 seconds\n\nThrow out a Hammer that returns to you, dealing " + falhammer.ToString() + " damage\nand slowing enemies by 25% for 2 seconds.");
            }
        }

        private void picWAbility_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Lightning Rod";
                int fallightningone = 35 + (10 * trackBar1.Value);
                int fallightningtwo = 25 + (7 * trackBar1.Value);
                toolTip1.SetToolTip(picWAbility, "Mana: 70\nCooldown: 15 seconds\n\nDeal " + fallightningone.ToString() + " damage to an enemy, and an additional  " + fallightningtwo.ToString() + " damage per second\nfor 4.25 seconds if you remain close to the target.");
            }
        }

        private void picEAbility_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Barrel Roll";
                int falbarrel = 75 + (15 * trackBar1.Value);
                toolTip1.SetToolTip(picEAbility, "Mana: 75\nCooldown: 14 seconds\n\nDashes forward and grants a " + falbarrel.ToString() + " point Shield for 2 seconds.");
            }
        }

        private void picR1Ability_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Mighty Gust";
                toolTip1.SetToolTip(picR1Ability, "Heroic Ability\nMana: 70\nCooldown: 50 seconds\n\nPush enemies away and apply an 60% slow that decays over 3 seconds.");
            }
        }

        private void picR2Ability_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Hinterland Blast";
                int falhinter = 280 + (31 * trackBar1.Value);
                toolTip1.SetToolTip(picR2Ability, "Heroic Ability\nMana: 100\nCooldown: 90 seconds\n\nAfter a short delay, deal " + falhinter.ToString() + " damage to enemies within a long line.");
            }
        }

        private void picTrait_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Tailwind";
                toolTip1.SetToolTip(picTrait, "Cooldown: 6 seconds\n\nGain 20% increased Movement Speed after not taking damage for 6 seconds.");
            }
        }

        private void Ability1_1_MouseHover_1(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Power Throw";
                toolTip1.SetToolTip(Ability1_1, "Increase the range of Hammerang by 40%\nand the slow duration by 25%.");
            }
        }

        private void Ability1_2_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Updraft";
                toolTip1.SetToolTip(Ability1_2, "Increase the range of Barrel Roll by 30%.");
            }
        }

        private void Ability1_3_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Seasoned Marksman";
                toolTip1.SetToolTip(Ability1_3, "For every 6 enemy Minion or Mercenary kills near your Hero,\ngain 1 Basic Attack damage.\nHero Takedowns count as 2 Minion kills.");
            }
        }

        private void Ability1_4_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Conjurer's Pursuit";
                toolTip1.SetToolTip(Ability1_4, "Increases Mana Regeneration by 0.5 per second.\nEvery 3 Regeneration Globes gathered increases this bonus by 0.25.");
            }
        }

        private void Ability1_5_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Bribe";
                toolTip1.SetToolTip(Ability1_5, "Kill enemy Minions to gain up to 50 stacks of Bribe.\nUse 20 stacks to bribe target Mercenary, instantly defeating them.\nDoes not work on Bosses.");
            }
        }

        private void Ability2_1_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Charged Up";
                toolTip1.SetToolTip(Ability2_1, "Lightning Rod strikes the target 2 additional times.");
            }
        }

        private void Ability2_2_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Flow Rider";
                toolTip1.SetToolTip(Ability2_2, "Lowers the cooldown of Barrel Roll by 40%.");
            }
        }

        private void Ability2_3_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Vampiric Assault";
                toolTip1.SetToolTip(Ability2_3, "Basic Attacks heal for 15% of the\ndamage dealt to the primary target.");
            }
        }

        private void Ability2_4_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Gathering Power";
                toolTip1.SetToolTip(Ability2_4, "Passively grants 5% Ability Power.\nEach Hero takedown increases this bonus by 2% to a maximum of 15%.\nThis bonus Ability Power is reset to 5% on death.");
            }
        }

        private void Ability3_1_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Battle Momentum";
                toolTip1.SetToolTip(Ability3_1, "Basic Attacks reduce Ability cooldowns by 0.5 seconds.");
            }
        }

        private void Ability3_2_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Secret Weapon";
                toolTip1.SetToolTip(Ability3_2, "Basic Attacks deal 80% bonus damage while Hammerang is in flight.");
            }
        }

        private void Ability3_3_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "BOOMerang";
                int falboom = 25 + (12 * trackBar1.Value);
                toolTip1.SetToolTip(Ability3_3, "Reactivate Hammerang mid-flight to deal " + falboom.ToString() + " damage around the Hammer.");
            }
        }

        private void Ability3_4_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Free Roll";
                toolTip1.SetToolTip(Ability3_4, "Barrel Roll costs no mana.");
            }
        }

        private void Ability3_5_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "First Aid";
                toolTip1.SetToolTip(Ability3_5, "Activate to heal 35.49% of your max Health over 6 seconds.");
            }
        }

        private void Ability4_1_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Mighty Gust";
                toolTip1.SetToolTip(Ability4_1, "Heroic Ability\nMana: 70\nCooldown: 50 seconds\n\nPush enemies away and apply an 60% slow that decays over 3 seconds.");
            }
        }

        private void Ability4_2_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Hinterland Blast";
                int falhinter = 280 + (31 * trackBar1.Value);
                toolTip1.SetToolTip(Ability4_2, "Heroic Ability\nMana: 100\nCooldown: 90 seconds\n\nAfter a short delay, deal " + falhinter.ToString() + " damage to enemies within a long line.");
            }
        }

        private void Ability5_1_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Giant Killer";
                toolTip1.SetToolTip(Ability5_1, "Basic Attacks against enemy Heroes deal bonus damage\nequal to 1.5% of the Hero's maximum Health.");
            }
        }

        private void Ability5_2_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Crippling Hammer";
                toolTip1.SetToolTip(Ability5_2, "Increases the Movement Speed Slow of Hammerang to 50%.");
            }
        }

        private void Ability5_3_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Thunderstrikes";
                toolTip1.SetToolTip(Ability5_3, "Lightning Rod deals 15% more damage each subsequent strike.");
            }
        }

        private void Ability5_4_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Static Shield";
                toolTip1.SetToolTip(Ability5_4, "Gain a Shield equal to 5% of your maximum Health after every Lightning Rod strike.\nLasts 4 seconds and stacks.");
            }
        }

        private void Ability6_1_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Aerie Gusts";
                toolTip1.SetToolTip(Ability6_1, "Reduce activation time for Tailwind to 2 seconds,\nand increase the Movement Speed bonus to 30%.");
            }
        }

        private void Ability6_2_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Hammer Time";
                toolTip1.SetToolTip(Ability6_2, "Your first Basic Attack against a target slowed by\nHammerang will stun them for 0.75 seconds.");
            }
        }

        private void Ability6_3_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Afterburner";
                toolTip1.SetToolTip(Ability6_3, "After using Barrel Roll, gain 60% Movement\nSpeed that decreases over 3 seconds.");
            }
        }

        private void Ability6_4_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Overdrive";
                toolTip1.SetToolTip(Ability6_4, "Activate to increase Ability Power by 25% and\nMana costs by 40% for 5 seconds.");
            }
        }

        private void Ability7_1_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Call of the Wildhammer";
                toolTip1.SetToolTip(Ability7_1, "Hinterland Blast has double the range and deals\n25% more damage.");
            }
        }

        private void Ability7_2_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Wind Tunnel";
                toolTip1.SetToolTip(Ability7_2, "Mighty Gust creates a wind tunnel for 4 seconds.\nEnemies caught in the tunnel will periodically be pushed back.");
            }
        }

        private void Ability7_3_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Nexus Frenzy";
                toolTip1.SetToolTip(Ability7_3, "Increases Attack Speed by 20% and Attack Range by 20%.");
            }
        }

        private void Ability7_4_MouseHover(object sender, EventArgs e)
        {
            if (lblHero.Text == "Falstad")
            {
                toolTip1.ToolTipTitle = "Epic Mount";
                toolTip1.SetToolTip(Ability7_4, "Reduce the cooldown of Flight to 20 seconds,\nreduce the cast time before flying to 0.5 seconds,\nand increase the speed by 50%.");
            }
        }

        private void picR1Ability_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void picR2Ability_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void picTrait_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability1_2_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability1_3_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability1_4_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability1_5_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability2_1_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability2_2_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability2_3_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability2_4_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability2_5_MouseHover(object sender, EventArgs e)
        {

        }

        private void Ability3_1_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability3_2_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability3_3_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability3_4_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability3_5_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability4_1_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability4_2_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability5_1_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability5_2_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability5_3_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability5_4_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability5_5_MouseHover(object sender, EventArgs e)
        {

        }

        private void Ability6_1_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability6_2_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability6_3_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability6_4_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability6_5_MouseHover(object sender, EventArgs e)
        {

        }

        private void Ability7_1_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability7_2_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability7_3_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability7_4_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void Ability7_5_MouseHover(object sender, EventArgs e)
        {

        }

        private void picSpec1_MouseHover(object sender, EventArgs e)
        {

        }

        private void picSpec2_MouseHover(object sender, EventArgs e)
        {

        }

        private void picSpec3_MouseHover(object sender, EventArgs e)
        {

        }

        private void picSpec4_MouseHover(object sender, EventArgs e)
        {

        }
    }
}