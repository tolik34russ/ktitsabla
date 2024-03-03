using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Data;
using System.Xml.Linq;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;
using _15.Classes.armors;
using _15.Classes.roditeli;
using _15.Classes.weapons;
using System.Security.Policy;


namespace _15
{
    public partial class MiddlePage : Page
    {
        internal List<Unit> Characters = new List<Unit>() { new Warrior(), new Rogue(), new Wizard() };
        internal List<Weapon> WeaponsList = new List<Weapon>() { new Axe(), new Dagger(), new Mace(), new Staff(), new Sword() };
        internal List<Armor> ArmorList = new List<Armor>() { new LightHelmet(), new LightСhesplate(), new MiddleHelmet(), new MiddleСhestplate(), new HeavyHelmet(), new HeavyСhesplate() };

        public MiddlePage()
        {
            InitializeComponent();
        }
       
        ///////////////////////////////////////////////////КОЭФФИЦЕНТЫ ЗАПОЛНЕНИЯ////////////////////////////////////////      
        private void SelCh(object sender, SelectionChangedEventArgs e)
        {
            var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
            if (CharactersFind.Name == "Warrior")
            {
                Pic(1);
                denis_img.Visibility = Visibility.Visible;
                NameClassBlock.Text = CharactersFind.Name + ": ";
                ClearAllStats();
                ClearBonuses();
                Сlrbuffs();
                //заполняются дэфолт статы
                LevelBlock.Text = CharactersFind.Level.ToString();
                ExperienceBlock.Text = CharactersFind.Exp.ToString();
                StrenghtBlock.Text = CharactersFind.Strenght.ToString();
                StrenghtMaxBlock.Text = CharactersFind.MaxStrenght.ToString();
                DexterityBlock.Text = CharactersFind.Dexterity.ToString();
                DexterityMaxBlock.Text = CharactersFind.MaxDexterity.ToString();
                InteligenceBlock.Text = CharactersFind.Intelengence.ToString();
                InteligenceMaxBlock.Text = CharactersFind.MaxIntelengence.ToString();
                VitalityBlock.Text = CharactersFind.Vitality.ToString();
                VitalityMaxBlock.Text = CharactersFind.MaxVitality.ToString();

                //первонач забивка
                HealthBlock.Text = Convert.ToString(CharactersFind.Vitality + CharactersFind.Strenght);
                ManaBlock.Text = Convert.ToString(CharactersFind.Intelengence);
                PdamageBlock.Text = Convert.ToString(CharactersFind.Strenght);
                ArmorBlock.Text = Convert.ToString(CharactersFind.Dexterity);
                MdamageBlock.Text = Convert.ToString(CharactersFind.Intelengence);
                MdefenseBlock.Text = Convert.ToString(CharactersFind.Intelengence);
                CrtchanseBlock.Text = Convert.ToString(CharactersFind.Dexterity);
                CrtdamageBlock.Text = Convert.ToString(CharactersFind.Dexterity);


                //заполняются статы на кнопки

                //int a = CharactersFind.Vitality * 2;
                //int b = CharactersFind.Strenght * 1;
                //int c = a + b;
                //HealthBlock.Text = Convert.ToString(c + MaceHBuff);
                //PdamageBlock.Text = Convert.ToString(CharactersFind.Strenght * 1 + StaffPdamBuff + DaggerPdamBuff + SwordPdamBuff + AxePdamBuff + MacePdamBuff);


                //ArmorBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1);
                //CrtchanseBlock.Text = Convert.ToString(CharactersFind.Dexterity * 2 / 10 + StaffCrtCBuff + DaggerCrtCBuff + SwordCrtCBuff + AxeCrtCBuff + MaceCrtCBuff);
                //CrtdamageBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1 / 10 + StaffCrtDBuff + DaggerCrtDBuff + SwordCrtDBuff + AxeCrtDBuff + MaceCrtDBuff);

                //ManaBlock.Text = Convert.ToString(CharactersFind.Intelengence * 1 + StaffMBuff);
                //MdamageBlock.Text = Convert.ToString(CharactersFind.Intelengence * 2 / 10);
                //MdefenseBlock.Text = Convert.ToString(CharactersFind.Intelengence * 5 / 10);
                NameXS.Text = "DenisXgodPivnieSiski BhopProChyshpan";
            }
            else if (CharactersFind.Name == "Rogue")
            {
                Pic(2);
                ildar_img.Visibility = Visibility.Visible;
                NameClassBlock.Text = CharactersFind.Name + ": ";
                ClearAllStats();
                ClearBonuses();
                Сlrbuffs();
                //заполняются дэфолт статы
                LevelBlock.Text = CharactersFind.Level.ToString();
                ExperienceBlock.Text = CharactersFind.Exp.ToString();
                StrenghtBlock.Text = CharactersFind.Strenght.ToString();
                StrenghtMaxBlock.Text = CharactersFind.MaxStrenght.ToString();
                DexterityBlock.Text = CharactersFind.Dexterity.ToString();
                DexterityMaxBlock.Text = CharactersFind.MaxDexterity.ToString();
                InteligenceBlock.Text = CharactersFind.Intelengence.ToString();
                InteligenceMaxBlock.Text = CharactersFind.MaxIntelengence.ToString();
                VitalityBlock.Text = CharactersFind.Vitality.ToString();
                VitalityMaxBlock.Text = CharactersFind.MaxVitality.ToString();

                //первонач забивка
                HealthBlock.Text = Convert.ToString(CharactersFind.Vitality + CharactersFind.Strenght);
                ManaBlock.Text = Convert.ToString(CharactersFind.Intelengence);
                PdamageBlock.Text = Convert.ToString(CharactersFind.Strenght);

                ArmorBlock.Text = Convert.ToString(CharactersFind.Dexterity);
                MdamageBlock.Text = Convert.ToString(CharactersFind.Intelengence);
                MdefenseBlock.Text = Convert.ToString(CharactersFind.Intelengence);
                CrtchanseBlock.Text = Convert.ToString(CharactersFind.Dexterity);
                CrtdamageBlock.Text = Convert.ToString(CharactersFind.Dexterity);

                //заполняются статы на кнопки
                //int a = CharactersFind.Vitality * 15 / 10;
                //int b = CharactersFind.Strenght * 5 / 10;
                //int c = a + b;
                //HealthBlock.Text = Convert.ToString(c + MaceHBuff);

                //int a1 = CharactersFind.Strenght * 5 / 10;
                //int b1 = CharactersFind.Dexterity * 5 / 10;
                //int c1 = a1 + b1;
                //PdamageBlock.Text = Convert.ToString(c1 + StaffPdamBuff + DaggerPdamBuff + SwordPdamBuff + AxePdamBuff + MacePdamBuff);
                //ArmorBlock.Text = Convert.ToString(CharactersFind.Dexterity * 15 / 10);
                //CrtchanseBlock.Text = Convert.ToString(CharactersFind.Dexterity * 2 / 10 + StaffCrtCBuff + DaggerCrtCBuff + SwordCrtCBuff + AxeCrtCBuff + MaceCrtCBuff);
                //CrtdamageBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1 / 10 + StaffCrtDBuff + DaggerCrtDBuff + SwordCrtDBuff + AxeCrtDBuff + MaceCrtDBuff);
                //ManaBlock.Text = Convert.ToString(CharactersFind.Intelengence * 12 / 10 + StaffMBuff);
                //MdamageBlock.Text = Convert.ToString(CharactersFind.Intelengence * 2 / 10);
                //MdefenseBlock.Text = Convert.ToString(CharactersFind.Intelengence * 5 / 10);
                NameXS.Text = "OldHead$hotmachine - Ildar Dzarahov Paskuda";
            }
            else if (CharactersFind.Name == "Wizard")
            {
                Pic(3);
                alvin_img.Visibility = Visibility.Visible;
                NameClassBlock.Text = CharactersFind.Name + ": ";
                ClearAllStats();
                ClearBonuses();
                Сlrbuffs();
                LevelBlock.Text = CharactersFind.Level.ToString();
                ExperienceBlock.Text = CharactersFind.Exp.ToString();
                //заполняются дэфолт статы
                StrenghtBlock.Text = CharactersFind.Strenght.ToString();
                StrenghtMaxBlock.Text = CharactersFind.MaxStrenght.ToString();
                DexterityBlock.Text = CharactersFind.Dexterity.ToString();
                DexterityMaxBlock.Text = CharactersFind.MaxDexterity.ToString();
                InteligenceBlock.Text = CharactersFind.Intelengence.ToString();
                InteligenceMaxBlock.Text = CharactersFind.MaxIntelengence.ToString();
                VitalityBlock.Text = CharactersFind.Vitality.ToString();
                VitalityMaxBlock.Text = CharactersFind.MaxVitality.ToString();

                //первонач забивка
                HealthBlock.Text = Convert.ToString(CharactersFind.Vitality + CharactersFind.Strenght);
                ManaBlock.Text = Convert.ToString(CharactersFind.Intelengence);
                PdamageBlock.Text = Convert.ToString(CharactersFind.Strenght);
                ArmorBlock.Text = Convert.ToString(CharactersFind.Dexterity);
                MdamageBlock.Text = Convert.ToString(CharactersFind.Intelengence);
                MdefenseBlock.Text = Convert.ToString(CharactersFind.Intelengence);
                CrtchanseBlock.Text = Convert.ToString(CharactersFind.Dexterity);
                CrtdamageBlock.Text = Convert.ToString(CharactersFind.Dexterity);

                //заполняются статы на кнопки
                //int a = CharactersFind.Vitality * 14 / 10;
                //int b = CharactersFind.Strenght * 2 / 10;
                //int c = a + b;
                //HealthBlock.Text = Convert.ToString(c + MaceHBuff);
                //PdamageBlock.Text = Convert.ToString(CharactersFind.Strenght * 5 / 10 + StaffPdamBuff + DaggerPdamBuff + SwordPdamBuff + AxePdamBuff + MacePdamBuff);
                //ArmorBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1);
                //CrtchanseBlock.Text = Convert.ToString(CharactersFind.Dexterity * 2 / 10 + StaffCrtCBuff + DaggerCrtCBuff + SwordCrtCBuff + AxeCrtCBuff + MaceCrtCBuff);
                //CrtdamageBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1 / 10 + StaffCrtDBuff + DaggerCrtDBuff + SwordCrtDBuff + AxeCrtDBuff + MaceCrtDBuff);
                //ManaBlock.Text = Convert.ToString(CharactersFind.Intelengence * 15 / 10 + StaffMBuff);
                //MdamageBlock.Text = Convert.ToString(CharactersFind.Intelengence * 1);
                //MdefenseBlock.Text = Convert.ToString(CharactersFind.Intelengence * 1);
                NameXS.Text = "Alvin - Edik Stambul x Sigma";
            }
            ClassList.Visibility = Visibility.Collapsed;
            ClassText.Text = "Now your character is";
        }

