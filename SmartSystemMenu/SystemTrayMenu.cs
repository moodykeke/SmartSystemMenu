﻿using System.Drawing;
using System.Windows.Forms;

namespace SmartSystemMenu
{
    class SystemTrayMenu
    {
        public ToolStripMenuItem MenuItemAutoStart { get; private set; }

        public ToolStripMenuItem MenuItemSettings { get; private set; }

        public ToolStripMenuItem MenuItemAbout { get; private set; }

        public ToolStripMenuItem MenuItemExit { get; private set; }

        public NotifyIcon Icon { get; private set; }

        public SystemTrayMenu()
        {
            MenuItemAutoStart = new ToolStripMenuItem();
            MenuItemAutoStart.Name = "miAutoStart";
            MenuItemAutoStart.Size = new Size(175, 22);
            MenuItemAutoStart.Text = "Auto start program";

            MenuItemSettings = new ToolStripMenuItem();
            MenuItemSettings.Name = "miSettings";
            MenuItemSettings.Size = new Size(175, 22);
            MenuItemSettings.Font = new Font(MenuItemSettings.Font.Name, MenuItemSettings.Font.Size, FontStyle.Bold);
            MenuItemSettings.Text = "Settings...";

            MenuItemAbout = new ToolStripMenuItem();
            MenuItemAbout.Name = "miAbout";
            MenuItemAbout.Size = new Size(175, 22);
            MenuItemAbout.Text = "About";

            var menuItemSeparator1 = new ToolStripSeparator();
            menuItemSeparator1.Name = "miSeparator1";
            menuItemSeparator1.Size = new Size(172, 6);

            var menuItemSeparator2 = new ToolStripSeparator();
            menuItemSeparator2.Name = "miSeparator2";
            menuItemSeparator2.Size = new Size(172, 6);

            MenuItemExit = new ToolStripMenuItem();
            MenuItemExit.Name = "miExit";
            MenuItemExit.Size = new Size(175, 22);
            MenuItemExit.Text = "Exit";

            var components = new System.ComponentModel.Container();
            var systemTrayMenu = new ContextMenuStrip(components);
            systemTrayMenu.Items.AddRange(new ToolStripItem[] { MenuItemAutoStart, menuItemSeparator1, MenuItemSettings, MenuItemAbout, menuItemSeparator2, MenuItemExit });
            systemTrayMenu.Name = "systemTrayMenu";
            systemTrayMenu.Size = new Size(176, 80);

            Icon = new NotifyIcon(components);
            Icon.ContextMenuStrip = systemTrayMenu;
            Icon.Icon = Properties.Resources.SmartSystemMenu;
            Icon.Text = AssemblyUtils.AssemblyTitle;
            Icon.Visible = true;
        }
    }
}