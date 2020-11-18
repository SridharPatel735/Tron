using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Tron
{
    public partial class HighScoreScreen : UserControl
    {
        List<Score> highScoreList = new List<Score>();
        public HighScoreScreen()
        {
            InitializeComponent();
        }

        private void HighScoreScreen_Enter(object sender, EventArgs e)
        {
            XmlReader reader = XmlReader.Create("Resources/HighScores.xml", null);


            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    string player1 = reader.ReadString();

                    reader.ReadToNextSibling("name2");
                    string player2 = reader.ReadString();

                    reader.ReadToFollowing("time");
                    string score = reader.ReadString();

                    Score s = new Score(player1, player2, score);
                    highScoreList.Add(s);
                }
            }
            highScoreList.RemoveAt(highScoreList.Count - 1);
            reader.Close();

            foreach(Score x in highScoreList)
            {
                highScoreLabel.Text = x.name1 + "  " + x.name2 + "  " + x.score + "\n";
            }
        }
    }
}