        ///////////////////////////////////////////////////МЕТОДЫ////////////////////////////////////////////////////////

        void Pic(int name)
        {
            ImgWarrior.Visibility = Visibility.Collapsed;
            ImgRogue.Visibility = Visibility.Collapsed;
            ImgWizard.Visibility = Visibility.Collapsed;

            switch(name)
            {
                case 1: ImgWarrior.Visibility = Visibility.Visible; break;
                case 2: ImgRogue.Visibility = Visibility.Visible; break;
                case 3: ImgWizard.Visibility = Visibility.Visible; break;
                default: 
                    break;

            }
        }
        
        void ClearBonuses()
        {
            BonusBarStr.Visibility = Visibility.Collapsed;
            BonusBarDex.Visibility = Visibility.Collapsed;
            BonusBarInt.Visibility = Visibility.Collapsed;
            BonusBarVit.Visibility = Visibility.Collapsed;
            BonusBarH.Visibility = Visibility.Collapsed;
            BonusBarM.Visibility = Visibility.Collapsed;
            BonusBarPdam.Visibility = Visibility.Collapsed;
            BonusBarArm.Visibility = Visibility.Collapsed;
            BonusBarMdam.Visibility = Visibility.Collapsed;
            BonusBarMdef.Visibility = Visibility.Collapsed;
            BonusBarCrtC.Visibility = Visibility.Collapsed;
            BonusBarCrtD.Visibility = Visibility.Collapsed;
        }
        void ClearAllStats() 
        {
            StrenghtBlock.Text = "";
            StrenghtMaxBlock.Text = "";
            DexterityBlock.Text = "";
            DexterityMaxBlock.Text = "";
            InteligenceBlock.Text = "";
            InteligenceMaxBlock.Text = "";
            VitalityBlock.Text = "";
            VitalityMaxBlock.Text = "";
            HealthBlock.Text = "";
            ManaBlock.Text = "";
            PdamageBlock.Text = "";
            ArmorBlock.Text = "";
            MdamageBlock.Text = "";
            MdefenseBlock.Text = "";
            CrtchanseBlock.Text = "";
            CrtdamageBlock.Text = "";
            LevelBlock.Text = "";
            ExperienceBlock.Text = "";

        }
        private void Page_Initialized(object sender, EventArgs e)
        {
            foreach (var a in Characters)
            {
                ClassList.Items.Add(a.Name);

            }
            CanvasInventory.Visibility = Visibility.Collapsed;
            CanvasInventory213123.Visibility = Visibility.Collapsed;
            InvMain.Visibility = Visibility.Collapsed;

            alvin_img.Visibility = Visibility.Collapsed;
            ildar_img.Visibility = Visibility.Collapsed;
            denis_img.Visibility = Visibility.Collapsed;

            none_def_shield1337.Visibility = Visibility.Collapsed;
            none_def_twohand1337.Visibility = Visibility.Collapsed;
            none_def_onehand1337.Visibility = Visibility.Collapsed;

            foreach (var a in WeaponsList)
            {
                WeaponList.Items.Add(a.Name);
            }
            foreach (var a in ArmorList)
            {
                ArmorssList.Items.Add(a.Name);
            }
            ClearBonuses();
        }
        void WarB()
        {
            var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
            int a = CharactersFind.Vitality * 2;
            int b = CharactersFind.Strenght * 1;
            int c = a + b;
            HealthBlock.Text = Convert.ToString(c + MaceHBuff);
            PdamageBlock.Text = Convert.ToString(CharactersFind.Strenght * 1 + StaffPdamBuff + DaggerPdamBuff + SwordPdamBuff + AxePdamBuff + MacePdamBuff);


            ArmorBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1);
            CrtchanseBlock.Text = Convert.ToString(CharactersFind.Dexterity * 2 / 10 + StaffCrtCBuff + DaggerCrtCBuff + SwordCrtCBuff + AxeCrtCBuff + MaceCrtCBuff);
            CrtdamageBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1 / 10 + StaffCrtDBuff + DaggerCrtDBuff + SwordCrtDBuff + AxeCrtDBuff + MaceCrtDBuff);

