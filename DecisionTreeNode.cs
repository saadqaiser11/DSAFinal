using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance
{
    public class DecisionTreeNode
    {
        public string Question { get; set; }
        public Dictionary<string, DecisionTreeNode> Children { get; set; }
        public string CareerRecommendation { get; set; }

        public DecisionTreeNode(string question = null, string recommendation = null)
        {
            Question = question;
            CareerRecommendation = recommendation;
            Children = new Dictionary<string, DecisionTreeNode>();
        }
    }

}
