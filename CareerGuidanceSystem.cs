using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance
{
    public class CareerGuidanceSystem
    {
        public DecisionTreeNode Root { get; private set; }
        private DecisionTreeNode currentNode;

        public CareerGuidanceSystem()
        {
            BuildTree();
            currentNode = Root;
        }

        private void BuildTree()
        {
            // Example tree setup
            Root = new DecisionTreeNode("Do you enjoy working with numbers?");

            var programmingNode = new DecisionTreeNode("Do you like programming?");
            programmingNode.CareerRecommendation = "Software Engineer";

            var creativeNode = new DecisionTreeNode("Do you prefer creative work?");
            creativeNode.CareerRecommendation = "Graphic Designer";

            Root.Children.Add("Yes", programmingNode);
            Root.Children.Add("No", creativeNode);
        }

        public string GetCurrentQuestion()
        {
            return currentNode.Question ?? $"Recommendation: {currentNode.CareerRecommendation}";
        }

        public void Navigate(string answer)
        {
            if (currentNode.Children.ContainsKey(answer))
            {
                currentNode = currentNode.Children[answer];
            }
        }

        public void Restart()
        {
            currentNode = Root;
        }
    }
}