            ManaBlock.Text = Convert.ToString(CharactersFind.Intelengence * 1 + StaffMBuff);
            MdamageBlock.Text = Convert.ToString(CharactersFind.Intelengence * 2 / 10);
            MdefenseBlock.Text = Convert.ToString(CharactersFind.Intelengence * 5 / 10);
        }

        void RogB()
        {
            var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
            //заполняются статы на кнопки
            int a = CharactersFind.Vitality * 15 / 10;
            int b = CharactersFind.Strenght * 5 / 10;
            int c = a + b;
            HealthBlock.Text = Convert.ToString(c + MaceHBuff);

            int a1 = CharactersFind.Strenght * 5 / 10;
            int b1 = CharactersFind.Dexterity * 5 / 10;
            int c1 = a1 + b1;
            PdamageBlock.Text = Convert.ToString(c1 + StaffPdamBuff + DaggerPdamBuff + SwordPdamBuff + AxePdamBuff + MacePdamBuff);
            ArmorBlock.Text = Convert.ToString(CharactersFind.Dexterity * 15 / 10);
            CrtchanseBlock.Text = Convert.ToString(CharactersFind.Dexterity * 2 / 10 + StaffCrtCBuff + DaggerCrtCBuff + SwordCrtCBuff + AxeCrtCBuff + MaceCrtCBuff);
            CrtdamageBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1 / 10 + StaffCrtDBuff + DaggerCrtDBuff + SwordCrtDBuff + AxeCrtDBuff + MaceCrtDBuff);
            ManaBlock.Text = Convert.ToString(CharactersFind.Intelengence * 12 / 10 +StaffMBuff);
            MdamageBlock.Text = Convert.ToString(CharactersFind.Intelengence * 2 / 10);
            MdefenseBlock.Text = Convert.ToString(CharactersFind.Intelengence * 5 / 10);
        }

        void WizB()
        {
            var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));

            //заполняются статы на кнопки
            int a = CharactersFind.Vitality * 14 / 10;
            int b = CharactersFind.Strenght * 2 / 10;
            int c = a + b;
            HealthBlock.Text = Convert.ToString(c + MaceHBuff);
            PdamageBlock.Text = Convert.ToString(CharactersFind.Strenght * 5 / 10 + StaffPdamBuff + DaggerPdamBuff + SwordPdamBuff + AxePdamBuff + MacePdamBuff);
            ArmorBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1);
            CrtchanseBlock.Text = Convert.ToString(CharactersFind.Dexterity * 2 / 10 + StaffCrtCBuff + DaggerCrtCBuff + SwordCrtCBuff + AxeCrtCBuff + MaceCrtCBuff);
            CrtdamageBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1 / 10 + StaffCrtDBuff + DaggerCrtDBuff + SwordCrtDBuff + AxeCrtDBuff + MaceCrtDBuff);
            ManaBlock.Text = Convert.ToString(CharactersFind.Intelengence * 15 / 10 + StaffMBuff);
            MdamageBlock.Text = Convert.ToString(CharactersFind.Intelengence * 1);
            MdefenseBlock.Text = Convert.ToString(CharactersFind.Intelengence * 1);
        }
        void Сlrbuffs()
        {
            int StaffPdamBuff = 0, StaffMBuff = 0, StaffIntBuff = 0, StaffCrtCBuff = 0, StaffCrtDBuff = 0, DaggerPdamBuff = 0, DaggerDexBuff = 0,
                DaggerCrtCBuff = 0, DaggerCrtDBuff = 0, SwordPdamBuff = 0, SwordDexBuff = 0, SwordStrBuff = 0, SwordCrtCBuff = 0, SwordCrtDBuff = 0,
                AxePdamBuff = 0, AxeStrBuff = 0, AxeCrtCBuff = 0, AxeCrtDBuff = 0, MacePdamBuff = 0, MaceStrBuff = 0, MaceHBuff = 0, MaceCrtCBuff = 0,
                MaceCrtDBuff = 0;
        }

        void ArmorPicsRefresh()
        {
            //армор
            comm_robe.Visibility = Visibility.Visible;
            ench_robe.Visibility = Visibility.Visible;
            rare_robe.Visibility = Visibility.Visible;

            comm_leather.Visibility = Visibility.Visible;
            ench_leather.Visibility = Visibility.Visible;
            rare_leather.Visibility = Visibility.Visible;

            comm_chain.Visibility = Visibility.Visible;
            ench_chain.Visibility = Visibility.Visible;
            rare_chain.Visibility = Visibility.Visible;

            comm_plate.Visibility = Visibility.Visible;
            ench_plate.Visibility = Visibility.Visible;
            rare_plate.Visibility = Visibility.Visible;          
        } 
        void RingPicsRefresh()
        {
            //кольца
            comm_ring.Visibility = Visibility.Visible;
            ench_ring.Visibility = Visibility.Visible;
            rare_ring.Visibility = Visibility.Visible;
        }
        void AmulPicsRefresh()
        {
            //амулеты
            comm_amul.Visibility = Visibility.Visible;
            ench_amul.Visibility = Visibility.Visible;
            rare_amul.Visibility = Visibility.Visible;
        }
        void HelmetPicsRefresh()
        {
            //шлемы
            comm_helmet.Visibility = Visibility.Visible;
            ench_helmet.Visibility = Visibility.Visible;
            rare_helmet.Visibility = Visibility.Visible;
        }
        void ShieldPicsRefresh()
        {
            //щиты
            comm_shield.Visibility = Visibility.Visible;
            ench_shield.Visibility = Visibility.Visible;
            rare_shield.Visibility = Visibility.Visible;
        }
        void WeaponPicsRefresh()
        {
            //оружки
            comm_wand.Visibility = Visibility.Visible;
            ench_wand.Visibility = Visibility.Visible;
            rare_wand.Visibility = Visibility.Visible;

            comm_dagg.Visibility = Visibility.Visible;
            ench_dagg.Visibility = Visibility.Visible;
            rare_dagg.Visibility = Visibility.Visible;

            comm_sword.Visibility = Visibility.Visible;
            ench_sword.Visibility = Visibility.Visible;
            rare_sword.Visibility = Visibility.Visible;

            comm_axe.Visibility = Visibility.Visible;
            ench_axe.Visibility = Visibility.Visible;
            rare_axe.Visibility = Visibility.Visible;

            comm_mace.Visibility = Visibility.Visible;
            ench_mace.Visibility = Visibility.Visible;
            rare_mace.Visibility = Visibility.Visible;
        }


        ////////////////////////////////////////////////////КЛИКИ ОЧКИ//////////////////////////////////////////////////

        private void ButtonStr(object sender, RoutedEventArgs e)
        {
            var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
            if (CharactersFind != null)
            {
                if (CharactersFind.Name == "Warrior")
                {
                    if (ExperienceBlock.Text != "")
                    {
                        if (Convert.ToInt32(ExperienceBlock.Text) > 0)
                        {
                            if (Convert.ToInt32(StrenghtBlock.Text) <= Convert.ToInt32(StrenghtMaxBlock.Text) - 1)
                            {
                                CharactersFind.Strenght += 1;
                                CharactersFind.Exp -= 1;
                            }
                            else
                            {
                                MessageBox.Show("Это максимум!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Опыт закончился((((");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нету опыта");
                    }
                    ExperienceBlock.Text = Convert.ToString(CharactersFind.Exp);
                    StrenghtBlock.Text = Convert.ToString(CharactersFind.Strenght);

                    int a = CharactersFind.Vitality * 2;
                    int b = CharactersFind.Strenght * 1;
                    int c = a + b;
                    HealthBlock.Text = Convert.ToString(c + MaceHBuff);
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Strenght * 1 + StaffPdamBuff + DaggerPdamBuff + SwordPdamBuff + AxePdamBuff + MacePdamBuff);
                }
                else if (CharactersFind.Name == "Rogue")
                {
                    if (ExperienceBlock.Text != "")
                    {
                        if (Convert.ToInt32(ExperienceBlock.Text) > 0)
                        {
                            if (Convert.ToInt32(StrenghtBlock.Text) <= Convert.ToInt32(StrenghtMaxBlock.Text) - 1)
                            {
                                CharactersFind.Strenght += 1;
                                CharactersFind.Exp -= 1;
                            }
                            else
                            {
                                MessageBox.Show("Это максимум!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Опыт закончился((((");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нету опыта");
                    }
                    ExperienceBlock.Text = Convert.ToString(CharactersFind.Exp);
                    StrenghtBlock.Text = Convert.ToString(CharactersFind.Strenght);

                    int a = CharactersFind.Vitality * 15 / 10;
                    int b = CharactersFind.Strenght * 5 / 10;
                    int c = a + b;
                    HealthBlock.Text = Convert.ToString(c + MaceHBuff);

                    int a1 = CharactersFind.Strenght * 5 / 10;
                    int b1 = CharactersFind.Dexterity * 5 / 10;
                    int c1 = a1 + b1;
                    PdamageBlock.Text = Convert.ToString(c1 + StaffPdamBuff + DaggerPdamBuff + SwordPdamBuff + AxePdamBuff + MacePdamBuff);
                }
                else if (CharactersFind.Name == "Wizard")
                {
                    if (ExperienceBlock.Text != "")
                    {
                        if (Convert.ToInt32(ExperienceBlock.Text) > 0)
                        {
                            if (Convert.ToInt32(StrenghtBlock.Text) <= Convert.ToInt32(StrenghtMaxBlock.Text) - 1)
                            {
                                CharactersFind.Strenght += 1;
                                CharactersFind.Exp -= 1;
                            }
                            else
                            {
                                MessageBox.Show("Это максимум!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Опыт закончился((((");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нету опыта");
                    }
                    ExperienceBlock.Text = Convert.ToString(CharactersFind.Exp);
                    StrenghtBlock.Text = Convert.ToString(CharactersFind.Strenght);

                    int a = CharactersFind.Vitality * 14 / 10;
                    int b = CharactersFind.Strenght * 2 / 10;
                    int c = a + b;
                    HealthBlock.Text = Convert.ToString(c + MaceHBuff);
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Strenght * 5 / 10 + StaffPdamBuff + DaggerPdamBuff + SwordPdamBuff + AxePdamBuff + MacePdamBuff);
                }
            }
            else
            {
                MessageBox.Show("Выберете персонажа");
            }
        }
        
        private void ButtonDex(object sender, RoutedEventArgs e)
        {
            var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
            if (CharactersFind != null)
            {
                if (CharactersFind.Name == "Warrior")
                {
                    if (ExperienceBlock.Text != "")
                    {
                        if (Convert.ToInt32(ExperienceBlock.Text) > 0)
                        {
                            if (Convert.ToInt32(DexterityBlock.Text) <= Convert.ToInt32(DexterityMaxBlock.Text) - 1)
                            {
                                CharactersFind.Dexterity += 1;
                                CharactersFind.Exp -= 1;
                            }
                            else
                            {
                                MessageBox.Show("Это максимум!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Опыт закончился((((");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нету опыта");
                    }
                    ExperienceBlock.Text = Convert.ToString(CharactersFind.Exp);
                    DexterityBlock.Text = Convert.ToString(CharactersFind.Dexterity);

                    ArmorBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1);
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Dexterity * 2 / 10 + StaffCrtCBuff + DaggerCrtCBuff + SwordCrtCBuff + AxeCrtCBuff + MaceCrtCBuff);
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1 / 10 + StaffCrtDBuff + DaggerCrtDBuff + SwordCrtDBuff + AxeCrtDBuff + MaceCrtDBuff);
                }
                else if (CharactersFind.Name == "Rogue")
                {
                    if (ExperienceBlock.Text != "")
                    {
                        if (Convert.ToInt32(ExperienceBlock.Text) > 0)
                        {
                            if (Convert.ToInt32(DexterityBlock.Text) <= Convert.ToInt32(DexterityMaxBlock.Text) - 1)
                            {
                                CharactersFind.Dexterity += 1;
                                CharactersFind.Exp -= 1;
                            }
                            else
                            {
                                MessageBox.Show("Это максимум!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Опыт закончился((((");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нету опыта");
                    }
                    ExperienceBlock.Text = Convert.ToString(CharactersFind.Exp);
                    DexterityBlock.Text = Convert.ToString(CharactersFind.Dexterity);

                    int a = CharactersFind.Vitality * 15 / 10;
                    int b = CharactersFind.Strenght * 5 / 10;
                    int c = a + b;
                    HealthBlock.Text = Convert.ToString(c + MaceHBuff);
                    ArmorBlock.Text = Convert.ToString(CharactersFind.Dexterity * 15 / 10);
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Dexterity * 2 / 10 + StaffCrtCBuff + StaffCrtCBuff + DaggerCrtCBuff + SwordCrtCBuff + AxeCrtCBuff + MaceCrtCBuff);
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1 / 10 + StaffCrtDBuff + StaffCrtDBuff + DaggerCrtDBuff + SwordCrtDBuff + AxeCrtDBuff + MaceCrtDBuff);
                }
                else if (CharactersFind.Name == "Wizard")
                {
                    if (ExperienceBlock.Text != "")
                    {
                        if (Convert.ToInt32(ExperienceBlock.Text) > 0)
                        {
                            if (Convert.ToInt32(DexterityBlock.Text) <= Convert.ToInt32(DexterityMaxBlock.Text) - 1)
                            {
                                CharactersFind.Dexterity += 1;
                                CharactersFind.Exp -= 1;
                            }
                            else
                            {
                                MessageBox.Show("Это максимум!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Опыт закончился((((");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нету опыта");
                    }
                    ExperienceBlock.Text = Convert.ToString(CharactersFind.Exp);
                    DexterityBlock.Text = Convert.ToString(CharactersFind.Dexterity);

                    ArmorBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1);
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Dexterity * 2 / 10 + StaffCrtCBuff + StaffCrtCBuff + StaffCrtCBuff + DaggerCrtCBuff + SwordCrtCBuff + AxeCrtCBuff + MaceCrtCBuff);
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Dexterity * 1 / 10 + StaffCrtDBuff + StaffCrtDBuff + StaffCrtDBuff + DaggerCrtDBuff + SwordCrtDBuff + AxeCrtDBuff + MaceCrtDBuff);
                }
            }
            else
            {
                MessageBox.Show("Выберете персонажа");
            }
        }

        private void ButtonInt(object sender, RoutedEventArgs e)
        {
            var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
            if (CharactersFind != null)
            {
                if (CharactersFind.Name == "Warrior")
                {
                    if (ExperienceBlock.Text != "")
                    {
                        if (Convert.ToInt32(ExperienceBlock.Text) > 0)
                        {
                            if (Convert.ToInt32(InteligenceBlock.Text) <= Convert.ToInt32(InteligenceMaxBlock.Text) - 1)
                            {
                                CharactersFind.Intelengence += 1;
                                CharactersFind.Exp -= 1;
                            }
                            else
                            {
                                MessageBox.Show("Это максимум!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Опыт закончился((((");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нету опыта");
                    }
                    ExperienceBlock.Text = Convert.ToString(CharactersFind.Exp);
                    InteligenceBlock.Text = Convert.ToString(CharactersFind.Intelengence);

                    //тут
                    CharactersFind.Mana = CharactersFind.Intelengence * 1;
                    ManaBlock.Text = Convert.ToString(CharactersFind.Mana + StaffMBuff);

                    CharactersFind.Mdamage = CharactersFind.Intelengence * 2 / 10;
                    MdamageBlock.Text = Convert.ToString(CharactersFind.Mdamage);

                    CharactersFind.Mdefense = CharactersFind.Intelengence * 5 / 10;
                    MdefenseBlock.Text = Convert.ToString(CharactersFind.Mdefense);
                }
                else if (CharactersFind.Name == "Rogue")
                {
                    if (ExperienceBlock.Text != "")
                    {
                        if (Convert.ToInt32(ExperienceBlock.Text) > 0)
                        {
                            if (Convert.ToInt32(InteligenceBlock.Text) <= Convert.ToInt32(InteligenceMaxBlock.Text) - 1)
                            {
                                CharactersFind.Intelengence += 1;
                                CharactersFind.Exp -= 1;
                            }
                            else
                            {
                                MessageBox.Show("Это максимум!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Опыт закончился((((");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нету опыта");
                    }
                    ExperienceBlock.Text = Convert.ToString(CharactersFind.Exp);
                    InteligenceBlock.Text = Convert.ToString(CharactersFind.Intelengence);

                    ManaBlock.Text = Convert.ToString(CharactersFind.Intelengence * 12 / 10 + StaffMBuff);
                    MdamageBlock.Text = Convert.ToString(CharactersFind.Intelengence * 2 / 10);
                    MdefenseBlock.Text = Convert.ToString(CharactersFind.Intelengence * 5 / 10);
                }
                else if (CharactersFind.Name == "Wizard")
                {
                    if (ExperienceBlock.Text != "")
                    {
                        if (Convert.ToInt32(ExperienceBlock.Text) > 0)
                        {
                            if (Convert.ToInt32(InteligenceBlock.Text) <= Convert.ToInt32(InteligenceMaxBlock.Text) - 1)
                            {
                                CharactersFind.Intelengence += 1;
                                CharactersFind.Exp -= 1;
                            }
                            else
                            {
                                MessageBox.Show("Это максимум!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Опыт закончился((((");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нету опыта");
                    }
                    ExperienceBlock.Text = Convert.ToString(CharactersFind.Exp);
                    InteligenceBlock.Text = Convert.ToString(CharactersFind.Intelengence);

                    ManaBlock.Text = Convert.ToString(CharactersFind.Intelengence * 15 / 10 + StaffMBuff);
                    MdamageBlock.Text = Convert.ToString(CharactersFind.Intelengence * 1);
                    MdefenseBlock.Text = Convert.ToString(CharactersFind.Intelengence * 1);
                }
            }
            else
            {
                MessageBox.Show("Выберете персонажа");
            }
        }

        private void ButtonVit(object sender, RoutedEventArgs e)
        {
            var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
            if (CharactersFind != null)
            {
                if (CharactersFind.Name == "Warrior")
                {
                    if (ExperienceBlock.Text != "")
                    {
                        if (Convert.ToInt32(ExperienceBlock.Text) > 0)
                        {
                            if (Convert.ToInt32(VitalityBlock.Text) <= Convert.ToInt32(VitalityMaxBlock.Text) - 1)
                            {
                                CharactersFind.Vitality += 1;
                                CharactersFind.Exp -= 1;
                            }
                            else
                            {
                                MessageBox.Show("Это максимум!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Опыт закончился((((");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нету опыта");
                    }
                    ExperienceBlock.Text = Convert.ToString(CharactersFind.Exp);
                    VitalityBlock.Text = Convert.ToString(CharactersFind.Vitality);
                    int a = CharactersFind.Vitality * 2;
                    int b = CharactersFind.Strenght * 1;
                    int c = a + b;
                    HealthBlock.Text = Convert.ToString(c + MaceHBuff);
                }
                else if (CharactersFind.Name == "Rogue")
                {
                    if (ExperienceBlock.Text != "")
                    {
                        if (Convert.ToInt32(ExperienceBlock.Text) > 0)
                        {
                            if (Convert.ToInt32(VitalityBlock.Text) <= Convert.ToInt32(VitalityMaxBlock.Text) - 1)
                            {
                                CharactersFind.Vitality += 1;
                                CharactersFind.Exp -= 1;
                            }
                            else
                            {
                                MessageBox.Show("Это максимум!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Опыт закончился((((");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нету опыта");
                    }
                    ExperienceBlock.Text = Convert.ToString(CharactersFind.Exp);
                    VitalityBlock.Text = Convert.ToString(CharactersFind.Vitality);
                    int a = CharactersFind.Vitality * 15 / 10;
                    int b = CharactersFind.Strenght * 5 / 10;
                    int c = a + b;
                    HealthBlock.Text = Convert.ToString(c + MaceHBuff);
                }
                else if (CharactersFind.Name == "Wizard")
                {
                    if (ExperienceBlock.Text != "")
                    {
                        if (Convert.ToInt32(ExperienceBlock.Text) > 0)
                        {
                            if (Convert.ToInt32(VitalityBlock.Text) <= Convert.ToInt32(VitalityMaxBlock.Text) - 1)
                            {
                                CharactersFind.Vitality += 1;
                                CharactersFind.Exp -= 1;
                            }
                            else
                            {
                                MessageBox.Show("Это максимум!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Опыт закончился((((");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нету опыта");
                    }
                    ExperienceBlock.Text = Convert.ToString(CharactersFind.Exp);
                    VitalityBlock.Text = Convert.ToString(CharactersFind.Vitality);
                    int a = CharactersFind.Vitality * 14 / 10;
                    int b = CharactersFind.Strenght * 2 / 10;
                    int c = a + b;
                    HealthBlock.Text = Convert.ToString(c + MaceHBuff);
                }
            }
            else
            {
                MessageBox.Show("Выберете персонажа");
            }
        }


        ////////////////////////////////////////////////////LOADED)))//////////////////////////////////////////////////
        

        ///////////////////////////////////////////////////КЛИКИ УРОВНИ////////////////////////////////////////////////

        static int[] Exp4Level = new int[] { 0, 1000, 3000, 6000, 10000, 15000, 21000};
        

        private void ButtonMin500(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(LevelBlock.Text) != 0)
            {
                if (Convert.ToInt32(ExperienceBlock.Text) > 0 && Convert.ToInt32(ExperienceBlock.Text) >= 500)
                {
                    var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
                    int a = CharactersFind.Exp -= 500;
                    ExperienceBlock.Text = a.ToString();
                    if (CharactersFind.Exp >= 0 && CharactersFind.Exp < 1000)
                    {
                        int b = CharactersFind.Level = 1;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 1000 && CharactersFind.Exp < 3000)
                    {
                        int b = CharactersFind.Level = 2;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 3000 && CharactersFind.Exp < 6000)
                    {
                        int b = CharactersFind.Level = 3;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 6000 && CharactersFind.Exp < 10000)
                    {
                        int b = CharactersFind.Level = 4;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 10000 && CharactersFind.Exp < 15000)
                    {
                        int b = CharactersFind.Level = 5;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 15000 && CharactersFind.Exp < 21000)
                    {
                        int b = CharactersFind.Level = 6;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 21000 && CharactersFind.Exp < 27000)
                    {
                        int b = CharactersFind.Level = 7;
                        LevelBlock.Text = b.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("У тебя и так мало, куда меньше то!");
                }
            }
            else
            {
                MessageBox.Show("Выберите персонажа");
            }
        }

        private void ButtonMin100(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(LevelBlock.Text) != 0)
            {
                if (Convert.ToInt32(ExperienceBlock.Text) > 0 && Convert.ToInt32(ExperienceBlock.Text) >= 100)
                {                  
                    var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
                    int a = CharactersFind.Exp -= 100;
                    ExperienceBlock.Text = a.ToString();
                    if (CharactersFind.Exp >= 0 && CharactersFind.Exp < 1000)
                    {
                        int b = CharactersFind.Level = 1;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 1000 && CharactersFind.Exp < 3000)
                    {
                        int b = CharactersFind.Level = 2;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 3000 && CharactersFind.Exp < 6000)
                    {
                        int b = CharactersFind.Level = 3;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 6000 && CharactersFind.Exp < 10000)
                    {
                        int b = CharactersFind.Level = 4;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 10000 && CharactersFind.Exp < 15000)
                    {
                        int b = CharactersFind.Level = 5;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 15000 && CharactersFind.Exp < 21000)
                    {
                        int b = CharactersFind.Level = 6;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 21000 && CharactersFind.Exp < 27000)
                    {
                        int b = CharactersFind.Level = 7;
                        LevelBlock.Text = b.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("У тебя и так мало, куда меньше то!");
                }
            }
            else
            {
                MessageBox.Show("Выберите персонажа");
            }
        }

        private void ButtomPlus50(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(LevelBlock.Text) != 0)
            {
                if (Convert.ToInt32(ExperienceBlock.Text) >= 0)
                {
                    var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
                    int a = CharactersFind.Exp += 50;
                    ExperienceBlock.Text = a.ToString();
                    if (CharactersFind.Exp >= 1000 && CharactersFind.Exp < 3000)
                    {
                        int b = CharactersFind.Level = 2;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 3000 && CharactersFind.Exp < 6000)
                    {
                        int b = CharactersFind.Level = 3;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 6000 && CharactersFind.Exp < 10000)
                    {
                        int b = CharactersFind.Level = 4;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 10000 && CharactersFind.Exp < 15000)
                    {
                        int b = CharactersFind.Level = 5;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 15000 && CharactersFind.Exp < 21000)
                    {
                        int b = CharactersFind.Level = 6;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 21000 && CharactersFind.Exp < 27000)
                    {
                        int b = CharactersFind.Level = 7;
                        LevelBlock.Text = b.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("У тебя и так мало, куда меньше то!");
                }                
            }
            else
            {
                MessageBox.Show("Выберите персонажа");
            }           
        }

        private void ButtomPlus100(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(LevelBlock.Text) != 0)
            {
                if (Convert.ToInt32(ExperienceBlock.Text) >= 0)
                {
                    var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
                    int a = CharactersFind.Exp += 100;
                    ExperienceBlock.Text = a.ToString();
                    if (CharactersFind.Exp >= 1000 && CharactersFind.Exp < 3000)
                    {
                        int b = CharactersFind.Level = 2;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 3000 && CharactersFind.Exp < 6000)
                    {
                        int b = CharactersFind.Level = 3;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 6000 && CharactersFind.Exp < 10000)
                    {
                        int b = CharactersFind.Level = 4;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 10000 && CharactersFind.Exp < 15000)
                    {
                        int b = CharactersFind.Level = 5;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 15000 && CharactersFind.Exp < 21000)
                    {
                        int b = CharactersFind.Level = 6;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 21000 && CharactersFind.Exp < 27000)
                    {
                        int b = CharactersFind.Level = 7;
                        LevelBlock.Text = b.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("У тебя и так мало, куда меньше то!");
                }
            }
            else
            {
                MessageBox.Show("Выберите персонажа");
            }
        }

        private void ButtomPlus500(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(LevelBlock.Text) != 0)
            {
                if (Convert.ToInt32(ExperienceBlock.Text) >= 0)
                {                   
                    var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));                    
                    int a = CharactersFind.Exp += 500;
                    ExperienceBlock.Text = a.ToString();
                    if(CharactersFind.Exp >= 1000 && CharactersFind.Exp < 3000)
                    {
                        int b = CharactersFind.Level = 2;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 3000 && CharactersFind.Exp < 6000)
                    {
                        int b = CharactersFind.Level = 3;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 6000 && CharactersFind.Exp < 10000)
                    {
                        int b = CharactersFind.Level = 4;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 10000 && CharactersFind.Exp < 15000)
                    {
                        int b = CharactersFind.Level = 5;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 15000 && CharactersFind.Exp < 21000)
                    {
                        int b = CharactersFind.Level = 6;
                        LevelBlock.Text = b.ToString();
                    }
                    if (CharactersFind.Exp >= 21000 && CharactersFind.Exp < 27000)
                    {
                        int b = CharactersFind.Level = 7;
                        LevelBlock.Text = b.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("У тебя и так мало, куда меньше то!");
                }
            }
            else
            {
                MessageBox.Show("Выберите персонажа");
            }

        }

        ///////////////////////////////////////////////////КНОПКИ ДЛЯ ИНВЕНТАРЯ////////////////////////////////////.///

        private void InventoryVIs2_Click(object sender, RoutedEventArgs e)
        {
            var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));           
            CanvasInventory.Visibility = Visibility.Collapsed;
            CanvasInventory213123.Visibility = Visibility.Collapsed; 
            InvMain.Visibility = Visibility.Collapsed;
            EqipentList.Items.Clear();
            foreach (var a in CharactersFind.Equipment)
            {
                EqipentList.Items.Add(a);
            }        
            //далее скрывается кнопка инвентаря, появляется кнопка назад и все заебись
        }

        private void InventoryVIs1_Click(object sender, RoutedEventArgs e)
        {
            var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
            if (CharactersFind != null)
            {
                CanvasInventory.Visibility = Visibility.Visible;
                CanvasInventory213123.Visibility = Visibility.Visible;
                InvMain.Visibility = Visibility.Visible;
                EqipentList.Items.Clear();
                foreach (var a in CharactersFind.Equipment)
                {
                    EqipentList.Items.Add(a);
                }
            }
            else
            {
                MessageBox.Show("Выберите персонажа");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            NavigationService.Navigate(mainPage);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        int StaffPdamBuff, StaffMBuff, StaffIntBuff, StaffCrtCBuff, StaffCrtDBuff;
        int DaggerPdamBuff, DaggerDexBuff, DaggerCrtCBuff, DaggerCrtDBuff;


        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("аффаввыа");
        }


        int SwordPdamBuff, SwordDexBuff, SwordStrBuff, SwordCrtCBuff, SwordCrtDBuff;
        int AxePdamBuff, AxeStrBuff, AxeCrtCBuff, AxeCrtDBuff;
        int MacePdamBuff, MaceStrBuff, MaceHBuff, MaceCrtCBuff, MaceCrtDBuff;

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void TypeList_Drop(object sender, DragEventArgs e)
        {
            
        }

        private void WeaponList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
            var WeaponFind = WeaponsList.Find(item => item.Name == Convert.ToString(WeaponList.SelectedItem));

            if (CharactersFind.Name == "Warrior")
            {
                if (WeaponFind.Name == "Dagger")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);

                    //пдам ап pdam up
                    DaggerPdamBuff += 10;
                    CharactersFind.Pdamage += DaggerPdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+10";

                    //декс ап
                    DaggerDexBuff += 50;
                    CharactersFind.MaxDexterity += DaggerDexBuff;
                    DexterityMaxBlock.Text = Convert.ToString(CharactersFind.MaxDexterity);
                    BonusBarDex.Visibility = Visibility.Visible;
                    BonusBarDex.Foreground = Brushes.Yellow;
                    BonusBarDex.Text = "+50";

                    //crtC ап
                    DaggerCrtCBuff += 60;
                    CharactersFind.Crtchanse += DaggerCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);
                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+60";

                    //сrtD ап
                    DaggerCrtDBuff += 70;
                    CharactersFind.Crtdamage += DaggerCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);
                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+70";
                    WarB();
                }
                else if (WeaponFind.Name == "Axe")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);

                    //пдам ап
                    AxePdamBuff += 40;
                    CharactersFind.Pdamage += AxePdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+40";

                    //стр ап
                    AxeStrBuff += 50;
                    CharactersFind.MaxStrenght += AxeStrBuff;
                    StrenghtMaxBlock.Text = Convert.ToString(CharactersFind.MaxStrenght);
                    BonusBarStr.Visibility = Visibility.Visible;
                    BonusBarStr.Foreground = Brushes.Yellow;
                    BonusBarStr.Text = "+50";

                    //cc ап
                    AxeCrtCBuff += 20;
                    CharactersFind.Crtchanse += AxeCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);
                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+20";

                    //сд ап
                    AxeCrtDBuff += 170;
                    CharactersFind.Crtdamage += AxeCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);
                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+170";
                    WarB();
                }
                else if (WeaponFind.Name == "Mace")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);

                    //пдам ап
                    MacePdamBuff += 40;
                    CharactersFind.Pdamage += MacePdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+40";

                    //стр ап
                    MaceStrBuff += 40;
                    CharactersFind.MaxStrenght += MaceStrBuff;
                    StrenghtMaxBlock.Text = Convert.ToString(CharactersFind.MaxStrenght);
                    BonusBarStr.Visibility = Visibility.Visible;
                    BonusBarStr.Foreground = Brushes.Yellow;
                    BonusBarStr.Text = "+40";

                    //хп ап
                    MaceHBuff += 30;
                    CharactersFind.Health += MaceHBuff;
                    HealthBlock.Text = Convert.ToString(CharactersFind.Health);
                    BonusBarH.Visibility = Visibility.Visible;
                    BonusBarH.Foreground = Brushes.Yellow;
                    BonusBarH.Text = "+30";

                    //сс ап
                    MaceCrtCBuff += 10;
                    CharactersFind.Crtchanse += MaceCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);
                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+10";

                    //сд ап
                    MaceCrtDBuff += 250;
                    CharactersFind.Crtdamage += MaceCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);
                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+250";
                    WarB();
                }
                else if (WeaponFind.Name == "Staff")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);
                    //пдам ап
                    StaffPdamBuff += 5;
                    CharactersFind.Pdamage += StaffPdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+5";

                    //мана ап
                    StaffMBuff += 100;
                    CharactersFind.Mana += StaffMBuff;
                    ManaBlock.Text = Convert.ToString(CharactersFind.Mana);

                    BonusBarM.Visibility = Visibility.Visible;
                    BonusBarM.Foreground = Brushes.Yellow;
                    BonusBarM.Text = "+100";

                    //инт ап
                    StaffIntBuff += 50;
                    CharactersFind.MaxIntelengence += StaffIntBuff;
                    InteligenceMaxBlock.Text = Convert.ToString(CharactersFind.MaxIntelengence);

                    BonusBarInt.Visibility = Visibility.Visible;
                    BonusBarInt.Foreground = Brushes.Yellow;
                    BonusBarInt.Text = "+50";

                    //крит шанс ап
                    StaffCrtCBuff += 5;
                    CharactersFind.Crtchanse += StaffCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);

                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+5";

                    //крит дамаг ап
                    StaffCrtDBuff += 300;
                    CharactersFind.Crtdamage += StaffCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);

                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+300";
                    WarB();
                }
                else if (WeaponFind.Name == "Sword")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);

                    //пдам ап
                    SwordPdamBuff += 20;
                    CharactersFind.Pdamage += SwordPdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+20";

                    //декс ап
                    SwordDexBuff += 30;
                    CharactersFind.MaxDexterity += SwordDexBuff;
                    DexterityMaxBlock.Text = Convert.ToString(CharactersFind.MaxDexterity);
                    BonusBarDex.Visibility = Visibility.Visible;
                    BonusBarDex.Foreground = Brushes.Yellow;
                    BonusBarDex.Text = "+30";

                    //стр ап
                    SwordStrBuff += 30;
                    CharactersFind.MaxStrenght += SwordStrBuff;
                    StrenghtMaxBlock.Text = Convert.ToString(CharactersFind.MaxStrenght);
                    BonusBarStr.Visibility = Visibility.Visible;
                    BonusBarStr.Foreground = Brushes.Yellow;
                    BonusBarStr.Text = "+30";

                    //сс ап
                    SwordCrtCBuff += 20;
                    CharactersFind.Crtchanse += SwordCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);
                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+20";

                    //сд ап
                    SwordCrtDBuff += 150;
                    CharactersFind.Crtdamage += SwordCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);
                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+150";
                    WarB();
                }
            }
            else if (CharactersFind.Name == "Rogue")
            {
                if (WeaponFind.Name == "Dagger")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);

                    //пдам ап
                    DaggerPdamBuff += 10;
                    CharactersFind.Pdamage += DaggerPdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+10";

                    //декс ап
                    DaggerDexBuff += 50;
                    CharactersFind.MaxDexterity += DaggerDexBuff;
                    DexterityMaxBlock.Text = Convert.ToString(CharactersFind.MaxDexterity);
                    BonusBarDex.Visibility = Visibility.Visible;
                    BonusBarDex.Foreground = Brushes.Yellow;
                    BonusBarDex.Text = "+50";

                    //crtC ап
                    DaggerCrtCBuff += 60;
                    CharactersFind.Crtchanse += DaggerCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);
                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+60";

                    //сrtD ап
                    DaggerCrtDBuff += 70;
                    CharactersFind.Crtdamage += DaggerCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);
                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+70";
                    RogB();
                }
                else if (WeaponFind.Name == "Axe")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);

                    //пдам ап
                    AxePdamBuff += 40;
                    CharactersFind.Pdamage += AxePdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+40";

                    //стр ап
                    AxeStrBuff += 50;
                    CharactersFind.MaxStrenght += AxeStrBuff;
                    StrenghtMaxBlock.Text = Convert.ToString(CharactersFind.MaxStrenght);
                    BonusBarStr.Visibility = Visibility.Visible;
                    BonusBarStr.Foreground = Brushes.Yellow;
                    BonusBarStr.Text = "+50";

                    //cc ап
                    AxeCrtCBuff += 20;
                    CharactersFind.Crtchanse += AxeCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);
                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+20";

                    //сд ап
                    AxeCrtDBuff += 170;
                    CharactersFind.Crtdamage += AxeCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);
                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+170";
                    RogB();
                }
                else if (WeaponFind.Name == "Mace")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);

                    //пдам ап
                    MacePdamBuff += 40;
                    CharactersFind.Pdamage += MacePdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+40";

                    //стр ап
                    MaceStrBuff += 40;
                    CharactersFind.MaxStrenght += MaceStrBuff;
                    StrenghtMaxBlock.Text = Convert.ToString(CharactersFind.MaxStrenght);
                    BonusBarStr.Visibility = Visibility.Visible;
                    BonusBarStr.Foreground = Brushes.Yellow;
                    BonusBarStr.Text = "+40";

                    //хп ап
                    MaceHBuff += 30;
                    CharactersFind.Health += MaceHBuff;
                    HealthBlock.Text = Convert.ToString(CharactersFind.Health);
                    BonusBarH.Visibility = Visibility.Visible;
                    BonusBarH.Foreground = Brushes.Yellow;
                    BonusBarH.Text = "+30";

                    //сс ап
                    MaceCrtCBuff += 10;
                    CharactersFind.Crtchanse += MaceCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);
                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+10";

                    //сд ап
                    MaceCrtDBuff += 250;
                    CharactersFind.Crtdamage += MaceCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);
                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+250";
                    RogB();
                }
                else if (WeaponFind.Name == "Staff")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);
                    //пдам ап
                    StaffPdamBuff += 5;
                    CharactersFind.Pdamage += StaffPdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+5";

                    //мана ап
                    StaffMBuff += 100;
                    CharactersFind.Mana += StaffMBuff;
                    ManaBlock.Text = Convert.ToString(CharactersFind.Mana);

                    BonusBarM.Visibility = Visibility.Visible;
                    BonusBarM.Foreground = Brushes.Yellow;
                    BonusBarM.Text = "+100";

                    //инт ап
                    StaffIntBuff += 50;
                    CharactersFind.MaxIntelengence += StaffIntBuff;
                    InteligenceMaxBlock.Text = Convert.ToString(CharactersFind.MaxIntelengence);

                    BonusBarInt.Visibility = Visibility.Visible;
                    BonusBarInt.Foreground = Brushes.Yellow;
                    BonusBarInt.Text = "+50";

                    //крит шанс ап
                    StaffCrtCBuff += 5;
                    CharactersFind.Crtchanse += StaffCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);

                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+5";

                    //крит дамаг ап
                    StaffCrtDBuff += 300;
                    CharactersFind.Crtdamage += StaffCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);

                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+300";
                    RogB();
                }
                else if (WeaponFind.Name == "Sword")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);

                    //пдам ап
                    SwordPdamBuff += 20;
                    CharactersFind.Pdamage += SwordPdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+20";

                    //декс ап
                    SwordDexBuff += 30;
                    CharactersFind.MaxDexterity += SwordDexBuff;
                    DexterityMaxBlock.Text = Convert.ToString(CharactersFind.MaxDexterity);
                    BonusBarDex.Visibility = Visibility.Visible;
                    BonusBarDex.Foreground = Brushes.Yellow;
                    BonusBarDex.Text = "+30";

                    //стр ап
                    SwordStrBuff += 30;
                    CharactersFind.MaxStrenght += SwordStrBuff;
                    StrenghtMaxBlock.Text = Convert.ToString(CharactersFind.MaxStrenght);
                    BonusBarStr.Visibility = Visibility.Visible;
                    BonusBarStr.Foreground = Brushes.Yellow;
                    BonusBarStr.Text = "+30";

                    //сс ап
                    SwordCrtCBuff += 20;
                    CharactersFind.Crtchanse += SwordCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);
                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+20";

                    //сд ап
                    SwordCrtDBuff += 150;
                    CharactersFind.Crtdamage += SwordCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);
                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+150";
                    RogB();
                }
            }
            else if (CharactersFind.Name == "Wizard")
            {
                if (WeaponFind.Name == "Dagger")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);

                    //пдам ап
                    DaggerPdamBuff += 10;
                    CharactersFind.Pdamage += DaggerPdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+10";

                    //декс ап
                    DaggerDexBuff += 50;
                    CharactersFind.MaxDexterity += DaggerDexBuff;
                    DexterityMaxBlock.Text = Convert.ToString(CharactersFind.MaxDexterity);
                    BonusBarDex.Visibility = Visibility.Visible;
                    BonusBarDex.Foreground = Brushes.Yellow;
                    BonusBarDex.Text = "+50";

                    //crtC ап
                    DaggerCrtCBuff += 60;
                    CharactersFind.Crtchanse += DaggerCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);
                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+60";

                    //сrtD ап
                    DaggerCrtDBuff += 70;
                    CharactersFind.Crtdamage += DaggerCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);
                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+70";
                    WizB();
                }
                else if (WeaponFind.Name == "Axe")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);

                    //пдам ап
                    AxePdamBuff += 40;
                    CharactersFind.Pdamage += AxePdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+40";

                    //стр ап
                    AxeStrBuff += 50;
                    CharactersFind.MaxStrenght += AxeStrBuff;
                    StrenghtMaxBlock.Text = Convert.ToString(CharactersFind.MaxStrenght);
                    BonusBarStr.Visibility = Visibility.Visible;
                    BonusBarStr.Foreground = Brushes.Yellow;
                    BonusBarStr.Text = "+50";

                    //cc ап
                    AxeCrtCBuff += 20;
                    CharactersFind.Crtchanse += AxeCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);
                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+20";

                    //сд ап
                    AxeCrtDBuff += 170;
                    CharactersFind.Crtdamage += AxeCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);
                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+170";
                    WizB();
                }
                else if (WeaponFind.Name == "Mace")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);

                    //пдам ап
                    MacePdamBuff += 40;
                    CharactersFind.Pdamage += MacePdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+40";

                    //стр ап
                    MaceStrBuff += 40;
                    CharactersFind.MaxStrenght += MaceStrBuff;
                    StrenghtMaxBlock.Text = Convert.ToString(CharactersFind.MaxStrenght);
                    BonusBarStr.Visibility = Visibility.Visible;
                    BonusBarStr.Foreground = Brushes.Yellow;
                    BonusBarStr.Text = "+40";

                    //хп ап
                    MaceHBuff += 30;
                    CharactersFind.Health += MaceHBuff;
                    HealthBlock.Text = Convert.ToString(CharactersFind.Health);
                    BonusBarH.Visibility = Visibility.Visible;
                    BonusBarH.Foreground = Brushes.Yellow;
                    BonusBarH.Text = "+30";

                    //сс ап
                    MaceCrtCBuff += 10;
                    CharactersFind.Crtchanse += MaceCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);
                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+10";

                    //сд ап
                    MaceCrtDBuff += 250;
                    CharactersFind.Crtdamage += MaceCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);
                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+250";
                    WizB();
                }
                else if (WeaponFind.Name == "Staff")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);
                    //пдам ап
                    StaffPdamBuff += 5;
                    CharactersFind.Pdamage += StaffPdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+5";

                    //мана ап
                    StaffMBuff += 100;
                    CharactersFind.Mana += StaffMBuff;
                    ManaBlock.Text = Convert.ToString(CharactersFind.Mana);

                    BonusBarM.Visibility = Visibility.Visible;
                    BonusBarM.Foreground = Brushes.Yellow;
                    BonusBarM.Text = "+100";

                    //инт ап
                    StaffIntBuff += 50;
                    CharactersFind.MaxIntelengence += StaffIntBuff;
                    InteligenceMaxBlock.Text = Convert.ToString(CharactersFind.MaxIntelengence);

                    BonusBarInt.Visibility = Visibility.Visible;
                    BonusBarInt.Foreground = Brushes.Yellow;
                    BonusBarInt.Text = "+50";

                    //крит шанс ап
                    StaffCrtCBuff += 5;
                    CharactersFind.Crtchanse += StaffCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);

                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+5";

                    //крит дамаг ап
                    StaffCrtDBuff += 300;
                    CharactersFind.Crtdamage += StaffCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);

                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+300";
                    WizB();
                }
                else if (WeaponFind.Name == "Sword")
                {
                    EqipentList.Items.Add(WeaponFind.Name);
                    CharactersFind.Equipment.Add(WeaponFind.Name);

                    //пдам ап
                    SwordPdamBuff += 20;
                    CharactersFind.Pdamage += SwordPdamBuff;
                    PdamageBlock.Text = Convert.ToString(CharactersFind.Pdamage);
                    BonusBarPdam.Visibility = Visibility.Visible;
                    BonusBarPdam.Foreground = Brushes.Yellow;
                    BonusBarPdam.Text = "+20";

                    //декс ап
                    SwordDexBuff += 30;
                    CharactersFind.MaxDexterity += SwordDexBuff;
                    DexterityMaxBlock.Text = Convert.ToString(CharactersFind.MaxDexterity);
                    BonusBarDex.Visibility = Visibility.Visible;
                    BonusBarDex.Foreground = Brushes.Yellow;
                    BonusBarDex.Text = "+30";

                    //стр ап
                    SwordStrBuff += 30;
                    CharactersFind.MaxStrenght += SwordStrBuff;
                    StrenghtMaxBlock.Text = Convert.ToString(CharactersFind.MaxStrenght);
                    BonusBarStr.Visibility = Visibility.Visible;
                    BonusBarStr.Foreground = Brushes.Yellow;
                    BonusBarStr.Text = "+30";

                    //сс ап
                    SwordCrtCBuff += 20;
                    CharactersFind.Crtchanse += SwordCrtCBuff;
                    CrtchanseBlock.Text = Convert.ToString(CharactersFind.Crtchanse);
                    BonusBarCrtC.Visibility = Visibility.Visible;
                    BonusBarCrtC.Foreground = Brushes.Yellow;
                    BonusBarCrtC.Text = "+20";

                    //сд ап
                    SwordCrtDBuff += 150;
                    CharactersFind.Crtdamage += SwordCrtDBuff;
                    CrtdamageBlock.Text = Convert.ToString(CharactersFind.Crtdamage);
                    BonusBarCrtD.Visibility = Visibility.Visible;
                    BonusBarCrtD.Foreground = Brushes.Yellow;
                    BonusBarCrtD.Text = "+150";
                    WizB();
                }
            }
        }

        private void ArmorssList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CharactersFind = Characters.Find(item => item.Name == Convert.ToString(ClassList.SelectedItem));
            var ArmorFind = ArmorList.Find(item => item.Name == Convert.ToString(ArmorssList.SelectedItem));
            //if (EqipentList.Items.)
            //{
                if (CharactersFind.Name == "Warrior")
                {
                    if (ArmorFind.Name == "LightHelmet")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "MiddleHelmet")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "HeavyHelmet")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "LightChesplate")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "MiddleChesplate")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "HeavyChesplate")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                }
                else if (CharactersFind.Name == "Rogue")
                {
                    if (ArmorFind.Name == "LightHelmet")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "MiddleHelmet")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "HeavyHelmet")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "LightChesplate")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "MiddleChesplate")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "HeavyChesplate")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                }
                else if (CharactersFind.Name == "Wizard")
                {
                    if (ArmorFind.Name == "LightHelmet")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "MiddleHelmet")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "HeavyHelmet")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "LightChesplate")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "MiddleChesplate")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                    else if (ArmorFind.Name == "HeavyChesplate")
                    {
                        EqipentList.Items.Add(ArmorFind.Name);
                        CharactersFind.Equipment.Add(ArmorFind.Name);
                    }
                }
            //}
        }




        /////////////////////////////////////////////////КНОПКИ ИНВЕНТАРЬ///////////////////////////////////////////////////////////// 

        //////////////////////////////////////////////////////////////армор/////////////////////////////////////////////////////////
        private void comm_robe_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ArmorPicsRefresh();
            comm_robe.Visibility = Visibility.Collapsed;
            def_chesplate.Background = comm_robe.Background;
        }
        private void ench_robe_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ArmorPicsRefresh();
            ench_robe.Visibility = Visibility.Collapsed;
            def_chesplate.Background = ench_robe.Background;
        }

        private void rare_robe_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ArmorPicsRefresh();
            rare_robe.Visibility = Visibility.Collapsed;
            def_chesplate.Background = rare_robe.Background;
        }

        private void comm_chain_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ArmorPicsRefresh();
            comm_chain.Visibility = Visibility.Collapsed;
            def_chesplate.Background = comm_chain.Background;
        }

        private void ench_chain_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ArmorPicsRefresh();
            ench_chain.Visibility = Visibility.Collapsed;
            def_chesplate.Background = ench_chain.Background;
        }

        private void rare_chain_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ArmorPicsRefresh();
            rare_chain.Visibility = Visibility.Collapsed;
            def_chesplate.Background = rare_chain.Background;
        }

        private void comm_plate_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ArmorPicsRefresh();
            comm_plate.Visibility = Visibility.Collapsed;
            def_chesplate.Background = comm_plate.Background;
        }

        private void ench_plate_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ArmorPicsRefresh();
            ench_plate.Visibility = Visibility.Collapsed;
            def_chesplate.Background = ench_plate.Background;
        }

        private void rare_plate_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ArmorPicsRefresh();
            rare_plate.Visibility = Visibility.Collapsed;
            def_chesplate.Background = rare_plate.Background;
        }

        private void rare_leather_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ArmorPicsRefresh();
            rare_leather.Visibility = Visibility.Collapsed;
            def_chesplate.Background = rare_leather.Background;
        }

        private void ench_leather_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ArmorPicsRefresh();
            ench_leather.Visibility = Visibility.Collapsed;
            def_chesplate.Background = ench_leather.Background;
        }

        private void comm_leather_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ArmorPicsRefresh();
            comm_leather.Visibility = Visibility.Collapsed;
            def_chesplate.Background = comm_leather.Background;
        }


        ////////////////////////////////////////////////////////////////кольца//////////////////////////////////////////////////////
        private void rare_ring_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RingPicsRefresh();
            rare_ring.Visibility = Visibility.Collapsed;
            def_ring.Background = rare_ring.Background;

        }

        private void ench_ring_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RingPicsRefresh();
            ench_ring.Visibility = Visibility.Collapsed;
            def_ring.Background = ench_ring.Background;
        }

        private void comm_ring_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RingPicsRefresh();
            comm_ring.Visibility = Visibility.Collapsed;
            def_ring.Background = comm_ring.Background;
        }


        /////////////////////////////////////////////////////////////////амулеты////////////////////////////////////////////////
        private void comm_amul_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AmulPicsRefresh();
            comm_amul.Visibility = Visibility.Collapsed;
            def_amul.Background = comm_amul.Background;
        }

        private void ench_amul_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AmulPicsRefresh();
            ench_amul.Visibility = Visibility.Collapsed;
            def_amul.Background = ench_amul.Background;
        }

        private void rare_amul_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AmulPicsRefresh();
            rare_amul.Visibility = Visibility.Collapsed;
            def_amul.Background = rare_amul.Background;
        }


        ////////////////////////////////////////////////////////////////шлема/////////////////////////////////////////////////
        private void comm_helmet_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HelmetPicsRefresh();
            comm_helmet.Visibility = Visibility.Collapsed;
            def_helmet.Background = comm_helmet.Background;
        }

        private void ench_helmet_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HelmetPicsRefresh();
            ench_helmet.Visibility = Visibility.Collapsed;
            def_helmet.Background = ench_helmet.Background;
        }

        private void rare_helmet_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HelmetPicsRefresh();
            rare_helmet.Visibility = Visibility.Collapsed;
            def_helmet.Background = rare_helmet.Background;
        }

        //щиты
        private void comm_shield_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (def_shield.Background == def_none.Background)
            {
                MessageBox.Show("Недоступно");
            }
            else
            {
                ShieldPicsRefresh();
                comm_shield.Visibility = Visibility.Collapsed;
                def_shield.Background = comm_shield.Background;
            }
        }

        private void ench_shield_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (def_shield.Background == def_none.Background)
            {
                MessageBox.Show("Недоступно");
            }
            else
            {
                ShieldPicsRefresh();
                ench_shield.Visibility = Visibility.Collapsed;
                def_shield.Background = ench_shield.Background;
            }
        }

        private void rare_shield_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (def_shield.Background == def_none.Background)
            {
                MessageBox.Show("Недоступно");
            }
            else
            {
                ShieldPicsRefresh();
                rare_shield.Visibility = Visibility.Collapsed;
                def_shield.Background = rare_shield.Background;
            }
        }

        ///////////////////////////////////////////////////////////оружки одна рука//////////////////////////////////////////
        private void comm_wand_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            comm_wand.Visibility = Visibility.Collapsed;
            def_onehand.Background = comm_wand.Background;
            def_twohand.Background = def_none.Background;
            def_shield.Background = none_def_shield1337.Background;
        }

        private void ench_wand_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            ench_wand.Visibility = Visibility.Collapsed;
            def_onehand.Background = ench_wand.Background;
            def_twohand.Background = def_none.Background;
            def_shield.Background = none_def_shield1337.Background;
        }

        private void rare_wand_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            rare_wand.Visibility = Visibility.Collapsed;
            def_onehand.Background = rare_wand.Background;
            def_twohand.Background = def_none.Background;
            def_shield.Background = none_def_shield1337.Background;
        } 

        private void comm_sword_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            comm_sword.Visibility = Visibility.Collapsed;
            def_onehand.Background = comm_sword.Background;
            def_twohand.Background = def_none.Background;
            def_shield.Background = none_def_shield1337.Background;
        }

        private void ench_sword_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            ench_sword.Visibility = Visibility.Collapsed;
            def_onehand.Background = ench_sword.Background;
            def_twohand.Background = def_none.Background;
            def_shield.Background = none_def_shield1337.Background;
        }

        private void rare_sword_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            rare_sword.Visibility = Visibility.Collapsed;
            def_onehand.Background = rare_sword.Background;
            def_twohand.Background = def_none.Background;
            def_shield.Background = none_def_shield1337.Background;
        }

        private void comm_axe_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            comm_axe.Visibility = Visibility.Collapsed;
            def_onehand.Background = comm_axe.Background;
            def_twohand.Background = def_none.Background;
            def_shield.Background = none_def_shield1337.Background;
        }

        private void ench_axe_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            ench_axe.Visibility = Visibility.Collapsed;
            def_onehand.Background = ench_axe.Background;
            def_twohand.Background = def_none.Background;
            def_shield.Background = none_def_shield1337.Background;
        }

        private void rare_axe_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            rare_axe.Visibility = Visibility.Collapsed;
            def_onehand.Background = rare_axe.Background;
            def_twohand.Background = def_none.Background;
            def_shield.Background = none_def_shield1337.Background;

        }
        private void comm_mace_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            comm_mace.Visibility = Visibility.Collapsed;
            def_onehand.Background = comm_mace.Background;
            def_twohand.Background = def_none.Background;
            def_shield.Background = none_def_shield1337.Background;
        }

        private void ench_mace_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            ench_mace.Visibility = Visibility.Collapsed;
            def_onehand.Background = ench_mace.Background;
            def_twohand.Background = def_none.Background;
            def_shield.Background = none_def_shield1337.Background;
        }

        private void rare_mace_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            rare_mace.Visibility = Visibility.Collapsed;
            def_onehand.Background = rare_mace.Background;
            def_twohand.Background = def_none.Background;
            def_shield.Background = none_def_shield1337.Background;
        }

        ///////////////////////////////////////////////////////////////оружки две руки///////////////////////////////////////////////////

        private void comm_wand_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            comm_wand.Visibility = Visibility.Collapsed;
            def_twohand.Background = comm_wand.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void ench_wand_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            ench_wand.Visibility = Visibility.Collapsed;
            def_twohand.Background = ench_wand.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void rare_wand_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            rare_wand.Visibility = Visibility.Collapsed;
            def_twohand.Background = rare_wand.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void comm_dagg_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            comm_dagg.Visibility = Visibility.Collapsed;
            def_twohand.Background = comm_dagg.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void ench_dagg_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            ench_dagg.Visibility = Visibility.Collapsed;
            def_twohand.Background = ench_dagg.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void rare_dagg_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            rare_dagg.Visibility = Visibility.Collapsed;
            def_twohand.Background = rare_dagg.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void comm_sword_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            comm_sword.Visibility = Visibility.Collapsed;
            def_twohand.Background = comm_sword.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void ench_sword_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            ench_sword.Visibility = Visibility.Collapsed;
            def_twohand.Background = ench_sword.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void rare_sword_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            rare_sword.Visibility = Visibility.Collapsed;
            def_twohand.Background = rare_sword.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void comm_axe_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            comm_axe.Visibility = Visibility.Collapsed;
            def_twohand.Background = comm_axe.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void ench_axe_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            ench_axe.Visibility = Visibility.Collapsed;
            def_twohand.Background = ench_axe.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void rare_axe_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            rare_axe.Visibility = Visibility.Collapsed;
            def_twohand.Background = rare_axe.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void comm_mace_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            comm_mace.Visibility = Visibility.Collapsed;
            def_twohand.Background = comm_mace.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void ench_mace_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            ench_mace.Visibility = Visibility.Collapsed;
            def_twohand.Background = ench_mace.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }

        private void rare_mace_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WeaponPicsRefresh();
            rare_mace.Visibility = Visibility.Collapsed;
            def_twohand.Background = rare_mace.Background;
            def_shield.Background = def_none.Background;
            def_onehand.Background = def_none.Background;
            ShieldPicsRefresh();
        }


        //////////////////////////////////////////////////////////УДАЛЕНИЕ//////////////////////////////////////////////////
        //////////////////////////////////////////////////////////изи///////////////////////////////////////////////////////
        private void def_helmet_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            def_helmet.Background = none_def_shield1337.Background;
            HelmetPicsRefresh();
        }

        private void def_chesplate_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            def_chesplate.Background = none_def_shield1337.Background;
            ArmorPicsRefresh();
        }

        private void def_ring_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            def_ring.Background = none_def_shield1337.Background;
            RingPicsRefresh();
        }

        private void def_amul_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            def_amul.Background = none_def_shield1337.Background;
            AmulPicsRefresh();
        }

        //////////////////////////////////////////////////////////неизи/////////////////////////////////////////////////////
        private void def_shield_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (def_shield.Background == def_none.Background)
            {
                MessageBox.Show("Тут и так ничего нету)))");
            }
            else
            {
                def_shield.Background = none_def_shield1337.Background;
                ShieldPicsRefresh();
            }
        }

        private void def_onehand_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (def_onehand.Background == def_none.Background)
            {
                MessageBox.Show("Тут и так ничего нету)))");
            }
            else
            {
                def_onehand.Background = none_def_shield1337.Background;
                def_twohand.Background = none_def_shield1337.Background;
                WeaponPicsRefresh(); 
            }
        }

        private void def_twohand_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (def_twohand.Background == def_none.Background)
            {
                MessageBox.Show("Тут и так ничего нету)))");
            }
            else
            {
                def_twohand.Background = none_def_shield1337.Background;
                def_onehand.Background = none_def_shield1337.Background;
                def_shield.Background = none_def_shield1337.Background;
                WeaponPicsRefresh();
            }
        }
    }
}   

