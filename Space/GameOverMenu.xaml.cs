﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Space
{
   /// <summary>
   /// Логика взаимодействия для GameOverMenu.xaml
   /// </summary>
   public partial class GameOverMenu : UserControl
   {
      public event EventHandler OnMainMenuClicked;

      public GameOverMenu()
      {
         InitializeComponent();
      }

      private void MainMenuClick(object sender, RoutedEventArgs e)
      {
         OnMainMenuClicked(sender, e);
      }
   }
}
