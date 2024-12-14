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
            // Root question
            Root = new DecisionTreeNode("Do you enjoy working with numbers?");

            // First level of questions
            var yesNode = new DecisionTreeNode("Do you like programming?");
            var noNode = new DecisionTreeNode("Do you prefer creative work?");

            Root.Children.Add("Yes", yesNode);
            Root.Children.Add("No", noNode);

            // Second level under "Yes"
            var logicalThinkingNode = new DecisionTreeNode("Do you enjoy logical thinking?");
            var teamWorkNode = new DecisionTreeNode("Do you enjoy teamwork?");

            yesNode.Children.Add("Yes", logicalThinkingNode);
            yesNode.Children.Add("No", teamWorkNode);

            // Third level under "teamWorkNode"
            var leadershipNode = new DecisionTreeNode("Do you enjoy taking leadership roles?");
            var collaborationNode = new DecisionTreeNode("Do you prefer collaborative environments?");

            teamWorkNode.Children.Add("Yes", leadershipNode);
            teamWorkNode.Children.Add("No", collaborationNode);

            // Fourth level under "leadershipNode"
            leadershipNode.Children.Add("Yes", new DecisionTreeNode("Team Leader"));
            leadershipNode.Children.Add("No", new DecisionTreeNode("Project Coordinator"));

            // Fourth level under "collaborationNode"
            collaborationNode.Children.Add("Yes", new DecisionTreeNode("Team Player"));
            collaborationNode.Children.Add("No", new DecisionTreeNode("Independent Contributor"));

            // Third level under "logicalThinkingNode"
            var problemSolvingNode = new DecisionTreeNode("Do you enjoy problem-solving?");
            var mathAnalysisNode = new DecisionTreeNode("Are you good at math analysis?");

            logicalThinkingNode.Children.Add("Yes", problemSolvingNode);
            logicalThinkingNode.Children.Add("No", mathAnalysisNode);

            // Fourth level under "problemSolvingNode"
            var deepAnalysisNode = new DecisionTreeNode("Do you enjoy deep analysis?");
            problemSolvingNode.Children.Add("Yes", deepAnalysisNode);
            problemSolvingNode.Children.Add("No", new DecisionTreeNode("Software Engineer"));

            deepAnalysisNode.Children.Add("Yes", new DecisionTreeNode("Data Scientist"));
            deepAnalysisNode.Children.Add("No", new DecisionTreeNode("System Analyst"));

            // Fourth level under "mathAnalysisNode"
            var mathTeachingNode = new DecisionTreeNode("Are you interested in teaching math?");
            mathAnalysisNode.Children.Add("Yes", mathTeachingNode);
            mathAnalysisNode.Children.Add("No", new DecisionTreeNode("Accountant"));

            mathTeachingNode.Children.Add("Yes", new DecisionTreeNode("Math Professor"));
            mathTeachingNode.Children.Add("No", new DecisionTreeNode("Actuary"));

            // Second level under "No"
            var visualArtsNode = new DecisionTreeNode("Do you like visual arts?");
            var writingNode = new DecisionTreeNode("Do you enjoy writing?");

            noNode.Children.Add("Yes", visualArtsNode);
            noNode.Children.Add("No", writingNode);

            // Third level under "visualArtsNode"
            var animationNode = new DecisionTreeNode("Do you like animation?");
            var photographyNode = new DecisionTreeNode("Do you enjoy photography?");

            visualArtsNode.Children.Add("Yes", animationNode);
            visualArtsNode.Children.Add("No", photographyNode);

            animationNode.Children.Add("Yes", new DecisionTreeNode("Animator"));
            animationNode.Children.Add("No", new DecisionTreeNode("UI/UX Designer"));

            photographyNode.Children.Add("Yes", new DecisionTreeNode("Photographer"));
            photographyNode.Children.Add("No", new DecisionTreeNode("Video Editor"));

            // Third level under "writingNode"
            var fictionNode = new DecisionTreeNode("Do you enjoy writing fiction?");
            var technicalNode = new DecisionTreeNode("Do you prefer technical writing?");

            writingNode.Children.Add("Yes", fictionNode);
            writingNode.Children.Add("No", technicalNode);

            fictionNode.Children.Add("Yes", new DecisionTreeNode("Novelist"));
            fictionNode.Children.Add("No", new DecisionTreeNode("Content Writer"));

            technicalNode.Children.Add("Yes", new DecisionTreeNode("Technical Writer"));
            technicalNode.Children.Add("No", new DecisionTreeNode("Editor"));

            // Additional intermediate questions to ensure 10+ steps
            var intermediateNode1 = new DecisionTreeNode("Do you enjoy working with people?");
            var intermediateNode2 = new DecisionTreeNode("Do you like solving puzzles?");
            var intermediateNode3 = new DecisionTreeNode("Do you enjoy leadership roles?");

            var intermediateNode4 = new DecisionTreeNode("Do you enjoy public speaking?");
            var intermediateNode5 = new DecisionTreeNode("Do you like designing?");

            Root.Children["Yes"].Children["Yes"].Children["Yes"].Children["Yes"] = intermediateNode1;
            intermediateNode1.Children.Add("Yes", intermediateNode3);
            intermediateNode1.Children.Add("No", intermediateNode2);

            intermediateNode2.Children.Add("Yes", new DecisionTreeNode("Cybersecurity Specialist"));
            intermediateNode2.Children.Add("No", new DecisionTreeNode("Network Administrator"));

            intermediateNode3.Children.Add("Yes", new DecisionTreeNode("Project Manager"));
            intermediateNode3.Children.Add("No", new DecisionTreeNode("Human Resources Specialist"));

            noNode.Children["Yes"].Children["Yes"] = intermediateNode4;
            intermediateNode4.Children.Add("Yes", new DecisionTreeNode("Marketing Specialist"));
            intermediateNode4.Children.Add("No", intermediateNode5);

            intermediateNode5.Children.Add("Yes", new DecisionTreeNode("Interior Designer"));
            intermediateNode5.Children.Add("No", new DecisionTreeNode("Event Planner"));

            // Additional extensions for wider paths
            var intermediateNode6 = new DecisionTreeNode("Do you like mentoring others?");
            var intermediateNode7 = new DecisionTreeNode("Do you enjoy creating detailed plans?");

            logicalThinkingNode.Children["Yes"] = intermediateNode6;
            intermediateNode6.Children.Add("Yes", new DecisionTreeNode("Consultant"));
            intermediateNode6.Children.Add("No", intermediateNode7);

            intermediateNode7.Children.Add("Yes", new DecisionTreeNode("Architect"));
            intermediateNode7.Children.Add("No", new DecisionTreeNode("Logistics Manager"));
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
