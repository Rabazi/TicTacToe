using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MarkType[] markTypes;
        private bool Player1Turn;
        private bool GameEnd;
        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }

        private void NewGame()
        {
            markTypes = new MarkType[9];

            for (var i = 0; i < markTypes.Length; i++)
                markTypes[i] = MarkType.Free;
            Player1Turn = true;
            // Iterate every button
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {

            });
        }
    }
}
