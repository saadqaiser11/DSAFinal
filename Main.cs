using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerGuidance
{
    public partial class Main : Form
    {
        private CareerGuidanceSystem careerGuidanceSystem;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            careerGuidanceSystem.Restart();
            UpdateUI();
            btnYes.Enabled = true;
            btnNo.Enabled = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            careerGuidanceSystem = new CareerGuidanceSystem();
            lblQuestion.Text = careerGuidanceSystem.GetCurrentQuestion();
        }
        private void UpdateUI()
        {
            lblQuestion.Text = careerGuidanceSystem.GetCurrentQuestion();

            // If the end of the tree is reached, disable buttons
            if (lblQuestion.Text.StartsWith("Recommendation"))
            {
                btnYes.Enabled = false;
                btnNo.Enabled = false;
            }
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            careerGuidanceSystem.Navigate("Yes");
            UpdateUI();
            panelGraph.Invalidate();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            careerGuidanceSystem.Navigate("No");
            UpdateUI();
            panelGraph.Invalidate();
        }
        private void PopulateTreeView()
        {
            treeViewDecisionTree.Nodes.Clear();
            var rootNode = new TreeNode("Start");
            treeViewDecisionTree.Nodes.Add(rootNode);

            AddNodesToTree(rootNode, careerGuidanceSystem.Root);
        }

        private void AddNodesToTree(TreeNode parent, DecisionTreeNode node)
        {
            if (node.Children.Count == 0)
            {
                parent.Nodes.Add(new TreeNode($"Recommendation: {node.CareerRecommendation}"));
                return;
            }

            foreach (var child in node.Children)
            {
                var childNode = new TreeNode($"{child.Key}: {child.Value.Question}");
                parent.Nodes.Add(childNode);
                AddNodesToTree(childNode, child.Value);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph(e.Graphics);
        }
        private void DrawGraph(Graphics g)
        {
            // Example graph drawing
            g.DrawEllipse(Pens.Black, 100, 50, 50, 50); // Node 1
            g.DrawString("Node 1", new Font("Arial", 10), Brushes.Black, 110, 65);

            g.DrawEllipse(Pens.Black, 200, 50, 50, 50); // Node 2
            g.DrawString("Node 2", new Font("Arial", 10), Brushes.Black, 210, 65);

            g.DrawLine(Pens.Black, 150, 75, 200, 75); // Connection between Node 1 and Node 2
        }


    }
}
