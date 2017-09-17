using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using LPCallouts.Internals;
//
using LSPD_First_Response.Mod.API;
using Rage;
using RAGENativeUI;
using RAGENativeUI.Elements;

namespace LPCallouts.Menu
{
    public static class LPCMenu
    {
        private static UIMenu _mainMenu;
        private static UIMenu _departments;
        private static UIMenu _settings;
        private static MenuPool _menuPool;
        private static UIMenuItem _navtodeptarments;
        private static UIMenuItem _navtosettings;
        private static UIMenuCheckboxItem _enable_radius;
        private static UIMenuCheckboxItem _dept01;
        private static UIMenuCheckboxItem _dept02;
        private static UIMenuCheckboxItem _dept03;
        private static UIMenuCheckboxItem _dept04;
        private static UIMenuCheckboxItem _dept05;
        private static UIMenuCheckboxItem _dept06;
        private static Blip _userblip;

        private static int _selected_dept;

        public static void Main()
        {
            _menuPool = new MenuPool();
            _mainMenu = new UIMenu("LPCallouts Menu", "Select your item");
            _menuPool.Add(_mainMenu);

            _departments = new UIMenu("Jurisdiction", "Select your Jurisdiction");
            _menuPool.Add(_departments);

            _settings = new UIMenu("Settings", "Show settings");
            _menuPool.Add(_settings);

            _mainMenu.AddItem(_navtodeptarments = new UIMenuItem("Active Jurisdiction"));
            _mainMenu.AddItem(_navtosettings = new UIMenuItem("Settings"));

            _mainMenu.BindMenuToItem(_departments, _navtodeptarments);
            _departments.ParentMenu = _mainMenu;

            _mainMenu.BindMenuToItem(_settings, _navtosettings);
            _settings.ParentMenu = _mainMenu;

            #region initial jurisdiction settings
            switch (GameHandler.ini_department)
            {
                case 1:
                    _dept01 = new UIMenuCheckboxItem("~y~" + GameHandler._dept_lspd, true);
                    _dept02 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lssd, false);
                    _dept03 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lscs, false);
                    _dept04 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_bcso, false);
                    _dept05 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_sahp, false);
                    _dept06 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_sapr, false);
                    _dept01.Enabled = false;
                    _dept02.Enabled = true;
                    _dept03.Enabled = true;
                    _dept04.Enabled = true;
                    _dept05.Enabled = true;
                    _dept06.Enabled = true;
                    GameHandler._dialog_dept = GameHandler._dept_lspd;
                    break;
                case 2:
                    _dept01 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lspd, false);
                    _dept02 = new UIMenuCheckboxItem("~y~" + GameHandler._dept_lssd, true);
                    _dept03 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lscs, false);
                    _dept04 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_bcso, false);
                    _dept05 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_sahp, false);
                    _dept06 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_sapr, false);
                    _dept01.Enabled = true;
                    _dept02.Enabled = false;
                    _dept03.Enabled = true;
                    _dept04.Enabled = true;
                    _dept05.Enabled = true;
                    _dept06.Enabled = true;
                    GameHandler._dialog_dept = GameHandler._dept_lssd;
                    break;
                case 3:
                    _dept01 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lspd, false);
                    _dept02 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lssd, false);
                    _dept03 = new UIMenuCheckboxItem("~y~" + GameHandler._dept_lscs, true);
                    _dept04 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_bcso, false);
                    _dept05 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_sahp, false);
                    _dept06 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_sapr, false);
                    _dept01.Enabled = true;
                    _dept02.Enabled = true;
                    _dept03.Enabled = false;
                    _dept04.Enabled = true;
                    _dept05.Enabled = true;
                    _dept06.Enabled = true;
                    GameHandler._dialog_dept = GameHandler._dept_lscs;
                    break;
                case 4:
                    _dept01 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lspd, false);
                    _dept02 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lssd, false);
                    _dept03 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lscs, false);
                    _dept04 = new UIMenuCheckboxItem("~y~" + GameHandler._dept_bcso, true);
                    _dept05 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_sahp, false);
                    _dept06 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_sapr, false);
                    _dept01.Enabled = true;
                    _dept02.Enabled = true;
                    _dept03.Enabled = true;
                    _dept04.Enabled = false;
                    _dept05.Enabled = true;
                    _dept06.Enabled = true;
                    GameHandler._dialog_dept = GameHandler._dept_bcso;
                    break;
                case 5:
                    _dept01 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lspd, false);
                    _dept02 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lssd, false);
                    _dept03 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lscs, false);
                    _dept04 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_bcso, false);
                    _dept05 = new UIMenuCheckboxItem("~y~" + GameHandler._dept_sahp, true);
                    _dept06 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_sapr, false);
                    _dept01.Enabled = true;
                    _dept02.Enabled = true;
                    _dept03.Enabled = true;
                    _dept04.Enabled = true;
                    _dept05.Enabled = false;
                    _dept06.Enabled = true;
                    GameHandler._dialog_dept = GameHandler._dept_sahp;
                    break;
                case 6:
                    _dept01 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lspd, false);
                    _dept02 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lssd, false);
                    _dept03 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_lscs, false);
                    _dept04 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_bcso, false);
                    _dept05 = new UIMenuCheckboxItem("~c~" + GameHandler._dept_sahp, false);
                    _dept06 = new UIMenuCheckboxItem("~y~" + GameHandler._dept_sapr, true);
                    _dept01.Enabled = true;
                    _dept02.Enabled = true;
                    _dept03.Enabled = true;
                    _dept04.Enabled = true;
                    _dept05.Enabled = true;
                    _dept06.Enabled = false;
                    GameHandler._dialog_dept = GameHandler._dept_sapr;
                    break;
            }
            #endregion initial jurisdiction setting

            _departments.AddItem(_dept01);
            _departments.AddItem(_dept02);
            _departments.AddItem(_dept03);
            _departments.AddItem(_dept04);
            _departments.AddItem(_dept05);
            _departments.AddItem(_dept06);

            _enable_radius = new UIMenuCheckboxItem("Show Callout Spawn Radius", false);
            _settings.AddItem(_enable_radius);

            _mainMenu.RefreshIndex();
            _departments.RefreshIndex();
            _settings.RefreshIndex();

            _mainMenu.OnItemSelect += OnItemSelect;
            _departments.OnCheckboxChange += _departments_OnCheckboxChange;
            _settings.OnCheckboxChange += _settings_OnCheckboxChange;

            _mainMenu.MouseControlsEnabled = false;
            _mainMenu.AllowCameraMovement = true;
            _departments.MouseControlsEnabled = false;
            _departments.AllowCameraMovement = true;
            _settings.MouseControlsEnabled = false;
            _settings.AllowCameraMovement = true;
            MenuLogic();
        }

        public static void OnItemSelect(UIMenu sender, UIMenuItem seletedItem, int index)
        {
            if (sender == _mainMenu)
            {

            }
        }

        public static void _departments_OnCheckboxChange(UIMenu sender, UIMenuCheckboxItem checkbox, bool Checked)
        {
            if (sender == _departments && checkbox == _dept01)
            {
                _selected_dept = 1;
                _dept02.Checked = false;
                _dept03.Checked = false;
                _dept04.Checked = false;
                _dept05.Checked = false;
                _dept06.Checked = false;
                _dept01.Text = "~y~" + GameHandler._dept_lspd;
                _dept02.Text = "~c~" + GameHandler._dept_lssd;
                _dept03.Text = "~c~" + GameHandler._dept_lscs;
                _dept04.Text = "~c~" + GameHandler._dept_bcso;
                _dept05.Text = "~c~" + GameHandler._dept_sahp;
                _dept06.Text = "~c~" + GameHandler._dept_sapr;
                _dept01.Enabled = false;
                _dept02.Enabled = true;
                _dept03.Enabled = true;
                _dept04.Enabled = true;
                _dept05.Enabled = true;
                _dept06.Enabled = true;
                GameHandler._dialog_dept = GameHandler._dept_lspd;
            }
            else if (sender == _departments && checkbox == _dept02)
            {
                _selected_dept = 2;
                _dept01.Checked = false;
                _dept03.Checked = false;
                _dept04.Checked = false;
                _dept05.Checked = false;
                _dept06.Checked = false;
                _dept01.Text = "~c~" + GameHandler._dept_lspd;
                _dept02.Text = "~y~" + GameHandler._dept_lssd;
                _dept03.Text = "~c~" + GameHandler._dept_lscs;
                _dept04.Text = "~c~" + GameHandler._dept_bcso;
                _dept05.Text = "~c~" + GameHandler._dept_sahp;
                _dept06.Text = "~c~" + GameHandler._dept_sapr;
                _dept01.Enabled = true;
                _dept02.Enabled = false;
                _dept03.Enabled = true;
                _dept04.Enabled = true;
                _dept05.Enabled = true;
                _dept06.Enabled = true;
                GameHandler._dialog_dept = GameHandler._dept_lssd;
            }
            else if (sender == _departments && checkbox == _dept03)
            {
                _selected_dept = 3;
                _dept01.Checked = false;
                _dept02.Checked = false;
                _dept04.Checked = false;
                _dept05.Checked = false;
                _dept06.Checked = false;
                _dept01.Text = "~c~" + GameHandler._dept_lspd;
                _dept02.Text = "~c~" + GameHandler._dept_lssd;
                _dept03.Text = "~y~" + GameHandler._dept_lscs;
                _dept04.Text = "~c~" + GameHandler._dept_bcso;
                _dept05.Text = "~c~" + GameHandler._dept_sahp;
                _dept06.Text = "~c~" + GameHandler._dept_sapr;
                _dept01.Enabled = true;
                _dept02.Enabled = true;
                _dept03.Enabled = false;
                _dept04.Enabled = true;
                _dept05.Enabled = true;
                _dept06.Enabled = true;
                GameHandler._dialog_dept = GameHandler._dept_lscs;
            }
            else if (sender == _departments && checkbox == _dept04)
            {
                _selected_dept = 4;
                _dept01.Checked = false;
                _dept02.Checked = false;
                _dept03.Checked = false;
                _dept05.Checked = false;
                _dept06.Checked = false;
                _dept01.Text = "~c~" + GameHandler._dept_lspd;
                _dept02.Text = "~c~" + GameHandler._dept_lssd;
                _dept03.Text = "~c~" + GameHandler._dept_lscs;
                _dept04.Text = "~y~" + GameHandler._dept_bcso;
                _dept05.Text = "~c~" + GameHandler._dept_sahp;
                _dept06.Text = "~c~" + GameHandler._dept_sapr;
                _dept01.Enabled = true;
                _dept02.Enabled = true;
                _dept03.Enabled = true;
                _dept04.Enabled = false;
                _dept05.Enabled = true;
                _dept06.Enabled = true;
                GameHandler._dialog_dept = GameHandler._dept_bcso;
            }
            else if (sender == _departments && checkbox == _dept05)
            {
                _selected_dept = 5;
                _dept01.Checked = false;
                _dept02.Checked = false;
                _dept03.Checked = false;
                _dept04.Checked = false;
                _dept06.Checked = false;
                _dept01.Text = "~c~" + GameHandler._dept_lspd;
                _dept02.Text = "~c~" + GameHandler._dept_lssd;
                _dept03.Text = "~c~" + GameHandler._dept_lscs;
                _dept04.Text = "~c~" + GameHandler._dept_bcso;
                _dept05.Text = "~y~" + GameHandler._dept_sahp;
                _dept06.Text = "~c~" + GameHandler._dept_sapr;
                _dept01.Enabled = true;
                _dept02.Enabled = true;
                _dept03.Enabled = true;
                _dept04.Enabled = true;
                _dept05.Enabled = false;
                _dept06.Enabled = true;
                GameHandler._dialog_dept = GameHandler._dept_sahp;
            }
            else if (sender == _departments && checkbox == _dept06)
            {
                _selected_dept = 6;
                _dept01.Checked = false;
                _dept02.Checked = false;
                _dept03.Checked = false;
                _dept04.Checked = false;
                _dept05.Checked = false;
                _dept01.Text = "~c~" + GameHandler._dept_lspd;
                _dept02.Text = "~c~" + GameHandler._dept_lssd;
                _dept03.Text = "~c~" + GameHandler._dept_lscs;
                _dept04.Text = "~c~" + GameHandler._dept_bcso;
                _dept05.Text = "~c~" + GameHandler._dept_sahp;
                _dept06.Text = "~y~" + GameHandler._dept_sapr;
                _dept01.Enabled = true;
                _dept02.Enabled = true;
                _dept03.Enabled = true;
                _dept04.Enabled = true;
                _dept05.Enabled = true;
                _dept06.Enabled = false;
                GameHandler._dialog_dept = GameHandler._dept_sapr;
            }
            GameHandler.WriteIniValue(_selected_dept);
            Functions.PlayScannerAudio("REPORT_RESPONSE_COPY_01 DIV_" + GameHandler.ini_division + " " + GameHandler.ini_unittype + " BEAT_" + GameHandler.ini_beat + " LPC_IS DIV_10 DIV_08");
        }

        private static void _settings_OnCheckboxChange(UIMenu sender, UIMenuCheckboxItem checkbox, bool Checked)
        {
            if (sender == _settings && checkbox == _enable_radius)
            {
                if (_userblip.Exists())
                {
                    _userblip.Delete();
                    _enable_radius.Checked = false;
                    _enable_radius.Text = "~c~Show Callout Spawn Radius";
                }
                else
                {
                    _enable_radius.Checked = true;
                    _enable_radius.Text = "~y~Show Callout Spawn Radius";
                    _userblip = new Blip(Game.LocalPlayer.Character.Position, GameHandler.ini_radius);
                    _userblip.Alpha = 0.3f;
                    _userblip.Color = System.Drawing.Color.PapayaWhip;
                }
            }
        }

        public static void MenuLogic()
        {
            GameFiber.StartNew(delegate
            {
                while (true)
                {
                    GameFiber.Yield();
                    if(GameHandler.ini_menu_mod != Keys.None)
                    {
                        if (Game.IsKeyDown(GameHandler.ini_menu) && Game.IsKeyDownRightNow(GameHandler.ini_menu_mod) && !_menuPool.IsAnyMenuOpen())
                        {
                            _mainMenu.Visible = !_mainMenu.Visible;
                        }
                    }
                    else
                    {
                        if (Game.IsKeyDown(GameHandler.ini_menu) && !_menuPool.IsAnyMenuOpen())
                        {
                            _mainMenu.Visible = !_mainMenu.Visible;
                        }
                    }
                    _menuPool.ProcessMenus();
                }
            }, "Menu Logic");
        }
    }
}
